using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace frmLogin
{
    public partial class frmBillDetail : Form
    {
        Bill getBill;
        HashCode info = new HashCode();
        private int Language = frmlogin.Language;
        public Bill GetBill { get => getBill; set => getBill = value; }
        frmBillManagement frmBillManagement;
        public frmBillDetail(Bill bill, frmBillManagement frmBill)
        {
            if (Language == info.valueDefault)
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("vi");
            else
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en");
            InitializeComponent();
            getBill = bill;
            this.frmBillManagement = frmBill;
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

        private void frmBillDetail_Load(object sender, EventArgs e)
        {
            LoadBillDetail();
        }
        public void LoadBillDetail()
        {
            dtgvBillDetail.DataSource = BillInfoMenuBUS.Instance.GetListBillInfoMenu(getBill.ID);
        }

        private void btnDeleteBillDetail_Click(object sender, EventArgs e)
        {
            if (Language == info.valueDefault)
            {
                if (MessageBox.Show(info.messageDeleteVi,info.titleMessageVi, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (!BillInfoBUS.Instance.CheckBillInfoUsing(txtBillID.Text))
                    {
                        info.firstIndex = info.valueDefault;
                        string productID = info.strDefault;
                        if (dtgvBillDetail.SelectedRows.Count > 0)
                            productID = dtgvBillDetail.SelectedRows[info.valueDefault].Cells[info.firstIndex += 1].Value.ToString();
                        int count = BillInfoBUS.Instance.DeleteBillInfo(txtBillID.Text, productID);

                        if (count > 0)
                        {
                            MessageBox.Show(info.deleteVi, info.titleMessageVi, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.frmBillManagement.LoadBill();
                            frmBillDetail_Load(sender, e);

                        }
                        else
                            MessageBox.Show(info.deleteFailedVi, info.titleMessageVi, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                        MessageBox.Show(info.checkDelVi, info.titleMessageVi, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                if (MessageBox.Show(info.messageDeleteEn,info.titleMessageEn, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (!BillInfoBUS.Instance.CheckBillInfoUsing(txtBillID.Text))
                    {
                        string productID = info.strDefault;
                        info.firstIndex = info.valueDefault;
                        if (dtgvBillDetail.SelectedRows.Count > 0)
                            productID = dtgvBillDetail.SelectedRows[info.valueDefault].Cells[info.firstIndex += 1].Value.ToString();
                        int count = BillInfoBUS.Instance.DeleteBillInfo(txtBillID.Text, productID);

                        if (count > 0)
                        {
                            MessageBox.Show(info.deleteEn, info.titleMessageEn, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.frmBillManagement.LoadBill();
                            frmBillDetail_Load(sender, e);

                        }
                        else
                            MessageBox.Show(info.deleteFailedEn, info.titleMessageEn, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                        else
                        MessageBox.Show(info.checkDelEn, info.titleMessageEn, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void dtgvBillDetail_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgvBillDetail.SelectedRows.Count > 0)
            {
                info.firstIndex = info.valueDefault;
                txtBillID.Text = dtgvBillDetail.SelectedRows[info.valueDefault].Cells[info.firstIndex].Value.ToString();
                txtProductName.Text = dtgvBillDetail.SelectedRows[info.valueDefault].Cells[info.firstIndex+=2].Value.ToString();
                numCount.Value = int.Parse(dtgvBillDetail.SelectedRows[info.valueDefault].Cells[info.firstIndex+=1].Value.ToString());
                txtPrice.Text = dtgvBillDetail.SelectedRows[info.valueDefault].Cells[info.firstIndex+=1].Value.ToString();
                txtTotal.Text = dtgvBillDetail.SelectedRows[info.valueDefault].Cells[info.firstIndex+=1].Value.ToString();
            }
        }

        private void btnDeleteAllBillDetail_Click(object sender, EventArgs e)
        {
            if (Language == info.valueDefault)
            {
                if (MessageBox.Show(info.messageDeleteAllVi,info.titleMessageVi, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (!BillInfoBUS.Instance.CheckBillInfoUsing(getBill.ID))
                    {
                        int count = BillInfoBUS.Instance.DeleteAllBillInfo();

                        if (count > 0)
                        {
                            MessageBox.Show(info.deleteAllVi,info.titleMessageVi, MessageBoxButtons.OK);
                            this.frmBillManagement.LoadBill();
                            frmBillDetail_Load(sender, e);

                        }
                        else
                            MessageBox.Show(info.deleteAllFailedVi,info.titleMessageVi, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                        MessageBox.Show(info.checkDelVi, info.titleMessageEn, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                
                if (MessageBox.Show(info.messageDeleteAllEn,info.titleMessageEn, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (!BillInfoBUS.Instance.CheckBillInfoUsing(getBill.ID))
                    {
                        int count = BillInfoBUS.Instance.DeleteAllBillInfo();

                        if (count > 0)
                        {
                            MessageBox.Show(info.deleteAllEn,info.titleMessageEn, MessageBoxButtons.OK);
                            this.frmBillManagement.LoadBill();
                            frmBillDetail_Load(sender, e);

                        }
                        else
                            MessageBox.Show(info.deleteAllFailedEn,info.titleMessageEn, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                        MessageBox.Show(info.checkDelEn, info.titleMessageEn, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
