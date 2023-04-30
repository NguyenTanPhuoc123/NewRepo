using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;

namespace frmLogin
{
    public partial class frmProductManagement : Form
    {
        private string fileAddress;
        private byte[] img;
        public frmProductManagement()
        {
            InitializeComponent();
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

        }

        private void btnSaveProduct_Click(object sender, EventArgs e)
        {
            Product product = new Product(txtProductID.Text, txtProductName.Text, Convert.ToInt32(cbCategory.SelectedValue.ToString()), Convert.ToInt32(numQuantity.Value.ToString()), Convert.ToInt32(txtPrice.Text), 1, ImageToByteArray(pbProduct), richtxtDescribe.Text);
            if (ProductBUS.Instance.CheckNameProduct(product.TenSanPham))
            {
                int count = ProductBUS.Instance.ExecuteInsertCommand(product);
                MessageBox.Show(count > 0 ? "Them thanh cong" : "Them that bai");
                LoadProduct();
                ResetText();
            }
            else
                MessageBox.Show("Ten san pham da co");
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
            if (DialogResult.Yes == MessageBox.Show("Ban co muon xoa san pham", "Thong Bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                int data = ProductBUS.Instance.DeleteProduct(txtProductID.Text);
                MessageBox.Show(data > 0 ? "Xoa thanh cong" : "Xoa that bai");
                frmProductManagement_Load(sender, e);
                LoadProduct();
                Resettext();
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
            pbProduct.Image = null;
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
            if (DialogResult.Yes == MessageBox.Show("Ban co muon sua san pham", "Thong Bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                Product product = new Product
                    (
                        txtProductID.Text, txtProductName.Text, Convert.ToInt32(cbCategory.SelectedValue.ToString()), Convert.ToInt32(numQuantity.Value.ToString()), Convert.ToInt32(txtPrice.Text), 1, ImageToByteArray(pbProduct), richtxtDescribe.Text
                    );
                int cout = ProductBUS.Instance.UpdateProduct(product);
                MessageBox.Show(cout > 0 ? "Sua thanh cong" : "Sua that bai");
                Resettext();
                LoadProduct();
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
            if (string.IsNullOrEmpty(txtSearchProduct.Text))
            {
                MessageBox.Show("Ban chua nhap ten san pham de tim kiem");
                return;
            }
            dtgvListProduct.DataSource = null;
            dtgvListProduct.Rows.Clear();
            dtgvListProduct.DataSource = ProductBUS.Instance.GetListFindProduct(txtSearchProduct.Text);
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


    }
}
