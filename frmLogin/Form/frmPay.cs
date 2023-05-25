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
using System.Globalization;
using ZXing;
using ZXing.Common;
using ZXing.QrCode.Internal;
using System.Drawing.Drawing2D;
using System.Threading;

namespace frmLogin
{
    public partial class frmPay : Form
    {
        BillMenu billMenu = BillMenuBUS.Instance.GetBillMenuByTableID(frmSellManagement.GetTableID());
        
        private static string billID;
        private static string discountID;
        private int Language = frmlogin.Language;
        public static void SetBillID(string value)
        {
            billID = value;
        }

        public static string GetBillID()
        {
            return billID;
        }

        public static void SetDiscountID(string value)
        {
            discountID = value;
        }

        public static string GetDiscountID()
        {
            return discountID;
        }

        public frmPay()
        {
            if (Language == 0)
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("vi");
            else
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en");
            InitializeComponent();
        }

        private void btnExitFomPay_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void txtMoneyPay_TextChanged(object sender, EventArgs e)
        {
            CultureInfo culture = new CultureInfo("vi-VN");
            float moneyPay;
            try
            {
                moneyPay = float.Parse(txtMoneyPay.Text);
            }
            catch
            {
                moneyPay = 0;
            }
            lblMoneyReceive.Text = moneyPay.ToString("c", culture);
            lblMoneyPay.Text = (moneyPay - billMenu.Total).ToString("c", culture);
        }

        private void frmPay_Load(object sender, EventArgs e)
        {
            CultureInfo culture = new CultureInfo("vi-VN");
            txtBillID.Text = billMenu.ID;
            SetBillID(billMenu.ID);
            txtEmployeeID.Text = billMenu.EmployeeID.ToString();
            txtEmployeeName.Text = billMenu.EmployeeName;
            txtTableID.Text = billMenu.TableName;
            lblTotal.Text = billMenu.Total.ToString("c", culture);
            LoadDiscount();
            cbDiscount.SelectedIndex = 0;
            cbPay.SelectedIndex = 0;
            dtgvBill.DataSource = BillInfoMenuBUS.Instance.GetListBillInfoMenu(billMenu.ID);
        }

        public void LoadDiscount()
        {
            cbDiscount.DataSource = DiscountBUS.Instance.GetListDiscountAvailable();
            cbDiscount.DisplayMember = "DiscountName";
            cbDiscount.ValueMember = "DiscountID";
        }

        public void CloseForm(object sender, EventArgs e)
        {

        }

        public string GetMoneyReceive()
        {
            return lblMoneyReceive.Text;
        }

        public string GetMoneyPay()
        {
            return lblMoneyPay.Text;
        }

        private void btnOutputBill_Click(object sender, EventArgs e)
        {
            float total = billMenu.Total;
            string id = cbDiscount.SelectedValue.ToString();
            SetDiscountID(id);
            float price = 0;
            if (DiscountBUS.Instance.GetDiscountForID(id) != null)
            {
                price = DiscountBUS.Instance.GetDiscountForID(id).Price;
            }
            total = total - price;
            int row = TableBUS.Instance.UpdateTablePay(billMenu.TableID);
            int count = BillBUS.Instance.OutputBill(txtBillID.Text, total, cbDiscount.SelectedValue.ToString());
            if (total > 0)
            {
                if (count > 0 && row > 0)
                {
                    MessageBox.Show("Thanh toán thành công", "Thanh toán", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmPay_Load(sender, e);
                    this.IsMdiContainer = true;
                    frmOutputBill frm = new frmOutputBill(this);
                    frm.Show();
                    LoadBackColorMDI();
                    frmSellManagement.ActiveForm.Load += new EventHandler(CloseForm);
                }
                else
                {
                    MessageBox.Show("Thanh toán thất bại", "Thanh toán", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Số tiền khách hàng trả không đủ", "Thanh toán", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void LoadBackColorMDI()
        {
            MdiClient mdiCtrl;
            foreach (Control ctrl in this.Controls)
            {
                try
                {
                    mdiCtrl = (MdiClient)ctrl;
                    mdiCtrl.BackColor = System.Drawing.Color.White;
                }
                catch (InvalidCastException ex)
                {

                }
            }
        }

        private void cbDiscount_SelectedIndexChanged(object sender, EventArgs e)
        {
            CultureInfo culture = new CultureInfo("vi-VN");
            string id = cbDiscount.SelectedValue.ToString();
            Discount discount = DiscountBUS.Instance.GetDiscountForID(id);
            float price = 0;
            if (discount != null)
            {
                if (DiscountBUS.Instance.GetDiscountForID(id) != null)
                {
                    price = DiscountBUS.Instance.GetDiscountForID(id).Price;
                    if (billMenu.Total > discount.Limit)
                    {
                        lblTotal.Text = (billMenu.Total - price).ToString("c", culture);
                    }
                    else
                    {
                        MessageBox.Show("Không thể giảm giá cho hóa đơn này");
                        cbDiscount.SelectedIndex = 0;
                    }
                }

            }

        }

        private void cbPay_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbPay.SelectedIndex == 0)
            {
                label15.Visible = true;
                txtMoneyPay.Visible = true;
            }
            else
            {
                this.IsMdiContainer = true;
                frmQRCode frm = new frmQRCode();
                frm.Show();
                LoadBackColorMDI();
            }

        }
    }
}
