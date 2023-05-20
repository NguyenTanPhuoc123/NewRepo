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

    public partial class frmQuanLyAdmin : Form
    {
        private Button currentButton;
        private Form activeForm;

        public frmQuanLyAdmin()
        {
            InitializeComponent();
           

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
            if (activeForm != null)
                activeForm.Close();

            lblTitle.Text = "Thống kê";
            DisableButton();
            
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

        private void frmQuanLyAdmin_Load(object sender, EventArgs e)
        {
            cbTypeStatisticalBill.SelectedIndex = 0;
            string startDay = DateTime.Now.ToString("yyyy/MM/dd");
            string endDay = DateTime.Now.ToString("yyyy/MM/dd");
            List<StatisticalBill> list = StatisticalBillBUS.Instance.GetListEmployeeCreateBillMaxByDate(startDay,endDay);
            foreach(StatisticalBill item in list)
            {
                chartEmployeeCreateBill.Series["Số hóa đơn lập"].Points.AddXY(item.EmployeeName, item.CountBill);
            }
            chartEmployeeCreateBill.Titles.Add("Nhân viên lập nhiều hóa đơn nhất");
            
        }

        private void btnbtnStatisticalBill_Click(object sender, EventArgs e)
        {             
            chartEmployeeCreateBill.Series.Clear();
            chartEmployeeCreateBill.Series.Add("Số hóa đơn lập");
            string startDay = dtpBillStart.Value.ToString("yyyy/MM/dd");
            string endDay = dtpBillEnd.Value.ToString("yyyy/MM/dd");
            List<StatisticalBill> list = StatisticalBillBUS.Instance.GetListEmployeeCreateBillMaxByDate(startDay, endDay);
            foreach (StatisticalBill item in list)
            {
                chartEmployeeCreateBill.Series["Số hóa đơn lập"].Points.AddXY(item.EmployeeName, item.CountBill);
            }
           
        }

        private void btnReportEmployCreateBill_Click(object sender, EventArgs e)
        {
            frmStoreReport frm = new frmStoreReport();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }
    }
}
