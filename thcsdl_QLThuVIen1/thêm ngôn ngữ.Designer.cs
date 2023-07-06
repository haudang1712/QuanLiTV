
namespace thcsdl_QLThuVIen1
{
    partial class thêm_ngôn_ngữ
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
            this.lv_dsNN = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_tl = new System.Windows.Forms.Button();
            this.btn_xoaTL = new System.Windows.Forms.Button();
            this.txtTTL = new System.Windows.Forms.TextBox();
            this.txtMTL = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_themTL = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lv_dsNN
            // 
            this.lv_dsNN.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lv_dsNN.HideSelection = false;
            this.lv_dsNN.Location = new System.Drawing.Point(73, 77);
            this.lv_dsNN.Name = "lv_dsNN";
            this.lv_dsNN.Size = new System.Drawing.Size(1291, 298);
            this.lv_dsNN.TabIndex = 9;
            this.lv_dsNN.UseCompatibleStateImageBehavior = false;
            this.lv_dsNN.View = System.Windows.Forms.View.Details;
            this.lv_dsNN.SelectedIndexChanged += new System.EventHandler(this.lv_dsNN_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã ngôn ngữ";
            this.columnHeader1.Width = 646;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên ngôn ngữ";
            this.columnHeader2.Width = 515;
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(528, 487);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(75, 23);
            this.btn_sua.TabIndex = 17;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_tl
            // 
            this.btn_tl.Location = new System.Drawing.Point(1213, 487);
            this.btn_tl.Name = "btn_tl";
            this.btn_tl.Size = new System.Drawing.Size(75, 23);
            this.btn_tl.TabIndex = 16;
            this.btn_tl.Text = "trở lại";
            this.btn_tl.UseVisualStyleBackColor = true;
            this.btn_tl.Click += new System.EventHandler(this.btn_tl_Click);
            // 
            // btn_xoaTL
            // 
            this.btn_xoaTL.Location = new System.Drawing.Point(861, 487);
            this.btn_xoaTL.Name = "btn_xoaTL";
            this.btn_xoaTL.Size = new System.Drawing.Size(75, 23);
            this.btn_xoaTL.TabIndex = 15;
            this.btn_xoaTL.Text = "xóa";
            this.btn_xoaTL.UseVisualStyleBackColor = true;
            this.btn_xoaTL.Click += new System.EventHandler(this.btn_xoaTL_Click);
            // 
            // txtTTL
            // 
            this.txtTTL.Location = new System.Drawing.Point(1096, 415);
            this.txtTTL.Name = "txtTTL";
            this.txtTTL.Size = new System.Drawing.Size(100, 22);
            this.txtTTL.TabIndex = 14;
            // 
            // txtMTL
            // 
            this.txtMTL.Location = new System.Drawing.Point(323, 401);
            this.txtMTL.Name = "txtMTL";
            this.txtMTL.Size = new System.Drawing.Size(100, 22);
            this.txtMTL.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(868, 418);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Tên ngôn ngữ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(158, 404);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Mã ngôn ngữ";
            // 
            // btn_themTL
            // 
            this.btn_themTL.Location = new System.Drawing.Point(242, 487);
            this.btn_themTL.Name = "btn_themTL";
            this.btn_themTL.Size = new System.Drawing.Size(75, 23);
            this.btn_themTL.TabIndex = 10;
            this.btn_themTL.Text = "THêm";
            this.btn_themTL.UseVisualStyleBackColor = true;
            this.btn_themTL.Click += new System.EventHandler(this.btn_themTL_Click);
            // 
            // thêm_ngôn_ngữ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1436, 587);
            this.Controls.Add(this.lv_dsNN);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_tl);
            this.Controls.Add(this.btn_xoaTL);
            this.Controls.Add(this.txtTTL);
            this.Controls.Add(this.txtMTL);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_themTL);
            this.Name = "thêm_ngôn_ngữ";
            this.Text = "thêm_ngôn_ngữ";
            this.Load += new System.EventHandler(this.thêm_ngôn_ngữ_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lv_dsNN;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_tl;
        private System.Windows.Forms.Button btn_xoaTL;
        private System.Windows.Forms.TextBox txtTTL;
        private System.Windows.Forms.TextBox txtMTL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_themTL;
    }
}