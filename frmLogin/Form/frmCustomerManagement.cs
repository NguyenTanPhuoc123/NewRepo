using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace frmLogin
{
    public partial class frmCustomerManagement : Form
    {
        public frmCustomerManagement()
        {
            InitializeComponent();
        }

        private void btnCustomerDeleted_Click(object sender, EventArgs e)
        {
            frmRecycleBin frm = new frmRecycleBin();
            frm.Show();
        }

        private void frmCustomerManagement_Load(object sender, EventArgs e)
        {
            ResetInfo();
            dtgvListCustomer.DataSource = CustomerMenuBUS.Instance.GetListCustomerMenu();
        }

        public void ResetInfo()
        {
            txtCustomerID.Clear();
            txtCustomerName.Clear();
            txtCustomerNumberPhone.Clear();
            txtSearchCustomer.Clear();
            cbTypeCustomer.SelectedIndex = 0;
            //cbFillCustomer.SelectedIndex = 0;
            //cbSortCustomer.SelectedIndex = 0;
            radMale.Checked = true;
            btnSaveCustomer.Enabled = false;
            btnEditCustomer.Enabled = true;
            btnDeleteCustomer.Enabled = true;
            btnDeleteAllCustomer.Enabled = true;
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            txtCustomerID.Text = CustomerBUS.Instance.GetListAllCustomer().Count.ToString();
            txtCustomerName.Clear();
            txtCustomerNumberPhone.Clear();
            txtSearchCustomer.Clear();
            btnSaveCustomer.Enabled = true;
            btnEditCustomer.Enabled = false;
            btnDeleteCustomer.Enabled = false;
            btnDeleteAllCustomer.Enabled = false;
        }


    }
}
