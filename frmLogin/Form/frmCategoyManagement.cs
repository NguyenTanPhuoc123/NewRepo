
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
    public partial class frmCategoyManagement : Form
    {
        public frmCategoyManagement()
        {
            InitializeComponent();
            dtgvListDiscount.AutoGenerateColumns = false;
            dtgvListLocation.AutoGenerateColumns = false;
            dtgvListPosition.AutoGenerateColumns = false;
            dtgvListTypeAccount.AutoGenerateColumns = false;
            dtgvListTypeProduct.AutoGenerateColumns = false;
        }


        private void frmCategoyManagement_Load(object sender, EventArgs e)
        {
            LoadLocationTable();

            LoadTypeProduct();
            LoadPosition();
            LoadTypeAccount();
            LoadListDiscount();
        }


        #region Location Table Food
        
        public void LoadLocationTable()
        {
            dtgvListLocation.DataSource = LocationBUS.Instance.GetListLocation();
            btnSaveLocation.Enabled = false;
            btnEditLocation.Enabled = true;
            btnDeleteLocation.Enabled = true;
            btnDeleteAllLocation.Enabled = true;
            ResetLocationInfo();
        }

        public void ResetLocationInfo()
        {
            txtLocationID.Clear();
            txtLocationName.Clear();
        }

        private void btnAddLocation_Click(object sender, EventArgs e)
        {
            int i = LocationBUS.Instance.GetListLocation().Count + 1;
            txtLocationID.Text = i.ToString();
            txtLocationName.Clear();
            btnSaveLocation.Enabled = true;
            btnEditLocation.Enabled = false;
            btnDeleteLocation.Enabled = false;
            btnDeleteAllLocation.Enabled = false;

        }

        private void btnSaveLocation_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtLocationName.Text))
            {
                MessageBox.Show("Vui lòng nhập tên vị trí bàn muốn thêm vào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int count = LocationBUS.Instance.AddLocationTable(txtLocationName.Text);
            if (count > 0)
            {
                MessageBox.Show("Thêm vị trí bàn thành công!", "Thêm vị trí", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                MessageBox.Show("Thêm vị trí bàn thất bại!", "Thêm vị trí", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            LoadLocationTable();
        }

        private void btnEditLocation_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtLocationName.Text))
            {
                MessageBox.Show("Vui lòng nhập tên vị trí bàn muốn sửa vào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (MessageBox.Show("Bạn chắc chắn muốn sửa vị trí bàn này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                int count = LocationBUS.Instance.UpdateLocationTable(int.Parse(txtLocationID.Text), txtLocationName.Text);
                if (count > 0)
                {
                    MessageBox.Show("Sửa vị trí bàn thành công!", "Sửa vị trí", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                {
                    MessageBox.Show("Sửa vị trí bàn thất bại!", "Sửa vị trí", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                LoadLocationTable();
            }
        }

        private void btnDeleteLocation_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn xóa vị trí này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                int count = LocationBUS.Instance.DeleteLocationTable(int.Parse(txtLocationID.Text));
                if (count > 0)
                {
                    MessageBox.Show("Xóa vị trí bàn thành công!", "Xóa vị trí", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                {
                    MessageBox.Show("Xóa vị trí bàn thất bại!", "Xóa vị trí", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                LoadLocationTable();
            }
        }

        private void btnDeleteAllLocation_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn xóa tất cả vị trí này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                int count = LocationBUS.Instance.DeleteAllLocationTable();
                if (count > 0)
                {
                    MessageBox.Show("Xóa tất cả vị trí bàn thành công!", "Xóa vị trí", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                {
                    MessageBox.Show("Xóa tất cả vị trí bàn thất bại!", "Xóa vị trí", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                LoadLocationTable();
            }
        }

        private void btnLocationDeleted_Click(object sender, EventArgs e)
        {
            frmRecycleBinCategory frm = new frmRecycleBinCategory();
            frm.Show();
        }

        private void dtgvListLocation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgvListLocation.SelectedRows.Count > 0)
                txtLocationID.Text = dtgvListLocation.SelectedRows[0].Cells[0].Value.ToString();
            txtLocationName.Text = dtgvListLocation.SelectedRows[0].Cells[1].Value.ToString();
        }
        #endregion


        #region TypeProduct
        private void LoadTypeProduct()
        {
            dtgvListTypeProduct.DataSource = CategoryFoodBUS.Instance.GetCategoryFoods();
        }

        private void dtgvListTypeProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (i == -1) return;
            txtTypeProductID.Text = dtgvListTypeProduct.Rows[i].Cells[0].Value.ToString();
            txtTypeProductName.Text = dtgvListTypeProduct.Rows[i].Cells[1].Value.ToString();
        }
        private void btnAddTypeProduct_Click(object sender, EventArgs e)
        {
            txtTypeProductID.Clear();
            txtTypeProductName.Clear();
            int id = CategoryFoodBUS.Instance.GetCategoryFoodsID().Count + 1;
            txtTypeProductID.Text = id.ToString();
            btnSaveTypeProduct.Enabled = true;
        }
        private void btnSaveTypeProduct_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTypeProductName.Text))
            {
                MessageBox.Show("Ban chua nhap ten loai san pham", "Thong bao");
                return;
            }
            int count = CategoryFoodBUS.Instance.AddCategoryFood(txtTypeProductName.Text);
            MessageBox.Show(count > 0 ? "Them thanh cong" : "Them that bai");
            LoadTypeProduct();
        }

        private void btnEditTypeProduct_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Ban co muon sua loai san pham", "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                int count = CategoryFoodBUS.Instance.UpdateCategoryFood(txtTypeProductID.Text, txtTypeProductName.Text);
                MessageBox.Show(count > 0 ? "Sua thanh cong" : "Sua that bai");
                LoadTypeProduct();
            }
        }

        private void btnDeleteTypeProduct_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Ban co muon xoa loai san pham", "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                int count = CategoryFoodBUS.Instance.DeleteCategoryFood(txtTypeProductID.Text);
                MessageBox.Show(count > 0 ? "Xoa thanh cong" : "Xoa that bai");
                LoadTypeProduct();
            }
        }
        private void btnDeleteAllTypeProduct_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Ban co muon xoa tat ca loai san pham", "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                int count = CategoryFoodBUS.Instance.DeleteAllCategoryFood();
                MessageBox.Show(count > 0 ? "Xoa thanh cong" : "Xoa that bai");
                LoadTypeProduct();
            }
        }
        #endregion

        #region Position
        private void btnAddPosition_Click(object sender, EventArgs e)
        {
            int i = PositionBUS.Instance.GetListPosition().Count + 1;
            txtPositionID.Text = i.ToString();
            btnSavePosition.Enabled = true;
            btnDeleteAllPosition.Enabled = true;
        }

        private void btnSavePosition_Click(object sender, EventArgs e)
        {
            int count = PositionBUS.Instance.AddPosition(txtPositionName.Text);
            if (count > 0)
            {
                MessageBox.Show("Thêm chức vụ thành công");
            }
            else
            {
                MessageBox.Show("Thêm chức vụ thất bại");
            }
            LoadPosition();
        }

        public void LoadPosition()
        {
            dtgvListPosition.DataSource = PositionBUS.Instance.GetListPosition();

        }

        private void btnEditPosition_Click(object sender, EventArgs e)
        {
            int count = PositionBUS.Instance.UpdatePosition(int.Parse(txtPositionID.Text), txtPositionName.Text);
            if (count > 0)
            {
                MessageBox.Show("Sửa chức vụ thành công");
            }
            else
            {
                MessageBox.Show("Sửa chức vụ thất bại");
            }
            LoadPosition();
        }

        private void dtgvListPosition_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgvListLocation.SelectedRows.Count > 0)
            {
                txtPositionID.Text = dtgvListPosition.SelectedRows[0].Cells[0].Value.ToString();
                txtPositionName.Text = dtgvListPosition.SelectedRows[0].Cells[1].Value.ToString();
            }
        }

        private void btnDeletePosition_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn chắc chắn muốn xóa tất cả chức vụ này", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                int count = PositionBUS.Instance.DeletePosition(int.Parse(txtPositionID.Text));
                if (count > 0)
                {
                    MessageBox.Show("Xóa chức vụ thành công");
                }
                else
                {
                    MessageBox.Show("Xóa chức vụ thất bại");
                }
            }
            LoadPosition();
        }

        private void btnDeleteAllPosition_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn chắc chắn muốn xóa tất cả chức vụ này", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                int count = PositionBUS.Instance.DeleteAllPosition();
                if (count > 0)
                {
                    MessageBox.Show("Xóa tất cả chức vụ thành công");
                }
                else
                {
                    MessageBox.Show("Xóa tất cả chức vụ thất bại");
                }
            }
            LoadPosition();
        }

        #endregion

        #region TypeAccount
        public void LoadTypeAccount()
        {
            dtgvListTypeAccount.DataSource = TypeAccountBUS.Instance.GetListTypeAccount();

        }
        private void dtgvListTypeAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgvListTypeAccount.SelectedRows.Count > 0)
            {
                txtTypeAccountID.Text = dtgvListTypeAccount.SelectedRows[0].Cells[0].Value.ToString();
                txtTypeAccountName.Text = dtgvListTypeAccount.SelectedRows[0].Cells[1].Value.ToString();
            }
        }

        private void btnAddTypeAccount_Click(object sender, EventArgs e)
        {
            int i = TypeAccountBUS.Instance.GetListTypeAccount().Count + 1;
            txtTypeAccountID.Text = i.ToString();
            btnSaveTypeAccount.Enabled = true;
        }

        private void btnSaveTypeAccount_Click(object sender, EventArgs e)
        {
            int count = TypeAccountBUS.Instance.AddTypeAccount(txtTypeAccountName.Text);
            if (count > 0)
            {
                MessageBox.Show("Thêm chức vụ thành công");
            }
            else
            {
                MessageBox.Show("Thêm chức vụ thất bại");
            }
            LoadTypeAccount();
        }

        private void btnEditTypeAccount_Click(object sender, EventArgs e)
        {
            int count = TypeAccountBUS.Instance.UpdateTypeAccount(int.Parse(txtTypeAccountID.Text),txtTypeAccountName.Text);
            if (count > 0)
            {
                MessageBox.Show("Sửa loại tài khoản thành công");
            }
            else
            {
                MessageBox.Show("Sửa loại tài khoản thất bại");
            }
            LoadTypeAccount();
        }

        private void btnDeleteTypeAccount_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn chắc chắn muốn xóa loại tài khoản này", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                int count = TypeAccountBUS.Instance.DeleteTypeAccount(int.Parse(txtTypeAccountID.Text));
                if (count > 0)
                {
                    MessageBox.Show("Xóa loại tài khoản thành công");
                }
                else
                {
                    MessageBox.Show("Xóa loại tài khoản thất bại");
                }
            }
            LoadTypeAccount();
        }

        private void btnDeleteAllTypeAccount_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn chắc chắn muốn xóa tất cả loại tài khoản này", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                int count = TypeAccountBUS.Instance.DeleteAllTypeAccount();
                if (count > 0)
                {
                    MessageBox.Show("Xóa tất cả loại tài khoản thành công");
                }
                else
                {
                    MessageBox.Show("Xóa tất cả loại tài khoản thất bại");
                }
            }
            LoadTypeAccount();
        }
        #endregion

        private void btnPositionDeleted_Click(object sender, EventArgs e)
        {

        }

        private void btnTypeAccountDeleted_Click(object sender, EventArgs e)
        {
            frmRecycleBinCategory frm = new frmRecycleBinCategory();
            frm.Show();
        }

        #region Discount

       public void LoadListDiscount()
        {
            dtgvListDiscount.DataSource = DiscountBUS.Instance.GetListDiscount();
            ResetDiscountInfo();
            
        }

        public void ResetDiscountInfo()
        {
            txtDiscountID.Clear();
            txtDiscountName.Clear();
            txtDiscountPrice.Clear();
            dtpDateStart.Value = DateTime.Now;
            dtpDateEnd.Value = DateTime.Now;
            cbAvailableDiscount.SelectedIndex = 0;
            btnSaveDiscount.Enabled = false;
            btnEditDiscount.Enabled = true;
            btnDeleteDiscount.Enabled = true;
            btnDeleteAllDiscount.Enabled = true;            
        }

        private void btnAddDiscount_Click(object sender, EventArgs e)
        {
            ResetDiscountInfo();
            btnSaveDiscount.Enabled = true;
            btnEditDiscount.Enabled = false;
            btnDeleteDiscount.Enabled = false;
            btnDeleteAllDiscount.Enabled = false;
            
        }

        private void dtgvListDiscount_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgvListDiscount.SelectedRows.Count > 0)
            {
                txtDiscountID.Text = dtgvListDiscount.SelectedRows[0].Cells[0].Value.ToString();
                txtDiscountName.Text = dtgvListDiscount.SelectedRows[0].Cells[1].Value.ToString();
                txtDiscountPrice.Text = dtgvListDiscount.SelectedRows[0].Cells[2].Value.ToString();
                dtpDateStart.Text = dtgvListDiscount.SelectedRows[0].Cells[3].Value.ToString();
                dtpDateEnd.Text = dtgvListDiscount.SelectedRows[0].Cells[4].Value.ToString();
                bool available = bool.Parse(dtgvListDiscount.SelectedRows[0].Cells[5].Value.ToString());
                cbAvailableDiscount.SelectedIndex = available == true ? 0 : 1;
                btnSaveDiscount.Enabled = false;
                btnEditDiscount.Enabled = true;
                btnDeleteDiscount.Enabled = true;
                btnDeleteAllDiscount.Enabled = true;
            }
        }

        private void btnSaveDiscount_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDiscountName.Text) || string.IsNullOrEmpty(txtDiscountPrice.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin giảm giá", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string discountName = txtDiscountName.Text;
            float discountPrice = float.Parse(txtDiscountPrice.Text);
            string startDay = dtpDateStart.Value.ToString("yyyy/MM/dd");
            string endDay = dtpDateEnd.Value.ToString("yyyy/MM/dd");

            int count = DiscountBUS.Instance.AddNewDiscount(discountName, startDay, endDay, discountPrice);
            if (count > 0)
            {
                MessageBox.Show("Thêm giảm giá mới thành công", "Thêm giảm giá", MessageBoxButtons.OK);
                LoadListDiscount();
            }
            else
                MessageBox.Show("Thêm giảm giá mới thất bại", "Thêm giảm giá", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnEditDiscount_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn thay đổi thông tin này ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (string.IsNullOrEmpty(txtDiscountName.Text) || string.IsNullOrEmpty(txtDiscountPrice.Text))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin giảm giá", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string discountID = txtDiscountID.Text;
                string discountName = txtDiscountName.Text;
                float discountPrice = float.Parse(txtDiscountPrice.Text);
                string startDay = dtpDateStart.Value.ToString("yyyy/MM/dd");
                string endDay = dtpDateEnd.Value.ToString("yyyy/MM/dd");
                int available = cbAvailableDiscount.SelectedIndex == 0 ? 1 : 0;

                int count = DiscountBUS.Instance.EditDiscount(discountID, discountName, startDay, endDay, discountPrice, available);
                if (count > 0)
                {
                    MessageBox.Show("Sửa giảm giá thành công", "Sửa giảm giá", MessageBoxButtons.OK);
                    LoadListDiscount();
                }
                else
                    MessageBox.Show("Sửa giảm giá thất bại", "Sửa giảm giá", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnDeleteDiscount_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn xóa giảm giá này ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {

                string discountID = txtDiscountID.Text;

                int count = DiscountBUS.Instance.DeleteDiscount(discountID);
                if (count > 0)
                {
                    MessageBox.Show("Xóa giảm giá thành công", "Xóa giảm giá", MessageBoxButtons.OK);
                    LoadListDiscount();
                }
                else
                    MessageBox.Show("Xóa giảm giá thất bại", "Xóa giảm giá", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDeleteAllDiscount_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn xóa tất cả giảm giá này ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
               
                int count = DiscountBUS.Instance.DeleteAllDiscount();
                if (count > 0)
                {
                    MessageBox.Show("Xóa tất cả giảm giá thành công", "Xóa giảm giá", MessageBoxButtons.OK);
                    LoadListDiscount();
                }
                else
                    MessageBox.Show("Xóa tất cả giảm giá thất bại", "Xóa giảm giá", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDiscountDeleted_Click(object sender, EventArgs e)
        {
            frmRecycleBinCategory frm = new frmRecycleBinCategory();
            frm.Show();
        }

        #endregion


    }
}
