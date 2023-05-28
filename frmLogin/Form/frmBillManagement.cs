using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace frmLogin
{
    public partial class frmBillManagement : Form
    {
        HashCode info = new HashCode();
        private int Language = frmlogin.Language;
        public frmBillManagement()
        {
            if (Language == info.valueDefault)
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("vi");
            else
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en");
            InitializeComponent();
            dtgvListBill.AutoGenerateColumns = false;
        }

        private void btnShowDetail_Click(object sender, EventArgs e)
        {
            Bill bill = BillBUS.Instance.GetBillByBillID(txtBillID.Text);
            frmBillDetail frm = new frmBillDetail(bill,this);
            frm.Show();
        }

        private void frmBillManagement_Load(object sender, EventArgs e)
        {
            LoadBill();
            chkFillBill.Checked = false;
            cbSortBill.SelectedIndex = info.valueDefault;
        }
        public void LoadBill()
        {
            dtgvListBill.DataSource = BillMenuBUS.Instance.GetListBillMenu();

        }

        private void dtgvListBill_SelectionChanged(object sender, EventArgs e)
        {
            info.firstIndex = info.valueDefault;
            if (dtgvListBill.SelectedRows.Count > 0)
            {   
                txtBillID.Text = dtgvListBill.SelectedRows[info.valueDefault].Cells[info.firstIndex].Value.ToString();
                txtDayCheckIn.Text = dtgvListBill.SelectedRows[info.valueDefault].Cells[info.firstIndex+=1].Value.ToString();
                txtEmployeeName.Text = dtgvListBill.SelectedRows[info.valueDefault].Cells[info.firstIndex += 1].Value.ToString();
                if (dtgvListBill.SelectedRows[info.valueDefault].Cells[info.firstIndex += 1].Value != null)
                    txtDiscount.Text = dtgvListBill.SelectedRows[info.valueDefault].Cells[info.firstIndex].Value.ToString();
                else
                    txtDiscount.Text = "Không giảm giá";
                txtTable.Text = dtgvListBill.SelectedRows[info.valueDefault].Cells[info.firstIndex += 1].Value.ToString();
                txtDayCheckOut.Text = dtgvListBill.SelectedRows[info.valueDefault].Cells[info.firstIndex += 1].Value.ToString();
                CultureInfo culture = new CultureInfo("vi-VN");
                float total = float.Parse(dtgvListBill.SelectedRows[info.valueDefault].Cells[info.firstIndex += 1].Value.ToString());
                txtTotalBill.Text = total.ToString("c", culture);
                bool statusCheckOut = bool.Parse(dtgvListBill.SelectedRows[info.valueDefault].Cells[info.firstIndex += 1].Value.ToString());
                if (statusCheckOut == true)
                    cbStatusCheckOut.SelectedIndex = info.valueDefault;
                else
                    cbStatusCheckOut.SelectedIndex = info.valueDefault+1;
            }
        }

        private void cbSortBill_SelectedIndexChanged(object sender, EventArgs e)
        {
            info.firstIndex = info.valueDefault;
            if (chkFillBill.Checked == true)
            {
                string dayCheckIn = dtpFillBill.Value.ToString("yyyy/MM/dd");

                if (cbSortBill.SelectedIndex == (info.firstIndex+=1))
                    dtgvListBill.DataSource = BillMenuBUS.Instance.SortBillByBillID(dayCheckIn);
                else if (cbSortBill.SelectedIndex == (info.firstIndex += 1))
                    dtgvListBill.DataSource = BillMenuBUS.Instance.SortBillByBillIDDesc(dayCheckIn);
                else if (cbSortBill.SelectedIndex == (info.firstIndex += 1))
                    dtgvListBill.DataSource = BillMenuBUS.Instance.SortBillByDayCheckIn(dayCheckIn);
                else if (cbSortBill.SelectedIndex == (info.firstIndex += 1))
                    dtgvListBill.DataSource = BillMenuBUS.Instance.SortBillByDayCheckInDesc(dayCheckIn);
                else if (cbSortBill.SelectedIndex == (info.firstIndex += 1))
                    dtgvListBill.DataSource = BillMenuBUS.Instance.SortBillByTotal(dayCheckIn);
                else if (cbSortBill.SelectedIndex == (info.firstIndex += 1))
                    dtgvListBill.DataSource = BillMenuBUS.Instance.SortBillByTotalDesc(dayCheckIn);
                else
                    dtgvListBill.DataSource = BillMenuBUS.Instance.FillBillByDayCheckIn(dayCheckIn);
            }
            else
            {
                info.firstIndex = info.valueDefault;
                if (cbSortBill.SelectedIndex == info.firstIndex)
                    dtgvListBill.DataSource = BillMenuBUS.Instance.GetListBillMenu();
                else  if (cbSortBill.SelectedIndex == (info.firstIndex += 1))
                    dtgvListBill.DataSource = BillMenuBUS.Instance.SortBillByBillID(null);
                else if (cbSortBill.SelectedIndex == (info.firstIndex += 1))
                    dtgvListBill.DataSource = BillMenuBUS.Instance.SortBillByBillIDDesc(null);
                else if (cbSortBill.SelectedIndex == (info.firstIndex += 1))
                    dtgvListBill.DataSource = BillMenuBUS.Instance.SortBillByDayCheckIn(null);
                else if (cbSortBill.SelectedIndex == (info.firstIndex += 1))
                    dtgvListBill.DataSource = BillMenuBUS.Instance.SortBillByDayCheckInDesc(null);
                else if (cbSortBill.SelectedIndex == (info.firstIndex += 1))
                    dtgvListBill.DataSource = BillMenuBUS.Instance.SortBillByTotal(null);
                else if (cbSortBill.SelectedIndex == (info.firstIndex += 1))
                    dtgvListBill.DataSource = BillMenuBUS.Instance.SortBillByTotalDesc(null);
              
            }
        }

        private void chkFillBill_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFillBill.Checked == true)
                dtpFillBill.Enabled = true;
            else
                dtpFillBill.Enabled = false;
        }

        private void dtpFillBill_ValueChanged(object sender, EventArgs e)
        {
            info.firstIndex = info.valueDefault;
            if(chkFillBill.Checked == true)
            {
                string dayCheckIn = dtpFillBill.Value.ToString("yyyy/MM/dd");

                if (cbSortBill.SelectedIndex == (info.firstIndex += 1))
                    dtgvListBill.DataSource = BillMenuBUS.Instance.SortBillByBillID(dayCheckIn);
                else if (cbSortBill.SelectedIndex == (info.firstIndex += 1))
                    dtgvListBill.DataSource = BillMenuBUS.Instance.SortBillByBillIDDesc(dayCheckIn);
                else if (cbSortBill.SelectedIndex == (info.firstIndex += 1))
                    dtgvListBill.DataSource = BillMenuBUS.Instance.SortBillByDayCheckIn(dayCheckIn);
                else if (cbSortBill.SelectedIndex == (info.firstIndex += 1))
                    dtgvListBill.DataSource = BillMenuBUS.Instance.SortBillByDayCheckInDesc(dayCheckIn);
                else if (cbSortBill.SelectedIndex == (info.firstIndex += 1))
                    dtgvListBill.DataSource = BillMenuBUS.Instance.SortBillByTotal(dayCheckIn);
                else if (cbSortBill.SelectedIndex == (info.firstIndex += 1))
                    dtgvListBill.DataSource = BillMenuBUS.Instance.SortBillByTotalDesc(dayCheckIn);
                else
                    dtgvListBill.DataSource = BillMenuBUS.Instance.FillBillByDayCheckIn(dayCheckIn);
            }
        }
    }
}
