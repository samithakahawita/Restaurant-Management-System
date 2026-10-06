using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group
{
    public partial class email : Form
    {
        public email()
        {
            InitializeComponent();
        }

        private void send_Click(object sender, EventArgs e)
        {
            try
            {
                string To = txtNumber.Text;
                string Subject = txtMessage.Text;
                string Body = "Order accepted and we will prepare and will let you know";

                string Email = "kdsmaduranga@students.nsbm.ac.lk";
                string Password = "Wkq5%kds";  // Avoid hardcoding credentials
                string Host = "smtp.office365.com";  // Correct SMTP host for Outlook
                int Port = 587;  // Correct SMTP port

                using (MailMessage mail = new MailMessage(Email, To, Subject, Body))
                {
                    using (SmtpClient smtp = new SmtpClient(Host, Port))
                    {
                        smtp.UseDefaultCredentials = false;
                        smtp.EnableSsl = true;
                        smtp.Credentials = new NetworkCredential(Email, Password);
                        smtp.Timeout = 20000; // Set timeout

                        smtp.Send(mail);
                        MessageBox.Show("Email sent successfully!", "Success");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error");
            }
        }

        private void email_Load(object sender, EventArgs e)
        {

        }
    }
}
