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
    public partial class Khách_Hàng : Form
    {
        public Khách_Hàng()
        {
            InitializeComponent();
            _kn = new KetNoi();
        }

        KetNoi _kn;

            private void LoadDSKH()
            {
                string sql = "SELECT * FROM KhachHang";
                DataTable dsNXB = _kn.DocDuLieu(sql);
                lv_dsKH.Items.Clear();
                foreach (DataRow row in dsNXB.Rows)
                {
                    ListViewItem item = new ListViewItem(row["MaKhachHang"].ToString());
                    item.SubItems.Add(row["TenKhachHang"].ToString());
                    item.SubItems.Add(row["DiaChi"].ToString());
                    item.SubItems.Add(row["SoDienThoai"].ToString());

                    lv_dsKH.Items.Add(item);
                }
            }

            private void Khách_Hàng_Load(object sender, EventArgs e)
        {
            LoadDSKH();
        }

        private void lv_dsKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv_dsKH.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lv_dsKH.SelectedItems[0];
                string maKH = selectedItem.SubItems[0].Text;
                string tenKH = selectedItem.SubItems[1].Text;
                string diaChi = selectedItem.SubItems[2].Text;
                string SDT = selectedItem.SubItems[3].Text;


                txtMKH.Text = maKH;
                txtTKH.Text = tenKH;
                txtDIachi.Text = diaChi;
                txtSĐT.Text = SDT;


            }
        }

        private void btn_themTL_Click(object sender, EventArgs e)
        {
            string maKH = txtMKH.Text;
            string tenKH = txtTKH.Text;
            string diaChi = txtDIachi.Text;
            string SDT = txtSĐT.Text;


            if (string.IsNullOrWhiteSpace(maKH))
            {
                MessageBox.Show("Vui lòng nhập mã nhan viên");
                return;
            }

            string sql = "INSERT INTO KhachHang (MaKhachHang, TenKhachHang, DiaChi, SoDienThoai) VALUES (@MaKhachHang, @TenKhachHang, @DiaChi, @SoDienThoai)";

            SqlParameter[] thucthi_them = new SqlParameter[]
            {
                new SqlParameter("@MaKhachHang", maKH),
                new SqlParameter("@TenKhachHang", tenKH),
                new SqlParameter("@DiaChi", diaChi),
                new SqlParameter("@SoDienThoai", SDT)
            };

            bool ketQua = _kn.ThucThiLenh(sql, thucthi_them);
            if (ketQua == true)
            {
                MessageBox.Show("Thêm sách thành công");
                LoadDSKH();
            }
            else
            {
                MessageBox.Show("Thêm sách thất bại");
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            string maKH = txtMKH.Text;
            string tenKH = txtTKH.Text;
            string diaChi = txtDIachi.Text;
            string SDT = txtSĐT.Text;


            if (string.IsNullOrWhiteSpace(maKH))
            {
                MessageBox.Show("Vui lòng chọn nhan vien để sửa");
                return;
            }

            string sql = "UPDATE KhachHang SET TenKhachHang = @TenKhachHang, DiaChi = @DiaChi, SoDienThoai = @SoDienThoai WHERE MaKhachHang = @MaKhachHang";

            SqlParameter[] thucthi_sua = new SqlParameter[]
            {
                new SqlParameter("@TenKhachHang", tenKH),
                new SqlParameter("@DiaChi", diaChi),
                new SqlParameter("@SoDienThoai", SDT),
                new SqlParameter("@MaKhachHang", maKH)
            };

            bool ketQua = _kn.ThucThiLenh(sql, thucthi_sua);
            if (ketQua)
            {
                MessageBox.Show("Sửa sách thành công");
                LoadDSKH();
            }
            else
            {
                MessageBox.Show("Sửa sách thất bại");
            }
        }

        private void btn_tl_Click(object sender, EventArgs e)
        {
            this.Hide();
            Đơn_hàng theLoai = new Đơn_hàng();

            theLoai.ShowDialog();

            this.Close();
        }
    }
}
