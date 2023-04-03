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
    public partial class frmSetting : Form
    {
        public frmSetting()
        {
            InitializeComponent();
            grpChangePassword.Visible = false;
            cbLanguage.SelectedIndex = 0;
            cbSizeDisplay.SelectedIndex = 1;
        }

    

        private void btnExitFormSetting_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            grpChangePassword.Visible = true;
            grpAccountDetail.Visible = false;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            grpChangePassword.Visible = false;
            grpAccountDetail.Visible = true;
        }

        private void btnLogOff_Click(object sender, EventArgs e)
        {
            frmSellManagement frmSell = new frmSellManagement();
            frmlogin frmLogin = new frmlogin();
            this.Close();
            frmSell.Close();
            frmLogin.Show();
        }
    }
}
