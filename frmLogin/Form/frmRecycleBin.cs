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
            frmRecycleBin_Load(sender, e);
            
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
           
            LoadTableFoodDeleted();
        }

        void LoadTableFoodDeleted()
        {
            dtgvListTableFoodDeleted.DataSource = TableMenuDAF.Instance.GetListTableMenuDeleted();
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
            if(MessageBox.Show("Bạn muốn khôi phục lại bàn ăn này chứ?","Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    int count = TableDAF.Instance.RestoreTable(int.Parse(txtTableID.Text));
                    if (count > 0)
                        MessageBox.Show("Khôi phục thành công ", "Khôi phục bàn ăn", MessageBoxButtons.OK);
                    else
                        MessageBox.Show("Khôi phục thất bại ", "Khôi phục bàn ăn", MessageBoxButtons.OK);
                }
                catch(Exception ex)
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
                    int count = TableDAF.Instance.RestoreAllTable();
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

        private void btnExitFormSelectDish_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
 
}
