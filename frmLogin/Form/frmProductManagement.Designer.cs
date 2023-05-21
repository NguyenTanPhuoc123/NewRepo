
namespace frmLogin
{
    partial class frmProductManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProductManagement));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbSortProduct = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtSearchProduct = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbFillProduct = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dtgvListProduct = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpProductInfo = new System.Windows.Forms.GroupBox();
            this.richtxtDescribe = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.numQuantity = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.cbCategory = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtProductName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtProductID = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pbProduct = new System.Windows.Forms.PictureBox();
            this.grpFunction = new System.Windows.Forms.GroupBox();
            this.btnSaveProduct = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddProduct = new Guna.UI2.WinForms.Guna2Button();
            this.btnEditProduct = new Guna.UI2.WinForms.Guna2Button();
            this.btnDeleteAllProduct = new Guna.UI2.WinForms.Guna2Button();
            this.btnDeleteProduct = new Guna.UI2.WinForms.Guna2Button();
            this.btnProductDeleted = new Guna.UI2.WinForms.Guna2Button();
            this.ofdImage = new System.Windows.Forms.OpenFileDialog();
            this.btnSearchProduct = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListProduct)).BeginInit();
            this.grpProductInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProduct)).BeginInit();
            this.grpFunction.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // cbSortProduct
            // 
            resources.ApplyResources(this.cbSortProduct, "cbSortProduct");
            this.cbSortProduct.BackColor = System.Drawing.Color.Transparent;
            this.cbSortProduct.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbSortProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSortProduct.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbSortProduct.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbSortProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbSortProduct.Items.AddRange(new object[] {
            resources.GetString("cbSortProduct.Items"),
            resources.GetString("cbSortProduct.Items1"),
            resources.GetString("cbSortProduct.Items2"),
            resources.GetString("cbSortProduct.Items3"),
            resources.GetString("cbSortProduct.Items4")});
            this.cbSortProduct.Name = "cbSortProduct";
            this.cbSortProduct.SelectedIndexChanged += new System.EventHandler(this.cbSortProduct_SelectedIndexChanged);
            // 
            // txtSearchProduct
            // 
            resources.ApplyResources(this.txtSearchProduct, "txtSearchProduct");
            this.txtSearchProduct.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchProduct.DefaultText = "";
            this.txtSearchProduct.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearchProduct.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearchProduct.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchProduct.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchProduct.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchProduct.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchProduct.Name = "txtSearchProduct";
            this.txtSearchProduct.PasswordChar = '\0';
            this.txtSearchProduct.PlaceholderText = "";
            this.txtSearchProduct.SelectedText = "";
            // 
            // cbFillProduct
            // 
            resources.ApplyResources(this.cbFillProduct, "cbFillProduct");
            this.cbFillProduct.BackColor = System.Drawing.Color.Transparent;
            this.cbFillProduct.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbFillProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFillProduct.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbFillProduct.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbFillProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbFillProduct.Items.AddRange(new object[] {
            resources.GetString("cbFillProduct.Items")});
            this.cbFillProduct.Name = "cbFillProduct";
            this.cbFillProduct.SelectedIndexChanged += new System.EventHandler(this.cbFillProduct_SelectedIndexChanged);
            // 
            // dtgvListProduct
            // 
            resources.ApplyResources(this.dtgvListProduct, "dtgvListProduct");
            this.dtgvListProduct.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dtgvListProduct.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvListProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvListProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtgvListProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column3,
            this.Column2,
            this.Column8,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvListProduct.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvListProduct.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgvListProduct.Name = "dtgvListProduct";
            this.dtgvListProduct.RowHeadersVisible = false;
            this.dtgvListProduct.RowTemplate.Height = 24;
            this.dtgvListProduct.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgvListProduct.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtgvListProduct.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtgvListProduct.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtgvListProduct.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtgvListProduct.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dtgvListProduct.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgvListProduct.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtgvListProduct.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgvListProduct.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgvListProduct.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtgvListProduct.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtgvListProduct.ThemeStyle.HeaderStyle.Height = 20;
            this.dtgvListProduct.ThemeStyle.ReadOnly = false;
            this.dtgvListProduct.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgvListProduct.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgvListProduct.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgvListProduct.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtgvListProduct.ThemeStyle.RowsStyle.Height = 24;
            this.dtgvListProduct.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgvListProduct.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtgvListProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvListProduct_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "HinhAnh";
            resources.ApplyResources(this.Column1, "Column1");
            this.Column1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Column1.Name = "Column1";
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "MASANPHAM";
            resources.ApplyResources(this.Column3, "Column3");
            this.Column3.Name = "Column3";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TENSANPHAM";
            resources.ApplyResources(this.Column2, "Column2");
            this.Column2.Name = "Column2";
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "TenDanhMuc";
            resources.ApplyResources(this.Column8, "Column8");
            this.Column8.Name = "Column8";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "DANHMUC";
            resources.ApplyResources(this.Column4, "Column4");
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "SOLUONG";
            resources.ApplyResources(this.Column5, "Column5");
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "DonGia";
            resources.ApplyResources(this.Column6, "Column6");
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "MoTa";
            resources.ApplyResources(this.Column7, "Column7");
            this.Column7.Name = "Column7";
            // 
            // grpProductInfo
            // 
            resources.ApplyResources(this.grpProductInfo, "grpProductInfo");
            this.grpProductInfo.Controls.Add(this.richtxtDescribe);
            this.grpProductInfo.Controls.Add(this.label9);
            this.grpProductInfo.Controls.Add(this.label8);
            this.grpProductInfo.Controls.Add(this.txtPrice);
            this.grpProductInfo.Controls.Add(this.label7);
            this.grpProductInfo.Controls.Add(this.numQuantity);
            this.grpProductInfo.Controls.Add(this.label6);
            this.grpProductInfo.Controls.Add(this.cbCategory);
            this.grpProductInfo.Controls.Add(this.label5);
            this.grpProductInfo.Controls.Add(this.txtProductName);
            this.grpProductInfo.Controls.Add(this.label4);
            this.grpProductInfo.Controls.Add(this.txtProductID);
            this.grpProductInfo.Controls.Add(this.label1);
            this.grpProductInfo.Controls.Add(this.pbProduct);
            this.grpProductInfo.Name = "grpProductInfo";
            this.grpProductInfo.TabStop = false;
            // 
            // richtxtDescribe
            // 
            resources.ApplyResources(this.richtxtDescribe, "richtxtDescribe");
            this.richtxtDescribe.Name = "richtxtDescribe";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // txtPrice
            // 
            resources.ApplyResources(this.txtPrice, "txtPrice");
            this.txtPrice.BorderRadius = 10;
            this.txtPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrice.DefaultText = "";
            this.txtPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.PasswordChar = '\0';
            this.txtPrice.PlaceholderText = "";
            this.txtPrice.SelectedText = "";
            this.txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrice_KeyPress);
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // numQuantity
            // 
            resources.ApplyResources(this.numQuantity, "numQuantity");
            this.numQuantity.BackColor = System.Drawing.Color.Transparent;
            this.numQuantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numQuantity.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numQuantity.Name = "numQuantity";
            this.numQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // cbCategory
            // 
            resources.ApplyResources(this.cbCategory, "cbCategory");
            this.cbCategory.BackColor = System.Drawing.Color.Transparent;
            this.cbCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategory.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbCategory.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbCategory.Name = "cbCategory";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // txtProductName
            // 
            resources.ApplyResources(this.txtProductName, "txtProductName");
            this.txtProductName.BorderRadius = 10;
            this.txtProductName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProductName.DefaultText = "";
            this.txtProductName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtProductName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtProductName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtProductName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtProductName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtProductName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.PasswordChar = '\0';
            this.txtProductName.PlaceholderText = "";
            this.txtProductName.SelectedText = "";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // txtProductID
            // 
            resources.ApplyResources(this.txtProductID, "txtProductID");
            this.txtProductID.BorderRadius = 10;
            this.txtProductID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProductID.DefaultText = "";
            this.txtProductID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtProductID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtProductID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtProductID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtProductID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtProductID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.PasswordChar = '\0';
            this.txtProductID.PlaceholderText = "";
            this.txtProductID.ReadOnly = true;
            this.txtProductID.SelectedText = "";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // pbProduct
            // 
            resources.ApplyResources(this.pbProduct, "pbProduct");
            this.pbProduct.Name = "pbProduct";
            this.pbProduct.TabStop = false;
            this.pbProduct.Click += new System.EventHandler(this.pbProduct_Click);
            // 
            // grpFunction
            // 
            resources.ApplyResources(this.grpFunction, "grpFunction");
            this.grpFunction.Controls.Add(this.btnSaveProduct);
            this.grpFunction.Controls.Add(this.btnAddProduct);
            this.grpFunction.Controls.Add(this.btnEditProduct);
            this.grpFunction.Controls.Add(this.btnDeleteAllProduct);
            this.grpFunction.Controls.Add(this.btnDeleteProduct);
            this.grpFunction.Controls.Add(this.btnProductDeleted);
            this.grpFunction.Name = "grpFunction";
            this.grpFunction.TabStop = false;
            // 
            // btnSaveProduct
            // 
            resources.ApplyResources(this.btnSaveProduct, "btnSaveProduct");
            this.btnSaveProduct.BorderRadius = 20;
            this.btnSaveProduct.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSaveProduct.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSaveProduct.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSaveProduct.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSaveProduct.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(51)))), ((int)(((byte)(255)))));
            this.btnSaveProduct.ForeColor = System.Drawing.Color.Black;
            this.btnSaveProduct.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveProduct.Image")));
            this.btnSaveProduct.ImageSize = new System.Drawing.Size(30, 30);
            this.btnSaveProduct.Name = "btnSaveProduct";
            this.btnSaveProduct.Click += new System.EventHandler(this.btnSaveProduct_Click);
            // 
            // btnAddProduct
            // 
            resources.ApplyResources(this.btnAddProduct, "btnAddProduct");
            this.btnAddProduct.BorderRadius = 20;
            this.btnAddProduct.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddProduct.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddProduct.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddProduct.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddProduct.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(255)))), ((int)(((byte)(51)))));
            this.btnAddProduct.ForeColor = System.Drawing.Color.Black;
            this.btnAddProduct.Image = ((System.Drawing.Image)(resources.GetObject("btnAddProduct.Image")));
            this.btnAddProduct.ImageSize = new System.Drawing.Size(30, 30);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // btnEditProduct
            // 
            resources.ApplyResources(this.btnEditProduct, "btnEditProduct");
            this.btnEditProduct.BorderRadius = 20;
            this.btnEditProduct.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEditProduct.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEditProduct.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEditProduct.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEditProduct.ForeColor = System.Drawing.Color.Black;
            this.btnEditProduct.Image = ((System.Drawing.Image)(resources.GetObject("btnEditProduct.Image")));
            this.btnEditProduct.ImageSize = new System.Drawing.Size(40, 40);
            this.btnEditProduct.Name = "btnEditProduct";
            this.btnEditProduct.Click += new System.EventHandler(this.btnEditProduct_Click);
            // 
            // btnDeleteAllProduct
            // 
            resources.ApplyResources(this.btnDeleteAllProduct, "btnDeleteAllProduct");
            this.btnDeleteAllProduct.BorderColor = System.Drawing.Color.Red;
            this.btnDeleteAllProduct.BorderRadius = 10;
            this.btnDeleteAllProduct.BorderThickness = 2;
            this.btnDeleteAllProduct.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteAllProduct.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteAllProduct.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDeleteAllProduct.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDeleteAllProduct.FillColor = System.Drawing.Color.White;
            this.btnDeleteAllProduct.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteAllProduct.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteAllProduct.Image")));
            this.btnDeleteAllProduct.ImageSize = new System.Drawing.Size(30, 30);
            this.btnDeleteAllProduct.Name = "btnDeleteAllProduct";
            // 
            // btnDeleteProduct
            // 
            resources.ApplyResources(this.btnDeleteProduct, "btnDeleteProduct");
            this.btnDeleteProduct.BorderRadius = 20;
            this.btnDeleteProduct.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteProduct.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteProduct.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDeleteProduct.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDeleteProduct.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(85)))));
            this.btnDeleteProduct.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteProduct.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteProduct.Image")));
            this.btnDeleteProduct.ImageSize = new System.Drawing.Size(30, 30);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // btnProductDeleted
            // 
            resources.ApplyResources(this.btnProductDeleted, "btnProductDeleted");
            this.btnProductDeleted.BorderRadius = 20;
            this.btnProductDeleted.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnProductDeleted.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnProductDeleted.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnProductDeleted.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnProductDeleted.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(184)))));
            this.btnProductDeleted.ForeColor = System.Drawing.Color.Black;
            this.btnProductDeleted.Image = ((System.Drawing.Image)(resources.GetObject("btnProductDeleted.Image")));
            this.btnProductDeleted.ImageSize = new System.Drawing.Size(30, 30);
            this.btnProductDeleted.Name = "btnProductDeleted";
            this.btnProductDeleted.Click += new System.EventHandler(this.btnProductDeleted_Click);
            // 
            // ofdImage
            // 
            this.ofdImage.FileName = "openFileDialog1";
            resources.ApplyResources(this.ofdImage, "ofdImage");
            // 
            // btnSearchProduct
            // 
            resources.ApplyResources(this.btnSearchProduct, "btnSearchProduct");
            this.btnSearchProduct.BorderRadius = 10;
            this.btnSearchProduct.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSearchProduct.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSearchProduct.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSearchProduct.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSearchProduct.FillColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSearchProduct.ForeColor = System.Drawing.Color.White;
            this.btnSearchProduct.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchProduct.Image")));
            this.btnSearchProduct.Name = "btnSearchProduct";
            this.btnSearchProduct.Click += new System.EventHandler(this.btnSearchProduct_Click);
            // 
            // frmProductManagement
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.grpFunction);
            this.Controls.Add(this.grpProductInfo);
            this.Controls.Add(this.dtgvListProduct);
            this.Controls.Add(this.cbFillProduct);
            this.Controls.Add(this.txtSearchProduct);
            this.Controls.Add(this.cbSortProduct);
            this.Controls.Add(this.btnSearchProduct);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "frmProductManagement";
            this.Load += new System.EventHandler(this.frmProductManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListProduct)).EndInit();
            this.grpProductInfo.ResumeLayout(false);
            this.grpProductInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProduct)).EndInit();
            this.grpFunction.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button btnSearchProduct;
        private Guna.UI2.WinForms.Guna2ComboBox cbSortProduct;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchProduct;
        private Guna.UI2.WinForms.Guna2ComboBox cbFillProduct;
        private Guna.UI2.WinForms.Guna2Button btnAddProduct;
        private Guna.UI2.WinForms.Guna2Button btnEditProduct;
        private Guna.UI2.WinForms.Guna2Button btnDeleteProduct;
        private Guna.UI2.WinForms.Guna2DataGridView dtgvListProduct;
        private Guna.UI2.WinForms.Guna2Button btnDeleteAllProduct;
        private Guna.UI2.WinForms.Guna2Button btnProductDeleted;
        private System.Windows.Forms.GroupBox grpProductInfo;
        private System.Windows.Forms.RichTextBox richtxtDescribe;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2TextBox txtPrice;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2NumericUpDown numQuantity;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2ComboBox cbCategory;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txtProductName;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txtProductID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbProduct;
        private System.Windows.Forms.GroupBox grpFunction;
        private System.Windows.Forms.OpenFileDialog ofdImage;
        private Guna.UI2.WinForms.Guna2Button btnSaveProduct;
        private System.Windows.Forms.DataGridViewImageColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}