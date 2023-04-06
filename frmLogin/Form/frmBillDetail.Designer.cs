
namespace frmLogin
{
    partial class frmBillDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBillDetail));
            this.grpBillDetail = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbSize = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProductName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBillID = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgvBillDetail = new Guna.UI2.WinForms.Guna2DataGridView();
            this.grpFunctionBillDetail = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnExitFomBillDetail = new System.Windows.Forms.Button();
            this.btnDeleteAllBillDetail = new Guna.UI2.WinForms.Guna2Button();
            this.btnBillDetailDeleted = new Guna.UI2.WinForms.Guna2Button();
            this.btnRefreshBillDetail = new Guna.UI2.WinForms.Guna2Button();
            this.btnDeleteBillDetail = new Guna.UI2.WinForms.Guna2Button();
            this.btnEditBillInfo = new Guna.UI2.WinForms.Guna2Button();
            this.grpBillDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBillDetail)).BeginInit();
            this.grpFunctionBillDetail.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBillDetail
            // 
            this.grpBillDetail.Controls.Add(this.label5);
            this.grpBillDetail.Controls.Add(this.txtPrice);
            this.grpBillDetail.Controls.Add(this.label4);
            this.grpBillDetail.Controls.Add(this.cbSize);
            this.grpBillDetail.Controls.Add(this.label3);
            this.grpBillDetail.Controls.Add(this.txtProductName);
            this.grpBillDetail.Controls.Add(this.label2);
            this.grpBillDetail.Controls.Add(this.txtBillID);
            this.grpBillDetail.Controls.Add(this.label1);
            this.grpBillDetail.Location = new System.Drawing.Point(12, 79);
            this.grpBillDetail.Name = "grpBillDetail";
            this.grpBillDetail.Size = new System.Drawing.Size(354, 233);
            this.grpBillDetail.TabIndex = 0;
            this.grpBillDetail.TabStop = false;
            this.grpBillDetail.Text = "Thông tin chi tiết";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(261, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "VNĐ";
            // 
            // txtPrice
            // 
            this.txtPrice.BorderRadius = 10;
            this.txtPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrice.DefaultText = "";
            this.txtPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrice.Location = new System.Drawing.Point(117, 178);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.PasswordChar = '\0';
            this.txtPrice.PlaceholderText = "";
            this.txtPrice.SelectedText = "";
            this.txtPrice.Size = new System.Drawing.Size(138, 40);
            this.txtPrice.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Thành tiền:";
            // 
            // cbSize
            // 
            this.cbSize.BackColor = System.Drawing.Color.Transparent;
            this.cbSize.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSize.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbSize.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbSize.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbSize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbSize.ItemHeight = 30;
            this.cbSize.Location = new System.Drawing.Point(115, 119);
            this.cbSize.Name = "cbSize";
            this.cbSize.Size = new System.Drawing.Size(140, 36);
            this.cbSize.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Kích thước:";
            // 
            // txtProductName
            // 
            this.txtProductName.BorderRadius = 10;
            this.txtProductName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProductName.DefaultText = "";
            this.txtProductName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtProductName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtProductName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtProductName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtProductName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtProductName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtProductName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtProductName.Location = new System.Drawing.Point(115, 70);
            this.txtProductName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.PasswordChar = '\0';
            this.txtProductName.PlaceholderText = "";
            this.txtProductName.SelectedText = "";
            this.txtProductName.Size = new System.Drawing.Size(180, 40);
            this.txtProductName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên sản phẩm:";
            // 
            // txtBillID
            // 
            this.txtBillID.BorderRadius = 10;
            this.txtBillID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBillID.DefaultText = "";
            this.txtBillID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBillID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBillID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBillID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBillID.Enabled = false;
            this.txtBillID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBillID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBillID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBillID.Location = new System.Drawing.Point(115, 22);
            this.txtBillID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBillID.Name = "txtBillID";
            this.txtBillID.PasswordChar = '\0';
            this.txtBillID.PlaceholderText = "";
            this.txtBillID.SelectedText = "";
            this.txtBillID.Size = new System.Drawing.Size(180, 40);
            this.txtBillID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã hóa đơn:";
            // 
            // dtgvBillDetail
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dtgvBillDetail.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvBillDetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvBillDetail.ColumnHeadersHeight = 4;
            this.dtgvBillDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvBillDetail.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvBillDetail.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgvBillDetail.Location = new System.Drawing.Point(0, 318);
            this.dtgvBillDetail.Name = "dtgvBillDetail";
            this.dtgvBillDetail.RowHeadersVisible = false;
            this.dtgvBillDetail.RowHeadersWidth = 51;
            this.dtgvBillDetail.RowTemplate.Height = 24;
            this.dtgvBillDetail.Size = new System.Drawing.Size(797, 213);
            this.dtgvBillDetail.TabIndex = 1;
            this.dtgvBillDetail.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgvBillDetail.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtgvBillDetail.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtgvBillDetail.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtgvBillDetail.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtgvBillDetail.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dtgvBillDetail.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgvBillDetail.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtgvBillDetail.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgvBillDetail.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgvBillDetail.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtgvBillDetail.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtgvBillDetail.ThemeStyle.HeaderStyle.Height = 4;
            this.dtgvBillDetail.ThemeStyle.ReadOnly = false;
            this.dtgvBillDetail.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgvBillDetail.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgvBillDetail.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgvBillDetail.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtgvBillDetail.ThemeStyle.RowsStyle.Height = 24;
            this.dtgvBillDetail.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgvBillDetail.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // grpFunctionBillDetail
            // 
            this.grpFunctionBillDetail.Controls.Add(this.btnDeleteAllBillDetail);
            this.grpFunctionBillDetail.Controls.Add(this.btnBillDetailDeleted);
            this.grpFunctionBillDetail.Controls.Add(this.btnRefreshBillDetail);
            this.grpFunctionBillDetail.Controls.Add(this.btnDeleteBillDetail);
            this.grpFunctionBillDetail.Controls.Add(this.btnEditBillInfo);
            this.grpFunctionBillDetail.Location = new System.Drawing.Point(414, 79);
            this.grpFunctionBillDetail.Name = "grpFunctionBillDetail";
            this.grpFunctionBillDetail.Size = new System.Drawing.Size(339, 233);
            this.grpFunctionBillDetail.TabIndex = 2;
            this.grpFunctionBillDetail.TabStop = false;
            this.grpFunctionBillDetail.Text = "Chức năng";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panel1.Controls.Add(this.btnExitFomBillDetail);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 73);
            this.panel1.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(196, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(423, 52);
            this.label6.TabIndex = 0;
            this.label6.Text = "CHI TIẾT HÓA ĐƠN";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(522, 534);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "Tổng tiền:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(637, 537);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(16, 17);
            this.lblTotal.TabIndex = 5;
            this.lblTotal.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(760, 537);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 17);
            this.label8.TabIndex = 6;
            this.label8.Text = "VNĐ";
            // 
            // btnExitFomBillDetail
            // 
            this.btnExitFomBillDetail.FlatAppearance.BorderSize = 0;
            this.btnExitFomBillDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExitFomBillDetail.Image = ((System.Drawing.Image)(resources.GetObject("btnExitFomBillDetail.Image")));
            this.btnExitFomBillDetail.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnExitFomBillDetail.Location = new System.Drawing.Point(728, 3);
            this.btnExitFomBillDetail.Name = "btnExitFomBillDetail";
            this.btnExitFomBillDetail.Size = new System.Drawing.Size(69, 45);
            this.btnExitFomBillDetail.TabIndex = 6;
            this.btnExitFomBillDetail.UseVisualStyleBackColor = true;
            this.btnExitFomBillDetail.Click += new System.EventHandler(this.btnExitFomBillDetail_Click);
            // 
            // btnDeleteAllBillDetail
            // 
            this.btnDeleteAllBillDetail.BorderColor = System.Drawing.Color.Red;
            this.btnDeleteAllBillDetail.BorderRadius = 10;
            this.btnDeleteAllBillDetail.BorderThickness = 2;
            this.btnDeleteAllBillDetail.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteAllBillDetail.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteAllBillDetail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDeleteAllBillDetail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDeleteAllBillDetail.FillColor = System.Drawing.Color.White;
            this.btnDeleteAllBillDetail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDeleteAllBillDetail.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteAllBillDetail.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteAllBillDetail.Image")));
            this.btnDeleteAllBillDetail.ImageSize = new System.Drawing.Size(30, 30);
            this.btnDeleteAllBillDetail.Location = new System.Drawing.Point(91, 175);
            this.btnDeleteAllBillDetail.Name = "btnDeleteAllBillDetail";
            this.btnDeleteAllBillDetail.Size = new System.Drawing.Size(148, 43);
            this.btnDeleteAllBillDetail.TabIndex = 30;
            this.btnDeleteAllBillDetail.Text = "Xóa tất cả";
            // 
            // btnBillDetailDeleted
            // 
            this.btnBillDetailDeleted.BorderRadius = 20;
            this.btnBillDetailDeleted.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBillDetailDeleted.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBillDetailDeleted.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBillDetailDeleted.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBillDetailDeleted.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(184)))));
            this.btnBillDetailDeleted.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBillDetailDeleted.ForeColor = System.Drawing.Color.Black;
            this.btnBillDetailDeleted.Image = ((System.Drawing.Image)(resources.GetObject("btnBillDetailDeleted.Image")));
            this.btnBillDetailDeleted.ImageSize = new System.Drawing.Size(30, 30);
            this.btnBillDetailDeleted.Location = new System.Drawing.Point(185, 99);
            this.btnBillDetailDeleted.Name = "btnBillDetailDeleted";
            this.btnBillDetailDeleted.Size = new System.Drawing.Size(148, 45);
            this.btnBillDetailDeleted.TabIndex = 29;
            this.btnBillDetailDeleted.Text = " Đã xóa";
            this.btnBillDetailDeleted.Click += new System.EventHandler(this.btnBillDetailDeleted_Click);
            // 
            // btnRefreshBillDetail
            // 
            this.btnRefreshBillDetail.BorderRadius = 20;
            this.btnRefreshBillDetail.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRefreshBillDetail.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRefreshBillDetail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRefreshBillDetail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRefreshBillDetail.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(51)))), ((int)(((byte)(255)))));
            this.btnRefreshBillDetail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRefreshBillDetail.ForeColor = System.Drawing.Color.Black;
            this.btnRefreshBillDetail.Image = ((System.Drawing.Image)(resources.GetObject("btnRefreshBillDetail.Image")));
            this.btnRefreshBillDetail.ImageSize = new System.Drawing.Size(30, 30);
            this.btnRefreshBillDetail.Location = new System.Drawing.Point(185, 31);
            this.btnRefreshBillDetail.Name = "btnRefreshBillDetail";
            this.btnRefreshBillDetail.Size = new System.Drawing.Size(148, 45);
            this.btnRefreshBillDetail.TabIndex = 28;
            this.btnRefreshBillDetail.Text = "Làm mới";
            // 
            // btnDeleteBillDetail
            // 
            this.btnDeleteBillDetail.BorderRadius = 20;
            this.btnDeleteBillDetail.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteBillDetail.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteBillDetail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDeleteBillDetail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDeleteBillDetail.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(85)))));
            this.btnDeleteBillDetail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDeleteBillDetail.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteBillDetail.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteBillDetail.Image")));
            this.btnDeleteBillDetail.ImageSize = new System.Drawing.Size(30, 30);
            this.btnDeleteBillDetail.Location = new System.Drawing.Point(6, 99);
            this.btnDeleteBillDetail.Name = "btnDeleteBillDetail";
            this.btnDeleteBillDetail.Size = new System.Drawing.Size(139, 45);
            this.btnDeleteBillDetail.TabIndex = 1;
            this.btnDeleteBillDetail.Text = "Xóa";
            // 
            // btnEditBillInfo
            // 
            this.btnEditBillInfo.BorderRadius = 20;
            this.btnEditBillInfo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEditBillInfo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEditBillInfo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEditBillInfo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEditBillInfo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEditBillInfo.ForeColor = System.Drawing.Color.Black;
            this.btnEditBillInfo.Image = ((System.Drawing.Image)(resources.GetObject("btnEditBillInfo.Image")));
            this.btnEditBillInfo.ImageSize = new System.Drawing.Size(30, 30);
            this.btnEditBillInfo.Location = new System.Drawing.Point(6, 31);
            this.btnEditBillInfo.Name = "btnEditBillInfo";
            this.btnEditBillInfo.Size = new System.Drawing.Size(139, 45);
            this.btnEditBillInfo.TabIndex = 0;
            this.btnEditBillInfo.Text = "Sửa";
            // 
            // frmBillDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 563);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grpFunctionBillDetail);
            this.Controls.Add(this.dtgvBillDetail);
            this.Controls.Add(this.grpBillDetail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBillDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chi tiết hóa đơn";
            this.grpBillDetail.ResumeLayout(false);
            this.grpBillDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBillDetail)).EndInit();
            this.grpFunctionBillDetail.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBillDetail;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txtPrice;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2ComboBox cbSize;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtProductName;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtBillID;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView dtgvBillDetail;
        private System.Windows.Forms.GroupBox grpFunctionBillDetail;
        private Guna.UI2.WinForms.Guna2Button btnEditBillInfo;
        private Guna.UI2.WinForms.Guna2Button btnDeleteBillDetail;
        private Guna.UI2.WinForms.Guna2Button btnRefreshBillDetail;
        private Guna.UI2.WinForms.Guna2Button btnBillDetailDeleted;
        private Guna.UI2.WinForms.Guna2Button btnDeleteAllBillDetail;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnExitFomBillDetail;
    }
}