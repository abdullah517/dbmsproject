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
    public partial class NewEmployee : Form
    {
        function fn=new function();
        String query;
        string emailpatt = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";


        public NewEmployee()
        {
            InitializeComponent();
        }

        private Dashboard mainForm = null;
        public NewEmployee(Form callingForm)
        {
            mainForm = callingForm as Dashboard;
            InitializeComponent();
        }

        private bool checkcnicexistance(Int64 cnic)
        {
            query = "select all from newEmployee where eidproof=" + cnic + "";
            DataSet ds = fn.GetData(query);
            if (ds.Tables[0].Rows.Count > 0)
            {
                return true;
            }
            return false;
        }
        private bool checkvalidid()
        {
            if (uniqueid.Text.Length < 13)
            {
                return true;
            }
            errorProvider1.Clear();
            return false;
        }

        private bool checkvalidmobno()
        {
            if (mobilenumber.Text.Length < 11)
            {
                return true;
            }
            errorProvider3.Clear();
            return false;
        }

        private bool checkvalidemail()
        {
            if (Regex.IsMatch(emailid.Text, emailpatt) == false)
            {
                return true;
            }
            errorProvider2.Clear();
            return false;
        }


        private void clearAll()
        {
            name.Clear();
            fathername.Clear();
            mothername.Clear();
            permanentaddress.Clear();
            mobilenumber.Clear();
            uniqueid.Clear();
            emailid.Clear();
            txtdesignation.SelectedIndex = -1;
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (mobilenumber.Text == "" || name.Text == "" || fathername.Text=="" || mothername.Text=="" || emailid.Text=="" || permanentaddress.Text=="" || txtdesignation.SelectedIndex==-1 || uniqueid.Text!="")
            {
                MessageBox.Show("Please fill all credeintials", "Information", MessageBoxButtons.OK);
              
            }
            else if (checkvalidemail())
            {
                emailid.Focus();
                errorProvider2.SetError(this.emailid, "Please enter valid email");
            }
            else if (checkvalidid())
            {
                uniqueid.Focus();
                errorProvider1.SetError(this.uniqueid, "Please enter 13 digit valid cnic");
            }
            else if (checkcnicexistance(Int64.Parse(uniqueid.Text)))
            {
                uniqueid.Clear();
                uniqueid.Focus();
                MessageBox.Show("this id already exists", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (checkvalidmobno())
            {
                mobilenumber.Focus();
                errorProvider3.SetError(this.mobilenumber, "Please enter 11 digit mobile number");
            }
            else
            {
                Int64 mobile = Int64.Parse(mobilenumber.Text);
                String namet = name.Text;
                String fname = fathername.Text;
                String mname = mothername.Text;
                String email = emailid.Text;
                String address = permanentaddress.Text;
                String id = uniqueid.Text;
                String desgination = txtdesignation.Text;

                query = "insert into newEmployee(emobile,ename,efname,emname,eemail,epaddress,eidproof,edesignation) values (" + mobile + ",'" + namet + "','" + fname + "','" + mname + "','" + email + "','" + address + "','" + id + "','" + desgination + "')";
                fn.setdata(query, "Employee Registration Successful");
                clearAll();
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
            this.mainForm.func();
        }

        private void mobilenumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (char.IsDigit(ch) == true)
                e.Handled = false;
            else if (ch == 8)
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void name_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (char.IsLetter(ch) == true)
                e.Handled = false;
            else if (ch == 8 || ch == 32)
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void fathername_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (char.IsLetter(ch) == true)
                e.Handled = false;
            else if (ch == 8 || ch == 32)
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void mothername_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (char.IsLetter(ch) == true)
                e.Handled = false;
            else if (ch == 8 || ch == 32)
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void uniqueid_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (char.IsDigit(ch) == true)
                e.Handled = false;
            else if (ch == 8)
                e.Handled = false;
            else
                e.Handled = true;
        }
    }
}
