using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group
{
    internal class voidclass
    {

        private string connectionString = @"Data Source=DESKTOP-QG8L2ER\SQLEXPRESS;Initial Catalog=restuarant;Integrated Security=True";

        public void ConfirmAndVoidItems(DataGridView dataGridView)
        {
            var confirmation = MessageBox.Show("Are you sure you want to void the selected items?", "Confirm Void", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmation != DialogResult.Yes) return;

            using (voiditems loginForm = new voiditems())
            {
                if (loginForm.ShowDialog() == DialogResult.OK)
                {
                    if (!IsValidUser(loginForm.EnteredUsername, loginForm.EnteredPassword))
                    {
                        MessageBox.Show("Invalid username or password. Void operation canceled.");
                        return;
                    }
                }
                else
                {
                    return;
                }
            }

            MoveLightGreenRowsToVoidTable(dataGridView);
        }

        private bool IsValidUser(string username, string password)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM voidpassword WHERE username = @Username AND password = @Password";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password); // Note: use hashing in production

                conn.Open();
                int count = (int)cmd.ExecuteScalar();
                conn.Close();

                return count > 0;
            }
        }

        private void MoveLightGreenRowsToVoidTable(DataGridView dataGridView)
        {
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (row.DefaultCellStyle.BackColor == Color.LightGreen)
                {
                    try
                    {
                        if (row.Cells["Description"].Value == null || row.Cells["Qty"].Value == null || row.Cells["Price"].Value == null)
                        {
                            throw new Exception("Row contains null values. Please check the data.");
                        }

                        string description = row.Cells["Description"].Value.ToString();
                        int quantity = Convert.ToInt32(row.Cells["Qty"].Value);
                        decimal price = Convert.ToDecimal(row.Cells["Price"].Value);

                        byte[] descriptionBinary = Encoding.UTF8.GetBytes(description);

                        using (SqlConnection conn = new SqlConnection(connectionString))
                        {
                            string query = "INSERT INTO voiditems (description, quantity, price) VALUES (@Description, @Qty, @Price)";
                            SqlCommand cmd = new SqlCommand(query, conn);
                            cmd.Parameters.AddWithValue("@Description", descriptionBinary);
                            cmd.Parameters.AddWithValue("@Qty", quantity);
                            cmd.Parameters.AddWithValue("@Price", price);

                            conn.Open();
                            cmd.ExecuteNonQuery();
                            conn.Close();
                        }

                        dataGridView.Rows.Remove(row);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }

            MessageBox.Show("Selected items have been moved to the voiditems table.");
        }
    }
}
