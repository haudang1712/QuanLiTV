using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace thcsdl_QLThuVIen1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            _kn = new KetNoi();
        }

        KetNoi _kn;


        private void LoadDSSach()
        {
            string sql = "select s.MaSach, s.TenSach, s.MaNhaXuatBan, s.MaTheLoai, s.MaNgonNgu, s.SoLuong, s.Gia, stg.MaTacGia from Sach s, Sach_TacGia stg, TacGia tg where s.MaSach = stg.MaSach and stg.MaTacGia = tg.MaTacGia";
            DataTable dsSach = _kn.DocDuLieu(sql);
            lv_dsTrangChu.Items.Clear();
            foreach (DataRow row in dsSach.Rows)
            {
                ListViewItem item = new ListViewItem(row["Masach"].ToString());
                item.SubItems.Add(row["TenSach"].ToString());
                item.SubItems.Add(row["MaNhaXuatBan"].ToString());
                item.SubItems.Add(row["MaTheLoai"].ToString());
                item.SubItems.Add(row["MaNgonNgu"].ToString());
                item.SubItems.Add(row["SoLuong"].ToString());
                item.SubItems.Add(row["Gia"].ToString());
                item.SubItems.Add(row["MaTacGia"].ToString());
                lv_dsTrangChu.Items.Add(item);
            }
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lv_dsTrangChu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv_dsTrangChu.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lv_dsTrangChu.SelectedItems[0];
                string maSach = selectedItem.SubItems[0].Text;
                string tenSach = selectedItem.SubItems[1].Text;
                string maNXB = selectedItem.SubItems[2].Text;
                string maTheLoai = selectedItem.SubItems[3].Text;
                string maNgonNgu = selectedItem.SubItems[4].Text;
                string soLuong = selectedItem.SubItems[5].Text;
                string gia = selectedItem.SubItems[6].Text;

                string maTG = selectedItem.SubItems[7].Text;

                txtMaSach.Text = maSach;
                txtTenSach.Text = tenSach;
                txtMaNXB.Text = maNXB;
                txtMaTheLoai.Text = maTheLoai;
                txtMaNgonNgu.Text = maNgonNgu;
                txtSoLuong.Text = soLuong;
                txtGia.Text = gia;
                txtMTG.Text = maTG;
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_thêm_Click(object sender, EventArgs e)
        {
            txtMTG.Clear();

            string maSach = txtMaSach.Text;
            string tenSach = txtTenSach.Text;
            string maNXB = txtMaNXB.Text;
            string maTheLoai = txtMaTheLoai.Text;
            string maNgonNgu = txtMaNgonNgu.Text;
            string soLuong = txtSoLuong.Text;
            string gia = txtGia.Text;


            if (string.IsNullOrWhiteSpace(maSach))
            {
                MessageBox.Show("Vui lòng nhập mã sách");
                return;
            }

            string sql = "INSERT INTO Sach (MaSach, TenSach, MaNhaXuatBan, MaTheLoai, MaNgonNgu, SoLuong, Gia) VALUES (@MaSach, @TenSach, @MaNXB, @MaTheLoai, @MaNgonNgu, @SoLuong, @Gia)";



            SqlParameter[] thucthi_them = new SqlParameter[]
            {
                new SqlParameter("@MaSach", maSach),
                new SqlParameter("@TenSach", tenSach),
                new SqlParameter("@MaNXB", maNXB),
                new SqlParameter("@MaTheLoai", maTheLoai),
                new SqlParameter("@MaNgonNgu", maNgonNgu),
                new SqlParameter("@SoLuong", soLuong),
                new SqlParameter("@Gia", gia)
            };

            bool ketQua = _kn.ThucThiLenh(sql, thucthi_them);
            if (ketQua == true)
            {
                MessageBox.Show("Thêm sách thành công");
                LoadDSSach();
            }
            else
            {
                MessageBox.Show("Thêm sách thất bại");
            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

            LoadDSSach();
        }

        private void btn_Sửa_Click(object sender, EventArgs e)
        {
            string maSach = txtMaSach.Text;
            string tenSach = txtTenSach.Text;
            string maNXB = txtMaNXB.Text;
            string maTheLoai = txtMaTheLoai.Text;
            string maNgonNgu = txtMaNgonNgu.Text;
            string soLuong = txtSoLuong.Text;
            string gia = txtGia.Text;


            if (string.IsNullOrWhiteSpace(maSach))
            {
                MessageBox.Show("Vui lòng chọn sách để sửa");
                return;
            }

            string sql = "UPDATE Sach SET TenSach = @TenSach, MaNhaXuatBan = @MaNXB, MaTheLoai = @MaTheLoai, MaNgonNgu = @MaNgonNgu, SoLuong = @SoLuong, Gia = @Gia WHERE MaSach = @MaSach";

            SqlParameter[] thucthi_sua = new SqlParameter[]
            {
                new SqlParameter("@TenSach", tenSach),
                new SqlParameter("@MaNXB", maNXB),
                new SqlParameter("@MaTheLoai", maTheLoai),
                new SqlParameter("@MaNgonNgu", maNgonNgu),
                new SqlParameter("@SoLuong", soLuong),
                new SqlParameter("@Gia", gia),
                new SqlParameter("@MaSach", maSach)
            };

            bool ketQua = _kn.ThucThiLenh(sql, thucthi_sua);
            if (ketQua)
            {
                MessageBox.Show("Sửa sách thành công");
                LoadDSSach(); 
            }
            else
            {
                MessageBox.Show("Sửa sách thất bại");
            }
        }

        private void btn_Thoát_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Xóa_Click(object sender, EventArgs e)
        {
            if (lv_dsTrangChu.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lv_dsTrangChu.SelectedItems[0];
                string maSach = selectedItem.SubItems[0].Text;

                string sql = "DELETE * FROM Sach WHERE MaSach = @MaSach";
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@MaSach", maSach)
                };

                bool ketQua = _kn.ThucThiLenh(sql, parameters);
                if (ketQua)
                {
                    MessageBox.Show("Xóa sách thành công");
                    LoadDSSach();
                }
                else
                {
                    MessageBox.Show("Xóa sách thất bại");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sách để xóa");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Thêm_tác_giả theLoai = new Thêm_tác_giả();

            theLoai.ShowDialog();

            this.Close();
        }

        private void btn_themTL_Click(object sender, EventArgs e)
        {
            this.Hide();
            Thêm_Thể_loại theLoai = new Thêm_Thể_loại();

            theLoai.ShowDialog();

            this.Close();
        }

        private void btn_themNXB_Click(object sender, EventArgs e)
        {
            this.Hide();
            thêm_nhà_xuất_bản theLoai = new thêm_nhà_xuất_bản();

            theLoai.ShowDialog();

            this.Close();
        }

        private void btn_themNN_Click(object sender, EventArgs e)
        {
            this.Hide();
            thêm_ngôn_ngữ theLoai = new thêm_ngôn_ngữ();

            theLoai.ShowDialog();

            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Đơn_hàng theLoai = new Đơn_hàng();

            theLoai.ShowDialog();

            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            chi_tiết_sách theLoai = new chi_tiết_sách();

            theLoai.ShowDialog();

            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            chi_tiết_hóa_đơn theLoai = new chi_tiết_hóa_đơn();

            theLoai.ShowDialog();

            this.Close();
        }
    }
}
