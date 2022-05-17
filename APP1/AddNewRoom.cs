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
    public partial class AddNewRoom : Form
    {
        function fn=new function();
        String query;

        public AddNewRoom()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddNewRoom_Load(object sender, EventArgs e)
        {
            this.Location = new Point(350,170);
            labelroom1.Visible = false;
            labelroom2.Visible = false;

            query = "select * from rooms";
            DataSet ds = fn.GetData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void btnaddroom_Click(object sender, EventArgs e)
        {
            query = "select * from rooms where roomNo='"+txtroomno1.Text+"'";
            DataSet ds = fn.GetData(query);
            if (ds.Tables[0].Rows.Count == 0)
            {
                string status;
                if (CheckBox1.Checked)
                {
                    status = "Yes";
                }
                else
                    status = "No";
                labelroom1.Visible=false;
                query ="insert into rooms(roomNo,roomStatus) values("+txtroomno1.Text+",'"+status+"')";
                fn.setdata(query,"Room Added.");
                AddNewRoom_Load(this,null);
            }
            else
            {
                labelroom1.Text = "Room Already Exist";
                labelroom1.Visible = true;
            }
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            query = "select * from rooms where roomNo='" + txtroomno2.Text + "'";
            DataSet ds = fn.GetData(query);
            if (ds.Tables[0].Rows.Count == 0)
            {
                labelroom2.Text = "No Room Exist";
                labelroom1.Visible = true;
                CheckBox2.Checked = false;
            }
            else
            {
                labelroom2.Text = "Room Found";
                labelroom2.Visible = true;
                if(ds.Tables[0].Rows[0][1].ToString() == "Yes")
                {
                    CheckBox2.Checked = true;
                }else
                    CheckBox2.Checked=false;
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            string status;
            if (CheckBox2.Checked)
            {
                status = "Yes";
            }
            else
            {
                status = "No";
            }
            query = "update rooms set roomStatus='" + status + "'where roomNo =" + txtroomno2.Text + "";
            fn.setdata(query, "Details updated");
            AddNewRoom_Load(this, null);
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (labelroom2.Text == "Room Found")
            {
                query = "delete from rooms where roomNo=" + txtroomno2.Text + "";
                fn.setdata(query, "Room details deleted.");
                AddNewRoom_Load(this, null);
            }
            else
            {
                MessageBox.Show("Trying to delete which doesn't exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtroomno1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (char.IsDigit(ch) == true)
                e.Handled = false;
            else if (ch == 8)
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void txtroomno2_KeyPress(object sender, KeyPressEventArgs e)
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
