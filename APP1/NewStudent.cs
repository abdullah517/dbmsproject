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
        

        private Dashboard mainForm = null;
        public NewStudent(Form callingForm)
        {
            mainForm = callingForm as Dashboard;
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
            this.mainForm.func();
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

        private void checkroomstatus(int number,int roomno) {
            query = "select*from newStudent where roomNo=" + roomno + "";
            DataSet ds = fn.GetData(query);
            if (ds.Tables[0].Rows.Count == number)
            {
                query = "update rooms set Booked='Yes'";
                fn.setdata(query, "room is fully booked");
            }
        }

        private int getbeds(int room)
        {
            query = "select totalbeds from rooms where roomNo=" + room + "";
            DataSet ds = fn.GetData(query);
            int totalbeds = int.Parse(ds.Tables[0].Rows[0][0].ToString());
            return totalbeds;
        }

        private void getbedno(int beds,ref int bedno,int roomno)
        {
            int rng = beds + 1;
            Random random = new Random();
            while(true)
            {
                 bedno=random.Next(1, rng);
                MessageBox.Show(bedno.ToString());
                query = "select*from newStudent where bedno=" + bedno + "and roomNo="+roomno+ "and where living='Yes'";
                DataSet ds = fn.GetData(query);
                if (ds.Tables[0].Rows.Count == 0)
                {
                    break;
                }
            }
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
                int bedno=0;
                Int64 mobileno = Int64.Parse(txtnumber.Text);
                int roomno = int.Parse(ComboBoxRoomNo.Text);
                int beds = getbeds(roomno);
                getbedno(beds,ref bedno,roomno);
                query = "insert into newStudent (mobile,sname,fname,mname,email," +
                    "paddress,college,idproof,roomNo,bedno)values("+mobileno+",'"+txtname.Text+ "','" + txtFname.Text + "','" + txtMname.Text + "','" + txtemail.Text + "','" + txtpermanent.Text + "','" + txtclgname.Text + "','" + txtid.Text + "',"+roomno+","+ bedno + ")";
                fn.setdata(query, "Student Registration Successful.");
                clearall();
                checkroomstatus(beds, roomno);
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
