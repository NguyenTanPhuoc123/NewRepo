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
    public partial class frmBillDetail : Form
    {
        Bill getBill;
        private int Language = frmlogin.Language;
        public Bill GetBill { get => getBill; set => getBill = value; }
        frmBillManagement frmBillManagement;
        public frmBillDetail(Bill bill, frmBillManagement frmBill)
        {
            if (Language == 0)
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("vi");
            else
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en");
            InitializeComponent();
            getBill = bill;
            this.frmBillManagement = frmBill;
        }

        private void btnExitFomBillDetail_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBillDetailDeleted_Click(object sender, EventArgs e)
        {
            frmRecycleBin frm = new frmRecycleBin();
            frm.Show();
        }

        private void frmBillDetail_Load(object sender, EventArgs e)
        {
            LoadBillDetail();
        }
        public void LoadBillDetail()
        {
            dtgvBillDetail.DataSource = BillInfoMenuBUS.Instance.GetListBillInfoMenu(getBill.ID);
        }

        private void btnDeleteBillDetail_Click(object sender, EventArgs e)
        {
            if (Language == 0)
            {
                if (MessageBox.Show("Bạn muốn xóa chi tiết hóa đơn này ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    string productID = "";
                    if (dtgvBillDetail.SelectedRows.Count > 0)
                        productID = dtgvBillDetail.SelectedRows[0].Cells[1].Value.ToString();
                    int count = BillInfoBUS.Instance.DeleteBillInfo(txtBillID.Text, productID);

                    if (count > 0)
                    {
                        MessageBox.Show("Xóa chi tiết hóa đơn thành công", "Xóa chi tiết hóa đơn", MessageBoxButtons.OK);
                        this.frmBillManagement.LoadBill();
                        frmBillDetail_Load(sender, e);

                    }
                    else
                        MessageBox.Show("Xóa chi tiết hóa đơn thất bại", "Xóa chi tiết hóa đơn", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                if (MessageBox.Show("You want to delete this invoice details ?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    string productID = "";
                    if (dtgvBillDetail.SelectedRows.Count > 0)
                        productID = dtgvBillDetail.SelectedRows[0].Cells[1].Value.ToString();
                    int count = BillInfoBUS.Instance.DeleteBillInfo(txtBillID.Text, productID);

                    if (count > 0)
                    {
                        MessageBox.Show("Successfully deleted invoice details", "Notification", MessageBoxButtons.OK);
                        this.frmBillManagement.LoadBill();
                        frmBillDetail_Load(sender, e);

                    }
                    else
                        MessageBox.Show("Delete failed invoice details", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void dtgvBillDetail_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgvBillDetail.SelectedRows.Count > 0)
            {
                txtBillID.Text = dtgvBillDetail.SelectedRows[0].Cells[0].Value.ToString();
                txtProductName.Text = dtgvBillDetail.SelectedRows[0].Cells[2].Value.ToString();
                numCount.Value = int.Parse(dtgvBillDetail.SelectedRows[0].Cells[3].Value.ToString());
                txtPrice.Text = dtgvBillDetail.SelectedRows[0].Cells[4].Value.ToString();
                txtTotal.Text = dtgvBillDetail.SelectedRows[0].Cells[5].Value.ToString();
            }
        }

        private void btnDeleteAllBillDetail_Click(object sender, EventArgs e)
        {
            if (Language == 0)
            {
                if (MessageBox.Show("Bạn muốn xóa tất cả chi tiết hóa đơn này ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    int count = BillInfoBUS.Instance.DeleteAllBillInfo();

                    if (count > 0)
                    {
                        MessageBox.Show("Xóa tất cả chi tiết hóa đơn thành công", "Xóa chi tiết hóa đơn", MessageBoxButtons.OK);
                        this.frmBillManagement.LoadBill();
                        frmBillDetail_Load(sender, e);

                    }
                    else
                        MessageBox.Show("Xóa tất cả chi tiết hóa đơn thất bại", "Xóa chi tiết hóa đơn", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                if (MessageBox.Show("Want to delete all this invoice details?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    int count = BillInfoBUS.Instance.DeleteAllBillInfo();

                    if (count > 0)
                    {
                        MessageBox.Show("Delete all invoice details successfully", "Notification", MessageBoxButtons.OK);
                        this.frmBillManagement.LoadBill();
                        frmBillDetail_Load(sender, e);

                    }
                    else
                        MessageBox.Show("Delete all failed invoice details", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
