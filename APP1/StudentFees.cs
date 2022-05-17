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
    public partial class StudentFees : Form
    {
        function fs = new function();
        string query;
        public StudentFees()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StudentFees_Load(object sender, EventArgs e)
        {
            this.Location = new Point(350, 170);
            DateTimePicker.Format = DateTimePickerFormat.Custom;
            DateTimePicker.CustomFormat = "MMMM yyyy";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Int64 number = Int64.Parse(txtnumber.Text);
            query = "select sname,email,roomNo from newStudent where mobile =" + number + "";
            DataSet ds = fs.GetData(query);
            if (ds.Tables[0].Rows.Count != 0)
            {
                txtname.Text = ds.Tables[0].Rows[0][0].ToString();
                txtemail.Text = ds.Tables[0].Rows[0][1].ToString();
                txtroomno.Text = ds.Tables[0].Rows[0][2].ToString();
                setdatagridview(number);
            }
            else
            {
                MessageBox.Show("No record Exist", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void setdatagridview(Int64 number)
        {
            query = "select*from fees where mobileNo = " + number + "";
            DataSet ds=fs.GetData(query);
            DataGridView.DataSource = ds.Tables[0];
        }

        private void btnpay_Click(object sender, EventArgs e)
        {
            
            if (txtnumber.Text != "" && txtamount.Text != "")
            {
                Int64 number = Int64.Parse(txtnumber.Text);
                query = "select*from fees where mobileNo=" + number + "and fmonth='" + DateTimePicker.Text + "'";
                DataSet ds = fs.GetData(query);
                if (ds.Tables[0].Rows.Count == 0)
                {
                    string month = DateTimePicker.Text;
                    Int64 amount = Int64.Parse(txtamount.Text);
                    query = "insert into fees values(" + number + ",'" + month + "'," + amount + ")";
                    fs.setdata(query, "Fees Paid.");
                    clearall();
                }
                else
                {
                    MessageBox.Show("No dues of " + DateTimePicker.Text + " left.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            clearall();
        }

        private void clearall()
        {
            txtamount.Text = txtemail.Text = txtname.Text = txtnumber.Text=txtroomno.Text = "";
            DataGridView.DataSource = 0;
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
    }
}
