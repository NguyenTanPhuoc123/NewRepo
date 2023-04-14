using frmLogin.Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmLogin
{
    public partial class frmProductManagement : Form
    {
        public frmProductManagement()
        {
            InitializeComponent();

        }

        private void btnProductDeleted_Click(object sender, EventArgs e)
        {
            frmRecycleBin frm = new frmRecycleBin();
            frm.Show();

        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            byte[] image = imageToByteArray(pbProduct.Image);
            string query = string.Format("INSERT INTO SANPHAM VALUES({0},{1},{2},{3},{4},{5},1,{6})",txtProductID.Text,txtProductName.Text,cbCategory.SelectedValue.ToString(),numQuantity.Value.ToString(),txtPrice.Text,richtxtDescribe.Text,image);
            int count = DataProvider.ExecuteInsertCommand(query, null);
            MessageBox.Show(count > 0 ? "Them thanh cong" : "Them that bai");
        }
        public byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }

        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
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
            dtgvListProduct.DataSource = ProductDAF.Instance.GetListProduct();
            cbCategory.DataSource = CategoryFoodDAF.Instance.GetCategoryFoods();
            cbCategory.DisplayMember = "CategoryName";
            cbCategory.ValueMember = "CategoryID";
        }
    }
}
