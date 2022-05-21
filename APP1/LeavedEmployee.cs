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
    public partial class LeavedEmployee : Form
    {
        function fn = new function();
        String query;

        private Dashboard mainForm = null;
        public LeavedEmployee(Form callingForm)
        {
            mainForm = callingForm as Dashboard;
            InitializeComponent();
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            this.mainForm.func();
        }

        private void LeavedEmployee_Load(object sender, EventArgs e)
        {
            this.Location = new Point(350, 170);
            this.Location = new Point(350, 170);
            query = "select * from newEmployee where working='No'";
            DataSet ds = fn.GetData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
