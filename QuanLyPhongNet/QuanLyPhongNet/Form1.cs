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
    public partial class Form1 : Form
    {
        ServerManager serverManager;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string account = serverManager.acn;
            string message = txtMessage.Text;
            serverManager.sendMessage(account, message);
        }
    }
}
