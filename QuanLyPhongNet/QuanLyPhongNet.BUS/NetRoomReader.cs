namespace QuanLyPhongNet.BUS
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using QuanLyPhongNet.DAO;

    public class NetRoomReader
    {
        private ProcessMember memberObjectReader;
        private ProcessClient clientObjectReader;
        private static NetRoomReader instance;
        public static NetRoomReader Intance
        {
            get
            {
                if (instance == null)
                    instance = new NetRoomReader();
                return instance;
            }
        }
        public NetRoomReader()
        {
            memberObjectReader = new ProcessMember();
            clientObjectReader = new ProcessClient();
        }
        public List<QuanLyPhongNet.DTO.Member> GetAllMembers()
        {
            return memberObjectReader.LoadAllMembers();
        }
        public List<QuanLyPhongNet.DTO.Client> GetAllClients()
        {
            return clientObjectReader.LoadAllClients();
        }
    }
}
