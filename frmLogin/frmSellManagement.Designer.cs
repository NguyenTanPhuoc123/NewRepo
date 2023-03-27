
namespace frmLogin
{
    partial class frmSellManagement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinCáNhânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.flpTable = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.cbSortTable = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbLocationTable = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbChangeTable = new System.Windows.Forms.ComboBox();
            this.numSale = new System.Windows.Forms.NumericUpDown();
            this.btnCheckPay = new System.Windows.Forms.Button();
            this.btnSale = new System.Windows.Forms.Button();
            this.btnChangeTable = new System.Windows.Forms.Button();
            this.lstBill = new System.Windows.Forms.ListView();
            this.numQuantity = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddDish = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem,
            this.thôngTinTàiKhoảnToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1292, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.adminToolStripMenuItem.Text = "Admin";
            this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // thôngTinTàiKhoảnToolStripMenuItem
            // 
            this.thôngTinTàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinCáNhânToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.thôngTinTàiKhoảnToolStripMenuItem.Name = "thôngTinTàiKhoảnToolStripMenuItem";
            this.thôngTinTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(151, 24);
            this.thôngTinTàiKhoảnToolStripMenuItem.Text = "Thông tin tài khoản";
            // 
            // thôngTinCáNhânToolStripMenuItem
            // 
            this.thôngTinCáNhânToolStripMenuItem.Name = "thôngTinCáNhânToolStripMenuItem";
            this.thôngTinCáNhânToolStripMenuItem.Size = new System.Drawing.Size(210, 26);
            this.thôngTinCáNhânToolStripMenuItem.Text = "Thông tin cá nhân";
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // flpTable
            // 
            this.flpTable.Location = new System.Drawing.Point(12, 166);
            this.flpTable.Name = "flpTable";
            this.flpTable.Size = new System.Drawing.Size(682, 428);
            this.flpTable.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Lọc:";
            // 
            // cbSortTable
            // 
            this.cbSortTable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSortTable.FormattingEnabled = true;
            this.cbSortTable.Items.AddRange(new object[] {
            "Tất cả",
            "Bàn trống",
            "Bàn có người"});
            this.cbSortTable.Location = new System.Drawing.Point(55, 130);
            this.cbSortTable.Name = "cbSortTable";
            this.cbSortTable.Size = new System.Drawing.Size(167, 26);
            this.cbSortTable.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(450, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Vị trí:";
            // 
            // cbLocationTable
            // 
            this.cbLocationTable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLocationTable.FormattingEnabled = true;
            this.cbLocationTable.Items.AddRange(new object[] {
            "Bên trong tầng 1",
            "Bên ngoài tầng 1",
            "Bên trong tầng 2",
            "Bên ngoài tầng 2"});
            this.cbLocationTable.Location = new System.Drawing.Point(527, 130);
            this.cbLocationTable.Name = "cbLocationTable";
            this.cbLocationTable.Size = new System.Drawing.Size(167, 26);
            this.cbLocationTable.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbChangeTable);
            this.panel1.Controls.Add(this.numSale);
            this.panel1.Controls.Add(this.btnCheckPay);
            this.panel1.Controls.Add(this.btnSale);
            this.panel1.Controls.Add(this.btnChangeTable);
            this.panel1.Controls.Add(this.lstBill);
            this.panel1.Controls.Add(this.numQuantity);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnAddDish);
            this.panel1.Location = new System.Drawing.Point(700, 119);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(578, 475);
            this.panel1.TabIndex = 6;
            // 
            // cbChangeTable
            // 
            this.cbChangeTable.FormattingEnabled = true;
            this.cbChangeTable.Location = new System.Drawing.Point(3, 432);
            this.cbChangeTable.Name = "cbChangeTable";
            this.cbChangeTable.Size = new System.Drawing.Size(133, 26);
            this.cbChangeTable.TabIndex = 10;
            // 
            // numSale
            // 
            this.numSale.Location = new System.Drawing.Point(230, 432);
            this.numSale.Name = "numSale";
            this.numSale.Size = new System.Drawing.Size(133, 24);
            this.numSale.TabIndex = 9;
            // 
            // btnCheckPay
            // 
            this.btnCheckPay.Location = new System.Drawing.Point(442, 380);
            this.btnCheckPay.Name = "btnCheckPay";
            this.btnCheckPay.Size = new System.Drawing.Size(133, 92);
            this.btnCheckPay.TabIndex = 8;
            this.btnCheckPay.Text = "Thanh toán";
            this.btnCheckPay.UseVisualStyleBackColor = true;
            // 
            // btnSale
            // 
            this.btnSale.Location = new System.Drawing.Point(230, 380);
            this.btnSale.Name = "btnSale";
            this.btnSale.Size = new System.Drawing.Size(133, 46);
            this.btnSale.TabIndex = 7;
            this.btnSale.Text = "Giảm giá";
            this.btnSale.UseVisualStyleBackColor = true;
            // 
            // btnChangeTable
            // 
            this.btnChangeTable.Location = new System.Drawing.Point(3, 380);
            this.btnChangeTable.Name = "btnChangeTable";
            this.btnChangeTable.Size = new System.Drawing.Size(133, 46);
            this.btnChangeTable.TabIndex = 6;
            this.btnChangeTable.Text = "Chuyển bàn";
            this.btnChangeTable.UseVisualStyleBackColor = true;
            // 
            // lstBill
            // 
            this.lstBill.HideSelection = false;
            this.lstBill.Location = new System.Drawing.Point(3, 47);
            this.lstBill.Name = "lstBill";
            this.lstBill.Size = new System.Drawing.Size(572, 327);
            this.lstBill.TabIndex = 5;
            this.lstBill.UseCompatibleStateImageBehavior = false;
            // 
            // numQuantity
            // 
            this.numQuantity.Location = new System.Drawing.Point(501, 10);
            this.numQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numQuantity.Name = "numQuantity";
            this.numQuantity.Size = new System.Drawing.Size(74, 24);
            this.numQuantity.TabIndex = 4;
            this.numQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(424, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Số lượng:";
            // 
            // btnAddDish
            // 
            this.btnAddDish.Location = new System.Drawing.Point(12, 4);
            this.btnAddDish.Name = "btnAddDish";
            this.btnAddDish.Size = new System.Drawing.Size(124, 34);
            this.btnAddDish.TabIndex = 1;
            this.btnAddDish.Text = "Thêm món";
            this.btnAddDish.UseVisualStyleBackColor = true;
            this.btnAddDish.Click += new System.EventHandler(this.btnAddDish_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1292, 83);
            this.panel2.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(506, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(283, 55);
            this.label4.TabIndex = 0;
            this.label4.Text = "BÁN HÀNG";
            // 
            // frmSellManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1292, 606);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cbLocationTable);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbSortTable);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flpTable);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmSellManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSellManagement";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSellManagement_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinCáNhânToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.FlowLayoutPanel flpTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbSortTable;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbLocationTable;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbChangeTable;
        private System.Windows.Forms.NumericUpDown numSale;
        private System.Windows.Forms.Button btnCheckPay;
        private System.Windows.Forms.Button btnSale;
        private System.Windows.Forms.Button btnChangeTable;
        private System.Windows.Forms.ListView lstBill;
        private System.Windows.Forms.NumericUpDown numQuantity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddDish;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
    }
}