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
using Microsoft.ReportingServices.Interfaces;

namespace frmLogin
{
    public partial class frmAccountManagement : Form
    {
        private int Language = frmlogin.Language;
        HashCode info = new HashCode();
        public frmAccountManagement()
        {
            if (Language == info.valueDefault)
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("vi");
            else
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en");
            InitializeComponent();
            cbSortAccount.SelectedIndex = info.valueDefault;
            cbFillAccount.SelectedIndex = info.valueDefault;
        }

        private void frmAccountManagement_Load(object sender, EventArgs e)
        {
            LoadAccount();
            cbTypeAccount.DataSource = TypeAccountBUS.Instance.GetListTypeAccount();
            cbTypeAccount.DisplayMember = "TenLoai";
            cbTypeAccount.ValueMember = "MaLoai";
            cbEmloyee.DataSource = EmployeeMenuBUS.Instance.GetListEmployee();
            cbEmloyee.DisplayMember = "TenNV";
            cbEmloyee.ValueMember = "MaNV";
            btnSave.Enabled = false;
            btnSave.Enabled = false;
            btnDeleteAllAccount.Enabled = true;
            btnDeleteAccount.Enabled = true;
            btnEditAccount.Enabled = true;
        }
        public void LoadAccount()
        {
            dtgvListAccount.DataSource = AccountMenuBUS.Instance.GetListAccount();
        }
        private void btnAccountDeleted_Click(object sender, EventArgs e)
        {
            frmRecycleBin frm = new frmRecycleBin();
            frm.Show();

        }

        private void btnDeleteAllAccount_Click(object sender, EventArgs e)
        {
            if (Language == info.valueDefault)
            {
                if (DialogResult.Yes == MessageBox.Show(info.messageDeleteAllVi,info.titleMessageVi, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation))
                {
                    int count = AccountBUS.Instance.DeleteAllAccount(frmlogin.GetUsername());
                    if (count > 0)
                    {
                        MessageBox.Show(info.deleteAllVi,info.titleMessageVi, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(info.deleteAllFailedVi,info.titleMessageVi, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                frmAccountManagement_Load(sender, e);
            }
            else
            {
                if (DialogResult.Yes == MessageBox.Show(info.messageDeleteAllEn,info.titleMessageEn, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation))
                {
                    int count = AccountBUS.Instance.DeleteAllAccount(frmlogin.GetUsername());
                    if (count > 0)
                    {
                        MessageBox.Show(info.deleteAllEn,info.titleMessageEn, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(info.deleteAllFailedEn,info.titleMessageEn, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                frmAccountManagement_Load(sender, e);
            }
        }

        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
            cbEmloyee.SelectedIndex = info.valueDefault;
            cbTypeAccount.SelectedIndex = info.valueDefault;
            btnSave.Enabled = true;
            btnDeleteAllAccount.Enabled = false;
            btnDeleteAccount.Enabled = false;
            btnEditAccount.Enabled = false;
        }



        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            if (Language == info.valueDefault)
            {

                if (DialogResult.Yes == MessageBox.Show(info.messageDeleteVi,info.titleMessageVi, MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                {
                    if (txtUsername.Text != frmlogin.GetUsername())
                    {
                        int count = AccountBUS.Instance.DeleteAccountByUserName(txtUsername.Text);
                        if (count > 0)
                        {
                            MessageBox.Show(info.deleteVi,info.titleMessageVi, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show(info.deleteFailedVi, info.titleMessageVi, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show(info.checkDelVi,info.titleMessageVi, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                if (DialogResult.Yes == MessageBox.Show(info.messageDeleteEn,info.titleMessageEn, MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                {
                    if (txtUsername.Text != frmlogin.GetUsername())
                    {
                        int count = AccountBUS.Instance.DeleteAccountByUserName(txtUsername.Text);
                        if (count > 0)
                        {
                            MessageBox.Show(info.deleteEn,info.titleMessageEn, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show(info.deleteFailedEn,info.titleMessageEn, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show(info.checkDelEn,info.titleMessageEn, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            frmAccountManagement_Load(sender, e);
        }

        private void btnEditAccount_Click(object sender, EventArgs e)
        {
            if (Language == info.valueDefault)
            {
                if (MessageBox.Show(info.messageEditVi, info.titleMessageVi, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {   
                    if(string.IsNullOrEmpty(txtUsername.Text.Trim()) || string.IsNullOrEmpty(txtPassword.Text.Trim()))
                    {
                        MessageBox.Show(info.eventNullVi, info.titleMessageVi, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    int count = AccountBUS.Instance.EditAccount(txtUsername.Text, cbEmloyee.SelectedValue.ToString(), cbTypeAccount.SelectedValue.ToString(), txtPassword.Text);
                    if (count > 0)
                    {
                        MessageBox.Show(info.editVi,info.titleMessageVi, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(info.editFailedVi,info.titleMessageVi, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    frmAccountManagement_Load(sender, e);
                }
            }
            else
            {
                if (MessageBox.Show(info.messageEditEn, info.titleMessageEn, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (string.IsNullOrEmpty(txtUsername.Text.Trim()) || string.IsNullOrEmpty(txtPassword.Text.Trim()))
                    {
                        MessageBox.Show(info.eventNullEn, info.titleMessageEn, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    int count = AccountBUS.Instance.EditAccount(txtUsername.Text, cbEmloyee.SelectedValue.ToString(), cbTypeAccount.SelectedValue.ToString(), txtPassword.Text);
                    if (count > 0)
                    {
                        MessageBox.Show(info.editEn,info.titleMessageEn, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(info.editFailedEn,info.titleMessageEn, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    frmAccountManagement_Load(sender, e);
                }
            }
        }

        private void dtgvListAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            info.firstIndex = info.valueDefault;
            txtUsername.Text = dtgvListAccount.SelectedRows[info.valueDefault].Cells[info.firstIndex].Value.ToString();
            txtPassword.Text = dtgvListAccount.SelectedRows[info.valueDefault].Cells[info.firstIndex+=1].Value.ToString();
            cbEmloyee.SelectedValue = Convert.ToInt32(dtgvListAccount.SelectedRows[info.valueDefault].Cells[info.firstIndex+=1].Value.ToString());
            cbTypeAccount.SelectedValue = Convert.ToInt32(dtgvListAccount.SelectedRows[info.valueDefault].Cells[info.firstIndex+=1].Value.ToString());
            btnSave.Enabled = false;
            btnDeleteAllAccount.Enabled = true;
            btnDeleteAccount.Enabled = true;
            btnEditAccount.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Language == info.valueDefault)
            {
                if (string.IsNullOrEmpty(txtUsername.Text.Trim()) || string.IsNullOrEmpty(txtPassword.Text.Trim()))
                {
                    MessageBox.Show(info.eventNullVi,info.titleMessageVi, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (AccountBUS.Instance.CheckUsername(txtUsername.Text) && AccountBUS.Instance.CheckExistEmployee(Convert.ToInt32(cbEmloyee.SelectedValue.ToString())))
                {
                    int count = AccountBUS.Instance.AddAccount(txtUsername.Text, txtPassword.Text, cbEmloyee.SelectedValue.ToString(), cbTypeAccount.SelectedValue.ToString());
                    if (count > 0)
                    {
                        MessageBox.Show(info.addVi,info.titleMessageVi, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(info.addFailedVi,info.titleMessageVi, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    frmAccountManagement_Load(sender, e);
                }
                else
                {
                    MessageBox.Show(info.MessageCheckAccExistVi(txtUsername.Text,cbEmloyee.Text),info.titleMessageVi, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                if (string.IsNullOrEmpty(txtUsername.Text.Trim()) || string.IsNullOrEmpty(txtPassword.Text.Trim()))
                {
                    MessageBox.Show(info.eventNullEn,info.titleMessageEn, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (AccountBUS.Instance.CheckUsername(txtUsername.Text) && AccountBUS.Instance.CheckExistEmployee(Convert.ToInt32(cbEmloyee.SelectedValue.ToString())))
                {
                    int count = AccountBUS.Instance.AddAccount(txtUsername.Text, txtPassword.Text, cbEmloyee.SelectedValue.ToString(), cbTypeAccount.SelectedValue.ToString());
                    if (count > 0)
                    {
                        MessageBox.Show(info.addEn,info.addFailedEn, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(info.addFailedEn,info.titleMessageEn, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    frmAccountManagement_Load(sender, e);
                }
                else
                {
                    MessageBox.Show(info.MessageCheckAccExistEn(txtUsername.Text,cbEmloyee.Text),info.titleMessageEn, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void txtSearchAccount_TextChanged(object sender, EventArgs e)
        {
            dtgvListAccount.DataSource = AccountMenuBUS.Instance.SearchAccountByEmloyeeName(txtSearchAccount.Text);
        }

        private void btnSearchAccount_Click(object sender, EventArgs e)
        {
            dtgvListAccount.DataSource = AccountMenuBUS.Instance.SearchAccountByEmloyeeName(txtSearchAccount.Text);
        }

        private void cbSortAccount_SelectedIndexChanged(object sender, EventArgs e)
        {
            info.firstIndex = info.valueDefault;
            if (cbSortAccount.SelectedIndex == info.firstIndex && cbFillAccount.SelectedIndex == info.firstIndex)
            {
                dtgvListAccount.DataSource = AccountMenuBUS.Instance.GetListAccount();
            }

            else if (cbSortAccount.SelectedIndex == (info.firstIndex+=1))
                dtgvListAccount.DataSource = AccountMenuBUS.Instance.SortListAccountByUsername(cbFillAccount.SelectedIndex);
            else if (cbSortAccount.SelectedIndex == (info.firstIndex+=1))
                dtgvListAccount.DataSource = AccountMenuBUS.Instance.SortListAccountByEmployeeName(cbFillAccount.SelectedIndex);
        }

        private void cbFillAccount_SelectedIndexChanged(object sender, EventArgs e)
        {
            info.firstIndex = info.valueDefault;
            if (cbFillAccount.SelectedIndex == info.firstIndex && cbSortAccount.SelectedIndex == info.firstIndex)
            {
                dtgvListAccount.DataSource = AccountMenuBUS.Instance.GetListAccount();
            }

            else if (cbFillAccount.SelectedIndex == info.valueDefault && cbSortAccount.SelectedIndex == (info.firstIndex+=1))
            {
                dtgvListAccount.DataSource = AccountMenuBUS.Instance.SortListAccountByUsername(0);

            }

            else if (cbFillAccount.SelectedIndex == info.valueDefault && cbSortAccount.SelectedIndex == (info.firstIndex += 1))
                dtgvListAccount.DataSource = AccountMenuBUS.Instance.SortListAccountByEmployeeName(0);

            else
            {
                
                for (int i = 1; i <= cbFillAccount.Items.Count; i++)
                {
                    info.firstIndex = info.valueDefault;
                    if (cbFillAccount.SelectedIndex == i)
                    {
                        if (cbSortAccount.SelectedIndex == (info.firstIndex+=1))
                            dtgvListAccount.DataSource = AccountMenuBUS.Instance.SortListAccountByUsername(cbFillAccount.SelectedIndex);
                        else if (cbSortAccount.SelectedIndex == (info.firstIndex+=1))
                            dtgvListAccount.DataSource = AccountMenuBUS.Instance.SortListAccountByEmployeeName(cbFillAccount.SelectedIndex);
                    }
                }
            }
        }
    }
}
