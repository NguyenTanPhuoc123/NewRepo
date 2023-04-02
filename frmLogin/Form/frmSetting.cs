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
    public partial class frmSetting : Form
    {
        public frmSetting()
        {
            InitializeComponent();
            guna2GroupBox2.Visible = false;
            guna2ComboBox1.SelectedIndex = 0;
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            guna2GroupBox2.Visible = false;
            guna2GroupBox1.Visible = true;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            guna2GroupBox2.Visible = true;
            guna2GroupBox1.Visible = false;
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            frmSellManagement frm = new frmSellManagement();
            this.Close();
            frm.Close();
            
        }
    }
}
