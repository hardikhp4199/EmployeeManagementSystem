namespace EmployeeManagementSystem
{
    partial class Task
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.taskGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.task_user = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.task_id = new System.Windows.Forms.TextBox();
            this.task_project = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.task_reset_btn = new System.Windows.Forms.Button();
            this.task_up_btn = new System.Windows.Forms.Button();
            this.task_remove_btn = new System.Windows.Forms.Button();
            this.task_status = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.task_add_btn = new System.Windows.Forms.Button();
            this.task_desc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.task_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.taskGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.taskGridView);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(25, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1174, 353);
            this.panel2.TabIndex = 3;
            // 
            // taskGridView
            // 
            this.taskGridView.AllowUserToAddRows = false;
            this.taskGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(156)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.taskGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.taskGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.taskGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.taskGridView.EnableHeadersVisualStyles = false;
            this.taskGridView.Location = new System.Drawing.Point(19, 78);
            this.taskGridView.Name = "taskGridView";
            this.taskGridView.ReadOnly = true;
            this.taskGridView.RowHeadersVisible = false;
            this.taskGridView.RowHeadersWidth = 51;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskGridView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.taskGridView.RowTemplate.Height = 24;
            this.taskGridView.Size = new System.Drawing.Size(1136, 255);
            this.taskGridView.TabIndex = 1;
            this.taskGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.taskGridView_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(156)))), ((int)(((byte)(60)))));
            this.label1.Location = new System.Drawing.Point(29, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tasks";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.task_user);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.task_id);
            this.panel1.Controls.Add(this.task_project);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.task_reset_btn);
            this.panel1.Controls.Add(this.task_up_btn);
            this.panel1.Controls.Add(this.task_remove_btn);
            this.panel1.Controls.Add(this.task_status);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.task_add_btn);
            this.panel1.Controls.Add(this.task_desc);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.task_name);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(25, 371);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1174, 311);
            this.panel1.TabIndex = 2;
            // 
            // task_user
            // 
            this.task_user.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.task_user.FormattingEnabled = true;
            this.task_user.Location = new System.Drawing.Point(452, 149);
            this.task_user.Name = "task_user";
            this.task_user.Size = new System.Drawing.Size(350, 36);
            this.task_user.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(447, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 28);
            this.label4.TabIndex = 17;
            this.label4.Text = "User";
            // 
            // task_id
            // 
            this.task_id.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.task_id.Location = new System.Drawing.Point(808, 247);
            this.task_id.Name = "task_id";
            this.task_id.Size = new System.Drawing.Size(351, 35);
            this.task_id.TabIndex = 16;
            this.task_id.Visible = false;
            // 
            // task_project
            // 
            this.task_project.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.task_project.FormattingEnabled = true;
            this.task_project.Location = new System.Drawing.Point(452, 63);
            this.task_project.Name = "task_project";
            this.task_project.Size = new System.Drawing.Size(350, 36);
            this.task_project.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(447, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 28);
            this.label6.TabIndex = 14;
            this.label6.Text = "Project";
            // 
            // task_reset_btn
            // 
            this.task_reset_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(156)))), ((int)(((byte)(60)))));
            this.task_reset_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(156)))), ((int)(((byte)(60)))));
            this.task_reset_btn.FlatAppearance.BorderSize = 0;
            this.task_reset_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.task_reset_btn.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.task_reset_btn.ForeColor = System.Drawing.Color.White;
            this.task_reset_btn.Location = new System.Drawing.Point(1023, 172);
            this.task_reset_btn.Name = "task_reset_btn";
            this.task_reset_btn.Size = new System.Drawing.Size(129, 49);
            this.task_reset_btn.TabIndex = 13;
            this.task_reset_btn.Text = "Reset";
            this.task_reset_btn.UseVisualStyleBackColor = false;
            this.task_reset_btn.Click += new System.EventHandler(this.task_reset_btn_Click);
            // 
            // task_up_btn
            // 
            this.task_up_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(156)))), ((int)(((byte)(60)))));
            this.task_up_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(156)))), ((int)(((byte)(60)))));
            this.task_up_btn.FlatAppearance.BorderSize = 0;
            this.task_up_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.task_up_btn.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.task_up_btn.ForeColor = System.Drawing.Color.White;
            this.task_up_btn.Location = new System.Drawing.Point(1023, 95);
            this.task_up_btn.Name = "task_up_btn";
            this.task_up_btn.Size = new System.Drawing.Size(129, 51);
            this.task_up_btn.TabIndex = 12;
            this.task_up_btn.Text = "UPDATE";
            this.task_up_btn.UseVisualStyleBackColor = false;
            this.task_up_btn.Click += new System.EventHandler(this.task_up_btn_Click);
            // 
            // task_remove_btn
            // 
            this.task_remove_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(156)))), ((int)(((byte)(60)))));
            this.task_remove_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(156)))), ((int)(((byte)(60)))));
            this.task_remove_btn.FlatAppearance.BorderSize = 0;
            this.task_remove_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.task_remove_btn.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.task_remove_btn.ForeColor = System.Drawing.Color.White;
            this.task_remove_btn.Location = new System.Drawing.Point(839, 170);
            this.task_remove_btn.Name = "task_remove_btn";
            this.task_remove_btn.Size = new System.Drawing.Size(129, 51);
            this.task_remove_btn.TabIndex = 11;
            this.task_remove_btn.Text = "REMOVE";
            this.task_remove_btn.UseVisualStyleBackColor = false;
            this.task_remove_btn.Click += new System.EventHandler(this.task_remove_btn_Click);
            // 
            // task_status
            // 
            this.task_status.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.task_status.FormattingEnabled = true;
            this.task_status.Location = new System.Drawing.Point(452, 247);
            this.task_status.Name = "task_status";
            this.task_status.Size = new System.Drawing.Size(350, 36);
            this.task_status.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(447, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 28);
            this.label5.TabIndex = 9;
            this.label5.Text = "Status";
            // 
            // task_add_btn
            // 
            this.task_add_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(156)))), ((int)(((byte)(60)))));
            this.task_add_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(156)))), ((int)(((byte)(60)))));
            this.task_add_btn.FlatAppearance.BorderSize = 0;
            this.task_add_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.task_add_btn.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.task_add_btn.ForeColor = System.Drawing.Color.White;
            this.task_add_btn.Location = new System.Drawing.Point(839, 95);
            this.task_add_btn.Name = "task_add_btn";
            this.task_add_btn.Size = new System.Drawing.Size(129, 51);
            this.task_add_btn.TabIndex = 8;
            this.task_add_btn.Text = "ADD";
            this.task_add_btn.UseVisualStyleBackColor = false;
            this.task_add_btn.Click += new System.EventHandler(this.task_add_btn_Click);
            // 
            // task_desc
            // 
            this.task_desc.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.task_desc.Location = new System.Drawing.Point(34, 128);
            this.task_desc.Multiline = true;
            this.task_desc.Name = "task_desc";
            this.task_desc.Size = new System.Drawing.Size(351, 154);
            this.task_desc.TabIndex = 5;
            this.task_desc.TextChanged += new System.EventHandler(this.task_desc_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "Description";
            // 
            // task_name
            // 
            this.task_name.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.task_name.Location = new System.Drawing.Point(34, 46);
            this.task_name.Name = "task_name";
            this.task_name.Size = new System.Drawing.Size(351, 35);
            this.task_name.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // Task
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 694);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Task";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Task";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.taskGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView taskGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button task_reset_btn;
        private System.Windows.Forms.Button task_up_btn;
        private System.Windows.Forms.Button task_remove_btn;
        private System.Windows.Forms.ComboBox task_status;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button task_add_btn;
        private System.Windows.Forms.TextBox task_desc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox task_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox task_project;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox task_id;
        private System.Windows.Forms.ComboBox task_user;
        private System.Windows.Forms.Label label4;
    }
}