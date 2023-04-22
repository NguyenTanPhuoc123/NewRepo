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

namespace frmLogin
{
    public partial class frmEmployeeManager : Form
    {
        public frmEmployeeManager()
        {
            InitializeComponent();
            dtgvListEmployee.AutoGenerateColumns = false;
        }

        private void btnEmployeeDeleted_Click(object sender, EventArgs e)
        {
            frmRecycleBin frm = new frmRecycleBin();
            frm.Show();
        }

        private void frmEmployeeManager_Load(object sender, EventArgs e)
        {
            dtgvListEmployee.DataSource = EmployeeDAF.Instance.GetListEmployee();
            cbPosition.DataSource = PositionDAF.Instance.GetListPosition();
            cbPosition.DisplayMember = "TENCHUCVU";
            cbPosition.ValueMember = "MACHUCVU";
        }

        private void dtgvListEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            bool gender = dtgvListEmployee.Rows[0].Cells[3].Value.ToString().Equals("Nam") ? true : false;
            txtEmployeeID.Text = dtgvListEmployee.SelectedRows[0].Cells[0].Value.ToString();
            txtEmployeeName.Text = dtgvListEmployee.SelectedRows[0].Cells[1].Value.ToString();
            dtpBirthday.Text = dtgvListEmployee.SelectedRows[0].Cells[2].Value.ToString();
            txtNumberPhone.Text = dtgvListEmployee.SelectedRows[0].Cells[4].Value.ToString();
            richtxtAddress.Text = dtgvListEmployee.SelectedRows[0].Cells[5].Value.ToString();
            dtpWorkingDay.Text = dtgvListEmployee.SelectedRows[0].Cells[6].Value.ToString();
            if (gender == true)
            {

                radMale.Checked = true;
            }
            else
                radFemale.Checked = true;
            cbPosition.SelectedValue = Convert.ToInt32(dtgvListEmployee.SelectedRows[0].Cells[8].Value.ToString());
        }

        private void btnEditEmployee_Click(object sender, EventArgs e)
        {
            string gender = radMale.Checked == true ? radMale.Text : radFemale.Text;
            int count = EmployeeDAF.Instance.UpdateEmployee(int.Parse(txtEmployeeID.Text), txtEmployeeName.Text, dtpBirthday.Value.ToString(), gender, txtNumberPhone.Text, richtxtAddress.Text);
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
                int count = EmployeeDAF.Instance.DeleteEmployeeInfo(int.Parse(txtEmployeeID.Text));
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
            txtEmployeeID.Text = EmployeeDAF.Instance.GetEmployeeIDMax().ToString();
            txtEmployeeName.Clear();
            cbPosition.SelectedIndex = 0;
            cbPosition.SelectedIndex = 0;
            btnSaveEmployee.Enabled = true;
            btnDeleteEmployee.Enabled = false;
            btnDeleteAllEmployee.Enabled = false;
            btnEditEmployee.Enabled = false;
        }

        private void btnSaveEmployee_Click(object sender, EventArgs e)
        {
            string gender = radMale.Checked == true ? radMale.Text : radFemale.Text;
            int count = EmployeeDAF.Instance.AddEmployee(txtEmployeeName.Text, dtpBirthday.Value.ToString(), gender, dtpWorkingDay.Value.ToString(), cbPosition.SelectedValue.ToString(), txtNumberPhone.Text, richtxtAddress.Text);
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
                int count = EmployeeDAF.Instance.DeleteAllEmployee();
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
    }
}
