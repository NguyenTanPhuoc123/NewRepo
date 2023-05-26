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
using System.IO;
using System.Threading;
using Microsoft.ReportingServices.Interfaces;

namespace frmLogin
{
    public partial class frmRecycleBin : Form
    {
        private int Language = frmlogin.Language;
        HashCode info = new HashCode();
        public frmRecycleBin()
        {
            if (Language == info.valueDefault)
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("vi");
            else
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en");
            InitializeComponent();
            dtgvListAccountDeleted.AutoGenerateColumns = false;
            dtgvListEmployeeDeleted.AutoGenerateColumns = false;
            dtgvListProductDeleted.AutoGenerateColumns = false;
            dtgvListTableFoodDeleted.AutoGenerateColumns = false;
            dtgvListBillDetailDeleted.AutoGenerateColumns = false;
        }

        private void frmRecycleBin_Load(object sender, EventArgs e)
        {
            LoadAccountDeleted();
            LoadTableFoodDeleted();
            LoadProductDeleted();
            LoadEmployeeDeleted();
            LoadBillInfoDeleted();
        }

        private void btnExitFormSelectDish_Click(object sender, EventArgs e)
        {                                          
            this.Close();
        }

        public void CloseForm(object sender, EventArgs e)
        {
           
        }

        #region TableFood 
        void LoadTableFoodDeleted()
        {
            dtgvListTableFoodDeleted.DataSource = TableMenuBUS.Instance.GetListTableMenuDeleted();
            frmTableManagement.ActiveForm.Load += new EventHandler(CloseForm);
        }

        private void dtgvListTableFoodDeleted_SelectionChanged(object sender, EventArgs e)
        {
            info.firstIndex = info.valueDefault;
            if (dtgvListTableFoodDeleted.SelectedRows.Count > info.valueDefault)
            {
                txtTableID.Text = dtgvListTableFoodDeleted.SelectedRows[info.valueDefault].Cells[info.firstIndex].Value.ToString();
                txtTableName.Text = dtgvListTableFoodDeleted.SelectedRows[info.valueDefault].Cells[info.firstIndex+=1].Value.ToString();
                txtLocation.Text = dtgvListTableFoodDeleted.SelectedRows[info.valueDefault].Cells[info.firstIndex+=1].Value.ToString();

            }
        }

        private void btnRestoreTable_Click(object sender, EventArgs e)
        {
            if (Language == info.valueDefault)
            {
                if (MessageBox.Show(info.messageRestoreVi,info.titleMessageVi, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {                  
                    int count = TableBUS.Instance.RestoreTable(int.Parse(txtTableID.Text));
                    if (count > 0)
                    {
                        MessageBox.Show(info.restoreVi,info.titleMessageVi, MessageBoxButtons.OK,MessageBoxIcon.Information);
                        LoadTableFoodDeleted();
                    }
                    else
                        MessageBox.Show(info.restoreFailedVi, info.titleMessageVi, MessageBoxButtons.OK,MessageBoxIcon.Information);
                }                
            }
            else
            {
                if (MessageBox.Show(info.messageRestoreEn,info.titleMessageEn, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {                   
                        int count = TableBUS.Instance.RestoreTable(int.Parse(txtTableID.Text));
                    if (count > info.valueDefault)
                    {
                        MessageBox.Show(info.restoreEn,info.titleMessageEn, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadTableFoodDeleted();
                    }
                    else
                        MessageBox.Show(info.restoreFailedEn,info.titleMessageEn, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }    
            }
        }

        private void btnRestoreAllTable_Click(object sender, EventArgs e)
        {
            if (Language == info.valueDefault)
            {
                if (MessageBox.Show(info.messageRestoreAllVi,info.titleMessageVi, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {                   
                        int count = TableBUS.Instance.RestoreAllTable();
                    if (count > info.valueDefault)
                    {
                        MessageBox.Show(info.restoreAllVi, info.titleMessageVi, MessageBoxButtons.OK);
                        LoadTableFoodDeleted();
                    }
                    else
                        MessageBox.Show(info.restoreAllFailedVi, info.titleMessageVi, MessageBoxButtons.OK);     
                }
            }
            else
            {
                if (MessageBox.Show(info.messageRestoreAllEn,info.titleMessageEn, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {                 
                        int count = TableBUS.Instance.RestoreAllTable();
                    if (count > info.valueDefault)
                    {
                        MessageBox.Show(info.restoreAllEn, info.titleMessageEn, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadTableFoodDeleted();
                    }
                    else
                        MessageBox.Show(info.restoreAllFailedEn, info.titleMessageEn, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }                   
                    
            }           
        }
        #endregion
       

        #region Account
        private void btnRestoreAccount_Click(object sender, EventArgs e)
        {
            if (Language == 0)
            {
                if (MessageBox.Show("Bạn muốn phục hồi lại tài khoản này?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    int count = AccountBUS.Instance.RestoreAccountByUserName(txtUsername.Text);
                    if (count > 0)
                        MessageBox.Show("Khôi phục thành công", "Khôi phục tài khoản", MessageBoxButtons.OK);
                    else
                        MessageBox.Show("Khôi phục thất bại", "Khôi phục tài khoản", MessageBoxButtons.OK);
                }
                frmRecycleBin_Load(sender, e);
            }
            else
            {
                if (MessageBox.Show("Want to recover this account?", "Notification", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    int count = AccountBUS.Instance.RestoreAccountByUserName(txtUsername.Text);
                    if (count > 0)
                        MessageBox.Show("Successful recovery", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Recovery failed", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                frmRecycleBin_Load(sender, e);
            }
        }

        private void btnRestoreAllAccount_Click(object sender, EventArgs e)
        {
            if (Language == 0)
            {
                if (MessageBox.Show("Bạn muốn phục hồi lại tất cả tài khoản này?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    int count = AccountBUS.Instance.RestoreAllAccount();
                    if (count > 0)
                        MessageBox.Show("Khôi phục thành công", "Khôi phục tài khoản", MessageBoxButtons.OK);
                    else
                        MessageBox.Show("Khôi phục thất bại", "Khôi phục tài khoản", MessageBoxButtons.OK);
                }
            }
            else
            {
                if (MessageBox.Show("Want to recover all these accounts?", "Notification", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    int count = AccountBUS.Instance.RestoreAllAccount();
                    if (count > 0)
                        MessageBox.Show("Successful recovery", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Recovery failed", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            frmRecycleBin_Load(sender, e);
        }

        public void LoadAccountDeleted()
        {
            dtgvListAccountDeleted.DataSource = AccountBUS.Instance.GetListAccountDeleted();
            frmAccountManagement.ActiveForm.Load += new EventHandler(CloseForm);

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
        #endregion

        #region Product
        private void LoadProductDeleted()
        {
            dtgvListProductDeleted.DataSource = ProductBUS.Instance.GetProductDeleted();
            frmProductManagement.ActiveForm.Load += new EventHandler(CloseForm);
        }
        private void dtgvListProductDeleted_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (i == -1) return;
            MemoryStream memoryStream = new MemoryStream((byte[])dtgvListProductDeleted.Rows[i].Cells[0].Value);
            pbProduct.Image = Image.FromStream(memoryStream);
            txtProductID.Text = dtgvListProductDeleted.Rows[i].Cells[1].Value.ToString();
            txtProductName.Text = dtgvListProductDeleted.Rows[i].Cells[2].Value.ToString();
            cbCategory.SelectedValue = dtgvListProductDeleted.Rows[i].Cells[4].Value;
            numQuantity.Value = Convert.ToInt32(dtgvListProductDeleted.Rows[i].Cells[5].Value);
            txtPrice.Text = dtgvListProductDeleted.Rows[i].Cells[6].Value.ToString();
            richtxtDescribe.Text = dtgvListProductDeleted.Rows[i].Cells[7].Value.ToString();
        }
        private void btnRestoreProduct_Click(object sender, EventArgs e)
        {
            if (Language == 0)
            {
                if (DialogResult.Yes == MessageBox.Show("Bạn có muốn khôi phục sản phẩm", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    int cout = ProductBUS.Instance.RestoreProduct(txtProductID.Text);
                    if (cout > 0)
                    {
                        MessageBox.Show("Khôi phục thành công", "Thông Báo", MessageBoxButtons.OK);
                        LoadProductDeleted();

                    }
                    else
                        MessageBox.Show("Khôi phục thất bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                if (DialogResult.Yes == MessageBox.Show("Do you want to restore the product", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    int cout = ProductBUS.Instance.RestoreProduct(txtProductID.Text);
                    if (cout > 0)
                        MessageBox.Show("Successful recovery", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Recovery failed", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    LoadProductDeleted();
                }
            }
        }
        private void btnRestoreAllProduct_Click(object sender, EventArgs e)
        {
            if (Language == 0)
            {
                if (DialogResult.Yes == MessageBox.Show("Bạn có muốn khôi phục tất cả sản phẩm", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    int cout = ProductBUS.Instance.RestoreProductAll();
                    if (cout > 0)
                    {
                        MessageBox.Show("Khôi phục thành công", "Thông Báo", MessageBoxButtons.OK);
                        LoadProductDeleted();

                    }
                    else
                        MessageBox.Show("Khôi phục thất bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {

                if (DialogResult.Yes == MessageBox.Show("Do you want to restore all products", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    int cout = ProductBUS.Instance.RestoreProductAll();
                    if (cout > 0)
                        MessageBox.Show("Successful recovery", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Recovery failed", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    LoadProductDeleted();
                }
            }
        }
        #endregion
      
        #region Employee
        public void LoadEmployeeDeleted()
        {
            frmEmployeeManager.ActiveForm.Load += new EventHandler(CloseForm);
            dtgvListEmployeeDeleted.DataSource = EmployeeMenuBUS.Instance.GetListEmployeeDeleted();
            cbPosition.DataSource = PositionBUS.Instance.GetListPosition();
            cbPosition.DisplayMember = "TENCHUCVU";
            cbPosition.ValueMember = "MACHUCVU";
        }

        private void btnRestoreEmployee_Click(object sender, EventArgs e)
        {
            if (Language == 0)
            {
                if (MessageBox.Show("Bạn muốn phục hồi lại nhân viên này?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    int count = EmployeeBUS.Instance.RestoreEmployeeInfo(Convert.ToInt32(txtEmployeeID.Text));
                    if (count > 0)
                        MessageBox.Show("Khôi phục thành công", "Khôi phục nhân viên", MessageBoxButtons.OK);
                    else
                        MessageBox.Show("Khôi phục thất bại", "Khôi phục nhân viên", MessageBoxButtons.OK);
                }
            }
            else
            {
                if (MessageBox.Show("Want to reinstate this employee?", "Notification", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    int count = EmployeeBUS.Instance.RestoreEmployeeInfo(Convert.ToInt32(txtEmployeeID.Text));
                    if (count > 0)
                        MessageBox.Show("Successful recovery", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Recovery failed", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            frmRecycleBin_Load(sender, e);
    
        }

        private void btnRestoreAllEmployee_Click(object sender, EventArgs e)
        {
            if (Language == 0)
            {
                if (MessageBox.Show("Bạn muốn phục hồi lại tất cả nhân viên này?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    int count = EmployeeBUS.Instance.RestoreAllEmployee();
                    if (count > 0)
                        MessageBox.Show("Khôi phục thành công", "Khôi phục nhân viên", MessageBoxButtons.OK);
                    else
                        MessageBox.Show("Khôi phục thất bại", "Khôi phục nhân viên", MessageBoxButtons.OK);
                }
            }
            else
            {
                if (MessageBox.Show("You want to reinstate all these employees?", "Notification", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    int count = EmployeeBUS.Instance.RestoreAllEmployee();
                    if (count > 0)
                        MessageBox.Show("Successful recovery", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Recovery failed", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            frmRecycleBin_Load(sender, e);
 
        }

        private void dtgvListEmployeeDeleted_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgvListEmployeeDeleted.SelectedRows.Count > 0)
            {
                txtEmployeeID.Text = dtgvListEmployeeDeleted.SelectedRows[0].Cells[0].Value.ToString();
                txtEmployeeName.Text = dtgvListEmployeeDeleted.SelectedRows[0].Cells[1].Value.ToString();
                dtpBirthday.Text = dtgvListEmployeeDeleted.SelectedRows[0].Cells[2].Value.ToString();
                txtNumberPhone.Text = dtgvListEmployeeDeleted.SelectedRows[0].Cells[4].Value.ToString();
                richtxtAddress.Text = dtgvListEmployeeDeleted.SelectedRows[0].Cells[5].Value.ToString();
                dtpWorkingDay.Text = dtgvListEmployeeDeleted.SelectedRows[0].Cells[6].Value.ToString();
                string gender = dtgvListEmployeeDeleted.SelectedRows[0].Cells[3].Value.ToString();
                if (gender == radMale.Text)
                    radMale.Checked = true;
                else
                    radFemale.Checked = true;
                cbPosition.SelectedValue = Convert.ToInt32(dtgvListEmployeeDeleted.SelectedRows[0].Cells[8].Value.ToString());
            }
        }
        #endregion

        #region Bill Info
        public void LoadBillInfoDeleted()
        {
            dtgvListBillDetailDeleted.DataSource = BillInfoMenuBUS.Instance.GetListBillInfoMenuDeleted();
            frmBillDetail.ActiveForm.Load += new EventHandler(CloseForm);
            ResetBillInfo();
        }

        public void ResetBillInfo()
        {
            txtBillID.Clear();
            txtProductNameBill.Clear();
            numCountBillInfo.Value = 1;
            txtPriceBillInfo.Clear();
            txtTotalBillInfo.Clear();
        }

        private void dtgvListBillDetailDeleted_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgvListBillDetailDeleted.SelectedRows.Count > 0)
            {
                txtBillID.Text = dtgvListBillDetailDeleted.SelectedRows[0].Cells[0].Value.ToString();
                txtProductNameBill.Text = dtgvListBillDetailDeleted.SelectedRows[0].Cells[1].Value.ToString();
                numCountBillInfo.Value = int.Parse(dtgvListBillDetailDeleted.SelectedRows[0].Cells[2].Value.ToString());
                txtPriceBillInfo.Text = dtgvListBillDetailDeleted.SelectedRows[0].Cells[3].Value.ToString();
                txtTotalBillInfo.Text = dtgvListBillDetailDeleted.SelectedRows[0].Cells[4].Value.ToString();
            }
        }

        private void btnRestoreBillDetail_Click(object sender, EventArgs e)
        {
            if (Language == 0)
            {
                if (MessageBox.Show("Bạn muốn khôi phục chi tiết hóa đơn này ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    string productID = "";
                    if (dtgvListBillDetailDeleted.SelectedRows.Count > 0)
                        productID = dtgvListBillDetailDeleted.SelectedRows[0].Cells[5].Value.ToString();
                    int count = BillInfoBUS.Instance.RestoreBillInfo(txtBillID.Text, productID);

                    if (count > 0)
                    {
                        MessageBox.Show("Khôi phục chi tiết hóa đơn thành công", "Khôi phục chi tiết hóa đơn", MessageBoxButtons.OK);
                        LoadBillInfoDeleted();

                    }
                    else
                        MessageBox.Show("Khôi phục chi tiết hóa đơn thất bại", "Khôi phục chi tiết hóa đơn", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                if (MessageBox.Show("You want to recover this invoice details?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    string productID = "";
                    if (dtgvListBillDetailDeleted.SelectedRows.Count > 0)
                        productID = dtgvListBillDetailDeleted.SelectedRows[0].Cells[5].Value.ToString();
                    int count = BillInfoBUS.Instance.RestoreBillInfo(txtBillID.Text, productID);

                    if (count > 0)
                        MessageBox.Show("Successful recovery", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Recovery failed", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                LoadBillInfoDeleted();
            }
        }

        private void btnRestoreAllBillDetail_Click(object sender, EventArgs e)
        {
            if (Language == 0)
            {
                if (MessageBox.Show("Bạn muốn khôi phục tất cả chi tiết hóa đơn này ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    string productID = "";
                    if (dtgvListBillDetailDeleted.SelectedRows.Count > 0)
                        productID = dtgvListBillDetailDeleted.SelectedRows[0].Cells[5].Value.ToString();
                    int count = BillInfoBUS.Instance.RestoreAllBillInfo();

                    if (count > 0)
                    {
                        MessageBox.Show("Khôi phục tất cả chi tiết hóa đơn thành công", "Khôi phục chi tiết hóa đơn", MessageBoxButtons.OK);
                        LoadBillInfoDeleted();

                    }
                    else
                        MessageBox.Show("Khôi phục tất cả chi tiết hóa đơn thất bại", "Khôi phục chi tiết hóa đơn", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                if (MessageBox.Show("You want to recover all these invoice details ?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    string productID = "";
                    if (dtgvListBillDetailDeleted.SelectedRows.Count > 0)
                        productID = dtgvListBillDetailDeleted.SelectedRows[0].Cells[5].Value.ToString();
                    int count = BillInfoBUS.Instance.RestoreAllBillInfo();

                    if (count > 0)
                        MessageBox.Show("Successful recovery", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Recovery failed", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                LoadBillInfoDeleted();
            }
        }



        #endregion
       
    }
}
