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

namespace frmLogin
{
    public partial class frmCategoyManagement : Form
    {
        public frmCategoyManagement()
        {
            InitializeComponent();
        }

        private void btnAddLocation_Click(object sender, EventArgs e)
        {
            txtLocationID.Text = LocationDAF.Instance.GetLocationIDMax().ToString();
            btnSaveLocation.Enabled = true;
            btnEditLocation.Enabled = false;
            btnDeleteLocation.Enabled = false;
            btnDeleteAllLocation.Enabled = false;
            
        }

        public void ResetLocationInfo()
        {
            txtLocationID.Clear();
            txtLocationName.Clear();
        }

        private void frmCategoyManagement_Load(object sender, EventArgs e)
        {
            ResetLocationInfo();
            LoadLocationTable();
        }

        public void LoadLocationTable()
        {
            dtgvListLocation.DataSource = LocationDAF.Instance.GetListLocation();
            btnSaveLocation.Enabled = false;
            btnEditLocation.Enabled = true;
            btnDeleteLocation.Enabled = true;
            btnDeleteAllLocation.Enabled = true;
        }

        private void btnSaveLocation_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtLocationName.Text))
            {
                MessageBox.Show("Vui lòng nhập tên vị trí bàn muốn thêm vào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int count = LocationDAF.Instance.AddLocationTable(txtLocationName.Text);
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
                int count = LocationDAF.Instance.UpdateLocationTable(int.Parse(txtLocationID.Text),txtLocationName.Text);
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
                int count = LocationDAF.Instance.DeleteLocationTable(int.Parse(txtLocationID.Text));
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
                int count = LocationDAF.Instance.DeleteAllLocationTable();
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
    }
}
