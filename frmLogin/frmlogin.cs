using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmLogin
{
   
    public partial class frmlogin : Form
    {
        public frmlogin()
        {
            InitializeComponent();
        }


        private void frmlogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát khỏi phần mềm này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                e.Cancel = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbDisplay_Click(object sender, EventArgs e)
        {
            pbHide.BringToFront();
            txtPassword.UseSystemPasswordChar = false;
        }

        private void pbHide_Click(object sender, EventArgs e)
        {
           pbDisplay.BringToFront();
            txtPassword.UseSystemPasswordChar = true;
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            frmSellManagement login = new frmSellManagement();
            this.Hide();
            login.ShowDialog();
        }

        private void btnLogOff_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
