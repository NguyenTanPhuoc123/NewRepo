
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
        public frmTableManagement()
        {
            if (Language == 0)
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
            cbLocation.SelectedIndex = 0;
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
            cbFillTable.SelectedIndex = 0;
            cbSortTable.SelectedIndex = 0;
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

            if (dtgvListTable.SelectedRows.Count > 0)
            {
                txtTableID.Text = dtgvListTable.SelectedRows[0].Cells[0].Value.ToString();
                txtTableName.Text = dtgvListTable.SelectedRows[0].Cells[1].Value.ToString();
                cbLocation.SelectedValue = int.Parse(dtgvListTable.SelectedRows[0].Cells[2].Value.ToString());

            }
        }

        private void btnSaveTable_Click(object sender, EventArgs e)
        {
            if (Language == 0)
            {
                if (string.IsNullOrEmpty(txtTableName.Text.Trim()))
                {
                    MessageBox.Show("Vui lòng nhập tên bàn ăn vào ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                try
                {
                    if (TableBUS.Instance.checkTableExist(txtTableName.Text))
                    {
                        int count = TableBUS.Instance.AddTable(txtTableName.Text, int.Parse(cbLocation.SelectedValue.ToString()));

                        if (count > 0)
                            MessageBox.Show("Thêm bàn ăn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show("Thêm bàn ăn thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("Tên bàn ăn đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                frmTableManagement_Load(sender, e);
            }
            else
            {
                if (string.IsNullOrEmpty(txtTableName.Text.Trim()))
                {
                    MessageBox.Show("Please enter the table name in ", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                try
                {
                    if (TableBUS.Instance.checkTableExist(txtTableName.Text))
                    {
                        int count = TableBUS.Instance.AddTable(txtTableName.Text, int.Parse(cbLocation.SelectedValue.ToString()));

                        if (count > 0)
                            MessageBox.Show("Successfully added dining table", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show("More failed dining table", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("The name of the table already exists", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                frmTableManagement_Load(sender, e);
            }
        }

        private void btnEditTable_Click(object sender, EventArgs e)
        {
            if (Language == 0)
            {
                if (MessageBox.Show("Bạn muốn sửa bàn này chứ ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {

                    if (string.IsNullOrEmpty(txtTableName.Text))
                    {
                        MessageBox.Show("Vui lòng nhập tên bàn ăn vào ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    try
                    {
                        if (TableBUS.Instance.checkTableExist(txtTableName.Text))
                        {
                            int count = TableBUS.Instance.EditTable(int.Parse(txtTableID.Text), txtTableName.Text, int.Parse(cbLocation.SelectedValue.ToString()));

                            if (count > 0)
                                MessageBox.Show("Sửa bàn ăn thành công ", "Thông báo", MessageBoxButtons.OK);
                            else
                                MessageBox.Show("Sửa bàn ăn thất bại ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            MessageBox.Show("Tên bàn đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    frmTableManagement_Load(sender, e);
                }
            }
            else
            {
                if (MessageBox.Show("Do you want to fix this table?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {

                    if (string.IsNullOrEmpty(txtTableName.Text))
                    {
                        MessageBox.Show("Please enter table name", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    try
                    {

                        if (TableBUS.Instance.checkTableExist(txtTableName.Text))
                        {
                            int count = TableBUS.Instance.EditTable(int.Parse(txtTableID.Text), txtTableName.Text, int.Parse(cbLocation.SelectedValue.ToString()));

                            if (count > 0)
                                MessageBox.Show("Successfully repaired the dining table", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            else
                                MessageBox.Show("Fixing the dining table failed", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            MessageBox.Show("The name of the table already exists", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    frmTableManagement_Load(sender, e);
                }
            }
        }

        private void btnDeleteTable_Click(object sender, EventArgs e)
        {
            if (Language == 0)
            {
                if (MessageBox.Show("Bạn muốn xóa bàn này chứ ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (TableBUS.Instance.checkExistDelete(txtTableID.Text))
                    {
                        int count = TableBUS.Instance.DeleteTable(int.Parse(txtTableID.Text));

                        if (count > 0)
                            MessageBox.Show("Xóa bàn ăn thành công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show("Xóa bàn ăn thất bại ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                        MessageBox.Show("Xóa bàn ăn thất bại ,ban ăn hiện tại đang có khách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    frmTableManagement_Load(sender, e);
                }
            }
            else
            {

                if (MessageBox.Show("Do you want to delete this table?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    try
                    {
                        if (TableBUS.Instance.checkExistDelete(txtTableID.Text))
                        {
                            int count = TableBUS.Instance.DeleteTable(int.Parse(txtTableID.Text));

                            if (count > 0)
                                MessageBox.Show("Delete the dining table successfully", "Notification", MessageBoxButtons.OK);
                            else
                                MessageBox.Show("Delete the dining table failed", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                            MessageBox.Show("Delete the dining table failed, the dining table is currently having guests", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    frmTableManagement_Load(sender, e);
                }
            }
        }

        private void btnDeleteAllTable_Click(object sender, EventArgs e)
        {
            if (Language == 0)
            {
                if (MessageBox.Show("Bạn thật sự muốn xóa tất cả các bàn  chứ ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    try
                    {
                        if (TableBUS.Instance.checkExistDelete(txtTableID.Text))
                        {
                            int count = TableBUS.Instance.DeleteAllTable();

                            if (count > 0)
                                MessageBox.Show("Xóa bàn ăn thành công ", "Thông báo", MessageBoxButtons.OK);
                            else
                                MessageBox.Show("Xóa bàn ăn thất bại ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                            MessageBox.Show("Xóa bàn ăn thất bại ,ban ăn hiện tại đang có khách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    frmTableManagement_Load(sender, e);
                }
            }
            else
            {
                if (MessageBox.Show("Do you really want to delete all the tables?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    try
                    {
                        if (TableBUS.Instance.checkExistDelete(txtTableID.Text))
                        {
                            int count = TableBUS.Instance.DeleteAllTable();

                            if (count > 0)
                                MessageBox.Show("Delete the dining table successfully", "Notification", MessageBoxButtons.OK);
                            else
                                MessageBox.Show("Delete the dining table failed", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                            MessageBox.Show("Delete the dining table failed, the dining table is currently having guests", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    frmTableManagement_Load(sender, e);
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
