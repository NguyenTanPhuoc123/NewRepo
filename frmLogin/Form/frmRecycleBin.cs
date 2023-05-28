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

        public void LoadForm(object sender, EventArgs e)
        {
           
        }

        #region TableFood 
        void LoadTableFoodDeleted()
        {
            dtgvListTableFoodDeleted.DataSource = TableMenuBUS.Instance.GetListTableMenuDeleted();
            frmQuanLyAdmin.ActiveForm.Load += new EventHandler(LoadForm);
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
            if (Language == info.valueDefault)
            {
                if (MessageBox.Show(info.messageRestoreVi, info.titleMessageVi, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    int count = AccountBUS.Instance.RestoreAccountByUserName(txtUsername.Text);
                    if (count > info.valueDefault)
                    {
                        MessageBox.Show(info.restoreVi, info.titleMessageVi, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadAccountDeleted();
                    }
                    else
                        MessageBox.Show(info.restoreFailedVi, info.titleMessageVi, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                frmRecycleBin_Load(sender, e);
            }
            else
            {
                if (MessageBox.Show(info.messageRestoreEn, info.titleMessageEn, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    int count = AccountBUS.Instance.RestoreAccountByUserName(txtUsername.Text);
                    if (count > 0)
                    {
                        MessageBox.Show(info.restoreEn, info.titleMessageEn, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadAccountDeleted();
                    }
                    else
                        MessageBox.Show(info.restoreFailedVi, info.titleMessageVi, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
               
            }
        }

        private void btnRestoreAllAccount_Click(object sender, EventArgs e)
        {
            if (Language == info.valueDefault)
            {
                if (MessageBox.Show(info.messageRestoreAllVi, info.titleMessageVi, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    int count = AccountBUS.Instance.RestoreAllAccount();
                    if (count > 0)
                    {
                        MessageBox.Show(info.restoreAllVi, info.titleMessageVi, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadAccountDeleted();
                    }
                    else
                        MessageBox.Show(info.restoreAllFailedVi, info.titleMessageVi, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                if (MessageBox.Show(info.messageRestoreAllEn, info.titleMessageEn, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    int count = AccountBUS.Instance.RestoreAllAccount();
                    if (count > info.valueDefault)
                    {
                        MessageBox.Show(info.restoreAllEn, info.titleMessageEn, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadAccountDeleted();
                    }
                    else
                        MessageBox.Show(info.restoreAllFailedEn, info.titleMessageEn, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            
        }

        public void LoadAccountDeleted()
        {
            dtgvListAccountDeleted.DataSource = AccountBUS.Instance.GetListAccountDeleted();
            frmQuanLyAdmin.ActiveForm.Load += new EventHandler(LoadForm);

        }

        private void dtgvListAccountDeleted_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            info.firstIndex = info.valueDefault;
            int i = e.RowIndex;
            if (i == -1) return;
            txtUsername.Text = dtgvListAccountDeleted.Rows[i].Cells[info.firstIndex].Value.ToString();
            txtPassword.Text = dtgvListAccountDeleted.Rows[i].Cells[info.firstIndex += 1].Value.ToString();
            txtEmployee.Text = dtgvListAccountDeleted.Rows[i].Cells[info.firstIndex += 1].Value.ToString();
            int type = int.Parse(dtgvListAccountDeleted.Rows[i].Cells[info.firstIndex += 1].Value.ToString());
            if (type == info.idManager)
                txtTypeAccount.Text = info.positionManager;
            else
                txtTypeAccount.Text = info.positionSeller;

        }
        #endregion

        #region Product
        private void LoadProductDeleted()
        {
            dtgvListProductDeleted.DataSource = ProductBUS.Instance.GetProductDeleted();
            frmQuanLyAdmin.ActiveForm.Load += new EventHandler(LoadForm);
        }
        private void dtgvListProductDeleted_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            info.firstIndex = info.valueDefault;
            if (i == -1) return;
            MemoryStream memoryStream = new MemoryStream((byte[])dtgvListProductDeleted.Rows[i].Cells[info.firstIndex].Value);
            pbProduct.Image = Image.FromStream(memoryStream);
            txtProductID.Text = dtgvListProductDeleted.Rows[i].Cells[info.firstIndex += 1].Value.ToString();
            txtProductName.Text = dtgvListProductDeleted.Rows[i].Cells[info.firstIndex += 1].Value.ToString();
            txtCategoryProduct.Text = dtgvListProductDeleted.Rows[i].Cells[info.firstIndex +=1].Value.ToString();
            numQuantity.Value = Convert.ToInt32(dtgvListProductDeleted.Rows[i].Cells[info.firstIndex += 2].Value);
            txtPrice.Text = dtgvListProductDeleted.Rows[i].Cells[info.firstIndex += 1].Value.ToString();
            richtxtDescribe.Text = dtgvListProductDeleted.Rows[i].Cells[info.firstIndex += 1].Value.ToString();
        }
        private void btnRestoreProduct_Click(object sender, EventArgs e)
        {
            if (Language == info.valueDefault)
            {
                if (DialogResult.Yes == MessageBox.Show(info.messageRestoreVi, info.titleMessageVi, MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    int cout = ProductBUS.Instance.RestoreProduct(txtProductID.Text);
                    if (cout > 0)
                    {
                        MessageBox.Show(info.restoreVi, info.titleMessageVi, MessageBoxButtons.OK,MessageBoxIcon.Information);
                        LoadProductDeleted();
                    }
                    else
                        MessageBox.Show(info.restoreFailedVi, info.titleMessageVi, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                if (DialogResult.Yes == MessageBox.Show(info.messageRestoreEn, info.titleMessageEn, MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    int cout = ProductBUS.Instance.RestoreProduct(txtProductID.Text);
                    if (cout > 0)
                    {
                        MessageBox.Show(info.restoreEn, info.titleMessageEn, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadProductDeleted();
                    }
                    else
                        MessageBox.Show(info.restoreFailedEn, info.titleMessageEn, MessageBoxButtons.OK, MessageBoxIcon.Warning);                   
                }
            }
        }
        private void btnRestoreAllProduct_Click(object sender, EventArgs e)
        {
            if (Language == info.valueDefault)
            {
                if (DialogResult.Yes == MessageBox.Show(info.messageRestoreAllVi, info.titleMessageVi, MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    int cout = ProductBUS.Instance.RestoreProductAll();
                    if (cout > info.valueDefault)
                    {
                        MessageBox.Show(info.restoreAllVi, info.titleMessageVi, MessageBoxButtons.OK,MessageBoxIcon.Information);
                        LoadProductDeleted();

                    }
                    else
                        MessageBox.Show(info.restoreAllFailedVi, info.titleMessageVi, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {

                if (DialogResult.Yes == MessageBox.Show(info.messageRestoreAllEn, info.titleMessageEn, MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    int cout = ProductBUS.Instance.RestoreProductAll();
                    if (cout > info.valueDefault)
                    {
                        MessageBox.Show(info.restoreAllEn, info.titleMessageEn, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadProductDeleted();
                    }
                    else
                        MessageBox.Show(info.restoreAllFailedEn, info.titleMessageEn, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    
                }
            }
        }
        #endregion
      
        #region Employee
        public void LoadEmployeeDeleted()
        {
            frmEmployeeManager.ActiveForm.Load += new EventHandler(LoadForm);
            dtgvListEmployeeDeleted.DataSource = EmployeeMenuBUS.Instance.GetListEmployeeDeleted();
            cbPosition.DataSource = PositionBUS.Instance.GetListPosition();
            cbPosition.DisplayMember = "TENCHUCVU";
            cbPosition.ValueMember = "MACHUCVU";
        }

        private void btnRestoreEmployee_Click(object sender, EventArgs e)
        {
            if (Language == info.valueDefault)
            {
                if (MessageBox.Show(info.messageRestoreVi, info.titleMessageVi, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    int count = EmployeeBUS.Instance.RestoreEmployeeInfo(Convert.ToInt32(txtEmployeeID.Text));
                    if (count > info.valueDefault)
                    {
                        MessageBox.Show(info.restoreVi, info.titleMessageVi, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadEmployeeDeleted();
                    }
                    else
                        MessageBox.Show(info.restoreFailedVi, info.titleMessageVi, MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
            }
            else
            {
                if (MessageBox.Show(info.messageRestoreEn, info.titleMessageEn, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    int count = EmployeeBUS.Instance.RestoreEmployeeInfo(Convert.ToInt32(txtEmployeeID.Text));
                    if (count > info.valueDefault)
                    {
                        MessageBox.Show(info.restoreEn, info.titleMessageEn, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadEmployeeDeleted();
                    }
                    else
                        MessageBox.Show(info.restoreFailedEn, info.titleMessageEn, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }           
    
        }

        private void btnRestoreAllEmployee_Click(object sender, EventArgs e)
        {
            if (Language == info.valueDefault)
            {
                if (MessageBox.Show(info.messageRestoreAllVi, info.titleMessageVi, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    int count = EmployeeBUS.Instance.RestoreAllEmployee();
                    if (count > info.valueDefault)
                    {
                        MessageBox.Show(info.restoreAllVi, info.titleMessageVi, MessageBoxButtons.OK,MessageBoxIcon.Information);
                        LoadEmployeeDeleted();
                    }
                    else
                        MessageBox.Show(info.restoreAllFailedVi, info.titleMessageVi, MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
            }
            else
            {
                if (MessageBox.Show(info.messageRestoreAllEn, info.titleMessageEn, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    int count = EmployeeBUS.Instance.RestoreAllEmployee();
                    if (count > info.valueDefault)
                        MessageBox.Show(info.restoreAllEn, info.titleMessageEn, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show(info.restoreAllFailedEn, info.titleMessageEn, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            frmRecycleBin_Load(sender, e);
 
        }

        private void dtgvListEmployeeDeleted_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            info.firstIndex = info.valueDefault;

            if (dtgvListEmployeeDeleted.SelectedRows.Count > info.valueDefault)
            {
                txtEmployeeID.Text = dtgvListEmployeeDeleted.SelectedRows[info.valueDefault].Cells[info.firstIndex].Value.ToString();
                txtEmployeeName.Text = dtgvListEmployeeDeleted.SelectedRows[info.valueDefault].Cells[info.firstIndex += 1].Value.ToString();
                dtpBirthday.Text = dtgvListEmployeeDeleted.SelectedRows[info.valueDefault].Cells[info.firstIndex += 1].Value.ToString();
                string gender = dtgvListEmployeeDeleted.SelectedRows[info.valueDefault].Cells[info.firstIndex += 1].Value.ToString();
                if (gender == radMale.Text)
                    radMale.Checked = true;
                else
                    radFemale.Checked = true;
                txtNumberPhone.Text = dtgvListEmployeeDeleted.SelectedRows[info.valueDefault].Cells[info.firstIndex += 1].Value.ToString();
                richtxtAddress.Text = dtgvListEmployeeDeleted.SelectedRows[info.valueDefault].Cells[info.firstIndex += 1].Value.ToString();
                dtpWorkingDay.Text = dtgvListEmployeeDeleted.SelectedRows[info.valueDefault].Cells[info.firstIndex += 1].Value.ToString();           
                cbPosition.SelectedValue = Convert.ToInt32(dtgvListEmployeeDeleted.SelectedRows[info.valueDefault].Cells[info.firstIndex += 2].Value.ToString());
            }
        }
        #endregion

        #region Bill Info
        public void LoadBillInfoDeleted()
        {
            dtgvListBillDetailDeleted.DataSource = BillInfoMenuBUS.Instance.GetListBillInfoMenuDeleted();
            frmBillDetail.ActiveForm.Load += new EventHandler(LoadForm);
            ResetBillInfo();
        }

        public void ResetBillInfo()
        {
            txtBillID.Clear();
            txtProductNameBill.Clear();
            numCountBillInfo.Value = info.count;
            txtPriceBillInfo.Clear();
            txtTotalBillInfo.Clear();
        }

        private void dtgvListBillDetailDeleted_SelectionChanged(object sender, EventArgs e)
        {
            info.firstIndex = info.valueDefault;
            if (dtgvListBillDetailDeleted.SelectedRows.Count > info.valueDefault)
            {
                txtBillID.Text = dtgvListBillDetailDeleted.SelectedRows[info.valueDefault].Cells[info.firstIndex].Value.ToString();
                txtProductNameBill.Text = dtgvListBillDetailDeleted.SelectedRows[info.valueDefault].Cells[info.firstIndex += 1].Value.ToString();
                numCountBillInfo.Value = int.Parse(dtgvListBillDetailDeleted.SelectedRows[info.valueDefault].Cells[info.firstIndex += 1].Value.ToString());                
                txtPriceBillInfo.Text = dtgvListBillDetailDeleted.SelectedRows[info.valueDefault].Cells[info.firstIndex += 1].Value.ToString();                             
                txtTotalBillInfo.Text = dtgvListBillDetailDeleted.SelectedRows[info.valueDefault].Cells[info.firstIndex += 1].Value.ToString();
            }
        }

        private void btnRestoreBillDetail_Click(object sender, EventArgs e)
        {
            string productID = info.strDefault;
            info.firstIndex = info.valueDefault;
            if (dtgvListBillDetailDeleted.SelectedRows.Count > info.valueDefault)
                productID = dtgvListBillDetailDeleted.SelectedRows[info.valueDefault].Cells[info.firstIndex += 5].Value.ToString();
            if (Language == info.valueDefault)
            {
                if (MessageBox.Show(info.messageRestoreVi, info.titleMessageVi, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    
                    int count = BillInfoBUS.Instance.RestoreBillInfo(txtBillID.Text, productID);

                    if (count > 0)
                    {
                        MessageBox.Show(info.restoreVi, info.titleMessageVi, MessageBoxButtons.OK,MessageBoxIcon.Information);
                        LoadBillInfoDeleted();

                    }
                    else
                        MessageBox.Show(info.restoreFailedVi, info.titleMessageVi, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                if (MessageBox.Show(info.messageRestoreEn, info.titleMessageEn, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {                    
                    int count = BillInfoBUS.Instance.RestoreBillInfo(txtBillID.Text, productID);

                    if (count > info.valueDefault)
                    {
                        MessageBox.Show(info.restoreEn, info.titleMessageEn, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadBillInfoDeleted();
                    }
                    else
                        MessageBox.Show(info.restoreFailedEn, info.titleMessageEn, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                
            }
        }

        private void btnRestoreAllBillDetail_Click(object sender, EventArgs e)
        {
            if (Language == info.valueDefault)
            {
                if (MessageBox.Show(info.messageRestoreAllVi, info.titleMessageVi, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {                    
                    int count = BillInfoBUS.Instance.RestoreAllBillInfo();

                    if (count > info.valueDefault)
                    {
                        MessageBox.Show(info.restoreAllVi, info.titleMessageVi, MessageBoxButtons.OK,MessageBoxIcon.Information);
                        LoadBillInfoDeleted();

                    }
                    else
                        MessageBox.Show(info.restoreAllFailedVi, info.titleMessageVi, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                if (MessageBox.Show(info.messageRestoreAllEn, info.titleMessageEn, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {                    
                    int count = BillInfoBUS.Instance.RestoreAllBillInfo();

                    if (count > info.valueDefault)
                    {
                        MessageBox.Show(info.restoreAllEn, info.titleMessageEn, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadBillInfoDeleted();
                    }
                    else
                        MessageBox.Show(info.restoreAllFailedEn, info.titleMessageEn, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }              
            }
        }

        #endregion
       
    }
}
