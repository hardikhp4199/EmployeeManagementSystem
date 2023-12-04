namespace EmployeeManagementSystem
{
    partial class Registraion
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.signin_btn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.show_pass_check = new System.Windows.Forms.CheckBox();
            this.reset_btn = new System.Windows.Forms.Button();
            this.submit_btn = new System.Windows.Forms.Button();
            this.password = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.exit_label = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(178)))), ((int)(((byte)(156)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.signin_btn);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(391, 566);
            this.panel1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(91, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "WELCOME TO EMS";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EmployeeManagementSystem.Properties.Resources.logo_100_100;
            this.pictureBox1.Location = new System.Drawing.Point(124, 90);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(126, 122);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(32, 299);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(326, 24);
            this.label6.TabIndex = 2;
            this.label6.Text = "Employee Management System";
            // 
            // signin_btn
            // 
            this.signin_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(156)))), ((int)(((byte)(60)))));
            this.signin_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signin_btn.FlatAppearance.BorderSize = 0;
            this.signin_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signin_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signin_btn.ForeColor = System.Drawing.Color.White;
            this.signin_btn.Location = new System.Drawing.Point(52, 480);
            this.signin_btn.Name = "signin_btn";
            this.signin_btn.Size = new System.Drawing.Size(277, 39);
            this.signin_btn.TabIndex = 1;
            this.signin_btn.Text = "SIGN IN";
            this.signin_btn.UseVisualStyleBackColor = false;
            this.signin_btn.Click += new System.EventHandler(this.signin_btn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(90, 435);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(190, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Sing In your account";
            // 
            // show_pass_check
            // 
            this.show_pass_check.AutoSize = true;
            this.show_pass_check.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show_pass_check.Location = new System.Drawing.Point(586, 343);
            this.show_pass_check.Name = "show_pass_check";
            this.show_pass_check.Size = new System.Drawing.Size(175, 29);
            this.show_pass_check.TabIndex = 19;
            this.show_pass_check.Text = "Show Password";
            this.show_pass_check.UseVisualStyleBackColor = true;
            this.show_pass_check.CheckedChanged += new System.EventHandler(this.show_pass_check_CheckedChanged);
            // 
            // reset_btn
            // 
            this.reset_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(156)))), ((int)(((byte)(60)))));
            this.reset_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reset_btn.FlatAppearance.BorderSize = 0;
            this.reset_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reset_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset_btn.ForeColor = System.Drawing.Color.White;
            this.reset_btn.Location = new System.Drawing.Point(621, 396);
            this.reset_btn.Name = "reset_btn";
            this.reset_btn.Size = new System.Drawing.Size(140, 39);
            this.reset_btn.TabIndex = 18;
            this.reset_btn.Text = "Reset";
            this.reset_btn.UseVisualStyleBackColor = false;
            this.reset_btn.Click += new System.EventHandler(this.reset_btn_Click);
            // 
            // submit_btn
            // 
            this.submit_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(156)))), ((int)(((byte)(60)))));
            this.submit_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.submit_btn.FlatAppearance.BorderSize = 0;
            this.submit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit_btn.ForeColor = System.Drawing.Color.White;
            this.submit_btn.Location = new System.Drawing.Point(456, 396);
            this.submit_btn.Name = "submit_btn";
            this.submit_btn.Size = new System.Drawing.Size(140, 39);
            this.submit_btn.TabIndex = 17;
            this.submit_btn.Text = "Submit";
            this.submit_btn.UseVisualStyleBackColor = false;
            this.submit_btn.Click += new System.EventHandler(this.submit_btn_Click);
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(456, 307);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(305, 30);
            this.password.TabIndex = 16;
            this.password.TextChanged += new System.EventHandler(this.password_TextChanged);
            // 
            // username
            // 
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.Location = new System.Drawing.Point(456, 229);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(305, 30);
            this.username.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(451, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 25);
            this.label4.TabIndex = 14;
            this.label4.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(451, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(156)))), ((int)(((byte)(60)))));
            this.label2.Location = new System.Drawing.Point(475, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(262, 36);
            this.label2.TabIndex = 12;
            this.label2.Text = "Sign Up Account";
            // 
            // exit_label
            // 
            this.exit_label.AutoSize = true;
            this.exit_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit_label.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_label.Location = new System.Drawing.Point(779, 9);
            this.exit_label.Name = "exit_label";
            this.exit_label.Size = new System.Drawing.Size(25, 28);
            this.exit_label.TabIndex = 11;
            this.exit_label.Text = "X";
            // 
            // Registraion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 566);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.show_pass_check);
            this.Controls.Add(this.reset_btn);
            this.Controls.Add(this.submit_btn);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.exit_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Registraion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registraion";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button signin_btn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox show_pass_check;
        private System.Windows.Forms.Button reset_btn;
        private System.Windows.Forms.Button submit_btn;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label exit_label;
    }
}