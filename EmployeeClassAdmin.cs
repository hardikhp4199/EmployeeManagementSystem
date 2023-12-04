using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagementSystem
{
    
    class EmployeeClassAdmin
    {
        public int Id { get; set; }//0
        public string Username { get; set; } //1
        public string FirstName { get; set; } //2
        public string LastName { get; set; } //3

        public string MobileNumber { get; set; }

        public string EmailAddress { get; set; }

        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }
        public string Postcode { get; set; } 
        public string UserRole { get; set; }
        public string DepartmentName { get; set; }

        
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=G:\Ravensbourne\Advance Software Developer\Project\EmployeeManagementSystem\ems1.mdf;Integrated Security=True");

        public List<EmployeeClassAdmin> EmployeeList()
        {
            List<EmployeeClassAdmin> listdata = new List<EmployeeClassAdmin>();

            if (conn.State != ConnectionState.Open)
            {
                try
                {
                    conn.Open();
                    string query = "select u.* , ur.role as user_role, d.dname  as dname from users u, user_role ur, department d where u.deleted_date IS NULL and ur.deleted_date IS NULL and d.deleted_date IS NULL and u.user_role_id=ur.Id and u.dep_id = d.Id  and u.Id !=" + GlobalFunction.LoggedInUserId;

                    using (SqlCommand cmd = new SqlCommand(query, conn)){
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read()){
                            EmployeeClassAdmin data = new EmployeeClassAdmin();
                            data.Id = (int)reader["Id"];
                            data.Username = reader["username"].ToString();
                            data.FirstName= reader["fname"].ToString();
                            data.LastName = reader["lname"].ToString();
                            data.MobileNumber= reader["mobile_number"].ToString();
                            data.EmailAddress= reader["email_id"].ToString();
                            if (reader["dob"].ToString() != ""){
                                   data.DateOfBirth = (DateTime)reader["dob"];
                            }                            
                            data.Address= reader["address1"].ToString();
                            data.Postcode= reader["postcode"].ToString();
                            data.UserRole = reader["user_role"].ToString();
                            data.DepartmentName = reader["dname"].ToString();
                            listdata.Add(data);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Contact to technical person." + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                }
            }
            return listdata;
        }
    }
}
