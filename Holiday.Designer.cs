namespace EmployeeManagementSystem
{
    partial class Holiday
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.holidayGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.holiday_id = new System.Windows.Forms.TextBox();
            this.ho_company = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ho_date = new System.Windows.Forms.DateTimePicker();
            this.task_reset_btn = new System.Windows.Forms.Button();
            this.task_up_btn = new System.Windows.Forms.Button();
            this.task_remove_btn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.task_add_btn = new System.Windows.Forms.Button();
            this.ho_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ems1DataSet = new EmployeeManagementSystem.ems1DataSet();
            this.companyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.companyTableAdapter = new EmployeeManagementSystem.ems1DataSetTableAdapters.companyTableAdapter();
            this.holidayBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.holidayTableAdapter = new EmployeeManagementSystem.ems1DataSetTableAdapters.holidayTableAdapter();
            this.holidayBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.holidayGridView)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ems1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.holidayBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.holidayBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.holidayGridView);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(542, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(684, 649);
            this.panel2.TabIndex = 5;
            // 
            // holidayGridView
            // 
            this.holidayGridView.AllowUserToAddRows = false;
            this.holidayGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(156)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.holidayGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.holidayGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.holidayGridView.EnableHeadersVisualStyles = false;
            this.holidayGridView.Location = new System.Drawing.Point(26, 87);
            this.holidayGridView.Name = "holidayGridView";
            this.holidayGridView.ReadOnly = true;
            this.holidayGridView.RowHeadersVisible = false;
            this.holidayGridView.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 12F);
            this.holidayGridView.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.holidayGridView.RowTemplate.Height = 24;
            this.holidayGridView.Size = new System.Drawing.Size(628, 533);
            this.holidayGridView.TabIndex = 1;
            this.holidayGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.holidayGridView_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Holiday List";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.holiday_id);
            this.panel1.Controls.Add(this.ho_company);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.ho_date);
            this.panel1.Controls.Add(this.task_reset_btn);
            this.panel1.Controls.Add(this.task_up_btn);
            this.panel1.Controls.Add(this.task_remove_btn);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.task_add_btn);
            this.panel1.Controls.Add(this.ho_name);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(18, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(493, 649);
            this.panel1.TabIndex = 4;
            // 
            // holiday_id
            // 
            this.holiday_id.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.holiday_id.Location = new System.Drawing.Point(55, 567);
            this.holiday_id.Name = "holiday_id";
            this.holiday_id.Size = new System.Drawing.Size(351, 35);
            this.holiday_id.TabIndex = 17;
            this.holiday_id.Visible = false;
            // 
            // ho_company
            // 
            this.ho_company.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ho_company.FormattingEnabled = true;
            this.ho_company.Location = new System.Drawing.Point(38, 297);
            this.ho_company.Name = "ho_company";
            this.ho_company.Size = new System.Drawing.Size(409, 36);
            this.ho_company.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 28);
            this.label3.TabIndex = 15;
            this.label3.Text = "Company Name";
            // 
            // ho_date
            // 
            this.ho_date.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ho_date.Location = new System.Drawing.Point(38, 203);
            this.ho_date.Name = "ho_date";
            this.ho_date.Size = new System.Drawing.Size(409, 35);
            this.ho_date.TabIndex = 14;
            // 
            // task_reset_btn
            // 
            this.task_reset_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(156)))), ((int)(((byte)(60)))));
            this.task_reset_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(156)))), ((int)(((byte)(60)))));
            this.task_reset_btn.FlatAppearance.BorderSize = 0;
            this.task_reset_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.task_reset_btn.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.task_reset_btn.ForeColor = System.Drawing.Color.White;
            this.task_reset_btn.Location = new System.Drawing.Point(242, 494);
            this.task_reset_btn.Name = "task_reset_btn";
            this.task_reset_btn.Size = new System.Drawing.Size(129, 49);
            this.task_reset_btn.TabIndex = 13;
            this.task_reset_btn.Text = "Reset";
            this.task_reset_btn.UseVisualStyleBackColor = false;
            this.task_reset_btn.Click += new System.EventHandler(this.task_reset_btn_Click_1);
            // 
            // task_up_btn
            // 
            this.task_up_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(156)))), ((int)(((byte)(60)))));
            this.task_up_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(156)))), ((int)(((byte)(60)))));
            this.task_up_btn.FlatAppearance.BorderSize = 0;
            this.task_up_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.task_up_btn.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.task_up_btn.ForeColor = System.Drawing.Color.White;
            this.task_up_btn.Location = new System.Drawing.Point(242, 426);
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
            this.task_remove_btn.Location = new System.Drawing.Point(58, 492);
            this.task_remove_btn.Name = "task_remove_btn";
            this.task_remove_btn.Size = new System.Drawing.Size(129, 51);
            this.task_remove_btn.TabIndex = 11;
            this.task_remove_btn.Text = "REMOVE";
            this.task_remove_btn.UseVisualStyleBackColor = false;
            this.task_remove_btn.Click += new System.EventHandler(this.task_remove_btn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(34, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 28);
            this.label5.TabIndex = 9;
            this.label5.Text = "Date";
            // 
            // task_add_btn
            // 
            this.task_add_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(156)))), ((int)(((byte)(60)))));
            this.task_add_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(156)))), ((int)(((byte)(60)))));
            this.task_add_btn.FlatAppearance.BorderSize = 0;
            this.task_add_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.task_add_btn.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.task_add_btn.ForeColor = System.Drawing.Color.White;
            this.task_add_btn.Location = new System.Drawing.Point(58, 426);
            this.task_add_btn.Name = "task_add_btn";
            this.task_add_btn.Size = new System.Drawing.Size(129, 51);
            this.task_add_btn.TabIndex = 8;
            this.task_add_btn.Text = "ADD";
            this.task_add_btn.UseVisualStyleBackColor = false;
            this.task_add_btn.Click += new System.EventHandler(this.task_add_btn_Click);
            // 
            // ho_name
            // 
            this.ho_name.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ho_name.Location = new System.Drawing.Point(38, 116);
            this.ho_name.Name = "ho_name";
            this.ho_name.Size = new System.Drawing.Size(409, 35);
            this.ho_name.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // ems1DataSet
            // 
            this.ems1DataSet.DataSetName = "ems1DataSet";
            this.ems1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // companyBindingSource
            // 
            this.companyBindingSource.DataMember = "company";
            this.companyBindingSource.DataSource = this.ems1DataSet;
            // 
            // companyTableAdapter
            // 
            this.companyTableAdapter.ClearBeforeFill = true;
            // 
            // holidayBindingSource
            // 
            this.holidayBindingSource.DataMember = "holiday";
            this.holidayBindingSource.DataSource = this.ems1DataSet;
            // 
            // holidayTableAdapter
            // 
            this.holidayTableAdapter.ClearBeforeFill = true;
            // 
            // holidayBindingSource1
            // 
            this.holidayBindingSource1.DataMember = "holiday";
            this.holidayBindingSource1.DataSource = this.ems1DataSet;
            // 
            // Holiday
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 720);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Holiday";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Holiday";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.holidayGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ems1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.holidayBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.holidayBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView holidayGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button task_reset_btn;
        private System.Windows.Forms.Button task_up_btn;
        private System.Windows.Forms.Button task_remove_btn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button task_add_btn;
        private System.Windows.Forms.TextBox ho_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker ho_date;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ho_company;
        private System.Windows.Forms.TextBox holiday_id;
        private ems1DataSet ems1DataSet;
        private System.Windows.Forms.BindingSource companyBindingSource;
        private ems1DataSetTableAdapters.companyTableAdapter companyTableAdapter;
        private System.Windows.Forms.BindingSource holidayBindingSource;
        private ems1DataSetTableAdapters.holidayTableAdapter holidayTableAdapter;
        private System.Windows.Forms.BindingSource holidayBindingSource1;
    }
}