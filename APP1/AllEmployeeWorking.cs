using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace APP1
{
    public partial class AllEmployeeWorking : Form
    {
        function fn = new function();
        String query;
        
        private Dashboard mainForm = null;
        public AllEmployeeWorking(Form callingForm)
        {
            mainForm = callingForm as Dashboard;
            InitializeComponent();
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            this.mainForm.func();
        }

        private void AllEmployeeWorking_Load(object sender, EventArgs e)
        {
            this.Location = new Point(350, 170);
            query = "select * from newEmployee where working='Yes'";
            DataSet ds=fn.GetData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
        