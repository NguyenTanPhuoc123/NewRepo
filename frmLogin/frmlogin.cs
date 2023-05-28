
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace frmLogin
{
   
    public partial class frmlogin : Form
    {
        HashCode info = new HashCode();
        public static int Language = 0; 
        public static string username;
        public frmlogin()
        {
            InitializeComponent();
        }

        public static string GetUsername()
        {
            return username;
        }

        public static void SetUsername(string value)
        {
            username = value;
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
            txtPassword.PasswordChar = info.passwordCharNull;
        }

        private void pbHide_Click(object sender, EventArgs e)
        {
           pbDisplay.BringToFront();
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.PasswordChar = info.passwordChar;
        }

        

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            SetUsername(txtUsername.Text);
            if (Language == info.valueDefault)
            {
                if (string.IsNullOrEmpty(txtUsername.Text.Trim()) || string.IsNullOrEmpty(txtPassword.Text.Trim()))
                {
                    MessageBox.Show(info.eventNullVi,info.titleMessageVi, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (AccountBUS.Instance.CheckLogin(txtUsername.Text, txtPassword.Text))
                {
                    Account loginAccount = AccountBUS.Instance.GetAccountForUsername(txtUsername.Text);
                    frmSellManagement login = new frmSellManagement(loginAccount);
                    this.Hide();
                    login.ShowDialog();
                    txtPassword.Clear();
                    this.Show();
                }
                else
                {
                    MessageBox.Show(info.checkLoginVi,info.titleMessageVi,MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
            }
            else
            {
                if (string.IsNullOrEmpty(txtUsername.Text.Trim()) || string.IsNullOrEmpty(txtPassword.Text.Trim()))
                {
                    MessageBox.Show(info.eventNullEn,info.titleMessageEn, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (AccountBUS.Instance.CheckLogin(txtUsername.Text, txtPassword.Text))
                {
                    Account loginAccount = AccountBUS.Instance.GetAccountForUsername(txtUsername.Text);
                    frmSellManagement login = new frmSellManagement(loginAccount);
                    this.Hide();
                    login.ShowDialog();
                    txtPassword.Clear();
                    this.Show();
                }
                else
                {
                    MessageBox.Show(info.checkLoginEn,info.titleMessageEn, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            
        }

        private void btnLogOff_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void frmlogin_Load(object sender, EventArgs e)
        {
            this.Controls.Clear();
            if (Language == 0)
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("vi");
            else
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en");
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("vi");
            this.Controls.Clear();
            InitializeComponent();
            Language = info.valueDefault;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en");
            this.Controls.Clear();
            InitializeComponent();
            Language = info.count;
        }
    }
}
