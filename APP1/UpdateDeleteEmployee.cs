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
    public partial class UpdateDeleteEmployee : Form
    {
        function fn = new function();
        string emailpatt = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
        string query;
        private Dashboard mainForm = null;
        public UpdateDeleteEmployee(Form callingForm)
        {
            mainForm = callingForm as Dashboard;
            InitializeComponent();
        }
        private void guna2Button3_Click(object sender, EventArgs e)
        {
            query = "select * from newEmployee where emobile=" + txtmobile.Text + "";
            DataSet ds = fn.GetData(query); 
            if (ds.Tables[0].Rows.Count!=0)
            {
                txtname.Text=ds.Tables[0].Rows[0][2].ToString();
                txtfname.Text=ds.Tables[0].Rows[0][3].ToString();
                txtmname.Text=ds.Tables[0].Rows[0][4].ToString();
                txtemail.Text=ds.Tables[0].Rows[0][5].ToString();
                txtpaddress.Text=ds.Tables[0].Rows[0][6].ToString();
                txtUniqueid.Text=ds.Tables[0].Rows[0][7].ToString();
                txtdesignation.Text=ds.Tables[0].Rows[0][8].ToString();
                txtworkingstatus.Text=ds.Tables[0].Rows[0][9].ToString();
            }
            else
            {
                MessageBox.Show("No Records Exist.","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
                clearAll();
            }
        }

        private bool ischeckempty()
        {
            if (txtmobile.Text == "" || txtname.Text == "" || txtmname.Text == "" || txtfname.Text == "" || txtpaddress.Text == "" || txtemail.Text == "" || txtUniqueid.Text == "" || txtdesignation.Text == "" || txtworkingstatus.Text == "")
                return true;
            return false;
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
            if (txtUniqueid.Text.Length < 13)
            {
                return true;
            }
            errorProvider2.Clear();
            return false;
        }

        private bool checkcnicexistance(string cnic)
        {
            query = "select all from newEmployee where eidproof='" + cnic + "'";
            DataSet ds = fn.GetData(query);
            if (ds.Tables[0].Rows.Count > 0)
            {
                return true;
            }
            return false;
        }

        private void updatebtnEmp_Click(object sender, EventArgs e)
        {
            if (txtmobile.Text != "")
            {
                if (ischeckempty())
                {
                    MessageBox.Show("Please fill all Fields.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (checkvalidemail())
                {
                    txtemail.Focus();
                    errorProvider1.SetError(this.txtemail, "Please enter valid email");
                }
                else if (checkvalidid())
                {
                    txtUniqueid.Focus();
                    errorProvider2.SetError(this.txtUniqueid, "Please enter 13 digit valid cnic");
                }
                else if (checkcnicexistance(txtUniqueid.Text))
                {
                    txtUniqueid.Clear();
                    txtUniqueid.Focus();
                    MessageBox.Show("this id already exists", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    Int64 mobile = Int64.Parse(txtmobile.Text);
                    String name = txtname.Text;
                    String fname = txtfname.Text;
                    String mname = txtmname.Text;
                    String email = txtemail.Text;
                    String paddress = txtpaddress.Text;
                    String id = txtUniqueid.Text;
                    String designation = txtdesignation.Text;
                    String workingstatus = txtworkingstatus.Text;

                    query = "update newEmployee set ename='" + name + "',efname='" + fname + "',emname='" + mname + "',eemail='" + email + "',epaddress='" + paddress + "',eidproof='" + id + "',edesignation='" + designation + "',working='" + workingstatus + "' where emobile=" + mobile + "";
                    fn.setdata(query, "Data Updation Successfully");
                    clearAll();
                }
            }
            
        }

        private void deletebtnEmp_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                query = "delete from newEmployee where emobile=" + txtmobile.Text + "";
                fn.setdata(query, "Employee Record Deleted");
                clearAll();
            }

        }
        private void clearAll()
        {
            txtname.Clear();
            txtfname.Clear();
            txtmname.Clear();
            txtpaddress.Clear();
            txtmobile.Clear();
            txtUniqueid.Clear();
            txtemail.Clear();
            txtdesignation.SelectedIndex = -1;
            txtworkingstatus.SelectedIndex = -1;
        }

        private void clearbtnEmp_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            this.mainForm.func();
        }

        private void txtmobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (char.IsDigit(ch) == true)
                e.Handled = false;
            else if (ch == 8)
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void txtname_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (char.IsLetter(ch) == true)
                e.Handled = false;
            else if (ch == 8 || ch == 32)
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void txtfname_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (char.IsLetter(ch) == true)
                e.Handled = false;
            else if (ch == 8 || ch == 32)
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void txtmname_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (char.IsLetter(ch) == true)
                e.Handled = false;
            else if (ch == 8 || ch == 32)
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void txtUniqueid_KeyPress(object sender, KeyPressEventArgs e)
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
