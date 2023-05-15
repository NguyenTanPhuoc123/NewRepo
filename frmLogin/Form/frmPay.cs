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

namespace frmLogin
{
    public partial class frmPay : Form
    {
        public frmPay()
        {
            InitializeComponent();
        }
        
        private void btnExitFomPay_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        int TableID = frmSellManagement.GetTableID();
        string BillID = BillBUS.Instance.HDID(frmSellManagement.GetTableID());
        int EmployeeID = frmSellManagement.GetMANV();
        float Total = frmSellManagement.GetTotal();
        string EmployeeName = frmSellManagement.GetTENNV();

        private void txtMoneyPay_TextChanged(object sender, EventArgs e)
        {
            lblMoneyReceive.Text = txtMoneyPay.Text;
            lblMoneyPay.Text = (Convert.ToInt32(lblMoneyReceive.Text) - Convert.ToInt32(lblTotal.Text)).ToString();
        }

        private void frmPay_Load(object sender, EventArgs e)
        {
            txtBillID.Text = BillID.ToString();
            txtEmployeeID.Text = EmployeeID.ToString();
            txtEmployeeName.Text = EmployeeName;
            txtTableID.Text = TableID.ToString();
            lblTotal.Text = Total.ToString();
            LoadDiscount();
            cbDiscount.SelectedIndex = 0;
            cbPay.SelectedIndex = 0;
            dtgvBill.DataSource = BillInfoMenuBUS.Instance.GetListBillInfoMenu(BillID);
        }

        public void LoadDiscount()
        {
            cbDiscount.DataSource = DiscountBUS.Instance.GetListDiscountAvailable();
            cbDiscount.DisplayMember = "DiscountName";
            cbDiscount.ValueMember = "DiscountID";
        }

        private void btnOutputBill_Click(object sender, EventArgs e)
        {
            string id = cbDiscount.SelectedValue.ToString();
            float price = 0;
            if (DiscountBUS.Instance.GetDiscountForID(id) != null)
            {
                price = DiscountBUS.Instance.GetDiscountForID(id).Price;
            }
            Total = Total - price;
            int row = TableBUS.Instance.UpdateTablePay(TableID);
            int count = BillBUS.Instance.OutputBill(txtBillID.Text, Total, cbDiscount.SelectedValue.ToString());
            if (count > 0 && row > 0)
            {
                MessageBox.Show("Thanh toán thành công");
            }
            else
            {
                MessageBox.Show("Thanh toán thất bại");
            }
            frmPay_Load(sender, e);
        }

        private void cbDiscount_SelectedIndexChanged(object sender, EventArgs e)
        {
            CultureInfo culture = new CultureInfo("vi-VN");
            string id = cbDiscount.SelectedValue.ToString();
            float price = 0;
            if (DiscountBUS.Instance.GetDiscountForID(id) != null)
            {
                price = DiscountBUS.Instance.GetDiscountForID(id).Price;
                if (Total > price)
                {
                    //lblMoneyPay.Text = price.ToString("c", culture);
                    lblTotal.Text = (Total - price).ToString("c", culture);
                }
                else
                {
                    MessageBox.Show("Không thể giảm giá cho hóa đơn này");
                    cbDiscount.SelectedIndex = 0;
                }
            }
            
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbPay.SelectedIndex == 0)
            {
                label15.Visible = true;
                txtMoneyPay.Visible = true;
                label3.Visible = false;
                picQRPay.Visible = false;
            }
            else
            {
                label15.Visible = false;
                txtMoneyPay.Visible = false;
                label3.Visible = true;
                picQRPay.Visible = true;
                QRCode_Click(sender, e);
            }

        }
        #region QRCodeMoMo
        private void QRCode_Click(object sender, EventArgs e)
        {
            var qrcode_text = $"2|99|{"0969475617"}|{"Nguyễn Tấn Phước"}|0|0|{Total}";
            BarcodeWriter barcodeWriter = new BarcodeWriter();
            EncodingOptions encodingOptions = new EncodingOptions() { Width = 175, Height = 175, Margin = 0, PureBarcode = false };
            encodingOptions.Hints.Add(EncodeHintType.ERROR_CORRECTION, ErrorCorrectionLevel.H);
            barcodeWriter.Options = encodingOptions;
            barcodeWriter.Format = BarcodeFormat.QR_CODE;
            Bitmap bitmap = barcodeWriter.Write(qrcode_text);
            Bitmap logo = resizeImage(Properties.Resources.MoMo_Logo, 56, 56) as Bitmap;
            Graphics g = Graphics.FromImage(bitmap);
            g.DrawImage(logo, new Point((bitmap.Width - logo.Width) / 2, (bitmap.Height - logo.Height) / 2));
            picQRPay.Image = bitmap;
        }

        public Image resizeImage(Image img, int height, int width)
        {
            Bitmap new_img = new Bitmap(height, width);
            Graphics g = Graphics.FromImage((Image)new_img);
            g.InterpolationMode = InterpolationMode.High;
            g.DrawImage(img, 0, 0, width, height);
            return new_img;
        }
        #endregion
    }
}
