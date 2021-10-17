using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Client
{
    public partial class Chat : Form
    {
        ClientManager clientManager1;
        public Chat(ClientManager clientManager)
        {
            clientManager1 = clientManager;
            InitializeComponent();
        }

        private void button_send_cbat_Click(object sender, EventArgs e)
        {
            clientManager1.sendMessage(textBox_Message.Text);
            txtContent.Text = String.Join(Environment.NewLine, txtContent.Text, "Client: " + textBox_Message.Text);
            textBox_Message.Text = "";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (clientManager1.requestmessage == 114)
            {
                txtContent.Text = String.Join(Environment.NewLine, txtContent.Text, "Server: " + clientManager1.messagefrmsv);
                clientManager1.requestmessage = 113;
            }
        }
    }
}
