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
    public partial class Dashboard : Form
    {

        private void closeallforms()
        {
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                if (Application.OpenForms[i].Name != "Dashboard"&& Application.OpenForms[i].Name != "LogIn")
                    Application.OpenForms[i].Close();
            }
        }
        public Dashboard()
        {
            InitializeComponent();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        Boolean labelvisible = true;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (labelvisible == true)
            {
                hmslabel.Visible = true;
                labelvisible = false;
            }
            else
            {
                hmslabel.Visible = false;
                labelvisible = true;
            }
        }

        private void btnmanageroom_Click(object sender, EventArgs e)
        {
            closeallforms();
            AddNewRoom anr = new AddNewRoom();
            anr.Show();
        }

        private void new_stu_btn_Click(object sender, EventArgs e)
        {
            closeallforms();
            NewStudent ns = new NewStudent();
            ns.Show();
        }

        private void btnFees_Click(object sender, EventArgs e)
        {
            closeallforms();
            StudentFees sf = new StudentFees();
            sf.Show();
        }

        private void btnUpdateDeleteStudent_Click(object sender, EventArgs e)
        {
            closeallforms();
            UpdateDeleteStudent uds = new UpdateDeleteStudent();
            uds.Show();
        }

        private void btnAllStudents_Click(object sender, EventArgs e)
        {
            closeallforms();
            AllStudentsLiving asl = new AllStudentsLiving();
            asl.Show();
        }

        private void btnleavedStudents_Click(object sender, EventArgs e)
        {
            closeallforms();
            LeavedStudents ls = new LeavedStudents();
            ls.Show();
        }

        private void btnlogout_Click_1(object sender, EventArgs e)
        {
            closeallforms();
            this.Hide();
            LogIn ls = new LogIn(false);
            ls.Show();
        }
    }
}
