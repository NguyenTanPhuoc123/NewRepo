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
    public partial class frmSellManagement : Form
    {
        

        public frmSellManagement()
        {
            InitializeComponent();
            timer1.Start();
        }
        private void frmSellManagement_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát khỏi phần mềm này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                e.Cancel = true;
                
            }
            

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tsslblTime.Text = DateTime.Now.ToString("hh:mm:ss:tt");
        }

        private void btnStoreManagement_Click(object sender, EventArgs e)
        {
            frmQuanLyAdmin frm = new frmQuanLyAdmin();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void btnLogOff_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExitFormSell_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSelectDish_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            frmSelectDish frm = new frmSelectDish();
            frm.Show();
        }
    }
}
