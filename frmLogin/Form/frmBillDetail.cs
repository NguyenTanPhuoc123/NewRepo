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
    public partial class frmBillDetail : Form
    {
        Bill getBill;

        public Bill GetBill { get => getBill; set => getBill = value; }
        frmBillManagement frmBillManagement;
        public frmBillDetail(Bill bill, frmBillManagement frmBill)
        {
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
            dtgvBillDetail.DataSource = BillInfoMenuBUS.Instance.GetListBillInfoMenu(getBill.ID);            
        }

        private void btnDeleteBillDetail_Click(object sender, EventArgs e)
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
    }
}
