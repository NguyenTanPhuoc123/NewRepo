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
    public partial class frmBillDetail : Form
    {
        public frmBillDetail()
        {
            InitializeComponent();
        }

        private void btnExitFomBillDetail_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBillDetailDeleted_Click(object sender, EventArgs e)
        {
            frmRecycleBin frm = new frmRecycleBin();
            frm.Show();
        }
    }
}
