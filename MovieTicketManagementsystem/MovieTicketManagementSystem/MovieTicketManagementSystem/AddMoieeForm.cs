using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace MovieTicketManagementSystem
{
    public partial class AddMoieeForm : UserControl
    {
        string con_str = @"Data Source=CHYY;Initial Catalog=MovieTicketManagementSystem;Integrated Security=True";

        public AddMoieeForm()
        {
            InitializeComponent();
            displayData();
        }
        public void displayData()
        {
            movieData mData = new movieData();
            List<movieData> listData = mData.movieListData();
            dataGridView1.DataSource = listData;
        }

        private void addMovie_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra nếu các trường dữ liệu bị trống
                if (string.IsNullOrWhiteSpace(addMovie_movieID.Text) ||
                    string.IsNullOrWhiteSpace(movieName.Text) ||
                    string.IsNullOrWhiteSpace(genre.Text) ||
                    string.IsNullOrWhiteSpace(price.Text) ||
                    string.IsNullOrWhiteSpace(capacity.Text) ||
                    pictureBox1.ImageLocation == null)
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin và chọn hình ảnh.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (SqlConnection connect = new SqlConnection(con_str))
                {
                    connect.Open();
                    string checkID = "SELECT movie_id FROM Movies WHERE movie_id = @movieID";
                    using (SqlCommand cID = new SqlCommand(checkID, connect))
                    {
                        cID.Parameters.AddWithValue("@movieID", addMovie_movieID.Text.Trim());
                        SqlDataAdapter adapter = new SqlDataAdapter(cID);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        if (table.Rows.Count > 0)
                        {
                            MessageBox.Show($"Movie ID: {addMovie_movieID.Text.Trim()} đã tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            string insertDate = "INSERT INTO Movies (movie_id, movie_name, genre, price, capacity, movie_image,status, created_at) " +
                                                "VALUES (@movieID, @movieName, @genre, @price, @capacity, @movieImage,@status, @date)";

                            // Tạo đường dẫn lưu hình ảnh
                            string imageDirectory = "C:\\MovieImages";
                            if (!Directory.Exists(imageDirectory))
                            {
                                Directory.CreateDirectory(imageDirectory);
                            }
                            string path = Path.Combine(imageDirectory, addMovie_movieID.Text.Trim() + ".jpg");
                            File.Copy(pictureBox1.ImageLocation, path, true);

                            using (SqlCommand cmd = new SqlCommand(insertDate, connect))
                            {
                                cmd.Parameters.AddWithValue("@movieID", addMovie_movieID.Text.Trim());
                                cmd.Parameters.AddWithValue("@movieName", movieName.Text.Trim());
                                cmd.Parameters.AddWithValue("@genre", genre.SelectedItem.ToString());
                                cmd.Parameters.AddWithValue("@price", price.Text.Trim()); // Chuyển sang kiểu số nếu cần
                                cmd.Parameters.AddWithValue("@capacity", int.Parse(capacity.Text.Trim())); // Chuyển sang kiểu số nếu cần
                                cmd.Parameters.AddWithValue("@movieImage", path);
                                cmd.Parameters.AddWithValue("@status", status.SelectedItem.ToString());
                                cmd.Parameters.AddWithValue("@date", DateTime.Now);

                                cmd.ExecuteNonQuery();
                                displayData();
                                clearFileds();
                                MessageBox.Show("Thêm phim thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void addMovie_importBtn_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog file = new OpenFileDialog
                {
                    Filter = "Image Files(*.jpg; *.png)|*.jpg;*.png"
                };
                if (file.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.ImageLocation = file.FileName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
      
        public void clearFileds()
        {
            addMovie_movieID.Text = "";
            movieName.Text = "";
            genre.SelectedIndex = -1;
            price.Text = "";
            capacity.Text = "";
            pictureBox1.Image = null;
            status.SelectedIndex = -1;
        }

        private void updateMovie_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra nếu có trường dữ liệu nào bị bỏ trống
                if (string.IsNullOrWhiteSpace(addMovie_movieID.Text) ||
                    string.IsNullOrWhiteSpace(movieName.Text) ||
                    string.IsNullOrWhiteSpace(genre.Text) ||
                    string.IsNullOrWhiteSpace(price.Text) ||
                    string.IsNullOrWhiteSpace(capacity.Text) ||
                    status.SelectedItem == null)
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Kết nối cơ sở dữ liệu và cập nhật thông tin phim
                using (SqlConnection connect = new SqlConnection(con_str))
                {
                    connect.Open();
                    string updateQuery = "UPDATE Movies SET movie_name = @movieName, genre = @genre, price = @price, " +
                                         "capacity = @capacity, movie_image = @movieImage, status = @status, " +
                                         "update_date = @update_date WHERE movie_id = @movieID";

                    // Tạo đường dẫn hình ảnh mới (nếu cần thiết)
                    string imageDirectory = "C:\\MovieImages";
                    string path = Path.Combine(imageDirectory, addMovie_movieID.Text.Trim() + ".jpg");
                    if (pictureBox1.ImageLocation != path)
                    {
                        File.Copy(pictureBox1.ImageLocation, path, true);
                    }

                    using (SqlCommand cmd = new SqlCommand(updateQuery, connect))
                    {
                        cmd.Parameters.AddWithValue("@movieID", addMovie_movieID.Text.Trim());
                        cmd.Parameters.AddWithValue("@movieName", movieName.Text.Trim());
                        cmd.Parameters.AddWithValue("@genre", genre.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@price", price.Text.Trim()); // Chuyển đổi thành kiểu số nếu cần
                        cmd.Parameters.AddWithValue("@capacity", int.Parse(capacity.Text.Trim())); // Chuyển đổi thành kiểu số nếu cần
                        cmd.Parameters.AddWithValue("@movieImage", path);
                        cmd.Parameters.AddWithValue("@status", status.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@update_date", DateTime.Now);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Cập nhật phim thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            displayData(); // Làm mới lại dữ liệu hiển thị trong DataGridView
                            clearFileds(); // Xóa các trường nhập liệu
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy phim để cập nhật.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void deleteMovie_Btn_Click(object sender, EventArgs e)
        {
            try
    {
        // Kiểm tra nếu movieID không có giá trị
        if (string.IsNullOrWhiteSpace(addMovie_movieID.Text))
        {
            MessageBox.Show("Vui lòng chọn một phim để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        // Hiển thị hộp thoại xác nhận trước khi đánh dấu xóa
        DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa phim này không?", 
                                                    "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        if (dialogResult == DialogResult.Yes)
        {
            using (SqlConnection connect = new SqlConnection(con_str))
            {
                connect.Open();
                // Cập nhật cột delete_date thay vì xóa bản ghi
                string updateQuery = "UPDATE Movies SET delete_date = @deleteDate WHERE movie_id = @movieID";

                using (SqlCommand cmd = new SqlCommand(updateQuery, connect))
                {
                    cmd.Parameters.AddWithValue("@deleteDate", DateTime.Now); // Gán giá trị ngày hiện tại
                    cmd.Parameters.AddWithValue("@movieID", addMovie_movieID.Text.Trim());

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Phim đã được đánh dấu xóa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        displayData(); // Làm mới lại dữ liệu hiển thị trong DataGridView
                        clearFileds(); // Xóa các trường nhập liệu
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy phim để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }
    }
    catch (Exception ex)
    {
        MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
        }


        private void status_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void clearMovie_Btn_Click(object sender, EventArgs e)
        {
            clearFileds();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private int id = 0;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                id=(int)row.Cells[0].Value;
                addMovie_movieID.Text =row.Cells[1].Value.ToString();
                movieName.Text = row.Cells[2].Value.ToString();
                genre.Text = row.Cells[3].Value.ToString();
                price.Text = row.Cells[4].Value.ToString();
                capacity.Text = row.Cells[5].Value.ToString();
                status.Text = row.Cells[6].Value.ToString();
                pictureBox1.ImageLocation=row.Cells[7].Value.ToString();

            }
        }
    }
}
