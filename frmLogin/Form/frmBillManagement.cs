using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace frmLogin
{
    public partial class frmBillManagement : Form
    {
        public frmBillManagement()
        {
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
            cbSortBill.SelectedIndex = 0;
        }
        public void LoadBill()
        {
            dtgvListBill.DataSource = BillMenuBUS.Instance.GetListBillMenu();

        }

        private void dtgvListBill_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgvListBill.SelectedRows.Count > 0)
            {
                txtBillID.Text = dtgvListBill.SelectedRows[0].Cells[0].Value.ToString();
                txtDayCheckIn.Text = dtgvListBill.SelectedRows[0].Cells[1].Value.ToString();
                txtEmployeeName.Text = dtgvListBill.SelectedRows[0].Cells[2].Value.ToString();
                if (dtgvListBill.SelectedRows[0].Cells[3].Value != null)
                    txtDiscount.Text = dtgvListBill.SelectedRows[0].Cells[3].Value.ToString();
                else
                    txtDiscount.Text = "Không giảm giá";
                txtTable.Text = dtgvListBill.SelectedRows[0].Cells[4].Value.ToString();
                txtDayCheckOut.Text = dtgvListBill.SelectedRows[0].Cells[5].Value.ToString();
                CultureInfo culture = new CultureInfo("vi-VN");
                float total = float.Parse(dtgvListBill.SelectedRows[0].Cells[6].Value.ToString());
                txtTotalBill.Text = total.ToString("c", culture);
                bool statusCheckOut = bool.Parse(dtgvListBill.SelectedRows[0].Cells[7].Value.ToString());
                if (statusCheckOut == true)
                    cbStatusCheckOut.SelectedIndex = 0;
                else
                    cbStatusCheckOut.SelectedIndex = 1;
            }
        }

        private void cbSortBill_SelectedIndexChanged(object sender, EventArgs e)
        {   if (chkFillBill.Checked == true)
            {
                string dayCheckIn = dtpFillBill.Value.ToString("yyyy/MM/dd");

                if (cbSortBill.SelectedIndex == 1)
                    dtgvListBill.DataSource = BillMenuBUS.Instance.SortBillByBillID(dayCheckIn);
                else if (cbSortBill.SelectedIndex == 2)
                    dtgvListBill.DataSource = BillMenuBUS.Instance.SortBillByBillIDDesc(dayCheckIn);
                else if (cbSortBill.SelectedIndex == 3)
                    dtgvListBill.DataSource = BillMenuBUS.Instance.SortBillByDayCheckIn(dayCheckIn);
                else if (cbSortBill.SelectedIndex == 4)
                    dtgvListBill.DataSource = BillMenuBUS.Instance.SortBillByDayCheckInDesc(dayCheckIn);
                else if (cbSortBill.SelectedIndex == 5)
                    dtgvListBill.DataSource = BillMenuBUS.Instance.SortBillByTotal(dayCheckIn);
                else if (cbSortBill.SelectedIndex == 6)
                    dtgvListBill.DataSource = BillMenuBUS.Instance.SortBillByTotalDesc(dayCheckIn);
                else
                    dtgvListBill.DataSource = BillMenuBUS.Instance.FillBillByDayCheckIn(dayCheckIn);
            }
            else
            {
                if (cbSortBill.SelectedIndex == 0)
                    dtgvListBill.DataSource = BillMenuBUS.Instance.GetListBillMenu();
                else  if (cbSortBill.SelectedIndex == 1)
                    dtgvListBill.DataSource = BillMenuBUS.Instance.SortBillByBillID(null);
                else if (cbSortBill.SelectedIndex == 2)
                    dtgvListBill.DataSource = BillMenuBUS.Instance.SortBillByBillIDDesc(null);
                else if (cbSortBill.SelectedIndex == 3)
                    dtgvListBill.DataSource = BillMenuBUS.Instance.SortBillByDayCheckIn(null);
                else if (cbSortBill.SelectedIndex == 4)
                    dtgvListBill.DataSource = BillMenuBUS.Instance.SortBillByDayCheckInDesc(null);
                else if (cbSortBill.SelectedIndex == 5)
                    dtgvListBill.DataSource = BillMenuBUS.Instance.SortBillByTotal(null);
                else if (cbSortBill.SelectedIndex == 6)
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
            if(chkFillBill.Checked == true)
            {
                string dayCheckIn = dtpFillBill.Value.ToString("yyyy/MM/dd");

                if (cbSortBill.SelectedIndex == 1)
                    dtgvListBill.DataSource = BillMenuBUS.Instance.SortBillByBillID(dayCheckIn);
                else if (cbSortBill.SelectedIndex == 2)
                    dtgvListBill.DataSource = BillMenuBUS.Instance.SortBillByBillIDDesc(dayCheckIn);
                else if (cbSortBill.SelectedIndex == 3)
                    dtgvListBill.DataSource = BillMenuBUS.Instance.SortBillByDayCheckIn(dayCheckIn);
                else if (cbSortBill.SelectedIndex == 4)
                    dtgvListBill.DataSource = BillMenuBUS.Instance.SortBillByDayCheckInDesc(dayCheckIn);
                else if (cbSortBill.SelectedIndex == 5)
                    dtgvListBill.DataSource = BillMenuBUS.Instance.SortBillByTotal(dayCheckIn);
                else if (cbSortBill.SelectedIndex == 6)
                    dtgvListBill.DataSource = BillMenuBUS.Instance.SortBillByTotalDesc(dayCheckIn);
                else
                    dtgvListBill.DataSource = BillMenuBUS.Instance.FillBillByDayCheckIn(dayCheckIn);
            }
        }
    }
}
