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
using Microsoft.Reporting.WinForms;

namespace frmLogin
{
    public partial class frmOutputBill : Form
    {
        frmPay frm;
        public frmOutputBill(frmPay pay)
        {
            InitializeComponent();
            frm = pay;
        }

        private void frmOutputBill_Load(object sender, EventArgs e)
        {
            List<BillInfoMenu> billInfoMenus = BillInfoMenuBUS.Instance.GetListBillInfoMenuBillID(frmPay.GetBillID());
            List<Bill> bill = BillBUS.Instance.GetListBillForID(frmPay.GetBillID());
            List<BillMenu> billMenus = BillMenuBUS.Instance.GetListBillMenuForID(frmPay.GetBillID());
            List<Discount> discounts = DiscountBUS.Instance.GetListDiscountForID(frmPay.GetDiscountID());
            this.rpvOutputBill.LocalReport.ReportEmbeddedResource = "frmLogin.Bill.rdlc";
            this.rpvOutputBill.LocalReport.DataSources.Add(new ReportDataSource("ViewBill1", billInfoMenus));
            this.rpvOutputBill.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", bill));
            this.rpvOutputBill.LocalReport.DataSources.Add(new ReportDataSource("DataSet2", billMenus));
            this.rpvOutputBill.LocalReport.DataSources.Add(new ReportDataSource("DataSet3", discounts));
            ReportParameterCollection reportParameters = new ReportParameterCollection();
            reportParameters.Add(new ReportParameter("MoneyReceive",frm.GetMoneyReceive()));
            reportParameters.Add(new ReportParameter("MoneyPay",frm.GetMoneyPay()));
            this.rpvOutputBill.LocalReport.SetParameters(reportParameters);
            this.rpvOutputBill.RefreshReport();
        }            

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
