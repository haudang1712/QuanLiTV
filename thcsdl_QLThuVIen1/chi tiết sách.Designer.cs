
namespace thcsdl_QLThuVIen1
{
    partial class chi_tiết_sách
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
            this.columnHeader1});
            this.lv_dsTrangChu.FullRowSelect = true;
            this.lv_dsTrangChu.HideSelection = false;
            this.lv_dsTrangChu.Location = new System.Drawing.Point(12, 95);
            this.lv_dsTrangChu.Name = "lv_dsTrangChu";
            this.lv_dsTrangChu.Size = new System.Drawing.Size(1478, 337);
            this.lv_dsTrangChu.TabIndex = 4;
            this.lv_dsTrangChu.UseCompatibleStateImageBehavior = false;
            this.lv_dsTrangChu.View = System.Windows.Forms.View.Details;
            this.lv_dsTrangChu.SelectedIndexChanged += new System.EventHandler(this.lv_dsTrangChu_SelectedIndexChanged);
            // 
            // Masach
            // 
            this.Masach.Text = "Mã sách";
            this.Masach.Width = 92;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên sách";
            this.columnHeader2.Width = 325;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Tên Tác Giả";
            this.columnHeader3.Width = 128;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "TÊn NXB";
            this.columnHeader4.Width = 109;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "TÊn thể loại";
            this.columnHeader5.Width = 133;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "TÊn ngôn ngữ";
            this.columnHeader6.Width = 156;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Số lượng";
            this.columnHeader7.Width = 115;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "GIá";
            this.columnHeader1.Width = 177;
            // 
            // btn_Thoát
            // 
            this.btn_Thoát.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.btn_Thoát.Location = new System.Drawing.Point(706, 578);
            this.btn_Thoát.Name = "btn_Thoát";
            this.btn_Thoát.Size = new System.Drawing.Size(95, 36);
            this.btn_Thoát.TabIndex = 20;
            this.btn_Thoát.Text = "Thoát";
            this.btn_Thoát.UseVisualStyleBackColor = true;
            this.btn_Thoát.Click += new System.EventHandler(this.btn_Thoát_Click);
            // 
            // chi_tiết_sách
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1526, 757);
            this.Controls.Add(this.btn_Thoát);
            this.Controls.Add(this.lv_dsTrangChu);
            this.Name = "chi_tiết_sách";
            this.Text = "chi_tiết_sách";
            this.Load += new System.EventHandler(this.chi_tiết_sách_Load);
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
        private System.Windows.Forms.Button btn_Thoát;
    }
}