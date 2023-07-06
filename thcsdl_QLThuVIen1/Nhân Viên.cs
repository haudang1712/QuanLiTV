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
    public partial class Nhân_Viên : Form
    {
        public Nhân_Viên()
        {
            InitializeComponent();
            _kn = new KetNoi();
        }

        KetNoi _kn;

        private void LoadDSNV()
        {
            string sql = "SELECT * FROM NhanVien";
            DataTable dsNXB = _kn.DocDuLieu(sql);
            lv_dsNV.Items.Clear();
            foreach (DataRow row in dsNXB.Rows)
            {
                ListViewItem item = new ListViewItem(row["MaNhanVien"].ToString());
                item.SubItems.Add(row["TenNhanVien"].ToString());
                item.SubItems.Add(row["DiaChi"].ToString());
                item.SubItems.Add(row["SoDienThoai"].ToString());

                lv_dsNV.Items.Add(item);
            }
        }

        private void lv_dsNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv_dsNV.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lv_dsNV.SelectedItems[0];
                string maNV = selectedItem.SubItems[0].Text;
                string tenNV = selectedItem.SubItems[1].Text;
                string diaChi = selectedItem.SubItems[2].Text;
                string SDT = selectedItem.SubItems[3].Text;


                txtMNV.Text = maNV;
                txtTNV.Text = tenNV;
                txtDIachi.Text = diaChi;
                txtSĐT.Text = SDT;


            }
        }

        private void Nhân_Viên_Load(object sender, EventArgs e)
        {
            LoadDSNV();
        }

        private void btn_themTL_Click(object sender, EventArgs e)
        {
            string maNV = txtMNV.Text;
            string tenNV = txtTNV.Text;
            string diaChi = txtDIachi.Text;
            string SDT = txtSĐT.Text;


            if (string.IsNullOrWhiteSpace(maNV))
            {
                MessageBox.Show("Vui lòng nhập mã nhan viên");
                return;
            }

            string sql = "INSERT INTO NhanVien (MaNhanVien, TenNhanVien, DiaChi, SoDienThoai) VALUES (@MaNhanVien, @TenNhanVien, @DiaChi, @SoDienThoai)";

            SqlParameter[] thucthi_them = new SqlParameter[]
            {
                new SqlParameter("@MaNhanVien", maNV),
                new SqlParameter("@TenNhanVien", tenNV),
                new SqlParameter("@DiaChi", diaChi),
                new SqlParameter("@SoDienThoai", SDT)
            };

            bool ketQua = _kn.ThucThiLenh(sql, thucthi_them);
            if (ketQua == true)
            {
                MessageBox.Show("Thêm sách thành công");
                LoadDSNV();
            }
            else
            {
                MessageBox.Show("Thêm sách thất bại");
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            string maNV = txtMNV.Text;
            string tenNV = txtTNV.Text;
            string diaChi = txtDIachi.Text;
            string SDT = txtSĐT.Text;


            if (string.IsNullOrWhiteSpace(maNV))
            {
                MessageBox.Show("Vui lòng chọn nhan vien để sửa");
                return;
            }

            string sql = "UPDATE NhanVien SET TenNhanVien = @TenNhanVien, DiaChi = @DiaChi, SoDienThoai = @SoDienThoai WHERE MaNhanVien = @MaNhanVien";

            SqlParameter[] thucthi_sua = new SqlParameter[]
            {
                new SqlParameter("@TenNhanVien", tenNV),
                new SqlParameter("@DiaChi", diaChi),
                new SqlParameter("@SoDienThoai", SDT),
                new SqlParameter("@MaNhanVien", maNV)
            };

            bool ketQua = _kn.ThucThiLenh(sql, thucthi_sua);
            if (ketQua)
            {
                MessageBox.Show("Sửa sách thành công");
                LoadDSNV();
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
