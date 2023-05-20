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
        public frmOutputBill()
        {
            InitializeComponent();
        }

        private void frmOutputBill_Load(object sender, EventArgs e)
        {
            List<BillInfoMenu> billInfoMenus = BillInfoMenuBUS.Instance.GetListBillInfoMenuBillID(frmPay.GetBillID());
            List<Bill> bill = BillBUS.Instance.GetListBillForID(frmPay.GetBillID());
            List<BillMenu> billMenus = BillMenuBUS.Instance.GetListBillMenuForID(frmPay.GetBillID());
            List<Discount> discounts = DiscountBUS.Instance.GetListDiscountForID(frmPay.GetDiscountID());
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "frmLogin.Bill.rdlc";
            this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("ViewBill1", billInfoMenus));
            this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", bill));
            this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet2", billMenus));
            this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet3", discounts));
            this.reportViewer1.RefreshReport();
        }
    }
}
