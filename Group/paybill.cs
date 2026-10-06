using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group
{
    public partial class paybill : Form
    {
        private Form mainForm;
        public paybill(decimal totalAmount, Form mainForm)
        {
            InitializeComponent();
            total.Text = totalAmount.ToString("N");
            UpdateBalance();
            this.mainForm = mainForm;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            double incrementValue = 1.0; // Change this value as needed
            double currentCash = double.Parse(cash.Text);
            currentCash += incrementValue;
            cash.Text = currentCash.ToString("0.00");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            double incrementValue = 5.0; // Change this value as needed
            double currentCash = double.Parse(cash.Text);
            currentCash += incrementValue;
            cash.Text = currentCash.ToString("0.00");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            double incrementValue = 10.0; // Change this value as needed
            double currentCash = double.Parse(cash.Text);
            currentCash += incrementValue;
            cash.Text = currentCash.ToString("0.00");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            double incrementValue = 20.0; // Change this value as needed
            double currentCash = double.Parse(cash.Text);
            currentCash += incrementValue;
            cash.Text = currentCash.ToString("0.00");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double incrementValue = 50.0; // Change this value as needed
            double currentCash = double.Parse(cash.Text);
            currentCash += incrementValue;
            cash.Text = currentCash.ToString("0.00");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            double incrementValue = 100.0; // Change this value as needed
            double currentCash = double.Parse(cash.Text);
            currentCash += incrementValue;
            cash.Text = currentCash.ToString("0.00");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double incrementValue = 500.0; // Change this value as needed
            double currentCash = double.Parse(cash.Text);
            currentCash += incrementValue;
            cash.Text = currentCash.ToString("0.00");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            double incrementValue = 1000.0; // Change this value as needed
            double currentCash = double.Parse(cash.Text);
            currentCash += incrementValue;
            cash.Text = currentCash.ToString("0.00");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            double incrementValue = 2000.0; // Change this value as needed
            double currentCash = double.Parse(cash.Text);
            currentCash += incrementValue;
            cash.Text = currentCash.ToString("0.00");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double incrementValue = 5000.0; // Change this value as needed
            double currentCash = double.Parse(cash.Text);
            currentCash += incrementValue;
            cash.Text = currentCash.ToString("0.00");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            cash.Text = "";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void total_Click(object sender, EventArgs e)
        {
            
        }

        private void paybill_Load(object sender, EventArgs e)
        {
           
        }
        private void UpdateBalance()
        {
            decimal cashAmount = decimal.Parse(cash.Text); // Cash entered by user
            decimal totalAmount = decimal.Parse(total.Text); // Total price of items
            decimal balance = cashAmount - totalAmount; // Calculate balance

            balaces.Text= balance.ToString("N"); // Update balance label
        }

        private void balaces_Click(object sender, EventArgs e)
        {
            UpdateBalance();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            decimal totalAmount = decimal.Parse(total.Text); // Get total amount from PayBill form
            card c = new card(totalAmount); // Pass totalAmount to the card constructor
            c.Show(); // Show the card form
            this.Hide();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            ccamount ccamount = new ccamount();
            ccamount.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Do you want to finalize the bill?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Finalize logic here (e.g. save payment, print receipt, etc.)

                // Close this (PayBill) form
                this.Close();

                // Close the main order form
                if (mainForm != null)
                {
                    mainForm.Close();
                }
            }
        }
    }
}
