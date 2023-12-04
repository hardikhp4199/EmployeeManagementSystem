namespace EmployeeManagementSystem
{
    partial class AdminDashboard
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
            System.Windows.Forms.Label label4;
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.task_count = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.project_count = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.employee_count = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dep_count = new System.Windows.Forms.Label();
            this.dep_count_label = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.taskreport = new System.Windows.Forms.Button();
            this.projectreport = new System.Windows.Forms.Button();
            label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(156)))), ((int)(((byte)(60)))));
            label4.Location = new System.Drawing.Point(42, 29);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(130, 40);
            label4.TabIndex = 3;
            label4.Text = "Report";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1226, 263);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(178)))), ((int)(((byte)(156)))));
            this.panel6.Controls.Add(this.task_count);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Controls.Add(this.pictureBox4);
            this.panel6.Location = new System.Drawing.Point(929, 41);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(248, 186);
            this.panel6.TabIndex = 3;
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
            // 
            // task_count
            // 
            this.task_count.AutoSize = true;
            this.task_count.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.task_count.ForeColor = System.Drawing.Color.White;
            this.task_count.Location = new System.Drawing.Point(189, 12);
            this.task_count.Name = "task_count";
            this.task_count.Size = new System.Drawing.Size(34, 36);
            this.task_count.TabIndex = 5;
            this.task_count.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(71, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Task Count";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::EmployeeManagementSystem.Properties.Resources.task;
            this.pictureBox4.Location = new System.Drawing.Point(22, 53);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(90, 95);
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(178)))), ((int)(((byte)(156)))));
            this.panel5.Controls.Add(this.project_count);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.pictureBox3);
            this.panel5.Location = new System.Drawing.Point(635, 41);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(248, 186);
            this.panel5.TabIndex = 2;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // project_count
            // 
            this.project_count.AutoSize = true;
            this.project_count.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.project_count.ForeColor = System.Drawing.Color.White;
            this.project_count.Location = new System.Drawing.Point(186, 12);
            this.project_count.Name = "project_count";
            this.project_count.Size = new System.Drawing.Size(34, 36);
            this.project_count.TabIndex = 4;
            this.project_count.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(61, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Project Count";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::EmployeeManagementSystem.Properties.Resources.project;
            this.pictureBox3.Location = new System.Drawing.Point(22, 53);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(90, 95);
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(178)))), ((int)(((byte)(156)))));
            this.panel4.Controls.Add(this.employee_count);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Location = new System.Drawing.Point(336, 41);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(248, 186);
            this.panel4.TabIndex = 1;
            // 
            // employee_count
            // 
            this.employee_count.AutoSize = true;
            this.employee_count.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employee_count.ForeColor = System.Drawing.Color.White;
            this.employee_count.Location = new System.Drawing.Point(187, 12);
            this.employee_count.Name = "employee_count";
            this.employee_count.Size = new System.Drawing.Size(34, 36);
            this.employee_count.TabIndex = 3;
            this.employee_count.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(38, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Employee Count";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::EmployeeManagementSystem.Properties.Resources.employee;
            this.pictureBox2.Location = new System.Drawing.Point(25, 53);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(90, 95);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(178)))), ((int)(((byte)(156)))));
            this.panel3.Controls.Add(this.dep_count);
            this.panel3.Controls.Add(this.dep_count_label);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(46, 41);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(248, 186);
            this.panel3.TabIndex = 0;
            // 
            // dep_count
            // 
            this.dep_count.AutoSize = true;
            this.dep_count.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dep_count.ForeColor = System.Drawing.Color.White;
            this.dep_count.Location = new System.Drawing.Point(189, 12);
            this.dep_count.Name = "dep_count";
            this.dep_count.Size = new System.Drawing.Size(34, 36);
            this.dep_count.TabIndex = 2;
            this.dep_count.Text = "0";
            // 
            // dep_count_label
            // 
            this.dep_count_label.AutoSize = true;
            this.dep_count_label.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dep_count_label.ForeColor = System.Drawing.Color.White;
            this.dep_count_label.Location = new System.Drawing.Point(28, 151);
            this.dep_count_label.Name = "dep_count_label";
            this.dep_count_label.Size = new System.Drawing.Size(178, 22);
            this.dep_count_label.TabIndex = 1;
            this.dep_count_label.Text = "Department Count";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EmployeeManagementSystem.Properties.Resources.Department;
            this.pictureBox1.Location = new System.Drawing.Point(22, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 95);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.taskreport);
            this.panel2.Controls.Add(label4);
            this.panel2.Controls.Add(this.projectreport);
            this.panel2.Location = new System.Drawing.Point(12, 295);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1226, 366);
            this.panel2.TabIndex = 1;
            // 
            // taskreport
            // 
            this.taskreport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(156)))), ((int)(((byte)(60)))));
            this.taskreport.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(156)))), ((int)(((byte)(60)))));
            this.taskreport.FlatAppearance.BorderSize = 0;
            this.taskreport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.taskreport.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskreport.ForeColor = System.Drawing.Color.White;
            this.taskreport.Location = new System.Drawing.Point(264, 98);
            this.taskreport.Name = "taskreport";
            this.taskreport.Size = new System.Drawing.Size(169, 42);
            this.taskreport.TabIndex = 27;
            this.taskreport.Text = "Task Report";
            this.taskreport.UseVisualStyleBackColor = false;
            this.taskreport.Click += new System.EventHandler(this.taskreport_Click);
            // 
            // projectreport
            // 
            this.projectreport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(156)))), ((int)(((byte)(60)))));
            this.projectreport.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(156)))), ((int)(((byte)(60)))));
            this.projectreport.FlatAppearance.BorderSize = 0;
            this.projectreport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.projectreport.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectreport.ForeColor = System.Drawing.Color.White;
            this.projectreport.Location = new System.Drawing.Point(46, 98);
            this.projectreport.Name = "projectreport";
            this.projectreport.Size = new System.Drawing.Size(169, 42);
            this.projectreport.TabIndex = 26;
            this.projectreport.Text = "Project Report";
            this.projectreport.UseVisualStyleBackColor = false;
            this.projectreport.Click += new System.EventHandler(this.projectreport_Click);
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 720);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminDashboard";
            this.Text = "AdminDashboard";
            this.Load += new System.EventHandler(this.AdminDashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label dep_count_label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label dep_count;
        private System.Windows.Forms.Label employee_count;
        private System.Windows.Forms.Label project_count;
        private System.Windows.Forms.Label task_count;
        private System.Windows.Forms.Button projectreport;
        private System.Windows.Forms.Button taskreport;
    }
}