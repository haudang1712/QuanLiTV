
namespace thcsdl_QLThuVIen1
{
    partial class chi_tiết_hóa_đơn
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
            this.lv_dsTrangChu = new System.Windows.Forms.ListView();
            this.Masach = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_Thoát = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lv_dsTrangChu
            // 
            this.lv_dsTrangChu.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Masach,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader1,
            this.columnHeader8,
            this.columnHeader9});
            this.lv_dsTrangChu.FullRowSelect = true;
            this.lv_dsTrangChu.HideSelection = false;
            this.lv_dsTrangChu.Location = new System.Drawing.Point(12, 123);
            this.lv_dsTrangChu.Name = "lv_dsTrangChu";
            this.lv_dsTrangChu.Size = new System.Drawing.Size(1478, 337);
            this.lv_dsTrangChu.TabIndex = 5;
            this.lv_dsTrangChu.UseCompatibleStateImageBehavior = false;
            this.lv_dsTrangChu.View = System.Windows.Forms.View.Details;
            // 
            // Masach
            // 
            this.Masach.Text = "Mã đơn hàng";
            this.Masach.Width = 92;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên khách hàng";
            this.columnHeader2.Width = 265;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Địa chỉ";
            this.columnHeader3.Width = 110;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Số điện thoai";
            this.columnHeader4.Width = 109;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Tên nhân viên";
            this.columnHeader5.Width = 133;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Tên sách";
            this.columnHeader6.Width = 156;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Giá ";
            this.columnHeader7.Width = 115;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Số lượng";
            this.columnHeader1.Width = 177;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Giá sách";
            this.columnHeader8.Width = 99;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Tên Trạng thái";
            this.columnHeader9.Width = 141;
            // 
            // btn_Thoát
            // 
            this.btn_Thoát.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.btn_Thoát.Location = new System.Drawing.Point(705, 542);
            this.btn_Thoát.Name = "btn_Thoát";
            this.btn_Thoát.Size = new System.Drawing.Size(95, 36);
            this.btn_Thoát.TabIndex = 21;
            this.btn_Thoát.Text = "Thoát";
            this.btn_Thoát.UseVisualStyleBackColor = true;
            this.btn_Thoát.Click += new System.EventHandler(this.btn_Thoát_Click);
            // 
            // chi_tiết_hóa_đơn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1506, 680);
            this.Controls.Add(this.btn_Thoát);
            this.Controls.Add(this.lv_dsTrangChu);
            this.Name = "chi_tiết_hóa_đơn";
            this.Text = "chi_tiết_hóa_đơn";
            this.Load += new System.EventHandler(this.chi_tiết_hóa_đơn_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lv_dsTrangChu;
        private System.Windows.Forms.ColumnHeader Masach;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.Button btn_Thoát;
    }
}