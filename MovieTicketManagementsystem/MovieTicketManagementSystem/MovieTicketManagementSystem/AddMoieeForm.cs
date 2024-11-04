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
    public partial class AddMoieeForm : UserControl
    {
        string con_str = @"Data Source=CHYY;Initial Catalog=MovieTicketManagementSystem;Integrated Security=True";

        public AddMoieeForm()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void addMovie_Btn_Click(object sender, EventArgs e)
        {

        }
        private void addMovie_importBtn_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog file = new OpenFileDialog();
                string imagePath = "";
                file.Filter = "Image Files(*.jpg; *png)|*.jpg;*.png";
                if (file.ShowDialog() == DialogResult.OK)
                {
                    imagePath = file.FileName;
                    pictureBox1.ImageLocation = imagePath;

                }

            }
            catch (Exception ex) {
                
                    MessageBox.Show($"Error: {ex}", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
        }
    }
