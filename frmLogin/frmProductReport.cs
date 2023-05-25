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
    public partial class frmProductReport : Form
    {
        frmQuanLyAdmin frm;
        public frmProductReport(frmQuanLyAdmin admin)
        {
            InitializeComponent();
            frm = admin;
        }

        private void frmProductReport_Load(object sender, EventArgs e)
        {
            LoadProductReport();
        }

        public void LoadProductReport()
        {
            DateTime startDay = DateTime.Parse(frm.GetStartDayProduct());
            DateTime endDay = DateTime.Parse(frm.GetEndDayProduct());
            int sum = StatisticalProductBUS.Instance.GetSumQuantitySellByDay(startDay.ToString("yyyy/MM/dd"), endDay.ToString("yyyy/MM/dd"));
            List<StatisticalProduct> listProduct = StatisticalProductBUS.Instance.StatisticalProductCanNotSellByDay(startDay.ToString("yyyy/MM/dd"), endDay.ToString("yyyy/MM/dd"));
            List<StatisticalProduct> list = StatisticalProductBUS.Instance.GetListProductByDay(startDay.ToString("yyyy/MM/dd"), endDay.ToString("yyyy/MM/dd"));
            this.rpvProduct.LocalReport.ReportEmbeddedResource = "frmLogin.ProductReport.rdlc";
            this.rpvProduct.LocalReport.DataSources.Add(new ReportDataSource("StatisticalProduct", list));
            this.rpvProduct.LocalReport.DataSources.Add(new ReportDataSource("ProductCanNotSell", listProduct));

            ReportParameterCollection reportParameters = new ReportParameterCollection();
            reportParameters.Add(new ReportParameter("startDay", startDay.ToString("dd/MM/yyyy")));
            reportParameters.Add(new ReportParameter("endDay", endDay.ToString("dd/MM/yyyy")));
            reportParameters.Add(new ReportParameter("endDay", endDay.ToString("dd/MM/yyyy")));
            reportParameters.Add(new ReportParameter("EmployeeCreate", frm.GetEmployeeByID().TenNV));
            reportParameters.Add(new ReportParameter("SumCountSell",sum.ToString()));
            this.rpvProduct.LocalReport.SetParameters(reportParameters);
            this.rpvProduct.RefreshReport();
        }

        
    }
}
