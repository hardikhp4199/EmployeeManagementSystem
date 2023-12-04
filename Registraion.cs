using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagementSystem
{
    public partial class Registraion : Form
    {
        GlobalFunction gb;
        private const string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=G:\Ravensbourne\Advance Software Developer\Project\EmployeeManagementSystem\ems1.mdf;Integrated Security=True"; // Replace with your actual connection string

        public Registraion()
        {
            InitializeComponent();
        }

        private bool InsertUserIntoDatabase(string username, string password)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO users (username, password,user_role_id) VALUES (@Username, @Password,2)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Password", password);
                        command.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle database insertion error
                MessageBox.Show($"Error: {ex.Message}");
                return false;
            }
        }
        private void submit_btn_Click(object sender, EventArgs e)
        {
            string user = username.Text.Trim();
            string pass= password.Text;

            // Validate username
            if (user == "" || pass == "")
            {
                MessageBox.Show("Enter the all empty fields.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Validate username
            if (!gb.IsUsernameValid(user))
            {
                MessageBox.Show("Username is not valid. It may already exist or have invalid characters.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate password
            if (!IsPasswordValid(pass))
            {
                MessageBox.Show("Password is not valid. It must have 1 upper, 1 lower, 1 numeric, 1 special character, and be at least 8 characters long.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Insert user into the database
            if (InsertUserIntoDatabase(user, pass))
            {
                MessageBox.Show("Registration successful!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                openLoginForm();
            }
            else
            {
                MessageBox.Show("Registration failed. Please try again.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool IsUsernameValid(string username)
        {
            // Check if username exists in the database
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM users WHERE username = @Username";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    int count = (int)command.ExecuteScalar();
                    return count == 0;
                }
            }
        }

        private bool IsPasswordValid(string password)
        {
            // Password must have 1 upper, 1 lower, 1 numeric, 1 special character, and be at least 8 characters long
            string pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[\W_]).{8,}$";
            return Regex.IsMatch(password, pattern);
        }



        private void signin_btn_Click(object sender, EventArgs e){
            openLoginForm();
        }

        private void openLoginForm()
        {
            MainForm r1 = new MainForm();
            r1.Show();
            this.Hide();
        }
        private void reset()
        {
            username.Text = "";
            password.Text = "";
            username.Focus();
        }

        private void reset_btn_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void password_TextChanged(object sender, EventArgs e)
        {
            password.PasswordChar = show_pass_check.Checked ? '\0' : '*';
        }

        private void show_pass_check_CheckedChanged(object sender, EventArgs e)
        {
            password.PasswordChar = show_pass_check.Checked ? '\0' : '*';
        }
    }
}
