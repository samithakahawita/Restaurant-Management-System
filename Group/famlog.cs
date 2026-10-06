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
    public partial class famlog : Form
    {
        string input = string.Empty;
        TextBox activeTextBox;
        public famlog()
        {
            InitializeComponent();
            foreach (Control c in this.Controls)
            {
                if (c is Button btn && btn.Tag != null && c.Tag.ToString() == "keyboard")
                {
                    btn.Click += KeyboardButton_Click;
                }
            }

            activeTextBox = usernametxt;

            usernametxt.Enter += (s, e) => { input = usernametxt.Text; activeTextBox = usernametxt; };
            passwordtxt.Enter += (s, e) => { input = passwordtxt.Text; activeTextBox = passwordtxt; };

            usernametxt.KeyDown += Username_KeyDown;
        }

        private void button39_Click(object sender, EventArgs e)
        {
            string username = usernametxt.Text.Trim();
            string password = passwordtxt.Text.Trim();

            // Basic validation
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }

            // Use using statement for proper resource disposal
            using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-QG8L2ER\SQLEXPRESS;Initial Catalog=restuarant;Integrated Security=True"))
            {
                string query = "SELECT COUNT(*) FROM samithatb WHERE username = @username AND password = @password";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    try
                    {
                        con.Open();
                        int count = (int)cmd.ExecuteScalar();

                        if (count > 0)
                        {
                            // If login successful, just open stb form (you may later pass real values here)
                            familytable m = new familytable(new List<Tuple<string, int, decimal>>()); // Empty list for now
                            m.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Invalid Username or Password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void Username_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                passwordtxt.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }


        private void KeyboardButton_Click(object sender, EventArgs e)
        {
            if (sender is Button btn && activeTextBox != null)
            {
                input += btn.Text;
                activeTextBox.Text = input;
                activeTextBox.SelectionStart = activeTextBox.Text.Length;
            }
        }
        private void famlog_Load(object sender, EventArgs e)
        {

        }

        private void button37_Click(object sender, EventArgs e)
        {
            usernametxt.Clear();
            passwordtxt.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            input += "1";
            activeTextBox.Text = input;
        }

        private void usernametxt_TextChanged(object sender, EventArgs e)
        {
            activeTextBox = usernametxt;
        }

        private void passwordtxt_TextChanged(object sender, EventArgs e)
        {
            activeTextBox = passwordtxt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            input += "2";
            activeTextBox.Text = input;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            input += "3";
            activeTextBox.Text = input;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            input += "4";
            activeTextBox.Text = input;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            input += "5";
            activeTextBox.Text = input;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            input += "6";
            activeTextBox.Text = input;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            input += "7";
            activeTextBox.Text = input;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            input += "8";
            activeTextBox.Text = input;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            input += "9";
            activeTextBox.Text = input;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            input += "0";
            activeTextBox.Text = input;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            input += "q";
            activeTextBox.Text = input;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            input += "w";
            activeTextBox.Text = input;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            input += "e";
            activeTextBox.Text = input;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            input += "r";
            activeTextBox.Text = input;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            input += "t";
            activeTextBox.Text = input;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            input += "y";
            activeTextBox.Text = input;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            input += "u";
            activeTextBox.Text = input;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            input += "i";
            activeTextBox.Text = input;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            input += "o";
            activeTextBox.Text = input;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            input += "p";
            activeTextBox.Text = input;
        }

        private void button30_Click(object sender, EventArgs e)
        {
            input += "a";
            activeTextBox.Text = input;
        }

        private void button29_Click(object sender, EventArgs e)
        {
            input += "s";
            activeTextBox.Text = input;
        }

        private void button27_Click(object sender, EventArgs e)
        {
            input += "d";
            activeTextBox.Text = input;
        }

        private void button28_Click(object sender, EventArgs e)
        {
            input += "f";
            activeTextBox.Text = input;
        }

        private void button26_Click(object sender, EventArgs e)
        {
            input += "g";
            activeTextBox.Text = input;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            input += "h";
            activeTextBox.Text = input;
        }

        private void button25_Click(object sender, EventArgs e)
        {
            input += "j";
            activeTextBox.Text = input;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            input += "k";
            activeTextBox.Text = input;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            input += "l";
            activeTextBox.Text = input;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            input += "z";
            activeTextBox.Text = input;
        }

        private void button36_Click(object sender, EventArgs e)
        {
            input += "x";
            activeTextBox.Text = input;
        }

        private void button35_Click(object sender, EventArgs e)
        {
            input += "c";
            activeTextBox.Text = input;
        }

        private void button33_Click(object sender, EventArgs e)
        {
            input += "v";
            activeTextBox.Text = input;
        }

        private void button34_Click(object sender, EventArgs e)
        {
            input += "b";
            activeTextBox.Text = input;
        }

        private void button32_Click(object sender, EventArgs e)
        {
            input += "n";
            activeTextBox.Text = input;
        }

        private void button31_Click(object sender, EventArgs e)
        {
            input += "m";
            activeTextBox.Text = input;
        }
    }
}
