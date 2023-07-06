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
    public partial class Thêm_tác_giả : Form
    {
        public Thêm_tác_giả()
        {
            InitializeComponent();
            _kn = new KetNoi();
        }

        KetNoi _kn;

        private void LoadDSTG()
        {
            string sql = "SELECT * FROM TacGia";
            DataTable dsNXB = _kn.DocDuLieu(sql);
            lv_dsTG.Items.Clear();
            foreach (DataRow row in dsNXB.Rows)
            {
                ListViewItem item = new ListViewItem(row["MaTacGia"].ToString());
                item.SubItems.Add(row["TenTacGia"].ToString());
                item.SubItems.Add(row["DiaChi"].ToString());
                item.SubItems.Add(row["SoDienThoai"].ToString());

                lv_dsTG.Items.Add(item);
            }
        }

        private void Thêm_tác_giả_Load(object sender, EventArgs e)
        {
            LoadDSTG();
        }

        private void lv_dsTG_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv_dsTG.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lv_dsTG.SelectedItems[0];
                string maTG = selectedItem.SubItems[0].Text;
                string tenTG = selectedItem.SubItems[1].Text;
                string diaChi = selectedItem.SubItems[2].Text;
                string SDT = selectedItem.SubItems[3].Text;


                txtTG.Text = maTG;
                txtTacGia.Text = tenTG;
                txtDIachi.Text = diaChi;
                txtSĐT.Text = SDT;


            }
        }

        private void btn_themTL_Click(object sender, EventArgs e)
        {
            string maTG = txtTG.Text;
            string tenTG = txtTacGia.Text;
            string diaChi = txtDIachi.Text;
            string SDT = txtSĐT.Text;


            if (string.IsNullOrWhiteSpace(maTG))
            {
                MessageBox.Show("Vui lòng nhập mã NXB");
                return;
            }

            string sql = "INSERT INTO TacGia (MaTacGia, TenTacGia, DiaChi, SoDienThoai) VALUES (@MaTacGia, @TenTacGia, @DiaChi, @SoDienThoai)";

            SqlParameter[] thucthi_them = new SqlParameter[]
            {
                new SqlParameter("@MaTacGia", maTG),
                new SqlParameter("@TenTacGia", tenTG),
                new SqlParameter("@DiaChi", diaChi),
                new SqlParameter("@SoDienThoai", SDT)
            };

            bool ketQua = _kn.ThucThiLenh(sql, thucthi_them);
            if (ketQua == true)
            {
                MessageBox.Show("Thêm sách thành công");
                LoadDSTG();
            }
            else
            {
                MessageBox.Show("Thêm sách thất bại");
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            string maTG = txtTG.Text;
            string tenTG = txtTacGia.Text;
            string diaChi = txtDIachi.Text;
            string SDT = txtSĐT.Text;


            if (string.IsNullOrWhiteSpace(maTG))
            {
                MessageBox.Show("Vui lòng chọn NXB để sửa");
                return;
            }

            string sql = "UPDATE TacGia SET TenTacGia = @TenTacGia, DiaChi = @DiaChi, SoDienThoai = @SoDienThoai WHERE MaTacGia = @MaTacGia";

            SqlParameter[] thucthi_sua = new SqlParameter[]
            {
                new SqlParameter("@TenTacGia", tenTG),
                new SqlParameter("@DiaChi", diaChi),
                new SqlParameter("@SoDienThoai", SDT),
                new SqlParameter("@MaTacGia", maTG)
            };

            bool ketQua = _kn.ThucThiLenh(sql, thucthi_sua);
            if (ketQua)
            {
                MessageBox.Show("Sửa sách thành công");
                LoadDSTG();
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
