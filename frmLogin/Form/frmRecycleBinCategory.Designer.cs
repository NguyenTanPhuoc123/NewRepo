
namespace frmLogin
{
    partial class frmRecycleBinCategory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRecycleBinCategory));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tctrlCategoryDeleted = new Guna.UI2.WinForms.Guna2TabControl();
            this.tpTypeAccountDeleted = new System.Windows.Forms.TabPage();
            this.tpPositionDeleted = new System.Windows.Forms.TabPage();
            this.tpLocationDeleted = new System.Windows.Forms.TabPage();
            this.tpTypeProductDeleted = new System.Windows.Forms.TabPage();
            this.tpSizeProductDeleted = new System.Windows.Forms.TabPage();
            this.tpDiscountDeleted = new System.Windows.Forms.TabPage();
            this.grpLocationInfo = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLocationID = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLocationName = new Guna.UI2.WinForms.Guna2TextBox();
            this.grpFunctionLocationDeleted = new System.Windows.Forms.GroupBox();
            this.btnRestoreAllLocation = new Guna.UI2.WinForms.Guna2Button();
            this.btnRestoreLocation = new Guna.UI2.WinForms.Guna2Button();
            this.dtgvListLocationDeleted = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExitFormRecycleBinCategory = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tctrlCategoryDeleted.SuspendLayout();
            this.tpLocationDeleted.SuspendLayout();
            this.grpLocationInfo.SuspendLayout();
            this.grpFunctionLocationDeleted.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListLocationDeleted)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(108)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.btnExitFormRecycleBinCategory);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(925, 89);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(289, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(356, 55);
            this.label1.TabIndex = 2;
            this.label1.Text = "RECYCLE BIN";
            // 
            // tctrlCategoryDeleted
            // 
            this.tctrlCategoryDeleted.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tctrlCategoryDeleted.Controls.Add(this.tpTypeAccountDeleted);
            this.tctrlCategoryDeleted.Controls.Add(this.tpPositionDeleted);
            this.tctrlCategoryDeleted.Controls.Add(this.tpLocationDeleted);
            this.tctrlCategoryDeleted.Controls.Add(this.tpTypeProductDeleted);
            this.tctrlCategoryDeleted.Controls.Add(this.tpSizeProductDeleted);
            this.tctrlCategoryDeleted.Controls.Add(this.tpDiscountDeleted);
            this.tctrlCategoryDeleted.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tctrlCategoryDeleted.ItemSize = new System.Drawing.Size(180, 40);
            this.tctrlCategoryDeleted.Location = new System.Drawing.Point(0, 89);
            this.tctrlCategoryDeleted.Name = "tctrlCategoryDeleted";
            this.tctrlCategoryDeleted.SelectedIndex = 0;
            this.tctrlCategoryDeleted.Size = new System.Drawing.Size(925, 396);
            this.tctrlCategoryDeleted.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.tctrlCategoryDeleted.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.tctrlCategoryDeleted.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tctrlCategoryDeleted.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.tctrlCategoryDeleted.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.tctrlCategoryDeleted.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.tctrlCategoryDeleted.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tctrlCategoryDeleted.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tctrlCategoryDeleted.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.tctrlCategoryDeleted.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tctrlCategoryDeleted.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.tctrlCategoryDeleted.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.tctrlCategoryDeleted.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tctrlCategoryDeleted.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.tctrlCategoryDeleted.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.tctrlCategoryDeleted.TabButtonSize = new System.Drawing.Size(180, 40);
            this.tctrlCategoryDeleted.TabIndex = 1;
            this.tctrlCategoryDeleted.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            // 
            // tpTypeAccountDeleted
            // 
            this.tpTypeAccountDeleted.Location = new System.Drawing.Point(184, 4);
            this.tpTypeAccountDeleted.Name = "tpTypeAccountDeleted";
            this.tpTypeAccountDeleted.Padding = new System.Windows.Forms.Padding(3);
            this.tpTypeAccountDeleted.Size = new System.Drawing.Size(746, 388);
            this.tpTypeAccountDeleted.TabIndex = 0;
            this.tpTypeAccountDeleted.Text = "Loại tài khoản";
            this.tpTypeAccountDeleted.UseVisualStyleBackColor = true;
            // 
            // tpPositionDeleted
            // 
            this.tpPositionDeleted.Location = new System.Drawing.Point(184, 4);
            this.tpPositionDeleted.Name = "tpPositionDeleted";
            this.tpPositionDeleted.Padding = new System.Windows.Forms.Padding(3);
            this.tpPositionDeleted.Size = new System.Drawing.Size(746, 388);
            this.tpPositionDeleted.TabIndex = 1;
            this.tpPositionDeleted.Text = "Chức vụ";
            this.tpPositionDeleted.UseVisualStyleBackColor = true;
            // 
            // tpLocationDeleted
            // 
            this.tpLocationDeleted.Controls.Add(this.dtgvListLocationDeleted);
            this.tpLocationDeleted.Controls.Add(this.grpFunctionLocationDeleted);
            this.tpLocationDeleted.Controls.Add(this.grpLocationInfo);
            this.tpLocationDeleted.Location = new System.Drawing.Point(184, 4);
            this.tpLocationDeleted.Name = "tpLocationDeleted";
            this.tpLocationDeleted.Padding = new System.Windows.Forms.Padding(3);
            this.tpLocationDeleted.Size = new System.Drawing.Size(737, 388);
            this.tpLocationDeleted.TabIndex = 2;
            this.tpLocationDeleted.Text = "Vị trí bàn ăn";
            this.tpLocationDeleted.UseVisualStyleBackColor = true;
            // 
            // tpTypeProductDeleted
            // 
            this.tpTypeProductDeleted.Location = new System.Drawing.Point(184, 4);
            this.tpTypeProductDeleted.Name = "tpTypeProductDeleted";
            this.tpTypeProductDeleted.Padding = new System.Windows.Forms.Padding(3);
            this.tpTypeProductDeleted.Size = new System.Drawing.Size(746, 388);
            this.tpTypeProductDeleted.TabIndex = 3;
            this.tpTypeProductDeleted.Text = "Loại sản phẩm";
            this.tpTypeProductDeleted.UseVisualStyleBackColor = true;
            // 
            // tpSizeProductDeleted
            // 
            this.tpSizeProductDeleted.Location = new System.Drawing.Point(184, 4);
            this.tpSizeProductDeleted.Name = "tpSizeProductDeleted";
            this.tpSizeProductDeleted.Padding = new System.Windows.Forms.Padding(3);
            this.tpSizeProductDeleted.Size = new System.Drawing.Size(746, 388);
            this.tpSizeProductDeleted.TabIndex = 4;
            this.tpSizeProductDeleted.Text = "Kích thước sản phẩm";
            this.tpSizeProductDeleted.UseVisualStyleBackColor = true;
            // 
            // tpDiscountDeleted
            // 
            this.tpDiscountDeleted.Location = new System.Drawing.Point(184, 4);
            this.tpDiscountDeleted.Name = "tpDiscountDeleted";
            this.tpDiscountDeleted.Padding = new System.Windows.Forms.Padding(3);
            this.tpDiscountDeleted.Size = new System.Drawing.Size(746, 388);
            this.tpDiscountDeleted.TabIndex = 5;
            this.tpDiscountDeleted.Text = "Giảm giá";
            this.tpDiscountDeleted.UseVisualStyleBackColor = true;
            // 
            // grpLocationInfo
            // 
            this.grpLocationInfo.Controls.Add(this.txtLocationName);
            this.grpLocationInfo.Controls.Add(this.label3);
            this.grpLocationInfo.Controls.Add(this.txtLocationID);
            this.grpLocationInfo.Controls.Add(this.label2);
            this.grpLocationInfo.Location = new System.Drawing.Point(6, 6);
            this.grpLocationInfo.Name = "grpLocationInfo";
            this.grpLocationInfo.Size = new System.Drawing.Size(328, 156);
            this.grpLocationInfo.TabIndex = 0;
            this.grpLocationInfo.TabStop = false;
            this.grpLocationInfo.Text = "Thông tin vị trí bàn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã vị trí:";
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
            this.txtLocationID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLocationID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtLocationID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLocationID.Location = new System.Drawing.Point(89, 22);
            this.txtLocationID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLocationID.Name = "txtLocationID";
            this.txtLocationID.PasswordChar = '\0';
            this.txtLocationID.PlaceholderText = "";
            this.txtLocationID.SelectedText = "";
            this.txtLocationID.Size = new System.Drawing.Size(199, 35);
            this.txtLocationID.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên vị trí:";
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
            this.txtLocationName.Location = new System.Drawing.Point(89, 82);
            this.txtLocationName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLocationName.Name = "txtLocationName";
            this.txtLocationName.PasswordChar = '\0';
            this.txtLocationName.PlaceholderText = "";
            this.txtLocationName.SelectedText = "";
            this.txtLocationName.Size = new System.Drawing.Size(199, 35);
            this.txtLocationName.TabIndex = 3;
            // 
            // grpFunctionLocationDeleted
            // 
            this.grpFunctionLocationDeleted.Controls.Add(this.btnRestoreAllLocation);
            this.grpFunctionLocationDeleted.Controls.Add(this.btnRestoreLocation);
            this.grpFunctionLocationDeleted.Location = new System.Drawing.Point(358, 6);
            this.grpFunctionLocationDeleted.Name = "grpFunctionLocationDeleted";
            this.grpFunctionLocationDeleted.Size = new System.Drawing.Size(273, 156);
            this.grpFunctionLocationDeleted.TabIndex = 1;
            this.grpFunctionLocationDeleted.TabStop = false;
            this.grpFunctionLocationDeleted.Text = "Chức năng";
            // 
            // btnRestoreAllLocation
            // 
            this.btnRestoreAllLocation.BorderRadius = 20;
            this.btnRestoreAllLocation.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRestoreAllLocation.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRestoreAllLocation.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRestoreAllLocation.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRestoreAllLocation.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(51)))), ((int)(((byte)(255)))));
            this.btnRestoreAllLocation.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRestoreAllLocation.ForeColor = System.Drawing.Color.Black;
            this.btnRestoreAllLocation.Location = new System.Drawing.Point(46, 97);
            this.btnRestoreAllLocation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRestoreAllLocation.Name = "btnRestoreAllLocation";
            this.btnRestoreAllLocation.Size = new System.Drawing.Size(181, 46);
            this.btnRestoreAllLocation.TabIndex = 3;
            this.btnRestoreAllLocation.Text = "Khôi phục tất cả";
            // 
            // btnRestoreLocation
            // 
            this.btnRestoreLocation.BorderRadius = 20;
            this.btnRestoreLocation.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRestoreLocation.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRestoreLocation.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRestoreLocation.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRestoreLocation.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(255)))), ((int)(((byte)(110)))));
            this.btnRestoreLocation.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRestoreLocation.ForeColor = System.Drawing.Color.Black;
            this.btnRestoreLocation.Location = new System.Drawing.Point(46, 22);
            this.btnRestoreLocation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRestoreLocation.Name = "btnRestoreLocation";
            this.btnRestoreLocation.Size = new System.Drawing.Size(181, 46);
            this.btnRestoreLocation.TabIndex = 2;
            this.btnRestoreLocation.Text = "Khôi phục";
            // 
            // dtgvListLocationDeleted
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dtgvListLocationDeleted.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvListLocationDeleted.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvListLocationDeleted.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvListLocationDeleted.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvListLocationDeleted.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvListLocationDeleted.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgvListLocationDeleted.Location = new System.Drawing.Point(26, 202);
            this.dtgvListLocationDeleted.Name = "dtgvListLocationDeleted";
            this.dtgvListLocationDeleted.RowHeadersVisible = false;
            this.dtgvListLocationDeleted.RowHeadersWidth = 51;
            this.dtgvListLocationDeleted.RowTemplate.Height = 24;
            this.dtgvListLocationDeleted.Size = new System.Drawing.Size(590, 178);
            this.dtgvListLocationDeleted.TabIndex = 2;
            this.dtgvListLocationDeleted.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgvListLocationDeleted.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtgvListLocationDeleted.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtgvListLocationDeleted.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtgvListLocationDeleted.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtgvListLocationDeleted.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dtgvListLocationDeleted.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgvListLocationDeleted.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtgvListLocationDeleted.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgvListLocationDeleted.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgvListLocationDeleted.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtgvListLocationDeleted.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvListLocationDeleted.ThemeStyle.HeaderStyle.Height = 19;
            this.dtgvListLocationDeleted.ThemeStyle.ReadOnly = false;
            this.dtgvListLocationDeleted.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgvListLocationDeleted.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgvListLocationDeleted.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgvListLocationDeleted.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtgvListLocationDeleted.ThemeStyle.RowsStyle.Height = 24;
            this.dtgvListLocationDeleted.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgvListLocationDeleted.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
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
            // btnExitFormRecycleBinCategory
            // 
            this.btnExitFormRecycleBinCategory.FlatAppearance.BorderSize = 0;
            this.btnExitFormRecycleBinCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExitFormRecycleBinCategory.Image = ((System.Drawing.Image)(resources.GetObject("btnExitFormRecycleBinCategory.Image")));
            this.btnExitFormRecycleBinCategory.Location = new System.Drawing.Point(852, 3);
            this.btnExitFormRecycleBinCategory.Name = "btnExitFormRecycleBinCategory";
            this.btnExitFormRecycleBinCategory.Size = new System.Drawing.Size(69, 45);
            this.btnExitFormRecycleBinCategory.TabIndex = 8;
            this.btnExitFormRecycleBinCategory.UseVisualStyleBackColor = true;
            this.btnExitFormRecycleBinCategory.Click += new System.EventHandler(this.btnExitFormRecycleBinCategory_Click);
            // 
            // frmRecycleBinCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 485);
            this.Controls.Add(this.tctrlCategoryDeleted);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRecycleBinCategory";
            this.Text = "frmRecycleBinCategory";
            this.Load += new System.EventHandler(this.frmRecycleBinCategory_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tctrlCategoryDeleted.ResumeLayout(false);
            this.tpLocationDeleted.ResumeLayout(false);
            this.grpLocationInfo.ResumeLayout(false);
            this.grpLocationInfo.PerformLayout();
            this.grpFunctionLocationDeleted.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListLocationDeleted)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TabControl tctrlCategoryDeleted;
        private System.Windows.Forms.TabPage tpTypeAccountDeleted;
        private System.Windows.Forms.TabPage tpPositionDeleted;
        private System.Windows.Forms.TabPage tpLocationDeleted;
        private System.Windows.Forms.TabPage tpTypeProductDeleted;
        private System.Windows.Forms.TabPage tpSizeProductDeleted;
        private System.Windows.Forms.TabPage tpDiscountDeleted;
        private System.Windows.Forms.GroupBox grpFunctionLocationDeleted;
        private System.Windows.Forms.GroupBox grpLocationInfo;
        private Guna.UI2.WinForms.Guna2TextBox txtLocationName;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtLocationID;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2DataGridView dtgvListLocationDeleted;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private Guna.UI2.WinForms.Guna2Button btnRestoreAllLocation;
        private Guna.UI2.WinForms.Guna2Button btnRestoreLocation;
        private System.Windows.Forms.Button btnExitFormRecycleBinCategory;
    }
}