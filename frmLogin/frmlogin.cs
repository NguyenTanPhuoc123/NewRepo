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
            btnDisplay.BringToFront();
            txtPassword.UseSystemPasswordChar = true;
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            btnHide.BringToFront();
            txtPassword.UseSystemPasswordChar = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
