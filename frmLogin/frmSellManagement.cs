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

namespace frmLogin
{
    public partial class frmSellManagement : Form
    {
        private Account loginAccount;
        public frmSellManagement(Account acc)
        {
            InitializeComponent();
            this.loginAccount = acc;
            timer1.Start();
       
        }

        public  Account LoginAccount
        {
            get {  return this.loginAccount; }
            private set { this.loginAccount = value;}
        }
        private void frmSellManagement_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát khỏi phần mềm này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                e.Cancel = true;
                
            }
            

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
                MessageBox.Show("Bạn không có phận sự ở đây, cút!!!", "Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
        }


        private void btnExitFormSell_Click(object sender, EventArgs e)
        {
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

        public int GetTypeAccount()
        {
            return loginAccount.TypeAccount;
        }

        private void frmSellManagement_Load(object sender, EventArgs e)
        {
            tstlblPosition.Text = GetTypeAccountName() + " : ";
            tsslblName.Text = GetEmployeeName();
        }

        public string GetTypeAccountName()
        {
            TypeAccount typeAccount = TypeAccountDAF.Instance.GetTypeAccountForTypeAccountID(loginAccount.TypeAccount);
            return typeAccount.TenLoai;
        }

        public string GetEmployeeName()
        {
            Employee employee = EmployeeDAF.Instance.GetEmployeeByEmployeeID(loginAccount.EmployeeID);
            return employee.TenNV;
        }
    }
}
