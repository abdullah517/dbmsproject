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
    public partial class AllStudentsLiving : Form
    {
        function fs = new function();
        string query;
        public AllStudentsLiving()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AllStudentsLiving_Load(object sender, EventArgs e)
        {
            this.Location = new Point(350, 170);
            query = "select*from newStudent where living='Yes'";
            DataSet ds = fs.GetData(query);
            DataGridView.DataSource = ds.Tables[0];
        }
    }
}
