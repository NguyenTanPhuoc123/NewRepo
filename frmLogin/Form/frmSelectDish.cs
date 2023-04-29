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
        private Account loginAccount;

        public Account LoginAccount
        {
            get { return this.loginAccount; }
            private set { this.loginAccount = value; }
        }
        public frmSelectDish()
        {
            InitializeComponent();
            cbCategoryDish.SelectedIndex = 0;
        }

        private void btnExitFomSelectDish_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmSelectDish_Load(object sender, EventArgs e)
        {
            cbCategoryDish.DataSource = CategoryFoodBUS.Instance.GetCategoryFoods();
            cbCategoryDish.ValueMember = "CategoryID";
            cbCategoryDish.DisplayMember = "CategoryName";
            cbSize.DataSource = SizeProductBUS.Instance.GetListSizeProduct();
            cbSize.DisplayMember = "SizeName";
            cbSize.ValueMember = "SizeID";
        }
        private void LoadProduct()
        {
            if (cbCategoryDish.SelectedIndex == 0)
            {
                List<Product> products = ProductBUS.Instance.GetProduct();
                for (int i = 0; i < products.Count; i++)
                {
                    imageList1.Images.Add(convertbytetoimage(products[i].image));
                    ListViewItem item = new ListViewItem(products[i].TenSanPham);
                    item.ImageIndex = i;
                    item.SubItems.Add(products[i].DanhMuc.ToString());
                    item.SubItems.Add(products[i].DonGia.ToString());
                    lstvListDish.Items.Add(item);
                }
            }
            else
            {

            }    
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
                uc.HinhAnh = imageList1.Images[i];
                uc.TenSP = txtDishName.Text;
                uc.SoLuong = numQuantity.Value.ToString();
                uc.DonGia = txtDishPrice.Text;
                uc.KichthuocName1 = cbSize.Text;
                uc.TenSP1 = txtDishName.Text;
                uc.SoLuong1 = numQuantity.Value.ToString();
                uc.DonGia1 = txtDishPrice.Text;
                uc.KichThuoc1 =Convert.ToInt32(cbSize.SelectedValue);
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
                string Danhmuc = lstvListDish.SelectedItems[0].SubItems[1].Text;
                txtCategoryDish.Text =CategoryFoodBUS.Instance.GetCategory(Convert.ToInt32(Danhmuc));
                txtDishPrice.Text = lstvListDish.SelectedItems[0].SubItems[2].Text;
            }
        
        }
         private void btnSelectDish_Click(object sender, EventArgs e)
         {
            string masp;
            string soluong;
            int kichthuoc;
            int tableID = frmSellManagement.GetTableID();
            if (MenuDishBUS.Instance.CheckHD(tableID)) {
                if (MenuDishBUS.Instance.ADDBILL(tableID))
                {
                    foreach (Control c in flpAddDish.Controls)
                    {
                        if (c is Usercontrol)
                        {
                            Usercontrol userControl = (Usercontrol)c;
                            masp = MenuDishBUS.Instance.ProductID(userControl.TenSP1);
                            soluong = userControl.SoLuong1;
                            kichthuoc = userControl.KichThuoc1;
                            MenuDishBUS.Instance.ADDBILLINFO(masp, kichthuoc, soluong);
                        }
                    }
                }
            }
            else
            {
                foreach (Control c in flpAddDish.Controls)
                {
                    if (c is Usercontrol)
                    {
                        Usercontrol userControl = (Usercontrol)c;
                        masp = MenuDishBUS.Instance.ProductID(userControl.TenSP1);
                        soluong = userControl.SoLuong1;
                        kichthuoc = userControl.KichThuoc1;
                        MenuDishBUS.Instance.ADDBILLINFO(masp, kichthuoc, soluong);
                    }
                }
            }
            this.Close();
         }

        private void cbCategoryDish_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
