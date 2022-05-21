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
    public partial class UpdateDeleteEmployee : Form
    {
        function fn = new function();
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

        private void updatebtnEmp_Click(object sender, EventArgs e)
        {
            Int64 mobile =Int64.Parse(txtmobile.Text);
            String name=txtname.Text;
            String fname=txtfname.Text;
            String mname=txtmname.Text;
            String email=txtemail.Text;
            String paddress=txtpaddress.Text;
            String id=txtUniqueid.Text;
            String designation=txtdesignation.Text;
            String workingstatus=txtworkingstatus.Text;

            query = "update newEmployee set ename='" + name + "',efname='" + fname + "',emname='" + mname + "',eemail='" + email + "',epaddress='" + paddress + "',eidproof='" + id + "',edesignation='" + designation + "',working='" + workingstatus + "' where emobile=" + mobile + "";
            fn.setdata(query, "Data Updation Successfully");
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
    }
}
