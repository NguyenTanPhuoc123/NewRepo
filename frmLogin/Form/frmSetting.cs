
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
    public partial class frmSetting : Form
    {
        Account account;
        public frmSetting(Account acc)
        {
            InitializeComponent();
            account = acc;

            grpChangePassword.Visible = false;
            cbLanguage.SelectedIndex = 0;
            cbSizeDisplay.SelectedIndex = 1;
        }

    

        private void btnExitFormSetting_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            grpAccountDetail.Visible = false;
            grpChangePassword.Visible = true;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            grpAccountDetail.Visible = true;
            grpChangePassword.Visible = false;
        }

        private void btnLogOff_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn đăng xuất khỏi tài khoản này?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                frmSellManagement.ActiveForm.Disposed += new EventHandler(CloseForm);
                this.Close();
            }
        }

        public void CloseForm(object sender, EventArgs e)
        {
            frmSellManagement.ActiveForm.Dispose();
        }

        private void LoadThongTin()
        {
            Employee employee = EmployeeBUS.Instance.GetEmployeeByEmployeeID(account.EmployeeID);
            Position position = PositionBUS.Instance.GetPositionName(employee.MaChucVu);
            txtDisplayName.Text = employee.TenNV;
            txtUserName.Text = account.Username;
            txtEmployeeID.Text = employee.MaNV.ToString();
            txtEmployeeFullName.Text = employee.TenNV;
            txtNumberPhone.Text = employee.SoDienThoai;
            txtPosition.Text = position.TenChucVu;
            dtpBirthday.Text = employee.NgaySinh;
           dtpWorkingDay.Text = employee.NgayVaoLam;
            txtAddress.Text = employee.DiaChi;
            if (employee.GioiTinh == "Nam")
                radMale.Checked = true;
            else
                radFemale.Checked = true;
        }
        private void frmSetting_Load(object sender, EventArgs e)
        {
            LoadThongTin();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string gioiTinh;
            if (radMale.Checked)
                gioiTinh = "Nam";
            else
                gioiTinh = "Nữ";
            int row= EmployeeBUS.Instance.UpdateEmployeeInFo(Convert.ToInt32(txtEmployeeID.Text),txtNumberPhone.Text,dtpBirthday.Text,gioiTinh,txtAddress.Text);
            if (row == 1)
            {
                MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK);
                LoadThongTin();
            }
            else
                MessageBox.Show("Sửa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
        }

        private void txtAccept_Click(object sender, EventArgs e)
        {
            string password = account.Password;
            if (AccountBUS.Instance.GetMD5(txtOldPassword.Text) == password)
            {
                if (string.IsNullOrEmpty(txtNewPassword.Text) || string.IsNullOrEmpty(txtRepeatPassword.Text))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (txtNewPassword.Text != txtRepeatPassword.Text)
                {
                    MessageBox.Show("Mật khẩu mới không trùng khớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    int row = AccountBUS.Instance.UpdatePassword(txtNewPassword.Text, account.Username);
                    if (row == 1)
                    {
                        MessageBox.Show("Đổi mật khẩu thành công", "Thông báo", MessageBoxButtons.OK);

                    }
                    else
                        MessageBox.Show("Đổi mật khẩu thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Mật khẩu củ không chính xác","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
        }
    }
}
