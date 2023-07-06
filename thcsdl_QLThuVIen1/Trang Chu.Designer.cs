
namespace thcsdl_QLThuVIen1
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaSach = new System.Windows.Forms.TextBox();
            this.txtMaNXB = new System.Windows.Forms.TextBox();
            this.txtMaTheLoai = new System.Windows.Forms.TextBox();
            this.txtTenSach = new System.Windows.Forms.TextBox();
            this.txtMaNgonNgu = new System.Windows.Forms.TextBox();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_thêm = new System.Windows.Forms.Button();
            this.btn_Thoát = new System.Windows.Forms.Button();
            this.btn_Sửa = new System.Windows.Forms.Button();
            this.btn_Xóa = new System.Windows.Forms.Button();
            this.btn_themNXB = new System.Windows.Forms.Button();
            this.btn_themNN = new System.Windows.Forms.Button();
            this.btn_themTL = new System.Windows.Forms.Button();
            this.btn_themTG = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMTG = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
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
            this.lv_dsTrangChu.Location = new System.Drawing.Point(27, 83);
            this.lv_dsTrangChu.Name = "lv_dsTrangChu";
            this.lv_dsTrangChu.Size = new System.Drawing.Size(1478, 337);
            this.lv_dsTrangChu.TabIndex = 3;
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
            this.columnHeader3.Text = "Mã nhà xuất bản";
            this.columnHeader3.Width = 128;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Mã thể loại";
            this.columnHeader4.Width = 109;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Mã ngôn ngữ";
            this.columnHeader5.Width = 133;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Số lượng ";
            this.columnHeader6.Width = 156;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "GIá";
            this.columnHeader7.Width = 115;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Ma Tac Gia";
            this.columnHeader1.Width = 177;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(357, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "Danh Sach ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtMaSach
            // 
            this.txtMaSach.Location = new System.Drawing.Point(239, 484);
            this.txtMaSach.Name = "txtMaSach";
            this.txtMaSach.Size = new System.Drawing.Size(227, 22);
            this.txtMaSach.TabIndex = 4;
            // 
            // txtMaNXB
            // 
            this.txtMaNXB.Location = new System.Drawing.Point(239, 638);
            this.txtMaNXB.Name = "txtMaNXB";
            this.txtMaNXB.Size = new System.Drawing.Size(227, 22);
            this.txtMaNXB.TabIndex = 5;
            // 
            // txtMaTheLoai
            // 
            this.txtMaTheLoai.Location = new System.Drawing.Point(239, 708);
            this.txtMaTheLoai.Name = "txtMaTheLoai";
            this.txtMaTheLoai.Size = new System.Drawing.Size(227, 22);
            this.txtMaTheLoai.TabIndex = 6;
            // 
            // txtTenSach
            // 
            this.txtTenSach.Location = new System.Drawing.Point(239, 564);
            this.txtTenSach.Name = "txtTenSach";
            this.txtTenSach.Size = new System.Drawing.Size(227, 22);
            this.txtTenSach.TabIndex = 7;
            // 
            // txtMaNgonNgu
            // 
            this.txtMaNgonNgu.Location = new System.Drawing.Point(654, 481);
            this.txtMaNgonNgu.Name = "txtMaNgonNgu";
            this.txtMaNgonNgu.Size = new System.Drawing.Size(282, 22);
            this.txtMaNgonNgu.TabIndex = 8;
            this.txtMaNgonNgu.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(654, 620);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(282, 22);
            this.txtGia.TabIndex = 9;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(654, 548);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(282, 22);
            this.txtSoLuong.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 482);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "Mã Sách";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(38, 562);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 24);
            this.label3.TabIndex = 12;
            this.label3.Text = "Tên Sách";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(38, 636);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 24);
            this.label4.TabIndex = 13;
            this.label4.Text = "Mã Nhà Xuất Bản";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(38, 706);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 24);
            this.label5.TabIndex = 14;
            this.label5.Text = "Mã Thể Loại";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(511, 482);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 24);
            this.label6.TabIndex = 15;
            this.label6.Text = "Mã ngôn Ngữ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(511, 548);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 24);
            this.label7.TabIndex = 16;
            this.label7.Text = "Số lượng";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(511, 620);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 24);
            this.label8.TabIndex = 17;
            this.label8.Text = "Giá";
            // 
            // btn_thêm
            // 
            this.btn_thêm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.btn_thêm.Location = new System.Drawing.Point(1010, 473);
            this.btn_thêm.Name = "btn_thêm";
            this.btn_thêm.Size = new System.Drawing.Size(95, 40);
            this.btn_thêm.TabIndex = 18;
            this.btn_thêm.Text = "Thêm";
            this.btn_thêm.UseVisualStyleBackColor = true;
            this.btn_thêm.Click += new System.EventHandler(this.btn_thêm_Click);
            // 
            // btn_Thoát
            // 
            this.btn_Thoát.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.btn_Thoát.Location = new System.Drawing.Point(1010, 706);
            this.btn_Thoát.Name = "btn_Thoát";
            this.btn_Thoát.Size = new System.Drawing.Size(95, 36);
            this.btn_Thoát.TabIndex = 19;
            this.btn_Thoát.Text = "Thoát";
            this.btn_Thoát.UseVisualStyleBackColor = true;
            this.btn_Thoát.Click += new System.EventHandler(this.btn_Thoát_Click);
            // 
            // btn_Sửa
            // 
            this.btn_Sửa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.btn_Sửa.Location = new System.Drawing.Point(1010, 635);
            this.btn_Sửa.Name = "btn_Sửa";
            this.btn_Sửa.Size = new System.Drawing.Size(95, 37);
            this.btn_Sửa.TabIndex = 20;
            this.btn_Sửa.Text = "Sửa";
            this.btn_Sửa.UseVisualStyleBackColor = true;
            this.btn_Sửa.Click += new System.EventHandler(this.btn_Sửa_Click);
            // 
            // btn_Xóa
            // 
            this.btn_Xóa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.btn_Xóa.Location = new System.Drawing.Point(1010, 559);
            this.btn_Xóa.Name = "btn_Xóa";
            this.btn_Xóa.Size = new System.Drawing.Size(95, 38);
            this.btn_Xóa.TabIndex = 21;
            this.btn_Xóa.Text = "Xóa";
            this.btn_Xóa.UseVisualStyleBackColor = true;
            this.btn_Xóa.Click += new System.EventHandler(this.btn_Xóa_Click);
            // 
            // btn_themNXB
            // 
            this.btn_themNXB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_themNXB.Location = new System.Drawing.Point(1176, 559);
            this.btn_themNXB.Name = "btn_themNXB";
            this.btn_themNXB.Size = new System.Drawing.Size(185, 50);
            this.btn_themNXB.TabIndex = 25;
            this.btn_themNXB.Text = "Thêm nhà xuất bản";
            this.btn_themNXB.UseVisualStyleBackColor = true;
            this.btn_themNXB.Click += new System.EventHandler(this.btn_themNXB_Click);
            // 
            // btn_themNN
            // 
            this.btn_themNN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_themNN.Location = new System.Drawing.Point(1176, 635);
            this.btn_themNN.Name = "btn_themNN";
            this.btn_themNN.Size = new System.Drawing.Size(185, 49);
            this.btn_themNN.TabIndex = 24;
            this.btn_themNN.Text = "Thêm ngôn ngữ";
            this.btn_themNN.UseVisualStyleBackColor = true;
            this.btn_themNN.Click += new System.EventHandler(this.btn_themNN_Click);
            // 
            // btn_themTL
            // 
            this.btn_themTL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_themTL.Location = new System.Drawing.Point(1176, 706);
            this.btn_themTL.Name = "btn_themTL";
            this.btn_themTL.Size = new System.Drawing.Size(185, 51);
            this.btn_themTL.TabIndex = 23;
            this.btn_themTL.Text = "Thêm Thể loại";
            this.btn_themTL.UseVisualStyleBackColor = true;
            this.btn_themTL.Click += new System.EventHandler(this.btn_themTL_Click);
            // 
            // btn_themTG
            // 
            this.btn_themTG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_themTG.Location = new System.Drawing.Point(1176, 473);
            this.btn_themTG.Name = "btn_themTG";
            this.btn_themTG.Size = new System.Drawing.Size(185, 54);
            this.btn_themTG.TabIndex = 22;
            this.btn_themTG.Text = "Thêm Tác Giá";
            this.btn_themTG.UseVisualStyleBackColor = true;
            this.btn_themTG.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(645, 706);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(281, 73);
            this.button1.TabIndex = 26;
            this.button1.Text = "Mua Sách";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(511, 678);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 24);
            this.label9.TabIndex = 28;
            this.label9.Text = "Ma Tac Gia";
            // 
            // txtMTG
            // 
            this.txtMTG.Location = new System.Drawing.Point(654, 678);
            this.txtMTG.Name = "txtMTG";
            this.txtMTG.Size = new System.Drawing.Size(282, 22);
            this.txtMTG.TabIndex = 27;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(1176, 783);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(185, 54);
            this.button2.TabIndex = 29;
            this.button2.Text = "Chi tiết hóa đơn";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(964, 783);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(185, 54);
            this.button3.TabIndex = 30;
            this.button3.Text = "Chi tiết sách";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1566, 859);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtMTG);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_themNXB);
            this.Controls.Add(this.btn_themNN);
            this.Controls.Add(this.btn_themTL);
            this.Controls.Add(this.btn_themTG);
            this.Controls.Add(this.btn_Xóa);
            this.Controls.Add(this.btn_Sửa);
            this.Controls.Add(this.btn_Thoát);
            this.Controls.Add(this.btn_thêm);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.txtGia);
            this.Controls.Add(this.txtMaNgonNgu);
            this.Controls.Add(this.txtTenSach);
            this.Controls.Add(this.txtMaTheLoai);
            this.Controls.Add(this.txtMaNXB);
            this.Controls.Add(this.txtMaSach);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lv_dsTrangChu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lv_dsTrangChu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader Masach;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.TextBox txtMaSach;
        private System.Windows.Forms.TextBox txtMaNXB;
        private System.Windows.Forms.TextBox txtMaTheLoai;
        private System.Windows.Forms.TextBox txtTenSach;
        private System.Windows.Forms.TextBox txtMaNgonNgu;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_thêm;
        private System.Windows.Forms.Button btn_Thoát;
        private System.Windows.Forms.Button btn_Sửa;
        private System.Windows.Forms.Button btn_Xóa;
        private System.Windows.Forms.Button btn_themNXB;
        private System.Windows.Forms.Button btn_themNN;
        private System.Windows.Forms.Button btn_themTL;
        private System.Windows.Forms.Button btn_themTG;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMTG;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

