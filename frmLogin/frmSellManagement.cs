using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace frmLogin
{
    public partial class frmSellManagement : Form
    {
        private static int tableID = 0;
        private Account loginAccount;
        private static int manv;
        private static float total;
        private static string tennv;
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

            if (GetTypeAccount() == 1)
            {
                frmQuanLyAdmin frm = new frmQuanLyAdmin();
                this.Hide();
                frm.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Bạn không có phận sự ở đây, cút!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }


        private void btnExitFormSell_Click(object sender, EventArgs e)
        {   
            if(MessageBox.Show("Bạn muốn thoát khỏi phần mềm này?","Thông báo",MessageBoxButtons.OKCancel,MessageBoxIcon.Question)==DialogResult.OK)
                this.Close();
        }

        private void btnSelectDish_Click(object sender, EventArgs e)
        {
            if (GetTableID() == 0)
            {
                MessageBox.Show("Bạn chưa chọn bàn để chọn món", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void btnSetting_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            frmSetting frm = new frmSetting(loginAccount);
            frm.Show();
            LoadBackColorMDI();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (GetTableID() == 0)
            {
                MessageBox.Show("Bạn chưa chọn bàn để chọn món", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                this.IsMdiContainer = true;
                frmPay frm = new frmPay();
                frm.Show();
                LoadBackColorMDI();
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void frmSellManagement_Load(object sender, EventArgs e)
        {
            tstlblPosition.Text = GetTypeAccountName() + " : ";
            tsslblName.Text = GetEmployeeName();
            cbLocationTable.DataSource = LocationBUS.Instance.GetListLocation();
            cbLocationTable.DisplayMember = "TenViTri";
            cbLocationTable.ValueMember = "MaViTri";
            LoadTableNull();
        }
        public void LoadTableNull()
        {
            cbChangeTable.DataSource = TableBUS.Instance.GetListTablesTrong();
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
                    mdiCtrl.BackColor = System.Drawing.Color.Gainsboro;
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
                Button btnTable = new Button() { Width = 150, Height = 150 };               
                string tableDisplay = item.TenBan + Environment.NewLine + "<" + item.TrangThai + ">";
                btnTable.Text = tableDisplay;
                btnTable.Click += btnTable_Click;
                btnTable.Tag = item;
                if (item.TrangThai == "Trống")
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
            if (lstvMenuDish.SelectedItems.Count > 0)
            {

                int index = lstvMenuDish.SelectedItems[0].Index;
                ListViewItem item = lstvMenuDish.SelectedItems[0];
                string mahd = BillBUS.Instance.HDID(tableID);
                string masp = ProductBUS.Instance.ProductID(item.Text);
                if (DialogResult.Yes == MessageBox.Show("Bạn có muốn xóa món này", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    int count = BillInfoBUS.Instance.DeleteBillInfo(mahd, masp);
                    if (count > 0)
                    {
                        MessageBox.Show("Xóa món ăn thành công", "Thông báo", MessageBoxButtons.OK);
                        lstvMenuDish.Items.RemoveAt(index);
                    }
                    else
                        MessageBox.Show("Xóa món ăn thất bại", "Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
            }
            else
                MessageBox.Show("Bạn chưa chọn món để xóa","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);

        }
        private void btnChangeTable_Click(object sender, EventArgs e)
        {
            int tableid = GetTableID();
            string tablenew =cbChangeTable.SelectedValue.ToString();
            if (BillBUS.Instance.UpdateBill(tableid, tablenew))
            {
                MessageBox.Show("Chuyển bàn thành công");
                TableBUS.Instance.UpdateTableNull(tableid);
                TableBUS.Instance.UpdateTable(tablenew);
                LoadTableNull();
                GetListTableByLocationID(1);
            }
            else
                MessageBox.Show("Chuyen ban that bai");
        }


    }
}
