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
    public partial class EmployeePayment : Form
    {
        private Dashboard mainForm = null;
        public EmployeePayment(Form callingForm)
        {
            mainForm = callingForm as Dashboard;
            InitializeComponent();
        }

        function fn = new function();
        String query;
        private void EmployeePayment_Load(object sender, EventArgs e)
        {
            monthdatetime.Format = DateTimePickerFormat.Custom;
            monthdatetime.CustomFormat = "MMMM yyyy";
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            this.mainForm.func();
        }

        private void searchhbtnEm_Click(object sender, EventArgs e)
        {
            if (txtmobile.Text != "")
            {
                query = "select ename,eemail,edesignation from newEmployee where emobile=" + txtmobile.Text + "";
                DataSet ds = fn.GetData(query);
                if (ds.Tables[0].Rows.Count != 0)
                {
                    txtname.Text = ds.Tables[0].Rows[0][0].ToString();
                    txtemail.Text = ds.Tables[0].Rows[0][1].ToString();
                    txtdesignation.Text = ds.Tables[0].Rows[0][2].ToString();

                    setdataGridView(Int64.Parse(txtmobile.Text));
                }
                else
                {
                    MessageBox.Show("No record found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Enter Some data.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void setdataGridView(Int64 mobile)
        {
            query = "select * from employeeSalary where mobileNo=" + mobile + "";
            DataSet ds = fn.GetData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        private void paysalaryEmp_Click(object sender, EventArgs e)
        {
            if (txtmobile.Text != "" && txtpaymentEmp.Text != "")
            {
                query = "select * from employeeSalary where mobileNo=" + txtmobile.Text + " and fmonth ='" + monthdatetime.Text+"'";
                DataSet ds = fn.GetData(query);

                if (ds.Tables[0].Rows.Count == 0)
                {
                    Int64 mobile = Convert.ToInt64(txtmobile.Text);
                    String month = monthdatetime.Text;
                    Int64 amount = Convert.ToInt64(txtpaymentEmp.Text);
                    string msg = "Salary of month " + month + " is paid.";

                    query = "insert into employeeSalary values (" + mobile + ",'" + month + "'," + amount + ")";
                    fn.setdata(query,msg);
                    setdataGridView(mobile);
                }
                else
                {
                    MessageBox.Show("Payment of " + monthdatetime.Text + " is done.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void clearbtnEmp_Click(object sender, EventArgs e)
        {
            clearAll();
        }
        private void clearAll()
        {
            txtmobile.Clear();
            txtpaymentEmp.Clear();
            txtemail.Clear();
            txtname.Clear();
            txtdesignation.Clear();
            guna2DataGridView1.DataSource = 0;
            monthdatetime.ResetText();
        }
    }
}