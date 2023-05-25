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
    public partial class frmEmployeeReport : Form
    {
        frmQuanLyAdmin frm;
        public frmEmployeeReport(frmQuanLyAdmin admin)
        {
            InitializeComponent();
            frm = admin;
        }

        private void frmStoreReport_Load(object sender, EventArgs e)
        {
            LoadReport();
        }

        public void LoadReport()
        {
            DateTime startDay = DateTime.Parse(frm.GetStartDayBill());
            DateTime endDay = DateTime.Parse(frm.GetEndDayBill());
            List<BillMenu> list = BillMenuBUS.Instance.GetListBillMenuByDate(startDay.ToString("yyyy/MM/dd"), endDay.ToString("yyyy/MM/dd"));
            
            this.rpvStoreReport.LocalReport.ReportEmbeddedResource = "frmLogin.BillReport.rdlc";
            this.rpvStoreReport.LocalReport.DataSources.Add(new ReportDataSource("StatisticalBill", list));
            

            ReportParameterCollection reportParameters = new ReportParameterCollection();
            reportParameters.Add(new ReportParameter("StartDay", startDay.ToString("dd/MM/yyyy")));
            reportParameters.Add(new ReportParameter("EndDay", endDay.ToString("dd/MM/yyyy")));
            reportParameters.Add(new ReportParameter("EmployeeCreate", frm.GetEmployeeByID().TenNV));
            this.rpvStoreReport.LocalReport.SetParameters(reportParameters);
            this.rpvStoreReport.RefreshReport();
        }
    }
}
