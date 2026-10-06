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
    public partial class card : Form
    {
        private decimal totalAmount;
        public card(decimal totalAmount)
        {
            InitializeComponent();
            this.totalAmount = totalAmount;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ccamount c=new ccamount();
            c.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ccamount c = new ccamount();
            c.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ccamount c = new ccamount();
            c.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {

            paybill main = new paybill(totalAmount, this);
            main.Show();
            this.Hide();
        }

        private void card_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://localhost/abproject/card.php");
        }
    }
}
