using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace thcsdl_QLThuVIen1
{
    public partial class chi_tiết_hóa_đơn : Form
    {
        public chi_tiết_hóa_đơn()
        {
            InitializeComponent();
            _kn = new KetNoi();
        }

        KetNoi _kn;


        private void LoadDSSach()
        {
            string sql = "select * from ThongTin_DonHang";
            DataTable dsSach = _kn.DocDuLieu(sql);
            lv_dsTrangChu.Items.Clear();
            foreach (DataRow row in dsSach.Rows)
            {
                ListViewItem item = new ListViewItem(row["MaDonHang"].ToString());
                item.SubItems.Add(row["TenKhachHang"].ToString());
                item.SubItems.Add(row["DiaChi"].ToString());
                item.SubItems.Add(row["SoDienThoai"].ToString());
                item.SubItems.Add(row["TenNhanVien"].ToString());
                item.SubItems.Add(row["TenSach"].ToString());
                item.SubItems.Add(row["Gia"].ToString());
                item.SubItems.Add(row["SoLuong"].ToString());
                item.SubItems.Add(row["GiaSach"].ToString());
                item.SubItems.Add(row["TenTrangThai"].ToString());
                lv_dsTrangChu.Items.Add(item);
            }
        }

        private void btn_Thoát_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 theLoai = new Form1();

            theLoai.ShowDialog();

            this.Close();
        }

        private void chi_tiết_hóa_đơn_Load(object sender, EventArgs e)
        {
            LoadDSSach();
        }
    }

}
