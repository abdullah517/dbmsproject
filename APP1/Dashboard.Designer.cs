﻿
namespace APP1
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.hmslabel = new System.Windows.Forms.Label();
            this.btnmanageroom = new Guna.UI2.WinForms.Guna2Button();
            this.new_stu_btn = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdateDeleteStudent = new Guna.UI2.WinForms.Guna2Button();
            this.btnFees = new Guna.UI2.WinForms.Guna2Button();
            this.btnAllStudents = new Guna.UI2.WinForms.Guna2Button();
            this.btnleavedStudents = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button7 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button8 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button9 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button10 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button11 = new Guna.UI2.WinForms.Guna2Button();
            this.btnexit = new Guna.UI2.WinForms.Guna2Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnlogout = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // hmslabel
            // 
            this.hmslabel.AutoSize = true;
            this.hmslabel.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hmslabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.hmslabel.Location = new System.Drawing.Point(264, 12);
            this.hmslabel.Name = "hmslabel";
            this.hmslabel.Size = new System.Drawing.Size(788, 66);
            this.hmslabel.TabIndex = 2;
            this.hmslabel.Text = "Hostel Management System";
            // 
            // btnmanageroom
            // 
            this.btnmanageroom.BackColor = System.Drawing.Color.White;
            this.btnmanageroom.BorderRadius = 19;
            this.btnmanageroom.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnmanageroom.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnmanageroom.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(48)))), ((int)(((byte)(103)))));
            this.btnmanageroom.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnmanageroom.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmanageroom.ForeColor = System.Drawing.Color.White;
            this.btnmanageroom.Image = ((System.Drawing.Image)(resources.GetObject("btnmanageroom.Image")));
            this.btnmanageroom.Location = new System.Drawing.Point(12, 72);
            this.btnmanageroom.Name = "btnmanageroom";
            this.btnmanageroom.Size = new System.Drawing.Size(180, 40);
            this.btnmanageroom.TabIndex = 3;
            this.btnmanageroom.Text = "Rooms";
            this.btnmanageroom.Click += new System.EventHandler(this.btnmanageroom_Click);
            // 
            // new_stu_btn
            // 
            this.new_stu_btn.BackColor = System.Drawing.Color.White;
            this.new_stu_btn.BorderRadius = 19;
            this.new_stu_btn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.new_stu_btn.CheckedState.FillColor = System.Drawing.Color.White;
            this.new_stu_btn.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(48)))), ((int)(((byte)(103)))));
            this.new_stu_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.new_stu_btn.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.new_stu_btn.ForeColor = System.Drawing.Color.White;
            this.new_stu_btn.Image = ((System.Drawing.Image)(resources.GetObject("new_stu_btn.Image")));
            this.new_stu_btn.Location = new System.Drawing.Point(12, 118);
            this.new_stu_btn.Name = "new_stu_btn";
            this.new_stu_btn.Size = new System.Drawing.Size(180, 40);
            this.new_stu_btn.TabIndex = 4;
            this.new_stu_btn.Text = "New Student";
            this.new_stu_btn.Click += new System.EventHandler(this.new_stu_btn_Click);
            // 
            // btnUpdateDeleteStudent
            // 
            this.btnUpdateDeleteStudent.BackColor = System.Drawing.Color.White;
            this.btnUpdateDeleteStudent.BorderRadius = 19;
            this.btnUpdateDeleteStudent.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnUpdateDeleteStudent.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnUpdateDeleteStudent.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(48)))), ((int)(((byte)(103)))));
            this.btnUpdateDeleteStudent.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnUpdateDeleteStudent.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateDeleteStudent.ForeColor = System.Drawing.Color.White;
            this.btnUpdateDeleteStudent.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateDeleteStudent.Image")));
            this.btnUpdateDeleteStudent.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnUpdateDeleteStudent.ImageSize = new System.Drawing.Size(18, 20);
            this.btnUpdateDeleteStudent.Location = new System.Drawing.Point(12, 164);
            this.btnUpdateDeleteStudent.Name = "btnUpdateDeleteStudent";
            this.btnUpdateDeleteStudent.Size = new System.Drawing.Size(180, 40);
            this.btnUpdateDeleteStudent.TabIndex = 5;
            this.btnUpdateDeleteStudent.Text = "Update Students";
            this.btnUpdateDeleteStudent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnUpdateDeleteStudent.UseWaitCursor = true;
            this.btnUpdateDeleteStudent.Click += new System.EventHandler(this.btnUpdateDeleteStudent_Click);
            // 
            // btnFees
            // 
            this.btnFees.BackColor = System.Drawing.Color.White;
            this.btnFees.BorderRadius = 19;
            this.btnFees.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnFees.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnFees.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(48)))), ((int)(((byte)(103)))));
            this.btnFees.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnFees.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFees.ForeColor = System.Drawing.Color.White;
            this.btnFees.Image = ((System.Drawing.Image)(resources.GetObject("btnFees.Image")));
            this.btnFees.Location = new System.Drawing.Point(12, 210);
            this.btnFees.Name = "btnFees";
            this.btnFees.Size = new System.Drawing.Size(180, 40);
            this.btnFees.TabIndex = 6;
            this.btnFees.Text = "Student Fees";
            this.btnFees.Click += new System.EventHandler(this.btnFees_Click);
            // 
            // btnAllStudents
            // 
            this.btnAllStudents.BackColor = System.Drawing.Color.White;
            this.btnAllStudents.BorderRadius = 19;
            this.btnAllStudents.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnAllStudents.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnAllStudents.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(48)))), ((int)(((byte)(103)))));
            this.btnAllStudents.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnAllStudents.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllStudents.ForeColor = System.Drawing.Color.White;
            this.btnAllStudents.Image = ((System.Drawing.Image)(resources.GetObject("btnAllStudents.Image")));
            this.btnAllStudents.Location = new System.Drawing.Point(12, 256);
            this.btnAllStudents.Name = "btnAllStudents";
            this.btnAllStudents.Size = new System.Drawing.Size(180, 40);
            this.btnAllStudents.TabIndex = 7;
            this.btnAllStudents.Text = "Total Students";
            this.btnAllStudents.Click += new System.EventHandler(this.btnAllStudents_Click);
            // 
            // btnleavedStudents
            // 
            this.btnleavedStudents.BackColor = System.Drawing.Color.White;
            this.btnleavedStudents.BorderRadius = 19;
            this.btnleavedStudents.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnleavedStudents.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnleavedStudents.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(48)))), ((int)(((byte)(103)))));
            this.btnleavedStudents.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnleavedStudents.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnleavedStudents.ForeColor = System.Drawing.Color.White;
            this.btnleavedStudents.Image = ((System.Drawing.Image)(resources.GetObject("btnleavedStudents.Image")));
            this.btnleavedStudents.Location = new System.Drawing.Point(12, 302);
            this.btnleavedStudents.Name = "btnleavedStudents";
            this.btnleavedStudents.Size = new System.Drawing.Size(180, 40);
            this.btnleavedStudents.TabIndex = 8;
            this.btnleavedStudents.Text = "On Leave";
            this.btnleavedStudents.Click += new System.EventHandler(this.btnleavedStudents_Click);
            // 
            // guna2Button7
            // 
            this.guna2Button7.BackColor = System.Drawing.Color.White;
            this.guna2Button7.BorderRadius = 19;
            this.guna2Button7.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2Button7.CheckedState.FillColor = System.Drawing.Color.White;
            this.guna2Button7.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(48)))), ((int)(((byte)(103)))));
            this.guna2Button7.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.guna2Button7.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button7.ForeColor = System.Drawing.Color.White;
            this.guna2Button7.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button7.Image")));
            this.guna2Button7.Location = new System.Drawing.Point(12, 348);
            this.guna2Button7.Name = "guna2Button7";
            this.guna2Button7.Size = new System.Drawing.Size(180, 40);
            this.guna2Button7.TabIndex = 9;
            this.guna2Button7.Text = "New Employee";
            // 
            // guna2Button8
            // 
            this.guna2Button8.BackColor = System.Drawing.Color.White;
            this.guna2Button8.BorderRadius = 19;
            this.guna2Button8.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2Button8.CheckedState.FillColor = System.Drawing.Color.White;
            this.guna2Button8.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(48)))), ((int)(((byte)(103)))));
            this.guna2Button8.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.guna2Button8.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button8.ForeColor = System.Drawing.Color.White;
            this.guna2Button8.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button8.Image")));
            this.guna2Button8.Location = new System.Drawing.Point(12, 394);
            this.guna2Button8.Name = "guna2Button8";
            this.guna2Button8.Size = new System.Drawing.Size(180, 40);
            this.guna2Button8.TabIndex = 10;
            this.guna2Button8.Text = "Update Rec";
            // 
            // guna2Button9
            // 
            this.guna2Button9.BackColor = System.Drawing.Color.White;
            this.guna2Button9.BorderRadius = 19;
            this.guna2Button9.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2Button9.CheckedState.FillColor = System.Drawing.Color.White;
            this.guna2Button9.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(48)))), ((int)(((byte)(103)))));
            this.guna2Button9.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.guna2Button9.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button9.ForeColor = System.Drawing.Color.White;
            this.guna2Button9.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button9.Image")));
            this.guna2Button9.Location = new System.Drawing.Point(12, 440);
            this.guna2Button9.Name = "guna2Button9";
            this.guna2Button9.Size = new System.Drawing.Size(180, 40);
            this.guna2Button9.TabIndex = 11;
            this.guna2Button9.Text = "Employee Pay";
            // 
            // guna2Button10
            // 
            this.guna2Button10.BackColor = System.Drawing.Color.White;
            this.guna2Button10.BorderRadius = 19;
            this.guna2Button10.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2Button10.CheckedState.FillColor = System.Drawing.Color.White;
            this.guna2Button10.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(48)))), ((int)(((byte)(103)))));
            this.guna2Button10.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.guna2Button10.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button10.ForeColor = System.Drawing.Color.White;
            this.guna2Button10.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button10.Image")));
            this.guna2Button10.Location = new System.Drawing.Point(12, 486);
            this.guna2Button10.Name = "guna2Button10";
            this.guna2Button10.Size = new System.Drawing.Size(180, 40);
            this.guna2Button10.TabIndex = 12;
            this.guna2Button10.Text = "All Employee ";
            // 
            // guna2Button11
            // 
            this.guna2Button11.BackColor = System.Drawing.Color.White;
            this.guna2Button11.BorderRadius = 19;
            this.guna2Button11.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2Button11.CheckedState.FillColor = System.Drawing.Color.White;
            this.guna2Button11.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(48)))), ((int)(((byte)(103)))));
            this.guna2Button11.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.guna2Button11.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button11.ForeColor = System.Drawing.Color.White;
            this.guna2Button11.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button11.Image")));
            this.guna2Button11.Location = new System.Drawing.Point(12, 532);
            this.guna2Button11.Name = "guna2Button11";
            this.guna2Button11.Size = new System.Drawing.Size(180, 40);
            this.guna2Button11.TabIndex = 13;
            this.guna2Button11.Text = "On Leave";
            // 
            // btnexit
            // 
            this.btnexit.BorderColor = System.Drawing.Color.White;
            this.btnexit.BorderRadius = 22;
            this.btnexit.BorderThickness = 1;
            this.btnexit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnexit.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.ForeColor = System.Drawing.Color.White;
            this.btnexit.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnexit.ImageSize = new System.Drawing.Size(35, 35);
            this.btnexit.Location = new System.Drawing.Point(1128, 12);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(46, 45);
            this.btnexit.TabIndex = 15;
            this.btnexit.Text = "X";
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 900;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnlogout
            // 
            this.btnlogout.BackColor = System.Drawing.Color.White;
            this.btnlogout.BorderRadius = 16;
            this.btnlogout.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnlogout.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnlogout.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(48)))), ((int)(((byte)(103)))));
            this.btnlogout.FillColor = System.Drawing.Color.DarkRed;
            this.btnlogout.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.btnlogout.ForeColor = System.Drawing.Color.White;
            this.btnlogout.Image = ((System.Drawing.Image)(resources.GetObject("btnlogout.Image")));
            this.btnlogout.Location = new System.Drawing.Point(12, 578);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(180, 40);
            this.btnlogout.TabIndex = 16;
            this.btnlogout.Text = "LogOut";
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click_1);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1201, 666);
            this.Controls.Add(this.btnlogout);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.guna2Button11);
            this.Controls.Add(this.guna2Button10);
            this.Controls.Add(this.guna2Button9);
            this.Controls.Add(this.guna2Button8);
            this.Controls.Add(this.guna2Button7);
            this.Controls.Add(this.btnleavedStudents);
            this.Controls.Add(this.btnAllStudents);
            this.Controls.Add(this.btnFees);
            this.Controls.Add(this.btnUpdateDeleteStudent);
            this.Controls.Add(this.new_stu_btn);
            this.Controls.Add(this.btnmanageroom);
            this.Controls.Add(this.hmslabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.Text = "66";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label hmslabel;
        private Guna.UI2.WinForms.Guna2Button btnmanageroom;
        private Guna.UI2.WinForms.Guna2Button new_stu_btn;
        private Guna.UI2.WinForms.Guna2Button btnUpdateDeleteStudent;
        private Guna.UI2.WinForms.Guna2Button btnFees;
        private Guna.UI2.WinForms.Guna2Button btnAllStudents;
        private Guna.UI2.WinForms.Guna2Button btnleavedStudents;
        private Guna.UI2.WinForms.Guna2Button guna2Button7;
        private Guna.UI2.WinForms.Guna2Button guna2Button8;
        private Guna.UI2.WinForms.Guna2Button guna2Button9;
        private Guna.UI2.WinForms.Guna2Button guna2Button10;
        private Guna.UI2.WinForms.Guna2Button guna2Button11;
        private Guna.UI2.WinForms.Guna2Button btnexit;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2Button btnlogout;
    }
}