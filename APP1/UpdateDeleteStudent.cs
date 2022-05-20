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
    public partial class UpdateDeleteStudent : Form
    {
        function fs=new function();
        string query;
        string emailpatt = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";

       

        private Dashboard mainForm = null;
        public UpdateDeleteStudent(Form callingForm)
        {
            mainForm = callingForm as Dashboard;
            InitializeComponent();
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            this.mainForm.func();
        }

        private void UpdateDeleteStudent_Load(object sender, EventArgs e)
        {
            this.Location = new Point(350, 150);
            query = "select roomNo from rooms where roomStatus='Yes'and Booked='No'";
            DataSet ds = fs.GetData(query);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                int room = int.Parse(ds.Tables[0].Rows[i][0].ToString());
                ComboBoxroomno.Items.Add(room);
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            clearall();
        }
        private void clearall()
        {
            txtclgname.Text = txtemail.Text = txtFname.Text = txtid.Text =
                txtMname.Text = txtname.Text = txtnumber.Text = txtpermanent.Text = "";
            ComboBoxlivingstatus.SelectedIndex = -1;
            ComboBoxroomno.SelectedIndex = -1;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Int64 mobno = Int64.Parse(txtnumber.Text);
            query="select*from newStudent where mobile="+mobno+"";
            DataSet ds = fs.GetData(query);
            if (ds.Tables[0].Rows.Count != 0)
            {
                txtname.Text = ds.Tables[0].Rows[0][2].ToString();
                txtFname.Text = ds.Tables[0].Rows[0][3].ToString();
                txtMname.Text = ds.Tables[0].Rows[0][4].ToString();
                txtemail.Text = ds.Tables[0].Rows[0][5].ToString();
                txtpermanent.Text = ds.Tables[0].Rows[0][6].ToString();
                txtclgname.Text = ds.Tables[0].Rows[0][7].ToString();
                txtid.Text = ds.Tables[0].Rows[0][8].ToString();
                ComboBoxroomno.Text = ds.Tables[0].Rows[0][9].ToString();
                ComboBoxlivingstatus.Text = ds.Tables[0].Rows[0][10].ToString();
            }
            else
            {
                clearall();
                MessageBox.Show("No record with this mobile number exists.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are You Sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                query = "delete from newStudent where mobile=" + txtnumber.Text + "";
                fs.setdata(query, "Student deleted successfully.");
                clearall();
            }
        }

        private bool ischeckempty()
        {
            if (txtclgname.Text == "" || txtemail.Text == "" || txtFname.Text == "" || txtid.Text == "" || txtMname.Text == "" || txtname.Text == "" || txtpermanent.Text == "" || ComboBoxroomno.SelectedIndex == -1 || ComboBoxlivingstatus.SelectedIndex == -1)
            {
                return true;
            }
            return false;
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (txtnumber.Text != "")
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
                    txtid.Focus();
                    errorProvider2.SetError(this.txtid, "Please enter 13 digit valid cnic");
                }

            else
            {
                Int64 mobno = Int64.Parse(txtnumber.Text);
                int roomno = int.Parse(ComboBoxroomno.Text);
                Int64 uid = Int64.Parse(txtid.Text);
                query = "update newStudent set sname='" + txtname.Text + "',fname='" + txtFname.Text + "',mname='" + txtMname.Text + "',email='" + txtemail.Text + "',paddress='" + txtpermanent.Text + "',college='" + txtclgname.Text + "',idproof=" + uid + ",roomNo=" + roomno + ",living='" + ComboBoxlivingstatus.Text + "'where mobile=" + mobno + "update rooms set Booked='" + ComboBoxlivingstatus.Text + "'where roomNo=" + roomno + "";
                fs.setdata(query, "Data updation successfull.");
                clearall();
            }
            }
            else
            {
                MessageBox.Show("Please Enter any mobile number to Search.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
