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
    public partial class stblogin : Form
    {
        string input = string.Empty;
        TextBox activeTextBox;
        public stblogin()
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
                            stb m = new stb(new List<Tuple<string, int, decimal>>()); // Empty list for now
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

        private void stblogin_Load(object sender, EventArgs e)
        {

        }

        private void button37_Click(object sender, EventArgs e)
        {
            usernametxt.Clear();
            passwordtxt.Clear();
        }

        private void usernametxt_TextChanged(object sender, EventArgs e)
        {
            activeTextBox = usernametxt;
        }

        private void passwordtxt_TextChanged(object sender, EventArgs e)
        {
            activeTextBox = passwordtxt;
        }
    }
}
