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
        public frmProductManagement()
        {
            InitializeComponent();
            if (Language == 0)
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("vi");
            else
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en");
            dtgvListProduct.AutoGenerateColumns = false;
            cbFillProduct.SelectedIndex = 0;

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
            numQuantity.Value = 1;
            cbCategory.SelectedIndex = 0;
            btnEditProduct.Enabled = false;
            btnDeleteProduct.Enabled = false;
        }

        private void btnSaveProduct_Click(object sender, EventArgs e)
        {
            if (Language == 0)
            {
                if (string.IsNullOrEmpty(txtProductName.Text.Trim()))
                {
                    MessageBox.Show("Vui lòng nhập tên sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    if (string.IsNullOrEmpty(txtPrice.Text.Trim()))
                    {
                        MessageBox.Show("Vui lòng nhập đơn giá cúa sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        Product product = new Product(txtProductID.Text, txtProductName.Text, Convert.ToInt32(cbCategory.SelectedValue.ToString()), Convert.ToInt32(numQuantity.Value.ToString()), Convert.ToInt32(txtPrice.Text), 1, ImageToByteArray(pbProduct), richtxtDescribe.Text);
                        if (ProductBUS.Instance.CheckNameProduct(product.TenSanPham))
                        {
                            int count = ProductBUS.Instance.ExecuteInsertCommand(product);
                            if (count > 0)
                            {
                                MessageBox.Show("Thêm sản phẩm mới thành công", "Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Information);
                                LoadProduct();
                                Resettext();
                            }
                            else
                                MessageBox.Show("Thêm sản phẩm mới thất bại", "Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                        }
                        else
                            MessageBox.Show("Tên sản phẩm đã có", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                if (string.IsNullOrEmpty(txtProductName.Text.Trim()))
                {
                    MessageBox.Show("Please enter product name", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    if (string.IsNullOrEmpty(txtPrice.Text.Trim()))
                    {
                        MessageBox.Show("Please enter the price of the product", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        Product product = new Product(txtProductID.Text, txtProductName.Text, Convert.ToInt32(cbCategory.SelectedValue.ToString()), Convert.ToInt32(numQuantity.Value.ToString()), Convert.ToInt32(txtPrice.Text), 1, ImageToByteArray(pbProduct), richtxtDescribe.Text);
                        if (ProductBUS.Instance.CheckNameProduct(product.TenSanPham))
                        {
                            int count = ProductBUS.Instance.ExecuteInsertCommand(product);
                            if (count > 0)
                            {
                                MessageBox.Show("Successfully added new products", "Notification", MessageBoxButtons.OK);
                                LoadProduct();
                                Resettext();
                            }
                            else
                                MessageBox.Show("Add new product failed", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                            MessageBox.Show("Add new product failed", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }
        private void pbProduct_Click(object sender, EventArgs e)
        {
            ofdImage.Filter = "Pictures files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png)|*.jpg; *.jpeg; *.jpe; *.jfif; *.png|All files (*.*)|*.*";
            ofdImage.Title = "Chọn ảnh";
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
            if (Language == 0)
            {
                if (string.IsNullOrEmpty(txtProductID.Text))
                {
                    MessageBox.Show("Bạn chưa chọn sản phẩm để xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (DialogResult.Yes == MessageBox.Show("Bạn có muốn xóa sản phẩm", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    if (BillInfoBUS.Instance.CheckProduct(txtProductID.Text))
                    {
                        int data = ProductBUS.Instance.DeleteProduct(txtProductID.Text);
                        if (data > 0)
                            MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show("Xóa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        frmProductManagement_Load(sender, e);
                        LoadProduct();
                        Resettext();
                    }
                    else
                    {
                        MessageBox.Show("Sản phẩm đã có trong hóa đơn không thể xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                if (string.IsNullOrEmpty(txtProductID.Text))
                {
                    MessageBox.Show("You have not selected a product to delete", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (DialogResult.Yes == MessageBox.Show("Do you want to delete the product?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    if (BillInfoBUS.Instance.CheckProduct(txtProductID.Text))
                    {
                        int data = ProductBUS.Instance.DeleteProduct(txtProductID.Text);
                        if (data > 0)
                            MessageBox.Show("Delete successfully", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show("Delete failed", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        frmProductManagement_Load(sender, e);
                        LoadProduct();
                        Resettext();
                    }
                    else
                    {
                        MessageBox.Show("Product already in invoice cannot be deleted", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            numQuantity.Value = 1;
            cbCategory.SelectedIndex = 0;
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
            if (i == -1) return;
            MemoryStream memoryStream = new MemoryStream((byte[])dtgvListProduct.Rows[i].Cells[0].Value);
            pbProduct.Image = Image.FromStream(memoryStream);
            txtProductID.Text = dtgvListProduct.Rows[i].Cells[1].Value.ToString();
            txtProductName.Text = dtgvListProduct.Rows[i].Cells[2].Value.ToString();
            cbCategory.SelectedValue = dtgvListProduct.Rows[i].Cells[4].Value;
            numQuantity.Value = Convert.ToInt32(dtgvListProduct.Rows[i].Cells[5].Value);
            txtPrice.Text = dtgvListProduct.Rows[i].Cells[6].Value.ToString();
            richtxtDescribe.Text = dtgvListProduct.Rows[i].Cells[7].Value.ToString();
        }

        private void btnEditProduct_Click(object sender, EventArgs e)
        {
            if (Language == 0)
            {
                if (string.IsNullOrEmpty(txtProductID.Text))
                {
                    MessageBox.Show("Bạn chưa chọn sản phẩm để sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (DialogResult.Yes == MessageBox.Show("Bạn có muốn sửa sản phẩm", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {

                    Product product = new Product
                        (
                            txtProductID.Text, txtProductName.Text, Convert.ToInt32(cbCategory.SelectedValue.ToString()), Convert.ToInt32(numQuantity.Value.ToString()), Convert.ToInt32(txtPrice.Text), 1, ImageToByteArray(pbProduct), richtxtDescribe.Text
                        );
                    if (ProductBUS.Instance.CheckNameProduct(product.TenSanPham,txtProductID.Text))
                    {
                        int cout = ProductBUS.Instance.UpdateProduct(product);
                        if (cout > 0)
                            MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show("Sửa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("Tên sản phẩm đã có", "Thông báo", MessageBoxButtons.OK);
                    }
                    Resettext();
                    LoadProduct();
                }
            }
            else
            {
                if (string.IsNullOrEmpty(txtProductID.Text))
                {
                    MessageBox.Show("You have not selected a product to repair", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (DialogResult.Yes == MessageBox.Show("Do you want to fix the product?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    Product product = new Product
                        (
                            txtProductID.Text, txtProductName.Text, Convert.ToInt32(cbCategory.SelectedValue.ToString()), Convert.ToInt32(numQuantity.Value.ToString()), Convert.ToInt32(txtPrice.Text), 1, ImageToByteArray(pbProduct), richtxtDescribe.Text
                        );
                    if (ProductBUS.Instance.CheckNameProduct(product.TenSanPham, txtProductID.Text))
                    {
                        int cout = ProductBUS.Instance.UpdateProduct(product);
                        if (cout > 0)
                            MessageBox.Show("Successful fix", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show("Fix failure", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                        MessageBox.Show("Tên sản phẩm đã có", "Thông báo", MessageBoxButtons.OK);
                    Resettext();
                    LoadProduct();
                }
            }
        }
        private void cbFillProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtgvListProduct.DataSource = null;
            dtgvListProduct.Rows.Clear();
            if (cbFillProduct.SelectedIndex == 0)
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
            if (Language == 0)
            {
                if (string.IsNullOrEmpty(txtSearchProduct.Text.Trim()))
                {
                    MessageBox.Show("Bạn chưa nhập tên sản phẩm để tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                dtgvListProduct.DataSource = null;
                dtgvListProduct.Rows.Clear();
                dtgvListProduct.DataSource = ProductBUS.Instance.GetListFindProduct(txtSearchProduct.Text);
            }
            else
            {
                {
                    MessageBox.Show("You have not entered the product name to search", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                dtgvListProduct.DataSource = null;
                dtgvListProduct.Rows.Clear();
                dtgvListProduct.DataSource = ProductBUS.Instance.GetListFindProduct(txtSearchProduct.Text);
            }
        }

        private void cbSortProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
                dtgvListProduct.DataSource = null;
                dtgvListProduct.Rows.Clear();
                if (cbSortProduct.SelectedIndex == 0)
                    dtgvListProduct.DataSource = ProductBUS.Instance.SortProductName(cbFillProduct.Text);
                else if (cbSortProduct.SelectedIndex == 1)
                    dtgvListProduct.DataSource = ProductBUS.Instance.SortSoLuongASC(cbFillProduct.Text);
                else if (cbSortProduct.SelectedIndex == 2)
                    dtgvListProduct.DataSource = ProductBUS.Instance.SortSoLuongDESC(cbFillProduct.Text);
                else if (cbSortProduct.SelectedIndex == 3)
                    dtgvListProduct.DataSource = ProductBUS.Instance.SortDonGiaASC(cbFillProduct.Text);
                else
                    dtgvListProduct.DataSource = ProductBUS.Instance.SortDonGiaDESC(cbFillProduct.Text);
        }

        private void btnDeleteAllProduct_Click(object sender, EventArgs e)
        {
            if (Language == 0)
            {
                if (DialogResult.Yes == MessageBox.Show("Bạn có muốn xóa tất cả sản phẩm", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    if (BillInfoBUS.Instance.CheckProduct())
                    {
                        int data = ProductBUS.Instance.DeleteProductAll();
                        if (data > 0)
                            MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show("Xóa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        frmProductManagement_Load(sender, e);
                        LoadProduct();
                        Resettext();
                    }
                    else
                    {
                        MessageBox.Show("Sản phẩm đã có trong hóa đơn không thể xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                if (DialogResult.Yes == MessageBox.Show("Do you want to delete all the product?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    if (BillInfoBUS.Instance.CheckProduct())
                    {
                        int data = ProductBUS.Instance.DeleteProductAll();
                        if (data > 0)
                            MessageBox.Show("Delete successfully", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show("Delete failed", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        frmProductManagement_Load(sender, e);
                        LoadProduct();
                        Resettext();
                    }
                    else
                    {
                        MessageBox.Show("Product already in invoice cannot be deleted", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }
    }
}
