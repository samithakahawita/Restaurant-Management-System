using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group
{
    public partial class ccamount : Form
    {
        public TextBox total;
        public ccamount()
        {
            InitializeComponent();
            
        }
         // or Label cash;


        private void button6_Click(object sender, EventArgs e)
        {

            if (decimal.TryParse(textBox1.Text, out decimal amountValue))
            {
                // Pass the amount to the paybill form
                paybill paybillForm = new paybill(amountValue, this);

                // Show the paybill form
                paybillForm.Show();
            }
            else
            {
                MessageBox.Show("Please enter a valid amount.");
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += button1.Text;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text += button15.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += button3.Text;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text += button14.Text;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text += button12.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += button2.Text;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text += button13.Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += button11.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += button10.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += button4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += button5.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += button8.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void ccamount_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
