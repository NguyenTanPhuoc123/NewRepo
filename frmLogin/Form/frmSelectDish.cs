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
using System.Threading;

namespace frmLogin
{
    public partial class frmSelectDish : Form
    {
        private frmSellManagement FrmSellManagement;
        HashCode info = new HashCode();
        private int Language = frmlogin.Language;
        public frmSelectDish(frmSellManagement frmSell)
        {
            if (Language == info.valueDefault)
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("vi");
            else
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en");
            InitializeComponent();
            cbCategoryDish.SelectedIndex = info.valueDefault;
            this.FrmSellManagement = frmSell;
        }

        private void btnExitFomSelectDish_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmSelectDish_Load(object sender, EventArgs e)
        {
            LoadcbCategoryFood();
        }
        private void LoadcbCategoryFood()
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
         
                string tenSP = txtDishName.Text;
                int soLuong = ProductBUS.Instance.ProductCount(tenSP);
                int soLuongChon = Convert.ToInt32(numQuantity.Value.ToString());
            if (soLuongChon <= soLuong)
            {
                Usercontrol uc = new Usercontrol();
                if (lstvListDish.SelectedItems.Count > 0)
                {
                    int i = lstvListDish.Items.IndexOf(lstvListDish.SelectedItems[info.valueDefault]);
                    uc.HinhAnh = imageList1.Images[i];
                    uc.TenSP = tenSP;
                    uc.SoLuong = numQuantity.Value.ToString();
                    uc.DonGia = txtDishPrice.Text;
                    flpAddDish.Controls.Add(uc);
                }
                numQuantity.Value = info.count;
            }
            else
            {
                if (Language == info.valueDefault)
                    MessageBox.Show(info.checkCountVi,info.titleMessageVi,MessageBoxButtons.OK,MessageBoxIcon.Warning);
                else
                    MessageBox.Show(info.checkCountEn,info.titleMessageEn, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void lstvListDish_SelectedIndexChanged(object sender, EventArgs e)
        {
            info.firstIndex = info.valueDefault;
            if (lstvListDish.SelectedItems.Count > 0)
            {
                int i = lstvListDish.Items.IndexOf(lstvListDish.SelectedItems[info.valueDefault]);
                pbPictureDish.Image = imageList1.Images[i];
                pbPictureDish.SizeMode = PictureBoxSizeMode.Zoom;
                txtDishName.Text = lstvListDish.SelectedItems[info.valueDefault].Text;
                string Danhmuc = lstvListDish.SelectedItems[info.valueDefault].SubItems[info.firstIndex+=1].Text;
                txtCategoryDish.Text = CategoryFoodBUS.Instance.GetCategory(Convert.ToInt32(Danhmuc));
                txtDishPrice.Text = lstvListDish.SelectedItems[info.valueDefault].SubItems[info.firstIndex+=1].Text;
            }

        }
        private void btnSelectDish_Click(object sender, EventArgs e)
        {
            string masp;
            string soluong;
            float dongia;
            float thanhtien;
            int tableID = frmSellManagement.GetTableID();
            int manv = frmSellManagement.GetMANV();
            if (BillBUS.Instance.CheckHD(tableID))
            {
                if (BillBUS.Instance.AddNewBill(manv,tableID))
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
                            if (BillInfoBUS.Instance.CheckProduct(masp, mahd))
                            {
                                BillInfoBUS.Instance.UpdateCount(soluong, masp, mahd);
                                ProductBUS.Instance.UpdateProductCount(masp, soluong);
                            }
                            else
                                BillInfoBUS.Instance.InsertNewBillInfo(mahd, masp, dongia, soluong, thanhtien);
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
                        if (BillInfoBUS.Instance.CheckProductDeleted(masp, mahd))
                        {
                            BillInfoBUS.Instance.UpdateProduct(soluong, masp, mahd, thanhtien);
                            ProductBUS.Instance.UpdateProductCount(masp, soluong);
                        }
                        else
                        {
                            if (BillInfoBUS.Instance.CheckProduct(masp, mahd))
                            {
                                BillInfoBUS.Instance.UpdateCount(soluong, masp, mahd);
                                ProductBUS.Instance.UpdateProductCount(masp, soluong);
                            }
                            else
                                BillInfoBUS.Instance.InsertNewBillInfo(mahd, masp, dongia, soluong, thanhtien);
                        }
                    }
                }
            }          
            this.Close();
            this.FrmSellManagement.GetListTableByLocationID(1);
            this.FrmSellManagement.LoadTable();
        }

        private void cbCategoryDish_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstvListDish.Clear();
            imageList1.Images.Clear();
            if (cbCategoryDish.SelectedIndex == info.valueDefault)
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
                if(Language ==info.valueDefault)
                    MessageBox.Show(info.messSearchDishVi,info.titleMessageVi, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                    MessageBox.Show(info.messSearchDishEn,info.titleMessageEn, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            lstvListDish.Clear();
            imageList1.Images.Clear();
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
