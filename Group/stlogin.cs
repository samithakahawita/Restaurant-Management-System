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
    public partial class stlogin : Form
    {
        public stlogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = usernametxt.Text; // Get the username from the TextBox
            if (!string.IsNullOrEmpty(username))
            {
                usernametxt.Text = "1";  // Change the button text to "1"
            }
            else
            {
                usernametxt.Text = "1";  // Prompt to enter a username
            }

        }

        private void button39_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-QG8L2ER\SQLEXPRESS;Initial Catalog=restuarant;Integrated Security=True");
            con.Open();
            String username = usernametxt.Text;
            String password = passwordtxt.Text;
            SqlCommand cmd = new SqlCommand("select username,password from samithatb where username='" + usernametxt.Text + "'and password='" + passwordtxt.Text + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                items m = new items(new List<Tuple<string, int, decimal>>());
                m.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Invalid Username or Password");
            }
        }

        private void stlogin_Load(object sender, EventArgs e)
        {

        }

        private void usernametxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void button37_Click(object sender, EventArgs e)
        {
            usernametxt.Clear();
            passwordtxt.Clear();
        }
    }
}
