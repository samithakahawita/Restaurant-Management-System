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

namespace Group
{
    public partial class signoff : Form
    {
        public signoff()
        {
            InitializeComponent();
            this.Load += signoff_Load;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void signoff_Load(object sender, EventArgs e)
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

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "Data Source=DESKTOP-QG8L2ER\\SQLEXPRESS;Initial Catalog=restuarant;Integrated Security=True";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // 1. Copy all data from senditem to dailysale
                    string insertQuery = @"
                INSERT INTO dailysales (description, quantity, price)
                SELECT description, quantity, price FROM senditem";

                    using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
                    {
                        insertCommand.ExecuteNonQuery();
                    }

                    // 2. Delete all data from senditem
                    string deleteQuery = "DELETE FROM senditem";

                    using (SqlCommand deleteCommand = new SqlCommand(deleteQuery, connection))
                    {
                        deleteCommand.ExecuteNonQuery();
                    }

                    MessageBox.Show("Items moved to dailysale and senditem cleared successfully.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
