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
    public partial class frmPay : Form
    {
        public frmPay()
        {
            InitializeComponent();
        }

        private void btnExitFomPay_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtMoneyPay_TextChanged(object sender, EventArgs e)
        {
            lblMoneyReceive.Text = txtMoneyPay.Text;
            //lblMoneyPay.Text = (Convert.ToInt32(lblMoneyReceive.Text) - Convert.ToInt32(lblTotal.Text)).ToString();
        }
    }
}
