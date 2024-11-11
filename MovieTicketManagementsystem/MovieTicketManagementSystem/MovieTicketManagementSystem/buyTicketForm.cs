using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MovieTicketManagementSystem
{
    public partial class buyTicketForm : UserControl
    {
        string con_str = @"Data Source=CHYY;Initial Catalog=MovieTicketManagementSystem;Integrated Security=True";

        public buyTicketForm()
        {
            InitializeComponent();
            displayAvailableMovie();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void displayAvailableMovie()
        {
            movieData mData = new movieData();
            List<movieData> listData = mData.movieAvailableisData();

            dataGridView1.DataSource = listData;

        }
        private int id = 0;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
              
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                id = (int)row.Cells[0].Value;
                buyTicket_moiveID .Text = row.Cells[1].Value.ToString();
                buyTicket_movieName.Text = row.Cells[2].Value.ToString();
                buyTicket_genre.Text = row.Cells[3].Value.ToString();
                buyTicket_regularPrice.Text = row.Cells[4].Value.ToString();

                pictureBox1.ImageLocation = row.Cells[7].Value.ToString();
            }
        }
    }
}
