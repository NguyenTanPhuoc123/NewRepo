
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
            this.grpDishDetail = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lstDishSelect = new System.Windows.Forms.ListView();
            this.label3 = new System.Windows.Forms.Label();
            this.cbCategoryDish = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbStyleView = new System.Windows.Forms.ComboBox();
            this.pbDish = new System.Windows.Forms.PictureBox();
            this.txtDishName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCategoryDish = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.btnAddDish = new System.Windows.Forms.Button();
            this.grpDishDetail.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDish)).BeginInit();
            this.SuspendLayout();
            // 
            // grpDishDetail
            // 
            this.grpDishDetail.Controls.Add(this.btnAddDish);
            this.grpDishDetail.Controls.Add(this.txtPrice);
            this.grpDishDetail.Controls.Add(this.label7);
            this.grpDishDetail.Controls.Add(this.txtCategoryDish);
            this.grpDishDetail.Controls.Add(this.label6);
            this.grpDishDetail.Controls.Add(this.label5);
            this.grpDishDetail.Controls.Add(this.txtDishName);
            this.grpDishDetail.Controls.Add(this.pbDish);
            this.grpDishDetail.Location = new System.Drawing.Point(608, 78);
            this.grpDishDetail.Name = "grpDishDetail";
            this.grpDishDetail.Size = new System.Drawing.Size(429, 416);
            this.grpDishDetail.TabIndex = 0;
            this.grpDishDetail.TabStop = false;
            this.grpDishDetail.Text = "Thông tin món";
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
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1049, 72);
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
            // lstDishSelect
            // 
            this.lstDishSelect.HideSelection = false;
            this.lstDishSelect.Location = new System.Drawing.Point(12, 144);
            this.lstDishSelect.Name = "lstDishSelect";
            this.lstDishSelect.Size = new System.Drawing.Size(590, 350);
            this.lstDishSelect.TabIndex = 3;
            this.lstDishSelect.UseCompatibleStateImageBehavior = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Danh mục:";
            // 
            // cbCategoryDish
            // 
            this.cbCategoryDish.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategoryDish.FormattingEnabled = true;
            this.cbCategoryDish.Location = new System.Drawing.Point(98, 104);
            this.cbCategoryDish.Name = "cbCategoryDish";
            this.cbCategoryDish.Size = new System.Drawing.Size(180, 26);
            this.cbCategoryDish.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(368, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Style view:";
            // 
            // cbStyleView
            // 
            this.cbStyleView.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStyleView.FormattingEnabled = true;
            this.cbStyleView.Items.AddRange(new object[] {
            "LargeIcon",
            "Detail",
            "SmallIcon",
            "List",
            "Title"});
            this.cbStyleView.Location = new System.Drawing.Point(451, 107);
            this.cbStyleView.Name = "cbStyleView";
            this.cbStyleView.Size = new System.Drawing.Size(146, 26);
            this.cbStyleView.TabIndex = 7;
            // 
            // pbDish
            // 
            this.pbDish.Location = new System.Drawing.Point(83, 23);
            this.pbDish.Name = "pbDish";
            this.pbDish.Size = new System.Drawing.Size(270, 198);
            this.pbDish.TabIndex = 0;
            this.pbDish.TabStop = false;
            // 
            // txtDishName
            // 
            this.txtDishName.Location = new System.Drawing.Point(83, 242);
            this.txtDishName.Name = "txtDishName";
            this.txtDishName.Size = new System.Drawing.Size(270, 24);
            this.txtDishName.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 18);
            this.label5.TabIndex = 5;
            this.label5.Text = "Tên món:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 291);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 18);
            this.label6.TabIndex = 6;
            this.label6.Text = "Danh mục:";
            // 
            // txtCategoryDish
            // 
            this.txtCategoryDish.Location = new System.Drawing.Point(83, 288);
            this.txtCategoryDish.Name = "txtCategoryDish";
            this.txtCategoryDish.Size = new System.Drawing.Size(270, 24);
            this.txtCategoryDish.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 330);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 18);
            this.label7.TabIndex = 8;
            this.label7.Text = "Đơn giá:";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(83, 327);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(270, 24);
            this.txtPrice.TabIndex = 9;
            // 
            // btnAddDish
            // 
            this.btnAddDish.Location = new System.Drawing.Point(325, 373);
            this.btnAddDish.Name = "btnAddDish";
            this.btnAddDish.Size = new System.Drawing.Size(98, 37);
            this.btnAddDish.TabIndex = 10;
            this.btnAddDish.Text = "Thêm món";
            this.btnAddDish.UseVisualStyleBackColor = true;
            // 
            // frmSelectDish
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 506);
            this.Controls.Add(this.cbStyleView);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbCategoryDish);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstDishSelect);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grpDishDetail);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmSelectDish";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmSelectDish";
            this.grpDishDetail.ResumeLayout(false);
            this.grpDishDetail.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDish)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDishDetail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddDish;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCategoryDish;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDishName;
        private System.Windows.Forms.PictureBox pbDish;
        private System.Windows.Forms.ListView lstDishSelect;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbCategoryDish;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbStyleView;
    }
}