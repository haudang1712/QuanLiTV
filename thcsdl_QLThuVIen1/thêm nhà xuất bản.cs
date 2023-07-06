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
    public partial class thêm_nhà_xuất_bản : Form
    {
        public thêm_nhà_xuất_bản()
        {
            InitializeComponent();
            _kn = new KetNoi();
        }

        KetNoi _kn;

        private void LoadDSNXB()
        {
            string sql = "SELECT * FROM NhaXuatBan";
            DataTable dsNXB = _kn.DocDuLieu(sql);
            lv_dsNXB.Items.Clear();
            foreach (DataRow row in dsNXB.Rows)
            {
                ListViewItem item = new ListViewItem(row["MaNhaXuatBan"].ToString());
                item.SubItems.Add(row["TenNXB"].ToString());
                item.SubItems.Add(row["DiaChi"].ToString());
                item.SubItems.Add(row["SoDienThoai"].ToString());

                lv_dsNXB.Items.Add(item);
            }
        }

        private void lv_dsNXB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv_dsNXB.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lv_dsNXB.SelectedItems[0];
                string maXNB = selectedItem.SubItems[0].Text;
                string tenNXB = selectedItem.SubItems[1].Text;
                string diaChi = selectedItem.SubItems[2].Text;
                string SDT = selectedItem.SubItems[3].Text;


                txtMNXB.Text = maXNB;
                txtTNXB.Text = tenNXB;
                txtDIachi.Text = diaChi;
                txtSĐT.Text = SDT;


            }
        }

        private void thêm_nhà_xuất_bản_Load(object sender, EventArgs e)
        {
            LoadDSNXB();
        }

        private void btn_themTL_Click(object sender, EventArgs e)
        {
            string maNXB = txtMNXB.Text;
            string tenNXB = txtTNXB.Text;
            string diaChi = txtDIachi.Text;
            string SDT = txtSĐT.Text;


            if (string.IsNullOrWhiteSpace(maNXB))
            {
                MessageBox.Show("Vui lòng nhập mã NXB");
                return;
            }

            string sql = "INSERT INTO NhaXuatBan (MaNhaXuatBan, TenNXB, DiaChi, SoDienThoai) VALUES (@MaNhaXuatBan, @TenNXB, @DiaChi, @SoDienThoai)";

            SqlParameter[] thucthi_them = new SqlParameter[]
            {
                new SqlParameter("@MaNhaXuatBan", maNXB),
                new SqlParameter("@TenNXB", tenNXB),
                new SqlParameter("@DiaChi", diaChi),
                new SqlParameter("@SoDienThoai", SDT)
            };

            bool ketQua = _kn.ThucThiLenh(sql, thucthi_them);
            if (ketQua == true)
            {
                MessageBox.Show("Thêm sách thành công");
                LoadDSNXB();
            }
            else
            {
                MessageBox.Show("Thêm sách thất bại");
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            string maNXB = txtMNXB.Text;
            string tenNXB = txtTNXB.Text;
            string diaChi = txtDIachi.Text;
            string SDT = txtSĐT.Text;


            if (string.IsNullOrWhiteSpace(maNXB))
            {
                MessageBox.Show("Vui lòng chọn NXB để sửa");
                return;
            }

            string sql = "UPDATE NhaXuatBan SET TenNXB = @TenNXB, DiaChi = @DiaChi, SoDienThoai = @SoDienThoai WHERE MaNhaXuatBan = @MaNhaXuatBan";

            SqlParameter[] thucthi_sua = new SqlParameter[]
            {
                new SqlParameter("@TenNXB", tenNXB),
                new SqlParameter("@DiaChi", diaChi),
                new SqlParameter("@SoDienThoai", SDT),
                new SqlParameter("@MaNhaXuatBan", maNXB)
            };

            bool ketQua = _kn.ThucThiLenh(sql, thucthi_sua);
            if (ketQua)
            {
                MessageBox.Show("Sửa sách thành công");
                LoadDSNXB();
            }
            else
            {
                MessageBox.Show("Sửa sách thất bại");
            }
        }

        private void btn_xoaTL_Click(object sender, EventArgs e)
        {

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
