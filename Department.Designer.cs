namespace EmployeeManagementSystem
{
    partial class Department
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.departmentGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dep_id = new System.Windows.Forms.TextBox();
            this.dep_company_name = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.task_reset_btn = new System.Windows.Forms.Button();
            this.task_up_btn = new System.Windows.Forms.Button();
            this.task_remove_btn = new System.Windows.Forms.Button();
            this.task_add_btn = new System.Windows.Forms.Button();
            this.dep_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.departmentGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.departmentGridView);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(505, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(698, 649);
            this.panel2.TabIndex = 7;
            // 
            // departmentGridView
            // 
            this.departmentGridView.AllowUserToAddRows = false;
            this.departmentGridView.AllowUserToDeleteRows = false;
            this.departmentGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(156)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.departmentGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.departmentGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.departmentGridView.EnableHeadersVisualStyles = false;
            this.departmentGridView.Location = new System.Drawing.Point(27, 78);
            this.departmentGridView.Name = "departmentGridView";
            this.departmentGridView.RowHeadersVisible = false;
            this.departmentGridView.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departmentGridView.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.departmentGridView.RowTemplate.Height = 24;
            this.departmentGridView.Size = new System.Drawing.Size(647, 533);
            this.departmentGridView.TabIndex = 1;
            this.departmentGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.departmentGridView_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(156)))), ((int)(((byte)(60)))));
            this.label1.Location = new System.Drawing.Point(29, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Departments";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.dep_id);
            this.panel1.Controls.Add(this.dep_company_name);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.task_reset_btn);
            this.panel1.Controls.Add(this.task_up_btn);
            this.panel1.Controls.Add(this.task_remove_btn);
            this.panel1.Controls.Add(this.task_add_btn);
            this.panel1.Controls.Add(this.dep_name);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(23, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(457, 649);
            this.panel1.TabIndex = 6;
            // 
            // dep_id
            // 
            this.dep_id.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dep_id.Location = new System.Drawing.Point(46, 277);
            this.dep_id.Name = "dep_id";
            this.dep_id.Size = new System.Drawing.Size(351, 35);
            this.dep_id.TabIndex = 17;
            this.dep_id.Visible = false;
            // 
            // dep_company_name
            // 
            this.dep_company_name.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dep_company_name.FormattingEnabled = true;
            this.dep_company_name.Location = new System.Drawing.Point(47, 205);
            this.dep_company_name.Name = "dep_company_name";
            this.dep_company_name.Size = new System.Drawing.Size(350, 36);
            this.dep_company_name.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 28);
            this.label3.TabIndex = 15;
            this.label3.Text = "Company Name";
            // 
            // task_reset_btn
            // 
            this.task_reset_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(156)))), ((int)(((byte)(60)))));
            this.task_reset_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(156)))), ((int)(((byte)(60)))));
            this.task_reset_btn.FlatAppearance.BorderSize = 0;
            this.task_reset_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.task_reset_btn.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.task_reset_btn.ForeColor = System.Drawing.Color.White;
            this.task_reset_btn.Location = new System.Drawing.Point(250, 459);
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
            this.task_up_btn.Location = new System.Drawing.Point(250, 391);
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
            this.task_remove_btn.Location = new System.Drawing.Point(66, 457);
            this.task_remove_btn.Name = "task_remove_btn";
            this.task_remove_btn.Size = new System.Drawing.Size(129, 51);
            this.task_remove_btn.TabIndex = 11;
            this.task_remove_btn.Text = "REMOVE";
            this.task_remove_btn.UseVisualStyleBackColor = false;
            this.task_remove_btn.Click += new System.EventHandler(this.task_remove_btn_Click);
            // 
            // task_add_btn
            // 
            this.task_add_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(156)))), ((int)(((byte)(60)))));
            this.task_add_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(156)))), ((int)(((byte)(60)))));
            this.task_add_btn.FlatAppearance.BorderSize = 0;
            this.task_add_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.task_add_btn.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.task_add_btn.ForeColor = System.Drawing.Color.White;
            this.task_add_btn.Location = new System.Drawing.Point(66, 391);
            this.task_add_btn.Name = "task_add_btn";
            this.task_add_btn.Size = new System.Drawing.Size(129, 51);
            this.task_add_btn.TabIndex = 8;
            this.task_add_btn.Text = "ADD";
            this.task_add_btn.UseVisualStyleBackColor = false;
            this.task_add_btn.Click += new System.EventHandler(this.task_add_btn_Click);
            // 
            // dep_name
            // 
            this.dep_name.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dep_name.Location = new System.Drawing.Point(47, 109);
            this.dep_name.Name = "dep_name";
            this.dep_name.Size = new System.Drawing.Size(351, 35);
            this.dep_name.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // Department
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 673);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Department";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Department";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.departmentGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView departmentGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox dep_company_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button task_reset_btn;
        private System.Windows.Forms.Button task_up_btn;
        private System.Windows.Forms.Button task_remove_btn;
        private System.Windows.Forms.Button task_add_btn;
        private System.Windows.Forms.TextBox dep_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox dep_id;
    }
}