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
    public partial class monthattendance : Form
    {
        public monthattendance()
        {
            InitializeComponent();
        }

        private void monthattendance_Load(object sender, EventArgs e)
        {
            string connString = "Data Source=DESKTOP-QG8L2ER\\SQLEXPRESS;Initial Catalog=restuarant;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();

                // Query to count present days per student
                string query = @"
                SELECT 
                    stname,
                    COUNT(CASE WHEN present = 1 THEN 1 END) AS presentDays
                FROM attendance
                GROUP BY stname";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                // Add calculated columns
                dt.Columns.Add("payDays", typeof(int));
                dt.Columns.Add("noPayDays", typeof(int));

                foreach (DataRow row in dt.Rows)
                {
                    int presentDays = Convert.ToInt32(row["presentDays"]);
                    row["payDays"] = presentDays;
                    row["noPayDays"] = 30 - presentDays;
                }

                dataGridView1.DataSource = dt;
            }
        }
    }
}
