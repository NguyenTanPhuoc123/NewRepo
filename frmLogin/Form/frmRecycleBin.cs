using frmLogin.Data_Access_Layer;
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
    public partial class frmRecycleBin : Form
    {
        public frmRecycleBin()
        {
            InitializeComponent();
        }

        private void btnExitFomSelectDish_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void btnRestoreAccount_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn muốn phục hồi lại tài khoản này?","Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                int count = AccountDAF.Instance.RestoreAccountByUserName(txtUsername.Text);
                if (count > 0)
                    MessageBox.Show("Khôi phục thành công", "Khôi phục tài khoản", MessageBoxButtons.OK);
                else
                    MessageBox.Show("Khôi phục thất bại", "Khôi phục tài khoản", MessageBoxButtons.OK);
            }
        }

        private void btnRestoreAllAccount_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn phục hồi lại tất cả tài khoản này?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                int count = AccountDAF.Instance.RestoreAllAccount();
                if (count > 0)
                    MessageBox.Show("Khôi phục thành công", "Khôi phục tài khoản", MessageBoxButtons.OK);
                else
                    MessageBox.Show("Khôi phục thất bại", "Khôi phục tài khoản", MessageBoxButtons.OK);
            }
        }

        private void frmRecycleBin_Load(object sender, EventArgs e)
        {
            dtgvListAccountDeleted.DataSource = AccountDAF.Instance.GetListAccountDeleted();
        }
    }
        //Anhhghggh
        //Do An
}
