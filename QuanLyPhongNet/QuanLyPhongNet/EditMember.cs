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
    public partial class EditMember : Form
    {
        public EditMember()
        {
            InitializeComponent();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            ServerHandle.Intance.updateMember(txtAccount.Text, txtPass.Text, comboBox1.SelectedItem.ToString(), txtMoney.Text);
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditMember_Load(object sender, EventArgs e)
        {
            txtAccount.Text = ServerHandle.Intance.acn;
            txtPass.Text = ServerHandle.Intance.pw;
            comboBox1.SelectedItem = ServerHandle.Intance.gro;
            txtMoney.Text = ServerHandle.Intance.mn.ToString();
            if (ServerHandle.Intance.mn == 0)
                txtTime.Text = "00:00:00";
            else
                txtTime.Text = ServerHandle.Intance.ChangeMoneyToTime(ServerHandle.Intance.mn).ToString();
        }

        private void txtMoney_TextChanged(object sender, EventArgs e)
        {

            if (txtMoney.Text == null || txtMoney.Text == "")
            {
                txtTime.Text = "00:00:00";
                return;
            }
            if (txtMoney.Text == "0")
                txtTime.Text = "00:00:00";
            if (float.Parse(txtMoney.Text) > 2000)
                txtTime.Text = ServerHandle.Intance.ChangeMoneyToTime(float.Parse(txtMoney.Text)).ToString();
        }
    }
}
