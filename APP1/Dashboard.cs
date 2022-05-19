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
        private static Dashboard d;
        public Dashboard()
        {
            InitializeComponent();
          
        }

       

        private void closeallforms()
        {
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                if (Application.OpenForms[i].Name != "Dashboard" && Application.OpenForms[i].Name != "LogIn")
                    Application.OpenForms[i].Close();
            }
        }

        private void btnroom_Click(object sender, EventArgs e)
        {
           
            loadform(new AddNewRoom(this));
            mainpanel.Visible = true;
        }

        private void btnnewstudent_Click(object sender, EventArgs e)
        {
          
            loadform(new NewStudent(this));
            mainpanel.Visible = true;
        }

        private void btnupddelstudent_Click(object sender, EventArgs e)
        {
        
            loadform(new UpdateDeleteStudent(this));
            mainpanel.Visible = true;
        }

        private void btnstudentfees_Click(object sender, EventArgs e)
        {
          
            loadform(new StudentFees(this));
            mainpanel.Visible = true;
        }

        private void btnstudentliving_Click(object sender, EventArgs e)
        {
           
            loadform(new AllStudentsLiving(this));
            mainpanel.Visible = true;
        }

        private void btnleavedstudent_Click(object sender, EventArgs e)
        {
            
           
            loadform(new LeavedStudents(this));
            mainpanel.Visible = true;
        }

        public void func()
        {
            mainpanel.Visible = false;
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

        private void loadform(object form)
        {
            if (this.mainpanel.Controls.Count > 0)
                this.mainpanel.Controls.RemoveAt(0);
            Form f = form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(f);
            this.mainpanel.Tag = f;
            f.Show();
        }

        
        private void btnlogout_Click(object sender, EventArgs e)
        {
            closeallforms();
            this.Hide();
            LogIn ls = new LogIn(false);
            ls.Show();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnmaximize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnminimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnnewemp_Click(object sender, EventArgs e)
        {
            loadform(new NewEmployee(this));
            mainpanel.Visible = true;
        }
    }
}
