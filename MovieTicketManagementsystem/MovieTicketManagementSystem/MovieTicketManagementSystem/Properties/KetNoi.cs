using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp.Properties
{
    class KetNoi
    {
        private string con_str = @"Data Source=CHYY;Initial Catalog=MovieTicketManagementSystem;Integrated Security=True";

        // Hàm LayDuLieu để lấy dữ liệu từ cơ sở dữ liệu và trả về DataSet
        public DataSet LayDuLieu(string query, string table_name)
        {
            DataSet ds = new DataSet();
            try
            {
                using (SqlConnection conn = new SqlConnection(con_str))
                {
                    using (SqlDataAdapter da = new SqlDataAdapter(query, conn))
                    {
                        da.Fill(ds, table_name);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lấy dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return ds;
        }

        // Hàm ThucThi để thực thi các lệnh SQL (INSERT, UPDATE, DELETE)
        public bool ThucThi(string query)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(con_str))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        int soluong = cmd.ExecuteNonQuery();
                        return soluong > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
    }
}
