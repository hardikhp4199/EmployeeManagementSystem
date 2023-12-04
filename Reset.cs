using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagementSystem
{
    public partial class Reset : Form
    {
        GlobalFunction gb;
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=G:\Ravensbourne\Advance Software Developer\Project\EmployeeManagementSystem\ems1.mdf;Integrated Security=True");
        public Reset()
        {
            InitializeComponent();
            gb = new GlobalFunction();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        
        private void pro_reset_btn_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void reset()
        {
            old_pass.Text = "";
            new_pass.Text = "";
            new_confirm_pass.Text = "";    
        }

        private void show_old_pass_check_CheckedChanged(object sender, EventArgs e)
        {
            old_pass.PasswordChar = show_old_pass_check.Checked ? '\0' : '*';
        }

        private void old_pass_TextChanged(object sender, EventArgs e)
        {
            old_pass.PasswordChar = show_old_pass_check.Checked ? '\0' : '*';
        }

        private void show_new_pass_check_CheckedChanged(object sender, EventArgs e)
        {
            new_pass.PasswordChar = show_new_pass_check.Checked ? '\0' : '*';
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            new_pass.PasswordChar = show_new_pass_check.Checked ? '\0' : '*';
        }

        private void new_confirm_pass_TextChanged(object sender, EventArgs e)
        {
            new_confirm_pass.PasswordChar = show_new_confirm_pass_check.Checked ? '\0' : '*';
        }

        private void show_new_confirm_pass_check_CheckedChanged(object sender, EventArgs e)
        {
            new_confirm_pass.PasswordChar = show_new_confirm_pass_check.Checked ? '\0' : '*';
        }

        private void pro_add_btn_Click(object sender, EventArgs e)
        {
            string oldPassword = old_pass.Text.Trim();
            string newPassword = new_pass.Text.Trim();
            string confirmPassword = new_confirm_pass.Text.Trim();
            if (oldPassword == "" || newPassword == "" || confirmPassword == "")
            {
                MessageBox.Show("Please fill the all empty field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!ValidateOldPassword(oldPassword))
            {
                MessageBox.Show("Invalid old password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate new password
            if (!ValidateNewPassword(newPassword, confirmPassword))
            {
               /* MessageBox.Show("Invalid new password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);*/
                return;
            }
            updatePassword();
        }

        private bool ValidateOldPassword(string oldPassword)
        {
            // Compare the entered old password with the stored password (replace this with your password comparison logic)
            return oldPassword.Equals(getPassword());
        }
        private string getPassword()
        {
            string password = "";
            if (conn.State != ConnectionState.Open)
            {
                try
                {
                    conn.Open();
                    int userId = GlobalFunction.LoggedInUserId;
                    string getPassword = "select password from users where Id=" + userId;
                    using (SqlCommand checkUser = new SqlCommand(getPassword, conn))
                    {
                        using (SqlDataReader reader = checkUser.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                password = reader.GetString(reader.GetOrdinal("password"));
                            }
                            else
                            {
                                MessageBox.Show("Error.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                reset();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                }
            }
            return password;
        }
        private bool ValidateNewPassword(string newPassword, string confirmPassword){
            // Validate password length and complexity
            if (newPassword != confirmPassword)
            {
                MessageBox.Show("New Password and confirm password does not same.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!gb.IsPasswordValid(newPassword) || !gb.IsPasswordValid(confirmPassword))
            {
                MessageBox.Show("Password is not valid. It must have 1 upper, 1 lower, 1 numeric, 1 special character, and be at least 8 characters long.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;   
            }
            
            // Confirm password matches
            return newPassword.Equals(confirmPassword);
        }

        private void updatePassword()
        {
            if (conn.State != ConnectionState.Open){
                try
                {
                    conn.Open();
                    int userId = GlobalFunction.LoggedInUserId;
                    string getPassword = "update users set password=@password where Id=" + userId;
                    using (SqlCommand cmd = new SqlCommand(getPassword, conn))
                    {
                            cmd.Parameters.AddWithValue("@password", new_pass.Text);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Password Successfully Updated!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            reset();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                }
            }
        }
    }
}