using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using WindowsFormsApp.Properties;
using System.Collections;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace MovieTicketManagementSystem
{

    public partial class AddStaffForm : UserControl
    {
        string con_str = @"Data Source=CHYY;Initial Catalog=MovieTicketManagementSystem;Integrated Security=True";

        public AddStaffForm()
        {
            InitializeComponent();
            displayData();
        }
        public void displayData()
        {
            staffData sData = new staffData();
            List<staffData> listData = sData.staffDataListData();
            dataGridView1.DataSource = listData;
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
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
        private void addStaff_addBtn_Click(object sender, EventArgs e)
        {
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
            clearFields();
        }


        private void addStaff_updateBtn_Click(object sender, EventArgs e)
        {
        






        }
        public void clearFields()
        {
            reg_userName.Text = "";
            reg_NumberPhone.Text = "";
            reg_Email.Text = "";
            reg_password.Text = "";
            reg_cPassword.Text = "";
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void reg_userName_TextChanged(object sender, EventArgs e)
        {

        }

        private int getID = 0;

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            // Đảm bảo rằng AutoSizeColumnsMode chỉ thiết lập một lần
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Kiểm tra xem hàng được nhấp vào có hợp lệ không
            if (e.RowIndex >= 0 && dataGridView1.Rows[e.RowIndex].Cells[0].Value != null)
            {
                // Lấy hàng được chọn
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Lấy ID và các giá trị khác, kiểm tra giá trị null
                getID = row.Cells[0].Value != null ? Convert.ToInt32(row.Cells[0].Value) : 0;
                reg_userName.Text = row.Cells[1].Value?.ToString() ?? "";
                reg_NumberPhone.Text = row.Cells[3].Value?.ToString() ?? "";
                reg_Email.Text = row.Cells[4].Value?.ToString() ?? "";
                reg_password.Text = row.Cells[2].Value?.ToString() ?? "";
                reg_cPassword.Text = row.Cells[2].Value?.ToString() ?? "";
            }
        }



    }
}
   



        
       
    

