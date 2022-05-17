using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APP1
{
    public partial class SignUp : Form
    {
        function fs = new function();
        string query;
        string emailpatt = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
        string passpatt = @"(?=^.{8,}$)((?=.*\d)|(?=.*\W+))(?![.\n])(?=.*[A-Z])(?=.*[a-z]).*$";
        public SignUp()
        {
            InitializeComponent();
        }

        private void linksignin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            LogIn li = new LogIn(false);
            li.Show();
        }

        private void clearall()
        {
            txtcfmpass.Text = txtemail.Text = txtfullname.Text = txtid.Text =
                txtpass.Text = "";
        }

        private void txtfullname_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (char.IsLetter(ch) == true)
                e.Handled = false;
            else if (ch == 8 || ch == 32)
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void txtid_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (char.IsDigit(ch) == true)
                e.Handled = false;
            else if (ch == 8)
                e.Handled = false;
            else
                e.Handled = true;
        }

        private bool checkemailexistance()
        {
            query = "select*from appuser where email='" + txtemail.Text + "'";
            DataSet ds = fs.GetData(query);
            if (ds.Tables[0].Rows.Count != 0)
                return true;
            else
            {
                label4.Visible = false;
                return false;
            }                                                 
        }

        private bool checkcnicexistance()
        {
            Int64 uid = Int64.Parse(txtid.Text);
            query = "select*from appuser where id="+uid+"";
            DataSet ds = fs.GetData(query);
            if (ds.Tables[0].Rows.Count != 0)
                return true;
            else
            {
                label5.Visible = false;
                return false;
            }
               
        }

        private bool checkvalidemail()
        {
            if (Regex.IsMatch(txtemail.Text, emailpatt) == false)
            {
                return true;
            }
            errorProvider1.Clear();
            return false;
        }

        private bool checkvalidid()
        {
            if (txtid.Text.Length < 13)
            {
                return true;
            }
            errorProvider2.Clear();
            return false;
        }

        private bool checkpass()
        {
            if(Regex.IsMatch(txtpass.Text, passpatt) == false)
            {
                return true;
            }
            errorProvider3.Clear();
            return false;
        }

        private bool checkempty()
        {
            if(txtcfmpass.Text==""||txtemail.Text==""||txtfullname.Text==""
                || txtid.Text == "" || txtpass.Text == "")
            {
                return true;
            }
            return false;
        }

        private bool chkcfmpass()
        {
            if (txtcfmpass.Text!=txtpass.Text)
            {
                return true;
            }
            label3.Visible = false;
            return false;
        }

        private void btnregister_Click(object sender, EventArgs e)
        {
            if (checkempty())
                MessageBox.Show("Please fill all the fields", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (checkvalidemail())
            {
                txtemail.Focus();
                errorProvider1.SetError(this.txtemail, "Please enter valid email");
            }
            else if (checkvalidid())
            {
                txtid.Focus();
                errorProvider2.SetError(this.txtid, "Please enter 13 digit valid cnic");
            }

            else if (checkpass())
            {
                txtpass.Focus();
                errorProvider3.SetError(this.txtpass, "Please enter strong password including uppercase,lowercase,numbers and special characters");
            }

            else if (checkemailexistance())
                label4.Visible = true;
            else if (checkcnicexistance())
            {
                label5.Visible = true;
            }
            else if (chkcfmpass())
            {
                label3.Visible = true;
            }

            else
            {
                Int64 Id = Int64.Parse(txtid.Text);
                query = "insert into appuser(fullname,email,pass,id)values('" + txtfullname.Text + "','" + txtemail.Text + "','" + txtpass.Text + "'," + Id + ")";
                fs.setdata(query, "Registered Successfully.");
                clearall();
            }
        }
    }
}
