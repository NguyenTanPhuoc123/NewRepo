using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace frmLogin
{
    public partial class frmProductManagement : Form
    {
        private string fileAddress;
        private byte[] img;
        private int Language = frmlogin.Language;
        HashCode info = new HashCode();
        public frmProductManagement()
        {
            InitializeComponent();
            if (Language == info.valueDefault)
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("vi");
            else
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en");
            dtgvListProduct.AutoGenerateColumns = false;
            cbFillProduct.SelectedIndex = info.valueDefault;

        }

        private void btnProductDeleted_Click(object sender, EventArgs e)
        {
            frmRecycleBin frm = new frmRecycleBin();
            frm.Show();

        }
        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            txtProductID.Text = ProductBUS.Instance.GetProductID();
            btnSaveProduct.Enabled = true;
            btnAddProduct.Enabled = false;
            txtProductName.Clear();
            txtPrice.Clear();
            richtxtDescribe.Clear();
            numQuantity.Value = info.count;
            cbCategory.SelectedIndex = info.valueDefault;
            btnEditProduct.Enabled = false;
            btnDeleteProduct.Enabled = false;
        }

        private void btnSaveProduct_Click(object sender, EventArgs e)
        {
            if (Language == info.valueDefault)
            {
                if (string.IsNullOrEmpty(txtProductName.Text.Trim()) || string.IsNullOrEmpty(txtPrice.Text.Trim()))
                {
                    MessageBox.Show(info.eventNullVi,info.titleMessageVi, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }                                  
                Product product = new Product(txtProductID.Text, txtProductName.Text, Convert.ToInt32(cbCategory.SelectedValue.ToString()), Convert.ToInt32(numQuantity.Value.ToString()), Convert.ToInt32(txtPrice.Text), 1, ImageToByteArray(pbProduct), richtxtDescribe.Text);
                if (ProductBUS.Instance.CheckNameProduct(product.TenSanPham))
                {
                    int count = ProductBUS.Instance.ExecuteInsertCommand(product);
                    if (count > 0)
                    {
                        MessageBox.Show(info.addVi,info.titleMessageVi, MessageBoxButtons.OK,MessageBoxIcon.Information);
                        LoadProduct();
                        Resettext();
                    }
                    else
                        MessageBox.Show(info.addFailedVi,info.titleMessageVi, MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
                else
                    MessageBox.Show(info.MessageCheckExistVi(txtProductName.Text),info.titleMessageVi, MessageBoxButtons.OK, MessageBoxIcon.Warning);                                   
            }
            else
            {
                if (string.IsNullOrEmpty(txtProductName.Text.Trim()) || string.IsNullOrEmpty(txtPrice.Text.Trim()))
                {
                    MessageBox.Show(info.eventNullEn,info.titleMessageEn, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }                                  
                Product product = new Product(txtProductID.Text, txtProductName.Text, Convert.ToInt32(cbCategory.SelectedValue.ToString()), Convert.ToInt32(numQuantity.Value.ToString()), Convert.ToInt32(txtPrice.Text), 1, ImageToByteArray(pbProduct), richtxtDescribe.Text);
                if (ProductBUS.Instance.CheckNameProduct(product.TenSanPham))
                {
                    int count = ProductBUS.Instance.ExecuteInsertCommand(product);
                    if (count > 0)
                    {
                        MessageBox.Show(info.addEn,info.titleMessageEn, MessageBoxButtons.OK,MessageBoxIcon.Information);
                        LoadProduct();
                        Resettext();
                    }
                    else
                        MessageBox.Show(info.addFailedEn,info.titleMessageEn, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                    MessageBox.Show(info.MessageCheckExistEn(txtProductName.Text),info.titleMessageEn, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            
                
            }
        }
        private void pbProduct_Click(object sender, EventArgs e)
        {
            ofdImage.Filter = info.filterPicTure;
            ofdImage.Title = info.selectImgVi;
            if (ofdImage.ShowDialog() == DialogResult.OK)
            {
                fileAddress = ofdImage.FileName;
                pbProduct.Image = CloneImage(fileAddress);
                pbProduct.ImageLocation = fileAddress;
                img = ImageToByteArray(pbProduct);
            }

        }
        private Image CloneImage(string path)
        {
            Image result;
            using (Bitmap original = new Bitmap(path))
            {
                result = (Bitmap)original.Clone();

            };
            return result;
        }

        private byte[] ImageToByteArray(PictureBox pictureBox)
        {
            MemoryStream memoryStream = new MemoryStream();
            pictureBox.Image.Save(memoryStream, pictureBox.Image.RawFormat);
            return memoryStream.ToArray();
        }
        private void frmProductManagement_Load(object sender, EventArgs e)
        {
            LoadProduct();
            cbCategory.DataSource = CategoryFoodBUS.Instance.GetCategoryFoods();
            cbCategory.DisplayMember = "CategoryName";
            cbCategory.ValueMember = "CategoryID";
            List<CategoryFood> list = new List<CategoryFood>();
            list = CategoryFoodBUS.Instance.GetCategoryFoods();
            for (int i = 0; i < list.Count; i++)
            {
                cbFillProduct.Items.Add(list[i].CategoryName);
            }
        }
        public void LoadProduct()
        {
            dtgvListProduct.DataSource = ProductBUS.Instance.GetListProduct();
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            if (Language == info.valueDefault)
            {
                if (string.IsNullOrEmpty(txtProductID.Text))
                {
                    MessageBox.Show(info.messDelDishVi,info.titleMessageVi, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (DialogResult.Yes == MessageBox.Show(info.messageDeleteVi,info.titleMessageVi, MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    if (BillInfoBUS.Instance.CheckProduct(txtProductID.Text))
                    {
                        int data = ProductBUS.Instance.DeleteProduct(txtProductID.Text);
                        if (data > 0)
                            MessageBox.Show(info.deleteVi,info.titleMessageVi, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show(info.deleteFailedVi,info.titleMessageVi, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        frmProductManagement_Load(sender, e);
                        LoadProduct();
                        Resettext();
                    }
                    else
                    {
                        MessageBox.Show(info.checkDelVi,info.titleMessageVi, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                if (string.IsNullOrEmpty(txtProductID.Text))
                {
                    MessageBox.Show(info.messDelDishEn,info.titleMessageEn, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (DialogResult.Yes == MessageBox.Show(info.messageDeleteEn,info.titleMessageEn, MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    if (BillInfoBUS.Instance.CheckProduct(txtProductID.Text))
                    {
                        int data = ProductBUS.Instance.DeleteProduct(txtProductID.Text);
                        if (data > 0)
                            MessageBox.Show(info.deleteEn,info.titleMessageEn, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show(info.deleteFailedEn,info.titleMessageEn, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        frmProductManagement_Load(sender, e);
                        LoadProduct();
                        Resettext();
                    }
                    else
                    {
                        MessageBox.Show(info.checkDelEn,info.titleMessageEn, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }
        public void Resettext()
        {
            txtProductID.Clear();
            txtProductName.Clear();
            txtPrice.Clear();
            richtxtDescribe.Clear();
            numQuantity.Value = info.count;
            cbCategory.SelectedIndex = info.valueDefault;
            btnSaveProduct.Enabled = false;
            btnAddProduct.Enabled = true;
            btnDeleteProduct.Enabled = true;
            btnEditProduct.Enabled = true;
        }
        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void dtgvListProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            info.firstIndex = info.valueDefault;
            if (i == -1) return;
            MemoryStream memoryStream = new MemoryStream((byte[])dtgvListProduct.Rows[i].Cells[info.firstIndex].Value);
            pbProduct.Image = Image.FromStream(memoryStream);
            txtProductID.Text = dtgvListProduct.Rows[i].Cells[info.firstIndex+=1].Value.ToString();
            txtProductName.Text = dtgvListProduct.Rows[i].Cells[info.firstIndex += 1].Value.ToString();
            cbCategory.SelectedValue = dtgvListProduct.Rows[i].Cells[info.firstIndex += 2].Value;
            numQuantity.Value = Convert.ToInt32(dtgvListProduct.Rows[i].Cells[info.firstIndex += 1].Value);
            txtPrice.Text = dtgvListProduct.Rows[i].Cells[info.firstIndex += 1].Value.ToString();
            richtxtDescribe.Text = dtgvListProduct.Rows[i].Cells[info.firstIndex += 1].Value.ToString();
        }

        private void btnEditProduct_Click(object sender, EventArgs e)
        {
            if (Language == info.valueDefault)
            {
                if (string.IsNullOrEmpty(txtProductID.Text))
                {
                    MessageBox.Show(info.messEditDishVi,info.titleMessageVi, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (DialogResult.Yes == MessageBox.Show(info.messageEditVi,info.titleMessageVi, MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {

                    Product product = new Product
                        (
                            txtProductID.Text, txtProductName.Text, Convert.ToInt32(cbCategory.SelectedValue.ToString()), Convert.ToInt32(numQuantity.Value.ToString()), Convert.ToInt32(txtPrice.Text), 1, ImageToByteArray(pbProduct), richtxtDescribe.Text
                        );
                    if (ProductBUS.Instance.CheckNameProduct(product.TenSanPham,txtProductID.Text))
                    {
                        int cout = ProductBUS.Instance.UpdateProduct(product);
                        if (cout > 0)
                            MessageBox.Show(info.editVi,info.titleMessageVi, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show(info.editFailedVi,info.titleMessageVi, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show(info.MessageCheckExistVi(txtProductName.Text),info.titleMessageVi, MessageBoxButtons.OK);
                    }
                    Resettext();
                    LoadProduct();
                }
            }
            else
            {
                if (string.IsNullOrEmpty(txtProductID.Text))
                {
                    MessageBox.Show(info.messEditDishEn,info.titleMessageEn, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (DialogResult.Yes == MessageBox.Show(info.messageEditEn,info.titleMessageEn, MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    Product product = new Product
                        (
                            txtProductID.Text, txtProductName.Text, Convert.ToInt32(cbCategory.SelectedValue.ToString()), Convert.ToInt32(numQuantity.Value.ToString()), Convert.ToInt32(txtPrice.Text), 1, ImageToByteArray(pbProduct), richtxtDescribe.Text
                        );
                    if (ProductBUS.Instance.CheckNameProduct(product.TenSanPham, txtProductID.Text))
                    {
                        int cout = ProductBUS.Instance.UpdateProduct(product);
                        if (cout > 0)
                            MessageBox.Show(info.editEn,info.titleMessageEn, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show(info.editFailedEn,info.titleMessageEn, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                        MessageBox.Show(info.MessageCheckExistEn(txtProductName.Text),info.titleMessageEn, MessageBoxButtons.OK);
                    Resettext();
                    LoadProduct();
                }
            }
        }
        private void cbFillProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtgvListProduct.DataSource = null;
            dtgvListProduct.Rows.Clear();
            if (cbFillProduct.SelectedIndex == info.valueDefault)
            {
                LoadProduct();
            }
            else
            {
                dtgvListProduct.DataSource = ProductBUS.Instance.GetListFillProduct(cbFillProduct.Text);
            }
        }

        private void btnSearchProduct_Click(object sender, EventArgs e)
        {
            if (Language == info.valueDefault)
            {
                if (string.IsNullOrEmpty(txtSearchProduct.Text.Trim()))
                {
                    MessageBox.Show(info.messSearchDishVi,info.titleMessageVi, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                dtgvListProduct.DataSource = null;
                dtgvListProduct.Rows.Clear();
                dtgvListProduct.DataSource = ProductBUS.Instance.GetListFindProduct(txtSearchProduct.Text);
            }
            else
            {
                {
                    MessageBox.Show(info.messSearchDishEn,info.titleMessageEn, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                dtgvListProduct.DataSource = null;
                dtgvListProduct.Rows.Clear();
                dtgvListProduct.DataSource = ProductBUS.Instance.GetListFindProduct(txtSearchProduct.Text);
            }
        }

        private void cbSortProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            info.firstIndex = info.valueDefault;
            dtgvListProduct.DataSource = null;
            dtgvListProduct.Rows.Clear();
            if (cbSortProduct.SelectedIndex == info.firstIndex )
                dtgvListProduct.DataSource = ProductBUS.Instance.SortProductName(cbFillProduct.Text);
            else if (cbSortProduct.SelectedIndex == (info.firstIndex+=1))
                dtgvListProduct.DataSource = ProductBUS.Instance.SortSoLuongASC(cbFillProduct.Text);
            else if (cbSortProduct.SelectedIndex == (info.firstIndex += 1))
                dtgvListProduct.DataSource = ProductBUS.Instance.SortSoLuongDESC(cbFillProduct.Text);
            else if (cbSortProduct.SelectedIndex == (info.firstIndex += 1))
                dtgvListProduct.DataSource = ProductBUS.Instance.SortDonGiaASC(cbFillProduct.Text);
            else
                dtgvListProduct.DataSource = ProductBUS.Instance.SortDonGiaDESC(cbFillProduct.Text);
        }

        private void btnDeleteAllProduct_Click(object sender, EventArgs e)
        {
            if (Language == info.valueDefault)
            {
                if (DialogResult.Yes == MessageBox.Show(info.messageDeleteAllVi,info.titleMessageVi, MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    if (BillInfoBUS.Instance.CheckProduct())
                    {
                        int data = ProductBUS.Instance.DeleteProductAll();
                        if (data > 0)
                            MessageBox.Show(info.deleteAllVi,info.titleMessageVi, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show(info.deleteAllEn,info.titleMessageVi, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        frmProductManagement_Load(sender, e);
                        LoadProduct();
                        Resettext();
                    }
                    else
                    {
                        MessageBox.Show(info.checkDelVi,info.titleMessageVi, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                if (DialogResult.Yes == MessageBox.Show(info.messageDeleteAllEn,info.titleMessageEn, MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    if (BillInfoBUS.Instance.CheckProduct())
                    {
                        int data = ProductBUS.Instance.DeleteProductAll();
                        if (data > 0)
                            MessageBox.Show(info.deleteAllEn,info.titleMessageEn, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show(info.deleteAllFailedEn,info.titleMessageEn, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        frmProductManagement_Load(sender, e);
                        LoadProduct();
                        Resettext();
                    }
                    else
                    {
                        MessageBox.Show(info.checkDelEn,info.titleMessageEn, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }
    }
}
