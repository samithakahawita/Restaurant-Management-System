using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group
{
    public partial class sptakeaway : Form
    {
        private PrintDocument printDocument = new PrintDocument();
        private string billText = "=== BILL RECEIPT ===\n\nItem A - $10\nItem B - $15\n\nTotal: $25";
        private bool isBillPrinted = false;
        public sptakeaway(List<Tuple<string, int, decimal>> items)
        {
            InitializeComponent();
            printDocument.PrintPage += new PrintPageEventHandler(PrintPageHandler);
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
        private void PrintPageHandler(object sender, PrintPageEventArgs e)
        {
            Font printFont = new Font("Arial", 12);
            float leftMargin = e.MarginBounds.Left;
            float topMargin = e.MarginBounds.Top;

            e.Graphics.DrawString(billText, printFont, Brushes.Black, leftMargin, topMargin);
            e.HasMorePages = false;
        }
        private void button16_Click(object sender, EventArgs e)
        {
            bool itemFound = false;

            // Check if the item exists in the table
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["Description"].Value != null &&
                    row.Cells["Description"].Value.ToString() == "chicken rice normal")
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
                dataGridView1.Rows.Add("chicken rice normal", 1, 800);
            }

            // Optionally, update the total price for the entire table
            UpdateTotal();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            bool itemFound = false;

            // Check if the item exists in the table
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["Description"].Value != null &&
                    row.Cells["Description"].Value.ToString() == "chicken devilled")
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
                dataGridView1.Rows.Add("chicken devilled", 1, 800);
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
            sub.Text = total.ToString("N");
            net.Text = netTotal.ToString("N");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            bool itemFound = false;

            // Check if the item exists in the table
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["Description"].Value != null &&
                    row.Cells["Description"].Value.ToString() == "fried chicken")
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
                dataGridView1.Rows.Add("fried chicken", 1, 700);
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
                    row.Cells["Description"].Value.ToString() == "hot butter chicken")
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
                dataGridView1.Rows.Add("hot butter chicken", 1, 850);
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
                    row.Cells["Description"].Value.ToString() == "fried garlic")
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
                dataGridView1.Rows.Add("fried garlic", 1, 400);
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
                    row.Cells["Description"].Value.ToString() == "french fries")
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
                dataGridView1.Rows.Add("french fries", 1, 420);
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
                    row.Cells["Description"].Value.ToString() == "fish and chips")
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
                dataGridView1.Rows.Add("fish and chips", 1, 1500);
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
                    row.Cells["Description"].Value.ToString() == "hot butter cuttlefish")
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
                dataGridView1.Rows.Add("hot butter cuttlefish", 1, 900);
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
                    row.Cells["Description"].Value.ToString() == "chicken rice large")
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
                dataGridView1.Rows.Add("chicken rice large", 1, 1200);
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
                    row.Cells["Description"].Value.ToString() == "seafood rice normal")
                {
                    // Increase the quantity
                    int currentQty = Convert.ToInt32(row.Cells["Qty"].Value);
                    row.Cells["Qty"].Value = currentQty + 1;

                    // Update the total price for this row
                    row.Cells["Price"].Value = (currentQty + 1) * 1000;

                    itemFound = true;
                    break;
                }
            }

            // If the item doesn't exist, add it
            if (!itemFound)
            {
                dataGridView1.Rows.Add("seafood rice normal", 1, 1000);
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
                    row.Cells["Description"].Value.ToString() == "seafood rice large")
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
                dataGridView1.Rows.Add("seafood rice large", 1, 1500);
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
                    row.Cells["Description"].Value.ToString() == "mixed rice normal")
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
                dataGridView1.Rows.Add("mixed rice normal", 1, 1200);
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
                    row.Cells["Description"].Value.ToString() == "mixed rice large")
                {
                    // Increase the quantity
                    int currentQty = Convert.ToInt32(row.Cells["Qty"].Value);
                    row.Cells["Qty"].Value = currentQty + 1;

                    // Update the total price for this row
                    row.Cells["Price"].Value = (currentQty + 1) * 1700;

                    itemFound = true;
                    break;
                }
            }

            // If the item doesn't exist, add it
            if (!itemFound)
            {
                dataGridView1.Rows.Add("mixed rice large", 1, 1700);
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
                    row.Cells["Description"].Value.ToString() == "pork stew")
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
                dataGridView1.Rows.Add("pork stew", 1, 850);
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
                    row.Cells["Description"].Value.ToString() == "beef devilled")
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
                dataGridView1.Rows.Add("beef devilled", 1, 920);
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
                    row.Cells["Description"].Value.ToString() == "beef stew")
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
                dataGridView1.Rows.Add("beef stew", 1, 950);
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
                    row.Cells["Description"].Value.ToString() == "pork devilled")
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
                dataGridView1.Rows.Add("pork devilled", 1, 900);
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
                    row.Cells["Description"].Value.ToString() == "mixed chopsy with rice")
                {
                    // Increase the quantity
                    int currentQty = Convert.ToInt32(row.Cells["Qty"].Value);
                    row.Cells["Qty"].Value = currentQty + 1;

                    // Update the total price for this row
                    row.Cells["Price"].Value = (currentQty + 1) * 2000;

                    itemFound = true;
                    break;
                }
            }

            // If the item doesn't exist, add it
            if (!itemFound)
            {
                dataGridView1.Rows.Add("mixed chopsy with rice", 1, 2000);
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
                    row.Cells["Description"].Value.ToString() == "seafood chopsy with rice")
                {
                    // Increase the quantity
                    int currentQty = Convert.ToInt32(row.Cells["Qty"].Value);
                    row.Cells["Qty"].Value = currentQty + 1;

                    // Update the total price for this row
                    row.Cells["Price"].Value = (currentQty + 1) * 1900;

                    itemFound = true;
                    break;
                }
            }

            // If the item doesn't exist, add it
            if (!itemFound)
            {
                dataGridView1.Rows.Add("seafood chopsy with rice", 1, 1900);
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
                    row.Cells["Description"].Value.ToString() == "chicken kottu normal")
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
                dataGridView1.Rows.Add("chicken kottu normal", 1, 700);
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
                    row.Cells["Description"].Value.ToString() == "chicken kottu large")
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
                dataGridView1.Rows.Add("chicken kottu large", 1, 1200);
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
                    row.Cells["Description"].Value.ToString() == "cheese kottu normal")
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
                dataGridView1.Rows.Add("cheese kottu normal", 1, 750);
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
                    row.Cells["Description"].Value.ToString() == "cheese kottu large")
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
                dataGridView1.Rows.Add("cheese kottu large", 1, 1200);
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
                    row.Cells["Description"].Value.ToString() == "chicken noodles normal")
                {
                    // Increase the quantity
                    int currentQty = Convert.ToInt32(row.Cells["Qty"].Value);
                    row.Cells["Qty"].Value = currentQty + 1;

                    // Update the total price for this row
                    row.Cells["Price"].Value = (currentQty + 1) * 650;

                    itemFound = true;
                    break;
                }
            }

            // If the item doesn't exist, add it
            if (!itemFound)
            {
                dataGridView1.Rows.Add("chicken noodles normal", 1, 650);
            }

            // Optionally, update the total price for the entire table
            UpdateTotal();
        }

        private void button33_Click(object sender, EventArgs e)
        {
            bool itemFound = false;

            // Check if the item exists in the table
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["Description"].Value != null &&
                    row.Cells["Description"].Value.ToString() == "chicken noodle large")
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
                dataGridView1.Rows.Add("chicken noodles large", 1, 1100);
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
                    row.Cells["Description"].Value.ToString() == "seafood noodles normal")
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
                dataGridView1.Rows.Add("chicken noodles normal", 1, 850);
            }

            // Optionally, update the total price for the entire table
            UpdateTotal();
        }

        private void button31_Click(object sender, EventArgs e)
        {
            bool itemFound = false;

            // Check if the item exists in the table
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["Description"].Value != null &&
                    row.Cells["Description"].Value.ToString() == "seafood noodles large")
                {
                    // Increase the quantity
                    int currentQty = Convert.ToInt32(row.Cells["Qty"].Value);
                    row.Cells["Qty"].Value = currentQty + 1;

                    // Update the total price for this row
                    row.Cells["Price"].Value = (currentQty + 1) * 1250;

                    itemFound = true;
                    break;
                }
            }

            // If the item doesn't exist, add it
            if (!itemFound)
            {
                dataGridView1.Rows.Add("seafood noodles large", 1, 1250);
            }

            // Optionally, update the total price for the entire table
            UpdateTotal();
        }

        private void button32_Click(object sender, EventArgs e)
        {
            bool itemFound = false;

            // Check if the item exists in the table
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["Description"].Value != null &&
                    row.Cells["Description"].Value.ToString() == "nasigurang rice")
                {
                    // Increase the quantity
                    int currentQty = Convert.ToInt32(row.Cells["Qty"].Value);
                    row.Cells["Qty"].Value = currentQty + 1;

                    // Update the total price for this row
                    row.Cells["Price"].Value = (currentQty + 1) * 1280;

                    itemFound = true;
                    break;
                }
            }

            // If the item doesn't exist, add it
            if (!itemFound)
            {
                dataGridView1.Rows.Add("nasigurang rice", 1, 1280);
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
                    row.Cells["Description"].Value.ToString() == "mixed noodle normal")
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
                dataGridView1.Rows.Add("mixed noodles normal", 1, 900);
            }

            // Optionally, update the total price for the entire table
            UpdateTotal();
        }

        private void button34_Click(object sender, EventArgs e)
        {
            bool itemFound = false;

            // Check if the item exists in the table
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["Description"].Value != null &&
                    row.Cells["Description"].Value.ToString() == "mixed noodle large")
                {
                    // Increase the quantity
                    int currentQty = Convert.ToInt32(row.Cells["Qty"].Value);
                    row.Cells["Qty"].Value = currentQty + 1;

                    // Update the total price for this row
                    row.Cells["Price"].Value = (currentQty + 1) * 1300;

                    itemFound = true;
                    break;
                }
            }

            // If the item doesn't exist, add it
            if (!itemFound)
            {
                dataGridView1.Rows.Add("mixed noodles large", 1, 1300);
            }

            // Optionally, update the total price for the entire table
            UpdateTotal();
        }

        private void button35_Click(object sender, EventArgs e)
        {
            bool itemFound = false;

            // Check if the item exists in the table
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["Description"].Value != null &&
                    row.Cells["Description"].Value.ToString() == "colselaw salad")
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
                dataGridView1.Rows.Add("colselaw salad", 1, 300);
            }

            // Optionally, update the total price for the entire table
            UpdateTotal();
        }

        private void button36_Click(object sender, EventArgs e)
        {
            bool itemFound = false;

            // Check if the item exists in the table
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["Description"].Value != null &&
                    row.Cells["Description"].Value.ToString() == "green salad")
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
                dataGridView1.Rows.Add("green salad", 1, 300);
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
                items i = new items(itemList);
                i.Show();
                this.Hide();
            }
            UpdateTotal();
        }

        private void button42_Click(object sender, EventArgs e)
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
                sptakeaway2 s = new sptakeaway2(itemList);
                s.Show();
                this.Hide();
            }
            UpdateTotal();
        }

        private void sptakeaway_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to print this bill?", "Print Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                PrintBill();
            }
        }
        private void PrintBill()
        {
            try
            {
                printDocument.Print();
                isBillPrinted = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Printing failed: " + ex.Message, "Print Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (!isBillPrinted)
            {
                MessageBox.Show("Please print the bill first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Parse the total amount from a label (e.g., labelTotal)
            decimal totalAmount = decimal.Parse(net.Text);

            // Pass the value to the paybill form
            paybill payForm = new paybill(totalAmount, this);
            payForm.Show();
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

        private void button4_Click(object sender, EventArgs e)
        {
            ccamount c = new ccamount();
            c.Show();
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
