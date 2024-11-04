using Microsoft.Win32;
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
using WindowsFormsApp.Properties;

using BCrypt.Net; // Đảm bảo đã cài đặt thư viện BCrypt.Net qua NuGet

namespace MovieTicketManagementSystem
{
    public partial class Form1 : Form
    {
        KetNoi db = new KetNoi(); // Giữ lại một khai báo

        public Form1()
        {
            InitializeComponent();
            login_btn.Enabled = false;

            // Gắn sự kiện TextChanged cho các TextBox
            login_email.TextChanged += new EventHandler(Dangnhap_TextChanged);
            login_password.TextChanged += new EventHandler(Dangnhap_TextChanged);

            // Cấu hình AutoComplete cho txt_email
            login_email.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            login_email.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void Dangnhap_TextChanged(object sender, EventArgs e)
        {
            login_btn.Enabled = !string.IsNullOrWhiteSpace(login_email.Text) &&
                                !string.IsNullOrWhiteSpace(login_password.Text);
        }

        public static bool VerifyPassword(string password, string hashedPassword)
        {
            // Sử dụng BCrypt để kiểm tra tính hợp lệ của mật khẩu
            return BCrypt.Net.BCrypt.Verify(password, hashedPassword);
        }

        public bool CheckTxtNull()
        {
            return !(string.IsNullOrEmpty(login_email.Text) || string.IsNullOrEmpty(login_password.Text));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!CheckTxtNull())
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string con_str = @"Data Source=CHYY;Initial Catalog=MovieTicketManagementSystem;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(con_str))
            {
                conn.Open();
                string email = login_email.Text;
                string query = "SELECT passWord FROM users WHERE email = @Email";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Email", email);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            reader.Read(); // Chỉ cần đọc một lần

                            string hashedPassword = reader["passWord"].ToString();

                            // Kiểm tra mật khẩu
                            if (VerifyPassword(login_password.Text, hashedPassword))
                            {
                                MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Sai mật khẩu!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Tài khoản không tồn tại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (login_showPass.Checked) // Nếu checkbox được chọn
            {
                login_password.PasswordChar = '\0'; // Hiển thị mật khẩu
            }
            else // Nếu checkbox không được chọn
            {
                login_password.PasswordChar = '●'; // Đặt lại ký tự ẩn cho mật khẩu
            }
        }
       
     

     

        private void login_signupBtn_Click(object sender, EventArgs e)
        {
            // Tạo và mở form đăng ký RegForm
            RegForm regForm = new RegForm();
            regForm.Show();

            // Ẩn form đăng nhập hiện tại
            this.Hide();
        }

        private void close_Click(object sender, EventArgs e)
        {
            // Đóng form hiện tại
            this.Close();
        }

        private void login_email_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_password_TextChanged(object sender, EventArgs e)
        {
            // Đặt ký tự ẩn cho ô nhập mật khẩu
            login_password.PasswordChar = '●'; // Hoặc ký tự bạn muốn sử dụng để ẩn
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Tạo và mở form đăng ký RegForm
            GetOTP getotp = new GetOTP();
            getotp.Show();

            // Ẩn form đăng nhập hiện tại
            this.Hide();
        }
    }
}
