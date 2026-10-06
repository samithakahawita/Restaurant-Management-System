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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Group
{
    public partial class signon : Form
    {
        public signon()
        {
            InitializeComponent();
            this.Load += signon_Load;

        }

        private void signon_Load(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "Data Source=DESKTOP-QG8L2ER\\SQLEXPRESS;Initial Catalog=restuarant;Integrated Security=True";
                string query = "SELECT username FROM login WHERE id = 1"; // Make sure this user exists

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        string user = reader["username"].ToString();
                        textBox1.Text = user; // Make sure your textbox is named "textBox1"
                    }
                    else
                    {
                        MessageBox.Show("No user found with id = 1");
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            try
            {
                string connectionString = "Data Source=DESKTOP-QG8L2ER\\SQLEXPRESS;Initial Catalog=restuarant;Integrated Security=True";
                string query = "SELECT SUM(price) AS TotalSale FROM senditem";  // Replace 'price' if your column is named differently

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();

                    object result = command.ExecuteScalar();  // returns first column of first row

                    if (result != DBNull.Value)
                    {
                        textBox3.Text = result.ToString();  // Replace totalSaleTextBox with your actual TextBox name
                    }
                    else
                    {
                        textBox3.Text = "0";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading total sale: " + ex.Message);
            }
        }
    }
}
