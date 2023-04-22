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
using frmLogin.Data_Access_Layer;
using frmLogin.Data_Tranfer_Object;

namespace frmLogin
{
    public partial class frmProductManagement : Form
    {
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
        ProductDTO product;
        public void getValue()
        {
            string maSP = txtProductID.Text;
            string tenSP = txtProductName.Text;
            int donGia = Convert.ToInt32(txtPrice.Text);
            int soLuong = Convert.ToInt32(numQuantity.Value.ToString());
            string moTa = richtxtDescribe.Text;
            int danhMuc = Convert.ToInt32(cbCategory.SelectedValue.ToString());
            byte[] hinhAnh = ConvertImageToByte(pbProduct);
            product = new ProductDTO(maSP, tenSP, danhMuc, soLuong, donGia, 1,hinhAnh,moTa);
        }
        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            getValue();
            int count = ProductBUS.Instance.ExecuteInsertCommand(product);
            MessageBox.Show(count > 0 ? "Them thanh cong" : "Them that bai");
            LoadProduct();
            ResetText();
        }
        public byte[] ConvertImageToByte(PictureBox image)
        {
            using (var memoryStream = new MemoryStream())
            {
                image.Image.Save(memoryStream, image.Image.RawFormat);
                return memoryStream.ToArray();
            }
        }

        private void pbProduct_Click(object sender, EventArgs e)
        {
            ofdImage.Filter = "Image files(*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";
            if (ofdImage.ShowDialog() == DialogResult.OK)
            {
                pbProduct.ImageLocation = ofdImage.FileName;
            }

        }

        private void frmProductManagement_Load(object sender, EventArgs e)
        {
            LoadProduct();
            cbCategory.DataSource = CategoryFoodDAF.Instance.GetCategoryFoods();
            cbCategory.DisplayMember = "CategoryName";
            cbCategory.ValueMember = "CategoryID";
            List<CategoryFood> list = new List<CategoryFood>();
            list = CategoryFoodDAF.Instance.GetCategoryFoods();
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
        private void dtgvListProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (i == -1) return;
            Image image = (Image)dtgvListProduct.Rows[i].Cells[0].Value;
            pbProduct.Image = image;
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
                getValueUpdate();
                byte[] hinhAnh;
                Image image = (Image)dtgvListProduct.SelectedRows[0].Cells[0].Value;
                hinhAnh = pbProduct.Image == image ? null : ConvertImageToByte(pbProduct);
                int cout = ProductBUS.Instance.UpdateProduct(product, hinhAnh);
                MessageBox.Show(cout > 0 ? "Sua thanh cong" : "Sua that bai");
                Resettext();
                LoadProduct();
            }
        }
        public void getValueUpdate()
        {
            string maSP = txtProductID.Text;
            string tenSP = txtProductName.Text;
            int donGia = Convert.ToInt32(txtPrice.Text);
            int soLuong = Convert.ToInt32(numQuantity.Value.ToString());
            string moTa = richtxtDescribe.Text;
            int danhMuc = Convert.ToInt32(cbCategory.SelectedValue.ToString());
            product = new ProductDTO(maSP, tenSP, danhMuc, soLuong, donGia, 1, null, moTa);
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
