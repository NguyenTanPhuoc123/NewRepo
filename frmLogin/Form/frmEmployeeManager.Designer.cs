
namespace frmLogin
{
    partial class frmEmployeeManager
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
            this.dtgvListEmployee = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cbArrageEmployee = new System.Windows.Forms.ComboBox();
            this.btnSearchEmployee = new System.Windows.Forms.Button();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.btnEditEmployee = new System.Windows.Forms.Button();
            this.btnDeleteEmployee = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbSortEmployee = new System.Windows.Forms.ComboBox();
            this.txtSearchEmployee = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvListEmployee
            // 
            this.dtgvListEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvListEmployee.Location = new System.Drawing.Point(12, 74);
            this.dtgvListEmployee.Name = "dtgvListEmployee";
            this.dtgvListEmployee.RowHeadersWidth = 51;
            this.dtgvListEmployee.RowTemplate.Height = 24;
            this.dtgvListEmployee.Size = new System.Drawing.Size(1040, 415);
            this.dtgvListEmployee.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sắp xếp";
            // 
            // cbArrageEmployee
            // 
            this.cbArrageEmployee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbArrageEmployee.FormattingEnabled = true;
            this.cbArrageEmployee.Items.AddRange(new object[] {
            "Theo mã ",
            "Theo tên ",
            "Theo ngày vào làm"});
            this.cbArrageEmployee.Location = new System.Drawing.Point(12, 39);
            this.cbArrageEmployee.Name = "cbArrageEmployee";
            this.cbArrageEmployee.Size = new System.Drawing.Size(220, 26);
            this.cbArrageEmployee.TabIndex = 2;
            // 
            // btnSearchEmployee
            // 
            this.btnSearchEmployee.Location = new System.Drawing.Point(640, 34);
            this.btnSearchEmployee.Name = "btnSearchEmployee";
            this.btnSearchEmployee.Size = new System.Drawing.Size(84, 34);
            this.btnSearchEmployee.TabIndex = 3;
            this.btnSearchEmployee.Text = "Tìm kiếm";
            this.btnSearchEmployee.UseVisualStyleBackColor = true;
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.Location = new System.Drawing.Point(1058, 184);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(91, 39);
            this.btnAddEmployee.TabIndex = 4;
            this.btnAddEmployee.Text = "Thêm";
            this.btnAddEmployee.UseVisualStyleBackColor = true;
            // 
            // btnEditEmployee
            // 
            this.btnEditEmployee.Location = new System.Drawing.Point(1058, 254);
            this.btnEditEmployee.Name = "btnEditEmployee";
            this.btnEditEmployee.Size = new System.Drawing.Size(91, 39);
            this.btnEditEmployee.TabIndex = 5;
            this.btnEditEmployee.Text = "Sửa";
            this.btnEditEmployee.UseVisualStyleBackColor = true;
            // 
            // btnDeleteEmployee
            // 
            this.btnDeleteEmployee.Location = new System.Drawing.Point(1058, 327);
            this.btnDeleteEmployee.Name = "btnDeleteEmployee";
            this.btnDeleteEmployee.Size = new System.Drawing.Size(91, 39);
            this.btnDeleteEmployee.TabIndex = 6;
            this.btnDeleteEmployee.Text = "Xóa";
            this.btnDeleteEmployee.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(810, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Lọc:";
            // 
            // cbSortEmployee
            // 
            this.cbSortEmployee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSortEmployee.FormattingEnabled = true;
            this.cbSortEmployee.Items.AddRange(new object[] {
            "Tất cả",
            "Nhân viên bán hàng",
            "Nhân viên quản lý",
            "Nhân viên bảo vệ"});
            this.cbSortEmployee.Location = new System.Drawing.Point(862, 39);
            this.cbSortEmployee.Name = "cbSortEmployee";
            this.cbSortEmployee.Size = new System.Drawing.Size(190, 26);
            this.cbSortEmployee.TabIndex = 8;
            // 
            // txtSearchEmployee
            // 
            this.txtSearchEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchEmployee.Location = new System.Drawing.Point(319, 38);
            this.txtSearchEmployee.Name = "txtSearchEmployee";
            this.txtSearchEmployee.Size = new System.Drawing.Size(295, 27);
            this.txtSearchEmployee.TabIndex = 9;
            // 
            // frmEmployeeManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 501);
            this.Controls.Add(this.txtSearchEmployee);
            this.Controls.Add(this.cbSortEmployee);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDeleteEmployee);
            this.Controls.Add(this.btnEditEmployee);
            this.Controls.Add(this.btnAddEmployee);
            this.Controls.Add(this.btnSearchEmployee);
            this.Controls.Add(this.cbArrageEmployee);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgvListEmployee);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmEmployeeManager";
            this.Text = "frmEmployeeManager";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvListEmployee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbArrageEmployee;
        private System.Windows.Forms.Button btnSearchEmployee;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.Button btnEditEmployee;
        private System.Windows.Forms.Button btnDeleteEmployee;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbSortEmployee;
        private System.Windows.Forms.TextBox txtSearchEmployee;
    }
}