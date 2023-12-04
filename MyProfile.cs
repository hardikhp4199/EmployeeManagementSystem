using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagementSystem
{
    public partial class MyProfile : Form
    {
        GlobalFunction gb;
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=G:\Ravensbourne\Advance Software Developer\Project\EmployeeManagementSystem\ems1.mdf;Integrated Security=True");
        public MyProfile()
        {
            InitializeComponent();
            gb = new GlobalFunction();
            
        }

        private void button2_Click(object sender, EventArgs e){
            getMyProfileData();
        }

        private void reset(){
            fname.Text = "";
            lname.Text = "";
            emailaddress.Text = "";
            mobilenumber.Text = "";
            address.Text = "";
            postcode.Text = "";
        }

        
        
        private void updateProfile_Click(object sender, EventArgs e)
        {
            if (fname.Text.Trim() == "" || lname.Text.Trim() == "" || mobilenumber.Text.Trim() == "" || emailaddress.Text.Trim() == "" || address.Text.Trim() == "" || postcode.Text.Trim() == ""){
                MessageBox.Show("Please fill all the empty fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else{
                MessageBox.Show("Updated Successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                address.Text = "160 Kingslang RD, Upton Park, London";
            }
        }

        private void MyProfile_Load(object sender, EventArgs e)
        {
            getMyProfileData();
        }

        private Image ByteArrayToImage(byte[] byteArrayIn)
        {
            using (MemoryStream ms = new MemoryStream(byteArrayIn))
            {
                Image returnImage = Image.FromStream(ms);
                return returnImage;
            }
        }
        private void getMyProfileData()
        {
            if (conn.State != ConnectionState.Open)
            {
                try
                {
                    conn.Open();
                    int userId = GlobalFunction.LoggedInUserId;
                    string getUsername = "select u.*, d.dname as departmentName from users u, department d where u.dep_id = d.Id and u.Id=" + userId;
                    using (SqlCommand checkUser = new SqlCommand(getUsername, conn))
                    {

                        using (SqlDataReader reader = checkUser.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Retrieve count and id values
                                
                                username.Text = reader.GetString(reader.GetOrdinal("username"));
                                fname.Text = reader.GetString(reader.GetOrdinal("lname"));
                                lname.Text = reader.GetString(reader.GetOrdinal("fname"));
                                address.Text = reader.GetString(reader.GetOrdinal("address1"));
                                department.Text = reader.GetString(reader.GetOrdinal("departmentName"));
                                postcode.Text = reader.GetString(reader.GetOrdinal("postcode"));
                                mobilenumber.Text = reader.GetString(reader.GetOrdinal("mobile_number"));
                                emailaddress.Text = reader.GetString(reader.GetOrdinal("email_id"));
                                // Execute the query and retrieve the image data
                            }
                            else
                            {
                                MessageBox.Show("Something is wrong", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception ex){
                    MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }finally{
                    conn.Close();
                }
            }
        }
    }
}
