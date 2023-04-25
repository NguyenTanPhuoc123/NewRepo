using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace frmLogin
{
    public partial class frmCustomerManagement : Form
    {
        public frmCustomerManagement()
        {
            InitializeComponent();
        }

        private void btnCustomerDeleted_Click(object sender, EventArgs e)
        {
            frmRecycleBin frm = new frmRecycleBin();
            frm.Show();
        }

        private void frmCustomerManagement_Load(object sender, EventArgs e)
        {          
            cbTypeCustomer.DataSource = TypeCustomerBUS.Instance.GetListTypeCustomer();
            cbTypeCustomer.ValueMember = "TypeID";
            cbTypeCustomer.DisplayMember = "TypeName";
            dtgvListCustomer.DataSource = CustomerMenuBUS.Instance.GetListCustomerMenu();
            ResetInfo();
        }

        public void ResetInfo()
        {
            txtCustomerID.Clear();
            txtCustomerName.Clear();
            txtCustomerNumberPhone.Clear();
            txtSearchCustomer.Clear();
            cbTypeCustomer.SelectedIndex = 0;
            //cbFillCustomer.SelectedIndex = 0;
            //cbSortCustomer.SelectedIndex = 0;
            radMale.Checked = true;
            btnSaveCustomer.Enabled = false;
            btnEditCustomer.Enabled = true;
            btnDeleteCustomer.Enabled = true;
            btnDeleteAllCustomer.Enabled = true;
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            txtCustomerID.Text = CustomerBUS.Instance.GetCustomerID();
            txtCustomerName.Clear();
            txtCustomerNumberPhone.Clear();
            txtSearchCustomer.Clear();
            radMale.Checked = true;
            cbTypeCustomer.SelectedIndex = 0;
            btnSaveCustomer.Enabled = true;
            btnEditCustomer.Enabled = false;
            btnDeleteCustomer.Enabled = false;
            btnDeleteAllCustomer.Enabled = false;
        }


        private void btnSaveCustomer_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtCustomerName.Text) || string.IsNullOrEmpty(txtCustomerNumberPhone.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string gender = radMale.Checked ? "Nam" : "Nữ";
            int count = CustomerBUS.Instance.AddNewCustomer(txtCustomerName.Text, txtCustomerNumberPhone.Text, int.Parse(cbTypeCustomer.SelectedValue.ToString()), gender);

            if(count>0)
            {
                MessageBox.Show("Thêm khách hàng mới thành công", "Thêm khách hàng", MessageBoxButtons.OK);
                frmCustomerManagement_Load(sender, e);
            }
            else
                MessageBox.Show("Thêm khách hàng mới thất bại", "Thêm khách hàng", MessageBoxButtons.OK,MessageBoxIcon.Error);
        }

        private void dtgvListCustomer_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgvListCustomer.SelectedRows.Count > 0)
            {
                txtCustomerID.Text = dtgvListCustomer.SelectedRows[0].Cells[0].Value.ToString();
                txtCustomerName.Text = dtgvListCustomer.SelectedRows[0].Cells[1].Value.ToString();
                string gender = dtgvListCustomer.SelectedRows[0].Cells[5].Value.ToString();
                if (gender == radMale.Text)
                    radMale.Checked = true;
                else
                    radFemale.Checked = true;

                txtCustomerNumberPhone.Text = dtgvListCustomer.SelectedRows[0].Cells[2].Value.ToString();
                cbTypeCustomer.SelectedValue = dtgvListCustomer.SelectedRows[0].Cells[3].Value;
                btnSaveCustomer.Enabled = false;
                btnEditCustomer.Enabled = true;
                btnDeleteCustomer.Enabled = true;
                btnDeleteAllCustomer.Enabled = true;
            }
        }

        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn chắc muốn thay đổi thông tin khách hàng này ?","Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (string.IsNullOrEmpty(txtCustomerName.Text) || string.IsNullOrEmpty(txtCustomerNumberPhone.Text))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string gender = radMale.Checked ? "Nam" : "Nữ";
                int count = CustomerBUS.Instance.EditCustomer(txtCustomerID.Text,txtCustomerName.Text, txtCustomerNumberPhone.Text, int.Parse(cbTypeCustomer.SelectedValue.ToString()), gender);

                if (count > 0)
                {
                    MessageBox.Show("Sửa khách hàng thành công", "Sửa khách hàng", MessageBoxButtons.OK);
                    frmCustomerManagement_Load(sender, e);
                }
                else
                    MessageBox.Show("Sửa khách hàng thất bại", "Sửa khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc muốn xóa khách hàng này ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                int count = CustomerBUS.Instance.DeleteCustomer(txtCustomerID.Text);

                if (count > 0)
                {
                    MessageBox.Show("Xóa khách hàng thành công", "Xóa khách hàng", MessageBoxButtons.OK);
                    frmCustomerManagement_Load(sender, e);
                }
                else
                    MessageBox.Show("Xóa khách hàng  thất bại", "Xóa khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteAllCustomer_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc muốn xóa tất cả khách hàng này ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                int count = CustomerBUS.Instance.DeleteAllCustomer();

                if (count > 0)
                {
                    MessageBox.Show("Xóa tất cả khách hàng thành công", "Xóa khách hàng", MessageBoxButtons.OK);
                    frmCustomerManagement_Load(sender, e);
                }
                else
                    MessageBox.Show("Xóa tất cả khách hàng  thất bại", "Xóa khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
    }
}
