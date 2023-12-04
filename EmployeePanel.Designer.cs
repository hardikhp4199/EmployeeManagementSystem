namespace EmployeeManagementSystem
{
    partial class EmployeePanel
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
            this.task_completed = new System.Windows.Forms.Label();
            this.task_completed_count = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.holiday_count = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.task_pending_count = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // task_completed
            // 
            this.task_completed.AutoSize = true;
            this.task_completed.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.task_completed.ForeColor = System.Drawing.Color.White;
            this.task_completed.Location = new System.Drawing.Point(194, 16);
            this.task_completed.Name = "task_completed";
            this.task_completed.Size = new System.Drawing.Size(34, 36);
            this.task_completed.TabIndex = 4;
            this.task_completed.Text = "0";
            // 
            // task_completed_count
            // 
            this.task_completed_count.AutoSize = true;
            this.task_completed_count.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.task_completed_count.ForeColor = System.Drawing.Color.White;
            this.task_completed_count.Location = new System.Drawing.Point(56, 151);
            this.task_completed_count.Name = "task_completed_count";
            this.task_completed_count.Size = new System.Drawing.Size(153, 22);
            this.task_completed_count.TabIndex = 3;
            this.task_completed_count.Text = "Task Completed";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(178)))), ((int)(((byte)(156)))));
            this.panel5.Controls.Add(this.pictureBox2);
            this.panel5.Controls.Add(this.task_completed);
            this.panel5.Controls.Add(this.task_completed_count);
            this.panel5.Location = new System.Drawing.Point(509, 41);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(248, 186);
            this.panel5.TabIndex = 2;
            // 
            // holiday_count
            // 
            this.holiday_count.AutoSize = true;
            this.holiday_count.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.holiday_count.ForeColor = System.Drawing.Color.White;
            this.holiday_count.Location = new System.Drawing.Point(211, 16);
            this.holiday_count.Name = "holiday_count";
            this.holiday_count.Size = new System.Drawing.Size(34, 36);
            this.holiday_count.TabIndex = 5;
            this.holiday_count.Text = "0";
            this.holiday_count.Click += new System.EventHandler(this.holiday_count_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(84, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Holidays";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(178)))), ((int)(((byte)(156)))));
            this.panel6.Controls.Add(this.pictureBox3);
            this.panel6.Controls.Add(this.holiday_count);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Location = new System.Drawing.Point(803, 41);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(248, 186);
            this.panel6.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Location = new System.Drawing.Point(3, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1226, 263);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(178)))), ((int)(((byte)(156)))));
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Controls.Add(this.task_pending_count);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(210, 41);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(248, 186);
            this.panel4.TabIndex = 1;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // task_pending_count
            // 
            this.task_pending_count.AutoSize = true;
            this.task_pending_count.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.task_pending_count.ForeColor = System.Drawing.Color.White;
            this.task_pending_count.Location = new System.Drawing.Point(196, 16);
            this.task_pending_count.Name = "task_pending_count";
            this.task_pending_count.Size = new System.Drawing.Size(34, 36);
            this.task_pending_count.TabIndex = 3;
            this.task_pending_count.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(59, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Task Pending";
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(3, 295);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1226, 366);
            this.panel2.TabIndex = 3;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::EmployeeManagementSystem.Properties.Resources.task;
            this.pictureBox1.Location = new System.Drawing.Point(30, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 95);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = global::EmployeeManagementSystem.Properties.Resources.task;
            this.pictureBox2.Location = new System.Drawing.Point(34, 35);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(90, 95);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Image = global::EmployeeManagementSystem.Properties.Resources.Holiday;
            this.pictureBox3.Location = new System.Drawing.Point(33, 35);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(90, 95);
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // EmployeePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 673);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmployeePanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmployeePanel";
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label task_completed;
        private System.Windows.Forms.Label task_completed_count;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label holiday_count;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label task_pending_count;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}