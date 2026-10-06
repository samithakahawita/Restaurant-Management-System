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
    public partial class Form1 : Form
    {
        string input = string.Empty;
        TextBox activeTextBox;
        public Form1()
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


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button39_Click(object sender, EventArgs e)
        {
           

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-QG8L2ER\SQLEXPRESS;Initial Catalog=restuarant;Integrated Security=True");
            con.Open();
            String username = usernametxt.Text;
            String password = passwordtxt.Text;
            SqlCommand cmd = new SqlCommand("select username,password from login where username='" + usernametxt.Text + "'and password='" + passwordtxt.Text + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                rest m = new rest();
                m.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Invalid Username or Password");
            }
        }
        
        private void usernametxt_TextChanged(object sender, EventArgs e)
        {
            activeTextBox = usernametxt;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            input += "1";
            activeTextBox.Text = input;


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

        private void passwordtxt_TextChanged(object sender, EventArgs e)
        {
            activeTextBox = passwordtxt;


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

        private void button37_Click(object sender, EventArgs e)
        {
            usernametxt.Clear();
            passwordtxt.Clear();
            usernametxt.Focus();
            activeTextBox = usernametxt;
            input = string.Empty;
        }
    }
}
