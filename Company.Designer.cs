namespace EmployeeManagementSystem
{
    partial class Company
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.companyGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.com_mobile_number = new System.Windows.Forms.TextBox();
            this.com_postcode = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.com_reset_btn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.com_up_btn = new System.Windows.Forms.Button();
            this.com_email = new System.Windows.Forms.TextBox();
            this.com_remove_btn = new System.Windows.Forms.Button();
            this.com_add_btn = new System.Windows.Forms.Button();
            this.com_address = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.com_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.empid = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.companyGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.companyGridView);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(456, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(769, 649);
            this.panel2.TabIndex = 5;
            // 
            // companyGridView
            // 
            this.companyGridView.AllowUserToAddRows = false;
            this.companyGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(156)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.companyGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.companyGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.companyGridView.EnableHeadersVisualStyles = false;
            this.companyGridView.Location = new System.Drawing.Point(21, 77);
            this.companyGridView.Name = "companyGridView";
            this.companyGridView.ReadOnly = true;
            this.companyGridView.RowHeadersVisible = false;
            this.companyGridView.RowHeadersWidth = 51;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companyGridView.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.companyGridView.RowTemplate.Height = 24;
            this.companyGridView.Size = new System.Drawing.Size(727, 548);
            this.companyGridView.TabIndex = 1;
            this.companyGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.companyGridView_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(156)))), ((int)(((byte)(60)))));
            this.label1.Location = new System.Drawing.Point(29, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Comapny";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.com_mobile_number);
            this.panel1.Controls.Add(this.com_postcode);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.com_reset_btn);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.com_up_btn);
            this.panel1.Controls.Add(this.com_email);
            this.panel1.Controls.Add(this.com_remove_btn);
            this.panel1.Controls.Add(this.com_add_btn);
            this.panel1.Controls.Add(this.com_address);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.com_name);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(23, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(417, 649);
            this.panel1.TabIndex = 4;
            // 
            // com_mobile_number
            // 
            this.com_mobile_number.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.com_mobile_number.Location = new System.Drawing.Point(35, 148);
            this.com_mobile_number.Name = "com_mobile_number";
            this.com_mobile_number.Size = new System.Drawing.Size(351, 35);
            this.com_mobile_number.TabIndex = 24;
            // 
            // com_postcode
            // 
            this.com_postcode.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.com_postcode.Location = new System.Drawing.Point(35, 464);
            this.com_postcode.Name = "com_postcode";
            this.com_postcode.Size = new System.Drawing.Size(351, 35);
            this.com_postcode.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(30, 433);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 28);
            this.label7.TabIndex = 19;
            this.label7.Text = "Post Code";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(191, 28);
            this.label5.TabIndex = 23;
            this.label5.Text = "Mobile Number";
            // 
            // com_reset_btn
            // 
            this.com_reset_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(156)))), ((int)(((byte)(60)))));
            this.com_reset_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(156)))), ((int)(((byte)(60)))));
            this.com_reset_btn.FlatAppearance.BorderSize = 0;
            this.com_reset_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.com_reset_btn.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.com_reset_btn.ForeColor = System.Drawing.Color.White;
            this.com_reset_btn.Location = new System.Drawing.Point(221, 586);
            this.com_reset_btn.Name = "com_reset_btn";
            this.com_reset_btn.Size = new System.Drawing.Size(129, 49);
            this.com_reset_btn.TabIndex = 13;
            this.com_reset_btn.Text = "Reset";
            this.com_reset_btn.UseVisualStyleBackColor = false;
            this.com_reset_btn.Click += new System.EventHandler(this.com_reset_btn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 28);
            this.label4.TabIndex = 21;
            this.label4.Text = "Email Address";
            // 
            // com_up_btn
            // 
            this.com_up_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(156)))), ((int)(((byte)(60)))));
            this.com_up_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(156)))), ((int)(((byte)(60)))));
            this.com_up_btn.FlatAppearance.BorderSize = 0;
            this.com_up_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.com_up_btn.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.com_up_btn.ForeColor = System.Drawing.Color.White;
            this.com_up_btn.Location = new System.Drawing.Point(221, 512);
            this.com_up_btn.Name = "com_up_btn";
            this.com_up_btn.Size = new System.Drawing.Size(129, 51);
            this.com_up_btn.TabIndex = 12;
            this.com_up_btn.Text = "UPDATE";
            this.com_up_btn.UseVisualStyleBackColor = false;
            this.com_up_btn.Click += new System.EventHandler(this.com_up_btn_Click);
            // 
            // com_email
            // 
            this.com_email.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.com_email.Location = new System.Drawing.Point(35, 218);
            this.com_email.Name = "com_email";
            this.com_email.Size = new System.Drawing.Size(351, 35);
            this.com_email.TabIndex = 20;
            // 
            // com_remove_btn
            // 
            this.com_remove_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(156)))), ((int)(((byte)(60)))));
            this.com_remove_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(156)))), ((int)(((byte)(60)))));
            this.com_remove_btn.FlatAppearance.BorderSize = 0;
            this.com_remove_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.com_remove_btn.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.com_remove_btn.ForeColor = System.Drawing.Color.White;
            this.com_remove_btn.Location = new System.Drawing.Point(63, 586);
            this.com_remove_btn.Name = "com_remove_btn";
            this.com_remove_btn.Size = new System.Drawing.Size(129, 51);
            this.com_remove_btn.TabIndex = 11;
            this.com_remove_btn.Text = "REMOVE";
            this.com_remove_btn.UseVisualStyleBackColor = false;
            this.com_remove_btn.Click += new System.EventHandler(this.com_remove_btn_Click);
            // 
            // com_add_btn
            // 
            this.com_add_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(156)))), ((int)(((byte)(60)))));
            this.com_add_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(156)))), ((int)(((byte)(60)))));
            this.com_add_btn.FlatAppearance.BorderSize = 0;
            this.com_add_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.com_add_btn.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.com_add_btn.ForeColor = System.Drawing.Color.White;
            this.com_add_btn.Location = new System.Drawing.Point(63, 512);
            this.com_add_btn.Name = "com_add_btn";
            this.com_add_btn.Size = new System.Drawing.Size(129, 51);
            this.com_add_btn.TabIndex = 8;
            this.com_add_btn.Text = "ADD";
            this.com_add_btn.UseVisualStyleBackColor = false;
            this.com_add_btn.Click += new System.EventHandler(this.com_add_btn_Click);
            // 
            // com_address
            // 
            this.com_address.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.com_address.Location = new System.Drawing.Point(35, 302);
            this.com_address.Multiline = true;
            this.com_address.Name = "com_address";
            this.com_address.Size = new System.Drawing.Size(351, 124);
            this.com_address.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "Address";
            // 
            // com_name
            // 
            this.com_name.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.com_name.Location = new System.Drawing.Point(35, 54);
            this.com_name.Name = "com_name";
            this.com_name.Size = new System.Drawing.Size(351, 35);
            this.com_name.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // empid
            // 
            this.empid.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empid.Location = new System.Drawing.Point(58, 682);
            this.empid.Name = "empid";
            this.empid.Size = new System.Drawing.Size(351, 35);
            this.empid.TabIndex = 25;
            this.empid.Visible = false;
            // 
            // Company
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 720);
            this.Controls.Add(this.empid);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Company";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Company";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.companyGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView companyGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button com_reset_btn;
        private System.Windows.Forms.Button com_up_btn;
        private System.Windows.Forms.Button com_remove_btn;
        private System.Windows.Forms.Button com_add_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox com_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox com_postcode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox com_email;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox com_address;
        private System.Windows.Forms.TextBox com_mobile_number;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox empid;
    }
}