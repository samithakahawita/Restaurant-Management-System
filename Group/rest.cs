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
    public partial class rest : Form
    {
        public rest()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            takeaway m = new takeaway();
            m.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            BAR m = new BAR();
            m.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            family m = new family();
            m.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            online o = new online();
            o.Show();
            this.Hide();
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://localhost/abproject/home.php");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            signoff m = new signoff();  
            m.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            signon s = new signon();
            s.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CANCELLBILL c = new CANCELLBILL();
            c.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            createsteward c = new createsteward();
            c.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            attendance attendance = new attendance();
            attendance.Show();
        }

        private void rest_Load(object sender, EventArgs e)
        {

        }

        private void button68_Click(object sender, EventArgs e)
        {
            totalsale s = new totalsale();
            s.Show();
        }

        private void button31_Click(object sender, EventArgs e)
        {
            CANCELLBILL cANCELLBILL = new CANCELLBILL();
            cANCELLBILL.Show();
        }

        private void button30_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            takeaway takeaway = new takeaway();
            takeaway.Show();
            this.Hide();
        }

        private void button33_Click(object sender, EventArgs e)
        {
            family family = new family();
            family.Show();
            this.Hide();
        }

        private void button29_Click(object sender, EventArgs e)
        {
            BAR bAR = new BAR();
            bAR.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button32_Click(object sender, EventArgs e)
        {
            rest r=new rest();
            r.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            voiditemsform v = new voiditemsform();
            v.Show();
        }
    }
}
