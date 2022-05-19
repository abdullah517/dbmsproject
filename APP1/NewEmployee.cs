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
    public partial class NewEmployee : Form
    {
        function fn=new function();
        String query;
        public NewEmployee()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void NewEmployee_Load(object sender, EventArgs e)
        {

        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2CirclePictureBox3_Click(object sender, EventArgs e)
        {
            clearAll();
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
            if (mobilenumber.Text != "" && name.Text != "" &&fathername.Text!=""&&mothername.Text!=""&&emailid.Text!=""&&permanentaddress.Text!=""&&txtdesignation.SelectedIndex!=null&&uniqueid.Text!="")
            {
                Int64 mobile=Int64.Parse(mobilenumber.Text);
                String namet = name.Text;
                String fname=fathername.Text;
                String mname=mothername.Text;
                String email=emailid.Text;
                String address=permanentaddress.Text;
                String id=uniqueid.Text;
                String desgination=txtdesignation.Text;

                query = "insert into newEmployee(emobile,ename,efname,emname,eemail,epaddress,eidproof,edesignation) values ("+mobile+",'"+namet+ "','" + fname + "','" + mname + "','" + email + "','" + address + "','" + id + "','" + desgination + "')";
                fn.setdata(query, "Employee Registration Successful");
                clearAll();
            }
            else
            {
                MessageBox.Show("Please fill all credeintials","Information",MessageBoxButtons.OK);
            }
        }
    }
}
