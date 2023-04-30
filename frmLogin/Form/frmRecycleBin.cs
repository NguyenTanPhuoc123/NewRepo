
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
using System.IO;

namespace frmLogin
{
    public partial class frmRecycleBin : Form
    {
        public frmRecycleBin()
        {
            InitializeComponent();
            dtgvListEmployeeDeleted.AutoGenerateColumns = false;
            dtgvListProductDeleted.AutoGenerateColumns = false;
        }

        private void frmRecycleBin_Load(object sender, EventArgs e)
        {
            LoadAccountDeleted();
            LoadTableFoodDeleted();
            LoadCustomerDeleted();
            LoadProductDeleted();
            LoadEmployeeDeleted();
        }

        private void btnExitFormSelectDish_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region TableFood 
        void LoadTableFoodDeleted()
        {
            dtgvListTableFoodDeleted.DataSource = TableMenuBUS.Instance.GetListTableMenuDeleted();
        }

        private void dtgvListTableFoodDeleted_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgvListTableFoodDeleted.SelectedRows.Count > 0)
            {
                txtTableID.Text = dtgvListTableFoodDeleted.SelectedRows[0].Cells[0].Value.ToString();
                txtTableName.Text = dtgvListTableFoodDeleted.SelectedRows[0].Cells[1].Value.ToString();
                txtLocation.Text = dtgvListTableFoodDeleted.SelectedRows[0].Cells[4].Value.ToString();

            }
        }

        private void btnRestoreTable_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn khôi phục lại bàn ăn này chứ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    int count = TableBUS.Instance.RestoreTable(int.Parse(txtTableID.Text));
                    if (count > 0)
                        MessageBox.Show("Khôi phục thành công ", "Khôi phục bàn ăn", MessageBoxButtons.OK);
                    else
                        MessageBox.Show("Khôi phục thất bại ", "Khôi phục bàn ăn", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                LoadTableFoodDeleted();
            }
        }

        private void btnRestoreAllTable_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn khôi phục lại tất cả bàn ăn chứ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    int count = TableBUS.Instance.RestoreAllTable();
                    if (count > 0)
                        MessageBox.Show("Khôi phục tất cả thành công ", "Khôi phục bàn ăn", MessageBoxButtons.OK);
                    else
                        MessageBox.Show("Khôi phục tất cả thất bại ", "Khôi phục bàn ăn", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                LoadTableFoodDeleted();
            }
        }
        #endregion
       

        #region Account
        private void btnRestoreAccount_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn phục hồi lại tài khoản này?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                int count = AccountBUS.Instance.RestoreAccountByUserName(txtUsername.Text);
                if (count > 0)
                    MessageBox.Show("Khôi phục thành công", "Khôi phục tài khoản", MessageBoxButtons.OK);
                else
                    MessageBox.Show("Khôi phục thất bại", "Khôi phục tài khoản", MessageBoxButtons.OK);
            }
            frmRecycleBin_Load(sender, e);

        }

        private void btnRestoreAllAccount_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn phục hồi lại tất cả tài khoản này?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                int count = AccountBUS.Instance.RestoreAllAccount();
                if (count > 0)
                    MessageBox.Show("Khôi phục thành công", "Khôi phục tài khoản", MessageBoxButtons.OK);
                else
                    MessageBox.Show("Khôi phục thất bại", "Khôi phục tài khoản", MessageBoxButtons.OK);
            }
        }

        public void LoadAccountDeleted()
        {
            dtgvListAccountDeleted.DataSource = AccountBUS.Instance.GetListAccountDeleted();
        }

        private void dtgvListAccountDeleted_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtUsername.Text = dtgvListAccountDeleted.SelectedRows[0].Cells[0].Value.ToString();
            txtPassword.Text = dtgvListAccountDeleted.SelectedRows[0].Cells[1].Value.ToString();
            txtEmployee.Text = dtgvListAccountDeleted.SelectedRows[0].Cells[2].Value.ToString();
            int type = int.Parse(dtgvListAccountDeleted.SelectedRows[0].Cells[3].Value.ToString());
            if (type == 1)
                txtTypeAccount.Text = "Nhân viên quản lý";
            else
                txtTypeAccount.Text = "Nhân viên bán hàng";

        }
        #endregion

        #region Product
        private void LoadProductDeleted()
        {
            dtgvListProductDeleted.DataSource = ProductBUS.Instance.GetProductDeleted();
        }
        private void dtgvListProductDeleted_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (i == -1) return;
            MemoryStream memoryStream = new MemoryStream((byte[])dtgvListProductDeleted.Rows[i].Cells[0].Value);
            pbProduct.Image = Image.FromStream(memoryStream);
            txtProductID.Text = dtgvListProductDeleted.Rows[i].Cells[1].Value.ToString();
            txtProductName.Text = dtgvListProductDeleted.Rows[i].Cells[2].Value.ToString();
            cbCategory.SelectedValue = dtgvListProductDeleted.Rows[i].Cells[4].Value;
            numQuantity.Value = Convert.ToInt32(dtgvListProductDeleted.Rows[i].Cells[5].Value);
            txtPrice.Text = dtgvListProductDeleted.Rows[i].Cells[6].Value.ToString();
            richtxtDescribe.Text = dtgvListProductDeleted.Rows[i].Cells[7].Value.ToString();
        }
        private void btnRestoreProduct_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Ban co muon khoi phuc san pham", "Thong Bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                int cout = ProductBUS.Instance.RestoreProduct(txtProductID.Text);
                MessageBox.Show(cout > 0 ? "Khoi phuc thanh cong" : "Khoi phuc that bai");
            }
        }
        private void btnRestoreAllProduct_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Ban co muon khoi phuc tat ca san pham", "Thong Bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                int cout = ProductBUS.Instance.RestoreProductAll();
                MessageBox.Show(cout > 0 ? "Khoi phuc thanh cong" : "Khoi phuc that bai");
            }
        }
        #endregion
        #region Customer
        public void LoadCustomerDeleted()
        {
            dtgvListCustomerDeleted.DataSource = CustomerMenuBUS.Instance.GetListCustomerMenuDeleted();
            ResetInfo();
        }

        public void ResetInfo()
        {
            txtCustomerID.Clear();
            txtCustomerName.Clear();
            txtCustomerNumberPhone.Clear();
            txtTypeCustomer.Clear();
            radMale.Checked = true;
        }

        private void dtgvListCustomerDeleted_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgvListCustomerDeleted.SelectedRows.Count > 0)
            {
                txtCustomerID.Text = dtgvListCustomerDeleted.SelectedRows[0].Cells[0].Value.ToString();
                txtCustomerName.Text = dtgvListCustomerDeleted.SelectedRows[0].Cells[1].Value.ToString();
                string gender = dtgvListCustomerDeleted.SelectedRows[0].Cells[5].Value.ToString();
                if (gender == radMale.Text)
                    radCustomerMale.Checked = true;
                else
                    radCustomerFemale.Checked = true;
                txtCustomerNumberPhone.Text = dtgvListCustomerDeleted.SelectedRows[0].Cells[2].Value.ToString();
                txtTypeCustomer.Text = dtgvListCustomerDeleted.SelectedRows[0].Cells[4].Value.ToString();
            }
        }

        #endregion

        private void btnRestoreCustomer_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc muốn khôi phục khách hàng này ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int count = CustomerBUS.Instance.RestoreCustomer(txtCustomerID.Text);

                if (count > 0)
                {
                    MessageBox.Show("Khôi phục khách hàng thành công", "Khôi phục khách hàng", MessageBoxButtons.OK);
                    LoadCustomerDeleted();
                   
                }
                else
                    MessageBox.Show("Khôi phục khách hàng  thất bại", "Khôi phục khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRestoreAllCustomer_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc muốn khôi phục tất cả khách hàng này ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                int count = CustomerBUS.Instance.RestoreAllCustomer();

                if (count > 0)
                {
                    MessageBox.Show("Khôi phục tất cả khách hàng thành công", "Khôi phục khách hàng", MessageBoxButtons.OK);
                    LoadCustomerDeleted();
                }
                else
                    MessageBox.Show("Khôi phục tất cả khách hàng  thất bại", "Khôi phục khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region Employee
        public void LoadEmployeeDeleted()
        {
            
            dtgvListEmployeeDeleted.DataSource = EmployeeMenuBUS.Instance.GetListEmployeeDeleted();
            cbPosition.DataSource = PositionBUS.Instance.GetListPosition();
            cbPosition.DisplayMember = "TENCHUCVU";
            cbPosition.ValueMember = "MACHUCVU";
        }

        private void btnRestoreEmployee_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn phục hồi lại nhân viên này?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                int count = EmployeeBUS.Instance.RestoreEmployeeInfo(Convert.ToInt32(txtEmployeeID.Text));
                if (count > 0)
                    MessageBox.Show("Khôi phục thành công", "Khôi phục nhân viên", MessageBoxButtons.OK);
                else
                    MessageBox.Show("Khôi phục thất bại", "Khôi phục nhân viên", MessageBoxButtons.OK);
            }
            frmRecycleBin_Load(sender, e);
        }

        private void btnRestoreAllEmployee_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn phục hồi lại tất cả nhân viên này?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                int count = EmployeeBUS.Instance.RestoreAllEmployee();
                if (count > 0)
                    MessageBox.Show("Khôi phục thành công", "Khôi phục nhân viên", MessageBoxButtons.OK);
                else
                    MessageBox.Show("Khôi phục thất bại", "Khôi phục nhân viên", MessageBoxButtons.OK);
            }
            frmRecycleBin_Load(sender, e);
        }

        private void dtgvListEmployeeDeleted_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgvListEmployeeDeleted.SelectedRows.Count > 0)
            {
                txtEmployeeID.Text = dtgvListEmployeeDeleted.SelectedRows[0].Cells[0].Value.ToString();
                txtEmployeeName.Text = dtgvListEmployeeDeleted.SelectedRows[0].Cells[1].Value.ToString();
                dtpBirthday.Text = dtgvListEmployeeDeleted.SelectedRows[0].Cells[2].Value.ToString();
                txtNumberPhone.Text = dtgvListEmployeeDeleted.SelectedRows[0].Cells[4].Value.ToString();
                richtxtAddress.Text = dtgvListEmployeeDeleted.SelectedRows[0].Cells[5].Value.ToString();
                dtpWorkingDay.Text = dtgvListEmployeeDeleted.SelectedRows[0].Cells[6].Value.ToString();
                string gender = dtgvListEmployeeDeleted.SelectedRows[0].Cells[3].Value.ToString();
                if (gender == radMale.Text)
                    radMale.Checked = true;
                else
                    radFemale.Checked = true;
                cbPosition.SelectedValue = Convert.ToInt32(dtgvListEmployeeDeleted.SelectedRows[0].Cells[8].Value.ToString());
            }
        }
        #endregion
    }
}
