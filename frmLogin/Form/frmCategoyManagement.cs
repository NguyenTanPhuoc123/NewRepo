using frmLogin.Data_Access_Layer;
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
        }


        private void frmCategoyManagement_Load(object sender, EventArgs e)
        {
            LoadLocationTable();
            LoadListSizeProduct();
            LoadTypeCustomer();
            LoadTypeProduct();
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
            txtLocationID.Text = LocationBUS.Instance.GetLocationIDMax().ToString();
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

        #region Size Product
        private void dtgvListSize_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgvListSize.SelectedRows.Count > 0)
            {
                txtSizeID.Text = dtgvListSize.SelectedRows[0].Cells[0].Value.ToString();
                txtSizeName.Text = dtgvListSize.SelectedRows[0].Cells[1].Value.ToString();
                txtSizePrice.Text = dtgvListSize.SelectedRows[0].Cells[2].Value.ToString();
            }
        }
        public void LoadListSizeProduct()
        {
            dtgvListSize.DataSource = SizeProductBUS.Instance.GetListSizeProduct();
            ResetSizeInfo();
        }

        public void ResetSizeInfo()
        {
            txtSizeName.Clear();
            txtSizePrice.Clear();
            btnSaveSize.Enabled = false;
            btnEditSize.Enabled = true;
            btnDeleteAllSize.Enabled = true;
            btnDeleteSize.Enabled = true;
        }


        private void btnSizeDeleted_Click(object sender, EventArgs e)
        {
            frmRecycleBinCategory frm = new frmRecycleBinCategory();
            frm.Show();
        }

        private void txtSizePrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void btnAddSize_Click(object sender, EventArgs e)
        {
            txtSizeID.Text = SizeProductBUS.Instance.GetSizeIDMax().ToString();
            txtSizeName.Clear();
            txtSizePrice.Clear();
            btnSaveSize.Enabled = true;
            btnEditSize.Enabled = false;
            btnDeleteAllSize.Enabled = false;
            btnDeleteSize.Enabled = false;
        }

        private void btnSaveSize_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSizeName.Text) || string.IsNullOrEmpty(txtSizePrice.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin mà bạn muốn thêm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int count = SizeProductBUS.Instance.AddSizeProduct(txtSizeName.Text, float.Parse(txtSizePrice.Text));
            if (count > 0)
            {
                MessageBox.Show("Thêm kích thước mới thành công", "Thêm kích thước", MessageBoxButtons.OK);
                LoadListSizeProduct();
            }
            else
                MessageBox.Show("Thêm kích thước mới thất bại", "Thêm kích thước", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnEditSize_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thay đổi thông tin kích thước này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (string.IsNullOrEmpty(txtSizeName.Text) || string.IsNullOrEmpty(txtSizePrice.Text))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin mà bạn muốn sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                int count = SizeProductBUS.Instance.EditSizeProduct(int.Parse(txtSizeID.Text), txtSizeName.Text, float.Parse(txtSizePrice.Text));
                if (count > 0)
                {
                    MessageBox.Show("Sửa kích thước thành công", "Sửa kích thước", MessageBoxButtons.OK);
                    LoadListSizeProduct();
                }
                else
                    MessageBox.Show("Sửa kích thước thất bại", "Sửa kích thước", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteSize_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn xóa kích thước này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {

                int count = SizeProductBUS.Instance.DeleteSizeProduct(int.Parse(txtSizeID.Text));
                if (count > 0)
                {
                    MessageBox.Show("Xóa kích thước thành công", "Xóa kích thước", MessageBoxButtons.OK);
                    LoadListSizeProduct();
                }
                else
                    MessageBox.Show("Xóa kích thước thất bại", "Xóa kích thước", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteAllSize_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn xóa tất cả các kích thước này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {

                int count = SizeProductBUS.Instance.DeleteAllSizeProduct();
                if (count > 0)
                {
                    MessageBox.Show("Xóa tất cả kích thước thành công", "Xóa kích thước", MessageBoxButtons.OK);
                    LoadListSizeProduct();
                }
                else
                    MessageBox.Show("Xóa tất cả kích thước thất bại", "Xóa kích thước", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        #endregion

        #region Type Customer
        public void LoadTypeCustomer()
        {
            dtgvListTypeCustomer.DataSource = TypeCustomerBUS.Instance.GetListTypeCustomer();
            ResetInfo();
            btnSaveTypeCustomer.Enabled = false;
            btnEditTypeCustomer.Enabled = true;
            btnDeleteAllTypeCustomer.Enabled = true;
            btnDeleteTypeCustomer.Enabled = true;
        }

        public void ResetInfo()
        {
            txtTypeCustomerID.Clear();
            txtTypeCustomerName.Clear();
        }

        private void btnAddTypeCustomer_Click(object sender, EventArgs e)
        {
            txtTypeCustomerID.Text = TypeCustomerBUS.Instance.GetTypeCustomerIDMax().ToString();
            txtTypeCustomerName.Clear();
            btnSaveTypeCustomer.Enabled = true;
            btnEditTypeCustomer.Enabled = false;
            btnDeleteAllTypeCustomer.Enabled = false;
            btnDeleteTypeCustomer.Enabled = false;
        }

        private void btnSaveTypeCustomer_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTypeCustomerName.Text))
            {
                MessageBox.Show("Vui lòng nhập tên loại khách hàng muốn thêm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int count = TypeCustomerBUS.Instance.AddTypeCustomer(txtTypeCustomerName.Text);
            if (count > 0)
            {
                MessageBox.Show("Thêm loại khách hàng mới thành công", "Thêm loại khách hàng", MessageBoxButtons.OK);
                LoadTypeCustomer();
            }
            else
                MessageBox.Show("Thêm loại khách hàng mới thất bại", "Thêm loại khách hàng", MessageBoxButtons.OK,MessageBoxIcon.Error);       
        }

        private void btnEditTypeCustomer_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn sửa loại khách hàng này chứ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (string.IsNullOrEmpty(txtTypeCustomerName.Text))
                {
                    MessageBox.Show("Vui lòng nhập tên loại khách hàng muốn sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int count = TypeCustomerBUS.Instance.EditTypeCustomer(int.Parse(txtTypeCustomerID.Text), txtTypeCustomerName.Text);
                if (count > 0)
                {
                    MessageBox.Show("Sửa loại khách hàng thành công", "Sửa loại khách hàng", MessageBoxButtons.OK);
                    LoadTypeCustomer();
                }
                else
                    MessageBox.Show("Sửa loại khách hàng thất bại", "Sửa loại khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }          
        }

        private void btnDeleteTypeCustomer_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn xóa loại khách hàng này chứ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                int count = TypeCustomerBUS.Instance.DeleteTypeCustomer(int.Parse(txtTypeCustomerID.Text));
                if (count > 0)
                {
                    MessageBox.Show("Xóa loại khách hàng thành công", "Xóa loại khách hàng", MessageBoxButtons.OK);
                    LoadTypeCustomer();
                }
                else
                    MessageBox.Show("Xóa loại khách hàng thất bại", "Xóa loại khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            
        }

        private void btnDeleteAllTypeCustomer_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn xóa tất cả  loại khách hàng này chứ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                int count = TypeCustomerBUS.Instance.DeleteAllTypeCustomer();
                if (count > 0)
                {
                    MessageBox.Show("Xóa tất cả loại khách hàng thành công", "Xóa loại khách hàng", MessageBoxButtons.OK);
                    LoadTypeCustomer();
                }
                else
                    MessageBox.Show("Xóa tất cả loại khách hàng thất bại", "Xóa loại khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnTypeCustomerDeleted_Click(object sender, EventArgs e)
        {
            frmRecycleBinCategory frm = new frmRecycleBinCategory();
            frm.Show();
        }

        private void dtgvListTypeCustomer_SelectionChanged(object sender, EventArgs e)
        {
            btnSaveTypeCustomer.Enabled = false;
            btnEditTypeCustomer.Enabled = true;
            btnDeleteAllTypeAccount.Enabled = true;
            btnDeleteTypeCustomer.Enabled = true;
            if (dtgvListTypeCustomer.SelectedRows.Count > 0)
            {
                txtTypeCustomerID.Text = dtgvListTypeCustomer.SelectedRows[0].Cells[0].Value.ToString();
                txtTypeCustomerName.Text = dtgvListTypeCustomer.SelectedRows[0].Cells[1].Value.ToString();
            }
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

    }
}
