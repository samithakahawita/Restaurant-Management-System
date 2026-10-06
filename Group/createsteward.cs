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
using System.Xml.Linq;

namespace Group
{
    public partial class createsteward : Form
    {
        public createsteward()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-QG8L2ER\\SQLEXPRESS;Initial Catalog=restuarant;Integrated Security=True";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("INSERT INTO samithatb ( username, password) VALUES ( @Username, @Password)", con))
                    {
                       
                        cmd.Parameters.AddWithValue("@Username", stname.Text);
                        cmd.Parameters.AddWithValue("@Password", stp.Text); // Corrected parameter name

                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Data inserted successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

        }

        private void createsteward_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            stid.Clear();
            stname.Clear();
            stp.Clear();
            stpp.Clear();
        }
    }
}
