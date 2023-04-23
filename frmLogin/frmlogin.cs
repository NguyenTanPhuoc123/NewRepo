using frmLogin.Data_Access_Layer;
using frmLogin.Data_Tranfer_Object;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

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
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbDisplay_Click(object sender, EventArgs e)
        {
            pbHide.BringToFront();
            txtPassword.UseSystemPasswordChar= false;
            txtPassword.PasswordChar = '\0';
        }

        private void pbHide_Click(object sender, EventArgs e)
        {
           pbDisplay.BringToFront();
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.PasswordChar = '●';
        }

        

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            
            if(AccountBUS.Instance.CheckLogin(txtUsername.Text, txtPassword.Text))
            {
                DTO.Account loginAccount = AccountBUS.Instance.GetAccountForUsername(txtUsername.Text);
                frmSellManagement login = new frmSellManagement(loginAccount);
                this.Hide();
                login.ShowDialog();
                txtPassword.Clear();
                this.Show();
            }
            else
            {
                MessageBox.Show("Dữ liệu không hợp lệ", "Thông báo");
            }
        }

        private void btnLogOff_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
