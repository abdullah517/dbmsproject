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
    public partial class NewStudent : Form
    {
        string query;
        string emailpatt = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
        function fn = new function();
        public NewStudent()
        {
            InitializeComponent();
        }

        private bool checkvalidid()
        {
           if (txtid.Text.Length < 13)
            {
                return true;
            }
            errorProvider1.Clear();
            return false;
        }

        private bool checkvalidmobno()
        {
            if (txtnumber.Text.Length < 11)
            {
                return true;
            }
            errorProvider3.Clear();
            return false;
        }

        private bool checkvalidemail()
        {
           if (Regex.IsMatch(txtemail.Text, emailpatt) == false)
            {
                return true;
            }
            errorProvider2.Clear();
            return false;
        }
        private void clearall()
        {
            txtnumber.Text = txtname.Text = txtFname.Text = txtMname.Text =
               txtemail.Text = txtpermanent.Text = txtclgname.Text =
               txtid.Text = "";
            ComboBoxRoomNo.SelectedIndex = -1;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NewStudent_Load(object sender, EventArgs e)
        {
            this.Location = new Point(350, 170);
            query = "select roomNo from rooms where roomStatus='Yes'and Booked='No'";
            DataSet ds = fn.GetData(query);
            for(int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                int room = int.Parse(ds.Tables[0].Rows[i][0].ToString());
                ComboBoxRoomNo.Items.Add(room);
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            clearall();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
           if(txtclgname.Text==""||txtemail.Text==""||txtFname.Text==""
                ||txtid.Text==""||txtMname.Text==""||txtname.Text==""
                || txtnumber.Text == "" || txtpermanent.Text == ""||
                ComboBoxRoomNo.SelectedIndex==-1)
            {
                MessageBox.Show("Please fill all fields", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           else if (checkvalidemail())
            {
                txtemail.Focus();
                errorProvider2.SetError(this.txtemail, "Please enter valid email");
            }
           else if (checkvalidid())
            {
                txtid.Focus();
                errorProvider1.SetError(this.txtid, "Please enter 13 digit valid cnic");
            }
            else if (checkvalidmobno())
            {
                txtnumber.Focus();
                errorProvider3.SetError(this.txtnumber, "Please enter 11 digit mobile number");
            }
            else
            {
                Int64 mobileno = Int64.Parse(txtnumber.Text);
                int roomno = int.Parse(ComboBoxRoomNo.Text);
                query = "insert into newStudent (mobile,sname,fname,mname,email," +
                    "paddress,college,idproof,roomNo)values("+mobileno+",'"+txtname.Text+ "','" + txtFname.Text + "','" + txtMname.Text + "','" + txtemail.Text + "','" + txtpermanent.Text + "','" + txtclgname.Text + "','" + txtid.Text + "',"+roomno+") update rooms set Booked='Yes'where roomNo="+roomno+"";
                fn.setdata(query, "Student Registration Successful.");
                clearall();
            }
 
        }

        private void txtnumber_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtFname_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (char.IsLetter(ch) == true)
                e.Handled = false;
            else if (ch == 8 || ch == 32)
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void txtMname_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (char.IsLetter(ch) == true)
                e.Handled = false;
            else if (ch == 8 || ch == 32)
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void txtclgname_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
