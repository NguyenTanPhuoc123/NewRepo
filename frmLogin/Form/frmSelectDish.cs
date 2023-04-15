using frmLogin.Data_Access_Layer;
using frmLogin.Data_Tranfer_Object;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            List<Product> products = ProductDAF.Instance.GetListProduct();
            for (int i = 0; i < products.Count; i++)
            {
                imageList1.Images.Add(products[i].HinhAnh);
                ListViewItem item = new ListViewItem(products[i].TenSanPham);
                item.ImageIndex =i;
                item.SubItems.Add(products[i].DanhMuc.ToString());
                item.SubItems.Add(products[i].DonGia.ToString());
                lstvListDish.Items.Add(item);
            }
        }

        private void btnSelectDish_Click(object sender, EventArgs e)
        {
            Usercontrol uc = new Usercontrol();
            if (lstvListDish.SelectedItems.Count > 0)
            {
                int i = lstvListDish.Items.IndexOf(lstvListDish.SelectedItems[0]);
                uc.HinhAnh  = imageList1.Images[i];
                uc.TenSP = " " + txtDishName.Text;
                uc.SoLuong = " " + numQuantity.Value.ToString();
                uc.DonGia = " " + txtDishPrice.Text;
                flowLayoutPanel1.Controls.Add(uc);
            }
        }

        private void lstvListDish_SelectedIndexChanged(object sender, EventArgs e)
        {
          
            if (lstvListDish.SelectedItems.Count > 0)
            {
                int i = lstvListDish.Items.IndexOf(lstvListDish.SelectedItems[0]);
                pbPictureDish.Image = imageList1.Images[i];
                txtDishName.Text = lstvListDish.SelectedItems[0].Text;
                txtCategoryDish.Text = lstvListDish.SelectedItems[0].SubItems[1].Text;
                txtDishPrice.Text = lstvListDish.SelectedItems[0].SubItems[2].Text;
            }
        }
    }
}
