namespace EmployeeManagementSystem
{
    partial class EmployeeMaster
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
            this.main_panel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.top_panel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.holidaylist_btn = new System.Windows.Forms.Button();
            this.task_btn = new System.Windows.Forms.Button();
            this.bottom_panel = new System.Windows.Forms.Panel();
            this.dashboard_btn = new System.Windows.Forms.Button();
            this.welcome_username = new System.Windows.Forms.Label();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.emp_exit_btn = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.employee_btn = new System.Windows.Forms.Button();
            this.left_panel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.top_panel.SuspendLayout();
            this.bottom_panel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.left_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // main_panel
            // 
            this.main_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main_panel.Location = new System.Drawing.Point(287, 40);
            this.main_panel.Name = "main_panel";
            this.main_panel.Size = new System.Drawing.Size(1413, 720);
            this.main_panel.TabIndex = 9;
            this.main_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.main_panel_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(464, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(487, 36);
            this.label3.TabIndex = 3;
            this.label3.Text = "Employee Management System";
            // 
            // top_panel
            // 
            this.top_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(178)))), ((int)(((byte)(156)))));
            this.top_panel.Controls.Add(this.label3);
            this.top_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.top_panel.Location = new System.Drawing.Point(287, 0);
            this.top_panel.Name = "top_panel";
            this.top_panel.Size = new System.Drawing.Size(1413, 40);
            this.top_panel.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(359, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(659, 36);
            this.label2.TabIndex = 2;
            this.label2.Text = "Copyright © 2023 EMS. All rights reserved.";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(156)))), ((int)(((byte)(60)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(156)))), ((int)(((byte)(60)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(18, 538);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(246, 40);
            this.button1.TabIndex = 14;
            this.button1.Text = "LogOut";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // holidaylist_btn
            // 
            this.holidaylist_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(156)))), ((int)(((byte)(60)))));
            this.holidaylist_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(156)))), ((int)(((byte)(60)))));
            this.holidaylist_btn.FlatAppearance.BorderSize = 0;
            this.holidaylist_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.holidaylist_btn.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.holidaylist_btn.ForeColor = System.Drawing.Color.White;
            this.holidaylist_btn.Location = new System.Drawing.Point(18, 426);
            this.holidaylist_btn.Name = "holidaylist_btn";
            this.holidaylist_btn.Size = new System.Drawing.Size(246, 40);
            this.holidaylist_btn.TabIndex = 12;
            this.holidaylist_btn.Text = "Holiday";
            this.holidaylist_btn.UseVisualStyleBackColor = false;
            this.holidaylist_btn.Click += new System.EventHandler(this.holidaylist_btn_Click);
            // 
            // task_btn
            // 
            this.task_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(156)))), ((int)(((byte)(60)))));
            this.task_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(156)))), ((int)(((byte)(60)))));
            this.task_btn.FlatAppearance.BorderSize = 0;
            this.task_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.task_btn.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.task_btn.ForeColor = System.Drawing.Color.White;
            this.task_btn.Location = new System.Drawing.Point(18, 367);
            this.task_btn.Name = "task_btn";
            this.task_btn.Size = new System.Drawing.Size(246, 40);
            this.task_btn.TabIndex = 11;
            this.task_btn.Text = "Task";
            this.task_btn.UseVisualStyleBackColor = false;
            this.task_btn.Click += new System.EventHandler(this.task_btn_Click);
            // 
            // bottom_panel
            // 
            this.bottom_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(178)))), ((int)(((byte)(156)))));
            this.bottom_panel.Controls.Add(this.label2);
            this.bottom_panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottom_panel.Location = new System.Drawing.Point(287, 760);
            this.bottom_panel.Name = "bottom_panel";
            this.bottom_panel.Size = new System.Drawing.Size(1413, 40);
            this.bottom_panel.TabIndex = 7;
            // 
            // dashboard_btn
            // 
            this.dashboard_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(156)))), ((int)(((byte)(60)))));
            this.dashboard_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(156)))), ((int)(((byte)(60)))));
            this.dashboard_btn.FlatAppearance.BorderSize = 0;
            this.dashboard_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashboard_btn.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboard_btn.ForeColor = System.Drawing.Color.White;
            this.dashboard_btn.Location = new System.Drawing.Point(18, 239);
            this.dashboard_btn.Name = "dashboard_btn";
            this.dashboard_btn.Size = new System.Drawing.Size(246, 40);
            this.dashboard_btn.TabIndex = 2;
            this.dashboard_btn.Text = "Dashboard";
            this.dashboard_btn.UseVisualStyleBackColor = false;
            this.dashboard_btn.Click += new System.EventHandler(this.dashboard_btn_Click);
            // 
            // welcome_username
            // 
            this.welcome_username.AutoSize = true;
            this.welcome_username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(178)))), ((int)(((byte)(156)))));
            this.welcome_username.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcome_username.ForeColor = System.Drawing.Color.White;
            this.welcome_username.Location = new System.Drawing.Point(32, 183);
            this.welcome_username.Name = "welcome_username";
            this.welcome_username.Size = new System.Drawing.Size(232, 36);
            this.welcome_username.TabIndex = 2;
            this.welcome_username.Text = "Welcome User";
            this.welcome_username.Click += new System.EventHandler(this.welcome_username_Click);
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // emp_exit_btn
            // 
            this.emp_exit_btn.AutoSize = true;
            this.emp_exit_btn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emp_exit_btn.ForeColor = System.Drawing.Color.White;
            this.emp_exit_btn.Location = new System.Drawing.Point(1664, 9);
            this.emp_exit_btn.Name = "emp_exit_btn";
            this.emp_exit_btn.Size = new System.Drawing.Size(24, 24);
            this.emp_exit_btn.TabIndex = 1;
            this.emp_exit_btn.Text = "X";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "SGG";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(0)))), ((int)(((byte)(97)))));
            this.panel1.Controls.Add(this.emp_exit_btn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(287, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1413, 0);
            this.panel1.TabIndex = 5;
            // 
            // employee_btn
            // 
            this.employee_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(156)))), ((int)(((byte)(60)))));
            this.employee_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(156)))), ((int)(((byte)(60)))));
            this.employee_btn.FlatAppearance.BorderSize = 0;
            this.employee_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.employee_btn.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employee_btn.ForeColor = System.Drawing.Color.White;
            this.employee_btn.Location = new System.Drawing.Point(18, 301);
            this.employee_btn.Name = "employee_btn";
            this.employee_btn.Size = new System.Drawing.Size(246, 40);
            this.employee_btn.TabIndex = 8;
            this.employee_btn.Text = "My Profile";
            this.employee_btn.UseVisualStyleBackColor = false;
            this.employee_btn.Click += new System.EventHandler(this.employee_btn_Click);
            // 
            // left_panel
            // 
            this.left_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(178)))), ((int)(((byte)(156)))));
            this.left_panel.Controls.Add(this.button2);
            this.left_panel.Controls.Add(this.button1);
            this.left_panel.Controls.Add(this.holidaylist_btn);
            this.left_panel.Controls.Add(this.task_btn);
            this.left_panel.Controls.Add(this.employee_btn);
            this.left_panel.Controls.Add(this.dashboard_btn);
            this.left_panel.Controls.Add(this.welcome_username);
            this.left_panel.Controls.Add(this.pictureBox1);
            this.left_panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.left_panel.Location = new System.Drawing.Point(0, 0);
            this.left_panel.Name = "left_panel";
            this.left_panel.Size = new System.Drawing.Size(287, 800);
            this.left_panel.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pictureBox1.Image = global::EmployeeManagementSystem.Properties.Resources.logo_100_100;
            this.pictureBox1.Location = new System.Drawing.Point(76, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 119);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(156)))), ((int)(((byte)(60)))));
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(156)))), ((int)(((byte)(60)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(18, 482);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(246, 40);
            this.button2.TabIndex = 15;
            this.button2.Text = "Reset Password";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // EmployeeMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1700, 800);
            this.Controls.Add(this.main_panel);
            this.Controls.Add(this.top_panel);
            this.Controls.Add(this.bottom_panel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.left_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmployeeMaster";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmployeeMaster";
            this.top_panel.ResumeLayout(false);
            this.top_panel.PerformLayout();
            this.bottom_panel.ResumeLayout(false);
            this.bottom_panel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.left_panel.ResumeLayout(false);
            this.left_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel main_panel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel top_panel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button holidaylist_btn;
        private System.Windows.Forms.Button task_btn;
        private System.Windows.Forms.Panel bottom_panel;
        private System.Windows.Forms.Button dashboard_btn;
        private System.Windows.Forms.Label welcome_username;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private System.Windows.Forms.Label emp_exit_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button employee_btn;
        private System.Windows.Forms.Panel left_panel;
        private System.Windows.Forms.Button button2;
    }
}