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
        function fs = new function();
        string query;
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
            
            if (txtusername.Text != "" && txtpassword.Text != "")
            {
                query = "select*from appuser where email='" + txtusername.Text + "'and pass='" + txtpassword.Text + "'";
                DataSet ds = fs.GetData(query);
                if (ds.Tables[0].Rows.Count != 0)
                {
                    this.Hide();
                    Dashboard Ds = new Dashboard();
                    Ds.Show();
                }
                else
                {
                    MessageBox.Show("Please enter valid details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtpassword.Clear();
                }
            }
            else
                MessageBox.Show("Please fill both fields","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
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

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            bool check = CheckBox1.Checked;
            if (check == true)
                txtpassword.PasswordChar = '\0';
            else
                txtpassword.PasswordChar = '*';
        }
    }
}
