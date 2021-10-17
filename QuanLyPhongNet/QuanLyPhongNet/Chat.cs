using QuanLyPhongNet.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyPhongNet
{
    
    public partial class Chat : Form
    {
        ServerManager serverManager1;
        public Chat(ServerManager serverManager)
        {
            InitializeComponent();
            serverManager1 = serverManager;   
        }
        private void button_send_cbat_Click(object sender, EventArgs e)
        {
            string account = serverManager1.acn;
            string message = textBox_Message.Text;
            serverManager1.sendMessage(account, message);
            txtContent.Text = String.Join(Environment.NewLine, txtContent.Text, "Server: " + textBox_Message.Text);
            textBox_Message.Text = "";
        }
        private void timerContent_Tick(object sender, EventArgs e)
        {
            if (serverManager1.requestmessage == 114)
            {
                txtContent.Text = String.Join(Environment.NewLine, txtContent.Text, "Client: " + serverManager1.messagefrClient);
                serverManager1.requestmessage = 113;
            }

        }

    }
}
