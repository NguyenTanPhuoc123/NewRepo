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

namespace frmLogin
{
    public partial class frmSelectDish : Form
    {
        public frmSelectDish()
        {
            InitializeComponent();
        }

        private void btnExitFomSelectDish_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmSelectDish_Load(object sender, EventArgs e)
        {
            List<Product> products = ProductBUS.Instance.GetProduct();
            for (int i = 0; i < products.Count; i++)
            {
                imageList1.Images.Add(convertbytetoimage(products[i].image));
                ListViewItem item = new ListViewItem(products[i].TenSanPham);
                item.ImageIndex =i;
                item.SubItems.Add(products[i].DanhMuc.ToString());
                item.SubItems.Add(products[i].DonGia.ToString());
                lstvListDish.Items.Add(item);
            }
            cbCategoryDish.DataSource = CategoryFoodBUS.Instance.GetCategoryFoods();
            cbCategoryDish.ValueMember = "CategoryID";
            cbCategoryDish.DisplayMember = "CategoryName";
        }
        private Image convertbytetoimage(byte[] b)
        {
            using (MemoryStream ms = new MemoryStream(b))
            {
                Image image = Image.FromStream(ms);
                return image;
            }
        }
        private void btnAddDish_Click(object sender, EventArgs e)
        {
            Usercontrol uc = new Usercontrol();
            if (lstvListDish.SelectedItems.Count > 0)
            {
                int i = lstvListDish.Items.IndexOf(lstvListDish.SelectedItems[0]);
                uc.HinhAnh  = imageList1.Images[i];
                uc.TenSP = " " + txtDishName.Text;
                uc.SoLuong = " " + numQuantity.Value.ToString();
                uc.DonGia = " " + txtDishPrice.Text;
                flpAddDish.Controls.Add(uc);
            }
        }

        private void lstvListDish_SelectedIndexChanged(object sender, EventArgs e)
        {
          
            if (lstvListDish.SelectedItems.Count > 0)
            {
                int i = lstvListDish.Items.IndexOf(lstvListDish.SelectedItems[0]);
               pbPictureDish.Image = imageList1.Images[i];
                pbPictureDish.SizeMode = PictureBoxSizeMode.Zoom;
                txtDishName.Text = lstvListDish.SelectedItems[0].Text;
                txtCategoryDish.Text = lstvListDish.SelectedItems[0].SubItems[1].Text;
                txtDishPrice.Text = lstvListDish.SelectedItems[0].SubItems[2].Text;
            }
        }       
    
    }
}
