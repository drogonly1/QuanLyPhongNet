using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class ClientLogin : Form
    {
        ClientManager clientManager;
        public ClientLogin()
        {
            InitializeComponent();
            this.BackColor = Color.Black;
            this.CausesValidation = false;
            this.StartPosition = FormStartPosition.Manual;
            this.WindowState = FormWindowState.Maximized;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ShowInTaskbar = false;
            this.TopMost = true;
            timer1.Interval = 1;
            timer1.Enabled = true;
        }

        private void ClientFormClosingEventHandler(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }

        private void ClientLogin_Load(object sender, EventArgs e)
        {
            this.TopMost = true;    
            this.WindowState = FormWindowState.Maximized;

        }

        protected override bool ProcessDialogKey(System.Windows.Forms.Keys keyData)
        {
            switch ((keyData))
            {
                case Keys.Control:
                    {
                        return true;
                    }

                case Keys.Alt | Keys.F4:
                    {
                        return true;
                    }

                case Keys.Alt | Keys.Control | Keys.Delete:
                    {
                        return true;
                    }

                case Keys.Control | Keys.Q:
                    {
                        return true;
                    }
            }
            return base.ProcessDialogKey(keyData);
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            string username = txtUsername.Text.ToString();
            string password = txtPassword.Text.ToString();
            clientManager.Login(username, password);
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.TopMost = false;
            this.Close();
        }
    }
}
