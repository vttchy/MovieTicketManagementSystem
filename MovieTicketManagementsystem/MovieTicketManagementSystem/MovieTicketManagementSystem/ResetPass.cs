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

namespace MovieTicketManagementSystem
{
    public partial class ResetPass : Form
    {
        private string email;

        public ResetPass(string email) // Constructor nhận email
        {
            InitializeComponent();
            this.email = email;

        }




        public bool CheckTxtNull()
        {
            return !string.IsNullOrWhiteSpace(reset_pass.Text) && !string.IsNullOrWhiteSpace(reset_confirmpass.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            {
                bool check = CheckTxtNull();
                if (!check)
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (reset_pass.Text != reset_confirmpass.Text)
                {
                    MessageBox.Show("Mật khẩu xác thực không trùng khớp", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string con_str = @"Data Source=CHYY;Initial Catalog=MovieTicketManagementSystem;Integrated Security=True";
                using (SqlConnection conn = new SqlConnection(con_str))
                {
                    conn.Open();

                    // Truy vấn kiểm tra sự tồn tại của tài khoản với email
                    string querykt = "SELECT * FROM users WHERE email=@Email";
                    using (SqlCommand cmd = new SqlCommand(querykt, conn))
                    {
                        cmd.Parameters.AddWithValue("@Email", email);
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.HasRows)
                        {
                            // Đóng reader trước khi thực hiện truy vấn cập nhật
                            reader.Close();

                            // Bắt đầu cập nhật mật khẩu
                            string newPassword = reset_pass.Text;
                            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(newPassword);  // Mã hóa mật khẩu mới

                            string updateQuery = "UPDATE users SET passWord=@HashedPassword WHERE email=@Email";
                            using (SqlCommand updateCmd = new SqlCommand(updateQuery, conn))
                            {
                                // Thêm tham số cho câu lệnh UPDATE
                                updateCmd.Parameters.AddWithValue("@HashedPassword", hashedPassword);
                                updateCmd.Parameters.AddWithValue("@Email", email);

                                int rowsAffected = updateCmd.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Mật khẩu đã được cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    MessageBox.Show("Cập nhật mật khẩu thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy tài khoản với email này.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            // Hiển thị thông báo xác nhận với hai lựa chọn Yes và No
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đóng không?", "Xác nhận đóng", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Nếu người dùng chọn Yes
            if (result == DialogResult.Yes)
            {
                // Đóng form hiện tại
                this.Close();
            }
            // Nếu người dùng chọn No, không làm gì
        }

        private void ResetPass_Load(object sender, EventArgs e)
        {

        }
    }
}