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
using QuanLyPhongNet.DTO;
namespace QuanLyPhongNet
{
    public partial class AddMember : Form
    {
        ServerHandle serverHandle;
        public AddMember()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ServerHandle.Intance.addMember(txtName.Text, txtPass.Text, txtMoney.Text);
            this.Close();
        }

        private void txtMoney_TextChanged(object sender, EventArgs e)
        {

            if (txtMoney.Text == null || txtMoney.Text == "")
            {
                txtTime.Text = "00:00:00";
                return;
            }
            if (float.Parse(txtMoney.Text)>2000)
                txtTime.Text = ServerHandle.Intance.ChangeMoneyToTime(float.Parse(txtMoney.Text)).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddMember_Load(object sender, EventArgs e)
        {
            txtTime.Text = "00:00:00";
            txtTime.Select();
        }
    }
}
