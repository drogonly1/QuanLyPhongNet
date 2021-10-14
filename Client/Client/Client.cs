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
    public partial class Client : Form
    {
        ClientManager clientManager;

        private static Client instance;
        public static Client Instance
        {
            get
            {
                if (instance == null)
                    instance = new Client();
                return instance;
            }
            set
            {
                instance = value;
            }
        }
        public Client()
        {
            InitializeComponent();

        }
        public Client(ClientManager x)
        {
            this.clientManager = x;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userName = textBox1.Text.ToString();
            string passWord = textBox2.Text.ToString();
            clientManager.Login(userName, passWord);
            if (clientManager.message.Equals("Acount not exist !! Or Wrong Username, Password"))
            {
                MessageBox.Show("Acount not exist !! Or Wrong Username, Password. Or Your Account is exhauted");
            }
        }

        private void Client_Load(object sender, EventArgs e)
        {

        }

        private void Client_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }
    }
}
