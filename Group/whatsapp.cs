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
    public partial class whatsapp : Form
    {
        public whatsapp()
        {
            InitializeComponent();
        }

        private void whatsapp_Load(object sender, EventArgs e)
        {

        }
        private void sendWhatsApp(string number, string message)

        {

            try

            {

                if (number == "")

                {

                    MessageBox.Show("No number added");

                }

                if (number.Length <= 10)

                {

                    MessageBox.Show("Your Order Message Confirm it, We will Arrage and Confirm it!!!");

                    number = "+94" + txtNumber;

                }

                number = number.Replace(" ", "");



                System.Diagnostics.Process.Start("http://api.whatsapp.com/send?phone=" + number + "&text=" + message);

            }

            catch (Exception ex)

            {

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string finalMessage = txtMessage.Text + "\n\nYour Order Message Confirm it, We will Arrange and Confirm it!!!";
            sendWhatsApp(send.Text, finalMessage);
        }

        private void txtMessage_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
