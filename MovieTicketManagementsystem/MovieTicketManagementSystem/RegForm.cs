using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp.Properties;
using BCrypt.Net;
namespace MovieTicketManagementSystem
{
    public partial class RegForm : Form
    {
        public RegForm()
        {
            InitializeComponent();


        }
        private void reg_TextChanged(object sender, EventArgs e)
        {

        }

        private void RegForm_Load(object sender, EventArgs e)
        {

        }
        KetNoi db = new KetNoi();
        public static string HashPassword(string password)
        {
            // Sử dụng BCrypt để tạo một salt ngẫu nhiên và mã hóa mật khẩu
            string salt = BCrypt.Net.BCrypt.GenerateSalt();
            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password, salt);

            return hashedPassword;
        }
        public static bool VerifyPassword(string password, string hashedPassword)
        {
            // Sử dụng BCrypt để kiểm tra tính hợp lệ của mật khẩu
            return BCrypt.Net.BCrypt.Verify(password, hashedPassword);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string hashedPassword = HashPassword(reg_password.Text);
            string email = reg_Email.Text;

            // Biểu thức chính quy để kiểm tra định dạng email
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

            if (!Regex.IsMatch(email, emailPattern))
            {
                MessageBox.Show("Email không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Dừng thực hiện nếu email không hợp lệ
            }
            if (reg_cPassword.Text != reg_password.Text)
            {
                MessageBox.Show("Mật khẩu xác thực không trùng khớp", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string query = string.Format("insert into users(userName,passWord, SDT ,email) values ('{0}','{1}','{2}','{3}')",
             reg_userName.Text, hashedPassword, reg_NumberPhone.Text, reg_Email.Text);
            string check = string.Format("select * from users where email= '{0}' ", reg_Email.Text);
            DataSet ds = db.LayDuLieu(check, "users");
            if (ds.Tables["users"].Rows.Count >= 1)
            {
                MessageBox.Show("Trùng tài khoản gmail !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            bool kt = db.ThucThi(query);
            if (kt == true)
            {
                MessageBox.Show("Đăng ký thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form1 dangnhap = new Form1();
                this.Hide();
                dangnhap.Show();
            }
            else
            {
                MessageBox.Show("Đăng ký k thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void reg_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void reg_showPass_CheckedChanged(object sender, EventArgs e)
        {
            if (reg_showPass.Checked ) // Nếu checkbox được chọn
            {
                reg_password.PasswordChar = '\0'; // Hiển thị mật khẩu
                reg_cPassword.PasswordChar = '\0';
            }
            else // Nếu checkbox không được chọn
            {
                reg_password.PasswordChar = '●'; // Đặt lại ký tự ẩn cho mật khẩu
                reg_cPassword.PasswordChar = '●';
            }


        }
        private void reg_password_TextChanged(object sender, EventArgs e)
        {
            // Đặt ký tự ẩn cho ô nhập mật khẩu
            reg_password.PasswordChar = '●'; // Hoặc ký tự bạn muốn sử dụng để ẩn
        }

        private void reg_cPassword_TextChanged(object sender, EventArgs e)
        {
            // Đặt ký tự ẩn cho ô nhập mật khẩu
            reg_cPassword.PasswordChar = '●'; // Hoặc ký tự bạn muốn sử dụng để ẩn


        }
        private void reg_btn_Click(object sender, EventArgs e)
        {
            if (reg_userName.Text == "" || reg_password.Text == "" || reg_cPassword.Text == "" || reg_NumberPhone.Text == "" || reg_Email.Text == "")
            {
                MessageBox.Show("Pleasse fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (reg_password.Text != reg_cPassword.Text)
            {
                MessageBox.Show("Password does not match", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (reg_password.Text.Length < 8)
            {
                MessageBox.Show("Invalid Password", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

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

        private void reg_signlnBtn_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void reg_NumberPhone_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

