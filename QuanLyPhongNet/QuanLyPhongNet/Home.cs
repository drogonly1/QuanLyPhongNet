using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyPhongNet.BUS;

namespace QuanLyPhongNet
{
    public partial class Home : Form
    {
        ServerManager serverManager;
        private NetRoomReader objReader;
        private NetRoomWriter objWriter;
        private int index = 0;
        public Home()
        {
            serverManager = new ServerManager();
            CheckForIllegalCrossThreadCalls = false;
            objReader = new NetRoomReader();
            objWriter = new NetRoomWriter();
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            this.Location = new Point(0, 0);
            LoadSourceToDGV();
        }
        private void LoadSourceToDGV()
        {
            drgvMember.DataSource = objReader.GetAllMembers();
            drgvMember.Columns[0].HeaderText = "Tên Tài Khoản";
            drgvMember.Columns[1].HeaderText = "Mật Khẩu";
            drgvMember.Columns[2].HeaderText = "Thuộc Nhóm";
            drgvMember.Columns[3].HeaderText = "Thời Gian Hiện Có";
            drgvMember.Columns[4].HeaderText = "Số Tiền Hiện Có";
            drgvMember.Columns[5].HeaderText = "Trạng Thái";
           
            drgvClient.DataSource = objReader.GetAllClients();
            drgvClient.Refresh();
        }

        public void LoadClient()
        {
            drgvClient.DataSource = (from client in serverManager.arrClient select new { ComputerName = client.nameClient, State = client.stateClient, StartTime = client.startTime }).ToArray();
        }

        private void timerProgam_Tick(object sender, EventArgs e)
        {
            if (ServerManager.refreshClient != serverManager.arrClient.Count)
            {

                ServerManager.refreshClient = serverManager.arrClient.Count;
                LoadClient();
            }
            LoadClient();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (ServerManager.refreshClient != serverManager.arrClient.Count)
            {

                ServerManager.refreshClient = serverManager.arrClient.Count;
                LoadClient();
            }
            LoadClient();
        }

        private void drgvClient_MouseHover(object sender, EventArgs e)
        {
            if (ServerManager.refreshClient != serverManager.arrClient.Count)
            {

                ServerManager.refreshClient = serverManager.arrClient.Count;
                LoadClient();
            }
            LoadClient();
        }

        private void drgvMember_MouseHover(object sender, EventArgs e)
        {
           drgvMember.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            serverManager.loginWithGuess(serverManager.arrClient[index].nameClient);
            LoadClient();
            index = 0;
        }

        private void drgvClient_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                index = drgvClient.Rows[e.RowIndex].Index;
            }
            catch (Exception) {}
        }
        //Tính Tiền
        private void button2_Click(object sender, EventArgs e)
        {
            float total = serverManager.guessPayment(serverManager.arrClient[index].nameClient);
            MessageBox.Show("Tên máy: "+ serverManager.arrClient[index].nameClient
                            +"\n"+
                            "Tiền: " + total,
                            "Thanh Toán");
            LoadClient();
            index = 0;
        }
        //Tắt máy
        private void button4_Click(object sender, EventArgs e)
        {
            serverManager.LockClient(index);
            LoadClient();
            index = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            serverManager.LockClient(index);
            LoadClient();
            index = 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddMember frAddMember = new AddMember();
            frAddMember.ShowDialog();
        }
        
    }
}
