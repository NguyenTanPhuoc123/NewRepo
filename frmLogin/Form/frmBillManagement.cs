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
    public partial class frmBillManagement : Form
    {
        public frmBillManagement()
        {
            InitializeComponent();
            dtgvListBill.AutoGenerateColumns = false;
        }

        private void btnShowDetail_Click(object sender, EventArgs e)
        {
            frmBillDetail frm = new frmBillDetail();
            frm.Show();
        }

        private void frmBillManagement_Load(object sender, EventArgs e)
        {
            dtgvListBill.DataSource = BillMenuBUS.Instance.GetListBillMenu();
        }

        private void dtgvListBill_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgvListBill.SelectedRows.Count > 0)
            {
                txtBillID.Text = dtgvListBill.SelectedRows[0].Cells[0].Value.ToString();
                txtDayCheckIn.Text = dtgvListBill.SelectedRows[0].Cells[1].Value.ToString();
                txtEmployeeName.Text = dtgvListBill.SelectedRows[0].Cells[2].Value.ToString();
                txtCustomerName.Text = dtgvListBill.SelectedRows[0].Cells[3].Value.ToString();
                txtTable.Text = dtgvListBill.SelectedRows[0].Cells[5].Value.ToString();
                txtDayCheckOut.Text = dtgvListBill.SelectedRows[0].Cells[6].Value.ToString();
                bool statusCheckOut = bool.Parse(dtgvListBill.SelectedRows[0].Cells[7].Value.ToString());
                if (statusCheckOut == true)
                    cbStatusCheckOut.SelectedIndex = 0;
                else
                    cbStatusCheckOut.SelectedIndex = 1;
            }
        }
    }
}
