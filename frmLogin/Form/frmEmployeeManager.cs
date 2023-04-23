using frmLogin.Data_Access_Layer;
using frmLogin.Data_Tranfer_Object;
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
    public partial class frmEmployeeManager : Form
    {
        public frmEmployeeManager()
        {
            InitializeComponent();
            dtgvListEmployee.AutoGenerateColumns = false;
            cbSortEmployee.SelectedIndex = 0;
        }

        private void btnEmployeeDeleted_Click(object sender, EventArgs e)
        {
            frmRecycleBin frm = new frmRecycleBin();
            frm.Show();
        }

        private void frmEmployeeManager_Load(object sender, EventArgs e)
        {
            dtgvListEmployee.DataSource = EmployeeMenuBUS.Instance.GetListEmployee();
            cbPosition.DataSource = PositionBUS.Instance.GetListPosition();
            cbPosition.DisplayMember = "TENCHUCVU";
            cbPosition.ValueMember = "MACHUCVU";
            btnSaveEmployee.Enabled = false;
            btnDeleteEmployee.Enabled = true;
            btnDeleteAllEmployee.Enabled = true;
            btnEditEmployee.Enabled = true;
            radMale.Checked = true;
        }

        private void dtgvListEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgvListEmployee.SelectedRows.Count > 0)
            {
                txtEmployeeID.Text = dtgvListEmployee.SelectedRows[0].Cells[0].Value.ToString();
                txtEmployeeName.Text = dtgvListEmployee.SelectedRows[0].Cells[1].Value.ToString();
                dtpBirthday.Text = dtgvListEmployee.SelectedRows[0].Cells[2].Value.ToString();
                txtNumberPhone.Text = dtgvListEmployee.SelectedRows[0].Cells[4].Value.ToString();
                richtxtAddress.Text = dtgvListEmployee.SelectedRows[0].Cells[5].Value.ToString();
                dtpWorkingDay.Text = dtgvListEmployee.SelectedRows[0].Cells[6].Value.ToString();
                string gender = dtgvListEmployee.SelectedRows[0].Cells[3].Value.ToString();
                if (gender == radMale.Text)
                    radMale.Checked = true;
                else
                    radFemale.Checked = true;
                cbPosition.SelectedValue = Convert.ToInt32(dtgvListEmployee.SelectedRows[0].Cells[8].Value.ToString());
            }
        }

        private void btnEditEmployee_Click(object sender, EventArgs e)
        {
            string gender = radMale.Checked == true ? radMale.Text : radFemale.Text;
            int count = EmployeeBUS.Instance.UpdateEmployee(int.Parse(txtEmployeeID.Text), txtEmployeeName.Text, dtpBirthday.Value.ToString("yyyy/MM/dd"), gender, txtNumberPhone.Text, richtxtAddress.Text);
            if (count > 0)
            {
                MessageBox.Show("Sửa tài khoản thành công");
            }
            else
            {
                MessageBox.Show("Sửa tài khoản thất bại");
            }
            frmEmployeeManager_Load(sender, e);
        }

        private void btnDeleteEmployee_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn chắc chắn muốn xóa nhân viên này", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                int count = EmployeeBUS.Instance.DeleteEmployeeInfo(int.Parse(txtEmployeeID.Text));
                if (count > 0)
                {
                    MessageBox.Show("Xóa tài khoản thành công");
                }
                else
                {
                    MessageBox.Show("Xóa tài khoản thất bại");
                }
            }
            frmEmployeeManager_Load(sender, e);
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            txtEmployeeID.Text = EmployeeBUS.Instance.GetEmployeeIDMax().ToString();
            //txtEmployeeID.Enabled = false;
            txtEmployeeName.Clear();
            cbPosition.SelectedIndex = 0;
            radMale.Checked = true;
            richtxtAddress.Clear();
            txtNumberPhone.Clear();
            btnSaveEmployee.Enabled = true;
            btnDeleteEmployee.Enabled = false;
            btnDeleteAllEmployee.Enabled = false;
            btnEditEmployee.Enabled = false;
        }

        private void btnSaveEmployee_Click(object sender, EventArgs e)
        {
            string gender = radMale.Checked == true ? radMale.Text : radFemale.Text;
            int count = EmployeeBUS.Instance.AddEmployee(txtEmployeeName.Text, dtpBirthday.Value.ToString("yyyy/MM/dd"), gender, dtpWorkingDay.Value.ToString("yyyy/MM/dd"), (int)cbPosition.SelectedValue, txtNumberPhone.Text, richtxtAddress.Text);
            if (count > 0)
            {
                MessageBox.Show("Thêm tài khoản thành công");
            }
            else
            {
                MessageBox.Show("Thêm tài khoản thất bại");
            }
            frmEmployeeManager_Load(sender, e);
        }

        private void btnDeleteAllEmployee_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn chắc chắn muốn xóa toàn bộ nhân viên", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                int count = EmployeeBUS.Instance.DeleteAllEmployee();
                if (count > 0)
                {
                    MessageBox.Show("Xóa tất cả tài khoản thành công");
                }
                else
                {
                    MessageBox.Show("Xóa tất cả tài khoản thất bại");
                }
            }
            frmEmployeeManager_Load(sender, e);
        }

        private void txtSearchEmployee_TextChanged(object sender, EventArgs e)
        {
            dtgvListEmployee.DataSource = EmployeeMenuBUS.Instance.SearchEmloyeeName(txtSearchEmployee.Text);
        }

        private void btnSearchEmployee_Click(object sender, EventArgs e)
        {
            dtgvListEmployee.DataSource = EmployeeMenuBUS.Instance.SearchEmloyeeName(txtSearchEmployee.Text);
        }

        private void cbSortEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSortEmployee.SelectedIndex == 0)
            {
                dtgvListEmployee.DataSource = EmployeeMenuBUS.Instance.GetListEmployee();
            }
            else if (cbSortEmployee.SelectedIndex == 1)
            {
                dtgvListEmployee.DataSource = EmployeeMenuBUS.Instance.SortListEmployeeByEmployeeName();
            }
            else
            {
                dtgvListEmployee.DataSource = EmployeeMenuBUS.Instance.SortListEmployeeByEmployeeID();
            }
        }
    }
}
