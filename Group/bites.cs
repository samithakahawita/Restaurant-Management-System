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
    public partial class bites : Form
    {
        public bites(List<Tuple<string, int, decimal>> items)
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
                    row.Cells["Description"].Value.ToString() == "CHICKEN DEVILLED")
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
                dataGridView1.Rows.Add("CHICKEN DEVILLED", 1, 800);
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
            sub.Text =  total.ToString("N");
            net.Text =  netTotal.ToString("N");
            label8.Text =serviceCharge.ToString("N"); // Ensure you have a label for this
            net.Text =  finalTotal.ToString("N"); // Ensure you have a label for this
        }

        private void button13_Click(object sender, EventArgs e)
        {
            bool itemFound = false;

            // Check if the item exists in the table
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["Description"].Value != null &&
                    row.Cells["Description"].Value.ToString() == "FRIED CHICKEN")
                {
                    // Increase the quantity
                    int currentQty = Convert.ToInt32(row.Cells["Qty"].Value);
                    row.Cells["Qty"].Value = currentQty + 1;

                    // Update the total price for this row
                    row.Cells["Price"].Value = (currentQty + 1) * 700;

                    itemFound = true;
                    break;
                }
            }

            // If the item doesn't exist, add it
            if (!itemFound)
            {
                dataGridView1.Rows.Add("FRIED CHICKEN", 1, 700);
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
                    row.Cells["Description"].Value.ToString() == "HOT BUTTER CHICKEN")
                {
                    // Increase the quantity
                    int currentQty = Convert.ToInt32(row.Cells["Qty"].Value);
                    row.Cells["Qty"].Value = currentQty + 1;

                    // Update the total price for this row
                    row.Cells["Price"].Value = (currentQty + 1) * 850;

                    itemFound = true;
                    break;
                }
            }

            // If the item doesn't exist, add it
            if (!itemFound)
            {
                dataGridView1.Rows.Add("HOT BUTTER CHICKEN", 1, 850);
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
                    row.Cells["Description"].Value.ToString() == "FRIED GARLIC")
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
                dataGridView1.Rows.Add("FRIED GARLIC", 1, 400);
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
                    row.Cells["Description"].Value.ToString() == "FRENCH FRIES")
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
                dataGridView1.Rows.Add("FRENCH FRIES", 1, 420);
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
                    row.Cells["Description"].Value.ToString() == "FISH AND CHIPS")
                {
                    // Increase the quantity
                    int currentQty = Convert.ToInt32(row.Cells["Qty"].Value);
                    row.Cells["Qty"].Value = currentQty + 1;

                    // Update the total price for this row
                    row.Cells["Price"].Value = (currentQty + 1) * 1500;

                    itemFound = true;
                    break;
                }
            }

            // If the item doesn't exist, add it
            if (!itemFound)
            {
                dataGridView1.Rows.Add("FISH AND CHIPS", 1, 1500);
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
                    row.Cells["Description"].Value.ToString() == "HOT BUTTER CUTTLE FISH")
                {
                    // Increase the quantity
                    int currentQty = Convert.ToInt32(row.Cells["Qty"].Value);
                    row.Cells["Qty"].Value = currentQty + 1;

                    // Update the total price for this row
                    row.Cells["Price"].Value = (currentQty + 1) * 900;

                    itemFound = true;
                    break;
                }
            }

            // If the item doesn't exist, add it
            if (!itemFound)
            {
                dataGridView1.Rows.Add("HOT BUTTER CUTTLE FISH", 1, 900);
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
                    row.Cells["Description"].Value.ToString() == "CHICKEN RICE")
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
                dataGridView1.Rows.Add("CHICKEN RICE", 1, 800);
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
                    row.Cells["Description"].Value.ToString() == "FRUIT PLATTER")
                {
                    // Increase the quantity
                    int currentQty = Convert.ToInt32(row.Cells["Qty"].Value);
                    row.Cells["Qty"].Value = currentQty + 1;

                    // Update the total price for this row
                    row.Cells["Price"].Value = (currentQty + 1) * 700;

                    itemFound = true;
                    break;
                }
            }

            // If the item doesn't exist, add it
            if (!itemFound)
            {
                dataGridView1.Rows.Add("FRUIT PLATTER", 1, 700);
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
                    row.Cells["Description"].Value.ToString() == "CHICKEN LEG")
                {
                    // Increase the quantity
                    int currentQty = Convert.ToInt32(row.Cells["Qty"].Value);
                    row.Cells["Qty"].Value = currentQty + 1;

                    // Update the total price for this row
                    row.Cells["Price"].Value = (currentQty + 1) * 380;

                    itemFound = true;
                    break;
                }
            }

            // If the item doesn't exist, add it
            if (!itemFound)
            {
                dataGridView1.Rows.Add("CHICKEN LEG", 1, 380);
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
                    row.Cells["Description"].Value.ToString() == "PORK SLICE")
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
                dataGridView1.Rows.Add("PORK SLICE", 1, 300);
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
                    row.Cells["Description"].Value.ToString() == "BEEF SLICE")
                {
                    // Increase the quantity
                    int currentQty = Convert.ToInt32(row.Cells["Qty"].Value);
                    row.Cells["Qty"].Value = currentQty + 1;

                    // Update the total price for this row
                    row.Cells["Price"].Value = (currentQty + 1) * 350;

                    itemFound = true;
                    break;
                }
            }

            // If the item doesn't exist, add it
            if (!itemFound)
            {
                dataGridView1.Rows.Add("BEEF SLICE", 1, 350);
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
                    row.Cells["Description"].Value.ToString() == "PORK DEVILLED")
                {
                    // Increase the quantity
                    int currentQty = Convert.ToInt32(row.Cells["Qty"].Value);
                    row.Cells["Qty"].Value = currentQty + 1;

                    // Update the total price for this row
                    row.Cells["Price"].Value = (currentQty + 1) * 820;

                    itemFound = true;
                    break;
                }
            }

            // If the item doesn't exist, add it
            if (!itemFound)
            {
                dataGridView1.Rows.Add("PORK DEVILLED", 1, 820);
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
                    row.Cells["Description"].Value.ToString() == "PORK STEW")
                {
                    // Increase the quantity
                    int currentQty = Convert.ToInt32(row.Cells["Qty"].Value);
                    row.Cells["Qty"].Value = currentQty + 1;

                    // Update the total price for this row
                    row.Cells["Price"].Value = (currentQty + 1) * 850;

                    itemFound = true;
                    break;
                }
            }

            // If the item doesn't exist, add it
            if (!itemFound)
            {
                dataGridView1.Rows.Add("PORK STEW", 1, 850);
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
                    row.Cells["Description"].Value.ToString() == "BEEF DEVILLED")
                {
                    // Increase the quantity
                    int currentQty = Convert.ToInt32(row.Cells["Qty"].Value);
                    row.Cells["Qty"].Value = currentQty + 1;

                    // Update the total price for this row
                    row.Cells["Price"].Value = (currentQty + 1) * 920;

                    itemFound = true;
                    break;
                }
            }

            // If the item doesn't exist, add it
            if (!itemFound)
            {
                dataGridView1.Rows.Add("BEEF DEVILLED", 1, 920);
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
                    row.Cells["Description"].Value.ToString() == "BEEF STEW")
                {
                    // Increase the quantity
                    int currentQty = Convert.ToInt32(row.Cells["Qty"].Value);
                    row.Cells["Qty"].Value = currentQty + 1;

                    // Update the total price for this row
                    row.Cells["Price"].Value = (currentQty + 1) * 950;

                    itemFound = true;
                    break;
                }
            }

            // If the item doesn't exist, add it
            if (!itemFound)
            {
                dataGridView1.Rows.Add("BEEF STEW", 1, 950);
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
                    row.Cells["Description"].Value.ToString() == "CHICKEN WINGS")
                {
                    // Increase the quantity
                    int currentQty = Convert.ToInt32(row.Cells["Qty"].Value);
                    row.Cells["Qty"].Value = currentQty + 1;

                    // Update the total price for this row
                    row.Cells["Price"].Value = (currentQty + 1) * 180;

                    itemFound = true;
                    break;
                }
            }

            // If the item doesn't exist, add it
            if (!itemFound)
            {
                dataGridView1.Rows.Add("CHICKEN WINGS", 1, 180);
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
                    row.Cells["Description"].Value.ToString() == "APPLE PLATE")
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
                dataGridView1.Rows.Add("APPLE PLATE", 1, 400);
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
                    row.Cells["Description"].Value.ToString() == "SAUSAGE")
                {
                    // Increase the quantity
                    int currentQty = Convert.ToInt32(row.Cells["Qty"].Value);
                    row.Cells["Qty"].Value = currentQty + 1;

                    // Update the total price for this row
                    row.Cells["Price"].Value = (currentQty + 1) * 180;

                    itemFound = true;
                    break;
                }
            }

            // If the item doesn't exist, add it
            if (!itemFound)
            {
                dataGridView1.Rows.Add("SAUSAGE", 1, 180);
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
                    row.Cells["Description"].Value.ToString() == "SAUSAGE DEVILLED")
                {
                    // Increase the quantity
                    int currentQty = Convert.ToInt32(row.Cells["Qty"].Value);
                    row.Cells["Qty"].Value = currentQty + 1;

                    // Update the total price for this row
                    row.Cells["Price"].Value = (currentQty + 1) * 700;

                    itemFound = true;
                    break;
                }
            }

            // If the item doesn't exist, add it
            if (!itemFound)
            {
                dataGridView1.Rows.Add("SAUSAGE DEVILLED", 1, 700);
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
                    row.Cells["Description"].Value.ToString() == "CHEESE CRACKER")
                {
                    // Increase the quantity
                    int currentQty = Convert.ToInt32(row.Cells["Qty"].Value);
                    row.Cells["Qty"].Value = currentQty + 1;

                    // Update the total price for this row
                    row.Cells["Price"].Value = (currentQty + 1) * 200;

                    itemFound = true;
                    break;
                }
            }

            // If the item doesn't exist, add it
            if (!itemFound)
            {
                dataGridView1.Rows.Add("CHEESE CRACKER", 1, 200);
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
                    row.Cells["Description"].Value.ToString() == "PRAWNS DEVILLED")
                {
                    // Increase the quantity
                    int currentQty = Convert.ToInt32(row.Cells["Qty"].Value);
                    row.Cells["Qty"].Value = currentQty + 1;

                    // Update the total price for this row
                    row.Cells["Price"].Value = (currentQty + 1) * 750;

                    itemFound = true;
                    break;
                }
            }

            // If the item doesn't exist, add it
            if (!itemFound)
            {
                dataGridView1.Rows.Add("PRAWNS DEVILLED", 1, 750);
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
                    row.Cells["Description"].Value.ToString() == "CASHEW NUT PACK")
                {
                    // Increase the quantity
                    int currentQty = Convert.ToInt32(row.Cells["Qty"].Value);
                    row.Cells["Qty"].Value = currentQty + 1;

                    // Update the total price for this row
                    row.Cells["Price"].Value = (currentQty + 1) * 200;

                    itemFound = true;
                    break;
                }
            }

            // If the item doesn't exist, add it
            if (!itemFound)
            {
                dataGridView1.Rows.Add("CASHEW NUT PACK", 1, 200);
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
                    row.Cells["Description"].Value.ToString() == "FRIED CASHEW")
                {
                    // Increase the quantity
                    int currentQty = Convert.ToInt32(row.Cells["Qty"].Value);
                    row.Cells["Qty"].Value = currentQty + 1;

                    // Update the total price for this row
                    row.Cells["Price"].Value = (currentQty + 1) * 900;

                    itemFound = true;
                    break;
                }
            }

            // If the item doesn't exist, add it
            if (!itemFound)
            {
                dataGridView1.Rows.Add("FRIED CASHEW", 1, 900);
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
                stb s = new stb(itemList);
                s.Show();
                this.Hide();
            }
            UpdateTotal();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

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
    }
}
