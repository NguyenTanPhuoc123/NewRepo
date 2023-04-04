using frmLogin.Data_Access_Layer;
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
    public partial class frmAccountManagement : Form
    {
        public frmAccountManagement()
        {
            InitializeComponent();
        }

        private void frmAccountManagement_Load(object sender, EventArgs e)
        {
            string query = "select * from taikhoan";
            dtgvListAccount.DataSource =  DataProvider.ExcecuteSelectCommand(query, null);
        }
    }
}
