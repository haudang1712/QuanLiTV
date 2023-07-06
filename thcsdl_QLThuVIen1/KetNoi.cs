using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace thcsdl_QLThuVIen1
{
    public class KetNoi
    {
        private string chuoiKetNoi = "Data Source=LAPTOP-A9AFGL7F;Initial Catalog=Bookstore;User ID=sa;Password=123";

        private SqlConnection conn;
        public KetNoi()
        {
            conn = new SqlConnection(chuoiKetNoi);
        }


        public DataTable DocDuLieu(string sql, SqlParameter[] v = null)
        {
            DataTable ketQua = new DataTable();
            if (conn.State != ConnectionState.Open)
                conn.Open();
            string query = sql;
            SqlCommand cmd = new SqlCommand(query, conn);

            if (v != null)
                cmd.Parameters.AddRange(v);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            try
            {
                da.Fill(ketQua);
            }
            catch (Exception)
            {
            }
            cmd.Dispose();
            conn.Close();
            da.Dispose();
            return ketQua;
        }

        // Thực thi lệnh và kiểm tra số dòng bị tác động
        // bởi lệnh dùng cho các câu truy vấn update và delete
        // do không tra về giá trị
        public bool ThucThiLenh(string sql, SqlParameter[] v = null)
        {
            DataTable ketQua = new DataTable();
            if (conn.State != ConnectionState.Open)
                conn.Open();
            string query = sql;
            SqlCommand cmd = new SqlCommand(query, conn);
            if (v != null)
                cmd.Parameters.AddRange(v);
            bool result = false;
            try
            {
                result = cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception ex)
            {
                result = false;
            }
            cmd.Dispose();
            conn.Close();
            return result;
        }
    }
}
