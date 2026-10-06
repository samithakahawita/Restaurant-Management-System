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
    public partial class items : Form
    {
        private PrintDocument printDocument = new PrintDocument();
        private string billText = "=== BILL RECEIPT ===\n\nItem A - $10\nItem B - $15\n\nTotal: $25";
        private bool isBillPrinted = false;
        public items(List<Tuple<string, int, decimal>> items)
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
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
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
            sptakeaway s = new sptakeaway(itemList);
            s.Show();
            this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

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
            paybill payForm = new paybill(totalAmount, this);
            payForm.Show();
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

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
