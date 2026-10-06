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
    public partial class soup : Form
    {
        public soup(List<Tuple<string, int, decimal>> items)
        {
            InitializeComponent();
            if (dataGridView1.Columns.Count == 0)
            {
                dataGridView1.Columns.Add("Description", "Description");
                dataGridView1.Columns.Add("Qty", "Qty");
                dataGridView1.Columns.Add("Price", "Price");
            }

            decimal totalPrice = 0;

            foreach (var item in items)
            {
                dataGridView1.Rows.Add(item.Item1, item.Item2, item.Item3);
                totalPrice += item.Item3; // Sum up the prices
            }

            // Display total price in a label
            net.Text = totalPrice.ToString("N");
            sub.Text = totalPrice.ToString("N");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            bool itemFound = false;

            // Check if the item exists in the table
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["Description"].Value != null &&
                    row.Cells["Description"].Value.ToString() == "VEGETABLE SOUP")
                {
                    // Increase the quantity
                    int currentQty = Convert.ToInt32(row.Cells["Qty"].Value);
                    row.Cells["Qty"].Value = currentQty + 1;

                    // Update the total price for this row
                    row.Cells["Price"].Value = (currentQty + 1) * 300;

                    itemFound = true;
                    break;
                }
            }

            // If the item doesn't exist, add it
            if (!itemFound)
            {
                dataGridView1.Rows.Add("VEGETABLE", 1, 300);
            }

            // Optionally, update the total price for the entire table
            UpdateTotal();
        }
        private void UpdateTotal()
        {
            decimal total = 0; // Total for all items
            decimal netTotal = 0; // Net total excluding removed items
            decimal serviceCharge = 0; // 10% service charge

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["Price"].Value != null)
                {
                    try
                    {
                        // Parse the price value
                        decimal price = Convert.ToDecimal(row.Cells["Price"].Value);

                        // Add to total for all items
                        total += price;

                        // Check if the row is marked as removed
                        if (row.DefaultCellStyle.BackColor != Color.Red) // Exclude removed items
                        {
                            netTotal += price;
                        }
                    }
                    catch (FormatException)
                    {
                        // Handle invalid price value
                        MessageBox.Show("Invalid value detected in the Price column.");
                    }
                }
            }

            // Calculate 10% service charge on net total
            serviceCharge = netTotal * 0.10m;
            decimal finalTotal = netTotal + serviceCharge;

            // Update labels for total, net total, and service charge
            sub.Text = total.ToString("N");
            net.Text = netTotal.ToString("N");
            label8.Text = serviceCharge.ToString("N"); // Ensure you have a label for this
            net.Text = finalTotal.ToString("N"); // Ensure you have a label for this
        }

        private void button13_Click(object sender, EventArgs e)
        {
            bool itemFound = false;

            // Check if the item exists in the table
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["Description"].Value != null &&
                    row.Cells["Description"].Value.ToString() == "CREAM OF CHICKEN SOUP")
                {
                    // Increase the quantity
                    int currentQty = Convert.ToInt32(row.Cells["Qty"].Value);
                    row.Cells["Qty"].Value = currentQty + 1;

                    // Update the total price for this row
                    row.Cells["Price"].Value = (currentQty + 1) * 500;

                    itemFound = true;
                    break;
                }
            }

            // If the item doesn't exist, add it
            if (!itemFound)
            {
                dataGridView1.Rows.Add("CREAM OF CHICKEN SOUP", 1, 500);
            }

            // Optionally, update the total price for the entire table
            UpdateTotal();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            bool itemFound = false;

            // Check if the item exists in the table
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["Description"].Value != null &&
                    row.Cells["Description"].Value.ToString() == "TOM YAM SOUP")
                {
                    // Increase the quantity
                    int currentQty = Convert.ToInt32(row.Cells["Qty"].Value);
                    row.Cells["Qty"].Value = currentQty + 1;

                    // Update the total price for this row
                    row.Cells["Price"].Value = (currentQty + 1) * 400;

                    itemFound = true;
                    break;
                }
            }

            // If the item doesn't exist, add it
            if (!itemFound)
            {
                dataGridView1.Rows.Add("TOM YAM SOUP", 1, 400);
            }

            // Optionally, update the total price for the entire table
            UpdateTotal();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            bool itemFound = false;

            // Check if the item exists in the table
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["Description"].Value != null &&
                    row.Cells["Description"].Value.ToString() == "CHICKEN NOODLES SOUP")
                {
                    // Increase the quantity
                    int currentQty = Convert.ToInt32(row.Cells["Qty"].Value);
                    row.Cells["Qty"].Value = currentQty + 1;

                    // Update the total price for this row
                    row.Cells["Price"].Value = (currentQty + 1) * 440;

                    itemFound = true;
                    break;
                }
            }

            // If the item doesn't exist, add it
            if (!itemFound)
            {
                dataGridView1.Rows.Add("CHICKEN NOODLES SOUP", 1, 440);
            }

            // Optionally, update the total price for the entire table
            UpdateTotal();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            bool itemFound = false;

            // Check if the item exists in the table
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["Description"].Value != null &&
                    row.Cells["Description"].Value.ToString() == "FRENCH ONION  SOUP")
                {
                    // Increase the quantity
                    int currentQty = Convert.ToInt32(row.Cells["Qty"].Value);
                    row.Cells["Qty"].Value = currentQty + 1;

                    // Update the total price for this row
                    row.Cells["Price"].Value = (currentQty + 1) * 420;

                    itemFound = true;
                    break;
                }
            }

            // If the item doesn't exist, add it
            if (!itemFound)
            {
                dataGridView1.Rows.Add("FRENCH ONION SOUP", 1, 420);
            }

            // Optionally, update the total price for the entire table
            UpdateTotal();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            bool itemFound = false;

            // Check if the item exists in the table
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["Description"].Value != null &&
                    row.Cells["Description"].Value.ToString() == "BEEF BOTH SOUP")
                {
                    // Increase the quantity
                    int currentQty = Convert.ToInt32(row.Cells["Qty"].Value);
                    row.Cells["Qty"].Value = currentQty + 1;

                    // Update the total price for this row
                    row.Cells["Price"].Value = (currentQty + 1) * 550;

                    itemFound = true;
                    break;
                }
            }

            // If the item doesn't exist, add it
            if (!itemFound)
            {
                dataGridView1.Rows.Add("BEEF BOTH SOUP", 1, 550);
            }

            // Optionally, update the total price for the entire table
            UpdateTotal();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            List<Tuple<string, int, decimal>> itemList = new List<Tuple<string, int, decimal>>();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["Description"].Value != null &&
                    row.Cells["Qty"].Value != null &&
                    row.Cells["Price"].Value != null)
                {
                    try
                    {
                        string description = row.Cells["Description"].Value.ToString();
                        int quantity = Convert.ToInt32(row.Cells["Qty"].Value);
                        decimal price = Convert.ToDecimal(row.Cells["Price"].Value);

                        byte[] descriptionBinary = System.Text.Encoding.UTF8.GetBytes(description);

                        using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-QG8L2ER\\SQLEXPRESS;Initial Catalog=restuarant;Integrated Security=True"))
                        {
                            string query = "INSERT INTO category (dscription, qty, price) VALUES (@Description, @Qty, @Price)";
                            using (SqlCommand cmd = new SqlCommand(query, conn))
                            {
                                cmd.Parameters.AddWithValue("@Description", descriptionBinary);
                                cmd.Parameters.AddWithValue("@Qty", quantity);
                                cmd.Parameters.AddWithValue("@Price", price);

                                conn.Open();
                                cmd.ExecuteNonQuery();
                            }
                        }

                        row.DefaultCellStyle.BackColor = System.Drawing.Color.LightGreen;

                        // Add to list for stb
                        itemList.Add(new Tuple<string, int, decimal>(description, quantity, price));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }

            }

            // Open stb form with all data
            if (itemList.Count > 0)
            {
                familytable2 s = new familytable2(itemList);
                s.Show();
                this.Hide();
            }
            UpdateTotal();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["Description"].Value != null &&
                    row.Cells["Qty"].Value != null &&
                    row.Cells["Price"].Value != null)
                {
                    try
                    {
                        // Retrieve data from the row
                        string description = row.Cells["Description"].Value.ToString();
                        int quantity = Convert.ToInt32(row.Cells["Qty"].Value);
                        decimal price = Convert.ToDecimal(row.Cells["Price"].Value);

                        // Convert the description to binary (if necessary)
                        byte[] descriptionBinary = System.Text.Encoding.UTF8.GetBytes(description);

                        // Insert data into the database
                        using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-QG8L2ER\\SQLEXPRESS;Initial Catalog=restuarant;Integrated Security=True"))
                        {
                            string query = "INSERT INTO senditem (description, quantity, price) VALUES (@Description, @Qty, @Price)";
                            SqlCommand cmd = new SqlCommand(query, conn);
                            cmd.Parameters.AddWithValue("@Description", descriptionBinary);
                            cmd.Parameters.AddWithValue("@Qty", quantity);
                            cmd.Parameters.AddWithValue("@Price", price);

                            conn.Open();
                            cmd.ExecuteNonQuery();
                            conn.Close();
                        }

                        // Change row color to indicate it has been processed
                        row.DefaultCellStyle.BackColor = Color.LightGreen;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            for (int i = dataGridView1.SelectedRows.Count - 1; i >= 0; i--)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[i];

                // Check if the row is not marked as sent (e.g., by its color or a flag)
                if (selectedRow.DefaultCellStyle.BackColor != Color.LightGreen) // LightGreen indicates a sent item
                {
                    if (!selectedRow.IsNewRow) // Ensure not to remove the "new row" placeholder
                    {
                        dataGridView1.Rows.Remove(selectedRow); // Remove only non-sent items
                    }
                }
                else
                {
                    // Optionally, show a message that sent items cannot be removed
                    MessageBox.Show("Sent items cannot be removed.");
                }
            }
            UpdateTotal();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Group.voidclass vc = new Group.voidclass();
            vc.ConfirmAndVoidItems(dataGridView1);
            UpdateTotal();
        }
    }
}
