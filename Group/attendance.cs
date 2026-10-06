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
    public partial class attendance : Form
    {
        public attendance()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = dateTimePicker1.Value;
            string connString = "Data Source=DESKTOP-QG8L2ER\\SQLEXPRESS;Initial Catalog=restuarant;Integrated Security=True"; // Replace with your DB connection string

            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                foreach (DataGridViewRow row in dgvAttendance.Rows)
                {
                    if (row.Cells["studentName"].Value != null && row.Cells["present"].Value != null)
                    {
                        string name = row.Cells["studentName"].Value.ToString();
                        bool isPresent = Convert.ToBoolean(row.Cells["present"].Value);

                        string query = "INSERT INTO attendance (stname, present, date) VALUES (@name, @present, @date)";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@name", name);
                            cmd.Parameters.AddWithValue("@present", isPresent);
                            cmd.Parameters.AddWithValue("@date", selectedDate.Date);
                            cmd.ExecuteNonQuery();
                        }
                    }
                }

                MessageBox.Show("Attendance data inserted successfully.");
            }
        }

        private void attendance_Load(object sender, EventArgs e)
        {
            dgvAttendance.Columns.Clear();

            // Add "Student Name" column (Text)
            dgvAttendance.Columns.Add("studentName", "Student Name");

            // Add "Present" column (CheckBox)
            DataGridViewCheckBoxColumn presentColumn = new DataGridViewCheckBoxColumn();
            presentColumn.HeaderText = "Present";
            presentColumn.Name = "present";
            dgvAttendance.Columns.Add(presentColumn);

            // Sample students
            string[] students = { "Samitha", "Dilan", "Hiranya", "Prasantha","Sachintha", "Sayuni","Esandi","Sashrika","Upeka","Sathsarani" };
            foreach (string student in students)
            {
                dgvAttendance.Rows.Add(student, false); // false = not present by default
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            monthattendance m=new monthattendance();
            m.Show();
        }
    }
}
