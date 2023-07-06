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
    public partial class Đơn_hàng : Form
    {
        public Đơn_hàng()
        {
            InitializeComponent();
            _kn = new KetNoi();
        }

        KetNoi _kn;

        private void LoadDSDH()
        {
            string sql = "SELECT * FROM DonHang";
            DataTable dsNXB = _kn.DocDuLieu(sql);
            lv_dsDH.Items.Clear();
            foreach (DataRow row in dsNXB.Rows)
            {
                ListViewItem item = new ListViewItem(row["MaDonHang"].ToString());
                item.SubItems.Add(row["MaKhachHang"].ToString());
                item.SubItems.Add(row["MaNhanVien"].ToString());
                item.SubItems.Add(row["ThanhTien"].ToString());
                item.SubItems.Add(row["MaTrangThai"].ToString());
                lv_dsDH.Items.Add(item);
            }
        }

        private void Đơn_hàng_Load(object sender, EventArgs e)
        {
            LoadDSDH();
        }

        private void btn_TNV_Click(object sender, EventArgs e)
        {
            this.Hide();
            Nhân_Viên theLoai = new Nhân_Viên();

            theLoai.ShowDialog();

            this.Close();
        }

        private void btn_TKH_Click(object sender, EventArgs e)
        {
            this.Hide();
            Khách_Hàng theLoai = new Khách_Hàng();

            theLoai.ShowDialog();

            this.Close();
        }

        private void btn_themTL_Click(object sender, EventArgs e)
        {
            string maDH = txtMDH.Text;
            string maKH = txtMKH.Text;
            string maNV = txtMNV.Text;
            string thanhTien = txtTT.Text;
            string maTT = txtMTT.Text;

            if (string.IsNullOrWhiteSpace(maDH))
            {
                MessageBox.Show("Vui lòng nhập mã dơn hàng");
                return;
            }

            string sql = "INSERT INTO DonHang (MaDonHang, MaKhachHang, MaNhanVien, ThanhTien, MaTrangThai) VALUES (@MaDonHang, @MaKhachHang, @MaNhanVien, @ThanhTien, @MaTrangThai)";

            SqlParameter[] thucthi_them = new SqlParameter[]
            {
                new SqlParameter("@MaDonHang", maDH),
                new SqlParameter("@MaKhachHang", maKH),
                new SqlParameter("@MaNhanVien", maNV),
                new SqlParameter("@ThanhTien", thanhTien),
                new SqlParameter("@MaTrangThai", maTT)

            };

            bool ketQua = _kn.ThucThiLenh(sql, thucthi_them);
            if (ketQua == true)
            {
                MessageBox.Show("Thêm sách thành công");
                LoadDSDH();
            }
            else
            {
                MessageBox.Show("Thêm sách thất bại");
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            string maDH = txtMDH.Text;
            string maKH = txtMKH.Text;
            string maNV = txtMNV.Text;
            string thanhTien = txtTT.Text;
            string maTT = txtMTT.Text;


            if (string.IsNullOrWhiteSpace(maDH))
            {
                MessageBox.Show("Vui lòng chọn NXB để sửa");
                return;
            }

            string sql = "UPDATE DonHang SET MaKhachHang = @MaKhachHang, MaNhanVien = @MaNhanVien, ThanhTien = @ThanhTien, MaTrangThai=@MaTrangThai WHERE MaDonHang = @MaDonHang";

            SqlParameter[] thucthi_sua = new SqlParameter[]
            {
                new SqlParameter("@MaKhachHang", maKH),
                new SqlParameter("@MaNhanVien", maNV),
                new SqlParameter("@ThanhTien", thanhTien),
                new SqlParameter("@MaTrangThai", maTT),
                new SqlParameter("@MaDonHang", maDH),

            };

            bool ketQua = _kn.ThucThiLenh(sql, thucthi_sua);
            if (ketQua)
            {
                MessageBox.Show("Sửa sách thành công");
                LoadDSDH();
            }
            else
            {
                MessageBox.Show("Sửa sách thất bại");
            }
        }

        private void btn_tl_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 theLoai = new Form1();

            theLoai.ShowDialog();

            this.Close();
        }
    }
}
