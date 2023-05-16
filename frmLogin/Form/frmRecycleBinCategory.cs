
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
            dtgvListDiscountDeleted.AutoGenerateColumns = false;
            dtgvListPositionDeleted.AutoGenerateColumns = false;
            dtgvListLocationDeleted.AutoGenerateColumns = false;
            dtgvListTypeProductDeleted.AutoGenerateColumns = false;
            
        }

        private void frmRecycleBinCategory_Load(object sender, EventArgs e)
        {
            LoadLocationDeleted();
            LoadTypeAccountDeleted();
            LoadPositionDeleted();
            LoadDiscountDeleted();
        }

        private void btnExitFormRecycleBinCategory_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void CloseForm(object sender, EventArgs e)
        {

        }

        #region Location
        private void tpLocationDeleted_Click(object sender, EventArgs e)
        {
            LoadLocationDeleted();
            frmCategoyManagement.ActiveForm.Load += new EventHandler(CloseForm);
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


        #region TypeProduct
        private void LoadTypeProductDeleted()
        {
            dtgvListTypeProductDeleted.DataSource = CategoryFoodBUS.Instance.GetCategoryFoodsDeleted();
            frmCategoyManagement.ActiveForm.Load += new EventHandler(CloseForm);
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
            if (DialogResult.Yes == MessageBox.Show("Bạn có muốn khôi phục loại sản phẩm", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                int count = CategoryFoodBUS.Instance.RestoreCategoryFood(txtTypeProductID.Text);
                if (count > 0)
                    MessageBox.Show("Khôi phục thành công", "Thông Báo", MessageBoxButtons.OK);
                else
                    MessageBox.Show("Khôi phục thất bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LoadTypeProductDeleted();
            }
        }

        private void btnRestoreAllTypeProduct_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn có muốn khôi phục tất cả sản phẩm", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                int count = CategoryFoodBUS.Instance.RestoreCategoryFood(txtTypeProductID.Text);
                if (count > 0)
                    MessageBox.Show("Khôi phục tất cả loại sản phẩm thành công", "Thông Báo", MessageBoxButtons.OK);
                else
                    MessageBox.Show("Khôi phục tất cả loại sản phẩm thất bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LoadTypeProductDeleted();
            }
        }
        #endregion

        #region TypeAccount
        private void LoadTypeAccountDeleted()
        {
            frmCategoyManagement.ActiveForm.Load += new EventHandler(CloseForm);
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
            frmCategoyManagement.ActiveForm.Load += new EventHandler(CloseForm);
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

        #region Discount
        public void LoadDiscountDeleted()
        {
            dtgvListDiscountDeleted.DataSource = DiscountBUS.Instance.GetListDiscountDeleted();
            frmCategoyManagement.ActiveForm.Load += new EventHandler(CloseForm);
            ResetInfoDiscount();
        }

        public void ResetInfoDiscount()
        {
            txtDiscountID.Clear();
            txtDiscountName.Clear();
            txtDiscountPrice.Clear();
            txtStartDayDiscount.Clear();
            txtEndDayDiscount.Clear();
        }
        
        private void dtgvListDiscountDeleted_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgvListDiscountDeleted.SelectedRows.Count > 0)
            {
                txtDiscountID.Text = dtgvListDiscountDeleted.SelectedRows[0].Cells[0].Value.ToString();
                txtDiscountName.Text = dtgvListDiscountDeleted.SelectedRows[0].Cells[1].Value.ToString();
                txtDiscountPrice.Text = dtgvListDiscountDeleted.SelectedRows[0].Cells[2].Value.ToString();
                txtStartDayDiscount.Text = dtgvListDiscountDeleted.SelectedRows[0].Cells[3].Value.ToString();
                txtEndDayDiscount.Text = dtgvListDiscountDeleted.SelectedRows[0].Cells[4].Value.ToString();
                txtAvailableDiscount.Text = dtgvListDiscountDeleted.SelectedRows[0].Cells[5].Value.ToString();
                txtLimitDiscount.Text = dtgvListDiscountDeleted.SelectedRows[0].Cells[6].Value.ToString();
            }
        }

        private void btnRestoreDiscount_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn khôi phục giảm giá này ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {

                string discountID = txtDiscountID.Text;

                int count = DiscountBUS.Instance.RestoreDiscount(discountID);
                if (count > 0)
                {
                    MessageBox.Show("Khôi phục giảm giá thành công", "Khôi phục giảm giá", MessageBoxButtons.OK);
                    LoadDiscountDeleted();
                }
                else
                    MessageBox.Show("Khôi phục giảm giá thất bại", "Khôi phục giảm giá", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnRestoreAllDiscount_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn khôi phục tất cả giảm giá này ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {

                int count = DiscountBUS.Instance.RestoreAllDiscount();
                if (count > 0)
                {
                    MessageBox.Show("Khôi phục tất cả giảm giá thành công", "Khôi phục giảm giá", MessageBoxButtons.OK);
                    LoadDiscountDeleted();
                }
                else
                    MessageBox.Show("Khôi phục tất cả giảm giá thất bại", "Khôi phục giảm giá", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        #endregion



    }
}