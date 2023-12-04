namespace EmployeeManagementSystem
{
    partial class MyProfile
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.department = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.postcode = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.emailaddress = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.mobilenumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.fname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.updateProfile = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(156)))), ((int)(((byte)(60)))));
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 36);
            this.label1.TabIndex = 3;
            this.label1.Text = "My Profile";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.updateProfile);
            this.panel1.Controls.Add(this.department);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.postcode);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.address);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.emailaddress);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.mobilenumber);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lname);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.fname);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.username);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1208, 586);
            this.panel1.TabIndex = 4;
            // 
            // department
            // 
            this.department.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.department.Location = new System.Drawing.Point(426, 276);
            this.department.Name = "department";
            this.department.ReadOnly = true;
            this.department.Size = new System.Drawing.Size(367, 35);
            this.department.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(423, 242);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(133, 28);
            this.label10.TabIndex = 17;
            this.label10.Text = "Department";
            // 
            // postcode
            // 
            this.postcode.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postcode.Location = new System.Drawing.Point(812, 276);
            this.postcode.Name = "postcode";
            this.postcode.Size = new System.Drawing.Size(367, 35);
            this.postcode.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(809, 242);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 28);
            this.label8.TabIndex = 12;
            this.label8.Text = "Post Code";
            // 
            // address
            // 
            this.address.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address.Location = new System.Drawing.Point(814, 66);
            this.address.Multiline = true;
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(367, 140);
            this.address.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(811, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 28);
            this.label7.TabIndex = 10;
            this.label7.Text = "Address";
            // 
            // emailaddress
            // 
            this.emailaddress.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailaddress.Location = new System.Drawing.Point(426, 171);
            this.emailaddress.Name = "emailaddress";
            this.emailaddress.Size = new System.Drawing.Size(367, 35);
            this.emailaddress.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(423, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 28);
            this.label6.TabIndex = 8;
            this.label6.Text = "Email Address";
            // 
            // mobilenumber
            // 
            this.mobilenumber.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mobilenumber.Location = new System.Drawing.Point(426, 66);
            this.mobilenumber.Name = "mobilenumber";
            this.mobilenumber.Size = new System.Drawing.Size(367, 35);
            this.mobilenumber.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(423, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 28);
            this.label5.TabIndex = 6;
            this.label5.Text = "Mobile Number";
            // 
            // lname
            // 
            this.lname.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lname.Location = new System.Drawing.Point(35, 269);
            this.lname.Name = "lname";
            this.lname.Size = new System.Drawing.Size(367, 35);
            this.lname.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 28);
            this.label4.TabIndex = 4;
            this.label4.Text = "Lastname";
            // 
            // fname
            // 
            this.fname.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fname.Location = new System.Drawing.Point(31, 167);
            this.fname.Name = "fname";
            this.fname.Size = new System.Drawing.Size(367, 35);
            this.fname.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Firstname";
            // 
            // username
            // 
            this.username.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.Location = new System.Drawing.Point(33, 66);
            this.username.Name = "username";
            this.username.ReadOnly = true;
            this.username.Size = new System.Drawing.Size(367, 35);
            this.username.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "Username";
            // 
            // updateProfile
            // 
            this.updateProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(156)))), ((int)(((byte)(60)))));
            this.updateProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateProfile.FlatAppearance.BorderSize = 0;
            this.updateProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateProfile.ForeColor = System.Drawing.Color.White;
            this.updateProfile.Location = new System.Drawing.Point(331, 352);
            this.updateProfile.Name = "updateProfile";
            this.updateProfile.Size = new System.Drawing.Size(195, 53);
            this.updateProfile.TabIndex = 19;
            this.updateProfile.Text = "Update Profile";
            this.updateProfile.UseVisualStyleBackColor = false;
            this.updateProfile.Click += new System.EventHandler(this.updateProfile_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(587, 352);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(195, 53);
            this.button2.TabIndex = 20;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MyProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1250, 720);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MyProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyProfile";
            this.Load += new System.EventHandler(this.MyProfile_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox lname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox mobilenumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox emailaddress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox postcode;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox department;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button updateProfile;
    }
}