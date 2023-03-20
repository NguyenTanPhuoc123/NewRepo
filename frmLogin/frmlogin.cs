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
            if (MessageBox.Show("Bạn muốn thoát  này?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK)
                e.Cancel = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                lblWarning.Text ="Vui lòng nhập đầy đủ thông tin đăng nhập";
                return;
            }
            frmQuanLyAdmin login = new frmQuanLyAdmin();
            this.Hide();
            login.ShowDialog();
            
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            if(txtPassword.PasswordChar == '\0')
            {
                btnDisplay.BringToFront();
                txtPassword.PasswordChar = '*';
            }
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            if(txtPassword.PasswordChar == '*')
            {
                btnHide.BringToFront();
                txtPassword.PasswordChar = '\0';
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
