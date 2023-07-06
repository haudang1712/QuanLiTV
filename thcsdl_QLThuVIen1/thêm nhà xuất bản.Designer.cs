
namespace thcsdl_QLThuVIen1
{
    partial class thêm_nhà_xuất_bản
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
            this.lv_dsNXB = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_tl = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoaTL = new System.Windows.Forms.Button();
            this.txtTNXB = new System.Windows.Forms.TextBox();
            this.txtMNXB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_themTL = new System.Windows.Forms.Button();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtSĐT = new System.Windows.Forms.TextBox();
            this.txtDIachi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lv_dsNXB
            // 
            this.lv_dsNXB.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lv_dsNXB.HideSelection = false;
            this.lv_dsNXB.Location = new System.Drawing.Point(0, 93);
            this.lv_dsNXB.Name = "lv_dsNXB";
            this.lv_dsNXB.Size = new System.Drawing.Size(1291, 298);
            this.lv_dsNXB.TabIndex = 18;
            this.lv_dsNXB.UseCompatibleStateImageBehavior = false;
            this.lv_dsNXB.View = System.Windows.Forms.View.Details;
            this.lv_dsNXB.SelectedIndexChanged += new System.EventHandler(this.lv_dsNXB_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã nhà xuất bản";
            this.columnHeader1.Width = 294;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên nhã xuất bản";
            this.columnHeader2.Width = 387;
            // 
            // btn_tl
            // 
            this.btn_tl.Location = new System.Drawing.Point(1138, 552);
            this.btn_tl.Name = "btn_tl";
            this.btn_tl.Size = new System.Drawing.Size(75, 23);
            this.btn_tl.TabIndex = 25;
            this.btn_tl.Text = "trở lại";
            this.btn_tl.UseVisualStyleBackColor = true;
            this.btn_tl.Click += new System.EventHandler(this.btn_tl_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(447, 552);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(75, 23);
            this.btn_sua.TabIndex = 26;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_xoaTL
            // 
            this.btn_xoaTL.Location = new System.Drawing.Point(788, 552);
            this.btn_xoaTL.Name = "btn_xoaTL";
            this.btn_xoaTL.Size = new System.Drawing.Size(75, 23);
            this.btn_xoaTL.TabIndex = 24;
            this.btn_xoaTL.Text = "xóa";
            this.btn_xoaTL.UseVisualStyleBackColor = true;
            this.btn_xoaTL.Click += new System.EventHandler(this.btn_xoaTL_Click);
            // 
            // txtTNXB
            // 
            this.txtTNXB.Location = new System.Drawing.Point(1023, 431);
            this.txtTNXB.Name = "txtTNXB";
            this.txtTNXB.Size = new System.Drawing.Size(100, 22);
            this.txtTNXB.TabIndex = 23;
            // 
            // txtMNXB
            // 
            this.txtMNXB.Location = new System.Drawing.Point(250, 417);
            this.txtMNXB.Name = "txtMNXB";
            this.txtMNXB.Size = new System.Drawing.Size(100, 22);
            this.txtMNXB.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(795, 434);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "Tên nhà xuát bản";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 420);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "Mã nhà xuất bản";
            // 
            // btn_themTL
            // 
            this.btn_themTL.Location = new System.Drawing.Point(181, 552);
            this.btn_themTL.Name = "btn_themTL";
            this.btn_themTL.Size = new System.Drawing.Size(75, 23);
            this.btn_themTL.TabIndex = 19;
            this.btn_themTL.Text = "THêm";
            this.btn_themTL.UseVisualStyleBackColor = true;
            this.btn_themTL.Click += new System.EventHandler(this.btn_themTL_Click);
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
            // txtSĐT
            // 
            this.txtSĐT.Location = new System.Drawing.Point(1013, 480);
            this.txtSĐT.Name = "txtSĐT";
            this.txtSĐT.Size = new System.Drawing.Size(100, 22);
            this.txtSĐT.TabIndex = 30;
            // 
            // txtDIachi
            // 
            this.txtDIachi.Location = new System.Drawing.Point(240, 466);
            this.txtDIachi.Name = "txtDIachi";
            this.txtDIachi.Size = new System.Drawing.Size(100, 22);
            this.txtDIachi.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(785, 483);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 17);
            this.label3.TabIndex = 28;
            this.label3.Text = "SĐT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 469);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 17);
            this.label4.TabIndex = 27;
            this.label4.Text = "Địa chỉ";
            // 
            // thêm_nhà_xuất_bản
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1291, 619);
            this.Controls.Add(this.txtSĐT);
            this.Controls.Add(this.txtDIachi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lv_dsNXB);
            this.Controls.Add(this.btn_tl);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_xoaTL);
            this.Controls.Add(this.txtTNXB);
            this.Controls.Add(this.txtMNXB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_themTL);
            this.Name = "thêm_nhà_xuất_bản";
            this.Text = "thêm_nhà_xuất_bản";
            this.Load += new System.EventHandler(this.thêm_nhà_xuất_bản_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lv_dsNXB;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btn_tl;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_xoaTL;
        private System.Windows.Forms.TextBox txtTNXB;
        private System.Windows.Forms.TextBox txtMNXB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_themTL;
        private System.Windows.Forms.TextBox txtSĐT;
        private System.Windows.Forms.TextBox txtDIachi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}