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
using DTO;
using BUS;

namespace frmLogin
{
    public partial class frmRecycleBinCategory : Form
    {
        public frmRecycleBinCategory()
        {
            InitializeComponent();
        }

        private void frmRecycleBinCategory_Load(object sender, EventArgs e)
        {
            LoadLocationDeleted();
        }

        #region Location
            public void LoadLocationDeleted()
            {
            txtLocationID.Clear();
            txtLocationName.Clear();
            dtgvListLocationDeleted.DataSource = LocationBUS.Instance.GetListLocation();
            }
        #endregion

        private void btnExitFormRecycleBinCategory_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
