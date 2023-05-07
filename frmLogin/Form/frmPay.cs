using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;

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

        int TableID = frmSellManagement.GetTableID();
        string BillID = BillBUS.Instance.HDID(frmSellManagement.GetTableID());
        int EmployeeID = frmSellManagement.GetMANV();
        float Total = frmSellManagement.GetTotal();
        string EmployeeName = frmSellManagement.GetTENNV();

        private void txtMoneyPay_TextChanged(object sender, EventArgs e)
        {
            lblMoneyReceive.Text = txtMoneyPay.Text;
            //lblMoneyPay.Text = (Convert.ToInt32(lblMoneyReceive.Text) - Convert.ToInt32(lblTotal.Text)).ToString();
        }

        private void frmPay_Load(object sender, EventArgs e)
        {
            txtBillID.Text = BillID.ToString();
            txtEmployeeID.Text = EmployeeID.ToString();
            txtEmployeeName.Text = EmployeeName;
            dtpDateBill.Text = DateTime.Now.ToString();
            lblTotal.Text = Total.ToString();
            dtgvBill.DataSource = BillInfoMenuBUS.Instance.GetListBillInfoMenu(BillID);
        }
    }
}
