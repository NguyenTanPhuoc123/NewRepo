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
    public partial class Usercontrol : UserControl
    {
        private string tenSP;
        private string soLuong;
        private string donGia;
        private int Kichthuoc;
        private string KichthuocName;
        private Image hinhAnh;
        public Usercontrol()
        {
            InitializeComponent();

        }

        public Usercontrol(string tenSP, string soLuong, string donGia, Image hinhAnh, int KichThuoc)
        {
            this.tenSP = tenSP;
            this.soLuong = soLuong;
            this.donGia = donGia;
            this.hinhAnh = hinhAnh;
            this.Kichthuoc = KichThuoc;
        }

        public string TenSP { get => tenSP; set => lbTenSP.Text += value; }
        public string SoLuong { get => soLuong; set => lbSoLuong.Text += value; }
        public string DonGia { get => donGia; set => lbDonGia.Text += value; }
        public Image HinhAnh { get => hinhAnh; set => pictureBox1.Image = value; }
        public string KichthuocName1 { get => KichthuocName; set => lbKichThuoc.Text = value; }

        public string TenSP1 { get => tenSP; set => tenSP = value ; }
        public string SoLuong1 { get => soLuong; set => soLuong = value; }
        public string DonGia1 { get => donGia; set => donGia = value; }
        public int KichThuoc1 { get => Kichthuoc; set => Kichthuoc = value; }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.pictureBox1.Image != null)
            {
                Image img = pictureBox1.Image;
                this.pictureBox1.Image = null;
                img.Dispose();
                lbSoLuong = null;
                lbTenSP = null;
                lbKichThuoc = null;
                lbDonGia = null;
            }
            this.Parent.Controls.Remove(this);
        }
    }
}
