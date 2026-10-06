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
    public partial class voiditems : Form
    {
        public string EnteredUsername => usernametxt.Text;
        public string EnteredPassword => passwordtxt.Text;
        public voiditems()
        {
            InitializeComponent();
        }
        private voidclass manager = new voidclass();
        private void button39_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void voiditems_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            usernametxt.Clear();
            passwordtxt.Clear();
        }
    }
}
