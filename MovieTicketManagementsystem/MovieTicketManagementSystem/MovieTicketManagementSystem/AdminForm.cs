using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieTicketManagementSystem
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void AdminForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

      

        private void logout_btn_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Are you sure you want to logout?", "Confirmation Message"
               , MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                Application.Exit();
            }
        }

        private void addStaffForm1_Load(object sender, EventArgs e)
        {

        }

        private void addMoieeForm1_Load(object sender, EventArgs e)
        {

        }

        private void dashboard_btn_Click(object sender, EventArgs e)
        {
            // Xóa các điều khiển con hiện tại trong dashboardForm (giả sử bạn có một Panel tên là mainPanel trong dashboardForm)


            // Tạo instance của AddStaffForm và đặt Dock để hiển thị toàn bộ panel
            AddStaffForm addStaffForm = new AddStaffForm();
            addStaffForm.Dock = DockStyle.Fill;

            // Thêm AddStaffForm vào mainPanel
            addStaffForm1.Controls.Add(addStaffForm);
        }

      

        private void button1_Click(object sender, EventArgs e)
        {
            // Xóa các điều khiển con hiện tại trong mainPanel
            addStaffForm1.Controls.Clear();

            // Tạo instance của AddStaffForm và đặt Dock để hiển thị toàn bộ panel
            AddStaffForm addStaffForm = new AddStaffForm();
            addStaffForm.Dock = DockStyle.Fill;

            // Thêm AddStaffForm vào mainPanel
            addStaffForm1.Controls.Add(addStaffForm);
        }

        private void dashboardForm1_Load(object sender, EventArgs e)
        {

        }

        private void addMoieeForm2_Load(object sender, EventArgs e)
        {

        }
    }
}
