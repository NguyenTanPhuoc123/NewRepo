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
                    if (LocationBUS.Instance.CheckNameExist(txtLocationName.Text) == true)
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
                    if (LocationBUS.Instance.CheckNameExist(txtLocationName.Text) == true)
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
            if (i == -1) return;
            txtTypeProductID.Text = dtgvListTypeProduct.Rows[i].Cells[0].Value.ToString();
            txtTypeProductName.Text = dtgvListTypeProduct.Rows[i].Cells[1].Value.ToString();
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
            if (Language == 0)
            {
                if (string.IsNullOrEmpty(txtTypeProductName.Text.Trim()))
                {
                    MessageBox.Show("Bạn chưa nhập tên loại sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (CategoryFoodBUS.Instance.checkNameExist(txtTypeProductName.Text))
                {
                    int count = CategoryFoodBUS.Instance.AddCategoryFood(txtTypeProductName.Text);
                    if (count > 0)
                    {
                        MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        reset();
                    }
                    else
                        MessageBox.Show("Thêm thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Tên loại sản phẩm đã có", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                LoadTypeProduct();
            }
            else
            {
                if (string.IsNullOrEmpty(txtTypeProductName.Text.Trim()))
                {
                    MessageBox.Show("You have not entered the product type name", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (CategoryFoodBUS.Instance.checkNameExist(txtTypeProductName.Text))
                {
                    int count = CategoryFoodBUS.Instance.AddCategoryFood(txtTypeProductName.Text);
                    if (count > 0)
                    {
                        MessageBox.Show("More success", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        reset();
                    }
                    else
                        MessageBox.Show("TMore failure", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Product type name already available", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                LoadTypeProduct();
            }
        }

        private void btnEditTypeProduct_Click(object sender, EventArgs e)
        {
            if (Language == 0)
            {
                if (string.IsNullOrEmpty(txtTypeProductID.Text.Trim()))
                {
                    MessageBox.Show("Bạn chưa chọn loại sản phẩm để sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (DialogResult.Yes == MessageBox.Show("Bạn có muốn sửa loại sản phẩm", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {

                    if (string.IsNullOrEmpty(txtTypeProductID.Text.Trim()))
                    {
                        MessageBox.Show("Vui lòng nhập tên loại muốn sửa vào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (CategoryFoodBUS.Instance.checkNameExist(txtTypeProductName.Text))
                    {
                        int count = CategoryFoodBUS.Instance.UpdateCategoryFood(txtTypeProductID.Text, txtTypeProductName.Text);
                        if (count > 0)
                        {
                            MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            reset();
                        }
                        else
                            MessageBox.Show("Sửa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                        MessageBox.Show("Tên loại sản phẩm đã có", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    LoadTypeProduct();
                }
            }
            else
            {

                if (string.IsNullOrEmpty(txtTypeProductID.Text))
                {
                    MessageBox.Show("You have not selected a product type to repair", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (DialogResult.Yes == MessageBox.Show("Do you want to edit the product type", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    if (string.IsNullOrEmpty(txtTypeProductID.Text.Trim()))
                    {
                        MessageBox.Show("Please enter the name of the type you want to edit!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (CategoryFoodBUS.Instance.checkNameExist(txtTypeProductName.Text))
                    {
                        int count = CategoryFoodBUS.Instance.UpdateCategoryFood(txtTypeProductID.Text, txtTypeProductName.Text);
                        if (count > 0)
                        {
                            MessageBox.Show("Successful fix", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            reset();
                        }
                        else
                            MessageBox.Show("Fix failure", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                        MessageBox.Show("Product type name already available", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);

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
                    MessageBox.Show("Bạn chưa chọn loại sản phẩm để xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (DialogResult.Yes == MessageBox.Show("Bạn có muốn xóa loại sản phẩm", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    if (CategoryFoodBUS.Instance.checkExistDelete(txtTypeProductID.Text))
                    {
                        int count = CategoryFoodBUS.Instance.DeleteCategoryFood(txtTypeProductID.Text);
                        if (count > 0)
                        {
                            MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK);
                            reset();
                        }
                        else
                            MessageBox.Show("Xóa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                        MessageBox.Show("Xóa thất bại loại sản phẩm đã có trong sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    LoadTypeProduct();
                }
            }
            else
            {
                if (string.IsNullOrEmpty(txtTypeProductID.Text))
                {
                    MessageBox.Show("You have not selected a product type to delete", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (DialogResult.Yes == MessageBox.Show("Do you want to delete the product type", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    if (CategoryFoodBUS.Instance.checkExistDelete(txtTypeProductID.Text))
                    {
                        int count = CategoryFoodBUS.Instance.DeleteCategoryFood(txtTypeProductID.Text);
                        if (count > 0)
                        {
                            MessageBox.Show("Delete successfully", "Notification", MessageBoxButtons.OK);
                            reset();
                        }
                        else
                            MessageBox.Show("Delete failed", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                        MessageBox.Show("Failed to delete product type already in product", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    LoadTypeProduct();
                }
            }
        }
        private void btnDeleteAllTypeProduct_Click(object sender, EventArgs e)
        {
            if (Language == 0)
            {
                if (DialogResult.Yes == MessageBox.Show("Bạn có muốn xóa tất cả loại sản phẩm", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    if (CategoryFoodBUS.Instance.checkExistDelete(txtTypeProductID.Text))
                    {
                        int count = CategoryFoodBUS.Instance.DeleteAllCategoryFood();
                        if (count > 0)
                        {
                            MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            reset();
                        }
                        else
                            MessageBox.Show("Xóa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                        MessageBox.Show("Xóa thất bại loại sản phẩm đã có trong sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    LoadTypeProduct();
                }
            }
            else
            {
                if (DialogResult.Yes == MessageBox.Show("Do you want to delete all product categories?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    if (CategoryFoodBUS.Instance.checkExistDelete(txtTypeProductID.Text))
                    {
                        int count = CategoryFoodBUS.Instance.DeleteAllCategoryFood();
                        if (count > 0)
                        {
                            MessageBox.Show("Delete successfully", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            reset();
                        }
                        else
                            MessageBox.Show("Delete failed", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                        MessageBox.Show("Failed to delete product type already in product", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            if (Language == 0)
            {
                if (string.IsNullOrEmpty(txtPositionName.Text.Trim()))
                {
                    MessageBox.Show("Vui lòng nhập tên chức vụ muốn thêm vào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (PositionBUS.Instance.checkNameExist(txtPositionName.Text))
                {
                    int count = PositionBUS.Instance.AddPosition(txtPositionName.Text);
                    if (count > 0)
                    {
                        MessageBox.Show("Thêm chức vụ thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Thêm chức vụ thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Tên chức vụ đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                LoadPosition();
            }
            else
            {
                if (string.IsNullOrEmpty(txtPositionName.Text.Trim()))
                {
                    MessageBox.Show("Please enter the name of the position you want to add!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (PositionBUS.Instance.checkNameExist(txtPositionName.Text))
                {
                    int count = PositionBUS.Instance.AddPosition(txtPositionName.Text);
                    if (count > 0)
                    {
                        MessageBox.Show("More successful positions", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("More failed positions", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Job title already exists", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            if (Language == 0)
            {
                if (string.IsNullOrEmpty(txtPositionName.Text.Trim()))
                {
                    MessageBox.Show("Vui lòng nhập tên chức vụ muốn sửa vào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (PositionBUS.Instance.checkNameExist(txtPositionName.Text))
                {
                    int count = PositionBUS.Instance.UpdatePosition(int.Parse(txtPositionID.Text), txtPositionName.Text);
                    if (count > 0)
                    {
                        MessageBox.Show("Sửa chức vụ thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Sửa chức vụ thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Tên chức vụ đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                LoadPosition();
            }
            else
            {
                if (string.IsNullOrEmpty(txtPositionName.Text.Trim()))
                {
                    MessageBox.Show("Please enter the name of the position you want to edit!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (PositionBUS.Instance.checkNameExist(txtPositionName.Text))
                {
                    int count = PositionBUS.Instance.UpdatePosition(int.Parse(txtPositionID.Text), txtPositionName.Text);
                    if (count > 0)
                    {
                        MessageBox.Show("Editing the position successfully", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Fix failed position", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Job title already exists", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                LoadPosition();
            }
        }

        private void dtgvListPosition_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgvListLocation.SelectedRows.Count > 0)
            {
                txtPositionID.Text = dtgvListPosition.SelectedRows[0].Cells[0].Value.ToString();
                txtPositionName.Text = dtgvListPosition.SelectedRows[0].Cells[1].Value.ToString();
            }
        }

        private void btnDeletePosition_Click(object sender, EventArgs e)
        {
            if (Language == 0)
            {
                if (DialogResult.Yes == MessageBox.Show("Bạn chắc chắn muốn xóa chức vụ này", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                {
                    if (PositionBUS.Instance.checkExistDelete(txtPositionID.Text))
                    {
                        int count = PositionBUS.Instance.DeletePosition(int.Parse(txtPositionID.Text));
                        if (count > 0)
                        {
                            MessageBox.Show("Xóa chức vụ thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Xóa chức vụ thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Chức vụ tồn tại trong nhân viên không thể xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                LoadPosition();
            }
            else
            {
                if (DialogResult.Yes == MessageBox.Show("You definitely want to delete this position", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                {
                    if (PositionBUS.Instance.checkExistDelete(txtPositionID.Text))
                    {
                        int count = PositionBUS.Instance.DeletePosition(int.Parse(txtPositionID.Text));
                        if (count > 0)
                        {
                            MessageBox.Show("Delete position successfully", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Delete position successfully", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("The position that exists in the employee cannot be deleted", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                LoadPosition();
            }
        }

        private void btnDeleteAllPosition_Click(object sender, EventArgs e)
        {
            if (Language == 0)
            {
                if (DialogResult.Yes == MessageBox.Show("Bạn chắc chắn muốn xóa tất cả chức vụ này", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                {
                    if (PositionBUS.Instance.checkExistDelete(txtPositionID.Text))
                    {
                        int count = PositionBUS.Instance.DeleteAllPosition();
                        if (count > 0)
                        {
                            MessageBox.Show("Xóa tất cả chức vụ thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Xóa tất cả chức vụ thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Chức vụ tồn tại trong nhân viên không thể xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
                LoadPosition();
            }
            else
            {
                if (DialogResult.Yes == MessageBox.Show("You definitely want to delete all these positions", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                {
                    if (PositionBUS.Instance.checkExistDelete(txtPositionID.Text))
                    {
                        int count = PositionBUS.Instance.DeleteAllPosition();
                        if (count > 0)
                        {
                            MessageBox.Show("Delete all positions successfully", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Delete all failed positions", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("The position that exists in the employee cannot be deleted", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        #endregion

        #region TypeAccount
        public void LoadTypeAccount()
        {
            dtgvListTypeAccount.DataSource = TypeAccountBUS.Instance.GetListTypeAccount();

        }
        private void dtgvListTypeAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgvListTypeAccount.SelectedRows.Count > 0)
            {
                txtTypeAccountID.Text = dtgvListTypeAccount.SelectedRows[0].Cells[0].Value.ToString();
                txtTypeAccountName.Text = dtgvListTypeAccount.SelectedRows[0].Cells[1].Value.ToString();
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
            if (Language == 0)
            {
                if (string.IsNullOrEmpty(txtTypeAccountName.Text.Trim()))
                {
                    MessageBox.Show("Vui lòng nhập tên loại tài khoản muốn thêm vào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (TypeAccountBUS.Instance.checkNameExist(txtTypeAccountName.Text))
                {

                    int count = TypeAccountBUS.Instance.AddTypeAccount(txtTypeAccountName.Text);
                    if (count > 0)
                    {
                        MessageBox.Show("Thêm loại tài khoản thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Thêm loại tài khoản thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Tên loại tài khoản đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                LoadTypeAccount();
            }
            else
            {
                if (string.IsNullOrEmpty(txtTypeAccountName.Text.Trim()))
                {
                    MessageBox.Show("Please enter the name of the account type you want to add!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (TypeAccountBUS.Instance.checkNameExist(txtTypeAccountName.Text))
                {
                    int count = TypeAccountBUS.Instance.AddTypeAccount(txtTypeAccountName.Text);
                    if (count > 0)
                    {
                        MessageBox.Show("Successfully added account type", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Add failed account type", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Name type account already exists", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                LoadTypeAccount();
            }
        }

        private void btnEditTypeAccount_Click(object sender, EventArgs e)
        {
            if (Language == 0)
            {
                if (string.IsNullOrEmpty(txtTypeAccountName.Text.Trim()))
                {
                    MessageBox.Show("Vui lòng nhập tên loại tài khoản muốn sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (TypeAccountBUS.Instance.checkNameExist(txtTypeAccountName.Text))
                {
                    int count = TypeAccountBUS.Instance.UpdateTypeAccount(int.Parse(txtTypeAccountID.Text), txtTypeAccountName.Text);
                    if (count > 0)
                    {
                        MessageBox.Show("Sửa loại tài khoản thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Sửa loại tài khoản thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Tên loại tài khoản đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                LoadTypeAccount();
            }
            else
            {

                if (string.IsNullOrEmpty(txtTypeAccountName.Text.Trim()))
                {
                    MessageBox.Show("Please enter the name of the account type you want to edit!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (TypeAccountBUS.Instance.checkNameExist(txtTypeAccountName.Text))
                {
                    int count = TypeAccountBUS.Instance.UpdateTypeAccount(int.Parse(txtTypeAccountID.Text), txtTypeAccountName.Text);
                    if (count > 0)
                    {
                        MessageBox.Show("Account Type Correction Successful", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Fix failed account type", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Name type account already exists", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                LoadTypeAccount();
            }
        }

        private void btnDeleteTypeAccount_Click(object sender, EventArgs e)
        {
            if (Language == 0)
            {

                if (DialogResult.Yes == MessageBox.Show("Bạn chắc chắn muốn xóa loại tài khoản này", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                {
                    if (TypeAccountBUS.Instance.checkExistDelete(txtTypeAccountID.Text))
                    {
                        int count = TypeAccountBUS.Instance.DeleteTypeAccount(int.Parse(txtTypeAccountID.Text));
                        if (count > 0)
                        {
                            MessageBox.Show("Xóa loại tài khoản thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Xóa loại tài khoản thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Xóa loại tài khoản thất bại loại tài khoản đã tồn tại trong tài khoản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    LoadTypeAccount();
                }

            }
            else
            {
                if (DialogResult.Yes == MessageBox.Show("You definitely want to delete this account type", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                {
                    if (TypeAccountBUS.Instance.checkExistDelete(txtTypeAccountID.Text))
                    {
                        int count = TypeAccountBUS.Instance.DeleteTypeAccount(int.Parse(txtTypeAccountID.Text));
                        if (count > 0)
                        {
                            MessageBox.Show("Delete Account Type Successfully", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Delete account type failed", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Deleting the account type failed the account type already exists in the account", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                LoadTypeAccount();
            }
        }

        private void btnDeleteAllTypeAccount_Click(object sender, EventArgs e)
        {
            if (Language == 0)
            {
                if (DialogResult.Yes == MessageBox.Show("Bạn chắc chắn muốn xóa tất cả loại tài khoản này", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                {
                    if (TypeAccountBUS.Instance.checkExistDelete(txtTypeAccountID.Text))
                    {
                        int count = TypeAccountBUS.Instance.DeleteAllTypeAccount();
                        if (count > 0)
                        {
                            MessageBox.Show("Xóa tất cả loại tài khoản thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Xóa tất cả loại tài khoản thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Xóa loại tài khoản thất bại loại tài khoản đã tồn tại trong tài khoản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                LoadTypeAccount();
            }
            else
            {
                if (DialogResult.Yes == MessageBox.Show("You definitely want to delete all these types of accounts", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                {
                    if (TypeAccountBUS.Instance.checkExistDelete(txtTypeAccountID.Text))
                    {
                        int count = TypeAccountBUS.Instance.DeleteAllTypeAccount();
                        if (count > 0)
                        {
                            MessageBox.Show("Delete all account types successfully", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {

                            MessageBox.Show("Delete all account types failed", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Deleting the account type failed the account type already exists in the account", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                LoadTypeAccount();
            }
        }
        #endregion

        private void btnPositionDeleted_Click(object sender, EventArgs e)
        {
            frmRecycleBinCategory frm = new frmRecycleBinCategory();
            frm.Show();
        }

        private void btnTypeAccountDeleted_Click(object sender, EventArgs e)
        {
            frmRecycleBinCategory frm = new frmRecycleBinCategory();
            frm.Show();
        }

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
            cbAvailableDiscount.SelectedIndex = 0;
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
            if (dtgvListDiscount.SelectedRows.Count > 0)
            {
                txtDiscountID.Text = dtgvListDiscount.SelectedRows[0].Cells[0].Value.ToString();
                txtDiscountName.Text = dtgvListDiscount.SelectedRows[0].Cells[1].Value.ToString();
                txtDiscountPrice.Text = dtgvListDiscount.SelectedRows[0].Cells[2].Value.ToString();
                dtpDateStart.Text = dtgvListDiscount.SelectedRows[0].Cells[3].Value.ToString();
                dtpDateEnd.Text = dtgvListDiscount.SelectedRows[0].Cells[4].Value.ToString();
                bool available = bool.Parse(dtgvListDiscount.SelectedRows[0].Cells[5].Value.ToString());
                cbAvailableDiscount.SelectedIndex = available == true ? 0 : 1;
                txtLimitDiscount.Text = dtgvListDiscount.SelectedRows[0].Cells[6].Value.ToString();

                btnSaveDiscount.Enabled = false;
                btnEditDiscount.Enabled = true;
                btnDeleteDiscount.Enabled = true;
                btnDeleteAllDiscount.Enabled = true;
            }
        }

        private void btnSaveDiscount_Click(object sender, EventArgs e)
        {
            if (Language == 0)
            {
                if (string.IsNullOrEmpty(txtDiscountName.Text.Trim()) || string.IsNullOrEmpty(txtDiscountPrice.Text.Trim()))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin giảm giá", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string discountName = txtDiscountName.Text;
                float discountPrice = float.Parse(txtDiscountPrice.Text);
                string startDay = dtpDateStart.Value.ToString("yyyy/MM/dd");
                string endDay = dtpDateEnd.Value.ToString("yyyy/MM/dd");
                float limitDiscount = txtLimitDiscount.Text == null ? 0 : float.Parse(txtLimitDiscount.Text);
                if (DiscountBUS.Instance.checkNameExist(txtDiscountName.Text))
                {
                    int count = DiscountBUS.Instance.AddNewDiscount(discountName, startDay, endDay, discountPrice, limitDiscount);
                    if (count > 0)
                    {
                        MessageBox.Show("Thêm giảm giá mới thành công", "Thêm giảm giá", MessageBoxButtons.OK);
                        LoadListDiscount();
                    }
                    else
                        MessageBox.Show("Thêm giảm giá mới thất bại", "Thêm giảm giá", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Tên giảm giá đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                if (string.IsNullOrEmpty(txtDiscountName.Text.Trim()) || string.IsNullOrEmpty(txtDiscountPrice.Text.Trim()))
                {
                    MessageBox.Show("Please fill out the discount information", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string discountName = txtDiscountName.Text;
                float discountPrice = float.Parse(txtDiscountPrice.Text);
                string startDay = dtpDateStart.Value.ToString("yyyy/MM/dd");
                string endDay = dtpDateEnd.Value.ToString("yyyy/MM/dd");
                float limitDiscount = txtLimitDiscount.Text == null ? 0 : float.Parse(txtLimitDiscount.Text);
                if (DiscountBUS.Instance.checkNameExist(txtDiscountName.Text))
                {
                    int count = DiscountBUS.Instance.AddNewDiscount(discountName, startDay, endDay, discountPrice, limitDiscount);
                    if (count > 0)
                    {
                        MessageBox.Show("Add new discount successfully", "Notification", MessageBoxButtons.OK);
                        LoadListDiscount();
                    }
                    else
                        MessageBox.Show("Add new discount failed", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Discount name already exists", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnEditDiscount_Click(object sender, EventArgs e)
        {
            if (Language == 0)
            {
                if (MessageBox.Show("Bạn chắc chắn muốn thay đổi thông tin này ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (string.IsNullOrEmpty(txtDiscountName.Text) || string.IsNullOrEmpty(txtDiscountPrice.Text))
                    {
                        MessageBox.Show("Vui lòng điền đầy đủ thông tin giảm giá", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    string discountID = txtDiscountID.Text;
                    string discountName = txtDiscountName.Text;
                    float discountPrice = float.Parse(txtDiscountPrice.Text);
                    string startDay = dtpDateStart.Value.ToString("yyyy/MM/dd");
                    string endDay = dtpDateEnd.Value.ToString("yyyy/MM/dd");
                    int available = cbAvailableDiscount.SelectedIndex == 0 ? 1 : 0;
                    float limitDiscount = float.Parse(txtLimitDiscount.Text);

                    if (DiscountBUS.Instance.checkNameExist(txtDiscountName.Text))
                    {
                        int count = DiscountBUS.Instance.EditDiscount(discountID, discountName, startDay, endDay, discountPrice, available, limitDiscount);
                        if (count > 0)
                        {
                            MessageBox.Show("Sửa giảm giá thành công", "Sửa giảm giá", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadListDiscount();
                        }
                        else
                            MessageBox.Show("Sửa giảm giá thất bại", "Sửa giảm giá", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                        MessageBox.Show("Tên giảm giá đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                if (MessageBox.Show("You definitely want to change this information ?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (string.IsNullOrEmpty(txtDiscountName.Text) || string.IsNullOrEmpty(txtDiscountPrice.Text))
                    {
                        MessageBox.Show("Please fill in the discount information completely", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    string discountID = txtDiscountID.Text;
                    string discountName = txtDiscountName.Text;
                    float discountPrice = float.Parse(txtDiscountPrice.Text);
                    string startDay = dtpDateStart.Value.ToString("yyyy/MM/dd");
                    string endDay = dtpDateEnd.Value.ToString("yyyy/MM/dd");
                    int available = cbAvailableDiscount.SelectedIndex == 0 ? 1 : 0;
                    float limitDiscount = float.Parse(txtLimitDiscount.Text);

                    if (DiscountBUS.Instance.checkNameExist(txtDiscountName.Text))
                    {
                        int count = DiscountBUS.Instance.EditDiscount(discountID, discountName, startDay, endDay, discountPrice, available, limitDiscount);
                        if (count > 0)
                        {
                            MessageBox.Show("Successful discount correction", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadListDiscount();
                        }
                        else
                            MessageBox.Show("Failed to fix discount", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                        MessageBox.Show("Discount name already exists", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }

        private void btnDeleteDiscount_Click(object sender, EventArgs e)
        {
            if (Language == 0)
            {
                if (MessageBox.Show("Bạn chắc chắn muốn xóa giảm giá này ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {

                    string discountID = txtDiscountID.Text;

                    int count = DiscountBUS.Instance.DeleteDiscount(discountID);
                    if (count > 0)
                    {
                        MessageBox.Show("Xóa giảm giá thành công", "Xóa giảm giá", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadListDiscount();
                    }
                    else
                        MessageBox.Show("Xóa giảm giá thất bại", "Xóa giảm giá", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                if (MessageBox.Show("You definitely want to remove this discount?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {

                    string discountID = txtDiscountID.Text;

                    int count = DiscountBUS.Instance.DeleteDiscount(discountID);
                    if (count > 0)
                    {
                        MessageBox.Show("Delete discount successfully", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadListDiscount();
                    }
                    else
                        MessageBox.Show("Delete discount successfully", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnDeleteAllDiscount_Click(object sender, EventArgs e)
        {
            if (Language == 0)
            {
                if (MessageBox.Show("Bạn chắc chắn muốn xóa tất cả giảm giá này ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {

                    int count = DiscountBUS.Instance.DeleteAllDiscount();
                    if (count > 0)
                    {
                        MessageBox.Show("Xóa tất cả giảm giá thành công", "Xóa giảm giá", MessageBoxButtons.OK);
                        LoadListDiscount();
                    }
                    else
                        MessageBox.Show("Xóa tất cả giảm giá thất bại", "Xóa giảm giá", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                if (MessageBox.Show("You definitely want to delete all these discounts?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {

                    int count = DiscountBUS.Instance.DeleteAllDiscount();
                    if (count > 0)
                    {
                        MessageBox.Show("Delete all successful discounts", "Notification", MessageBoxButtons.OK);
                        LoadListDiscount();
                    }
                    else
                        MessageBox.Show("Delete all failed discounts", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnDiscountDeleted_Click(object sender, EventArgs e)
        {
            frmRecycleBinCategory frm = new frmRecycleBinCategory();
            frm.Show();
        }


        #endregion

        private void btnTypeProductDeleted_Click(object sender, EventArgs e)
        {
            frmRecycleBin frm = new frmRecycleBin();
            frm.Show();
        }

    }
}
