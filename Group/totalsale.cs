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
    public partial class totalsale : Form
    {
        public totalsale()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void totalsale_Load(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-QG8L2ER\\SQLEXPRESS;Initial Catalog=restuarant;Integrated Security=True";
            string query = "SELECT id, description, quantity, price FROM dailysales";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    // Setup DataGridView
                    dataGridView1.Columns.Clear();
                    dataGridView1.Columns.Add("ID", "ID");
                    dataGridView1.Columns.Add("Description", "Description");
                    dataGridView1.Columns.Add("Quantity", "Quantity");
                    dataGridView1.Columns.Add("Price", "Price");

                    decimal totalSale = 0;

                    while (reader.Read())
                    {
                        // Read values
                        string id = reader["id"].ToString();
                        string description = reader["description"].ToString();
                        int quantity = Convert.ToInt32(reader["quantity"]);
                        decimal price = Convert.ToDecimal(reader["price"]);

                        // Add to DataGridView
                        int rowIndex = dataGridView1.Rows.Add();
                        dataGridView1.Rows[rowIndex].Cells[0].Value = id;
                        dataGridView1.Rows[rowIndex].Cells[1].Value = description;
                        dataGridView1.Rows[rowIndex].Cells[2].Value = quantity;
                        dataGridView1.Rows[rowIndex].Cells[3].Value = price;

                        // Calculate total
                        totalSale += quantity * price;
                    }

                    reader.Close();

                    // Display total in label3
                    label3.Text =  totalSale.ToString("N2");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
