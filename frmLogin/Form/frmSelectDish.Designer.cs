
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSelectDish));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lstvListDish = new System.Windows.Forms.ListView();
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
            this.btnSelectDish = new Guna.UI2.WinForms.Guna2Button();
            this.pbPictureDish = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnSearchDish = new Guna.UI2.WinForms.Guna2Button();
            this.btnExitFomSelectDish = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.grpDishDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPictureDish)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(414, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 18);
            this.label1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panel1.Controls.Add(this.btnExitFomSelectDish);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(991, 72);
            this.panel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(365, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(299, 55);
            this.label2.TabIndex = 3;
            this.label2.Text = "CHỌN MÓN";
            // 
            // lstvListDish
            // 
            this.lstvListDish.HideSelection = false;
            this.lstvListDish.Location = new System.Drawing.Point(12, 148);
            this.lstvListDish.Name = "lstvListDish";
            this.lstvListDish.Size = new System.Drawing.Size(522, 399);
            this.lstvListDish.TabIndex = 3;
            this.lstvListDish.UseCompatibleStateImageBehavior = false;
            // 
            // cbCategoryDish
            // 
            this.cbCategoryDish.BackColor = System.Drawing.Color.Transparent;
            this.cbCategoryDish.BorderRadius = 10;
            this.cbCategoryDish.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbCategoryDish.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategoryDish.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbCategoryDish.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbCategoryDish.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbCategoryDish.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbCategoryDish.ItemHeight = 30;
            this.cbCategoryDish.Location = new System.Drawing.Point(12, 105);
            this.cbCategoryDish.Name = "cbCategoryDish";
            this.cbCategoryDish.Size = new System.Drawing.Size(155, 36);
            this.cbCategoryDish.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Danh mục";
            // 
            // txtSearchDish
            // 
            this.txtSearchDish.BorderRadius = 10;
            this.txtSearchDish.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchDish.DefaultText = "";
            this.txtSearchDish.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearchDish.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearchDish.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchDish.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchDish.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchDish.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearchDish.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchDish.Location = new System.Drawing.Point(185, 105);
            this.txtSearchDish.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearchDish.Name = "txtSearchDish";
            this.txtSearchDish.PasswordChar = '\0';
            this.txtSearchDish.PlaceholderText = "";
            this.txtSearchDish.SelectedText = "";
            this.txtSearchDish.Size = new System.Drawing.Size(263, 36);
            this.txtSearchDish.TabIndex = 6;
            // 
            // grpDishDetail
            // 
            this.grpDishDetail.Controls.Add(this.btnSelectDish);
            this.grpDishDetail.Controls.Add(this.numQuantity);
            this.grpDishDetail.Controls.Add(this.label7);
            this.grpDishDetail.Controls.Add(this.txtDishPrice);
            this.grpDishDetail.Controls.Add(this.label6);
            this.grpDishDetail.Controls.Add(this.txtCategoryDish);
            this.grpDishDetail.Controls.Add(this.label5);
            this.grpDishDetail.Controls.Add(this.txtDishName);
            this.grpDishDetail.Controls.Add(this.label4);
            this.grpDishDetail.Controls.Add(this.pbPictureDish);
            this.grpDishDetail.Location = new System.Drawing.Point(552, 105);
            this.grpDishDetail.Name = "grpDishDetail";
            this.grpDishDetail.Size = new System.Drawing.Size(427, 442);
            this.grpDishDetail.TabIndex = 8;
            this.grpDishDetail.TabStop = false;
            this.grpDishDetail.Text = "Chi tiết món";
            // 
            // numQuantity
            // 
            this.numQuantity.BackColor = System.Drawing.Color.Transparent;
            this.numQuantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numQuantity.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numQuantity.Location = new System.Drawing.Point(88, 350);
            this.numQuantity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numQuantity.Name = "numQuantity";
            this.numQuantity.Size = new System.Drawing.Size(93, 43);
            this.numQuantity.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 362);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 18);
            this.label7.TabIndex = 7;
            this.label7.Text = "Số lượng:";
            // 
            // txtDishPrice
            // 
            this.txtDishPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDishPrice.DefaultText = "";
            this.txtDishPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDishPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDishPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDishPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDishPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDishPrice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDishPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDishPrice.Location = new System.Drawing.Point(88, 302);
            this.txtDishPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDishPrice.Name = "txtDishPrice";
            this.txtDishPrice.PasswordChar = '\0';
            this.txtDishPrice.PlaceholderText = "";
            this.txtDishPrice.ReadOnly = true;
            this.txtDishPrice.SelectedText = "";
            this.txtDishPrice.Size = new System.Drawing.Size(229, 40);
            this.txtDishPrice.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 319);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Đơn giá:";
            // 
            // txtCategoryDish
            // 
            this.txtCategoryDish.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCategoryDish.DefaultText = "";
            this.txtCategoryDish.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCategoryDish.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCategoryDish.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCategoryDish.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCategoryDish.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCategoryDish.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCategoryDish.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCategoryDish.Location = new System.Drawing.Point(88, 254);
            this.txtCategoryDish.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCategoryDish.Name = "txtCategoryDish";
            this.txtCategoryDish.PasswordChar = '\0';
            this.txtCategoryDish.PlaceholderText = "";
            this.txtCategoryDish.ReadOnly = true;
            this.txtCategoryDish.SelectedText = "";
            this.txtCategoryDish.Size = new System.Drawing.Size(229, 40);
            this.txtCategoryDish.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 18);
            this.label5.TabIndex = 3;
            this.label5.Text = "Danh mục";
            // 
            // txtDishName
            // 
            this.txtDishName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDishName.DefaultText = "";
            this.txtDishName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDishName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDishName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDishName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDishName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDishName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDishName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDishName.Location = new System.Drawing.Point(88, 206);
            this.txtDishName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDishName.Name = "txtDishName";
            this.txtDishName.PasswordChar = '\0';
            this.txtDishName.PlaceholderText = "";
            this.txtDishName.ReadOnly = true;
            this.txtDishName.SelectedText = "";
            this.txtDishName.Size = new System.Drawing.Size(229, 40);
            this.txtDishName.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tên món";
            // 
            // btnSelectDish
            // 
            this.btnSelectDish.BorderRadius = 20;
            this.btnSelectDish.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSelectDish.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSelectDish.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSelectDish.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSelectDish.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(51)))), ((int)(((byte)(255)))));
            this.btnSelectDish.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSelectDish.ForeColor = System.Drawing.Color.White;
            this.btnSelectDish.Image = ((System.Drawing.Image)(resources.GetObject("btnSelectDish.Image")));
            this.btnSelectDish.ImageSize = new System.Drawing.Size(30, 30);
            this.btnSelectDish.Location = new System.Drawing.Point(241, 391);
            this.btnSelectDish.Name = "btnSelectDish";
            this.btnSelectDish.Size = new System.Drawing.Size(180, 45);
            this.btnSelectDish.TabIndex = 9;
            this.btnSelectDish.Text = "Lên món";
            // 
            // pbPictureDish
            // 
            this.pbPictureDish.ImageRotate = 0F;
            this.pbPictureDish.Location = new System.Drawing.Point(88, 23);
            this.pbPictureDish.Name = "pbPictureDish";
            this.pbPictureDish.Size = new System.Drawing.Size(229, 152);
            this.pbPictureDish.TabIndex = 0;
            this.pbPictureDish.TabStop = false;
            // 
            // btnSearchDish
            // 
            this.btnSearchDish.BorderRadius = 10;
            this.btnSearchDish.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSearchDish.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSearchDish.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSearchDish.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSearchDish.FillColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSearchDish.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSearchDish.ForeColor = System.Drawing.Color.White;
            this.btnSearchDish.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchDish.Image")));
            this.btnSearchDish.Location = new System.Drawing.Point(454, 105);
            this.btnSearchDish.Name = "btnSearchDish";
            this.btnSearchDish.Size = new System.Drawing.Size(80, 36);
            this.btnSearchDish.TabIndex = 7;
            // 
            // btnExitFomSelectDish
            // 
            this.btnExitFomSelectDish.FlatAppearance.BorderSize = 0;
            this.btnExitFomSelectDish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExitFomSelectDish.Image = ((System.Drawing.Image)(resources.GetObject("btnExitFomSelectDish.Image")));
            this.btnExitFomSelectDish.Location = new System.Drawing.Point(922, 0);
            this.btnExitFomSelectDish.Name = "btnExitFomSelectDish";
            this.btnExitFomSelectDish.Size = new System.Drawing.Size(69, 45);
            this.btnExitFomSelectDish.TabIndex = 4;
            this.btnExitFomSelectDish.UseVisualStyleBackColor = true;
            this.btnExitFomSelectDish.Click += new System.EventHandler(this.btnExitFomSelectDish_Click);
            // 
            // frmSelectDish
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 559);
            this.Controls.Add(this.grpDishDetail);
            this.Controls.Add(this.btnSearchDish);
            this.Controls.Add(this.txtSearchDish);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbCategoryDish);
            this.Controls.Add(this.lstvListDish);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSelectDish";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSelectDish";
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
        private Guna.UI2.WinForms.Guna2Button btnSelectDish;
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
    }
}