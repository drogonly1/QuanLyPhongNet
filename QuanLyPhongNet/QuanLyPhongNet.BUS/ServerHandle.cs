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
    public class ServerHandle
    {
        NetRoomReader netRoomReader = new NetRoomReader();
        NetRoomWriter netRoomWriter;
        public string acn = "";
        public string pw = "";
        public string gro = "";
        TimeSpan tm;
        public float mn = 0;
        private static ServerHandle instance;
        public static ServerHandle Intance
        {
            get
            {
                if (instance == null)
                    instance = new ServerHandle();
                return instance;
            }
        }
        public void addMember(string username, string password, string money)
        {
            int compare = -1;
            List<DTO.Member> lstMember = netRoomReader.GetAllMembers();
            foreach (DTO.Member m in lstMember)
            {
                if (m.AccountName.ToUpper() == username.ToUpper())
                {
                    compare = 0;
                }
            }
            if (username == "" || password == "")
                MessageBox.Show("tài khoản, mật khẩu không được để trống", "thông báo");
            if (compare == 0)
            {
                MessageBox.Show("tài khoản đã tồn tại", "thông báo");
            }
            else
            {
                NetRoomWriter.Intance.InsertMember(username, password, "Hội Viên", ChangeMoneyToTime(float.Parse(money)), float.Parse(money), "Cho Phép");
                MessageBox.Show("thêm tài khoản thành công\nVui lòng nhấn tải lại để cập nhập.", "thông báo");
            }
        }
        public void updateMember(string username, string password, string groupuser,string money)
        {
            List<DTO.Member> lstMember = netRoomReader.GetAllMembers();
            foreach (DTO.Member m in lstMember)
            {
                if (m.AccountName.ToUpper() == username.ToUpper() && float.Parse(money) > 0)
                {
                    NetRoomWriter.Intance.UpdateMember(username, password, groupuser, ChangeMoneyToTime(float.Parse(money)), float.Parse(money), "Cho Phép");
                }
                if (m.AccountName.ToUpper() == username.ToUpper() && float.Parse(money) <= 0)
                {
                    NetRoomWriter.Intance.UpdateMember(username, password, groupuser, ChangeMoneyToTime(float.Parse(money)), float.Parse(money), "Hết Thời Gian");
                }
            }
            MessageBox.Show("Cập nhật tài khoản thành công\nVui lòng nhấn tải lại để cập nhập.");
        }

        //
        public void sendMember(string accout)
        {
            List<Member> lstMember = NetRoomReader.Intance.GetAllMembers();
            foreach(Member member in lstMember)
            {
                if(member.AccountName.ToUpper() == accout.ToUpper())
                {
                    acn = member.AccountName;
                    gro = member.GroupUserName;
                    pw = member.Password;
                    mn = member.CurrentMoney;
                }
            }
        }
        
        //Change money to time
        public TimeSpan ChangeMoneyToTime(float money)
        {
            if(money == 0)
            {
                TimeSpan time1;
                string span1 = "00:00:00";
                time1 = new TimeSpan(int.Parse(span1.Split(':')[0]),    // hours
                                            int.Parse(span1.Split(':')[1]),    // minutes
                                            0); ;                             // seconds
                return time1;
            }
            TimeSpan time;
            int hour = 0;
            int minutes = (int)money / 50;
            while (minutes < 60)
            {
                hour++;
                minutes = minutes - 60;
            }
            string span = hour + ":" + minutes + ":" + "00";
            time = new TimeSpan(int.Parse(span.Split(':')[0]),    // hours
                                        int.Parse(span.Split(':')[1]),    // minutes
                                        0); ;                             // seconds
            return time;
        }
        

    }
}
