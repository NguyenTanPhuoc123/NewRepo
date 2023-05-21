
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;
namespace frmLogin
{
    public partial class frmEmployeeManager : Form
    {
        private int Language = frmlogin.Language;
        public frmEmployeeManager()
        {
            if (Language == 0)
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("vi");
            else
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en");
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
            LoadEmployee();
            cbPosition.DataSource = PositionBUS.Instance.GetListPosition();
            cbPosition.DisplayMember = "TENCHUCVU";
            cbPosition.ValueMember = "MACHUCVU";
            btnSaveEmployee.Enabled = false;
            btnDeleteEmployee.Enabled = true;
            btnDeleteAllEmployee.Enabled = true;
            btnEditEmployee.Enabled = true;
            radMale.Checked = true;
            LoadCbFill();
        }
        public void LoadEmployee()
        {
            dtgvListEmployee.DataSource = EmployeeMenuBUS.Instance.GetListEmployee();
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
            if (EmployeeBUS.Instance.CheckNumberPhone(txtNumberPhone.Text, txtEmployeeID.Text) && EmployeeBUS.Instance.CheckAge(dtpBirthday.Value))
            {
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
            else
            {
                MessageBox.Show("Số điện thoại của bạn tối đa 10 số và các số điện thoại không được trùng nhau hoặc bạn chưa đủ 18 tuổi");
            }

        }

        private void btnDeleteEmployee_Click(object sender, EventArgs e)
        {

            if (DialogResult.Yes == MessageBox.Show("Bạn chắc chắn muốn xóa nhân viên này", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                if (EmployeeBUS.Instance.CheckAccountDelete(txtEmployeeName.Text))
                {
                    int count = EmployeeBUS.Instance.DeleteEmployeeInfo(int.Parse(txtEmployeeID.Text));
                    if (count > 0)
                    {
                        MessageBox.Show("Xóa nhân viên thành công");
                    }
                    else
                    {
                        MessageBox.Show("Xóa nhân viên thất bại");
                    }
                    frmEmployeeManager_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Tài khoản của nhân viên vẫn còn tồn tại");
                }
            }

        }

        public void LoadCbFill()
        {
            cbFillEmployee.SelectedIndex = 0;
            List<Position> positions = PositionBUS.Instance.GetListPosition();
            for (int i = 0; i < positions.Count; i++)
            {
                cbFillEmployee.Items.Add(positions[i].TenChucVu);
            }
        }
        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            int i = EmployeeMenuBUS.Instance.GetListEmployee().Count + 1;
            txtEmployeeID.Text = i.ToString();
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
            if (string.IsNullOrEmpty(txtEmployeeName.Text.Trim())||string.IsNullOrEmpty(txtNumberPhone.Text.Trim())||string.IsNullOrEmpty(richtxtAddress.Text.Trim()))
            {
                MessageBox.Show("Vui lòng nhập tên vị trí bàn muốn thêm vào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string gender = radMale.Checked == true ? radMale.Text : radFemale.Text;
            if (EmployeeBUS.Instance.CheckNumberPhoneCreate(txtNumberPhone.Text) && EmployeeBUS.Instance.CheckAge(dtpBirthday.Value))
            {
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
            else
            {
                MessageBox.Show("Số điện thoại của bạn tối đa 10 số và các số điện thoại không được trùng nhau hoặc bạn chưa đủ 18 tuổi");
            }
        }

        private void btnDeleteAllEmployee_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn chắc chắn muốn xóa toàn bộ nhân viên", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                if (EmployeeBUS.Instance.CheckAccountDeleteAll())
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
                else
                {
                    MessageBox.Show("Bạn không thể thực hiện chức năng khi chưa xóa tài khoản");
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
            if (cbSortEmployee.SelectedIndex == 0 && cbFillEmployee.SelectedIndex == 0)
            {
                dtgvListEmployee.DataSource = EmployeeMenuBUS.Instance.GetListEmployee();
            }

            else if (cbSortEmployee.SelectedIndex == 1)
                dtgvListEmployee.DataSource = EmployeeMenuBUS.Instance.SortListEmployeeByEmployeeName(cbFillEmployee.SelectedIndex);
            else if (cbSortEmployee.SelectedIndex == 2)
                dtgvListEmployee.DataSource = EmployeeMenuBUS.Instance.SortListEmployeeByEmployeeID(cbFillEmployee.SelectedIndex);

        }

        private void cbFillEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbFillEmployee.SelectedIndex == 0 && cbSortEmployee.SelectedIndex == 0)
            {
                dtgvListEmployee.DataSource = EmployeeMenuBUS.Instance.GetListEmployee();
            }

            else if (cbFillEmployee.SelectedIndex == 0 && cbSortEmployee.SelectedIndex == 1)
            {
                dtgvListEmployee.DataSource = EmployeeMenuBUS.Instance.SortListEmployeeByEmployeeName(0);

            }

            else if (cbFillEmployee.SelectedIndex == 0 && cbSortEmployee.SelectedIndex == 2)
                dtgvListEmployee.DataSource = EmployeeMenuBUS.Instance.SortListEmployeeByEmployeeID(0);

            else
            {
                for (int i = 1; i <= cbFillEmployee.Items.Count; i++)
                {
                    if (cbFillEmployee.SelectedIndex == i)
                    {
                        if (cbSortEmployee.SelectedIndex == 1)
                            dtgvListEmployee.DataSource = EmployeeMenuBUS.Instance.SortListEmployeeByEmployeeName(cbFillEmployee.SelectedIndex);
                        else if (cbSortEmployee.SelectedIndex == 2)
                            dtgvListEmployee.DataSource = EmployeeMenuBUS.Instance.SortListEmployeeByEmployeeID(cbFillEmployee.SelectedIndex);
                    }
                }
            }
        }

        private void txtNumberPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtEmployeeName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }


    }
}
