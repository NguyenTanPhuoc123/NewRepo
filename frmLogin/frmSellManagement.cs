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
using frmLogin.Data_Tranfer_Object;
using BUS;
using DTO;

namespace frmLogin
{
    public partial class frmSellManagement : Form
    {
        private Account loginAccount;

        public Account LoginAccount
        {
            get { return this.loginAccount; }
            private set { this.loginAccount = value; }
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
            this.IsMdiContainer = true;
            frmSelectDish frm = new frmSelectDish();
            frm.Show();
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            frmSetting frm = new frmSetting(loginAccount);
            frm.Show();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            frmPay frm = new frmPay();
            frm.Show();
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
            
        }

        public void ShowBill(int nTableId)
        {
            List<MenuTable> menus = MenuDAF.Instance.GetListMenu(nTableId);
            for(int i = 0; i < menus.Count; i++)
            {
                ListViewItem lsvItem = new ListViewItem();
            }
        }
        private void btnTable_Click(object sender, EventArgs e)
        {
            int nTableId = ((sender as Button).Tag as Table).MaBanAn;
          
        }
        #region Method
       
        public string GetTypeAccountName()
            {
                TypeAccount typeAccount = TypeAccountBUS.Instance.GetTypeAccountForTypeAccountID(loginAccount.TypeAccount);
                return typeAccount.TenLoai;
            }

        public string GetEmployeeName()
            {
                Employee employee = EmployeeBUS.Instance.GetEmployeeByEmployeeID(loginAccount.EmployeeID);
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

        
    }
}
