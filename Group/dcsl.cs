using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group
{
   
    public partial class dcsl : Form
    {
        private sharedata _gridManager;
        public dcsl(List<Tuple<string, int, decimal>> items)
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

        
        private void panel4_Paint(object sender, PaintEventArgs e)
        {
           
        }
        private int quantityCount = 0;
        private decimal basePrice = 280;
        private int exquantityCount = 0;
        private decimal exPrice = 4200;
        private int ex375quantityCount = 0;
        private decimal ex375basePrice = 2100;


        private void button10_Click(object sender, EventArgs e)
        {
            bool itemFound = false;

            // Check if the item exists in the table
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["Description"].Value != null &&
                    row.Cells["Description"].Value.ToString() == "EX SPECIAL 50ML")
                {
                    // Increase the quantity
                    int currentQty = Convert.ToInt32(row.Cells["Qty"].Value);
                    row.Cells["Qty"].Value = currentQty + 1;

                    // Update the total price for this row
                    row.Cells["Price"].Value = (currentQty + 1) * 280;

                    itemFound = true;
                    break;
                }
            }

            // If the item doesn't exist, add it
            if (!itemFound)
            {
                dataGridView1.Rows.Add("EX SPECIAL 50ML", 1, 280);
            }

            // Optionally, update the total price for the entire table
            UpdateTotal();
            

        }

        private void UpdateTotal()
        {
            decimal total = 0; // Total for all items
            decimal netTotal = 0; // Net total excluding removed items

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

            // Update labels for total and net total
            sub.Text = "Rs " + total.ToString("N");
            net.Text = "Rs " + netTotal.ToString("N");
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            // Setup DataGridView columns
            
        }



        private void LoadDcslData(string selectQuery)
        {

            
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            bool itemFound = false;

            // Check if the item exists in the table
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["Description"].Value != null &&
                    row.Cells["Description"].Value.ToString() == "EX SPECIAL 750ML")
                {
                    // Increase the quantity
                    int currentQty = Convert.ToInt32(row.Cells["Qty"].Value);
                    row.Cells["Qty"].Value = currentQty + 1;

                    // Update the total price for this row
                    row.Cells["Price"].Value = (currentQty + 1) * 4200;

                    itemFound = true;
                    break;
                }
            }

            // If the item doesn't exist, add it
            if (!itemFound)
            {
                dataGridView1.Rows.Add("EX SPECIAL 750ML", 1, 4200);
            }

            // Optionally, update the total price for the entire table
            UpdateTotal();
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

        private void button12_Click(object sender, EventArgs e)
        {
            bool itemFound = false;

            // Check if the item exists in the table
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["Description"].Value != null &&
                    row.Cells["Description"].Value.ToString() == "EX SPECIAL 375ML")
                {
                    // Increase the quantity
                    int currentQty = Convert.ToInt32(row.Cells["Qty"].Value);
                    row.Cells["Qty"].Value = currentQty + 1;

                    // Update the total price for this row
                    row.Cells["Price"].Value = (currentQty + 1) * 2100;

                    itemFound = true;
                    break;
                }
            }

            // If the item doesn't exist, add it
            if (!itemFound)
            {
                dataGridView1.Rows.Add("EX SPECIAL 375ML", 1, 2100);
            }

            // Optionally, update the total price for the entire table
            UpdateTotal();
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {

        }

      

       
      
        private string connectionString = "Data Source=DESKTOP-QG8L2ER\\SQLEXPRESS;Initial Catalog=restuarant;Integrated Security=True";
        

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                decimal totalSelectedPrice = 0;

                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    if (row.Cells["price"] != null && row.Cells["price"].Value != null)
                    {
                        totalSelectedPrice += Convert.ToDecimal(row.Cells["price"].Value);
                    }
                    else
                    {
                        MessageBox.Show("Price column is empty or invalid!");
                    }
                }

                dataGridView3.Rows.Clear();
                dataGridView3.Columns.Clear();
                dataGridView3.Columns.Add("Description", "Description");
                dataGridView3.Columns.Add("Total Price", "Total Price");
                dataGridView3.Rows.Add("Selected Items", totalSelectedPrice);

                MessageBox.Show($"Total price of selected items: {totalSelectedPrice}", "Total Price", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button11_Click(object sender, EventArgs e)
        {
            bool itemFound = false;

            // Check if the item exists in the table
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["Description"].Value != null &&
                    row.Cells["Description"].Value.ToString() == "EX SPECIAL 180ML")
                {
                    // Increase the quantity
                    int currentQty = Convert.ToInt32(row.Cells["Qty"].Value);
                    row.Cells["Qty"].Value = currentQty + 1;

                    // Update the total price for this row
                    row.Cells["Price"].Value = (currentQty + 1) * 1050;

                    itemFound = true;
                    break;
                }
            }

            // If the item doesn't exist, add it
            if (!itemFound)
            {
                dataGridView1.Rows.Add("EX SPECIAL 180ML", 1, 1050);
            }

            // Optionally, update the total price for the entire table
            UpdateTotal();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            bool itemFound = false;

            // Check if the item exists in the table
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["Description"].Value != null &&
                    row.Cells["Description"].Value.ToString() == "White Label 50ML")
                {
                    // Increase the quantity
                    int currentQty = Convert.ToInt32(row.Cells["Qty"].Value);
                    row.Cells["Qty"].Value = currentQty + 1;

                    // Update the total price for this row
                    row.Cells["Price"].Value = (currentQty + 1) * 295;

                    itemFound = true;
                    break;
                }
            }

            // If the item doesn't exist, add it
            if (!itemFound)
            {
                dataGridView1.Rows.Add("White Label 50ML", 1, 295);
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
                    row.Cells["Description"].Value.ToString() == "White Label 750ML")
                {
                    // Increase the quantity
                    int currentQty = Convert.ToInt32(row.Cells["Qty"].Value);
                    row.Cells["Qty"].Value = currentQty + 1;

                    // Update the total price for this row
                    row.Cells["Price"].Value = (currentQty + 1) * 4400;

                    itemFound = true;
                    break;
                }
            }

            // If the item doesn't exist, add it
            if (!itemFound)
            {
                dataGridView1.Rows.Add("White Label 750ML", 1, 4400);
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
                    row.Cells["Description"].Value.ToString() == "White Label 375ML")
                {
                    // Increase the quantity
                    int currentQty = Convert.ToInt32(row.Cells["Qty"].Value);
                    row.Cells["Qty"].Value = currentQty + 1;

                    // Update the total price for this row
                    row.Cells["Price"].Value = (currentQty + 1) * 2200;

                    itemFound = true;
                    break;
                }
            }

            // If the item doesn't exist, add it
            if (!itemFound)
            {
                dataGridView1.Rows.Add("White Label 375ML", 1, 2200);
            }

            // Optionally, update the total price for the entire table
            UpdateTotal();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            bool itemFound = false;

            // Check if the item exists in the table
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["Description"].Value != null &&
                    row.Cells["Description"].Value.ToString() == "White Label 180ML")
                {
                    // Increase the quantity
                    int currentQty = Convert.ToInt32(row.Cells["Qty"].Value);
                    row.Cells["Qty"].Value = currentQty + 1;

                    // Update the total price for this row
                    row.Cells["Price"].Value = (currentQty + 1) * 1100;

                    itemFound = true;
                    break;
                }
            }

            // If the item doesn't exist, add it
            if (!itemFound)
            {
                dataGridView1.Rows.Add("White Label 180ML", 1, 1100);
            }

            // Optionally, update the total price for the entire table
            UpdateTotal();
        }

        private void button29_Click(object sender, EventArgs e)
        {
            bool itemFound = false;

            // Check if the item exists in the table
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["Description"].Value != null &&
                    row.Cells["Description"].Value.ToString() == "Old Arrack 50ML")
                {
                    // Increase the quantity
                    int currentQty = Convert.ToInt32(row.Cells["Qty"].Value);
                    row.Cells["Qty"].Value = currentQty + 1;

                    // Update the total price for this row
                    row.Cells["Price"].Value = (currentQty + 1) * 320;

                    itemFound = true;
                    break;
                }
            }

            // If the item doesn't exist, add it
            if (!itemFound)
            {
                dataGridView1.Rows.Add("Old Arrack 50ML", 1, 320);
            }

            // Optionally, update the total price for the entire table
            UpdateTotal();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            bool itemFound = false;

            // Check if the item exists in the table
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["Description"].Value != null &&
                    row.Cells["Description"].Value.ToString() == "Old Arrack 750ML")
                {
                    // Increase the quantity
                    int currentQty = Convert.ToInt32(row.Cells["Qty"].Value);
                    row.Cells["Qty"].Value = currentQty + 1;

                    // Update the total price for this row
                    row.Cells["Price"].Value = (currentQty + 1) * 4800;

                    itemFound = true;
                    break;
                }
            }

            // If the item doesn't exist, add it
            if (!itemFound)
            {
                dataGridView1.Rows.Add("Old Arrack 750ML", 1, 4800);
            }

            // Optionally, update the total price for the entire table
            UpdateTotal();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            bool itemFound = false;

            // Check if the item exists in the table
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["Description"].Value != null &&
                    row.Cells["Description"].Value.ToString() == "Old Arrack 375ML")
                {
                    // Increase the quantity
                    int currentQty = Convert.ToInt32(row.Cells["Qty"].Value);
                    row.Cells["Qty"].Value = currentQty + 1;

                    // Update the total price for this row
                    row.Cells["Price"].Value = (currentQty + 1) * 2400;

                    itemFound = true;
                    break;
                }
            }

            // If the item doesn't exist, add it
            if (!itemFound)
            {
                dataGridView1.Rows.Add("Old Arrack 375ML", 1, 2400);
            }

            // Optionally, update the total price for the entire table
            UpdateTotal();
        }

        private void button28_Click(object sender, EventArgs e)
        {
            bool itemFound = false;

            // Check if the item exists in the table
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["Description"].Value != null &&
                    row.Cells["Description"].Value.ToString() == "Old Arrack 180ML")
                {
                    // Increase the quantity
                    int currentQty = Convert.ToInt32(row.Cells["Qty"].Value);
                    row.Cells["Qty"].Value = currentQty + 1;

                    // Update the total price for this row
                    row.Cells["Price"].Value = (currentQty + 1) * 1200;

                    itemFound = true;
                    break;
                }
            }

            // If the item doesn't exist, add it
            if (!itemFound)
            {
                dataGridView1.Rows.Add("Old Arrack 180ML", 1, 1200);
            }

            // Optionally, update the total price for the entire table
            UpdateTotal();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            bool itemFound = false;

            // Check if the item exists in the table
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["Description"].Value != null &&
                    row.Cells["Description"].Value.ToString() == "Black Opal 50ML")
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
                dataGridView1.Rows.Add("Black Opal 50ML", 1, 300);
            }

            // Optionally, update the total price for the entire table
            UpdateTotal();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            bool itemFound = false;

            // Check if the item exists in the table
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["Description"].Value != null &&
                    row.Cells["Description"].Value.ToString() == "Black Opal 750ML")
                {
                    // Increase the quantity
                    int currentQty = Convert.ToInt32(row.Cells["Qty"].Value);
                    row.Cells["Qty"].Value = currentQty + 1;

                    // Update the total price for this row
                    row.Cells["Price"].Value = (currentQty + 1) * 4500;

                    itemFound = true;
                    break;
                }
            }

            // If the item doesn't exist, add it
            if (!itemFound)
            {
                dataGridView1.Rows.Add("Black Opal 750ML", 1, 4500);
            }

            // Optionally, update the total price for the entire table
            UpdateTotal();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            bool itemFound = false;

            // Check if the item exists in the table
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["Description"].Value != null &&
                    row.Cells["Description"].Value.ToString() == "Black Opal 375ML")
                {
                    // Increase the quantity
                    int currentQty = Convert.ToInt32(row.Cells["Qty"].Value);
                    row.Cells["Qty"].Value = currentQty + 1;

                    // Update the total price for this row
                    row.Cells["Price"].Value = (currentQty + 1) * 2250;

                    itemFound = true;
                    break;
                }
            }

            // If the item doesn't exist, add it
            if (!itemFound)
            {
                dataGridView1.Rows.Add("Black Opal 375ML", 1, 2250);
            }

            // Optionally, update the total price for the entire table
            UpdateTotal();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            bool itemFound = false;

            // Check if the item exists in the table
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["Description"].Value != null &&
                    row.Cells["Description"].Value.ToString() == "Black Opal 180ML")
                {
                    // Increase the quantity
                    int currentQty = Convert.ToInt32(row.Cells["Qty"].Value);
                    row.Cells["Qty"].Value = currentQty + 1;

                    // Update the total price for this row
                    row.Cells["Price"].Value = (currentQty + 1) * 1125;

                    itemFound = true;
                    break;
                }
            }

            // If the item doesn't exist, add it
            if (!itemFound)
            {
                dataGridView1.Rows.Add("Black Opal 180ML", 1, 1125);
            }

            // Optionally, update the total price for the entire table
            UpdateTotal();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            bool itemFound = false;

            // Check if the item exists in the table
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["Description"].Value != null &&
                    row.Cells["Description"].Value.ToString() == "Gallery Brandy 50ML")
                {
                    // Increase the quantity
                    int currentQty = Convert.ToInt32(row.Cells["Qty"].Value);
                    row.Cells["Qty"].Value = currentQty + 1;

                    // Update the total price for this row
                    row.Cells["Price"].Value = (currentQty + 1) * 415;

                    itemFound = true;
                    break;
                }
            }

            // If the item doesn't exist, add it
            if (!itemFound)
            {
                dataGridView1.Rows.Add("Gallery Brandy 50ML", 1, 415);
            }

            // Optionally, update the total price for the entire table
            UpdateTotal();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            bool itemFound = false;

            // Check if the item exists in the table
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["Description"].Value != null &&
                    row.Cells["Description"].Value.ToString() == "Gallery Brandy 750ML")
                {
                    // Increase the quantity
                    int currentQty = Convert.ToInt32(row.Cells["Qty"].Value);
                    row.Cells["Qty"].Value = currentQty + 1;

                    // Update the total price for this row
                    row.Cells["Price"].Value = (currentQty + 1) * 6200;

                    itemFound = true;
                    break;
                }
            }

            // If the item doesn't exist, add it
            if (!itemFound)
            {
                dataGridView1.Rows.Add("Gallery Brandy 750ML", 1, 6200);
            }

            // Optionally, update the total price for the entire table
            UpdateTotal();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            bool itemFound = false;

            // Check if the item exists in the table
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["Description"].Value != null &&
                    row.Cells["Description"].Value.ToString() == "Gallery Brandy 375ML")
                {
                    // Increase the quantity
                    int currentQty = Convert.ToInt32(row.Cells["Qty"].Value);
                    row.Cells["Qty"].Value = currentQty + 1;

                    // Update the total price for this row
                    row.Cells["Price"].Value = (currentQty + 1) * 3100;

                    itemFound = true;
                    break;
                }
            }

            // If the item doesn't exist, add it
            if (!itemFound)
            {
                dataGridView1.Rows.Add("Gallery Brandy 375ML", 1, 3100);
            }

            // Optionally, update the total price for the entire table
            UpdateTotal();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            bool itemFound = false;

            // Check if the item exists in the table
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["Description"].Value != null &&
                    row.Cells["Description"].Value.ToString() == "Gallery Brandy 180ML")
                {
                    // Increase the quantity
                    int currentQty = Convert.ToInt32(row.Cells["Qty"].Value);
                    row.Cells["Qty"].Value = currentQty + 1;

                    // Update the total price for this row
                    row.Cells["Price"].Value = (currentQty + 1) * 1550;

                    itemFound = true;
                    break;
                }
            }

            // If the item doesn't exist, add it
            if (!itemFound)
            {
                dataGridView1.Rows.Add("Gallery Brandy 180ML", 1, 1550);
            }

            // Optionally, update the total price for the entire table
            UpdateTotal();
        }

        private void button41_Click(object sender, EventArgs e)
        {
            bool itemFound = false;

            // Check if the item exists in the table
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["Description"].Value != null &&
                    row.Cells["Description"].Value.ToString() == "Strong Beer")
                {
                    // Increase the quantity
                    int currentQty = Convert.ToInt32(row.Cells["Qty"].Value);
                    row.Cells["Qty"].Value = currentQty + 1;

                    // Update the total price for this row
                    row.Cells["Price"].Value = (currentQty + 1) * 800;

                    itemFound = true;
                    break;
                }
            }

            // If the item doesn't exist, add it
            if (!itemFound)
            {
                dataGridView1.Rows.Add("Strong Beer", 1, 800);
            }

            // Optionally, update the total price for the entire table
            UpdateTotal();
        }

        private void button38_Click(object sender, EventArgs e)
        {
            bool itemFound = false;

            // Check if the item exists in the table
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["Description"].Value != null &&
                    row.Cells["Description"].Value.ToString() == "Stout Beer")
                {
                    // Increase the quantity
                    int currentQty = Convert.ToInt32(row.Cells["Qty"].Value);
                    row.Cells["Qty"].Value = currentQty + 1;

                    // Update the total price for this row
                    row.Cells["Price"].Value = (currentQty + 1) * 880;

                    itemFound = true;
                    break;
                }
            }

            // If the item doesn't exist, add it
            if (!itemFound)
            {
                dataGridView1.Rows.Add("Stout Beer", 1, 880);
            }

            // Optionally, update the total price for the entire table
            UpdateTotal();
        }

        private void button39_Click(object sender, EventArgs e)
        {
            bool itemFound = false;

            // Check if the item exists in the table
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["Description"].Value != null &&
                    row.Cells["Description"].Value.ToString() == "Empty 750")
                {
                    // Increase the quantity
                    int currentQty = Convert.ToInt32(row.Cells["Qty"].Value);
                    row.Cells["Qty"].Value = currentQty + 1;

                    // Update the total price for this row
                    row.Cells["Price"].Value = (currentQty + 1) * 100;

                    itemFound = true;
                    break;
                }
            }

            // If the item doesn't exist, add it
            if (!itemFound)
            {
                dataGridView1.Rows.Add("Empty 750", 1, 100);
            }

            // Optionally, update the total price for the entire table
            UpdateTotal();
        }

        private void button40_Click(object sender, EventArgs e)
        {
            bool itemFound = false;

            // Check if the item exists in the table
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["Description"].Value != null &&
                    row.Cells["Description"].Value.ToString() == "Empty 375")
                {
                    // Increase the quantity
                    int currentQty = Convert.ToInt32(row.Cells["Qty"].Value);
                    row.Cells["Qty"].Value = currentQty + 1;

                    // Update the total price for this row
                    row.Cells["Price"].Value = (currentQty + 1) * 70;

                    itemFound = true;
                    break;
                }
            }

            // If the item doesn't exist, add it
            if (!itemFound)
            {
                dataGridView1.Rows.Add("Empty 375", 1, 70);
            }

            // Optionally, update the total price for the entire table
            UpdateTotal();
        }

        private void button37_Click(object sender, EventArgs e)
        {
            bool itemFound = false;

            // Check if the item exists in the table
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["Description"].Value != null &&
                    row.Cells["Description"].Value.ToString() == "Empty 180")
                {
                    // Increase the quantity
                    int currentQty = Convert.ToInt32(row.Cells["Qty"].Value);
                    row.Cells["Qty"].Value = currentQty + 1;

                    // Update the total price for this row
                    row.Cells["Price"].Value = (currentQty + 1) * 50;

                    itemFound = true;
                    break;
                }
            }

            // If the item doesn't exist, add it
            if (!itemFound)
            {
                dataGridView1.Rows.Add("Empty 180", 1, 50);
            }

            // Optionally, update the total price for the entire table
            UpdateTotal();
        }

        private void button30_Click(object sender, EventArgs e)
        {
            bool itemFound = false;

            // Check if the item exists in the table
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["Description"].Value != null &&
                    row.Cells["Description"].Value.ToString() == "Beer Empty")
                {
                    // Increase the quantity
                    int currentQty = Convert.ToInt32(row.Cells["Qty"].Value);
                    row.Cells["Qty"].Value = currentQty + 1;

                    // Update the total price for this row
                    row.Cells["Price"].Value = (currentQty + 1) * 100;

                    itemFound = true;
                    break;
                }
            }

            // If the item doesn't exist, add it
            if (!itemFound)
            {
                dataGridView1.Rows.Add("Beer Empty", 1, 100);
            }

            // Optionally, update the total price for the entire table
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

            // Close or hide the table (optional, but does not remove rows)
    
        }

        private voidclass manager = new voidclass();
        private void button1_Click(object sender, EventArgs e)
        {
            Group.voidclass vc = new Group.voidclass();
            vc.ConfirmAndVoidItems(dataGridView1);

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
                stb s = new stb(itemList);
                s.Show();
                this.Hide();
            }
            UpdateTotal();
        }

        private void dcsl_Load(object sender, EventArgs e)
        {
            

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    
}
