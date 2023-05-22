
namespace frmLogin
{
    partial class frmSelectDish
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSelectDish));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExitFomSelectDish = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lstvListDish = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.cbCategoryDish = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSearchDish = new Guna.UI2.WinForms.Guna2TextBox();
            this.grpDishDetail = new System.Windows.Forms.GroupBox();
            this.numQuantity = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDishPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCategoryDish = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDishName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pbPictureDish = new Guna.UI2.WinForms.Guna2PictureBox();
            this.flpAddDish = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSelectDish = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddDish = new Guna.UI2.WinForms.Guna2Button();
            this.btnSearchDish = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            this.grpDishDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPictureDish)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(108)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.btnExitFomSelectDish);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Name = "panel1";
            // 
            // btnExitFomSelectDish
            // 
            resources.ApplyResources(this.btnExitFomSelectDish, "btnExitFomSelectDish");
            this.btnExitFomSelectDish.FlatAppearance.BorderSize = 0;
            this.btnExitFomSelectDish.Name = "btnExitFomSelectDish";
            this.btnExitFomSelectDish.UseVisualStyleBackColor = true;
            this.btnExitFomSelectDish.Click += new System.EventHandler(this.btnExitFomSelectDish_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Name = "label2";
            // 
            // lstvListDish
            // 
            resources.ApplyResources(this.lstvListDish, "lstvListDish");
            this.lstvListDish.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lstvListDish.HideSelection = false;
            this.lstvListDish.LargeImageList = this.imageList1;
            this.lstvListDish.Name = "lstvListDish";
            this.lstvListDish.UseCompatibleStateImageBehavior = false;
            this.lstvListDish.SelectedIndexChanged += new System.EventHandler(this.lstvListDish_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            resources.ApplyResources(this.columnHeader1, "columnHeader1");
            // 
            // columnHeader2
            // 
            resources.ApplyResources(this.columnHeader2, "columnHeader2");
            // 
            // columnHeader3
            // 
            resources.ApplyResources(this.columnHeader3, "columnHeader3");
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth16Bit;
            resources.ApplyResources(this.imageList1, "imageList1");
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // cbCategoryDish
            // 
            resources.ApplyResources(this.cbCategoryDish, "cbCategoryDish");
            this.cbCategoryDish.BackColor = System.Drawing.Color.Transparent;
            this.cbCategoryDish.BorderRadius = 10;
            this.cbCategoryDish.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbCategoryDish.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategoryDish.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbCategoryDish.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbCategoryDish.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbCategoryDish.Items.AddRange(new object[] {
            resources.GetString("cbCategoryDish.Items")});
            this.cbCategoryDish.Name = "cbCategoryDish";
            this.cbCategoryDish.SelectedIndexChanged += new System.EventHandler(this.cbCategoryDish_SelectedIndexChanged);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // txtSearchDish
            // 
            resources.ApplyResources(this.txtSearchDish, "txtSearchDish");
            this.txtSearchDish.BorderRadius = 10;
            this.txtSearchDish.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchDish.DefaultText = "";
            this.txtSearchDish.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearchDish.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearchDish.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchDish.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchDish.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchDish.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchDish.Name = "txtSearchDish";
            this.txtSearchDish.PasswordChar = '\0';
            this.txtSearchDish.PlaceholderText = "";
            this.txtSearchDish.SelectedText = "";
            // 
            // grpDishDetail
            // 
            resources.ApplyResources(this.grpDishDetail, "grpDishDetail");
            this.grpDishDetail.Controls.Add(this.numQuantity);
            this.grpDishDetail.Controls.Add(this.label7);
            this.grpDishDetail.Controls.Add(this.txtDishPrice);
            this.grpDishDetail.Controls.Add(this.label6);
            this.grpDishDetail.Controls.Add(this.txtCategoryDish);
            this.grpDishDetail.Controls.Add(this.label5);
            this.grpDishDetail.Controls.Add(this.txtDishName);
            this.grpDishDetail.Controls.Add(this.label4);
            this.grpDishDetail.Controls.Add(this.pbPictureDish);
            this.grpDishDetail.Name = "grpDishDetail";
            this.grpDishDetail.TabStop = false;
            // 
            // numQuantity
            // 
            resources.ApplyResources(this.numQuantity, "numQuantity");
            this.numQuantity.BackColor = System.Drawing.Color.Transparent;
            this.numQuantity.Cursor = System.Windows.Forms.Cursors.IBeam;
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
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // txtDishPrice
            // 
            resources.ApplyResources(this.txtDishPrice, "txtDishPrice");
            this.txtDishPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDishPrice.DefaultText = "";
            this.txtDishPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDishPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDishPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDishPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDishPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDishPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDishPrice.Name = "txtDishPrice";
            this.txtDishPrice.PasswordChar = '\0';
            this.txtDishPrice.PlaceholderText = "";
            this.txtDishPrice.ReadOnly = true;
            this.txtDishPrice.SelectedText = "";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // txtCategoryDish
            // 
            resources.ApplyResources(this.txtCategoryDish, "txtCategoryDish");
            this.txtCategoryDish.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCategoryDish.DefaultText = "";
            this.txtCategoryDish.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCategoryDish.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCategoryDish.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCategoryDish.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCategoryDish.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCategoryDish.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCategoryDish.Name = "txtCategoryDish";
            this.txtCategoryDish.PasswordChar = '\0';
            this.txtCategoryDish.PlaceholderText = "";
            this.txtCategoryDish.ReadOnly = true;
            this.txtCategoryDish.SelectedText = "";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // txtDishName
            // 
            resources.ApplyResources(this.txtDishName, "txtDishName");
            this.txtDishName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDishName.DefaultText = "";
            this.txtDishName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDishName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDishName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDishName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDishName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDishName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDishName.Name = "txtDishName";
            this.txtDishName.PasswordChar = '\0';
            this.txtDishName.PlaceholderText = "";
            this.txtDishName.ReadOnly = true;
            this.txtDishName.SelectedText = "";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // pbPictureDish
            // 
            resources.ApplyResources(this.pbPictureDish, "pbPictureDish");
            this.pbPictureDish.ImageRotate = 0F;
            this.pbPictureDish.Name = "pbPictureDish";
            this.pbPictureDish.TabStop = false;
            // 
            // flpAddDish
            // 
            resources.ApplyResources(this.flpAddDish, "flpAddDish");
            this.flpAddDish.Name = "flpAddDish";
            // 
            // btnSelectDish
            // 
            resources.ApplyResources(this.btnSelectDish, "btnSelectDish");
            this.btnSelectDish.BorderRadius = 20;
            this.btnSelectDish.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSelectDish.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSelectDish.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSelectDish.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSelectDish.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(51)))), ((int)(((byte)(255)))));
            this.btnSelectDish.ForeColor = System.Drawing.Color.White;
            this.btnSelectDish.Image = ((System.Drawing.Image)(resources.GetObject("btnSelectDish.Image")));
            this.btnSelectDish.ImageSize = new System.Drawing.Size(30, 30);
            this.btnSelectDish.Name = "btnSelectDish";
            this.btnSelectDish.Click += new System.EventHandler(this.btnSelectDish_Click);
            // 
            // btnAddDish
            // 
            resources.ApplyResources(this.btnAddDish, "btnAddDish");
            this.btnAddDish.BorderRadius = 20;
            this.btnAddDish.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddDish.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddDish.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddDish.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddDish.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(255)))), ((int)(((byte)(51)))));
            this.btnAddDish.ForeColor = System.Drawing.Color.White;
            this.btnAddDish.Image = ((System.Drawing.Image)(resources.GetObject("btnAddDish.Image")));
            this.btnAddDish.ImageSize = new System.Drawing.Size(30, 30);
            this.btnAddDish.Name = "btnAddDish";
            this.btnAddDish.Click += new System.EventHandler(this.btnAddDish_Click);
            // 
            // btnSearchDish
            // 
            resources.ApplyResources(this.btnSearchDish, "btnSearchDish");
            this.btnSearchDish.BorderRadius = 10;
            this.btnSearchDish.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSearchDish.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSearchDish.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSearchDish.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSearchDish.FillColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSearchDish.ForeColor = System.Drawing.Color.White;
            this.btnSearchDish.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchDish.Image")));
            this.btnSearchDish.Name = "btnSearchDish";
            this.btnSearchDish.Click += new System.EventHandler(this.btnSearchDish_Click);
            // 
            // frmSelectDish
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.btnSelectDish);
            this.Controls.Add(this.flpAddDish);
            this.Controls.Add(this.btnAddDish);
            this.Controls.Add(this.grpDishDetail);
            this.Controls.Add(this.btnSearchDish);
            this.Controls.Add(this.txtSearchDish);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbCategoryDish);
            this.Controls.Add(this.lstvListDish);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSelectDish";
            this.Load += new System.EventHandler(this.frmSelectDish_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grpDishDetail.ResumeLayout(false);
            this.grpDishDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPictureDish)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lstvListDish;
        private Guna.UI2.WinForms.Guna2ComboBox cbCategoryDish;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchDish;
        private Guna.UI2.WinForms.Guna2Button btnSearchDish;
        private System.Windows.Forms.GroupBox grpDishDetail;
        private Guna.UI2.WinForms.Guna2Button btnAddDish;
        private Guna.UI2.WinForms.Guna2NumericUpDown numQuantity;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox txtDishPrice;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox txtCategoryDish;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txtDishName;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2PictureBox pbPictureDish;
        private System.Windows.Forms.Button btnExitFomSelectDish;
        private System.Windows.Forms.FlowLayoutPanel flpAddDish;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ImageList imageList1;
        private Guna.UI2.WinForms.Guna2Button btnSelectDish;
    }
}