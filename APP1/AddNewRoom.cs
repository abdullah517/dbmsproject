﻿using System;
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
        }

       
    }
}
