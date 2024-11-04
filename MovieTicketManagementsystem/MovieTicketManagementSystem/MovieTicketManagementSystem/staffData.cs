using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using WindowsFormsApp.Properties;

namespace MovieTicketManagementSystem
{
    internal class staffData
    {
        string con_str = @"Data Source=CHYY;Initial Catalog=MovieTicketManagementSystem;Integrated Security=True";
        
        public int ID { set; get; }//0
        public string Username { set; get; }//1
        public string Password { set; get; }//2
        public string SDT { set; get; }//3
        public string Email { set; get; }//4
        public string Role { set; get; }//5
        public List<staffData> staffDataListData()
        {
            List<staffData> listData = new List<staffData>(); ;
            using (SqlConnection con = new SqlConnection(con_str))
            {
                con.Open();
                string selectData = "SELECT * FROM users";
                using (SqlCommand cmd = new SqlCommand(selectData, con))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        staffData sData = new staffData();
                        sData.ID = (int)reader[0];
                        sData.Username = reader[1].ToString();
                        sData.Password = reader[2].ToString();
                        sData.SDT = reader[3].ToString();
                        sData.Email = reader[4].ToString();
                        sData.Role = reader[5].ToString();
                        listData.Add(sData);
                    }
                }
            }
            return listData;
        }
       
    }
}


