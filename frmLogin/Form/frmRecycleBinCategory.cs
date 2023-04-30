
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

namespace frmLogin
{
    public partial class frmRecycleBinCategory : Form
    {
        public frmRecycleBinCategory()
        {
            InitializeComponent();
            dtgvListTypeAccountDeleted.AutoGenerateColumns = false;
        }

        private void frmRecycleBinCategory_Load(object sender, EventArgs e)
        {
            LoadLocationDeleted();
            LoadTypeCustomerDeleted();
            LoadTypeAccountDeleted();
            LoadPositionDeleted();
        }

        #region Location
        private void tpLocationDeleted_Click(object sender, EventArgs e)
        {
            LoadLocationDeleted();
        }
        public void LoadLocationDeleted()
        {
            txtLocationID.Clear();
            txtLocationName.Clear();
            dtgvListLocationDeleted.DataSource = LocationBUS.Instance.GetListLocationDeleted();
        }

        private void dtgvListLocationDeleted_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgvListLocationDeleted.SelectedRows.Count > 0)
            {
                txtLocationID.Text = dtgvListLocationDeleted.SelectedRows[0].Cells[0].Value.ToString();
                txtLocationName.Text = dtgvListLocationDeleted.SelectedRows[0].Cells[1].Value.ToString();

            }
        }

        private void btnRestoreLocation_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn khôi phục lại vị trí bàn này chứ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int count = LocationBUS.Instance.RestoreLocation(int.Parse(txtLocationID.Text));
                if (count > 0)
                {
                    MessageBox.Show("Khôi phục vị trí bàn thành công", "Khôi phục vị trí bàn", MessageBoxButtons.OK);
                    LoadLocationDeleted();
                }
                else
                    MessageBox.Show("Khôi phục vị trí bàn thất bại", "Khôi phục vị trí bàn", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnRestoreAllLocation_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn khôi phục tất cả  vị trí bàn này chứ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                int count = LocationBUS.Instance.RestoreAllLocation();
                if (count > 0)
                {
                    MessageBox.Show("Khôi phục tất cả vị trí bàn thành công", "Khôi phục vị trí bàn", MessageBoxButtons.OK);
                    LoadLocationDeleted();
                }
                else
                    MessageBox.Show("Khôi phục tất cả vị trí bàn thất bại", "Khôi phục vị trí bàn", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        #endregion

        #region Type Customer
        public void LoadTypeCustomerDeleted()
        {
            dtgvListTypeCustomerDeleted.DataSource = TypeCustomerBUS.Instance.GetListTypeCustomerDeleted();
            txtTypeCustomerID.Clear();
            txtTypeCustomerName.Clear();

        }

        private void dtgvListTypeCustomerDeleted_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgvListTypeCustomerDeleted.SelectedRows.Count > 0)
            {
                txtTypeCustomerID.Text = dtgvListTypeCustomerDeleted.SelectedRows[0].Cells[0].Value.ToString();
                txtTypeCustomerName.Text = dtgvListTypeCustomerDeleted.SelectedRows[0].Cells[1].Value.ToString();
            }
        }

        private void btnRestoreTypeCustomer_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn khôi phục lại loại khách hàng này chứ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int count = TypeCustomerBUS.Instance.RestoreTypeCustomer(int.Parse(txtTypeCustomerID.Text));
                if (count > 0)
                {
                    MessageBox.Show("Khôi phục loại khách hàng thành công", "Khôi phục loại khách hàng", MessageBoxButtons.OK);
                    LoadTypeCustomerDeleted();
                }
                else
                    MessageBox.Show("Khôi phục loại khách hàng thất bại", "Khôi phục loại khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnRestoreAllTypeCustomer_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn khôi phục tất cả  loại khách hàng này chứ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                int count = TypeCustomerBUS.Instance.RestoreAllTypeCustomer();
                if (count > 0)
                {
                    MessageBox.Show("Khôi phục tất cả loại khách hàng thành công", "Khôi phục loại khách hàng", MessageBoxButtons.OK);
                    LoadTypeCustomerDeleted();
                }
                else
                    MessageBox.Show("Khôi phục tất cả loại khách hàng thất bại", "Khôi phục loại khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        #endregion

        #region TypeProduct
        private void LoadTypeProductDeleted()
        {
            dtgvListTypeProductDeleted.DataSource = CategoryFoodBUS.Instance.GetCategoryFoodsDeleted();
        }
        private void dtgvListTypeProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (i == -1) return;
            txtTypeProductID.Text = dtgvListTypeProductDeleted.Rows[i].Cells[0].Value.ToString();
            txtTypeProductName.Text = dtgvListTypeProductDeleted.Rows[i].Cells[1].Value.ToString();
        }
        private void btnRestoreTypeProduct_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Ban co muon khoi phuc loai san pham", "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                int count = CategoryFoodBUS.Instance.RestoreCategoryFood(txtTypeProductID.Text);
                MessageBox.Show(count > 0 ? "Khoi phuc thanh cong" : "Khoi phuc that bai");
                LoadTypeProductDeleted();
            }
        }

        private void btnRestoreAllTypeProduct_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Ban co muon khoi phuc tat ca loai san pham", "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                int count = CategoryFoodBUS.Instance.RestoreCategoryFood(txtTypeProductID.Text);
                MessageBox.Show(count > 0 ? "Khoi phuc tat ca thanh cong" : "Khoi phuc tat ca that bai");
                LoadTypeProductDeleted();
            }
        }
        #endregion

        private void btnExitFormRecycleBinCategory_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region TypeAccount
        private void LoadTypeAccountDeleted()
        {
            dtgvListTypeAccountDeleted.DataSource = TypeAccountBUS.Instance.GetListTypeAccountDelete();
        }

        private void dtgvListTypeAccountDeleted_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (i == -1) return;
            txtTypeAccountID.Text = dtgvListTypeAccountDeleted.Rows[i].Cells[0].Value.ToString();
            txtTypeAccountName.Text = dtgvListTypeAccountDeleted.Rows[i].Cells[1].Value.ToString();
        }

        private void btnRestoreTypeAccount_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn có muốn khôi phục loại tài khoản này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                int count = TypeAccountBUS.Instance.RestoreTypeAccount(Convert.ToInt32(txtTypeAccountID.Text));
                MessageBox.Show(count > 0 ? "Khôi phục thành công" : "Khôi phục thất bại");
                LoadTypeAccountDeleted();
            }
        }

        private void btnRestoreAllTypeAccount_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn có muốn khôi phục tất cả loại tài khoản này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                int count = TypeAccountBUS.Instance.RestoreAllTypeAccount();
                MessageBox.Show(count > 0 ? "Khôi phục thành công" : "Khôi phục thất bại");
                LoadTypeAccountDeleted();
            }       
        }
        #endregion

        #region Position

        public void LoadPositionDeleted()
        {
            dtgvListPositionDeleted.DataSource = PositionBUS.Instance.GetListPositionDeleted();
        }

        private void RestorePosition_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn có muốn khôi phục loại chức vụ này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                int count = PositionBUS.Instance.RestorePosition(Convert.ToInt32(txtPositionID.Text));
                MessageBox.Show(count > 0 ? "Khôi phục thành công" : "Khôi phục thất bại");
                LoadTypeAccountDeleted();
            }
        }

        private void RestoreAllPosition_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn có muốn khôi phục tất cả loại chức vụ này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                int count = PositionBUS.Instance.RestoreAllPosition();
                MessageBox.Show(count > 0 ? "Khôi phục thành công" : "Khôi phục thất bại");
                LoadTypeAccountDeleted();
            }
        }

        private void dtgvListPositionDeleted_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (i == -1) return;
            txtPositionID.Text = dtgvListPositionDeleted.Rows[i].Cells[0].Value.ToString();
            txtPositionName.Text = dtgvListPositionDeleted.Rows[i].Cells[1].Value.ToString();
        }
        #endregion


    }
}