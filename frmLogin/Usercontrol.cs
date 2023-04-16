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
        private Image hinhAnh;
        public Usercontrol()
        {
            InitializeComponent();

        }

        public Usercontrol(string tenSP, string soLuong, string donGia, Image hinhAnh)
        {
            this.tenSP = tenSP;
            this.soLuong = soLuong;
            this.donGia = donGia;
            this.hinhAnh = hinhAnh;
        }

        public string TenSP { get => tenSP; set => label1.Text+= value; }
        public string SoLuong { get => soLuong; set => label2.Text += value; }
        public string DonGia { get => donGia; set => label3.Text += value; }
        public Image HinhAnh { get => hinhAnh; set => pictureBox1.Image = value; }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.pictureBox1.Image != null)
            {
                Image img = pictureBox1.Image;
                this.pictureBox1.Image = null;
                img.Dispose();
                label1 = null;
                label2 = null;
                label3 = null;

            }
            this.Parent.Controls.Remove(this);
        }
    }
}
