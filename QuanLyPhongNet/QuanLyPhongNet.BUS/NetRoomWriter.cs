namespace QuanLyPhongNet.BUS
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using QuanLyPhongNet.DTO;
    using QuanLyPhongNet.DAO;

    public class NetRoomWriter
    {
        private static NetRoomWriter instance;
        public static NetRoomWriter Intance
        {
            get
            {
                if (instance == null)
                    instance = new NetRoomWriter();
                return instance;
            }
        }
        private ProcessMember memberObjectWriter;

        public NetRoomWriter()
        {
            memberObjectWriter = new ProcessMember();
        }
        //Member
        public void InsertMember(string account, string pass, string groupUser, TimeSpan time, float money, string status)
        {
            memberObjectWriter.InsertMember(account, pass, groupUser, time, money, status);
        }
        public void UpdateMember(int memberID, string account, string pass, string groupUser, TimeSpan time, float money, string status)
        {
            memberObjectWriter.UpdateMember(memberID, account, pass, groupUser, time, money, status);
        }
    }
}
