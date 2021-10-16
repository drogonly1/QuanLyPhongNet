using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using QuanLyPhongNet.DTO;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;
using QuanLyPhongNet.BUS;
using System.Windows.Forms;

namespace QuanLyPhongNet.BUS
{
    public class ServerManager
    {
        public IPEndPoint iP;
        public Socket socketServer;
        NetRoomWriter netRoomWriter;
        public List<InfoClient> arrClient;
        const int portCode = 9999;
        const int maxGetByte = 1024 * 5000;
        public static int refreshClient = -1;
        public const int change = -1;
        const int request = 0;
        const string wait = "WAITING";
        const string USING = "USING";
        public TimeSpan totalTime;

        public string acn = "";
        public String messagefrClient ="";
        public int requestmessage = 113;

        public ServerManager()
        {
            arrClient = new List<InfoClient>();
            iP = new IPEndPoint(IPAddress.Any, portCode);
            socketServer = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            socketServer.Bind(iP);
            Thread OkeFine = new Thread(StartAceptClient);
            OkeFine.IsBackground = true;
            OkeFine.Start();
        }
        public void StartAceptClient()
        {
            try
            {
                while (true)
                {
                    socketServer.Listen(100);
                    Socket newClient = socketServer.Accept();
                    Thread listenClient = new Thread(ReceiveDataFromClient);
                    listenClient.IsBackground = true;
                    listenClient.Start(newClient);
                }

            }
            catch
            {

            }
        }
        public void ReceiveDataFromClient(object obj)
        {
            Socket currentClient = obj as Socket;
            try
            {
                while (true)
                {
                    byte[] messegeFromClient = new byte[1024 * 5000];
                    currentClient.Receive(messegeFromClient);
                    string messege = (string)CovertToMessege(messegeFromClient);
                    List<string> lstMessege = messege.Split('|').ToList();
                    if (lstMessege[request].Equals("ConnectWithMePls!!"))
                    {
                        arrClient.Add(
                        new InfoClient()
                        {
                            stateClient = wait,
                            client = currentClient,
                            nameClient = lstMessege[1]
                        });
                        refreshClient = change;
                    }
                    if (lstMessege[request].Equals("AllowToLogInPls!!"))
                    {
                        if (CheckLogin(lstMessege[1], lstMessege[2]))
                        {
                            currentClient.Send(ConvertToByte("OkePlayGo|" + lstMessege[1] + "|" + totalTime + "|"));
                            ChangeStateClient(currentClient, "MEMBER USING", lstMessege[1]);
                        }
                        else
                        {
                            currentClient.Send(ConvertToByte("Acount not exist !! Or Wrong Username, Password"));
                            ChangeStateClient(currentClient, "WAITING", lstMessege[1]);
                        }

                    }
                    if (lstMessege[request].Equals("LogOutPls!!"))
                    {
                        UpdateRemainTime(lstMessege[1], TimeSpan.Parse(lstMessege[2]));
                        ChangeStateClient(currentClient, "WAITING", lstMessege[1]);
                    }
                    if (lstMessege[request].Equals("messagetosv"))
                    {
                        messagefrClient = lstMessege[1];
                        requestmessage = 114;
                    }
                }

            }
            catch
            {

            }

        }
        public void UpdateRemainTime(string userName, TimeSpan remainTime)
        {
            userName = userName.ToUpper();
            List<Member> lstMember = new NetRoomReader().GetAllMembers();

            foreach (Member m in lstMember)
            {
                m.AccountName = m.AccountName.ToUpper();
                if (m.AccountName.Equals(userName))
                {
                    float money = m.CurrentMoney - ChangeUseTimeToMinutes(remainTime.ToString()) * 100;
                    new NetRoomWriter().UpdateMember(m.AccountName, m.Password, m.GroupUserName, remainTime, money, m.Status);
                }
            }
        }

        private bool CheckLogin(string userName, string pass)
        {
            userName = userName.ToUpper();
            List<Member> lstMember = new NetRoomReader().GetAllMembers();
            foreach (Member m in lstMember)
            {
                m.AccountName = m.AccountName.ToUpper();
                if (m.AccountName.Equals(userName) && m.Password.Equals(pass))
                {
                    if (ChangeUseTimeToMinutes(m.TimeInAccount.ToString()) > 0)
                    {
                        totalTime = m.TimeInAccount;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return false;
        }

        public void ChangeStateClient(Socket client, string state, string userName)
        {
            foreach (InfoClient cli in arrClient)
            {
                if (cli.client == client)
                {
                    cli.stateClient = state;
                    cli.nameCustomer = userName;
                }
            }
        }


        //guess Manager
        public InfoClient GetInfoClient(string nameClient, string statut)
        {
            foreach(InfoClient infoClient in arrClient)
            {
                if (infoClient.nameClient.Equals(nameClient) && infoClient.stateClient.Equals(statut))
                    return infoClient;
            }
            return null;
        }

        public bool loginWithGuess(string nameGuess)
        {
            InfoClient infoClient = GetInfoClient(nameGuess, wait);
            if (infoClient == null)
                return false;
            else
            {
                try
                {
                    infoClient.client.Send(ConvertToByte("GuessLogin!!!"));
                    infoClient.startTime = DateTime.Now;
                    infoClient.stateClient = USING;
                    return true;
                }
                catch { return false; }
            }
        }
        public float guessPayment(string nameClient)
        {
            try
            {
                float total = 0;
                int priceforminute = 50;
                string useTime;
                InfoClient infoClient = GetInfoClient(nameClient, USING);
                infoClient.stateClient = "WAITING";
                if (infoClient == null)
                return 0;
                infoClient.client.Send(ConvertToByte("PAYMENT"));
                
                useTime = DateTime.Now.Subtract(infoClient.startTime).ToString();
                int useMinute = ChangeUseTimeToMinutes(useTime);
                if(useMinute < 21)
                    total = 2000;
                else
                    total = total + useMinute * priceforminute;
                return total;
            }
            catch
            {
                return 0;
            }
        }
        public void LockClient(int index)
        {
            InfoClient client = arrClient[index];
            client.stateClient = "WAITING";
            client.client.Send(ConvertToByte("LockClient"));
        }


        //Chuyển đổi
        private int ChangeUseTimeToMinutes(String useTime)
        {
            int minutes = 0;
            string[] arrListStr = useTime.Split(':');
            if (int.Parse(arrListStr[1]) > 0)
            {
                minutes = minutes + int.Parse(arrListStr[1]);
            }
            if (int.Parse(arrListStr[0]) > 0)
            {
                minutes = minutes + int.Parse(arrListStr[0]) * 60;
            }
            return minutes;
        }
        //Xử lý với Db
        public void deleteMember(string username)
        {
            try
            {
                List<Member> lstMember = new NetRoomReader().GetAllMembers();
                foreach (Member member in lstMember)
                {
                    if (member.AccountName.ToUpper() == username.ToUpper())
                        NetRoomWriter.Intance.DeleteMember(username);
                }
                MessageBox.Show("Account: " + username + "đã được xóa!!!");
            }
            catch { return; }
            
        }
        //
        //public InfoClient sendInfoClient(string nameClient)
        //{
        //    InfoClient infoClient = null;
        //    List<InfoClient> infoClients = arrClient;
        //    foreach (InfoClient info in infoClients)
        //        if (info.nameClient.ToUpper() == nameClient.ToUpper())
        //            infoClient = info;
        //    return infoClient;
        //}
        public void sendInfoClient(string accout)
        {
            List<InfoClient> lstMember = arrClient;
            foreach (InfoClient member in lstMember)
            {
                if (member.nameClient.ToUpper() == accout.ToUpper())
                {
                    acn = member.nameClient;
                }
            }
        }
        public void sendMessage(string accout, string message)
        {
            List<InfoClient> lstMember = arrClient;
            foreach (InfoClient member in lstMember)
            {
                if (member.nameClient.ToUpper() == accout.ToUpper())
                {
                    member.client.Send(ConvertToByte("messagetoclient|"+message+"|"));
                }
            }
        }

        //ConvertToByte && CovertToMessege
        byte[] ConvertToByte(object obj)
        {
            MemoryStream memoryStream = new MemoryStream();
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            binaryFormatter.Serialize(memoryStream, obj);
            return memoryStream.ToArray();
        }
        object CovertToMessege(byte[] messege)
        {
            MemoryStream memoryStream = new MemoryStream(messege);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            return binaryFormatter.Deserialize(memoryStream);
        }
    }
}
