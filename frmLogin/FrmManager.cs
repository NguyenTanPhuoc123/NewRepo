using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmLogin
{
    public partial class FrmManager : Form
    {
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;

        public FrmManager()
        {
            InitializeComponent();
            random = new Random();
        }
       
        

        private void FrmManager_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát khỏi phần mềm quản lý này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                e.Cancel = true;
        }

        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.colorList.Count);
            while (tempIndex == index)
            {
                index=random.Next(ThemeColor.colorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.colorList[index];
            return ColorTranslator.FromHtml(color);
        }

        private void ActiveButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button) btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void DisableButton()
        {
            foreach(Control previousButton in panelMenu.Controls)
            {
                if (previousButton.GetType() == typeof(Button))
                {
                    previousButton.BackColor = Color.FromArgb(51,51,76);
                    previousButton.ForeColor = Color.Gainsboro;
                    new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

      

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActiveButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelMain.Controls.Add(childForm);
            this.panelMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;
        }

        private void btnMaximumized_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void btnMinimumized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnQuanLySanPham_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QuanLyDoAnThucUong(),sender);
            lblTitle.Text = btnQuanLySanPham.Text;
            ActiveButton(sender);
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ThongKe(), sender);
            lblTitle.Text = btnThongKe.Text;
            ActiveButton(sender);
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QuanLyTaiKhoan(), sender);
            lblTitle.Text = btnAccount.Text;
            ActiveButton(sender);
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QuanLyNhanVien(), sender);
            lblTitle.Text = btnNhanVien.Text;
            ActiveButton(sender);
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CaiDat(), sender);
            lblTitle.Text = btnSetting.Text;
            ActiveButton(sender);
        }
    }
}
