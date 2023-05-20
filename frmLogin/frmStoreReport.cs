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
    public partial class frmStoreReport : Form
    {
        public frmStoreReport()
        {
            InitializeComponent();
        }

        private void frmStoreReport_Load(object sender, EventArgs e)
        {
            List<BillMenu> list = BillMenuBUS.Instance.GetListBillMenu();
            this.rpvStoreReport.LocalReport.ReportEmbeddedResource = "frmLogin.BillReport.rdlc";
            this.rpvStoreReport.LocalReport.DataSources.Add(new ReportDataSource("StatisticalBill", list));
            this.rpvStoreReport.RefreshReport();
        }
    }
}
