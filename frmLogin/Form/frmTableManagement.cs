
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
using System.Threading;
using System.Web.Services.Description;
using System.Web.UI.WebControls;
using Microsoft.ReportingServices.Interfaces;

namespace frmLogin
{
    public partial class frmTableManagement : Form
    {
        private int Language = frmlogin.Language;
        HashCode info = new HashCode();

        public frmTableManagement()
        {
            
            if (Language == info.valueDefault)
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("vi");
            else
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en");
            InitializeComponent();

        }

        #region Method
        void LoadFillTableFood()
        {
            cbFillTable.Items.Clear();
            cbFillTable.Items.Add("Tất cả");
            List<Location> listLocation = LocationBUS.Instance.GetListLocation();
            foreach (Location location in listLocation)
            {
                cbFillTable.Items.Add(location.TenViTri);
            }
        }
        #endregion

        #region Events
        private void btnTableDeleted_Click(object sender, EventArgs e)
        {
            frmRecycleBin frm = new frmRecycleBin();
            frm.Show();
        }

        private void btnAddTable_Click(object sender, EventArgs e)
        {
            txtTableID.Text = TableBUS.Instance.GetTableIDMax().ToString();
            txtTableName.Clear();
            cbLocation.SelectedIndex = info.firstIndex;
            btnSaveTable.Enabled = true;
            btnDeleteAllTable.Enabled = false;
            btnDeleteTable.Enabled = false;
            btnEditTable.Enabled = false;
            btnTableDeleted.Enabled = false;
        }

        private void frmTableManagement_Load(object sender, EventArgs e)
        {
            btnEditTable.Enabled = true;
            btnDeleteAllTable.Enabled = true;
            btnDeleteTable.Enabled = true;
            btnSaveTable.Enabled = false;
            btnTableDeleted.Enabled = true;
            
            LoadFillTableFood();
            cbLocation.DataSource = LocationBUS.Instance.GetListLocation();
            cbLocation.ValueMember = "MaViTri";
            cbLocation.DisplayMember = "TenViTri";
            cbFillTable.SelectedIndex = info.firstIndex;
            cbSortTable.SelectedIndex = info.firstIndex;
            LoadTable();
        }
        public void LoadTable()
        {
            dtgvListTable.DataSource = TableMenuBUS.Instance.GetListTableMenu();
        }

        private void dtgvListTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSaveTable.Enabled = false;
            btnEditTable.Enabled = true;
            btnDeleteAllTable.Enabled = true;
            btnDeleteTable.Enabled = true;
            btnTableDeleted.Enabled = true;
            info.firstIndex = info.valueDefault;
            if (dtgvListTable.SelectedRows.Count > info.valueDefault)
            {             
                txtTableID.Text = dtgvListTable.SelectedRows[info.valueDefault].Cells[info.firstIndex].Value.ToString();
                txtTableName.Text = dtgvListTable.SelectedRows[info.valueDefault].Cells[info.firstIndex+=1].Value.ToString();
                cbLocation.SelectedValue = int.Parse(dtgvListTable.SelectedRows[info.valueDefault].Cells[info.firstIndex+=1].Value.ToString());

            }
        }

        private void btnSaveTable_Click(object sender, EventArgs e)
        {
            if (Language == info.valueDefault)
            {
                if (string.IsNullOrEmpty(txtTableName.Text.Trim()))
                {
                    MessageBox.Show(info.eventNullVi,info.titleMessageVi , MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }           
                
                    if (TableBUS.Instance.CheckTableNameExist(txtTableName.Text))
                    {
                        int count = TableBUS.Instance.AddTable(txtTableName.Text, int.Parse(cbLocation.SelectedValue.ToString()));

                    if (count > 0)
                    {
                        MessageBox.Show(info.addVi,info.titleMessageVi, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        frmTableManagement_Load(sender, e);
                    }
                    else
                        MessageBox.Show(info.addFailedVi,info.titleMessageVi, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show(info.MessageCheckExistVi(txtTableName.Text),info.titleMessageVi, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                                
                
            }
            else
            {
                if (string.IsNullOrEmpty(txtTableName.Text.Trim()))
                {
                    MessageBox.Show(info.eventNullEn,info.titleMessageEn, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }               
                    if (TableBUS.Instance.CheckTableNameExist(txtTableName.Text))
                    {
                        int count = TableBUS.Instance.AddTable(txtTableName.Text, int.Parse(cbLocation.SelectedValue.ToString()));

                        if (count > 0)
                            MessageBox.Show(info.addEn,info.titleMessageEn, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show(info.addFailedEn,info.titleMessageEn, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show(info.MessageCheckExistEn(txtTableName.Text),info.titleMessageEn, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }               
      
            }
        }

        private void btnEditTable_Click(object sender, EventArgs e)
        {
            if (Language == info.valueDefault)
            {
                if (MessageBox.Show(info.messageEditVi,info.titleMessageVi, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {

                    if (string.IsNullOrEmpty(txtTableName.Text))
                    {
                        MessageBox.Show(info.eventNullVi,info.titleMessageVi, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                  
                    if (TableBUS.Instance.CheckTableNameExist(txtTableName.Text))
                    {
                        int count = TableBUS.Instance.EditTable(int.Parse(txtTableID.Text), txtTableName.Text, int.Parse(cbLocation.SelectedValue.ToString()));

                        if (count > 0)
                        {
                            MessageBox.Show(info.editVi,info.titleMessageVi, MessageBoxButtons.OK);
                            frmTableManagement_Load(sender, e);
                        }
                        else
                            MessageBox.Show(info.editFailedVi,info.eventNullVi, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show(info.MessageCheckExistVi(txtTableName.Text),info.titleMessageVi, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }                                                         
                    
                }
            }
            else { 
                if (MessageBox.Show(info.messageEditEn,info.titleMessageEn, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {

                    if (string.IsNullOrEmpty(txtTableName.Text))
                    {
                        MessageBox.Show(info.eventNullEn,info.titleMessageEn, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }                   

                    if (TableBUS.Instance.CheckTableNameExist(txtTableName.Text))
                    {
                        int count = TableBUS.Instance.EditTable(int.Parse(txtTableID.Text), txtTableName.Text, int.Parse(cbLocation.SelectedValue.ToString()));

                    if (count > 0)
                    {
                        MessageBox.Show(info.editEn,info.titleMessageEn, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        frmTableManagement_Load(sender, e);
                    }
                    else
                        MessageBox.Show(info.editFailedEn,info.titleMessageEn, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show(info.MessageCheckExistEn(txtTableName.Text),info.titleMessageEn, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                                       
                    
                }
            }
        }

        private void btnDeleteTable_Click(object sender, EventArgs e)
        {
            if (Language == info.valueDefault)
            {
                if (MessageBox.Show(info.messageDeleteVi, info.titleMessageVi, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (TableBUS.Instance.CheckExistDelete(txtTableID.Text))
                    {
                        int count = TableBUS.Instance.DeleteTable(int.Parse(txtTableID.Text));

                        if (count > 0)
                        {
                            MessageBox.Show(info.deleteVi, info.titleMessageVi, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            frmTableManagement_Load(sender, e);
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

                if (MessageBox.Show(info.messageDeleteEn, info.titleMessageEn, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (TableBUS.Instance.CheckExistDelete(txtTableID.Text))
                    {
                        int count = TableBUS.Instance.DeleteTable(int.Parse(txtTableID.Text));

                        if (count > 0)
                        {
                            MessageBox.Show(info.deleteEn,info.titleMessageEn, MessageBoxButtons.OK);
                            frmTableManagement_Load(sender, e);
                        }
                        else
                            MessageBox.Show(info.deleteFailedEn,info.titleMessageEn, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                        MessageBox.Show(info.checkDelEn,info.titleMessageEn, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }                                        
                            
        }

        private void btnDeleteAllTable_Click(object sender, EventArgs e)
        {
            if (Language == info.valueDefault)
            {
                if (MessageBox.Show(info.messageDeleteAllVi,info.titleMessageVi, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {                  
                        if (TableBUS.Instance.CheckExistDelete(txtTableID.Text))
                        {
                            int count = TableBUS.Instance.DeleteAllTable();

                            if (count > 0)
                            {
                                MessageBox.Show(info.deleteAllVi,info.titleMessageVi, MessageBoxButtons.OK);
                                frmTableManagement_Load(sender, e);
                            }
                            else
                                MessageBox.Show(info.deleteAllFailedVi,info.titleMessageVi, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                            MessageBox.Show(info.checkDelVi,info.titleMessageVi, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                                    
            }
            else
            {
                if (MessageBox.Show(info.messageDeleteAllEn,info.titleMessageEn, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {                   
                        if (TableBUS.Instance.CheckExistDelete(txtTableID.Text))
                        {
                            int count = TableBUS.Instance.DeleteAllTable();

                        if (count > 0)
                        {
                            MessageBox.Show(info.deleteAllEn,info.titleMessageEn, MessageBoxButtons.OK);
                            frmTableManagement_Load(sender, e);
                        }
                        else
                            MessageBox.Show(info.deleteAllFailedEn,info.titleMessageEn, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                            MessageBox.Show(info.checkDelEn,info.titleMessageEn, MessageBoxButtons.OK, MessageBoxIcon.Warning);                   
                    
                }
            }
        }

        private void txtSearchTable_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearchTable.Text))
            {
                dtgvListTable.DataSource = TableMenuBUS.Instance.GetListTableMenu();
            }

            dtgvListTable.DataSource = TableMenuBUS.Instance.SearchTableFoodByTableName(txtSearchTable.Text);
        }

        private void cbSortTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSortTable.SelectedIndex == 0 && cbFillTable.SelectedIndex == 0)
            {
                dtgvListTable.DataSource = TableMenuBUS.Instance.GetListTableMenu();
            }
            else if (cbSortTable.SelectedIndex == 1)
                dtgvListTable.DataSource = TableMenuBUS.Instance.SortTableByID(cbFillTable.SelectedIndex);
            else if (cbSortTable.SelectedIndex == 2)
                dtgvListTable.DataSource = TableMenuBUS.Instance.SortTableByIDDecrease(cbFillTable.SelectedIndex);
            else if (cbSortTable.SelectedIndex == 3)
                dtgvListTable.DataSource = TableMenuBUS.Instance.SortTableByLocationID(cbFillTable.SelectedIndex);
            else
                dtgvListTable.DataSource = TableMenuBUS.Instance.SortTableByLocationIDDecrease(cbFillTable.SelectedIndex);

        }

        private void cbFillTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFillTable.SelectedIndex == 0 && cbSortTable.SelectedIndex == 0)
            {
                dtgvListTable.DataSource = TableMenuBUS.Instance.GetListTableMenu();
            }

            else if (cbFillTable.SelectedIndex == 0 && cbSortTable.SelectedIndex != 0)
            {
                if (cbSortTable.SelectedIndex == 1)
                    dtgvListTable.DataSource = TableMenuBUS.Instance.SortTableByID(0);
                else if (cbSortTable.SelectedIndex == 2)
                    dtgvListTable.DataSource = TableMenuBUS.Instance.SortTableByIDDecrease(0);
                else if (cbSortTable.SelectedIndex == 3)
                    dtgvListTable.DataSource = TableMenuBUS.Instance.SortTableByLocationID(0);
                else
                    dtgvListTable.DataSource = TableMenuBUS.Instance.SortTableByLocationIDDecrease(0);
            }

            else
            {
                for (int i = 1; i <= cbFillTable.Items.Count; i++)
                {
                    if (cbFillTable.SelectedIndex == i)
                    {
                        if (cbSortTable.SelectedIndex == 0)
                            dtgvListTable.DataSource = TableMenuBUS.Instance.FillListTableMenu(cbFillTable.SelectedIndex);
                        else if (cbSortTable.SelectedIndex == 1)
                            dtgvListTable.DataSource = TableMenuBUS.Instance.SortTableByID(cbFillTable.SelectedIndex);
                        else if (cbSortTable.SelectedIndex == 2)
                            dtgvListTable.DataSource = TableMenuBUS.Instance.SortTableByIDDecrease(cbFillTable.SelectedIndex);
                        else if (cbSortTable.SelectedIndex == 3)
                            dtgvListTable.DataSource = TableMenuBUS.Instance.SortTableByLocationID(cbFillTable.SelectedIndex);
                        else if (cbSortTable.SelectedIndex == 4)
                            dtgvListTable.DataSource = TableMenuBUS.Instance.SortTableByLocationIDDecrease(cbFillTable.SelectedIndex);
                    }
                }
            }

        }

        private void btnSearchTable_Click(object sender, EventArgs e)
        {
            dtgvListTable.DataSource = TableMenuBUS.Instance.SearchTableFoodByTableName(txtSearchTable.Text);
        }
        #endregion



    }
}
