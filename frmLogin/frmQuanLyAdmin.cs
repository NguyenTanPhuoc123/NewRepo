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
using System.Threading;
using System.Windows.Forms.DataVisualization.Charting;

namespace frmLogin
{   
    
    public partial class frmQuanLyAdmin : Form
    {
        HashCode info = new HashCode();
        private int Language = frmlogin.Language;
        private Button currentButton;
        private Form activeForm;
        frmSellManagement frm;

        public frmQuanLyAdmin(frmSellManagement frmSell)
        {
            if (Language == info.valueDefault)
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("vi");
            else
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en");
            InitializeComponent();
            cbTypeStatisticalBill.SelectedIndex = info.firstIndex;
            cbFillProduct.SelectedIndex = info.firstIndex;
            frm = frmSell;
        }

        private void frmQuanLyAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }

        #region EffectButton
        private void ActiveButton(object sender)
        {
            if(sender != null)
            {
                if (currentButton != (Button)sender)
                {
                    DisableButton();
                    Color colorBtn = Color.FromArgb(255,87,34);
                    currentButton = (Button)sender;
                    currentButton.BackColor = colorBtn;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                }
            }
        }

        private void DisableButton()
        {
            foreach(Control previousButton in panelMenu.Controls)
            {
                if(previousButton.GetType()== typeof(Button))
                {
                    previousButton.BackColor = Color.FromArgb(31,30,68);
                    previousButton.ForeColor = Color.Gainsboro;
                    previousButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        #endregion
        

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        #region OpenChildForm
        private void OpenChildForm(Form childForm, object sender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActiveButton(sender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelMain.Controls.Add(childForm);
            this.panelMain.Tag = childForm;
            
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;
        }

        private void btnProducManagement_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmProductManagement(), sender);
            lblTitle.Text = btnProducManagement.Text;
            ActiveButton(sender);
        }

        private void btnAccountManagement_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmAccountManagement(), sender);
            lblTitle.Text = btnAccountManagement.Text;
            ActiveButton(sender);
        }


        #endregion

        private void btnEmployeeManager_Click(object sender, EventArgs e)
        {
                OpenChildForm(new frmEmployeeManager(), sender);
                lblTitle.Text = btnEmployeeManager.Text;
                ActiveButton(sender);
            
        }

        private void btnCategoryManagement_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmCategoyManagement(), sender);
            lblTitle.Text = btnCategoryManagement.Text;
            ActiveButton(sender);
        }


        private void pbLogo_Click(object sender, EventArgs e)
        {
            if (Language == info.valueDefault)
            {
                if (activeForm != null)
                    activeForm.Close();

                lblTitle.Text = info.titleStatisticalVi;
                DisableButton();
            }
            else
            {
                if (activeForm != null)
                    activeForm.Close();

                lblTitle.Text = info.titleStatisticalEn;
                DisableButton();
            }
            
        }

        private void btnTableManagement_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmTableManagement(), sender);
            lblTitle.Text = btnTableManagement.Text;
            ActiveButton(sender);
        }

        private void btnBillManagement_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmBillManagement(), sender);
            lblTitle.Text = btnBillManagement.Text;
            ActiveButton(sender);
        }

        public Employee GetEmployeeByID()
        {
            return EmployeeBUS.Instance.GetEmployeeByEmployeeID(frm.LoginAccount.EmployeeID);
        }

        private void frmQuanLyAdmin_Load(object sender, EventArgs e)
        {
            LoadEmloyeeCreateBill();
            LoadProduct();
            //LoadStisticalRevenue();
        }
        #region Employee
        public void LoadEmloyeeCreateBill()
        {
            string startDay = DateTime.Now.ToString("yyyy/MM/dd");
            string endDay = DateTime.Now.ToString("yyyy/MM/dd");
            chartEmployeeCreateBill.DataSource = StatisticalBillBUS.Instance.GetListEmployeeCreateBillMaxByDate(startDay, endDay);
            chartEmployeeCreateBill.Series[info.firstIndex].XValueMember = "EmployeeName";
            chartEmployeeCreateBill.Series[info.firstIndex].XValueType = ChartValueType.String;
            chartEmployeeCreateBill.Series[info.firstIndex].YValueMembers = "CountBill";
            chartEmployeeCreateBill.Series[info.firstIndex].YValueType = ChartValueType.Int32;
        }


        private void btnbtnStatisticalBill_Click(object sender, EventArgs e)
        {
            string startDay = dtpBillStart.Value.ToString("yyyy/MM/dd");
            string endDay = dtpBillEnd.Value.ToString("yyyy/MM/dd");
            if (cbTypeStatisticalBill.SelectedIndex == info.firstIndex)
            {
                chartEmployeeCreateBill.Titles[info.firstIndex].Text = info.titleChartEmployeeCreateMaxVi;

                chartEmployeeCreateBill.DataSource = StatisticalBillBUS.Instance.GetListEmployeeCreateBillMaxByDate(startDay, endDay);
            }
            else
            {
                chartEmployeeCreateBill.DataSource = StatisticalBillBUS.Instance.GetListEmployeeCreateBillMinByDate(startDay, endDay);
                chartEmployeeCreateBill.Titles[info.firstIndex].Text = info.titleChartEmployeeCreateMinVi;
            }
            chartEmployeeCreateBill.Series[info.firstIndex].XValueMember = "EmployeeName";
            chartEmployeeCreateBill.Series[info.firstIndex].XValueType = ChartValueType.String;
            chartEmployeeCreateBill.Series[info.firstIndex].YValueMembers = "CountBill";
            chartEmployeeCreateBill.Series[info.firstIndex].YValueType = ChartValueType.Int32;


        }

        public string GetStartDayBill()
        {
            return dtpBillStart.Value.ToString("yyyy/MM/dd");
        }

        public string GetEndDayBill()
        {
            return dtpBillEnd.Value.ToString("yyyy/MM/dd");
        }

        private void btnReportEmployCreateBill_Click(object sender, EventArgs e)
        {
            string startDay = dtpBillStart.Value.ToString("yyyy/MM/dd");
            string endDay = dtpBillEnd.Value.ToString("yyyy/MM/dd");
            frmEmployeeReport frm = new frmEmployeeReport(this);
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        #endregion

        #region Revenue
        public void LoadStisticalRevenue()
        {                       
            DateTime startDay = DateTime.Now;
            DateTime endDay = DateTime.Now;
            float revenue = BillBUS.Instance.GetTotalRenvenueByDate(startDay.ToString("yyyy/MM/dd"), endDay.ToString("yyyy/MM/dd"));
            List <BillMenu> list = BillMenuBUS.Instance.GetListBillMenuByDate(startDay.ToString("yyyy/MM/dd"), endDay.ToString("yyyy/MM/dd"));

            this.rpvRevenue.LocalReport.ReportEmbeddedResource = "frmLogin.RevenueReport.rdlc";
            this.rpvRevenue.LocalReport.DataSources.Add(new ReportDataSource("Revenue", list));

            ReportParameterCollection reportParameters = new ReportParameterCollection();
            reportParameters.Add(new ReportParameter("StartDay", startDay.ToString("dd/MM/yyyy")));
            reportParameters.Add(new ReportParameter("EndDay", endDay.ToString("dd/MM/yyyy")));
            reportParameters.Add(new ReportParameter("EmployeeCreate", GetEmployeeByID().TenNV));
            reportParameters.Add(new ReportParameter("TotalRevenue", revenue.ToString()));
            this.rpvRevenue.LocalReport.SetParameters(reportParameters);
            this.rpvRevenue.RefreshReport();
        }
        #endregion
        #region KeyDown
        private void btnProducManagement_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                btnProducManagement_Click(sender, e);
            }
        }

        private void btnAccountManagement_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                btnAccountManagement_Click(sender, e);
            }
        }

        private void btnEmployeeManager_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
            {
                btnEmployeeManager_Click(sender, e);
            }
        }

        private void btnBillManagement_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F4)
            {
                btnBillManagement_Click(sender, e);
            }
        }

        private void btnTableManagement_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                btnTableManagement_Click(sender, e);
            }
        }

        private void btnCategoryManagement_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F6)
            {
                btnCategoryManagement_Click(sender, e);
            }
        }

        #endregion

        #region Statistical Product

        public string GetStartDayProduct()
        {
            return dtpProductStart.Value.ToString("yyyy/MM/dd");
        }

        public string GetEndDayProduct()
        {
            return dtpProductEnd.Value.ToString("yyyy/MM/dd");
        }

        public void LoadProduct()
        {
            string startDay = DateTime.Now.ToString("yyyy/MM/dd");
            string endDay = DateTime.Now.ToString("yyyy/MM/dd");
            chartProduct.Titles[info.firstIndex].Text = info.titleChartProductSoldMaxVi;
            chartProduct.DataSource = StatisticalProductBUS.Instance.StatisticalProductSoldMaxByDay(startDay, endDay);
            chartProduct.Series[info.firstIndex].XValueMember = "ProductName";
            chartProduct.Series[info.firstIndex].XValueType = ChartValueType.String;
            chartProduct.Series[info.firstIndex].YValueMembers = "TotalCount";
            chartProduct.Series[info.firstIndex].YValueType = ChartValueType.Int32;
        }

        private void btnStatisticalProduct_Click(object sender, EventArgs e)
        {
            string startDay = dtpProductStart.Value.ToString("yyyy/MM/dd");
            string endDay = dtpProductEnd.Value.ToString("yyyy/MM/dd");
            if (cbFillProduct.SelectedIndex == info.firstIndex)
            {
                chartProduct.Titles[info.firstIndex].Text = info.titleChartProductSoldMaxVi;
                chartProduct.DataSource = StatisticalProductBUS.Instance.StatisticalProductSoldMaxByDay(startDay, endDay);
            }
            else
            {
                chartProduct.DataSource = StatisticalProductBUS.Instance.StatisticalProductSoldMinByDay(startDay, endDay);
                chartProduct.Titles[info.firstIndex].Text = info.titleChartProductSoldMinVi;
            }

            chartProduct.Series[info.firstIndex].XValueMember = "ProductName";
            chartProduct.Series[info.firstIndex].XValueType = ChartValueType.String;
            chartProduct.Series[info.firstIndex].YValueMembers = "TotalCount";
            chartProduct.Series[info.firstIndex].YValueType = ChartValueType.Int32;
        }

        private void btnShowReportProduct_Click(object sender, EventArgs e)
        {
            string startDay = dtpProductStart.Value.ToString("yyyy/MM/dd");
            string endDay = dtpProductEnd.Value.ToString("yyyy/MM/dd");
            frmProductReport frm = new frmProductReport(this);
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        #endregion

        private void btnStatisticalRevenue_Click(object sender, EventArgs e)
        {
            DateTime startDay = dtpRevenueStart.Value;
            DateTime endDay = dtpRevenueEnd.Value;
     
            float revenue = BillBUS.Instance.GetTotalRenvenueByDate(startDay.ToString("yyyy/MM/dd"), endDay.ToString("yyyy/MM/dd"));
            List<BillMenu> list = BillMenuBUS.Instance.GetListBillMenuByDate(startDay.ToString("yyyy/MM/dd"), endDay.ToString("yyyy/MM/dd"));

            this.rpvRevenue.LocalReport.ReportEmbeddedResource = "frmLogin.RevenueReport.rdlc";
            this.rpvRevenue.LocalReport.DataSources.Add(new ReportDataSource("Revenue", list));

            ReportParameterCollection reportParameters = new ReportParameterCollection();
            reportParameters.Add(new ReportParameter("StartDay", startDay.ToString("dd/MM/yyyy")));
            reportParameters.Add(new ReportParameter("EndDay", endDay.ToString("dd/MM/yyyy")));
            reportParameters.Add(new ReportParameter("EmployeeCreate", GetEmployeeByID().TenNV));
            reportParameters.Add(new ReportParameter("TotalRevenue", revenue.ToString("c")));
            this.rpvRevenue.LocalReport.SetParameters(reportParameters);
            this.rpvRevenue.RefreshReport();
        }
    }
}
