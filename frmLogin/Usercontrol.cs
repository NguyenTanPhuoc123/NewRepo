using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmLogin
{
    public partial class Usercontrol : UserControl
    {
        private string tenSP;
        private string soLuong;
        private string donGia;
        private Image hinhAnh;
        private int Language = frmlogin.Language;
        public Usercontrol()
        {
            if (Language == 0)
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("vi");
            else
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en");
            InitializeComponent();

        }

        public string TenSP { get => tenSP; set => tenSP = value ; }
        public string SoLuong { get => soLuong; set => soLuong = value; }
        public string DonGia { get => donGia; set => donGia = value; }
        public Image HinhAnh { get => hinhAnh; set => hinhAnh = value; }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.pictureBox1.Image != null)
            {
                Image img = pictureBox1.Image;
                this.pictureBox1.Image = null;
                img.Dispose();
                lbSoLuong = null;
                lbTenSP = null;
                lbDonGia = null;
            }
            this.Parent.Controls.Remove(this);
        }

        private void Usercontrol_Load(object sender, EventArgs e)
        {
            lbTenSP.Text = TenSP;
            lbDonGia.Text = DonGia;
            lbSoLuong.Text = SoLuong;
            pictureBox1.Image = HinhAnh;
        }
    }
}
