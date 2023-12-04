using System;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace EmployeeManagementSystem
{
    class GlobalFunction
    {
        public static int LoggedInUserId { get; set; }
        private const string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=G:\Ravensbourne\Advance Software Developer\Project\EmployeeManagementSystem\ems1.mdf;Integrated Security=True"; // Replace with your actual connection string
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=G:\Ravensbourne\Advance Software Developer\Project\EmployeeManagementSystem\ems1.mdf;Integrated Security=True");
        public string DateFormation(string dateString)
        {
            DateTime dateTime = DateTime.Parse(dateString);

            string formattedDate = dateTime.ToString("MM/dd/yyyy");

            return formattedDate;
        }
        // Validate email address using regular expression
        public bool IsValidEmailAddress(string emailAddress)
        {
            // Use a regular expression to define the pattern for a valid email address
            string pattern = @"^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            // Use Regex.IsMatch to check if the email address matches the pattern
            return Regex.IsMatch(emailAddress, pattern);
        }

        // Validate mobile number using regular expression
        public bool IsValidMobileNumber(string mobileNumber)
        {
            // Use a regular expression to define the pattern for a valid mobile number
            string pattern = @"^\+(44)\s?(\d{10})$";

            // Use Regex.IsMatch to check if the mobile number matches the pattern
            return Regex.IsMatch(mobileNumber, pattern);
        }

        public bool IsPasswordValid(string password){
            // Define the regular expression pattern for password validation
            string pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@#$%^&+=]).{8,}$";
            return Regex.IsMatch(password,pattern);
        }


        public int GetCount(string query)
        {
            int count = 0;
            if (conn.State != ConnectionState.Open){
                try{
                    conn.Open();
                    //string getCountQuery= "select count(id) from "+ tableName +" where deleted_date is null " + wherePart;

                    using (SqlCommand getCount = new SqlCommand(query, conn)){
                        count = (int)getCount.ExecuteScalar();
                    }
                }
                catch (Exception ex){
                    MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }finally{
                    conn.Close();
                }
            }
            return count;
        }

        public bool IsUsernameValid(string username)
        {
            // Check if username exists in the database
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM users WHERE username = @Username and deleted_date is null";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    int count = (int)command.ExecuteScalar();
                    return count == 0;
                }
            }
        }

        public bool IsUsernameAvailable(string userId,string newUsername)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM users WHERE username = @Username AND Id != @CurrentUserID and  deleted_date is null";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", newUsername);
                    command.Parameters.AddWithValue("@CurrentUserID", userId);
                    
                    int count = (int)command.ExecuteScalar();
                    return count == 0;
                }
            }
        }

        public bool IsEmailAvailable(string userId,string emailID)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM users WHERE email_id = @email_id AND Id != @userId and  deleted_date is null" ;

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@email_id", emailID);
                    command.Parameters.AddWithValue("@userId", userId);

                    int count = (int)command.ExecuteScalar();

                    return count == 0;
                }
            }
        }

        public bool IsMobileNumberAvailable(string userId,string mobileNumber)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM users WHERE mobile_number = @mobileNumber AND Id != @userId and  deleted_date is null";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@mobileNumber", mobileNumber);
                    command.Parameters.AddWithValue("@userId", userId);

                    int count = (int)command.ExecuteScalar();

                    return count == 0;
                }
            }
        }

        public bool IsEmailValid(string email)
        {
            // Check if username exists in the database
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM users WHERE email_id = @email and  deleted_date is null";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@email", email);
                    int count = (int)command.ExecuteScalar();
                    return count == 0;
                }
            }
        }

        public bool IsMobileValid(string mobile){

            // Check if username exists in the database
            using (SqlConnection connection = new SqlConnection(ConnectionString)){

                connection.Open();
                string query = "SELECT COUNT(*) FROM users WHERE mobile_number = @mobile and  deleted_date is null";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@mobile", mobile);
                    int count = (int)command.ExecuteScalar();
                    return count == 0;
                }
            }
        }

        public int CalculateAge(DateTime dateOfBirth)
        {
            // Calculate age based on the current date
            DateTime currentDate = DateTime.Now;
            int age = currentDate.Year - dateOfBirth.Year;

            // Adjust age if the birthday hasn't occurred yet this year
            if (currentDate.Month < dateOfBirth.Month || (currentDate.Month == dateOfBirth.Month && currentDate.Day < dateOfBirth.Day))
            {
                age--;
            }

            return age;
        }

    }
}