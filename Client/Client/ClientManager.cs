using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace Client
{
    class ClientManager
    {
        IPEndPoint iP;
        public Socket client;
        int portCode = 9999;
        const int maxGetByte = 1024 * 4000;
        public static int refreshClient = -1;
        public const int change = -1;
        const int request = 0;
        public static int requestServer = -1;
        const int USECLIENT = 101;
        public const int MEMBERLOGIN = 102;
        public const int PAYMENT = 103;
        public ClientLogin lockScreen;
        public string userName = "";
        public string message = "";
        public TimeSpan totalTime;

        public void Login(string username, string password)
        {
            client.Send(ConvertToByte("LoginRepuest!!!|" + username + "|" + password + "|"));
        }

        public void Logout(string username, TimeSpan remainTime)
        {
            client.Send(ConvertToByte("LogoutRepuest!!!|" + username + "|" + remainTime.ToString() + "|"));
        }

        byte[] ConvertToByte(object obj)
        {
            MemoryStream memoryStream = new MemoryStream();
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            binaryFormatter.Serialize(memoryStream, obj);
            return memoryStream.ToArray();
        }
        object ConvertToMesseage(byte[] message)
        {
            MemoryStream memoryStream = new MemoryStream();
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            return binaryFormatter.Deserialize(memoryStream);
        }

    }
}
