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
    public partial class Timing : Form
    {
        ClientManager clientManager;
        const int USECLIENT = 101;
        const int MEMBERLOGIN = 102;
        const int PAYMENT = 103;
        Client lockScreen;
        int hour = 0;
        int min = 0;
        int sec = 0;
        double money = 0;
        TimeSpan total;
        TimeSpan use;
        TimeSpan remain;
        string userName = "";
        private int sendms = 0;
        public Timing()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            clientManager = new ClientManager();
            timerProgram.Interval = 1000;
            timerProgram.Enabled = true;
            timerProgram.Start();
            panel1.Visible = false;
        }

        private void timerProgram_Tick(object sender, EventArgs e)
        {
            if (ClientManager.requestServer == USECLIENT)
            {
                lblUserName.Text = "UserName: Customer";
                txtTotalTime.Text = "Unlimited";
                txtRemainTime.Text = "Unlimited";
                ClientManager.requestServer = -1;
                min = 0;
                ResetTime();
            }

            else if (ClientManager.requestServer == MEMBERLOGIN)
            {
                lblUserName.Text = "UserName: " + clientManager.userName;
                userName = clientManager.userName;
                txtTotalTime.Text = clientManager.totalTime.ToString();
                ClientManager.requestServer = -2;
                min = 0;
                ResetTime();
            }

            else if (ClientManager.requestServer == ClientManager.PAYMENT)
            {
                ResetTime();
            }

            TimeCount();
            if (ClientManager.requestServer == -2)
            {
                total = TimeSpan.Parse(txtTotalTime.Text.ToString());
                use = TimeSpan.Parse(txtUseTime.Text.ToString());
                remain = total - use;
                txtRemainTime.Text = remain.ToString();
                txtUseTimeFee.Text = "0";
            }

            MoneyCount(txtUseTime.Text.ToString());
            if (ClientManager.refreshClient == MEMBERLOGIN)
            {
                TimeSpan useTime = TimeSpan.Parse(txtUseTime.Text.ToString());
                TimeSpan totalTime = TimeSpan.Parse(txtTotalTime.Text.ToString());
                if (useTime > totalTime)
                {
                    lockScreen.Show();
                }

            }
            if( clientManager.requestmessage == 114)
            {
                txtContent.Text = String.Join(Environment.NewLine, txtContent.Text, "Server: " + clientManager.messagefrmsv);
                clientManager.requestmessage = 113;
            }
                
        }
        private void TimeCount()
        {
            txtUseTime.Text = hour.ToString("D2") + ":" + min.ToString("D2") + ":" + sec.ToString("D2");
            sec++;
            if (sec > 60)
            {
                min++;
                sec = 00;
            }

            if (min > 60)
            {
                hour++;
                min = 00;
            }

            if (hour > 99)
            {
                timerProgram.Stop();
                timerProgram.Enabled = true;
            }

        }
        private int ChangeUseTimeToMinutes(String useTime)
        {
            int minutes = 0;
            string[] arrListStr = useTime.Split(':');
            if (int.Parse(arrListStr[1]) > 0)
            {
                minutes = minutes + int.Parse(arrListStr[1]);
            }

            if (int.Parse(arrListStr[0]) > 0)
            {
                minutes = minutes + int.Parse(arrListStr[0]) * 60;
            }

            return minutes;
        }
        private void MoneyCount(String useTime)
        {
            int time = ChangeUseTimeToMinutes(useTime);
            txtUseTimeFee.Text = money.ToString();
            if (time < 20)
            {
                money = 2000;
            }

            else
                money = money + 1.5;
        }
        private void ResetTime()
        {
            min = 0;
            sec = 0;
            hour = 0;
            money = 0;
        }

        private void Timing_Load(object sender, EventArgs e)
        {

        }

        private void Timing_FormClosing(object sender, FormClosingEventArgs e)
        {
            clientManager.LogoutMember(clientManager.userName, remain);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clientManager.sendMessage(txtMessage.Text);
            txtContent.Text = String.Join(Environment.NewLine, txtContent.Text, "Client: " + txtMessage.Text);
            txtMessage.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (panel1.Visible == true)
            {
                panel1.Visible = false;
            }
            else
                panel1.Visible = true;
        }
    }
}
