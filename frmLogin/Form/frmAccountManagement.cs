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
    public partial class frmAccountManagement : Form
    {
        public frmAccountManagement()
        {
            InitializeComponent();
        }

        private void frmAccountManagement_Load(object sender, EventArgs e)
        {
            
            dtgvListAccount.DataSource= AccountDAF.Instance.GetListAccount();
            cbTypeAccount.DataSource = TypeAccountDAF.Instance.GetListTypeAccount();
            cbTypeAccount.DisplayMember = "TenLoai";
            cbTypeAccount.ValueMember = "MaLoai";
        }

        private void btnAccountDeleted_Click(object sender, EventArgs e)
        {
            frmRecycleBin frm = new frmRecycleBin();
            frm.Show();
        }

        private void btnDeleteAllAccount_Click(object sender, EventArgs e)
        {
            if(DialogResult.Yes == MessageBox.Show("Ban co muon xoa tat ca", "Thong bao", MessageBoxButtons.YesNo))
            {
                int count = AccountDAF.Instance.DeleteAllAccount();
                if (count > 0)
                {
                    MessageBox.Show("Xoa tat ca thanh cong");
                }
                else
                {
                    MessageBox.Show("Xoa tat ca that bai");
                }
            }
            frmAccountManagement_Load(sender, e);
        }

        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            
        }

        private void dtgvListAccount_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtUsername.Text = dtgvListAccount.SelectedRows[0].Cells[0].Value.ToString();
            txtPassword.Text = dtgvListAccount.SelectedRows[0].Cells[1].Value.ToString();
            txtEmployee.Text = dtgvListAccount.SelectedRows[0].Cells[2].Value.ToString();
            int type = int.Parse(dtgvListAccount.SelectedRows[0].Cells[3].Value.ToString());
            if (type == 1)
            {
                cbTypeAccount.SelectedIndex = 0;
            }
            else
            {
                cbTypeAccount.SelectedIndex = 1;
            }
        }

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Ban co muon xoa tai khoan", "Thong bao", MessageBoxButtons.YesNo))
            {
                int count = AccountDAF.Instance.DeleteAccountByUserName(txtUsername.Text);
                if (count > 0)
                {
                    MessageBox.Show("Xoa tai khoan thanh cong");
                }
                else
                {
                    MessageBox.Show("Xoa tai khoan that bai");
                }
            }
            frmAccountManagement_Load(sender, e);
        }
    }
}
