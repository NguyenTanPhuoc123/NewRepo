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
        public  void LoadListSizeProduct()
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

      
    }
}
