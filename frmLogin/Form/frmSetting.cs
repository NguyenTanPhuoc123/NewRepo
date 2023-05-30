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
using System.Threading;
using System.Web.UI.Design.WebControls;

namespace frmLogin
{
    public partial class frmSetting : Form
    {
        Account account;
        HashCode info = new HashCode();
        private int Language = frmlogin.Language;
        frmSellManagement frm;
        public frmSetting(Account acc, frmSellManagement frmSell)
        {
            if (Language == info.valueDefault)
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("vi");
            else
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en");
            InitializeComponent();
            frm = frmSell;
            account = acc;
            grpChangePassword.Visible = false;
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
            if (Language == info.valueDefault)
            {
                if (MessageBox.Show(info.checkLogOutVi,info.titleMessageVi, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    frmSellManagement.ActiveForm.Disposed += new EventHandler(CloseForm);
                    this.Close();
                }
            }
            else
            {
                if (MessageBox.Show(info.checkLogOutEn,info.titleMessageEn, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    frmSellManagement.ActiveForm.Disposed += new EventHandler(CloseForm);
                    this.Close();
                }
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
            if (employee.GioiTinh == info.maleVi)
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
            if (Language == info.valueDefault)
            {
                if (string.IsNullOrEmpty(txtNumberPhone.Text.Trim()))
                {
                    MessageBox.Show(info.checkPhoneSettingVi,info.titleMessageVi, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string gioiTinh;
                if (radMale.Checked)
                    gioiTinh = info.maleVi;
                else
                    gioiTinh = info.femaleVi;
                if (EmployeeBUS.Instance.CheckNumberPhone(txtNumberPhone.Text,txtEmployeeID.Text))
                {
                    int row = EmployeeBUS.Instance.UpdateEmployeeInFo(Convert.ToInt32(txtEmployeeID.Text), txtNumberPhone.Text, dtpBirthday.Text, gioiTinh, txtAddress.Text);
                    if (row == 1)
                    {
                        MessageBox.Show(info.editVi,info.titleMessageVi, MessageBoxButtons.OK,MessageBoxIcon.Information);
                        LoadThongTin();
                    }
                    else
                        MessageBox.Show(info.editFailedVi,info.titleMessageVi, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                    MessageBox.Show(info.checkPhoneSettingVi+info.orVi+info.checkPhoneExistVi,info.titleMessageVi,MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                if (string.IsNullOrEmpty(txtNumberPhone.Text.Trim()))
                {
                    MessageBox.Show(info.checkPhoneSettingEn,info.titleMessageEn, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string gioiTinh;
                if (radMale.Checked)
                    gioiTinh = info.maleVi;
                else
                    gioiTinh = info.femaleVi;
                if (EmployeeBUS.Instance.CheckNumberPhone(txtNumberPhone.Text, txtEmployeeID.Text))
                {
                    int row = EmployeeBUS.Instance.UpdateEmployeeInFo(Convert.ToInt32(txtEmployeeID.Text), txtNumberPhone.Text, dtpBirthday.Text, gioiTinh, txtAddress.Text);
                    if (row == 1)
                    {
                        MessageBox.Show(info.editEn,info.titleMessageEn, MessageBoxButtons.OK);
                        LoadThongTin();
                    }
                    else
                        MessageBox.Show(info.editFailedEn,info.titleMessageEn, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                    MessageBox.Show(info.checkPhoneSettingEn + info.orEn + info.checkPhoneExistEn, info.titleMessageEn, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void txtAccept_Click(object sender, EventArgs e)
        {
            if (Language == 0)
            {
                string password = account.Password;
                if (AccountBUS.Instance.GetMD5(txtOldPassword.Text) == password)
                {
                    if (string.IsNullOrEmpty(txtNewPassword.Text.Trim()) || string.IsNullOrEmpty(txtRepeatPassword.Text.Trim()))
                    {
                        MessageBox.Show(info.eventNullVi,info.titleMessageVi, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else if (txtNewPassword.Text != txtRepeatPassword.Text)
                    {
                        MessageBox.Show(info.checkPasswordNewVi,info.titleMessageVi, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        int row = AccountBUS.Instance.UpdatePassword(txtNewPassword.Text, account.Username);
                        if (row == 1)
                        {
                            MessageBox.Show(info.messageChangePasswordVi,info.titleMessageVi, MessageBoxButtons.OK,MessageBoxIcon.Information);

                        }
                        else
                            MessageBox.Show(info.messageChangePasswordfailedVi,info.titleMessageVi, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show(info.checkPasswordOldVi,info.titleMessageVi, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else
            {
                string password = account.Password;
                if (AccountBUS.Instance.GetMD5(txtOldPassword.Text) == password)
                {
                    if (string.IsNullOrEmpty(txtNewPassword.Text.Trim()) || string.IsNullOrEmpty(txtRepeatPassword.Text.Trim()))
                    {
                        MessageBox.Show(info.eventNullEn,info.titleMessageEn, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else if (txtNewPassword.Text != txtRepeatPassword.Text)
                    {
                        MessageBox.Show(info.checkPasswordNewEn,info.titleMessageEn, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        int row = AccountBUS.Instance.UpdatePassword(txtNewPassword.Text, account.Username);
                        if (row == 1)
                        {
                            MessageBox.Show(info.messageChangePasswordEn,info.titleMessageEn, MessageBoxButtons.OK);

                        }
                        else
                            MessageBox.Show(info.messageChangePasswordfailedEn,info.titleMessageEn, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show(info.checkPasswordOldEn,info.titleMessageEn, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
        }
    }
}
