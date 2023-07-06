
namespace thcsdl_QLThuVIen1
{
    partial class Nhân_Viên
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
            this.txtSĐT = new System.Windows.Forms.TextBox();
            this.txtDIachi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lv_dsNV = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_tl = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoaTL = new System.Windows.Forms.Button();
            this.txtMNV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_themTL = new System.Windows.Forms.Button();
            this.txtTNV = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtSĐT
            // 
            this.txtSĐT.Location = new System.Drawing.Point(1063, 452);
            this.txtSĐT.Name = "txtSĐT";
            this.txtSĐT.Size = new System.Drawing.Size(100, 22);
            this.txtSĐT.TabIndex = 43;
            // 
            // txtDIachi
            // 
            this.txtDIachi.Location = new System.Drawing.Point(290, 438);
            this.txtDIachi.Name = "txtDIachi";
            this.txtDIachi.Size = new System.Drawing.Size(100, 22);
            this.txtDIachi.TabIndex = 42;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(835, 455);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 17);
            this.label3.TabIndex = 41;
            this.label3.Text = "SĐT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(125, 441);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 17);
            this.label4.TabIndex = 40;
            this.label4.Text = "Địa chỉ";
            // 
            // lv_dsNV
            // 
            this.lv_dsNV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lv_dsNV.HideSelection = false;
            this.lv_dsNV.Location = new System.Drawing.Point(50, 65);
            this.lv_dsNV.Name = "lv_dsNV";
            this.lv_dsNV.Size = new System.Drawing.Size(1291, 298);
            this.lv_dsNV.TabIndex = 31;
            this.lv_dsNV.UseCompatibleStateImageBehavior = false;
            this.lv_dsNV.View = System.Windows.Forms.View.Details;
            this.lv_dsNV.SelectedIndexChanged += new System.EventHandler(this.lv_dsNV_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã nhân viên";
            this.columnHeader1.Width = 294;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên nhân viên";
            this.columnHeader2.Width = 387;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "đía chỉ";
            this.columnHeader3.Width = 234;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "SĐT";
            // 
            // btn_tl
            // 
            this.btn_tl.Location = new System.Drawing.Point(1188, 524);
            this.btn_tl.Name = "btn_tl";
            this.btn_tl.Size = new System.Drawing.Size(75, 23);
            this.btn_tl.TabIndex = 38;
            this.btn_tl.Text = "trở lại";
            this.btn_tl.UseVisualStyleBackColor = true;
            this.btn_tl.Click += new System.EventHandler(this.btn_tl_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(497, 524);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(75, 23);
            this.btn_sua.TabIndex = 39;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_xoaTL
            // 
            this.btn_xoaTL.Location = new System.Drawing.Point(838, 524);
            this.btn_xoaTL.Name = "btn_xoaTL";
            this.btn_xoaTL.Size = new System.Drawing.Size(75, 23);
            this.btn_xoaTL.TabIndex = 37;
            this.btn_xoaTL.Text = "xóa";
            this.btn_xoaTL.UseVisualStyleBackColor = true;
            // 
            // txtMNV
            // 
            this.txtMNV.Location = new System.Drawing.Point(300, 389);
            this.txtMNV.Name = "txtMNV";
            this.txtMNV.Size = new System.Drawing.Size(100, 22);
            this.txtMNV.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(845, 406);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 17);
            this.label2.TabIndex = 34;
            this.label2.Text = "tên nhân viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 392);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 33;
            this.label1.Text = "Mã nhân viên";
            // 
            // btn_themTL
            // 
            this.btn_themTL.Location = new System.Drawing.Point(231, 524);
            this.btn_themTL.Name = "btn_themTL";
            this.btn_themTL.Size = new System.Drawing.Size(75, 23);
            this.btn_themTL.TabIndex = 32;
            this.btn_themTL.Text = "THêm";
            this.btn_themTL.UseVisualStyleBackColor = true;
            this.btn_themTL.Click += new System.EventHandler(this.btn_themTL_Click);
            // 
            // txtTNV
            // 
            this.txtTNV.Location = new System.Drawing.Point(1073, 403);
            this.txtTNV.Name = "txtTNV";
            this.txtTNV.Size = new System.Drawing.Size(100, 22);
            this.txtTNV.TabIndex = 36;
            // 
            // Nhân_Viên
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1391, 613);
            this.Controls.Add(this.txtSĐT);
            this.Controls.Add(this.txtDIachi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lv_dsNV);
            this.Controls.Add(this.btn_tl);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_xoaTL);
            this.Controls.Add(this.txtMNV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_themTL);
            this.Controls.Add(this.txtTNV);
            this.Name = "Nhân_Viên";
            this.Text = "Nhân_Viên";
            this.Load += new System.EventHandler(this.Nhân_Viên_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSĐT;
        private System.Windows.Forms.TextBox txtDIachi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView lv_dsNV;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btn_tl;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_xoaTL;
        private System.Windows.Forms.TextBox txtMNV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_themTL;
        private System.Windows.Forms.TextBox txtTNV;
    }
}