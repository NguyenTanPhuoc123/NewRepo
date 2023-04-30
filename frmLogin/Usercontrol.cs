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
        private string kichThuocName;
        private Image hinhAnh;
        public Usercontrol()
        {
            InitializeComponent();

        }

        public string TenSP { get => tenSP; set => tenSP = value ; }
        public string SoLuong { get => soLuong; set => soLuong = value; }
        public string DonGia { get => donGia; set => donGia = value; }
        public int KichThuoc { get => Kichthuoc; set => Kichthuoc = value; }
        public string KichThuocName { get => kichThuocName; set => kichThuocName = value; }
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
                lbKichThuoc = null;
                lbDonGia = null;
            }
            this.Parent.Controls.Remove(this);
        }

        private void Usercontrol_Load(object sender, EventArgs e)
        {
            lbTenSP.Text = TenSP;
            lbDonGia.Text = DonGia;
            lbSoLuong.Text = SoLuong;
            lbKichThuoc.Text = KichThuocName;
            pictureBox1.Image = HinhAnh;
        }
    }
}
