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
    public partial class thêm_ngôn_ngữ : Form
    {
        public thêm_ngôn_ngữ()
        {
            InitializeComponent();
            _kn = new KetNoi();

        }
        KetNoi _kn;

        private void LoadDSNgonNgu()
        {
            string sql = "SELECT * FROM NgonNgu";
            DataTable dsNgonNgu = _kn.DocDuLieu(sql);
            lv_dsNN.Items.Clear();
            foreach (DataRow row in dsNgonNgu.Rows)
            {
                ListViewItem item = new ListViewItem(row["MaNgonNgu"].ToString());
                item.SubItems.Add(row["TenNgonNgu"].ToString());

                lv_dsNN.Items.Add(item);
            }
        }

        private void thêm_ngôn_ngữ_Load(object sender, EventArgs e)
        {
            LoadDSNgonNgu();
        }

        private void lv_dsNN_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv_dsNN.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lv_dsNN.SelectedItems[0];
                string maNgonNgu = selectedItem.SubItems[0].Text;
                string tenNgonNgu = selectedItem.SubItems[1].Text;

                txtMTL.Text = maNgonNgu;
                txtTTL.Text = maNgonNgu;


            }
        }

        private void btn_themTL_Click(object sender, EventArgs e)
        {
            string MaTheLoai = txtMTL.Text;
            string TenTheLoai = txtTTL.Text;

            if (string.IsNullOrWhiteSpace(MaTheLoai))
            {
                MessageBox.Show("Vui lòng nhập mã ngôn ngữ");
                return;
            }

            string sql = "INSERT INTO NgonNgu (MaNgonNgu, TenNgonNgu) VALUES (@MaNgonNgu, @TenNgonNgu)";

            SqlParameter[] thucthi_them = new SqlParameter[]
            {
                new SqlParameter("@MaNgonNgu", MaTheLoai),
                new SqlParameter("@TenNgonNgu", TenTheLoai)
            };

            bool ketQua = _kn.ThucThiLenh(sql, thucthi_them);
            if (ketQua == true)
            {
                MessageBox.Show("Thêm ngôn ngữ thành công");
                LoadDSNgonNgu();
            }
            else
            {
                MessageBox.Show("Thêm ngôn ngữ thất bại");
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            string maTheLoai = txtMTL.Text;
            string tenTheLoai = txtTTL.Text;


            if (string.IsNullOrWhiteSpace(maTheLoai))
            {
                MessageBox.Show("Vui lòng chọn ngô ngữ để sửa");
                return;
            }

            string sql = "UPDATE NgonNgu SET TenNgonNgu = @TenNgonNgu WHERE MaNgonNgu = @MaNgonNgu";

            SqlParameter[] thucthi_sua = new SqlParameter[]
            {
                new SqlParameter("@MaNgonNgu", maTheLoai),
                new SqlParameter("@TenNgonNgu", tenTheLoai)
            };

            bool ketQua = _kn.ThucThiLenh(sql, thucthi_sua);
            if (ketQua)
            {
                MessageBox.Show("Sửa ngôn ngữ thành công");
                LoadDSNgonNgu();
            }
            else
            {
                MessageBox.Show("Sửa ngôn ngữ thất bại");
            }
        }

        private void btn_xoaTL_Click(object sender, EventArgs e)
        {
            //2 kia sai này chắc không đúng đâu
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
