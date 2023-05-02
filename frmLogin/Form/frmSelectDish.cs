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
        public frmSelectDish(frmSellManagement frmSell)
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
            LoadProduct();
            LoadcbCategoryFoof();
        }
        private void LoadcbCategoryFoof()
        {
            List<CategoryFood> categoryFoods = CategoryFoodBUS.Instance.GetCategoryFoods();
            for (int i = 0; i < categoryFoods.Count; i++)
            {
                cbCategoryDish.Items.Add(categoryFoods[i].CategoryName);
            }
        }
        private void LoadProduct()
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
                flpAddDish.Controls.Add(uc);
            }
            numQuantity.Value = 1;
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
                txtCategoryDish.Text = CategoryFoodBUS.Instance.GetCategory(Convert.ToInt32(Danhmuc));
                txtDishPrice.Text = lstvListDish.SelectedItems[0].SubItems[2].Text;
            }

        }
        private void btnSelectDish_Click(object sender, EventArgs e)
        {
            string masp;
            string soluong;
            float dongia;
            float thanhtien;
            int tableID = frmSellManagement.GetTableID();
            if (BillBUS.Instance.CheckHD(tableID))
            {
                if (BillBUS.Instance.AddNewBill("GETDATE()", "GETDATE()", 1,null,tableID,0)>0)
                {
                    foreach (Control c in flpAddDish.Controls)
                    {
                        if (c is Usercontrol)
                        {
                            Usercontrol userControl = (Usercontrol)c;
                            masp = ProductBUS.Instance.ProductID(userControl.TenSP);
                            soluong = userControl.SoLuong;
                            dongia =float.Parse(userControl.DonGia);
                            thanhtien =float.Parse(soluong) * dongia;
                            string mahd = BillBUS.Instance.HDID(tableID);
                            int data = BillInfoBUS.Instance.InsertNewBillInfo(mahd, masp, dongia, soluong, thanhtien);
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
                        masp = ProductBUS.Instance.ProductID(userControl.TenSP);
                        soluong = userControl.SoLuong;
                        dongia = float.Parse(userControl.DonGia);
                        thanhtien = float.Parse(soluong) * dongia;
                        string mahd = BillBUS.Instance.HDID(tableID);
                        int data = BillInfoBUS.Instance.InsertNewBillInfo(mahd, masp,dongia, soluong, thanhtien);
                    }
                }
            }          
            this.Close();
        }

        private void cbCategoryDish_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstvListDish.Clear();
            imageList1.Images.Clear();
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
                List<Product> products = ProductBUS.Instance.GetListFillProductSelectDish(cbCategoryDish.Text);
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
        }

        private void btnSearchDish_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearchDish.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên sản phẩm để tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            lstvListDish.Clear();
            List<Product> products = ProductBUS.Instance.GetListFindProductSelectDish(txtSearchDish.Text);
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
    }
}
