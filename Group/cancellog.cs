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
    public partial class cancellog : Form
    {
        public string EnteredUsername => usernametxt.Text;
        public string EnteredPassword => passwordtxt.Text;
        public cancellog()
        {
            InitializeComponent();

        }

        private void cancellog_Load(object sender, EventArgs e)
        {

        }

        private void button39_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            usernametxt.Clear();
            passwordtxt.Clear();
        }
    }
}
