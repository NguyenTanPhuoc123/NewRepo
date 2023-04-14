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
        public Usercontrol()
        {
            InitializeComponent();

        }

        public string TenSP { get => tenSP; set => label1.Text+= value; }
        public string SoLuong { get => soLuong; set => label2.Text += value; }
        public string DonGia { get => donGia; set => label3.Text += value; }
    }
}
