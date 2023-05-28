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
using AForge;
using BUS;
using DTO;
using Microsoft.ReportingServices.Interfaces;

namespace frmLogin
{
    public partial class frmSellManagement : Form
    {
        private int Language =  frmlogin.Language;
        private static int tableID = 0;
        private Account loginAccount;
        private static int manv;
        private static float total;
        private static string tennv;
        HashCode info = new HashCode();
        public Account LoginAccount
        {
            get { return this.loginAccount; }
            private set { this.loginAccount = value; }
        }

        public static int GetMANV()
        {
            return manv;
        }

        public static void SetMANV(int value)
        {
            manv = value;
        }

        public static int GetTableID()
        {
            return tableID;
        }

        public static void SetTableID(int value)
        {
            tableID = value;
        }

        public static string GetTENNV()
        {
            return tennv;
        }

        public static void SetTENNV(string value)
        {
            tennv = value;
        }

        public static float GetTotal()
        {
            return total;
        }

        public static void SetTotal(float value)
        {
            total = value;
        }
        public frmSellManagement(Account acc)
        {
            if (Language == 0)
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("vi");
            else
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en");
            InitializeComponent();
            this.loginAccount = acc;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tsslblTime.Text = DateTime.Now.ToString("hh:mm:ss:tt");
        }

        private void btnStoreManagement_Click(object sender, EventArgs e)
        {
            if (Language == 0)
            {
                if (GetTypeAccount() == 1)
                {
                    frmQuanLyAdmin frm = new frmQuanLyAdmin(this);
                    this.Hide();
                    frm.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Bạn không đủ quyền vào quản lý",info.titleMessageVi, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else
            {
                if (GetTypeAccount() == 1)
                {
                    frmQuanLyAdmin frm = new frmQuanLyAdmin(this);
                    this.Hide();
                    frm.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("You do not have the right to manage",info.titleMessageEn, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
        }


        private void btnExitFormSell_Click(object sender, EventArgs e)
        {
            if (Language == 0)
            {
                if (MessageBox.Show(info.exitVi,info.titleMessageVi, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    this.Close();
            }
            else
            {
                if (MessageBox.Show(info.exitEn, info.titleMessageEn, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    this.Close();
            }
        }

        private void btnSelectDish_Click(object sender, EventArgs e)
        {
            if (Language == info.valueDefault)
            {
                if (GetTableID() == info.valueDefault)
                {
                    MessageBox.Show(info.selectTableVi,info.titleMessageVi, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    this.IsMdiContainer = true;
                    frmSelectDish frm = new frmSelectDish(this);
                    frm.Show();
                    LoadBackColorMDI();
                }
            }
            else
            {
                if (GetTableID() == info.valueDefault)
                {
                    MessageBox.Show(info.selectTableEn,info.titleMessageEn, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    this.IsMdiContainer = true;
                    frmSelectDish frm = new frmSelectDish(this);
                    frm.Show();
                    LoadBackColorMDI();
                }
            }
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            frmSetting frm = new frmSetting(loginAccount,this);
            frm.Show();
            LoadBackColorMDI();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (Language == info.valueDefault)
            {
                if (GetTableID() == info.valueDefault)
                {
                    MessageBox.Show(info.selectTablePayVi,info.titleMessageVi, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    BillMenu billMenu = BillMenuBUS.Instance.GetBillMenuByTableID(frmSellManagement.GetTableID());
                    int count = BillBUS.Instance.Pay(billMenu.ID, manv);
                    this.IsMdiContainer = true;
                    frmPay frm = new frmPay(this);
                    frm.Show();
                    LoadBackColorMDI();
                }
            }
            else
            {
                if (GetTableID() == info.valueDefault)
                {
                    MessageBox.Show(info.selectTablePayEn,info.titleMessageEn, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    BillMenu billMenu = BillMenuBUS.Instance.GetBillMenuByTableID(frmSellManagement.GetTableID());
                    int count = BillBUS.Instance.Pay(billMenu.ID, manv);
                    this.IsMdiContainer = true;
                    frmPay frm = new frmPay(this);
                    frm.Show();
                    LoadBackColorMDI();
                }
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        

        public void frmSellManagement_Load(object sender, EventArgs e)
        {
            tstlblPosition.Text = GetTypeAccountName() + " : ";
            tsslblName.Text = GetEmployeeName();
            cbLocationTable.DataSource = LocationBUS.Instance.GetListLocation();
            cbLocationTable.DisplayMember = "TenViTri";
            cbLocationTable.ValueMember = "MaViTri";
            LoadTable();
        }
        public void LoadTable()
        {
            cbChangeTable.DataSource = TableBUS.Instance.GetListTables();
            cbChangeTable.DisplayMember = "TenBan";
            cbChangeTable.ValueMember = "MaBanAn";
        }
        private void btnTable_Click(object sender, EventArgs e)
        {
            int tableID = ((sender as Button).Tag as Table).MaBanAn;
            SetTableID(tableID);
            ShowBill(tableID);
        }
        #region Method

        public void LoadBackColorMDI()
        {
            MdiClient mdiCtrl;
            foreach (Control ctrl in this.Controls)
            {
                try
                {
                    mdiCtrl = (MdiClient)ctrl;
                    mdiCtrl.BackColor = System.Drawing.Color.White;
                }
                catch (InvalidCastException ex)
                {

                }
            }
        }

        public string GetTypeAccountName()
            {
                TypeAccount typeAccount = TypeAccountBUS.Instance.GetTypeAccountForTypeAccountID(loginAccount.TypeAccount);
                return typeAccount.TenLoai;
            }

        public string GetEmployeeName()
        {
            Employee employee = EmployeeBUS.Instance.GetEmployeeByEmployeeID(loginAccount.EmployeeID);
            SetMANV(loginAccount.EmployeeID);
            SetTENNV(employee.TenNV);
            return employee.TenNV;
        }

        public int GetTypeAccount()
        {
            return loginAccount.TypeAccount;
        }
        
        public void GetListTableByLocationID(int id)
        {
            flpTable.Controls.Clear();
            List<Table> listTable = new List<Table>();
            listTable = TableBUS.Instance.GetListTableByLocationID(id);

            foreach (Table item in listTable)
            {
                Button btnTable = new Button() { Width = info.sizeWidth, Height = info.sizeHeight};               
                string tableDisplay = info.DisplayTable(item.TenBan,item.TrangThai);
                btnTable.Text = tableDisplay;
                btnTable.Click += btnTable_Click;
                btnTable.Tag = item;
                if (item.TrangThai == info.status_table_null)
                    btnTable.BackColor = Color.GreenYellow;
                else
                    btnTable.BackColor = Color.Red;
                flpTable.Controls.Add(btnTable);
            }
        }

        public void ShowBill(int tableID)
        {
            lstvMenuDish.Items.Clear();
            float total = 0;

            List<MenuDish> listMenuDish = MenuDishBUS.Instance.GetListMenuDishByTableID(tableID);
            foreach(MenuDish menuDish in listMenuDish)
            {
                ListViewItem item = new ListViewItem(menuDish.DishName);
                item.SubItems.Add(menuDish.Count.ToString());
                item.SubItems.Add(menuDish.Price.ToString());
                item.SubItems.Add(menuDish.TotalPrice.ToString());                
                total += menuDish.TotalPrice;
                lstvMenuDish.Items.Add(item);
            }
            CultureInfo culture = new CultureInfo("vi-VN");
            lblToltalPrice.Text = total.ToString("c",culture);
            SetTotal(total);
        }
        #endregion
        private void cbLocationTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null)
                return;
            Location selected = cb.SelectedItem as Location;
            id = selected.MaViTri;
            GetListTableByLocationID(id);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (Language == info.valueDefault)
            {
                if (lstvMenuDish.SelectedItems.Count > info.valueDefault)
                {

                    int index = lstvMenuDish.SelectedItems[info.valueDefault].Index;
                    ListViewItem item = lstvMenuDish.SelectedItems[info.valueDefault];
                    string mahd = BillBUS.Instance.HDID(tableID);
                    string masp = ProductBUS.Instance.ProductID(item.Text);                   
                        int count = BillInfoBUS.Instance.DeleteBillInfo(mahd, masp);
                        if (count > info.valueDefault)
                        {                            
                            lstvMenuDish.Items.RemoveAt(index);
                        }                        
                    
                }
                else
                    MessageBox.Show(info.messDelDishSelectedVi,info.titleMessageVi, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (lstvMenuDish.SelectedItems.Count > 0)
                {

                    int index = lstvMenuDish.SelectedItems[info.valueDefault].Index;
                    ListViewItem item = lstvMenuDish.SelectedItems[info.valueDefault];
                    string mahd = BillBUS.Instance.HDID(tableID);
                    string masp = ProductBUS.Instance.ProductID(item.Text);                    
                        int count = BillInfoBUS.Instance.DeleteBillInfo(mahd, masp);
                        if (count > 0)
                        {                     
                            lstvMenuDish.Items.RemoveAt(index);
                        }                   
                    
                }
                else
                    MessageBox.Show(info.messDelDishSelectedEn,info.titleMessageEn, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        private void btnChangeTable_Click(object sender, EventArgs e)
        {
            if (Language == info.valueDefault)
            {
                int tableIdOld = GetTableID();
                int tableIdNew = int.Parse(cbChangeTable.SelectedValue.ToString());
                 
                if (TableBUS.Instance.SwitchTable(tableIdOld,tableIdNew)>0)
                {
                    MessageBox.Show(info.changeTableVi,info.titleMessageVi,MessageBoxButtons.OK,MessageBoxIcon.Information);
                    TableBUS.Instance.UpdateStatusTable(tableIdOld);
                    TableBUS.Instance.UpdateStatusTable(tableIdNew);
                    LoadTable();
                    GetListTableByLocationID(1);
                }
                else
                    MessageBox.Show(info.changeTableFailedVi,info.titleMessageVi, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int tableIdOld = GetTableID();
                int tableIdNew = int.Parse(cbChangeTable.SelectedValue.ToString());
                if (TableBUS.Instance.SwitchTable(tableIdOld,tableIdNew)>0)
                {
                    MessageBox.Show(info.changeTableEn,info.titleMessageEn, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TableBUS.Instance.UpdateStatusTable(tableIdOld);
                    TableBUS.Instance.UpdateStatusTable(tableIdNew);
                    LoadTable();
                    GetListTableByLocationID(1);
                }
                else
                    MessageBox.Show(info.changeTableFailedEn,info.titleMessageEn, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSelectDish_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                btnSelectDish_Click(sender, e);
            }
        }

        private void btnStoreManagement_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                btnStoreManagement_Click(sender, e);
            }
        }

        private void btnPay_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
            {
                btnPay_Click(sender, e);
            }
        }
    }
}
