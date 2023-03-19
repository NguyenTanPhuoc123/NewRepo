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
    public partial class frmProductManagement : Form
    {
        public frmProductManagement()
        {   
            InitializeComponent();
            cbStyleView.Text = "LargeIcon";
            cbSort.Text = "Tất cả";
            cbArrage.Text = "Theo mã sản phẩm";
            timer1.Start();
        }

        private void cbStyleView_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolsslTime.Text = DateTime.Now.ToString("hh:mm:ss");
        }
    }
}
