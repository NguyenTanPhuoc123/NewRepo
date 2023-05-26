
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

namespace frmLogin
{
    public partial class frmRecycleBinCategory : Form
    {
        HashCode info = new HashCode();
        private int Language = frmlogin.Language;
        public frmRecycleBinCategory()
        {
            if (Language == info.valueDefault)
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("vi");
            else
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en");
            InitializeComponent();
            dtgvListTypeAccountDeleted.AutoGenerateColumns = false;
            dtgvListDiscountDeleted.AutoGenerateColumns = false;
            dtgvListPositionDeleted.AutoGenerateColumns = false;
            dtgvListLocationDeleted.AutoGenerateColumns = false;
            dtgvListTypeProductDeleted.AutoGenerateColumns = false;
            
        }

        private void frmRecycleBinCategory_Load(object sender, EventArgs e)
        {
            LoadLocationDeleted();
            LoadTypeAccountDeleted();
            LoadPositionDeleted();
            LoadDiscountDeleted();
        }

        private void btnExitFormRecycleBinCategory_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void CloseForm(object sender, EventArgs e)
        {

        }

        #region Location
        private void tpLocationDeleted_Click(object sender, EventArgs e)
        {
            LoadLocationDeleted();
            frmCategoyManagement.ActiveForm.Load += new EventHandler(CloseForm);
        }
        public void LoadLocationDeleted()
        {
            txtLocationID.Clear();
            txtLocationName.Clear();
            dtgvListLocationDeleted.DataSource = LocationBUS.Instance.GetListLocationDeleted();
        }

        private void dtgvListLocationDeleted_SelectionChanged(object sender, EventArgs e)
        {
            info.firstIndex = info.valueDefault;
            if (dtgvListLocationDeleted.SelectedRows.Count > info.valueDefault)
            {
                txtLocationID.Text = dtgvListLocationDeleted.SelectedRows[info.valueDefault].Cells[info.firstIndex].Value.ToString();
                txtLocationName.Text = dtgvListLocationDeleted.SelectedRows[info.valueDefault].Cells[info.firstIndex+=1].Value.ToString();

            }
        }

        private void btnRestoreLocation_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(info.messageRestoreVi,info.titleMessageVi, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int count = LocationBUS.Instance.RestoreLocation(int.Parse(txtLocationID.Text));
                if (count > 0)
                {
                    MessageBox.Show(info.restoreVi,info.titleMessageVi, MessageBoxButtons.OK);
                    LoadLocationDeleted();
                }
                else
                    MessageBox.Show(info.restoreFailedVi,info.titleMessageVi, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnRestoreAllLocation_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(info.messageRestoreAllVi,info.titleMessageVi, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                int count = LocationBUS.Instance.RestoreAllLocation();
                if (count > 0)
                {
                    MessageBox.Show(info.restoreAllVi,info.titleMessageVi, MessageBoxButtons.OK);
                    LoadLocationDeleted();
                }
                else
                    MessageBox.Show(info.restoreAllFailedVi,info.titleMessageVi, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        #endregion

        #region TypeProduct
        private void LoadTypeProductDeleted()
        {
            dtgvListTypeProductDeleted.DataSource = CategoryFoodBUS.Instance.GetCategoryFoodsDeleted();
            frmCategoyManagement.ActiveForm.Load += new EventHandler(CloseForm);
        }
        private void dtgvListTypeProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            info.firstIndex = info.valueDefault;
            if (i == -1) return;
            txtProductID.Text = dtgvListTypeProductDeleted.Rows[i].Cells[info.firstIndex].Value.ToString();
            txtProductName.Text = dtgvListTypeProductDeleted.Rows[i].Cells[info.firstIndex+=1].Value.ToString();
        }
        private void btnRestoreTypeProduct_Click(object sender, EventArgs e)
        {
            if (Language == info.valueDefault)
            {
                if (DialogResult.Yes == MessageBox.Show(info.messageRestoreVi,info.titleMessageVi, MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    int count = CategoryFoodBUS.Instance.RestoreCategoryFood(txtProductID.Text);
                    if (count > info.valueDefault)
                    {
                        MessageBox.Show(info.restoreVi, info.titleMessageVi, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadTypeProductDeleted();
                    }
                    else
                        MessageBox.Show(info.restoreFailedEn, info.titleMessageVi, MessageBoxButtons.OK, MessageBoxIcon.Warning);                    
                }
            }
            else
            {
                if (DialogResult.Yes == MessageBox.Show(info.messageRestoreEn,info.titleMessageEn, MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    int count = CategoryFoodBUS.Instance.RestoreCategoryFood(txtProductID.Text);
                    if (count > 0)
                    {
                        MessageBox.Show(info.restoreEn,info.titleMessageEn, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadTypeProductDeleted();
                    }
                    else
                        MessageBox.Show(info.restoreFailedEn,info.titleMessageEn, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                   
                }
            }
        }

        private void btnRestoreAllTypeProduct_Click(object sender, EventArgs e)
        {
            if (Language == 0)
            {
                if (DialogResult.Yes == MessageBox.Show(info.messageRestoreAllVi,info.titleMessageVi, MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    int count = CategoryFoodBUS.Instance.RestoreCategoryFood(txtProductID.Text);
                    if (count > 0)
                    {
                        MessageBox.Show(info.restoreAllVi, info.titleMessageVi, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadTypeProductDeleted();
                    }
                    else
                        MessageBox.Show(info.restoreAllFailedVi, info.titleMessageVi, MessageBoxButtons.OK, MessageBoxIcon.Warning);                  
                }
            }
            else
            {
                if (DialogResult.Yes == MessageBox.Show(info.messageRestoreAllEn,info.titleMessageEn, MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    int count = CategoryFoodBUS.Instance.RestoreCategoryFood(txtProductID.Text);
                    if (count > 0)
                    {
                        MessageBox.Show(info.restoreAllEn, info.titleMessageEn, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadTypeProductDeleted();
                    }
                    else
                        MessageBox.Show(info.restoreAllFailedEn, info.titleMessageEn, MessageBoxButtons.OK, MessageBoxIcon.Warning);               
                }
            }
        }
        #endregion

        #region TypeAccount
        private void LoadTypeAccountDeleted()
        {
            frmCategoyManagement.ActiveForm.Load += new EventHandler(CloseForm);
            dtgvListTypeAccountDeleted.DataSource = TypeAccountBUS.Instance.GetListTypeAccountDelete();
        }

        private void dtgvListTypeAccountDeleted_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            info.firstIndex = info.valueDefault;
            if (i == -1) return;
            txtTypeAccountID.Text = dtgvListTypeAccountDeleted.Rows[i].Cells[info.firstIndex].Value.ToString();
            txtTypeAccountName.Text = dtgvListTypeAccountDeleted.Rows[i].Cells[info.firstIndex+=1].Value.ToString();
        }

        private void btnRestoreTypeAccount_Click(object sender, EventArgs e)
        {
            if (Language == info.valueDefault)
            {
                if (DialogResult.Yes == MessageBox.Show(info.messageRestoreVi,info.titleMessageVi, MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    int count = TypeAccountBUS.Instance.RestoreTypeAccount(Convert.ToInt32(txtTypeAccountID.Text));
                    if (count > info.valueDefault)
                    {
                        MessageBox.Show(info.restoreVi, info.titleMessageVi, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadTypeAccountDeleted();
                    }
                    else
                        MessageBox.Show(info.restoreFailedVi, info.titleMessageVi, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    
                }
            }
            else
            {
                if (DialogResult.Yes == MessageBox.Show(info.messageRestoreEn,info.titleMessageEn, MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    int count = TypeAccountBUS.Instance.RestoreTypeAccount(Convert.ToInt32(txtTypeAccountID.Text));
                    if (count > info.valueDefault)
                    {
                        MessageBox.Show(info.restoreEn, info.titleMessageEn, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadTypeAccountDeleted();
                    }
                    else
                        MessageBox.Show(info.restoreFailedEn, info.titleMessageEn, MessageBoxButtons.OK, MessageBoxIcon.Warning);               
                }
            }
        }

        private void btnRestoreAllTypeAccount_Click(object sender, EventArgs e)
        {
            if (Language == 0)
            {
                if (DialogResult.Yes == MessageBox.Show(info.messageRestoreAllVi,info.titleMessageVi, MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    int count = TypeAccountBUS.Instance.RestoreAllTypeAccount();
                    if (count > info.valueDefault)
                    {
                        MessageBox.Show(info.restoreAllVi, info.titleMessageVi, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadTypeAccountDeleted();
                    }
                    else
                        MessageBox.Show(info.restoreAllFailedVi, info.titleMessageVi, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    
                }
            }
            else
            {
                if (DialogResult.Yes == MessageBox.Show(info.messageRestoreAllEn,info.titleMessageEn, MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    int count = TypeAccountBUS.Instance.RestoreAllTypeAccount();
                    if (count > 0)
                    {
                        MessageBox.Show(info.restoreAllEn, info.titleMessageEn, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadTypeAccountDeleted();
                    }
                    else
                        MessageBox.Show(info.restoreAllFailedEn, info.titleMessageEn, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    
                }
            }
        }
        #endregion

        #region Position

        public void LoadPositionDeleted()
        {
            dtgvListPositionDeleted.DataSource = PositionBUS.Instance.GetListPositionDeleted();
            frmCategoyManagement.ActiveForm.Load += new EventHandler(CloseForm);
        }

        private void RestorePosition_Click(object sender, EventArgs e)
        {
            if (Language == 0)
            {
                if (DialogResult.Yes == MessageBox.Show(info.messageRestoreVi,info.titleMessageVi, MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    int count = PositionBUS.Instance.RestorePosition(Convert.ToInt32(txtPositionID.Text));
                    if (count > 0)
                    {
                        MessageBox.Show(info.restoreVi, info.titleMessageVi, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadTypeAccountDeleted();
                    }
                    else
                        MessageBox.Show(info.restoreFailedVi, info.titleMessageVi, MessageBoxButtons.OK, MessageBoxIcon.Warning);                   
                }
            }
            else
            {
                if (DialogResult.Yes == MessageBox.Show(info.messageRestoreEn,info.titleMessageEn, MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    int count = PositionBUS.Instance.RestorePosition(Convert.ToInt32(txtPositionID.Text));
                    if (count > 0)
                    {
                        MessageBox.Show(info.restoreEn, info.titleMessageEn, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show(info.restoreFailedEn, info.titleMessageEn, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    LoadTypeAccountDeleted();
                }
            }
        }

        private void RestoreAllPosition_Click(object sender, EventArgs e)
        {
            if (Language == 0)
            {
                if (DialogResult.Yes == MessageBox.Show(info.restoreAllFailedVi, info.titleMessageVi, MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    int count = PositionBUS.Instance.RestoreAllPosition();
                    if (count > 0)
                    {
                        MessageBox.Show(info.restoreAllVi, info.titleMessageVi, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadTypeAccountDeleted();
                    }
                    else
                        MessageBox.Show(info.restoreAllFailedVi, info.titleMessageVi, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                   
                }
            }
            else
            {
                if (DialogResult.Yes == MessageBox.Show(info.messageRestoreAllEn, info.titleMessageEn, MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    int count = PositionBUS.Instance.RestoreAllPosition();
                    if (count > 0)
                    {
                        MessageBox.Show(info.restoreAllEn, info.titleMessageEn, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadTypeAccountDeleted();
                    }
                    else
                        MessageBox.Show(info.restoreAllFailedEn, info.titleMessageEn, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    
                }
            }
        }

        private void dtgvListPositionDeleted_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            info.firstIndex = info.valueDefault;
            if (i == -1) return;
            txtPositionID.Text = dtgvListPositionDeleted.Rows[i].Cells[info.firstIndex].Value.ToString();
            txtPositionName.Text = dtgvListPositionDeleted.Rows[i].Cells[info.firstIndex+=1].Value.ToString();
        }
        #endregion

        #region Discount
        public void LoadDiscountDeleted()
        {
            dtgvListDiscountDeleted.DataSource = DiscountBUS.Instance.GetListDiscountDeleted();
            frmCategoyManagement.ActiveForm.Load += new EventHandler(CloseForm);
            ResetInfoDiscount();
        }

        public void ResetInfoDiscount()
        {
            txtDiscountID.Clear();
            txtDiscountName.Clear();
            txtDiscountPrice.Clear();
            txtStartDayDiscount.Clear();
            txtEndDayDiscount.Clear();
        }
        
        private void dtgvListDiscountDeleted_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgvListDiscountDeleted.SelectedRows.Count > 0)
            {
                info.firstIndex = info.valueDefault;
                txtDiscountID.Text = dtgvListDiscountDeleted.SelectedRows[info.valueDefault].Cells[info.firstIndex].Value.ToString();
                txtDiscountName.Text = dtgvListDiscountDeleted.SelectedRows[info.valueDefault].Cells[info.firstIndex+=1].Value.ToString();
                txtDiscountPrice.Text = dtgvListDiscountDeleted.SelectedRows[info.valueDefault].Cells[info.firstIndex+=1].Value.ToString();
                txtStartDayDiscount.Text = dtgvListDiscountDeleted.SelectedRows[info.valueDefault].Cells[info.firstIndex += 1].Value.ToString();
                txtEndDayDiscount.Text = dtgvListDiscountDeleted.SelectedRows[info.valueDefault].Cells[info.firstIndex += 1].Value.ToString();
                txtAvailableDiscount.Text = dtgvListDiscountDeleted.SelectedRows[info.valueDefault].Cells[info.firstIndex += 1].Value.ToString();
                txtLimitDiscount.Text = dtgvListDiscountDeleted.SelectedRows[info.valueDefault].Cells[info.firstIndex += 1].Value.ToString();
            }
        }

        private void btnRestoreDiscount_Click(object sender, EventArgs e)
        {
            if (Language == 0)
            {
                if (MessageBox.Show(info.messageRestoreVi, info.titleMessageVi, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {

                    string discountID = txtDiscountID.Text;

                    int count = DiscountBUS.Instance.RestoreDiscount(discountID);
                    if (count > 0)
                    {
                        MessageBox.Show(info.restoreVi, info.titleMessageVi, MessageBoxButtons.OK);
                        LoadDiscountDeleted();
                    }
                    else
                        MessageBox.Show(info.restoreFailedVi, info.titleMessageVi, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                if (MessageBox.Show(info.messageRestoreEn, info.titleMessageEn, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {

                    string discountID = txtDiscountID.Text;

                    int count = DiscountBUS.Instance.RestoreDiscount(discountID);
                    if (count > 0)
                        MessageBox.Show(info.restoreEn, info.titleMessageEn, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show(info.restoreFailedEn, info.titleMessageEn, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    LoadDiscountDeleted();
                }
            }
        }

        private void btnRestoreAllDiscount_Click(object sender, EventArgs e)
        {
            if (Language == 0)
            {
                if (MessageBox.Show(info.messageRestoreAllVi, info.titleMessageVi, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {

                    int count = DiscountBUS.Instance.RestoreAllDiscount();
                    if (count > 0)
                    {
                        MessageBox.Show(info.restoreAllVi, info.titleMessageVi, MessageBoxButtons.OK);
                        LoadDiscountDeleted();
                    }
                    else
                        MessageBox.Show(info.restoreAllFailedVi, info.titleMessageVi, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                if (MessageBox.Show(info.messageRestoreAllEn, info.titleMessageEn, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {

                    int count = DiscountBUS.Instance.RestoreAllDiscount();
                    if (count > 0)
                        MessageBox.Show(info.restoreAllEn, info.titleMessageEn, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show(info.restoreAllFailedEn, info.titleMessageEn, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    LoadDiscountDeleted();
                }
            }
        }


        #endregion

    }
}