namespace EmployeeManagementSystem
{
    partial class Project
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pro_id = new System.Windows.Forms.TextBox();
            this.pro_reset_btn = new System.Windows.Forms.Button();
            this.pro_up_btn = new System.Windows.Forms.Button();
            this.pro_remove_btn = new System.Windows.Forms.Button();
            this.pro_status = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pro_add_btn = new System.Windows.Forms.Button();
            this.pro_desc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pro_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.projectGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projectGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.pro_id);
            this.panel1.Controls.Add(this.pro_reset_btn);
            this.panel1.Controls.Add(this.pro_up_btn);
            this.panel1.Controls.Add(this.pro_remove_btn);
            this.panel1.Controls.Add(this.pro_status);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.pro_add_btn);
            this.panel1.Controls.Add(this.pro_desc);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pro_name);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(457, 649);
            this.panel1.TabIndex = 0;
            // 
            // pro_id
            // 
            this.pro_id.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pro_id.Location = new System.Drawing.Point(21, 576);
            this.pro_id.Name = "pro_id";
            this.pro_id.Size = new System.Drawing.Size(394, 35);
            this.pro_id.TabIndex = 14;
            this.pro_id.Visible = false;
            // 
            // pro_reset_btn
            // 
            this.pro_reset_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(156)))), ((int)(((byte)(60)))));
            this.pro_reset_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(156)))), ((int)(((byte)(60)))));
            this.pro_reset_btn.FlatAppearance.BorderSize = 0;
            this.pro_reset_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pro_reset_btn.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pro_reset_btn.ForeColor = System.Drawing.Color.White;
            this.pro_reset_btn.Location = new System.Drawing.Point(246, 490);
            this.pro_reset_btn.Name = "pro_reset_btn";
            this.pro_reset_btn.Size = new System.Drawing.Size(129, 49);
            this.pro_reset_btn.TabIndex = 13;
            this.pro_reset_btn.Text = "Reset";
            this.pro_reset_btn.UseVisualStyleBackColor = false;
            this.pro_reset_btn.Click += new System.EventHandler(this.pro_reset_btn_Click);
            // 
            // pro_up_btn
            // 
            this.pro_up_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(156)))), ((int)(((byte)(60)))));
            this.pro_up_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(156)))), ((int)(((byte)(60)))));
            this.pro_up_btn.FlatAppearance.BorderSize = 0;
            this.pro_up_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pro_up_btn.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pro_up_btn.ForeColor = System.Drawing.Color.White;
            this.pro_up_btn.Location = new System.Drawing.Point(246, 422);
            this.pro_up_btn.Name = "pro_up_btn";
            this.pro_up_btn.Size = new System.Drawing.Size(129, 51);
            this.pro_up_btn.TabIndex = 12;
            this.pro_up_btn.Text = "UPDATE";
            this.pro_up_btn.UseVisualStyleBackColor = false;
            this.pro_up_btn.Click += new System.EventHandler(this.pro_up_btn_Click);
            // 
            // pro_remove_btn
            // 
            this.pro_remove_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(156)))), ((int)(((byte)(60)))));
            this.pro_remove_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(156)))), ((int)(((byte)(60)))));
            this.pro_remove_btn.FlatAppearance.BorderSize = 0;
            this.pro_remove_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pro_remove_btn.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pro_remove_btn.ForeColor = System.Drawing.Color.White;
            this.pro_remove_btn.Location = new System.Drawing.Point(62, 488);
            this.pro_remove_btn.Name = "pro_remove_btn";
            this.pro_remove_btn.Size = new System.Drawing.Size(129, 51);
            this.pro_remove_btn.TabIndex = 11;
            this.pro_remove_btn.Text = "REMOVE";
            this.pro_remove_btn.UseVisualStyleBackColor = false;
            this.pro_remove_btn.Click += new System.EventHandler(this.pro_remove_btn_Click);
            // 
            // pro_status
            // 
            this.pro_status.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pro_status.FormattingEnabled = true;
            this.pro_status.Location = new System.Drawing.Point(32, 369);
            this.pro_status.Name = "pro_status";
            this.pro_status.Size = new System.Drawing.Size(393, 36);
            this.pro_status.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 324);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 28);
            this.label5.TabIndex = 9;
            this.label5.Text = "Status";
            // 
            // pro_add_btn
            // 
            this.pro_add_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(156)))), ((int)(((byte)(60)))));
            this.pro_add_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(156)))), ((int)(((byte)(60)))));
            this.pro_add_btn.FlatAppearance.BorderSize = 0;
            this.pro_add_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pro_add_btn.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pro_add_btn.ForeColor = System.Drawing.Color.White;
            this.pro_add_btn.Location = new System.Drawing.Point(62, 422);
            this.pro_add_btn.Name = "pro_add_btn";
            this.pro_add_btn.Size = new System.Drawing.Size(129, 51);
            this.pro_add_btn.TabIndex = 8;
            this.pro_add_btn.Text = "ADD";
            this.pro_add_btn.UseVisualStyleBackColor = false;
            this.pro_add_btn.Click += new System.EventHandler(this.pro_add_btn_Click);
            // 
            // pro_desc
            // 
            this.pro_desc.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pro_desc.Location = new System.Drawing.Point(31, 166);
            this.pro_desc.Multiline = true;
            this.pro_desc.Name = "pro_desc";
            this.pro_desc.Size = new System.Drawing.Size(394, 124);
            this.pro_desc.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "Description";
            // 
            // pro_name
            // 
            this.pro_name.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pro_name.Location = new System.Drawing.Point(31, 84);
            this.pro_name.Name = "pro_name";
            this.pro_name.Size = new System.Drawing.Size(394, 35);
            this.pro_name.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.projectGrid);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(490, 23);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(730, 649);
            this.panel2.TabIndex = 1;
            // 
            // projectGrid
            // 
            this.projectGrid.AllowUserToAddRows = false;
            this.projectGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(156)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.projectGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.projectGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.projectGrid.EnableHeadersVisualStyles = false;
            this.projectGrid.Location = new System.Drawing.Point(27, 78);
            this.projectGrid.Name = "projectGrid";
            this.projectGrid.ReadOnly = true;
            this.projectGrid.RowHeadersVisible = false;
            this.projectGrid.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectGrid.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.projectGrid.RowTemplate.Height = 24;
            this.projectGrid.Size = new System.Drawing.Size(679, 533);
            this.projectGrid.TabIndex = 1;
            this.projectGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.projectGrid_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Projects";
            // 
            // Project
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 694);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Project";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Project";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projectGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView projectGrid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox pro_name;
        private System.Windows.Forms.TextBox pro_desc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button pro_add_btn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox pro_status;
        private System.Windows.Forms.Button pro_reset_btn;
        private System.Windows.Forms.Button pro_up_btn;
        private System.Windows.Forms.Button pro_remove_btn;
        private System.Windows.Forms.TextBox pro_id;
    }
}