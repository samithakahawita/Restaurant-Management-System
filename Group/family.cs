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
    public partial class family : Form
    {
        public family()
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

        private void button29_Click(object sender, EventArgs e)
        {
            online o = new online();
            o.Show();
            this.Hide();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            signoff m = new signoff();
            m.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                // Change button color to red
                btn.BackColor = Color.Red;

                // Create and show the form
                famst f = new famst();

                // Subscribe to the form's Closed event to reset button color after the form closes
                f.FormClosed += (s, args) =>
                {
                    // Reset button color to default (e.g., Control color)
                    btn.BackColor = SystemColors.Control;
                };

                f.Show();
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            CANCELLBILL c = new CANCELLBILL();
            c.Show();
        }

        private void button46_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                // Change button color to red
                btn.BackColor = Color.Red;

                // Create and show the form
                famst f = new famst();

                // Subscribe to the form's Closed event to reset button color after the form closes
                f.FormClosed += (s, args) =>
                {
                    // Reset button color to default (e.g., Control color)
                    btn.BackColor = SystemColors.Control;
                };

                f.Show();
            }
        }

        private void button31_Click(object sender, EventArgs e)
        {
            createsteward c = new createsteward();
            c.Show();
        }

        private void button30_Click(object sender, EventArgs e)
        {
            attendance attendance = new attendance();
            attendance.Show();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                // Change button color to red
                btn.BackColor = Color.Red;

                // Create and show the form
                famst f = new famst();

                // Subscribe to the form's Closed event to reset button color after the form closes
                f.FormClosed += (s, args) =>
                {
                    // Reset button color to default (e.g., Control color)
                    btn.BackColor = SystemColors.Control;
                };

                f.Show();
            }
        }

        private void family_Load(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                // Change button color to red
                btn.BackColor = Color.Red;

                // Create and show the form
                famst f = new famst();

                // Subscribe to the form's Closed event to reset button color after the form closes
                f.FormClosed += (s, args) =>
                {
                    // Reset button color to default (e.g., Control color)
                    btn.BackColor = SystemColors.Control;
                };

                f.Show();
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                // Change button color to red
                btn.BackColor = Color.Red;

                // Create and show the form
                famst f = new famst();

                // Subscribe to the form's Closed event to reset button color after the form closes
                f.FormClosed += (s, args) =>
                {
                    // Reset button color to default (e.g., Control color)
                    btn.BackColor = SystemColors.Control;
                };

                f.Show();
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                // Change button color to red
                btn.BackColor = Color.Red;

                // Create and show the form
                famst f = new famst();

                // Subscribe to the form's Closed event to reset button color after the form closes
                f.FormClosed += (s, args) =>
                {
                    // Reset button color to default (e.g., Control color)
                    btn.BackColor = SystemColors.Control;
                };

                f.Show();
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                // Change button color to red
                btn.BackColor = Color.Red;

                // Create and show the form
                famst f = new famst();

                // Subscribe to the form's Closed event to reset button color after the form closes
                f.FormClosed += (s, args) =>
                {
                    // Reset button color to default (e.g., Control color)
                    btn.BackColor = SystemColors.Control;
                };

                f.Show();
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                // Change button color to red
                btn.BackColor = Color.Red;

                // Create and show the form
                famst f = new famst();

                // Subscribe to the form's Closed event to reset button color after the form closes
                f.FormClosed += (s, args) =>
                {
                    // Reset button color to default (e.g., Control color)
                    btn.BackColor = SystemColors.Control;
                };

                f.Show();
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                // Change button color to red
                btn.BackColor = Color.Red;

                // Create and show the form
                famst f = new famst();

                // Subscribe to the form's Closed event to reset button color after the form closes
                f.FormClosed += (s, args) =>
                {
                    // Reset button color to default (e.g., Control color)
                    btn.BackColor = SystemColors.Control;
                };

                f.Show();
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                // Change button color to red
                btn.BackColor = Color.Red;

                // Create and show the form
                famst f = new famst();

                // Subscribe to the form's Closed event to reset button color after the form closes
                f.FormClosed += (s, args) =>
                {
                    // Reset button color to default (e.g., Control color)
                    btn.BackColor = SystemColors.Control;
                };

                f.Show();
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                // Change button color to red
                btn.BackColor = Color.Red;

                // Create and show the form
                famst f = new famst();

                // Subscribe to the form's Closed event to reset button color after the form closes
                f.FormClosed += (s, args) =>
                {
                    // Reset button color to default (e.g., Control color)
                    btn.BackColor = SystemColors.Control;
                };

                f.Show();
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                // Change button color to red
                btn.BackColor = Color.Red;

                // Create and show the form
                famst f = new famst();

                // Subscribe to the form's Closed event to reset button color after the form closes
                f.FormClosed += (s, args) =>
                {
                    // Reset button color to default (e.g., Control color)
                    btn.BackColor = SystemColors.Control;
                };

                f.Show();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                // Change button color to red
                btn.BackColor = Color.Red;

                // Create and show the form
                famst f = new famst();

                // Subscribe to the form's Closed event to reset button color after the form closes
                f.FormClosed += (s, args) =>
                {
                    // Reset button color to default (e.g., Control color)
                    btn.BackColor = SystemColors.Control;
                };

                f.Show();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                // Change button color to red
                btn.BackColor = Color.Red;

                // Create and show the form
                famst f = new famst();

                // Subscribe to the form's Closed event to reset button color after the form closes
                f.FormClosed += (s, args) =>
                {
                    // Reset button color to default (e.g., Control color)
                    btn.BackColor = SystemColors.Control;
                };

                f.Show();
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                // Change button color to red
                btn.BackColor = Color.Red;

                // Create and show the form
                famst f = new famst();

                // Subscribe to the form's Closed event to reset button color after the form closes
                f.FormClosed += (s, args) =>
                {
                    // Reset button color to default (e.g., Control color)
                    btn.BackColor = SystemColors.Control;
                };

                f.Show();
            }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                // Change button color to red
                btn.BackColor = Color.Red;

                // Create and show the form
                famst f = new famst();

                // Subscribe to the form's Closed event to reset button color after the form closes
                f.FormClosed += (s, args) =>
                {
                    // Reset button color to default (e.g., Control color)
                    btn.BackColor = SystemColors.Control;
                };

                f.Show();
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                // Change button color to red
                btn.BackColor = Color.Red;

                // Create and show the form
                famst f = new famst();

                // Subscribe to the form's Closed event to reset button color after the form closes
                f.FormClosed += (s, args) =>
                {
                    // Reset button color to default (e.g., Control color)
                    btn.BackColor = SystemColors.Control;
                };

                f.Show();
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                // Change button color to red
                btn.BackColor = Color.Red;

                // Create and show the form
                famst f = new famst();

                // Subscribe to the form's Closed event to reset button color after the form closes
                f.FormClosed += (s, args) =>
                {
                    // Reset button color to default (e.g., Control color)
                    btn.BackColor = SystemColors.Control;
                };

                f.Show();
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                // Change button color to red
                btn.BackColor = Color.Red;

                // Create and show the form
                famst f = new famst();

                // Subscribe to the form's Closed event to reset button color after the form closes
                f.FormClosed += (s, args) =>
                {
                    // Reset button color to default (e.g., Control color)
                    btn.BackColor = SystemColors.Control;
                };

                f.Show();
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                // Change button color to red
                btn.BackColor = Color.Red;

                // Create and show the form
                famst f = new famst();

                // Subscribe to the form's Closed event to reset button color after the form closes
                f.FormClosed += (s, args) =>
                {
                    // Reset button color to default (e.g., Control color)
                    btn.BackColor = SystemColors.Control;
                };

                f.Show();
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                // Change button color to red
                btn.BackColor = Color.Red;

                // Create and show the form
                famst f = new famst();

                // Subscribe to the form's Closed event to reset button color after the form closes
                f.FormClosed += (s, args) =>
                {
                    // Reset button color to default (e.g., Control color)
                    btn.BackColor = SystemColors.Control;
                };

                f.Show();
            }
        }

        private void button27_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                // Change button color to red
                btn.BackColor = Color.Red;

                // Create and show the form
                famst f = new famst();

                // Subscribe to the form's Closed event to reset button color after the form closes
                f.FormClosed += (s, args) =>
                {
                    // Reset button color to default (e.g., Control color)
                    btn.BackColor = SystemColors.Control;
                };

                f.Show();
            }
        }

        private void button45_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                // Change button color to red
                btn.BackColor = Color.Red;

                // Create and show the form
                famst f = new famst();

                // Subscribe to the form's Closed event to reset button color after the form closes
                f.FormClosed += (s, args) =>
                {
                    // Reset button color to default (e.g., Control color)
                    btn.BackColor = SystemColors.Control;
                };

                f.Show();
            }
        }

        private void button49_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                // Change button color to red
                btn.BackColor = Color.Red;

                // Create and show the form
                famst f = new famst();

                // Subscribe to the form's Closed event to reset button color after the form closes
                f.FormClosed += (s, args) =>
                {
                    // Reset button color to default (e.g., Control color)
                    btn.BackColor = SystemColors.Control;
                };

                f.Show();
            }
        }

        private void button44_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                // Change button color to red
                btn.BackColor = Color.Red;

                // Create and show the form
                famst f = new famst();

                // Subscribe to the form's Closed event to reset button color after the form closes
                f.FormClosed += (s, args) =>
                {
                    // Reset button color to default (e.g., Control color)
                    btn.BackColor = SystemColors.Control;
                };

                f.Show();
            }
        }

        private void button43_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                // Change button color to red
                btn.BackColor = Color.Red;

                // Create and show the form
                famst f = new famst();

                // Subscribe to the form's Closed event to reset button color after the form closes
                f.FormClosed += (s, args) =>
                {
                    // Reset button color to default (e.g., Control color)
                    btn.BackColor = SystemColors.Control;
                };

                f.Show();
            }
        }

        private void button48_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                // Change button color to red
                btn.BackColor = Color.Red;

                // Create and show the form
                famst f = new famst();

                // Subscribe to the form's Closed event to reset button color after the form closes
                f.FormClosed += (s, args) =>
                {
                    // Reset button color to default (e.g., Control color)
                    btn.BackColor = SystemColors.Control;
                };

                f.Show();
            }
        }

        private void button32_Click(object sender, EventArgs e)
        {
            signon s = new signon();
            s.Show();
        }

        private void button68_Click(object sender, EventArgs e)
        {
            totalsale s = new totalsale();
            s.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            voiditemsform v = new voiditemsform();
            v.Show();
        }
    }
}
