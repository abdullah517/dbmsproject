using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APP1
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void btnsignin_Click(object sender, EventArgs e)
        {
            if (txtusername.Text == "abcd" && txtpassword.Text == "1234")
            {
                this.Hide();
                Dashboard ds = new Dashboard();
                ds.Show();
            }
            else if (txtusername.Text == "" || txtpassword.Text == "")
                MessageBox.Show("Please fill both fields","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            else
                MessageBox.Show("Please enter valid details","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Chip1_Click(object sender, EventArgs e)
        {

        }

        private void LogIn_Load(object sender, EventArgs e)
        {

        }
    }
}
