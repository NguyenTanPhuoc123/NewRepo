
namespace frmLogin
{
    partial class frmCategoyManagement
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCategoyManagement));
            this.tctrlCagtegoryManagement = new Guna.UI2.WinForms.Guna2TabControl();
            this.tpTypeAccount = new System.Windows.Forms.TabPage();
            this.tpPosition = new System.Windows.Forms.TabPage();
            this.tpLocationTable = new System.Windows.Forms.TabPage();
            this.dtgvListLocation = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpFunctionLocation = new System.Windows.Forms.GroupBox();
            this.btnSaveLocation = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddLocation = new Guna.UI2.WinForms.Guna2Button();
            this.btnEditLocation = new Guna.UI2.WinForms.Guna2Button();
            this.btnDeleteAllLocation = new Guna.UI2.WinForms.Guna2Button();
            this.btnDeleteLocation = new Guna.UI2.WinForms.Guna2Button();
            this.btnLocationDeleted = new Guna.UI2.WinForms.Guna2Button();
            this.grpLocationInfo = new System.Windows.Forms.GroupBox();
            this.txtLocationName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLocationID = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tpTypeProduct = new System.Windows.Forms.TabPage();
            this.tpSizeProduct = new System.Windows.Forms.TabPage();
            this.tpDiscount = new System.Windows.Forms.TabPage();
            this.tctrlCagtegoryManagement.SuspendLayout();
            this.tpLocationTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListLocation)).BeginInit();
            this.grpFunctionLocation.SuspendLayout();
            this.grpLocationInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // tctrlCagtegoryManagement
            // 
            this.tctrlCagtegoryManagement.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tctrlCagtegoryManagement.Controls.Add(this.tpTypeAccount);
            this.tctrlCagtegoryManagement.Controls.Add(this.tpPosition);
            this.tctrlCagtegoryManagement.Controls.Add(this.tpLocationTable);
            this.tctrlCagtegoryManagement.Controls.Add(this.tpTypeProduct);
            this.tctrlCagtegoryManagement.Controls.Add(this.tpSizeProduct);
            this.tctrlCagtegoryManagement.Controls.Add(this.tpDiscount);
            this.tctrlCagtegoryManagement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tctrlCagtegoryManagement.ItemSize = new System.Drawing.Size(180, 40);
            this.tctrlCagtegoryManagement.Location = new System.Drawing.Point(0, 0);
            this.tctrlCagtegoryManagement.Name = "tctrlCagtegoryManagement";
            this.tctrlCagtegoryManagement.SelectedIndex = 0;
            this.tctrlCagtegoryManagement.Size = new System.Drawing.Size(964, 474);
            this.tctrlCagtegoryManagement.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.tctrlCagtegoryManagement.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.tctrlCagtegoryManagement.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tctrlCagtegoryManagement.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.tctrlCagtegoryManagement.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.tctrlCagtegoryManagement.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.tctrlCagtegoryManagement.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tctrlCagtegoryManagement.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tctrlCagtegoryManagement.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.tctrlCagtegoryManagement.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tctrlCagtegoryManagement.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.tctrlCagtegoryManagement.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.tctrlCagtegoryManagement.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tctrlCagtegoryManagement.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.tctrlCagtegoryManagement.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.tctrlCagtegoryManagement.TabButtonSize = new System.Drawing.Size(180, 40);
            this.tctrlCagtegoryManagement.TabIndex = 0;
            this.tctrlCagtegoryManagement.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            // 
            // tpTypeAccount
            // 
            this.tpTypeAccount.Location = new System.Drawing.Point(184, 4);
            this.tpTypeAccount.Name = "tpTypeAccount";
            this.tpTypeAccount.Padding = new System.Windows.Forms.Padding(3);
            this.tpTypeAccount.Size = new System.Drawing.Size(776, 466);
            this.tpTypeAccount.TabIndex = 0;
            this.tpTypeAccount.Text = "Loại tài khoản";
            this.tpTypeAccount.UseVisualStyleBackColor = true;
            // 
            // tpPosition
            // 
            this.tpPosition.Location = new System.Drawing.Point(184, 4);
            this.tpPosition.Name = "tpPosition";
            this.tpPosition.Padding = new System.Windows.Forms.Padding(3);
            this.tpPosition.Size = new System.Drawing.Size(776, 466);
            this.tpPosition.TabIndex = 1;
            this.tpPosition.Text = "Chức vụ";
            this.tpPosition.UseVisualStyleBackColor = true;
            // 
            // tpLocationTable
            // 
            this.tpLocationTable.Controls.Add(this.dtgvListLocation);
            this.tpLocationTable.Controls.Add(this.grpFunctionLocation);
            this.tpLocationTable.Controls.Add(this.grpLocationInfo);
            this.tpLocationTable.Location = new System.Drawing.Point(184, 4);
            this.tpLocationTable.Name = "tpLocationTable";
            this.tpLocationTable.Padding = new System.Windows.Forms.Padding(3);
            this.tpLocationTable.Size = new System.Drawing.Size(776, 466);
            this.tpLocationTable.TabIndex = 2;
            this.tpLocationTable.Text = "Vị trí bàn ăn";
            this.tpLocationTable.UseVisualStyleBackColor = true;
            // 
            // dtgvListLocation
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dtgvListLocation.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvListLocation.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvListLocation.ColumnHeadersHeight = 19;
            this.dtgvListLocation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtgvListLocation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvListLocation.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvListLocation.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgvListLocation.Location = new System.Drawing.Point(6, 240);
            this.dtgvListLocation.Name = "dtgvListLocation";
            this.dtgvListLocation.RowHeadersVisible = false;
            this.dtgvListLocation.RowHeadersWidth = 51;
            this.dtgvListLocation.RowTemplate.Height = 24;
            this.dtgvListLocation.Size = new System.Drawing.Size(762, 220);
            this.dtgvListLocation.TabIndex = 2;
            this.dtgvListLocation.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgvListLocation.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtgvListLocation.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtgvListLocation.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtgvListLocation.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtgvListLocation.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dtgvListLocation.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgvListLocation.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtgvListLocation.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgvListLocation.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgvListLocation.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtgvListLocation.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtgvListLocation.ThemeStyle.HeaderStyle.Height = 19;
            this.dtgvListLocation.ThemeStyle.ReadOnly = false;
            this.dtgvListLocation.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgvListLocation.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgvListLocation.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgvListLocation.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtgvListLocation.ThemeStyle.RowsStyle.Height = 24;
            this.dtgvListLocation.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgvListLocation.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtgvListLocation.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvListLocation_CellContentClick);
            this.dtgvListLocation.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvListLocation_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaViTri";
            this.Column1.HeaderText = "Mã vị trí";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TenViTri";
            this.Column2.HeaderText = "Tên vị trí";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // grpFunctionLocation
            // 
            this.grpFunctionLocation.Controls.Add(this.btnSaveLocation);
            this.grpFunctionLocation.Controls.Add(this.btnAddLocation);
            this.grpFunctionLocation.Controls.Add(this.btnEditLocation);
            this.grpFunctionLocation.Controls.Add(this.btnDeleteAllLocation);
            this.grpFunctionLocation.Controls.Add(this.btnDeleteLocation);
            this.grpFunctionLocation.Controls.Add(this.btnLocationDeleted);
            this.grpFunctionLocation.Location = new System.Drawing.Point(435, 6);
            this.grpFunctionLocation.Name = "grpFunctionLocation";
            this.grpFunctionLocation.Size = new System.Drawing.Size(333, 228);
            this.grpFunctionLocation.TabIndex = 1;
            this.grpFunctionLocation.TabStop = false;
            this.grpFunctionLocation.Text = "Chức năng";
            // 
            // btnSaveLocation
            // 
            this.btnSaveLocation.BorderRadius = 20;
            this.btnSaveLocation.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSaveLocation.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSaveLocation.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSaveLocation.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSaveLocation.Enabled = false;
            this.btnSaveLocation.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(51)))), ((int)(((byte)(255)))));
            this.btnSaveLocation.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSaveLocation.ForeColor = System.Drawing.Color.Black;
            this.btnSaveLocation.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveLocation.Image")));
            this.btnSaveLocation.ImageSize = new System.Drawing.Size(30, 30);
            this.btnSaveLocation.Location = new System.Drawing.Point(179, 25);
            this.btnSaveLocation.Name = "btnSaveLocation";
            this.btnSaveLocation.Size = new System.Drawing.Size(148, 45);
            this.btnSaveLocation.TabIndex = 33;
            this.btnSaveLocation.Text = "Lưu";
            this.btnSaveLocation.Click += new System.EventHandler(this.btnSaveLocation_Click);
            // 
            // btnAddLocation
            // 
            this.btnAddLocation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAddLocation.BorderRadius = 20;
            this.btnAddLocation.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddLocation.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddLocation.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddLocation.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddLocation.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(255)))), ((int)(((byte)(51)))));
            this.btnAddLocation.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddLocation.ForeColor = System.Drawing.Color.Black;
            this.btnAddLocation.Image = ((System.Drawing.Image)(resources.GetObject("btnAddLocation.Image")));
            this.btnAddLocation.ImageSize = new System.Drawing.Size(30, 30);
            this.btnAddLocation.Location = new System.Drawing.Point(8, 25);
            this.btnAddLocation.Name = "btnAddLocation";
            this.btnAddLocation.Size = new System.Drawing.Size(148, 45);
            this.btnAddLocation.TabIndex = 28;
            this.btnAddLocation.Text = "Thêm";
            this.btnAddLocation.Click += new System.EventHandler(this.btnAddLocation_Click);
            // 
            // btnEditLocation
            // 
            this.btnEditLocation.BorderRadius = 20;
            this.btnEditLocation.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEditLocation.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEditLocation.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEditLocation.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEditLocation.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(233)))), ((int)(((byte)(255)))));
            this.btnEditLocation.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEditLocation.ForeColor = System.Drawing.Color.Black;
            this.btnEditLocation.Image = ((System.Drawing.Image)(resources.GetObject("btnEditLocation.Image")));
            this.btnEditLocation.ImageSize = new System.Drawing.Size(30, 30);
            this.btnEditLocation.Location = new System.Drawing.Point(8, 81);
            this.btnEditLocation.Name = "btnEditLocation";
            this.btnEditLocation.Size = new System.Drawing.Size(148, 45);
            this.btnEditLocation.TabIndex = 29;
            this.btnEditLocation.Text = "Sửa";
            this.btnEditLocation.Click += new System.EventHandler(this.btnEditLocation_Click);
            // 
            // btnDeleteAllLocation
            // 
            this.btnDeleteAllLocation.BorderColor = System.Drawing.Color.Red;
            this.btnDeleteAllLocation.BorderRadius = 10;
            this.btnDeleteAllLocation.BorderThickness = 2;
            this.btnDeleteAllLocation.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteAllLocation.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteAllLocation.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDeleteAllLocation.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDeleteAllLocation.FillColor = System.Drawing.Color.White;
            this.btnDeleteAllLocation.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDeleteAllLocation.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteAllLocation.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteAllLocation.Image")));
            this.btnDeleteAllLocation.ImageSize = new System.Drawing.Size(30, 30);
            this.btnDeleteAllLocation.Location = new System.Drawing.Point(179, 152);
            this.btnDeleteAllLocation.Name = "btnDeleteAllLocation";
            this.btnDeleteAllLocation.Size = new System.Drawing.Size(148, 43);
            this.btnDeleteAllLocation.TabIndex = 32;
            this.btnDeleteAllLocation.Text = "Xóa tất cả";
            this.btnDeleteAllLocation.Click += new System.EventHandler(this.btnDeleteAllLocation_Click);
            // 
            // btnDeleteLocation
            // 
            this.btnDeleteLocation.BorderRadius = 20;
            this.btnDeleteLocation.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteLocation.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteLocation.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDeleteLocation.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDeleteLocation.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(85)))));
            this.btnDeleteLocation.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDeleteLocation.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteLocation.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteLocation.Image")));
            this.btnDeleteLocation.ImageSize = new System.Drawing.Size(30, 30);
            this.btnDeleteLocation.Location = new System.Drawing.Point(8, 150);
            this.btnDeleteLocation.Name = "btnDeleteLocation";
            this.btnDeleteLocation.Size = new System.Drawing.Size(148, 45);
            this.btnDeleteLocation.TabIndex = 30;
            this.btnDeleteLocation.Text = "Xóa";
            this.btnDeleteLocation.Click += new System.EventHandler(this.btnDeleteLocation_Click);
            // 
            // btnLocationDeleted
            // 
            this.btnLocationDeleted.BorderRadius = 20;
            this.btnLocationDeleted.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLocationDeleted.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLocationDeleted.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLocationDeleted.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLocationDeleted.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(184)))));
            this.btnLocationDeleted.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLocationDeleted.ForeColor = System.Drawing.Color.Black;
            this.btnLocationDeleted.Image = ((System.Drawing.Image)(resources.GetObject("btnLocationDeleted.Image")));
            this.btnLocationDeleted.ImageSize = new System.Drawing.Size(30, 30);
            this.btnLocationDeleted.Location = new System.Drawing.Point(179, 81);
            this.btnLocationDeleted.Name = "btnLocationDeleted";
            this.btnLocationDeleted.Size = new System.Drawing.Size(148, 45);
            this.btnLocationDeleted.TabIndex = 31;
            this.btnLocationDeleted.Text = "Bàn đã xóa";
            this.btnLocationDeleted.Click += new System.EventHandler(this.btnLocationDeleted_Click);
            // 
            // grpLocationInfo
            // 
            this.grpLocationInfo.Controls.Add(this.txtLocationName);
            this.grpLocationInfo.Controls.Add(this.label2);
            this.grpLocationInfo.Controls.Add(this.txtLocationID);
            this.grpLocationInfo.Controls.Add(this.label1);
            this.grpLocationInfo.Location = new System.Drawing.Point(6, 6);
            this.grpLocationInfo.Name = "grpLocationInfo";
            this.grpLocationInfo.Size = new System.Drawing.Size(407, 228);
            this.grpLocationInfo.TabIndex = 0;
            this.grpLocationInfo.TabStop = false;
            this.grpLocationInfo.Text = "Thông tin vị trí bàn";
            // 
            // txtLocationName
            // 
            this.txtLocationName.BorderRadius = 20;
            this.txtLocationName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLocationName.DefaultText = "";
            this.txtLocationName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtLocationName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtLocationName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLocationName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLocationName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLocationName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtLocationName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLocationName.Location = new System.Drawing.Point(111, 127);
            this.txtLocationName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLocationName.Name = "txtLocationName";
            this.txtLocationName.PasswordChar = '\0';
            this.txtLocationName.PlaceholderText = "";
            this.txtLocationName.SelectedText = "";
            this.txtLocationName.Size = new System.Drawing.Size(226, 48);
            this.txtLocationName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên vị trí:";
            // 
            // txtLocationID
            // 
            this.txtLocationID.BorderRadius = 20;
            this.txtLocationID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLocationID.DefaultText = "";
            this.txtLocationID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtLocationID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtLocationID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLocationID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLocationID.Enabled = false;
            this.txtLocationID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLocationID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtLocationID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLocationID.Location = new System.Drawing.Point(111, 22);
            this.txtLocationID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLocationID.Name = "txtLocationID";
            this.txtLocationID.PasswordChar = '\0';
            this.txtLocationID.PlaceholderText = "";
            this.txtLocationID.SelectedText = "";
            this.txtLocationID.Size = new System.Drawing.Size(226, 48);
            this.txtLocationID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã vị trí:";
            // 
            // tpTypeProduct
            // 
            this.tpTypeProduct.Location = new System.Drawing.Point(184, 4);
            this.tpTypeProduct.Name = "tpTypeProduct";
            this.tpTypeProduct.Padding = new System.Windows.Forms.Padding(3);
            this.tpTypeProduct.Size = new System.Drawing.Size(776, 466);
            this.tpTypeProduct.TabIndex = 3;
            this.tpTypeProduct.Text = "Loại sản phẩm";
            this.tpTypeProduct.UseVisualStyleBackColor = true;
            // 
            // tpSizeProduct
            // 
            this.tpSizeProduct.Location = new System.Drawing.Point(184, 4);
            this.tpSizeProduct.Name = "tpSizeProduct";
            this.tpSizeProduct.Padding = new System.Windows.Forms.Padding(3);
            this.tpSizeProduct.Size = new System.Drawing.Size(776, 466);
            this.tpSizeProduct.TabIndex = 4;
            this.tpSizeProduct.Text = "Kích thước";
            this.tpSizeProduct.UseVisualStyleBackColor = true;
            // 
            // tpDiscount
            // 
            this.tpDiscount.Location = new System.Drawing.Point(184, 4);
            this.tpDiscount.Name = "tpDiscount";
            this.tpDiscount.Padding = new System.Windows.Forms.Padding(3);
            this.tpDiscount.Size = new System.Drawing.Size(776, 466);
            this.tpDiscount.TabIndex = 5;
            this.tpDiscount.Text = "Giảm giá";
            this.tpDiscount.UseVisualStyleBackColor = true;
            // 
            // frmCategoyManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 474);
            this.Controls.Add(this.tctrlCagtegoryManagement);
            this.Name = "frmCategoyManagement";
            this.Text = "frmCategoyManagement";
            this.Load += new System.EventHandler(this.frmCategoyManagement_Load);
            this.tctrlCagtegoryManagement.ResumeLayout(false);
            this.tpLocationTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListLocation)).EndInit();
            this.grpFunctionLocation.ResumeLayout(false);
            this.grpLocationInfo.ResumeLayout(false);
            this.grpLocationInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TabControl tctrlCagtegoryManagement;
        private System.Windows.Forms.TabPage tpTypeAccount;
        private System.Windows.Forms.TabPage tpPosition;
        private System.Windows.Forms.TabPage tpLocationTable;
        private System.Windows.Forms.GroupBox grpFunctionLocation;
        private System.Windows.Forms.GroupBox grpLocationInfo;
        private Guna.UI2.WinForms.Guna2TextBox txtLocationName;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtLocationID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tpTypeProduct;
        private System.Windows.Forms.TabPage tpSizeProduct;
        private System.Windows.Forms.TabPage tpDiscount;
        private Guna.UI2.WinForms.Guna2DataGridView dtgvListLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private Guna.UI2.WinForms.Guna2Button btnSaveLocation;
        private Guna.UI2.WinForms.Guna2Button btnAddLocation;
        private Guna.UI2.WinForms.Guna2Button btnEditLocation;
        private Guna.UI2.WinForms.Guna2Button btnDeleteAllLocation;
        private Guna.UI2.WinForms.Guna2Button btnDeleteLocation;
        private Guna.UI2.WinForms.Guna2Button btnLocationDeleted;
    }
}