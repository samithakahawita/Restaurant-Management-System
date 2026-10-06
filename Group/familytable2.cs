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
    public partial class familytable2 : Form
    {
        private PrintDocument printDocument = new PrintDocument();
        private string billText = "=== BILL RECEIPT ===\n\nItem A - $10\nItem B - $15\n\nTotal: $25";
        private bool isBillPrinted = false;
        public familytable2(List<Tuple<string, int, decimal>> items)
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

            // Populate the DataGridView and calculate total price
            foreach (var item in items)
            {
                dataGridView1.Rows.Add(item.Item1, item.Item2, item.Item3);
                totalPrice += item.Item3;
            }

            // Apply 10% service charge
            decimal serviceCharge = totalPrice * 0.10m;
            decimal finalTotal = totalPrice + serviceCharge;

            // Update labels with calculated values
            sub.Text = totalPrice.ToString("N");
            net.Text = finalTotal.ToString("N");
            label8.Text = serviceCharge.ToString("N");
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
        private void PrintPageHandler(object sender, PrintPageEventArgs e)
        {
            Font printFont = new Font("Arial", 12);
            float leftMargin = e.MarginBounds.Left;
            float topMargin = e.MarginBounds.Top;

            e.Graphics.DrawString(billText, printFont, Brushes.Black, leftMargin, topMargin);
            e.HasMorePages = false;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
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

                        itemList.Add(new Tuple<string, int, decimal>(description, quantity, price));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }

            // Pass itemList to dcsl constructor
            prawns d = new prawns(itemList);
            d.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
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

                        itemList.Add(new Tuple<string, int, decimal>(description, quantity, price));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }

            // Pass itemList to dcsl constructor
            soup d = new soup(itemList);
            d.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
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

                        itemList.Add(new Tuple<string, int, decimal>(description, quantity, price));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }

            // Pass itemList to dcsl constructor
            setmenu d = new setmenu(itemList);
            d.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
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

                        itemList.Add(new Tuple<string, int, decimal>(description, quantity, price));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }

            // Pass itemList to dcsl constructor
            freshjuice d = new freshjuice(itemList);
            d.Show();
            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
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

                        itemList.Add(new Tuple<string, int, decimal>(description, quantity, price));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }

            // Pass itemList to dcsl constructor
            dessert d = new dessert(itemList);
            d.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
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

                        itemList.Add(new Tuple<string, int, decimal>(description, quantity, price));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }

            // Pass itemList to dcsl constructor
            softdrinks d = new softdrinks(itemList);
            d.Show();
            this.Hide();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
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

                        itemList.Add(new Tuple<string, int, decimal>(description, quantity, price));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }

            // Pass itemList to dcsl constructor
            bakery d = new bakery(itemList);
            d.Show();
            this.Hide();
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

                        itemList.Add(new Tuple<string, int, decimal>(description, quantity, price));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }

            // Pass itemList to dcsl constructor
            familytable d = new familytable(itemList);
            d.Show();
            this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

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
            paybill payForm = new paybill(totalAmount,this);
            payForm.Show();
        }

        private void familytable2_Load(object sender, EventArgs e)
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

        private void button4_Click(object sender, EventArgs e)
        {
            ccamount c = new ccamount();
            c.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
