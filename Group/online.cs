using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace Group
{
    public partial class online : Form
    {
        public online()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            online o = new online();
            o.Show();
            this.Hide();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            takeaway o = new takeaway();
            o.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            BAR b = new BAR();
            b.Show();
            this.Hide();
;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            family f = new family();
            f.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void online_Load(object sender, EventArgs e)
        {
            loadData();
        }
        public void loadData()
        {
            var database = new Database();
            if (database.connect_db())
            {
                string query = "SELECT * FROM `group`"; // Escaped the table name
                MySqlCommand mySqlCommand = new MySqlCommand(query);
                mySqlCommand.Connection = database.mySqlConnection;

                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.SelectCommand = mySqlCommand;

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = dt;

                dataGridView2.DataSource = bindingSource;

                database.close_db();
            }
            else
            {
                MessageBox.Show("Database error");
            }


        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView2.SelectedRows[0];
                string id = selectedRow.Cells["id"].Value.ToString(); // Assuming "id" is your primary key

                DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Confirm Delete", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    DeleteRecord(id);
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }
        private void DeleteRecord(string id)
        {
            var database = new Database();
            if (database.connect_db())
            {
                string query = "DELETE FROM `group` WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(query, database.mySqlConnection);
                cmd.Parameters.AddWithValue("@id", id);

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("✅ Record deleted successfully!");
                    loadData(); // Reload the DataGridView
                }
                catch (Exception ex)
                {
                    MessageBox.Show("❌ Error: " + ex.Message);
                }

                database.close_db();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            whatsapp w = new whatsapp();
            w.Show();
            
        }

        private void button13_Click(object sender, EventArgs e)
        {
            online o =new online();
            o.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            sms sms = new sms();
            sms.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            email email = new email();
            email.Show();
        }

        private void button13_Click_1(object sender, EventArgs e)
        {
            online online = new online();
            online.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            signoff signoff = new signoff();
            signoff.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CANCELLBILL c = new CANCELLBILL();
            c.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            createsteward c = new createsteward();
            c.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            attendance attendance = new attendance();
            attendance.Show();
        }

        private void button16_Click(object sender, EventArgs e)
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
