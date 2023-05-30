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
using Microsoft.ReportingServices.Interfaces;

namespace frmLogin
{
    public partial class frmCategoyManagement : Form
    {
        private int Language = frmlogin.Language;
        HashCode info = new HashCode();
        public frmCategoyManagement()
        {
            if (Language == info.valueDefault)
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("vi");
            else
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en");
            InitializeComponent();
            dtgvListDiscount.AutoGenerateColumns = false;
            dtgvListLocation.AutoGenerateColumns = false;
            dtgvListPosition.AutoGenerateColumns = false;
            dtgvListTypeAccount.AutoGenerateColumns = false;
            dtgvListTypeProduct.AutoGenerateColumns = false;
        }


        private void frmCategoyManagement_Load(object sender, EventArgs e)
        {
            LoadLocationTable();
            LoadTypeProduct();
            LoadPosition();
            LoadTypeAccount();
            LoadListDiscount();
            LoadTypeProduct();
        }

        #region Location Table Food

        public void LoadLocationTable()
        {
            dtgvListLocation.DataSource = LocationBUS.Instance.GetListLocation();
            btnSaveLocation.Enabled = false;
            btnEditLocation.Enabled = true;
            btnDeleteLocation.Enabled = true;
            btnDeleteAllLocation.Enabled = true;
            ResetLocationInfo();
        }

        public void ResetLocationInfo()
        {
            txtLocationID.Clear();
            txtLocationName.Clear();
        }

        private void btnAddLocation_Click(object sender, EventArgs e)
        {
            int i = LocationBUS.Instance.GetListLocation().Count + 1;
            txtLocationID.Text = i.ToString();
            txtLocationName.Clear();
            btnSaveLocation.Enabled = true;
            btnEditLocation.Enabled = false;
            btnDeleteLocation.Enabled = false;
            btnDeleteAllLocation.Enabled = false;
            
        }

        private void btnSaveLocation_Click(object sender, EventArgs e)
        {
            if (Language == info.valueDefault)
            {
                if (string.IsNullOrEmpty(txtLocationName.Text.Trim()))
                {
                    MessageBox.Show(info.eventNullVi, info.titleMessageVi, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (LocationBUS.Instance.CheckNameExist(txtLocationName.Text)==true)
                {
                    int count = LocationBUS.Instance.AddLocationTable(txtLocationName.Text);
                    if (count > info.valueDefault)
                    {
                        MessageBox.Show(info.addVi,info.titleMessageVi, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadLocationTable();
                    }

                    else
                    {
                        MessageBox.Show(info.addFailedVi,info.titleMessageVi, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show(info.MessageCheckExistVi(txtLocationName.Text),info.titleMessageVi, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                
            }
            else
            {
                if (string.IsNullOrEmpty(txtLocationName.Text.Trim()))
                {
                    MessageBox.Show(info.eventNullEn,info.eventNullEn, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (LocationBUS.Instance.CheckNameExist(txtLocationName.Text)==true)
                {
                    int count = LocationBUS.Instance.AddLocationTable(txtLocationName.Text);
                    if (count > 0)
                    {
                        MessageBox.Show(info.addEn,info.titleMessageEn, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadLocationTable();
                    }

                    else
                    {
                        MessageBox.Show(info.addFailedEn,info.titleMessageEn, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show(info.MessageCheckExistEn(txtLocationName.Text),info.titleMessageEn, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                
            }
        }

        private void btnEditLocation_Click(object sender, EventArgs e)
        {
            if (Language == info.valueDefault)
            {
                if (string.IsNullOrEmpty(txtLocationName.Text.Trim()))
                {
                    MessageBox.Show(info.eventNullVi,info.titleMessageVi, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (MessageBox.Show(info.messageEditVi,info.titleMessageVi, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (LocationBUS.Instance.CheckNameExist(txtLocationName.Text,txtLocationID.Text))
                    {
                        int count = LocationBUS.Instance.UpdateLocationTable(int.Parse(txtLocationID.Text), txtLocationName.Text);
                        if (count > info.valueDefault)
                        {
                            MessageBox.Show(info.editVi, info.titleMessageVi, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadLocationTable();
                        }

                        else
                        {
                            MessageBox.Show(info.editFailedVi, info.titleMessageVi, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show(info.MessageCheckExistVi(txtLocationName.Text),info.titleMessageVi, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    
                }
            }
            else
            {
                if (string.IsNullOrEmpty(txtLocationName.Text.Trim()))
                {
                    MessageBox.Show(info.eventNullEn,info.titleMessageEn, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (MessageBox.Show(info.messageEditEn,info.titleMessageEn, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (LocationBUS.Instance.CheckNameExist(txtLocationName.Text, txtLocationID.Text))
                    {
                        int count = LocationBUS.Instance.UpdateLocationTable(int.Parse(txtLocationID.Text), txtLocationName.Text);
                        if (count > info.valueDefault)
                        {
                            MessageBox.Show(info.editEn, info.titleMessageEn, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadLocationTable();
                        }

                        else
                        {
                            MessageBox.Show(info.editFailedEn, info.titleMessageEn, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show(info.MessageCheckExistEn(txtLocationName.Text),info.titleMessageEn, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
            }
        }

        private void btnDeleteLocation_Click(object sender, EventArgs e)
        {
            if (Language == info.valueDefault)
            {
                if (MessageBox.Show(info.messageDeleteEn,info.titleMessageVi, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    
                        int count = LocationBUS.Instance.DeleteLocationTable(int.Parse(txtLocationID.Text));
                        if (count > info.valueDefault)
                        {
                            MessageBox.Show(info.deleteVi,info.titleMessageVi, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadLocationTable();
                    }

                        else
                        {
                            MessageBox.Show(info.deleteFailedVi,info.titleMessageVi, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }                                                      
                }
            }
            else
            {

                if (MessageBox.Show(info.messageDeleteEn,info.titleMessageEn, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {                  
                    int count = LocationBUS.Instance.DeleteLocationTable(int.Parse(txtLocationID.Text));
                    if (count > info.valueDefault)
                    {
                        MessageBox.Show(info.deleteEn,info.titleMessageEn, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadLocationTable();
                    }
                    else
                    {
                        MessageBox.Show(info.deleteFailedEn,info.titleMessageEn, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                                                              
                }
            }
        }

        private void btnDeleteAllLocation_Click(object sender, EventArgs e)
        {
            if (Language == info.valueDefault)
            {
                if (MessageBox.Show(info.messageDeleteAllVi,info.titleMessageVi, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {

                    int count = LocationBUS.Instance.DeleteAllLocationTable();
                    if (count > info.valueDefault)
                    {
                        MessageBox.Show(info.deleteAllVi, info.titleMessageVi, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadLocationTable();
                    }

                    else
                    {
                        MessageBox.Show(info.deleteAllFailedVi,info.titleMessageVi, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    
                }
            }
            else
            {
                if (MessageBox.Show(info.messageDeleteAllEn,info.titleMessageEn, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {                   
                    int count = LocationBUS.Instance.DeleteAllLocationTable();
                    if (count > 0)
                    {
                        MessageBox.Show(info.deleteAllEn,info.titleMessageEn, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadLocationTable();
                    }

                    else
                    {
                        MessageBox.Show(info.deleteAllFailedEn, info.titleMessageEn, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }                                       
                    
                }
            }
        }

        private void btnLocationDeleted_Click(object sender, EventArgs e)
        {
            frmRecycleBinCategory frm = new frmRecycleBinCategory();
            frm.Show();
        }

        private void dtgvListLocation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            info.firstIndex = info.valueDefault;
            if (dtgvListLocation.SelectedRows.Count > info.valueDefault)
                txtLocationID.Text = dtgvListLocation.SelectedRows[info.valueDefault].Cells[info.firstIndex].Value.ToString();
            txtLocationName.Text = dtgvListLocation.SelectedRows[info.valueDefault].Cells[info.firstIndex+=1].Value.ToString();
        }
        #endregion

        #region TypeProduct
        private void btnTypeProductDeleted_Click(object sender, EventArgs e)
        {
            frmRecycleBinCategory frm = new frmRecycleBinCategory();
            frm.Show();
        }

        private void LoadTypeProduct()
        {
            dtgvListTypeProduct.DataSource = CategoryFoodBUS.Instance.GetCategoryFoods();
        }
        private void reset()
        {
            txtTypeProductID.Clear();
            txtTypeProductName.Clear();
            btnAddTypeProduct.Enabled = true;
            btnSaveTypeProduct.Enabled = false;
        }
        private void dtgvListTypeProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            info.firstIndex = info.valueDefault;
            if (i == -1) return;
            txtTypeProductID.Text = dtgvListTypeProduct.Rows[i].Cells[info.firstIndex].Value.ToString();
            txtTypeProductName.Text = dtgvListTypeProduct.Rows[i].Cells[info.firstIndex+=1].Value.ToString();
        }
        private void btnAddTypeProduct_Click(object sender, EventArgs e)
        {
            txtTypeProductID.Clear();
            txtTypeProductName.Clear();
            int id = CategoryFoodBUS.Instance.GetCategoryFoodsID().Count + 1;
            txtTypeProductID.Text = id.ToString();
            btnSaveTypeProduct.Enabled = true;
            btnAddTypeProduct.Enabled = false;
        }
        private void btnSaveTypeProduct_Click(object sender, EventArgs e)
        {
            if (Language == info.valueDefault)
            {
                if (string.IsNullOrEmpty(txtTypeProductName.Text.Trim()))
                {
                    MessageBox.Show(info.eventNullVi,info.titleMessageVi, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (CategoryFoodBUS.Instance.checkNameExist(txtTypeProductName.Text))
                {
                    int count = CategoryFoodBUS.Instance.AddCategoryFood(txtTypeProductName.Text);
                    if (count > 0)
                    {
                        MessageBox.Show(info.addVi,info.titleMessageVi, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        reset();
                    }
                    else
                        MessageBox.Show(info.addFailedVi,info.titleMessageVi, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show(info.MessageCheckExistVi(txtTypeProductName.Text),info.titleMessageVi, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                LoadTypeProduct();
            }
            else
            {
                if (string.IsNullOrEmpty(txtTypeProductName.Text.Trim()))
                {
                    MessageBox.Show(info.eventNullEn,info.titleMessageEn, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (CategoryFoodBUS.Instance.checkNameExist(txtTypeProductName.Text))
                {
                    int count = CategoryFoodBUS.Instance.AddCategoryFood(txtTypeProductName.Text);
                    if (count > 0)
                    {
                        MessageBox.Show(info.addEn,info.titleMessageEn, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        reset();
                    }
                    else
                        MessageBox.Show(info.addFailedEn,info.titleMessageEn, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show(info.MessageCheckExistEn(txtTypeProductName.Text),info.titleMessageEn, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                LoadTypeProduct();
            }
        }

        private void btnEditTypeProduct_Click(object sender, EventArgs e)
        {
            if (Language == info.valueDefault)
            {
                if (string.IsNullOrEmpty(txtTypeProductID.Text.Trim()))
                {
                    MessageBox.Show(info.messEditTypeDishVi,info.titleMessageVi, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (DialogResult.Yes == MessageBox.Show(info.messageEditVi,info.titleMessageVi, MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {

                    if (string.IsNullOrEmpty(txtTypeProductID.Text.Trim()))
                    {
                        MessageBox.Show(info.eventNullVi,info.titleMessageVi, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (CategoryFoodBUS.Instance.checkNameExist(txtTypeProductName.Text,txtTypeProductID.Text))
                    {
                        int count = CategoryFoodBUS.Instance.UpdateCategoryFood(txtTypeProductID.Text, txtTypeProductName.Text);
                        if (count > 0)
                        {
                            MessageBox.Show(info.editVi,info.titleMessageVi, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            reset();
                        }
                        else
                            MessageBox.Show(info.editFailedVi,info.titleMessageVi, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                        MessageBox.Show(info.MessageCheckExistVi(txtTypeProductName.Text),info.titleMessageVi, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    LoadTypeProduct();
                }
            }
            else
            {

                if (string.IsNullOrEmpty(txtTypeProductID.Text))
                {
                    MessageBox.Show(info.messEditTypeDishEn,info.titleMessageEn, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (DialogResult.Yes == MessageBox.Show(info.messageEditEn,info.titleMessageEn, MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    if (string.IsNullOrEmpty(txtTypeProductID.Text.Trim()))
                    {
                        MessageBox.Show(info.eventNullEn,info.titleMessageEn, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (CategoryFoodBUS.Instance.checkNameExist(txtTypeProductName.Text, txtTypeProductID.Text))
                    {
                        int count = CategoryFoodBUS.Instance.UpdateCategoryFood(txtTypeProductID.Text, txtTypeProductName.Text);
                        if (count > 0)
                        {
                            MessageBox.Show(info.editEn,info.titleMessageEn, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            reset();
                        }
                        else
                            MessageBox.Show(info.editFailedEn,info.titleMessageEn, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                        MessageBox.Show(info.MessageCheckExistEn(txtTypeProductName.Text),info.titleMessageEn, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    LoadTypeProduct();
                }
            }
        }


        private void btnDeleteTypeProduct_Click(object sender, EventArgs e)
        {
            if (Language == 0)
            {
                if (string.IsNullOrEmpty(txtTypeProductID.Text))
                {
                    MessageBox.Show(info.messDelTypeDishVi,info.titleMessageVi, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (DialogResult.Yes == MessageBox.Show(info.messageDeleteVi,info.titleMessageVi, MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    if (CategoryFoodBUS.Instance.checkExistDelete(txtTypeProductID.Text))
                    {
                        int count = CategoryFoodBUS.Instance.DeleteCategoryFood(txtTypeProductID.Text);
                        if (count > 0)
                        {
                            MessageBox.Show(info.deleteVi,info.titleMessageVi, MessageBoxButtons.OK);
                            reset();
                        }
                        else
                            MessageBox.Show(info.deleteFailedVi,info.titleMessageVi, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                        MessageBox.Show(info.checkDelVi,info.titleMessageVi, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    LoadTypeProduct();
                }
            }
            else
            {
                if (string.IsNullOrEmpty(txtTypeProductID.Text))
                {
                    MessageBox.Show(info.messDelTypeDishEn,info.titleMessageEn, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (DialogResult.Yes == MessageBox.Show(info.messageDeleteEn,info.titleMessageEn, MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    if (CategoryFoodBUS.Instance.checkExistDelete(txtTypeProductID.Text))
                    {
                        int count = CategoryFoodBUS.Instance.DeleteCategoryFood(txtTypeProductID.Text);
                        if (count > 0)
                        {
                            MessageBox.Show(info.deleteEn,info.titleMessageEn, MessageBoxButtons.OK);
                            reset();
                        }
                        else
                            MessageBox.Show(info.deleteFailedEn,info.titleMessageEn, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                        MessageBox.Show(info.checkDelEn,info.titleMessageEn, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    LoadTypeProduct();
                }
            }
        }
        private void btnDeleteAllTypeProduct_Click(object sender, EventArgs e)
        {
            if (Language == 0)
            {
                if (DialogResult.Yes == MessageBox.Show(info.messageDeleteAllVi,info.titleMessageVi, MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    if (CategoryFoodBUS.Instance.checkExistDelete())
                    {
                        int count = CategoryFoodBUS.Instance.DeleteAllCategoryFood();
                        if (count > 0)
                        {
                            MessageBox.Show(info.deleteAllVi,info.titleMessageVi, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            reset();
                        }
                        else
                            MessageBox.Show(info.deleteAllFailedVi,info.titleMessageVi, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                        MessageBox.Show(info.checkDelVi,info.titleMessageVi, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    LoadTypeProduct();
                }
            }
            else
            {
                if (DialogResult.Yes == MessageBox.Show(info.messageDeleteAllEn,info.titleMessageEn, MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    if (CategoryFoodBUS.Instance.checkExistDelete())
                    {
                        int count = CategoryFoodBUS.Instance.DeleteAllCategoryFood();
                        if (count > 0)
                        {
                            MessageBox.Show(info.deleteAllEn,info.titleMessageEn, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            reset();
                        }
                        else
                            MessageBox.Show(info.deleteAllFailedEn,info.titleMessageEn, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                        MessageBox.Show(info.checkDelEn,info.titleMessageEn, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    LoadTypeProduct();
                }
            }
        }
        #endregion

        #region Position
        private void btnAddPosition_Click(object sender, EventArgs e)
        {
            int i = PositionBUS.Instance.GetListPosition().Count + 1;
            txtPositionID.Text = i.ToString();
            btnSavePosition.Enabled = true;
            btnDeleteAllPosition.Enabled = true;
        }

        private void btnSavePosition_Click(object sender, EventArgs e)
        {
            if (Language == info.valueDefault)
            {
                if (string.IsNullOrEmpty(txtPositionName.Text.Trim()))
                {
                    MessageBox.Show(info.eventNullVi,info.titleMessageVi, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (PositionBUS.Instance.checkNameExist(txtPositionName.Text))
                {
                    int count = PositionBUS.Instance.AddPosition(txtPositionName.Text);
                    if (count > 0)
                    {
                        MessageBox.Show(info.addVi,info.titleMessageVi, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(info.addFailedVi,info.titleMessageVi, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show(info.MessageCheckExistVi(txtPositionName.Text),info.titleMessageVi, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                LoadPosition();
            }
            else
            {
                if (string.IsNullOrEmpty(txtPositionName.Text.Trim()))
                {
                    MessageBox.Show(info.eventNullEn,info.titleMessageEn, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (PositionBUS.Instance.checkNameExist(txtPositionName.Text))
                {
                    int count = PositionBUS.Instance.AddPosition(txtPositionName.Text);
                    if (count > 0)
                    {
                        MessageBox.Show(info.addEn,info.titleMessageEn, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(info.addFailedEn,info.titleMessageEn, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show(info.MessageCheckExistEn(txtPositionName.Text),info.titleMessageEn, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                LoadPosition();
            }
        }

        public void LoadPosition()
        {
            dtgvListPosition.DataSource = PositionBUS.Instance.GetListPosition();

        }

        private void btnEditPosition_Click(object sender, EventArgs e)
        {
            if (Language == info.valueDefault)
            {
                if (string.IsNullOrEmpty(txtPositionName.Text.Trim()))
                {
                    MessageBox.Show(info.eventNullVi,info.titleMessageVi, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (PositionBUS.Instance.checkNameExist(txtPositionName.Text,txtPositionID.Text))
                {
                    int count = PositionBUS.Instance.UpdatePosition(int.Parse(txtPositionID.Text), txtPositionName.Text);
                    if (count > 0)
                    {
                        MessageBox.Show(info.editVi,info.titleMessageVi, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(info.editFailedVi,info.titleMessageVi, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show(info.MessageCheckExistVi(txtPositionName.Text),info.titleMessageVi, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                LoadPosition();
            }
            else
            {
                if (string.IsNullOrEmpty(txtPositionName.Text.Trim()))
                {
                    MessageBox.Show(info.eventNullEn,info.titleMessageEn, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (PositionBUS.Instance.checkNameExist(txtPositionName.Text, txtPositionID.Text))
                {
                    int count = PositionBUS.Instance.UpdatePosition(int.Parse(txtPositionID.Text), txtPositionName.Text);
                    if (count > 0)
                    {
                        MessageBox.Show(info.editEn,info.titleMessageEn, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(info.editFailedEn,info.titleMessageEn, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show(info.MessageCheckExistEn(txtPositionName.Text),info.titleMessageEn, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                LoadPosition();
            }
        }

        private void dtgvListPosition_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            info.firstIndex = info.valueDefault;
            if (dtgvListLocation.SelectedRows.Count > 0)
            {
                txtPositionID.Text = dtgvListPosition.SelectedRows[info.valueDefault].Cells[info.firstIndex].Value.ToString();
                txtPositionName.Text = dtgvListPosition.SelectedRows[info.valueDefault].Cells[info.firstIndex+=1].Value.ToString();
            }
        }

        private void btnDeletePosition_Click(object sender, EventArgs e)
        {
            if (Language == info.valueDefault)
            {
                if (DialogResult.Yes == MessageBox.Show(info.messageDeleteVi,info.titleMessageVi, MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                {
                    if (PositionBUS.Instance.checkExistDelete(txtPositionID.Text))
                    {
                        int count = PositionBUS.Instance.DeletePosition(int.Parse(txtPositionID.Text));
                        if (count > 0)
                        {
                            MessageBox.Show(info.deleteVi,info.titleMessageVi, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show(info.deleteFailedVi,info.titleMessageVi, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show(info.checkDelVi,info.titleMessageVi, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                LoadPosition();
            }
            else
            {
                if (DialogResult.Yes == MessageBox.Show(info.messageDeleteEn,info.titleMessageEn, MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                {
                    if (PositionBUS.Instance.checkExistDelete(txtPositionID.Text))
                    {
                        int count = PositionBUS.Instance.DeletePosition(int.Parse(txtPositionID.Text));
                        if (count > 0)
                        {
                            MessageBox.Show(info.deleteEn,info.titleMessageEn, MessageBoxButtons.OK, MessageBoxIcon.Information); ;
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
                LoadPosition();
            }
        }

        private void btnDeleteAllPosition_Click(object sender, EventArgs e)
        {
            if (Language == info.valueDefault)
            {
                if (DialogResult.Yes == MessageBox.Show(info.messageDeleteAllVi,info.titleMessageVi, MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                {
                    if (PositionBUS.Instance.checkExistDelete())
                    {
                        int count = PositionBUS.Instance.DeleteAllPosition();
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
                        MessageBox.Show(info.checkDelVi,info.titleMessageVi, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
                LoadPosition();
            }
            else
            {
                if (DialogResult.Yes == MessageBox.Show(info.messageDeleteAllEn,info.titleMessageEn, MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                {
                    if (PositionBUS.Instance.checkExistDelete())
                    {
                        int count = PositionBUS.Instance.DeleteAllPosition();
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
                        MessageBox.Show(info.checkDelEn,info.titleMessageEn, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void btnPositionDeleted_Click(object sender, EventArgs e)
        {
            frmRecycleBinCategory frm = new frmRecycleBinCategory();
            frm.Show();
        }

        #endregion

        #region TypeAccount
        private void btnTypeAccountDeleted_Click(object sender, EventArgs e)
        {
            frmRecycleBinCategory frm = new frmRecycleBinCategory();
            frm.Show();
        }

        public void LoadTypeAccount()
        {
            dtgvListTypeAccount.DataSource = TypeAccountBUS.Instance.GetListTypeAccount();

        }
        private void dtgvListTypeAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            info.firstIndex = info.valueDefault;
            if (dtgvListTypeAccount.SelectedRows.Count > 0)
            {
                txtTypeAccountID.Text = dtgvListTypeAccount.SelectedRows[info.valueDefault].Cells[info.firstIndex].Value.ToString();
                txtTypeAccountName.Text = dtgvListTypeAccount.SelectedRows[info.valueDefault].Cells[info.firstIndex+=1].Value.ToString();
            }
        }

        private void btnAddTypeAccount_Click(object sender, EventArgs e)
        {
            int i = TypeAccountBUS.Instance.GetListTypeAccount().Count + 1;
            txtTypeAccountID.Text = i.ToString();
            btnSaveTypeAccount.Enabled = true;
        }

        private void btnSaveTypeAccount_Click(object sender, EventArgs e)
        {
            if (Language == info.valueDefault)
            {
                if (string.IsNullOrEmpty(txtTypeAccountName.Text.Trim()))
                {
                    MessageBox.Show(info.eventNullVi,info.titleMessageVi, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (TypeAccountBUS.Instance.checkNameExist(txtTypeAccountName.Text))
                {

                    int count = TypeAccountBUS.Instance.AddTypeAccount(txtTypeAccountName.Text);
                    if (count > 0)
                    {
                        MessageBox.Show(info.addVi,info.titleMessageVi, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(info.addFailedVi,info.titleMessageVi, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show(info.MessageCheckExistVi(txtTypeAccountName.Text),info.titleMessageVi, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                LoadTypeAccount();
            }
            else
            {
                if (string.IsNullOrEmpty(txtTypeAccountName.Text.Trim()))
                {
                    MessageBox.Show(info.eventNullEn,info.titleMessageEn, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (TypeAccountBUS.Instance.checkNameExist(txtTypeAccountName.Text))
                {
                    int count = TypeAccountBUS.Instance.AddTypeAccount(txtTypeAccountName.Text);
                    if (count > 0)
                    {
                        MessageBox.Show(info.addEn,info.titleMessageEn, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(info.addFailedEn,info.titleMessageEn, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show(info.MessageCheckExistEn(txtTypeAccountName.Text),info.titleMessageEn, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                LoadTypeAccount();
            }
        }

        private void btnEditTypeAccount_Click(object sender, EventArgs e)
        {
            if (Language == info.valueDefault)
            {
                if (string.IsNullOrEmpty(txtTypeAccountName.Text.Trim()))
                {
                    MessageBox.Show(info.eventNullVi,info.titleMessageVi, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (TypeAccountBUS.Instance.checkNameExist(txtTypeAccountName.Text,txtTypeAccountID.Text))
                {
                    int count = TypeAccountBUS.Instance.UpdateTypeAccount(int.Parse(txtTypeAccountID.Text), txtTypeAccountName.Text);
                    if (count > 0)
                    {
                        MessageBox.Show(info.editVi,info.titleMessageVi, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(info.editFailedVi,info.titleMessageVi, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show(info.MessageCheckExistVi(txtTypeAccountName.Text),info.titleMessageVi, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                LoadTypeAccount();
            }
            else
            {

                if (string.IsNullOrEmpty(txtTypeAccountName.Text.Trim()))
                {
                    MessageBox.Show(info.eventNullEn,info.titleMessageEn, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (TypeAccountBUS.Instance.checkNameExist(txtTypeAccountName.Text, txtTypeAccountID.Text))
                {
                    int count = TypeAccountBUS.Instance.UpdateTypeAccount(int.Parse(txtTypeAccountID.Text), txtTypeAccountName.Text);
                    if (count > 0)
                    {
                        MessageBox.Show(info.editEn,info.titleMessageEn, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(info.editFailedEn,info.titleMessageEn, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show(info.MessageCheckExistEn(txtTypeAccountName.Text),info.titleMessageEn, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                LoadTypeAccount();
            }
        }

        private void btnDeleteTypeAccount_Click(object sender, EventArgs e)
        {
            if (Language == info.valueDefault)
            {

                if (DialogResult.Yes == MessageBox.Show(info.messageDeleteVi,info.titleMessageVi, MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                {
                    if (TypeAccountBUS.Instance.checkExistDelete(txtTypeAccountID.Text))
                    {
                        int count = TypeAccountBUS.Instance.DeleteTypeAccount(int.Parse(txtTypeAccountID.Text));
                        if (count > 0)
                        {
                            MessageBox.Show(info.deleteVi,info.titleMessageVi, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show(info.deleteFailedVi,info.titleMessageVi, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show(info.checkDelVi,info.titleMessageVi, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    LoadTypeAccount();
                }

            }
            else
            {
                if (DialogResult.Yes == MessageBox.Show(info.messageDeleteEn,info.titleMessageEn, MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                {
                    if (TypeAccountBUS.Instance.checkExistDelete(txtTypeAccountID.Text))
                    {
                        int count = TypeAccountBUS.Instance.DeleteTypeAccount(int.Parse(txtTypeAccountID.Text));
                        if (count > 0)
                        {
                            MessageBox.Show(info.deleteEn,info.titleMessageEn, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show(info.deleteAllFailedEn,info.titleMessageEn, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show(info.checkDelEn,info.titleMessageEn, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                LoadTypeAccount();
            }
        }

        private void btnDeleteAllTypeAccount_Click(object sender, EventArgs e)
        {
            if (Language == info.valueDefault)
            {
                if (DialogResult.Yes == MessageBox.Show(info.messageDeleteAllVi,info.titleMessageVi, MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                {
                    if (TypeAccountBUS.Instance.checkExistDelete())
                    {
                        int count = TypeAccountBUS.Instance.DeleteAllTypeAccount();
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
                        MessageBox.Show(info.checkDelVi,info.titleMessageVi, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                LoadTypeAccount();
            }
            else
            {
                if (DialogResult.Yes == MessageBox.Show(info.messageDeleteAllEn,info.titleMessageEn, MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                {
                    if (TypeAccountBUS.Instance.checkExistDelete())
                    {
                        int count = TypeAccountBUS.Instance.DeleteAllTypeAccount();
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
                        MessageBox.Show(info.checkDelEn,info.titleMessageEn, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                LoadTypeAccount();
            }
        }
        #endregion
        
        #region Discount

        public void LoadListDiscount()
        {
            dtgvListDiscount.DataSource = DiscountBUS.Instance.GetListDiscount();
            ResetDiscountInfo();

        }

        public void ResetDiscountInfo()
        {
            txtDiscountID.Clear();
            txtDiscountName.Clear();
            txtDiscountPrice.Clear();
            txtLimitDiscount.Clear();
            dtpDateStart.Value = DateTime.Now;
            dtpDateEnd.Value = DateTime.Now;
            cbAvailableDiscount.SelectedIndex = info.valueDefault;
            btnSaveDiscount.Enabled = false;
            btnEditDiscount.Enabled = true;
            btnDeleteDiscount.Enabled = true;
            btnDeleteAllDiscount.Enabled = true;
        }

        private void btnAddDiscount_Click(object sender, EventArgs e)
        {
            ResetDiscountInfo();
            btnSaveDiscount.Enabled = true;
            btnEditDiscount.Enabled = false;
            btnDeleteDiscount.Enabled = false;
            btnDeleteAllDiscount.Enabled = false;

        }

        private void dtgvListDiscount_SelectionChanged(object sender, EventArgs e)
        {
            info.firstIndex = info.valueDefault;
            if (dtgvListDiscount.SelectedRows.Count > info.valueDefault)
            {
                txtDiscountID.Text = dtgvListDiscount.SelectedRows[info.valueDefault].Cells[info.firstIndex].Value.ToString();
                txtDiscountName.Text = dtgvListDiscount.SelectedRows[info.valueDefault].Cells[info.firstIndex+=1].Value.ToString();
                txtDiscountPrice.Text = dtgvListDiscount.SelectedRows[info.valueDefault].Cells[info.firstIndex += 1].Value.ToString();
                dtpDateStart.Text = dtgvListDiscount.SelectedRows[info.valueDefault].Cells[info.firstIndex += 1].Value.ToString();
                dtpDateEnd.Text = dtgvListDiscount.SelectedRows[info.valueDefault].Cells[info.firstIndex += 1].Value.ToString();
                bool available = bool.Parse(dtgvListDiscount.SelectedRows[info.valueDefault].Cells[info.firstIndex += 1].Value.ToString());
                cbAvailableDiscount.SelectedIndex = available == true ? info.valueDefault : info.count;
                txtLimitDiscount.Text = dtgvListDiscount.SelectedRows[info.valueDefault].Cells[info.firstIndex += 1].Value.ToString();

                btnSaveDiscount.Enabled = false;
                btnEditDiscount.Enabled = true;
                btnDeleteDiscount.Enabled = true;
                btnDeleteAllDiscount.Enabled = true;
            }
        }

        private void btnSaveDiscount_Click(object sender, EventArgs e)
        {
            if (Language == info.valueDefault)
            {
                if (string.IsNullOrEmpty(txtDiscountName.Text.Trim()) || string.IsNullOrEmpty(txtDiscountPrice.Text.Trim()))
                {
                    MessageBox.Show(info.eventNullVi,info.titleMessageVi, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string discountName = txtDiscountName.Text;
                float discountPrice = float.Parse(txtDiscountPrice.Text);
                string startDay = dtpDateStart.Value.ToString("yyyy/MM/dd");
                string endDay = dtpDateEnd.Value.ToString("yyyy/MM/dd");
                float limitDiscount = txtLimitDiscount.Text == null ? info.valueDefault : float.Parse(txtLimitDiscount.Text);
                if (DiscountBUS.Instance.checkNameExist(txtDiscountName.Text))
                {
                    int count = DiscountBUS.Instance.AddNewDiscount(discountName, startDay, endDay, discountPrice, limitDiscount);
                    if (count > 0)
                    {
                        MessageBox.Show(info.addVi,info.titleMessageVi, MessageBoxButtons.OK,MessageBoxIcon.Information);
                        LoadListDiscount();
                    }
                    else
                        MessageBox.Show(info.addFailedVi,info.titleMessageVi, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show(info.MessageCheckExistVi(txtDiscountName.Text),info.titleMessageVi, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                if (string.IsNullOrEmpty(txtDiscountName.Text.Trim()) || string.IsNullOrEmpty(txtDiscountPrice.Text.Trim()))
                {
                    MessageBox.Show(info.eventNullEn,info.titleMessageEn, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string discountName = txtDiscountName.Text;
                float discountPrice = float.Parse(txtDiscountPrice.Text);
                string startDay = dtpDateStart.Value.ToString("yyyy/MM/dd");
                string endDay = dtpDateEnd.Value.ToString("yyyy/MM/dd");
                float limitDiscount = txtLimitDiscount.Text == null ? info.valueDefault : float.Parse(txtLimitDiscount.Text);
                if (DiscountBUS.Instance.checkNameExist(txtDiscountName.Text))
                {
                    int count = DiscountBUS.Instance.AddNewDiscount(discountName, startDay, endDay, discountPrice, limitDiscount);
                    if (count > 0)
                    {
                        MessageBox.Show(info.addEn,info.titleMessageEn, MessageBoxButtons.OK);
                        LoadListDiscount();
                    }
                    else
                        MessageBox.Show(info.addFailedEn,info.titleMessageEn, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show(info.MessageCheckExistEn(txtDiscountName.Text),info.titleMessageEn, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnEditDiscount_Click(object sender, EventArgs e)
        {
            if (Language == info.valueDefault)
            {
                if (MessageBox.Show(info.messageEditVi, info.titleMessageVi, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (string.IsNullOrEmpty(txtDiscountName.Text) || string.IsNullOrEmpty(txtDiscountPrice.Text))
                    {
                        MessageBox.Show(info.eventNullVi, info.titleMessageVi, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                  
                    string discountID = txtDiscountID.Text;
                    string discountName = txtDiscountName.Text;
                    float discountPrice = float.Parse(txtDiscountPrice.Text);
                    string startDay = dtpDateStart.Value.ToString("yyyy/MM/dd");
                    string endDay = dtpDateEnd.Value.ToString("yyyy/MM/dd");
                    int available = cbAvailableDiscount.SelectedIndex == info.valueDefault ? info.count : info.valueDefault;
                    float limitDiscount = float.Parse(txtLimitDiscount.Text);

                    if (DiscountBUS.Instance.CheckNameExistToEdit(txtDiscountName.Text,txtDiscountID.Text))
                    {
                        int count = DiscountBUS.Instance.EditDiscount(discountID, discountName, startDay, endDay, discountPrice, available, limitDiscount);
                        if (count > 0)
                        {
                            MessageBox.Show(info.editVi, info.titleMessageVi, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadListDiscount();
                        }
                        else
                            MessageBox.Show(info.editFailedVi, info.titleMessageVi, MessageBoxButtons.OK, MessageBoxIcon.Warning);                       
                }
            }
            else
                MessageBox.Show(info.MessageCheckExistVi(txtDiscountName.Text), info.titleMessageVi, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (MessageBox.Show(info.messageEditEn,info.titleMessageEn, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (string.IsNullOrEmpty(txtDiscountName.Text) || string.IsNullOrEmpty(txtDiscountPrice.Text))
                    {
                        MessageBox.Show(info.eventNullEn,info.titleMessageEn, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }                   
                        string discountID = txtDiscountID.Text;
                    string discountName = txtDiscountName.Text;
                    float discountPrice = float.Parse(txtDiscountPrice.Text);
                    string startDay = dtpDateStart.Value.ToString("yyyy/MM/dd");
                    string endDay = dtpDateEnd.Value.ToString("yyyy/MM/dd");
                    int available = cbAvailableDiscount.SelectedIndex == info.valueDefault ? info.count : info.valueDefault;
                    float limitDiscount = float.Parse(txtLimitDiscount.Text);

                    if (DiscountBUS.Instance.CheckNameExistToEdit(txtDiscountName.Text, txtDiscountID.Text))
                    {
                        int count = DiscountBUS.Instance.EditDiscount(discountID, discountName, startDay, endDay, discountPrice, available, limitDiscount);
                        if (count > 0)
                        {
                            MessageBox.Show(info.editEn,info.titleMessageEn, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadListDiscount();
                        }
                        else
                            MessageBox.Show(info.editFailedEn,info.titleMessageEn, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                        MessageBox.Show(info.MessageCheckExistEn(txtDiscountName.Text),info.titleMessageEn, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }

        private void btnDeleteDiscount_Click(object sender, EventArgs e)
        {
            if (Language == info.valueDefault)
            {
                if (MessageBox.Show(info.messageDeleteVi,info.titleMessageVi, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {

                    string discountID = txtDiscountID.Text;

                    int count = DiscountBUS.Instance.DeleteDiscount(discountID);
                    if (count > 0)
                    {
                        MessageBox.Show(info.deleteVi,info.titleMessageVi, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadListDiscount();
                    }
                    else
                        MessageBox.Show(info.deleteFailedVi,info.titleMessageVi, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                if (MessageBox.Show(info.messageDeleteEn,info.titleMessageEn, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {

                    string discountID = txtDiscountID.Text;

                    int count = DiscountBUS.Instance.DeleteDiscount(discountID);
                    if (count > 0)
                    {
                        MessageBox.Show(info.deleteEn,info.titleMessageEn, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadListDiscount();
                    }
                    else
                        MessageBox.Show(info.deleteFailedEn,info.titleMessageEn, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnDeleteAllDiscount_Click(object sender, EventArgs e)
        {
            if (Language == info.valueDefault)
            {
                if (MessageBox.Show(info.messageDeleteAllVi,info.titleMessageVi, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {

                    int count = DiscountBUS.Instance.DeleteAllDiscount();
                    if (count > 0)
                    {
                        MessageBox.Show(info.deleteAllVi,info.titleMessageVi, MessageBoxButtons.OK);
                        LoadListDiscount();
                    }
                    else
                        MessageBox.Show(info.deleteAllFailedVi,info.titleMessageVi, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                if (MessageBox.Show(info.messageDeleteAllEn,info.titleMessageEn, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {

                    int count = DiscountBUS.Instance.DeleteAllDiscount();
                    if (count > 0)
                    {
                        MessageBox.Show(info.deleteAllEn,info.titleMessageEn, MessageBoxButtons.OK);
                        LoadListDiscount();
                    }
                    else
                        MessageBox.Show(info.deleteAllFailedEn,info.titleMessageEn, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnDiscountDeleted_Click(object sender, EventArgs e)
        {
            frmRecycleBinCategory frm = new frmRecycleBinCategory();
            frm.Show();
        }


        #endregion
       
    }
}
