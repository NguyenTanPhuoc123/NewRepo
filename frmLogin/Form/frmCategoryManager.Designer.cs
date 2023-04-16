
namespace frmLogin
{
    partial class frmCategoryManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCategoryManager));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tctrCategoryManager = new Guna.UI2.WinForms.Guna2TabControl();
            this.tpCategoryFood = new System.Windows.Forms.TabPage();
            this.dtgvListCategoryFood = new Guna.UI2.WinForms.Guna2DataGridView();
            this.tpCategoryLocation = new System.Windows.Forms.TabPage();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpCategoryFoodInfo = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCategoryFoodID = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCategoryFoodName = new Guna.UI2.WinForms.Guna2TextBox();
            this.grpFunctionCategoryFood = new System.Windows.Forms.GroupBox();
            this.btnSaveCategoryFood = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddCategoryFood = new Guna.UI2.WinForms.Guna2Button();
            this.btnEditCategoryFood = new Guna.UI2.WinForms.Guna2Button();
            this.btnDeleteAllCategoryFood = new Guna.UI2.WinForms.Guna2Button();
            this.btnDeleteCategoryFood = new Guna.UI2.WinForms.Guna2Button();
            this.btnCategoryFoodDeleted = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1.SuspendLayout();
            this.tctrCategoryManager.SuspendLayout();
            this.tpCategoryFood.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListCategoryFood)).BeginInit();
            this.grpCategoryFoodInfo.SuspendLayout();
            this.grpFunctionCategoryFood.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(108)))), ((int)(((byte)(255)))));
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(917, 75);
            this.guna2Panel1.TabIndex = 0;
          
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(143, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(468, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ DANH MỤC";
        
            // 
            // tctrCategoryManager
            // 
            this.tctrCategoryManager.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tctrCategoryManager.Controls.Add(this.tpCategoryFood);
            this.tctrCategoryManager.Controls.Add(this.tpCategoryLocation);
            this.tctrCategoryManager.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tctrCategoryManager.ItemSize = new System.Drawing.Size(180, 40);
            this.tctrCategoryManager.Location = new System.Drawing.Point(0, 75);
            this.tctrCategoryManager.Name = "tctrCategoryManager";
            this.tctrCategoryManager.SelectedIndex = 0;
            this.tctrCategoryManager.Size = new System.Drawing.Size(917, 375);
            this.tctrCategoryManager.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.tctrCategoryManager.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.tctrCategoryManager.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tctrCategoryManager.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.tctrCategoryManager.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.tctrCategoryManager.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.tctrCategoryManager.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tctrCategoryManager.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tctrCategoryManager.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.tctrCategoryManager.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tctrCategoryManager.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.tctrCategoryManager.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.tctrCategoryManager.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tctrCategoryManager.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.tctrCategoryManager.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.tctrCategoryManager.TabButtonSize = new System.Drawing.Size(180, 40);
            this.tctrCategoryManager.TabIndex = 1;
            this.tctrCategoryManager.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            
            // 
            // tpCategoryFood
            // 
            this.tpCategoryFood.Controls.Add(this.grpFunctionCategoryFood);
            this.tpCategoryFood.Controls.Add(this.grpCategoryFoodInfo);
            this.tpCategoryFood.Controls.Add(this.dtgvListCategoryFood);
            this.tpCategoryFood.Location = new System.Drawing.Point(184, 4);
            this.tpCategoryFood.Name = "tpCategoryFood";
            this.tpCategoryFood.Padding = new System.Windows.Forms.Padding(3);
            this.tpCategoryFood.Size = new System.Drawing.Size(729, 367);
            this.tpCategoryFood.TabIndex = 0;
            this.tpCategoryFood.Text = "Danh mục ăn uống";
            this.tpCategoryFood.UseVisualStyleBackColor = true;
           
            // 
            // dtgvListCategoryFood
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dtgvListCategoryFood.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvListCategoryFood.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvListCategoryFood.ColumnHeadersHeight = 19;
            this.dtgvListCategoryFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtgvListCategoryFood.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvListCategoryFood.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvListCategoryFood.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgvListCategoryFood.Location = new System.Drawing.Point(34, 211);
            this.dtgvListCategoryFood.Name = "dtgvListCategoryFood";
            this.dtgvListCategoryFood.RowHeadersVisible = false;
            this.dtgvListCategoryFood.RowHeadersWidth = 51;
            this.dtgvListCategoryFood.RowTemplate.Height = 24;
            this.dtgvListCategoryFood.Size = new System.Drawing.Size(661, 150);
            this.dtgvListCategoryFood.TabIndex = 0;
            this.dtgvListCategoryFood.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgvListCategoryFood.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtgvListCategoryFood.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtgvListCategoryFood.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtgvListCategoryFood.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtgvListCategoryFood.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dtgvListCategoryFood.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgvListCategoryFood.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtgvListCategoryFood.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgvListCategoryFood.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgvListCategoryFood.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtgvListCategoryFood.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtgvListCategoryFood.ThemeStyle.HeaderStyle.Height = 19;
            this.dtgvListCategoryFood.ThemeStyle.ReadOnly = false;
            this.dtgvListCategoryFood.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgvListCategoryFood.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgvListCategoryFood.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgvListCategoryFood.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtgvListCategoryFood.ThemeStyle.RowsStyle.Height = 24;
            this.dtgvListCategoryFood.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgvListCategoryFood.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            
            // 
            // tpCategoryLocation
            // 
            this.tpCategoryLocation.Location = new System.Drawing.Point(184, 4);
            this.tpCategoryLocation.Name = "tpCategoryLocation";
            this.tpCategoryLocation.Padding = new System.Windows.Forms.Padding(3);
            this.tpCategoryLocation.Size = new System.Drawing.Size(612, 367);
            this.tpCategoryLocation.TabIndex = 1;
            this.tpCategoryLocation.Text = "Vị trí bàn ăn";
            this.tpCategoryLocation.UseVisualStyleBackColor = true;
           
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "CategoryID";
            this.Column1.HeaderText = "Mã danh mục";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "CategoryName";
            this.Column2.HeaderText = "Tên danh mục";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // grpCategoryFoodInfo
            // 
            this.grpCategoryFoodInfo.Controls.Add(this.txtCategoryFoodName);
            this.grpCategoryFoodInfo.Controls.Add(this.label3);
            this.grpCategoryFoodInfo.Controls.Add(this.txtCategoryFoodID);
            this.grpCategoryFoodInfo.Controls.Add(this.label2);
            this.grpCategoryFoodInfo.Location = new System.Drawing.Point(6, 6);
            this.grpCategoryFoodInfo.Name = "grpCategoryFoodInfo";
            this.grpCategoryFoodInfo.Size = new System.Drawing.Size(348, 184);
            this.grpCategoryFoodInfo.TabIndex = 1;
            this.grpCategoryFoodInfo.TabStop = false;
            this.grpCategoryFoodInfo.Text = "Thông tin danh mục";
           
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã danh mục:";
           
            // 
            // txtCategoryFoodID
            // 
            this.txtCategoryFoodID.BorderRadius = 20;
            this.txtCategoryFoodID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCategoryFoodID.DefaultText = "";
            this.txtCategoryFoodID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCategoryFoodID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCategoryFoodID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCategoryFoodID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCategoryFoodID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCategoryFoodID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCategoryFoodID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCategoryFoodID.Location = new System.Drawing.Point(143, 33);
            this.txtCategoryFoodID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCategoryFoodID.Name = "txtCategoryFoodID";
            this.txtCategoryFoodID.PasswordChar = '\0';
            this.txtCategoryFoodID.PlaceholderText = "";
            this.txtCategoryFoodID.SelectedText = "";
            this.txtCategoryFoodID.Size = new System.Drawing.Size(188, 37);
            this.txtCategoryFoodID.TabIndex = 1;
          
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên danh mục:";
           
            // 
            // txtCategoryFoodName
            // 
            this.txtCategoryFoodName.BorderRadius = 20;
            this.txtCategoryFoodName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCategoryFoodName.DefaultText = "";
            this.txtCategoryFoodName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCategoryFoodName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCategoryFoodName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCategoryFoodName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCategoryFoodName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCategoryFoodName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCategoryFoodName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCategoryFoodName.Location = new System.Drawing.Point(143, 94);
            this.txtCategoryFoodName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCategoryFoodName.Name = "txtCategoryFoodName";
            this.txtCategoryFoodName.PasswordChar = '\0';
            this.txtCategoryFoodName.PlaceholderText = "";
            this.txtCategoryFoodName.SelectedText = "";
            this.txtCategoryFoodName.Size = new System.Drawing.Size(188, 37);
            this.txtCategoryFoodName.TabIndex = 3;
           
            // 
            // grpFunctionCategoryFood
            // 
            this.grpFunctionCategoryFood.Controls.Add(this.btnSaveCategoryFood);
            this.grpFunctionCategoryFood.Controls.Add(this.btnAddCategoryFood);
            this.grpFunctionCategoryFood.Controls.Add(this.btnEditCategoryFood);
            this.grpFunctionCategoryFood.Controls.Add(this.btnDeleteAllCategoryFood);
            this.grpFunctionCategoryFood.Controls.Add(this.btnDeleteCategoryFood);
            this.grpFunctionCategoryFood.Controls.Add(this.btnCategoryFoodDeleted);
            this.grpFunctionCategoryFood.Location = new System.Drawing.Point(388, 6);
            this.grpFunctionCategoryFood.Name = "grpFunctionCategoryFood";
            this.grpFunctionCategoryFood.Size = new System.Drawing.Size(333, 184);
            this.grpFunctionCategoryFood.TabIndex = 2;
            this.grpFunctionCategoryFood.TabStop = false;
            this.grpFunctionCategoryFood.Text = "Chức năng";
           
            // 
            // btnSaveCategoryFood
            // 
            this.btnSaveCategoryFood.BorderRadius = 20;
            this.btnSaveCategoryFood.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSaveCategoryFood.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSaveCategoryFood.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSaveCategoryFood.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSaveCategoryFood.Enabled = false;
            this.btnSaveCategoryFood.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(51)))), ((int)(((byte)(255)))));
            this.btnSaveCategoryFood.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSaveCategoryFood.ForeColor = System.Drawing.Color.Black;
            this.btnSaveCategoryFood.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveCategoryFood.Image")));
            this.btnSaveCategoryFood.ImageSize = new System.Drawing.Size(30, 30);
            this.btnSaveCategoryFood.Location = new System.Drawing.Point(163, 25);
            this.btnSaveCategoryFood.Name = "btnSaveCategoryFood";
            this.btnSaveCategoryFood.Size = new System.Drawing.Size(164, 45);
            this.btnSaveCategoryFood.TabIndex = 33;
            this.btnSaveCategoryFood.Text = "Lưu";
          
            // 
            // btnAddCategoryFood
            // 
            this.btnAddCategoryFood.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAddCategoryFood.BorderRadius = 20;
            this.btnAddCategoryFood.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddCategoryFood.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddCategoryFood.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddCategoryFood.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddCategoryFood.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(255)))), ((int)(((byte)(51)))));
            this.btnAddCategoryFood.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddCategoryFood.ForeColor = System.Drawing.Color.Black;
            this.btnAddCategoryFood.Image = ((System.Drawing.Image)(resources.GetObject("btnAddCategoryFood.Image")));
            this.btnAddCategoryFood.ImageSize = new System.Drawing.Size(30, 30);
            this.btnAddCategoryFood.Location = new System.Drawing.Point(6, 25);
            this.btnAddCategoryFood.Name = "btnAddCategoryFood";
            this.btnAddCategoryFood.Size = new System.Drawing.Size(124, 45);
            this.btnAddCategoryFood.TabIndex = 28;
            this.btnAddCategoryFood.Text = "Thêm";
           
            // 
            // btnEditCategoryFood
            // 
            this.btnEditCategoryFood.BorderRadius = 20;
            this.btnEditCategoryFood.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEditCategoryFood.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEditCategoryFood.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEditCategoryFood.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEditCategoryFood.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(233)))), ((int)(((byte)(255)))));
            this.btnEditCategoryFood.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEditCategoryFood.ForeColor = System.Drawing.Color.Black;
            this.btnEditCategoryFood.Image = ((System.Drawing.Image)(resources.GetObject("btnEditCategoryFood.Image")));
            this.btnEditCategoryFood.ImageSize = new System.Drawing.Size(30, 30);
            this.btnEditCategoryFood.Location = new System.Drawing.Point(6, 76);
            this.btnEditCategoryFood.Name = "btnEditCategoryFood";
            this.btnEditCategoryFood.Size = new System.Drawing.Size(124, 45);
            this.btnEditCategoryFood.TabIndex = 29;
            this.btnEditCategoryFood.Text = "Sửa";
           
            // 
            // btnDeleteAllCategoryFood
            // 
            this.btnDeleteAllCategoryFood.BorderColor = System.Drawing.Color.Red;
            this.btnDeleteAllCategoryFood.BorderRadius = 10;
            this.btnDeleteAllCategoryFood.BorderThickness = 2;
            this.btnDeleteAllCategoryFood.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteAllCategoryFood.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteAllCategoryFood.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDeleteAllCategoryFood.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDeleteAllCategoryFood.FillColor = System.Drawing.Color.White;
            this.btnDeleteAllCategoryFood.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDeleteAllCategoryFood.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteAllCategoryFood.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteAllCategoryFood.Image")));
            this.btnDeleteAllCategoryFood.ImageSize = new System.Drawing.Size(30, 30);
            this.btnDeleteAllCategoryFood.Location = new System.Drawing.Point(163, 135);
            this.btnDeleteAllCategoryFood.Name = "btnDeleteAllCategoryFood";
            this.btnDeleteAllCategoryFood.Size = new System.Drawing.Size(164, 43);
            this.btnDeleteAllCategoryFood.TabIndex = 32;
            this.btnDeleteAllCategoryFood.Text = "Xóa tất cả";
            
            // 
            // btnDeleteCategoryFood
            // 
            this.btnDeleteCategoryFood.BorderRadius = 20;
            this.btnDeleteCategoryFood.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteCategoryFood.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteCategoryFood.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDeleteCategoryFood.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDeleteCategoryFood.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(85)))));
            this.btnDeleteCategoryFood.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDeleteCategoryFood.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteCategoryFood.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteCategoryFood.Image")));
            this.btnDeleteCategoryFood.ImageSize = new System.Drawing.Size(30, 30);
            this.btnDeleteCategoryFood.Location = new System.Drawing.Point(6, 133);
            this.btnDeleteCategoryFood.Name = "btnDeleteCategoryFood";
            this.btnDeleteCategoryFood.Size = new System.Drawing.Size(124, 45);
            this.btnDeleteCategoryFood.TabIndex = 30;
            this.btnDeleteCategoryFood.Text = "Xóa";
           
            // 
            // btnCategoryFoodDeleted
            // 
            this.btnCategoryFoodDeleted.BorderRadius = 20;
            this.btnCategoryFoodDeleted.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCategoryFoodDeleted.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCategoryFoodDeleted.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCategoryFoodDeleted.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCategoryFoodDeleted.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(184)))));
            this.btnCategoryFoodDeleted.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCategoryFoodDeleted.ForeColor = System.Drawing.Color.Black;
            this.btnCategoryFoodDeleted.Image = ((System.Drawing.Image)(resources.GetObject("btnCategoryFoodDeleted.Image")));
            this.btnCategoryFoodDeleted.ImageSize = new System.Drawing.Size(30, 30);
            this.btnCategoryFoodDeleted.Location = new System.Drawing.Point(163, 76);
            this.btnCategoryFoodDeleted.Name = "btnCategoryFoodDeleted";
            this.btnCategoryFoodDeleted.Size = new System.Drawing.Size(164, 45);
            this.btnCategoryFoodDeleted.TabIndex = 31;
            this.btnCategoryFoodDeleted.Text = "Danh mục đã xóa";
           
            // 
            // frmCategoryManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 450);
            this.Controls.Add(this.tctrCategoryManager);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "frmCategoryManager";
            this.Text = "CategoryManager";
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.tctrCategoryManager.ResumeLayout(false);
            this.tpCategoryFood.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListCategoryFood)).EndInit();
            this.grpCategoryFoodInfo.ResumeLayout(false);
            this.grpCategoryFoodInfo.PerformLayout();
            this.grpFunctionCategoryFood.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TabControl tctrCategoryManager;
        private System.Windows.Forms.TabPage tpCategoryFood;
        private System.Windows.Forms.TabPage tpCategoryLocation;
        private Guna.UI2.WinForms.Guna2DataGridView dtgvListCategoryFood;
        private System.Windows.Forms.GroupBox grpFunctionCategoryFood;
        private System.Windows.Forms.GroupBox grpCategoryFoodInfo;
        private Guna.UI2.WinForms.Guna2TextBox txtCategoryFoodName;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtCategoryFoodID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private Guna.UI2.WinForms.Guna2Button btnSaveCategoryFood;
        private Guna.UI2.WinForms.Guna2Button btnAddCategoryFood;
        private Guna.UI2.WinForms.Guna2Button btnEditCategoryFood;
        private Guna.UI2.WinForms.Guna2Button btnDeleteAllCategoryFood;
        private Guna.UI2.WinForms.Guna2Button btnDeleteCategoryFood;
        private Guna.UI2.WinForms.Guna2Button btnCategoryFoodDeleted;
    }
}