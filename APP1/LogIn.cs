using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APP1
{
    public partial class LogIn : Form
    {
        public LogIn(bool chk = true)
        {
            if (chk == true)
            {
                Thread t = new Thread(new ThreadStart(splashstart));
                t.Start();
                Thread.Sleep(3000);
                InitializeComponent();
                t.Abort();
            }
            else
                InitializeComponent();
        }

        public void splashstart()
        {
           
            Application.Run(new splashscreen());
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

        private void linksignup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            SignUp su = new SignUp();
            su.Show();
        }

        private void linkforget_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            SendCode sc = new SendCode();
            sc.Show();
        }
    }
}
