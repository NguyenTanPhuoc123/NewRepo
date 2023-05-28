
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
        HashCode info = new HashCode();
        private int Language = frmlogin.Language;
        public frmEmployeeManager()
        {
            if (Language == info.valueDefault)
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("vi");
            else
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en");
            InitializeComponent();
            dtgvListEmployee.AutoGenerateColumns = false;
            cbSortEmployee.SelectedIndex = info.valueDefault;
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
            info.firstIndex = info.valueDefault;
            if (dtgvListEmployee.SelectedRows.Count > 0)
            {
                txtEmployeeID.Text = dtgvListEmployee.SelectedRows[info.valueDefault].Cells[info.firstIndex].Value.ToString();
                txtEmployeeName.Text = dtgvListEmployee.SelectedRows[info.valueDefault].Cells[info.firstIndex += 1].Value.ToString();
                dtpBirthday.Text = dtgvListEmployee.SelectedRows[info.valueDefault].Cells[info.firstIndex += 1].Value.ToString();
                string gender = dtgvListEmployee.SelectedRows[info.valueDefault].Cells[info.firstIndex += 1].Value.ToString();
                if (gender == radMale.Text)
                    radMale.Checked = true;
                else
                    radFemale.Checked = true;
                txtNumberPhone.Text = dtgvListEmployee.SelectedRows[info.valueDefault].Cells[info.firstIndex += 1].Value.ToString();
                richtxtAddress.Text = dtgvListEmployee.SelectedRows[info.valueDefault].Cells[info.firstIndex += 1].Value.ToString();
                dtpWorkingDay.Text = dtgvListEmployee.SelectedRows[info.valueDefault].Cells[info.firstIndex += 1].Value.ToString();
                
                cbPosition.SelectedValue = Convert.ToInt32(dtgvListEmployee.SelectedRows[0].Cells[info.firstIndex += 2].Value.ToString());
            }
        }

        private void btnEditEmployee_Click(object sender, EventArgs e)
        {
            if (Language == info.valueDefault)
            {
                string gender = radMale.Checked == true ? radMale.Text : radFemale.Text;
                if (EmployeeBUS.Instance.CheckNumberPhone(txtNumberPhone.Text, txtEmployeeID.Text) && EmployeeBUS.Instance.CheckAge(dtpBirthday.Value))
                {
                    int count = EmployeeBUS.Instance.UpdateEmployee(int.Parse(txtEmployeeID.Text), txtEmployeeName.Text, dtpBirthday.Value.ToString("yyyy/MM/dd"), gender, txtNumberPhone.Text, richtxtAddress.Text);
                    if (count > 0)
                    {
                        MessageBox.Show(info.editVi,info.titleMessageVi,MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(info.editFailedVi,info.titleMessageVi, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    frmEmployeeManager_Load(sender, e);
                }
                else
                {
                    MessageBox.Show(info.checkPhoneSettingVi+info.orVi+info.checkPhoneExistVi+info.orVi+info.checkAgeVi,info.titleMessageVi, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                string gender = radMale.Checked == true ? radMale.Text : radFemale.Text;
                if (EmployeeBUS.Instance.CheckNumberPhone(txtNumberPhone.Text, txtEmployeeID.Text) && EmployeeBUS.Instance.CheckAge(dtpBirthday.Value))
                {
                    int count = EmployeeBUS.Instance.UpdateEmployee(int.Parse(txtEmployeeID.Text), txtEmployeeName.Text, dtpBirthday.Value.ToString("yyyy/MM/dd"), gender, txtNumberPhone.Text, richtxtAddress.Text);
                    if (count > 0)
                    {
                        MessageBox.Show(info.editEn,info.titleMessageEn, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(info.editFailedEn,info.titleMessageEn, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    frmEmployeeManager_Load(sender, e);
                }
                else
                {
                    MessageBox.Show(info.checkPhoneSettingEn + info.orEn + info.checkPhoneExistEn + info.orEn + info.checkAgeEn, info.titleMessageEn, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }

        private void btnDeleteEmployee_Click(object sender, EventArgs e)
        {
            if (Language == info.valueDefault)
            {
                if (DialogResult.Yes == MessageBox.Show(info.messageDeleteVi,info.titleMessageVi, MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                {
                    if (EmployeeBUS.Instance.CheckAccountDelete(Convert.ToInt32(txtEmployeeID.Text)))
                    {
                        int count = EmployeeBUS.Instance.DeleteEmployeeInfo(int.Parse(txtEmployeeID.Text));
                        if (count > 0)
                        {
                            MessageBox.Show(info.deleteVi,info.titleMessageVi, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show(info.deleteFailedVi,info.titleMessageVi,MessageBoxButtons.OK,MessageBoxIcon.Warning);
                        }
                        frmEmployeeManager_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show(info.checkDelVi,info.titleMessageVi,MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                if (DialogResult.Yes == MessageBox.Show(info.messageDeleteEn,info.titleMessageEn, MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                {
                    if (EmployeeBUS.Instance.CheckAccountDelete(int.Parse(txtEmployeeID.Text)))
                    {
                        int count = EmployeeBUS.Instance.DeleteEmployeeInfo(int.Parse(txtEmployeeID.Text));
                        if (count > 0)
                        {
                            MessageBox.Show(info.deleteEn,info.titleMessageEn, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show(info.deleteFailedEn,info.titleMessageEn, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        frmEmployeeManager_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show(info.checkDelEn,info.titleMessageEn, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        public void LoadCbFill()
        {
            cbFillEmployee.SelectedIndex = info.valueDefault;
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
            txtEmployeeID.Enabled = false;
            txtEmployeeName.Clear();
            cbPosition.SelectedIndex = info.valueDefault;
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
            if (Language == info.valueDefault)
            {
                if (string.IsNullOrEmpty(txtEmployeeName.Text.Trim()) || string.IsNullOrEmpty(txtNumberPhone.Text.Trim()) || string.IsNullOrEmpty(richtxtAddress.Text.Trim()))
                {
                    MessageBox.Show(info.eventNullVi,info.titleMessageVi, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string gender = radMale.Checked == true ? radMale.Text : radFemale.Text;
                if (EmployeeBUS.Instance.CheckNumberPhoneCreate(txtNumberPhone.Text) && EmployeeBUS.Instance.CheckAge(dtpBirthday.Value))
                {
                    int count = EmployeeBUS.Instance.AddEmployee(txtEmployeeName.Text, dtpBirthday.Value.ToString("yyyy/MM/dd"), gender, dtpWorkingDay.Value.ToString("yyyy/MM/dd"), (int)cbPosition.SelectedValue, txtNumberPhone.Text, richtxtAddress.Text);
                    if (count > 0)
                    {
                        MessageBox.Show(info.addVi,info.titleMessageVi,MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(info.addFailedVi,info.titleMessageVi, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    frmEmployeeManager_Load(sender, e);
                }
                else
                {
                    MessageBox.Show(info.checkPhoneSettingVi + info.orVi + info.checkPhoneExistVi + info.orVi + info.checkAgeVi, info.titleMessageVi, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                if (string.IsNullOrEmpty(txtEmployeeName.Text.Trim()) || string.IsNullOrEmpty(txtNumberPhone.Text.Trim()) || string.IsNullOrEmpty(richtxtAddress.Text.Trim()))
                {
                    MessageBox.Show(info.eventNullEn,info.titleMessageEn, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string gender = radMale.Checked == true ? radMale.Text : radFemale.Text;
                if (EmployeeBUS.Instance.CheckNumberPhoneCreate(txtNumberPhone.Text) && EmployeeBUS.Instance.CheckAge(dtpBirthday.Value))
                {
                    int count = EmployeeBUS.Instance.AddEmployee(txtEmployeeName.Text, dtpBirthday.Value.ToString("yyyy/MM/dd"), gender, dtpWorkingDay.Value.ToString("yyyy/MM/dd"), (int)cbPosition.SelectedValue, txtNumberPhone.Text, richtxtAddress.Text);
                    if (count > 0)
                    {
                        MessageBox.Show(info.addEn,info.titleMessageEn, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(info.addFailedEn,info.titleMessageEn, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    frmEmployeeManager_Load(sender, e);
                }
                else
                {
                    MessageBox.Show(info.checkPhoneSettingEn + info.orEn + info.checkPhoneExistEn + info.orEn + info.checkAgeEn, info.titleMessageEn, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnDeleteAllEmployee_Click(object sender, EventArgs e)
        {
            if (Language == info.valueDefault)
            {
                if (DialogResult.Yes == MessageBox.Show(info.messageDeleteAllVi,info.titleMessageVi, MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                {
                    if (EmployeeBUS.Instance.CheckAccountDeleteAll())
                    {
                        int count = EmployeeBUS.Instance.DeleteAllEmployee();
                        if (count > 0)
                        {
                            MessageBox.Show(info.deleteAllVi,info.titleMessageVi, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show(info.deleteAllFailedVi,info.titleMessageVi, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show(info.messCheckDelAllVi,info.titleMessageVi, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
                frmEmployeeManager_Load(sender, e);
            }
            else
            {
                if (DialogResult.Yes == MessageBox.Show(info.messageDeleteAllVi,info.titleMessageVi, MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                {
                    if (EmployeeBUS.Instance.CheckAccountDeleteAll())
                    {
                        int count = EmployeeBUS.Instance.DeleteAllEmployee();
                        if (count > 0)
                        {
                            MessageBox.Show(info.deleteAllEn,info.titleMessageEn, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show(info.deleteAllFailedEn,info.titleMessageEn, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show(info.messCheckDelAllEn,info.titleMessageEn, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
                frmEmployeeManager_Load(sender, e);
            }
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
            info.firstIndex = info.valueDefault;
            if (cbSortEmployee.SelectedIndex == info.firstIndex && cbFillEmployee.SelectedIndex == info.firstIndex)
            {
                dtgvListEmployee.DataSource = EmployeeMenuBUS.Instance.GetListEmployee();
            }

            else if (cbSortEmployee.SelectedIndex == (info.firstIndex+=1))
                dtgvListEmployee.DataSource = EmployeeMenuBUS.Instance.SortListEmployeeByEmployeeName(cbFillEmployee.SelectedIndex);
            else if (cbSortEmployee.SelectedIndex == (info.firstIndex+=1))
                dtgvListEmployee.DataSource = EmployeeMenuBUS.Instance.SortListEmployeeByEmployeeID(cbFillEmployee.SelectedIndex);

        }

        private void cbFillEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            info.firstIndex = info.valueDefault;
            if (cbFillEmployee.SelectedIndex == info.valueDefault && cbSortEmployee.SelectedIndex == info.valueDefault)
            {
                dtgvListEmployee.DataSource = EmployeeMenuBUS.Instance.GetListEmployee();
            }

            else if (cbFillEmployee.SelectedIndex == info.valueDefault && cbSortEmployee.SelectedIndex == (info.firstIndex += 1))
            {
                dtgvListEmployee.DataSource = EmployeeMenuBUS.Instance.SortListEmployeeByEmployeeName(info.valueDefault);

            }

            else if (cbFillEmployee.SelectedIndex == info.valueDefault && cbSortEmployee.SelectedIndex == (info.firstIndex += 1))
                dtgvListEmployee.DataSource = EmployeeMenuBUS.Instance.SortListEmployeeByEmployeeID(info.valueDefault);

            else
            {
                for (int i = 1; i <= cbFillEmployee.Items.Count; i++)
                {
                    if (cbFillEmployee.SelectedIndex == i)
                    {
                        info.firstIndex = info.valueDefault;
                        if (cbSortEmployee.SelectedIndex == (info.firstIndex += 1))
                            dtgvListEmployee.DataSource = EmployeeMenuBUS.Instance.SortListEmployeeByEmployeeName(cbFillEmployee.SelectedIndex);
                        else if (cbSortEmployee.SelectedIndex == (info.firstIndex+=1))
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
