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
        string username = null;
        string password = null;
        public frmSellManagement()
        {
            InitializeComponent();
            timer1.Start();
       
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
            //string sql = String.Format("select count(*) from taikhoan where loaitaikhoan = 2 and tendangnhap = {0} and matkhau = {1}",username,password);
            //int dem = DataProvider.ExecuteScalarCommand(sql, null);
            //if(dem > 0)
            //{
                frmQuanLyAdmin frm = new frmQuanLyAdmin();
                this.Hide();
                frm.ShowDialog();
                this.Show();
            //}
            //else
            //{
            //    MessageBox.Show("Bạn ko đủ đk");
            //    return;
            //}
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
            frmSetting frm = new frmSetting();
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

        public void ChonTaiKhoan(string tenTk, string matKhau)
        {
            username = tenTk;
            password = matKhau;
        }

        private void tstlblPosition_Click(object sender, EventArgs e)
        {
            
        }

        private void frmSellManagement_Load(object sender, EventArgs e)
        {
            int chucVu = (sender as NhanVien).MaChucVu;
            
            if(chucVu == 2)
            {
                tstlblPosition.Text = "Quản lý";
            }
            else
            {
                tstlblPosition.Text = "Bán hàng";
            }
        }
    }
}
