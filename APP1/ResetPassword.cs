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
    public partial class ResetPassword : Form
    {
        function fs = new function();
        string query;
        string umail="";
        public ResetPassword()
        {
            InitializeComponent();
        }

       

        private void btnreset_Click(object sender, EventArgs e)
        {
            if (txtpass.Text == "" || txtcfmpass.Text == "")
                MessageBox.Show("Please fill both fields", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (txtcfmpass.Text != txtpass.Text)
            {
                label3.Visible = true;
                txtcfmpass.Clear();
            }
            else
            {
                umail = SendCode.UEmail;
                label3.Visible = false;
                query = "update appuser set pass='" + txtpass.Text + "'where email='"+umail+"'";
                fs.setdata(query, "Password reset successfully.");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            LogIn li = new LogIn(false);
            li.Show();
        }
    }
}
