using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Vonage;
using Vonage.Messaging;
using Vonage.Request;

namespace Group
{
    public partial class sms : Form
    {
        public sms()
        {
            InitializeComponent();
        }

        private void sms_Load(object sender, EventArgs e)
        {

        }

        private void send_Click(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string to = textBox1.Text.Trim();
            string from = textBox3.Text.Trim();
            string text = textBox2.Text.Trim();

            
            if (string.IsNullOrWhiteSpace(to))
            {
                MessageBox.Show("Please enter a valid mobile number.");
                return;
            }

            if (string.IsNullOrWhiteSpace(from))
            {
                MessageBox.Show("Please enter your account number.");
                return;
            }

            if (string.IsNullOrWhiteSpace(text))
            {
                MessageBox.Show("Message field is empty.");
                return;
            }

            
            if (!Regex.IsMatch(to, @"^\+?[1-9]\d{1,14}$"))
            {
                MessageBox.Show("Invalid phone number format. Use international format like +1234567890.");
                return;
            }

            try
            {
               
                var credentials = Credentials.FromApiKeyAndSecret("7af26af0", "n2bdqU8Am5KgXWEw");
                var vonageClient = new VonageClient(credentials);

                var request = new SendSmsRequest
                {
                    To = to,
                    From = from,
                    Text = text
                };

                var response = await vonageClient.SmsClient.SendAnSmsAsync(request);

                if (response.Messages[0].Status == "0")
                {
                    MessageBox.Show("Message sent successfully!");
                }
                else
                {
                    MessageBox.Show($"Failed to send message. Error: {response.Messages[0].ErrorText}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred:\n" + ex.Message);
            }
        }
    }
}
