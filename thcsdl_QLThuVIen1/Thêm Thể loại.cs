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
    public partial class Thêm_Thể_loại : Form
    {
        public Thêm_Thể_loại()
        {
            InitializeComponent();
            _kn = new KetNoi();
        }
        KetNoi _kn;

        private void LoadDSTheLoai()
        {
            string sql = "SELECT * FROM TheLoai";
            DataTable dsTheLoai = _kn.DocDuLieu(sql);
            lv_dsTL.Items.Clear();
            foreach (DataRow row in dsTheLoai.Rows)
            {
                ListViewItem item = new ListViewItem(row["MaTheLoai"].ToString());
                item.SubItems.Add(row["TenTheLoai"].ToString());

                lv_dsTL.Items.Add(item);
            }
        }

        private void Thêm_Thể_loại_Load(object sender, EventArgs e)
        {
            LoadDSTheLoai();
        }

        private void lv_dsTL_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv_dsTL.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lv_dsTL.SelectedItems[0];
                string maTheLoai = selectedItem.SubItems[0].Text;
                string tenTheLoai = selectedItem.SubItems[1].Text;

                txtMTL.Text = maTheLoai;
                txtTTL.Text = tenTheLoai;


            }
        }

        private void btn_themTL_Click(object sender, EventArgs e)
        {
            string MaTheLoai = txtMTL.Text;
            string TenTheLoai = txtTTL.Text;

            if (string.IsNullOrWhiteSpace(MaTheLoai))
            {
                MessageBox.Show("Vui lòng nhập mã thể loại");
                return;
            }

            string sql = "INSERT INTO TheLoai (MaTheLoai, TenTheLoai) VALUES (@MaTheLoai, @TenTheLoai)";

            SqlParameter[] thucthi_them = new SqlParameter[]
            {
                new SqlParameter("@MaTheLoai", MaTheLoai),
                new SqlParameter("@TenTheLoai", TenTheLoai)
            };

            bool ketQua = _kn.ThucThiLenh(sql, thucthi_them);
            if (ketQua == true)
            {
                MessageBox.Show("Thêm thể loại thành công");
                LoadDSTheLoai();
            }
            else
            {
                MessageBox.Show("Thêm thể loại thất bại");
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            string maTheLoai = txtMTL.Text;
            string tenTheLoai = txtTTL.Text;


            if (string.IsNullOrWhiteSpace(maTheLoai))
            {
                MessageBox.Show("Vui lòng chọn thể loại để sửa");
                return;
            }

            string sql = "UPDATE TheLoai SET TenTheLoai = @TenTheLoai WHERE MaTheLoai = @MaTheLoai";

            SqlParameter[] thucthi_sua = new SqlParameter[]
            {
                new SqlParameter("@MaTheLoai", maTheLoai),
                new SqlParameter("@TenTheLoai", tenTheLoai)
            };

            bool ketQua = _kn.ThucThiLenh(sql, thucthi_sua);
            if (ketQua)
            {
                MessageBox.Show("Sửa sách thành công");
                LoadDSTheLoai();
            }
            else
            {
                MessageBox.Show("Sửa sách thất bại");
            }
        }

        private void btn_xoaTL_Click(object sender, EventArgs e)
        {
            if (lv_dsTL.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lv_dsTL.SelectedItems[0];
                string maTheLoai = selectedItem.SubItems[0].Text;

                string sql = "DELETE * FROM TheLoai WHERE MaTheLoai = @MaTheLoai";
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@MaTheLoai", maTheLoai)
                };

                bool ketQua = _kn.ThucThiLenh(sql, parameters);
                if (ketQua)
                {
                    MessageBox.Show("Xóa sách thành công");
                    LoadDSTheLoai();
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

        private void btn_tl_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 theLoai = new Form1();

            theLoai.ShowDialog();

            this.Close();
        }
    }
}
