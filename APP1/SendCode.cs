using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

namespace APP1
{
    public partial class SendCode : Form
    {
        function fs = new function();
        string query;
        string randomcode = "";
        static string uemail = "";
        public SendCode()
        {
            InitializeComponent();
        }

        public static string UEmail
        {
            get { return uemail; }
            set { uemail = value; }
        }

        private void txtverify_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (char.IsDigit(ch) == true)
                e.Handled = false;
            else if (ch == 8)
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void sendmail()
        {
            string from = "", pass = "", to = "";
            Random rand = new Random();
            randomcode = (rand.Next(999999)).ToString();
            MailMessage message = new MailMessage();
            to = txtemail.Text;
            from = "codereset1@outlook.com";
            pass = "%?7R92DnesEfP)Y";
            message.To.Add(to);
            message.From = new MailAddress(from);
            message.Body = "Your reset code is " + randomcode;
            message.Subject = "Password Reset Code";
            SmtpClient client = new SmtpClient("smtp.outlook.com");
            client.Port = 587;
            client.Credentials = new NetworkCredential(from, pass);
            client.EnableSsl = true;
            try
            {
                client.Send(message);
                MessageBox.Show("Code Successfully Send","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnsendcode_Click(object sender, EventArgs e)
        {
            if (txtemail.Text != "")
            {
                query = "select*from appuser where email='" + txtemail.Text + "'";
                DataSet ds = fs.GetData(query);
                if (ds.Tables[0].Rows.Count != 0)
                {
                    UEmail = txtemail.Text;
                    sendmail();
                }
                else
                {
                    MessageBox.Show("Please enter valid email address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtemail.Clear();
                    txtemail.Focus();
                }
            }
            else
                MessageBox.Show("Please enter your email address", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnverify_Click(object sender, EventArgs e)
        {
            if (txtverify.Text != "")
            {
                if (txtverify.Text == randomcode)
                {
                    this.Close();
                    ResetPassword rs = new ResetPassword();
                    rs.Show();
                }
                else
                {
                    MessageBox.Show("Incorrect Code", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtverify.Clear();
                    txtverify.Focus();
                }
            }
            else
                MessageBox.Show("Please enter the code", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            LogIn li = new LogIn(false);
            li.Show();
        }
    }
}
