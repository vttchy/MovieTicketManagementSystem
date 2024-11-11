using System;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using BCrypt.Net;
using WindowsFormsApp.Properties;

namespace MovieTicketManagementSystem
{
    public partial class AddStaffForm : UserControl
    {
        private readonly string con_str = @"Data Source=CHYY;Initial Catalog=MovieTicketManagementSystem;Integrated Security=True";
        private KetNoi db = new KetNoi();
        private int getID = 0;

        public AddStaffForm()
        {
            InitializeComponent();
            DisplayData();
            dataGridView1.CellClick += dataGridView1_CellClick;  // Đăng ký sự kiện CellClick
        }

        // Hiển thị dữ liệu nhân viên lên DataGridView
        private void DisplayData()
        {
            DataSet ds = db.LayDuLieu("SELECT * FROM users", "users");
            if (ds != null)
            {
                dataGridView1.DataSource = ds.Tables["users"];
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        // Hàm mã hóa mật khẩu
        private string HashPassword(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password);
        }

        // Kiểm tra các trường trống
        private bool IsEmpty()
        {
            return string.IsNullOrWhiteSpace(reg_userName.Text) ||
                   string.IsNullOrWhiteSpace(reg_NumberPhone.Text) ||
                   string.IsNullOrWhiteSpace(reg_Email.Text) ||
                   string.IsNullOrWhiteSpace(reg_password.Text) ||
                   string.IsNullOrWhiteSpace(reg_cPassword.Text);
        }

        // Làm sạch các trường nhập liệu
        private void ClearFields()
        {
            reg_userName.Text = "";
            reg_NumberPhone.Text = "";
            reg_Email.Text = "";
            reg_password.Text = "";
            reg_cPassword.Text = "";
        }

        // Xử lý sự kiện khi nhấn nút Thêm
        private void addStaff_addBtn_Click(object sender, EventArgs e)
        {
            if (IsEmpty())
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string email = reg_Email.Text;
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            if (!Regex.IsMatch(email, emailPattern))
            {
                MessageBox.Show("Email không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (reg_cPassword.Text != reg_password.Text)
            {
                MessageBox.Show("Mật khẩu xác thực không trùng khớp", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string hashedPassword = HashPassword(reg_password.Text);
            string checkQuery = $"SELECT * FROM users WHERE email= '{email}'";
            DataSet ds = db.LayDuLieu(checkQuery, "users");

            if (ds != null && ds.Tables["users"].Rows.Count >= 1)
            {
                MessageBox.Show("Trùng tài khoản gmail!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string insertQuery = $"INSERT INTO users (userName, passWord, SDT, email) VALUES ('{reg_userName.Text}', '{hashedPassword}', '{reg_NumberPhone.Text}', '{email}')";
            bool isInserted = db.ThucThi(insertQuery);

            if (isInserted)
            {
                MessageBox.Show("Đăng ký thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DisplayData();
                ClearFields();
            }
            else
            {
                MessageBox.Show("Đăng ký không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Xử lý sự kiện khi nhấn nút Cập nhật
        private void addStaff_updateBtn_Click(object sender, EventArgs e)
        {
            if (IsEmpty())
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (DialogResult.Yes == MessageBox.Show($"Bạn có chắc chắn muốn cập nhật ID: {getID}?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                using (SqlConnection conn = new SqlConnection(con_str))
                {
                    conn.Open();
                    string checkQuery = "SELECT * FROM users WHERE userName = @usern";
                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@usern", reg_userName.Text.Trim());
                        SqlDataAdapter adapter = new SqlDataAdapter(checkCmd);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        if (table.Rows.Count >= 2)
                        {
                            MessageBox.Show("Tên người dùng đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        string updateQuery = "UPDATE users SET userName = @usern, passWord = @pass, SDT = @sdt, email = @email WHERE id_User = @id_User";
                        using (SqlCommand updateCmd = new SqlCommand(updateQuery, conn))
                        {
                            updateCmd.Parameters.AddWithValue("@usern", reg_userName.Text.Trim());
                            updateCmd.Parameters.AddWithValue("@sdt", reg_NumberPhone.Text.Trim());
                            updateCmd.Parameters.AddWithValue("@pass", HashPassword(reg_password.Text.Trim()));
                            updateCmd.Parameters.AddWithValue("@id_User", getID);
                            updateCmd.Parameters.AddWithValue("@email", reg_Email.Text.Trim());
                            updateCmd.ExecuteNonQuery();
                            MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            DisplayData();
                            ClearFields();
                        }
                    }
                }
            }
        }

        // Sự kiện khi click vào một ô trong DataGridView
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Kiểm tra và lấy giá trị của từng cột
                if (row.Cells[0].Value != null)
                    getID = Convert.ToInt32(row.Cells[0].Value);

                reg_userName.Text = row.Cells[1].Value?.ToString() ?? "";
                reg_NumberPhone.Text = row.Cells[3].Value?.ToString() ?? "";
                reg_Email.Text = row.Cells[4].Value?.ToString() ?? "";
                reg_password.Text = "";
                reg_cPassword.Text = "";
            }
        }

        private void addStaff_daleteBtn_Click(object sender, EventArgs e)
        {

         
                if (getID == 0)
                {
                    MessageBox.Show("Vui lòng chọn nhân viên để xóa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (DialogResult.Yes == MessageBox.Show($"Bạn có chắc chắn muốn xóa nhân viên ID: {getID}?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    string deleteQuery = $"DELETE FROM users WHERE id_User = {getID}";
                    bool isDeleted = db.ThucThi(deleteQuery);

                    if (isDeleted)
                    {
                        MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DisplayData();
                        ClearFields();
                    }
                    else
                    {
                        MessageBox.Show("Xóa không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                
            }

        }

        private void addStaff_clearBtn_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
