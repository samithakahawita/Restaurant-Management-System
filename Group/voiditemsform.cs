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
    public partial class voiditemsform : Form
    {
        public voiditemsform()
        {
            InitializeComponent();
        }

        private void voiditemsform_Load(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-QG8L2ER\\SQLEXPRESS;Initial Catalog=restuarant;Integrated Security=True";
            string query = "SELECT id, description, quantity, price FROM voiditems";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    // Ensure the DataGridView has columns before adding rows
                    dataGridView1.Columns.Clear();
                    dataGridView1.Columns.Add("ID", "ID");
                    dataGridView1.Columns.Add("Description", "Description");
                    dataGridView1.Columns.Add("Quantity", "Quantity");
                    dataGridView1.Columns.Add("Price", "Price");

                    // Add data column by column
                    while (reader.Read())
                    {
                        int rowIndex = dataGridView1.Rows.Add();
                        dataGridView1.Rows[rowIndex].Cells[0].Value = reader["id"].ToString();
                        dataGridView1.Rows[rowIndex].Cells[1].Value = reader["description"].ToString();
                        dataGridView1.Rows[rowIndex].Cells[2].Value = reader["quantity"].ToString();
                        dataGridView1.Rows[rowIndex].Cells[3].Value = reader["price"].ToString();
                    }

                    reader.Close();
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
