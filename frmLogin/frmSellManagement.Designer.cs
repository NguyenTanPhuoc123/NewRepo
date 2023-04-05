
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSellManagement));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnSelectDish = new Guna.UI2.WinForms.Guna2Button();
            this.dtgvBillDetail = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnPay = new Guna.UI2.WinForms.Guna2Button();
            this.numSale = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.flpTable = new System.Windows.Forms.FlowLayoutPanel();
            this.cbLocationTable = new Guna.UI2.WinForms.Guna2ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnSetting = new System.Windows.Forms.Button();
            this.btnExitFormSell = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tstlblPosition = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslblName = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslblTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbFillTable = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnStoreManagement = new Guna.UI2.WinForms.Guna2Button();
            this.cbChangeTable = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2ColorTransition1 = new Guna.UI2.WinForms.Guna2ColorTransition(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBillDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSale)).BeginInit();
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSelectDish
            // 
            this.btnSelectDish.BackColor = System.Drawing.Color.Transparent;
            this.btnSelectDish.BorderRadius = 10;
            this.btnSelectDish.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSelectDish.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSelectDish.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSelectDish.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSelectDish.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(150)))), ((int)(((byte)(51)))));
            this.btnSelectDish.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSelectDish.ForeColor = System.Drawing.Color.White;
            this.btnSelectDish.Image = ((System.Drawing.Image)(resources.GetObject("btnSelectDish.Image")));
            this.btnSelectDish.ImageSize = new System.Drawing.Size(30, 30);
            this.btnSelectDish.Location = new System.Drawing.Point(711, 119);
            this.btnSelectDish.Name = "btnSelectDish";
            this.btnSelectDish.Size = new System.Drawing.Size(180, 45);
            this.btnSelectDish.TabIndex = 5;
            this.btnSelectDish.Text = "Chọn món";
            this.btnSelectDish.Click += new System.EventHandler(this.btnSelectDish_Click);
            // 
            // dtgvBillDetail
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dtgvBillDetail.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvBillDetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dtgvBillDetail.ColumnHeadersHeight = 4;
            this.dtgvBillDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvBillDetail.DefaultCellStyle = dataGridViewCellStyle6;
            this.dtgvBillDetail.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgvBillDetail.Location = new System.Drawing.Point(711, 170);
            this.dtgvBillDetail.Name = "dtgvBillDetail";
            this.dtgvBillDetail.RowHeadersVisible = false;
            this.dtgvBillDetail.RowHeadersWidth = 51;
            this.dtgvBillDetail.RowTemplate.Height = 24;
            this.dtgvBillDetail.Size = new System.Drawing.Size(569, 345);
            this.dtgvBillDetail.TabIndex = 6;
            this.dtgvBillDetail.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgvBillDetail.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtgvBillDetail.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtgvBillDetail.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtgvBillDetail.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtgvBillDetail.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dtgvBillDetail.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgvBillDetail.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtgvBillDetail.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgvBillDetail.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgvBillDetail.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtgvBillDetail.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtgvBillDetail.ThemeStyle.HeaderStyle.Height = 4;
            this.dtgvBillDetail.ThemeStyle.ReadOnly = false;
            this.dtgvBillDetail.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgvBillDetail.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgvBillDetail.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgvBillDetail.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtgvBillDetail.ThemeStyle.RowsStyle.Height = 24;
            this.dtgvBillDetail.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgvBillDetail.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.Transparent;
            this.btnPay.BorderRadius = 10;
            this.btnPay.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPay.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPay.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPay.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPay.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(255)))), ((int)(((byte)(51)))));
            this.btnPay.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPay.ForeColor = System.Drawing.Color.White;
            this.btnPay.Image = ((System.Drawing.Image)(resources.GetObject("btnPay.Image")));
            this.btnPay.ImageSize = new System.Drawing.Size(30, 30);
            this.btnPay.Location = new System.Drawing.Point(1152, 537);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(128, 63);
            this.btnPay.TabIndex = 7;
            this.btnPay.Text = "Thanh toán";
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // numSale
            // 
            this.numSale.BackColor = System.Drawing.Color.Transparent;
            this.numSale.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numSale.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numSale.Location = new System.Drawing.Point(1025, 559);
            this.numSale.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numSale.Name = "numSale";
            this.numSale.Size = new System.Drawing.Size(113, 36);
            this.numSale.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(1036, 537);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Giảm giá";
            // 
            // flpTable
            // 
            this.flpTable.Location = new System.Drawing.Point(12, 170);
            this.flpTable.Name = "flpTable";
            this.flpTable.Size = new System.Drawing.Size(693, 428);
            this.flpTable.TabIndex = 11;
            // 
            // cbLocationTable
            // 
            this.cbLocationTable.BackColor = System.Drawing.Color.Transparent;
            this.cbLocationTable.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbLocationTable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLocationTable.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbLocationTable.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbLocationTable.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbLocationTable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbLocationTable.ItemHeight = 30;
            this.cbLocationTable.Location = new System.Drawing.Point(12, 128);
            this.cbLocationTable.Name = "cbLocationTable";
            this.cbLocationTable.Size = new System.Drawing.Size(191, 36);
            this.cbLocationTable.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panel1.Controls.Add(this.btnMinimize);
            this.panel1.Controls.Add(this.btnSetting);
            this.panel1.Controls.Add(this.btnExitFormSell);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1292, 100);
            this.panel1.TabIndex = 13;
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.Location = new System.Drawing.Point(1144, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(73, 46);
            this.btnMinimize.TabIndex = 21;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnSetting
            // 
            this.btnSetting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSetting.FlatAppearance.BorderSize = 0;
            this.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetting.Image = ((System.Drawing.Image)(resources.GetObject("btnSetting.Image")));
            this.btnSetting.Location = new System.Drawing.Point(1085, 0);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(53, 46);
            this.btnSetting.TabIndex = 20;
            this.btnSetting.UseVisualStyleBackColor = true;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // btnExitFormSell
            // 
            this.btnExitFormSell.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExitFormSell.FlatAppearance.BorderSize = 0;
            this.btnExitFormSell.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExitFormSell.Image = ((System.Drawing.Image)(resources.GetObject("btnExitFormSell.Image")));
            this.btnExitFormSell.Location = new System.Drawing.Point(1217, 0);
            this.btnExitFormSell.Name = "btnExitFormSell";
            this.btnExitFormSell.Size = new System.Drawing.Size(75, 46);
            this.btnExitFormSell.TabIndex = 19;
            this.btnExitFormSell.UseVisualStyleBackColor = true;
            this.btnExitFormSell.Click += new System.EventHandler(this.btnExitFormSell_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(501, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 44);
            this.label2.TabIndex = 0;
            this.label2.Text = "BÁN HÀNG";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tstlblPosition,
            this.tsslblName,
            this.tsslblTime});
            this.statusStrip1.Location = new System.Drawing.Point(0, 607);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1292, 22);
            this.statusStrip1.TabIndex = 14;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tstlblPosition
            // 
            this.tstlblPosition.Name = "tstlblPosition";
            this.tstlblPosition.Size = new System.Drawing.Size(67, 17);
            this.tstlblPosition.Text = "Nhân viên: ";
            this.tstlblPosition.Click += new System.EventHandler(this.tstlblPosition_Click);
            // 
            // tsslblName
            // 
            this.tsslblName.Name = "tsslblName";
            this.tsslblName.Size = new System.Drawing.Size(39, 17);
            this.tsslblName.Text = "Name";
            // 
            // tsslblTime
            // 
            this.tsslblTime.Margin = new System.Windows.Forms.Padding(900, 4, 0, 2);
            this.tsslblTime.Name = "tsslblTime";
            this.tsslblTime.Size = new System.Drawing.Size(0, 16);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(12, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "Vị trí bàn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(508, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 15);
            this.label4.TabIndex = 16;
            this.label4.Text = "Lọc ";
            // 
            // cbFillTable
            // 
            this.cbFillTable.BackColor = System.Drawing.Color.Transparent;
            this.cbFillTable.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbFillTable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFillTable.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbFillTable.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbFillTable.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbFillTable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbFillTable.ItemHeight = 30;
            this.cbFillTable.Location = new System.Drawing.Point(511, 128);
            this.cbFillTable.Name = "cbFillTable";
            this.cbFillTable.Size = new System.Drawing.Size(191, 36);
            this.cbFillTable.TabIndex = 17;
            // 
            // btnStoreManagement
            // 
            this.btnStoreManagement.BackColor = System.Drawing.Color.Transparent;
            this.btnStoreManagement.BorderRadius = 20;
            this.btnStoreManagement.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnStoreManagement.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnStoreManagement.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnStoreManagement.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnStoreManagement.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btnStoreManagement.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnStoreManagement.ForeColor = System.Drawing.Color.White;
            this.btnStoreManagement.Image = ((System.Drawing.Image)(resources.GetObject("btnStoreManagement.Image")));
            this.btnStoreManagement.ImageSize = new System.Drawing.Size(30, 30);
            this.btnStoreManagement.Location = new System.Drawing.Point(1065, 119);
            this.btnStoreManagement.Name = "btnStoreManagement";
            this.btnStoreManagement.Size = new System.Drawing.Size(215, 45);
            this.btnStoreManagement.TabIndex = 18;
            this.btnStoreManagement.Text = "Quản lý cửa hàng";
            this.btnStoreManagement.Click += new System.EventHandler(this.btnStoreManagement_Click);
            // 
            // cbChangeTable
            // 
            this.cbChangeTable.BackColor = System.Drawing.Color.Transparent;
            this.cbChangeTable.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbChangeTable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbChangeTable.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbChangeTable.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbChangeTable.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbChangeTable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbChangeTable.ItemHeight = 30;
            this.cbChangeTable.Location = new System.Drawing.Point(724, 564);
            this.cbChangeTable.Name = "cbChangeTable";
            this.cbChangeTable.Size = new System.Drawing.Size(152, 36);
            this.cbChangeTable.TabIndex = 19;
            // 
            // guna2ColorTransition1
            // 
            this.guna2ColorTransition1.ColorArray = new System.Drawing.Color[] {
        System.Drawing.Color.Red,
        System.Drawing.Color.Blue,
        System.Drawing.Color.Orange};
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(721, 537);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 15);
            this.label5.TabIndex = 20;
            this.label5.Text = "Chuyển bàn";
            // 
            // btnDelete
            // 
            this.btnDelete.BorderRadius = 20;
            this.btnDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(907, 555);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(85, 45);
            this.btnDelete.TabIndex = 21;
            this.btnDelete.Text = "Xóa";
            // 
            // frmSellManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1292, 629);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbChangeTable);
            this.Controls.Add(this.btnStoreManagement);
            this.Controls.Add(this.cbFillTable);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbLocationTable);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnSelectDish);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flpTable);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numSale);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.dtgvBillDetail);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSellManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSellManagement";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSellManagement_FormClosing);
            this.Load += new System.EventHandler(this.frmSellManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBillDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSale)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnSelectDish;
        private Guna.UI2.WinForms.Guna2DataGridView dtgvBillDetail;
        private Guna.UI2.WinForms.Guna2Button btnPay;
        private Guna.UI2.WinForms.Guna2NumericUpDown numSale;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flpTable;
        private Guna.UI2.WinForms.Guna2ComboBox cbLocationTable;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tstlblPosition;
        private System.Windows.Forms.ToolStripStatusLabel tsslblName;
        private System.Windows.Forms.ToolStripStatusLabel tsslblTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2ComboBox cbFillTable;
        private Guna.UI2.WinForms.Guna2Button btnStoreManagement;
        private System.Windows.Forms.Button btnExitFormSell;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnSetting;
        private Guna.UI2.WinForms.Guna2ComboBox cbChangeTable;
        private Guna.UI2.WinForms.Guna2ColorTransition guna2ColorTransition1;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
    }
}