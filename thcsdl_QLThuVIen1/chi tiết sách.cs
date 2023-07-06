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
    public partial class chi_tiết_sách : Form
    {
        public chi_tiết_sách()
        {
            InitializeComponent();
            _kn = new KetNoi();
        }

        KetNoi _kn;


        private void LoadDSSach()
        {
            string sql = "select * from ThongTin_Sach";
            DataTable dsSach = _kn.DocDuLieu(sql);
            lv_dsTrangChu.Items.Clear();
            foreach (DataRow row in dsSach.Rows)
            {
                ListViewItem item = new ListViewItem(row["Masach"].ToString());
                item.SubItems.Add(row["TenSach"].ToString());
                item.SubItems.Add(row["TenTacGia"].ToString());
                item.SubItems.Add(row["TenNXB"].ToString());
                item.SubItems.Add(row["TenTheLoai"].ToString());
                item.SubItems.Add(row["TenNgonNgu"].ToString());
                item.SubItems.Add(row["SoLuong"].ToString());
                item.SubItems.Add(row["Gia"].ToString());
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

        private void lv_dsTrangChu_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void chi_tiết_sách_Load(object sender, EventArgs e)
        {
            LoadDSSach();
        }
    }
}
