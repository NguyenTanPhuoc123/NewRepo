using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using frmLogin.Data_Access_Layer;

namespace frmLogin
{
    public partial class frmEmployeeManager : Form
    {
        public frmEmployeeManager()
        {
            InitializeComponent();
            string query = "Select * from NhanVien";
            dtgvListEmployee.DataSource = DataProvider.ExcecuteSelectCommand(query, null);

        }

        
    }
}
