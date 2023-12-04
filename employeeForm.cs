using MySqlX.XDevAPI.Relational;
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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace EmployeeManagementSystem
{
    public partial class employeeForm : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=G:\Ravensbourne\Advance Software Developer\Project\EmployeeManagementSystem\ems1.mdf;Integrated Security=True");
        GlobalFunction gb;
        public employeeForm()
        {
            InitializeComponent();
            gb = new GlobalFunction();
            displayEmpData();
            bindDepartmentComboBox();
            dob.MinDate = new DateTime(1900, 1, 1);

        }

        
        private void bindDepartmentComboBox()
        {
            try
            {
                string query = "SELECT d.Id,d.dname FROM department d, company c where d.deleted_date IS NULL and c.deleted_date IS NULL and c.Id = d.company_id";
                conn.Open();
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string value = reader["dname"].ToString();
                            departmentCombo.Items.Add(new KeyValuePair<int, string>(reader.GetInt32(0), reader.GetString(1)));
                            departmentCombo.DisplayMember = "Value";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        public void displayEmpData()
        {
            EmployeeClassAdmin admin = new EmployeeClassAdmin();

            List<EmployeeClassAdmin> list = admin.EmployeeList();
            empGridView.DataSource = list;
            empGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            empGridView.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;
        }

        
        private void addEmployee(object sender, EventArgs e)
        {
            if (username.Text.Trim() == "" || fname.Text.Trim() == "" || lname.Text.Trim() == "" || mobilenumber.Text.Trim() == "" || emailaddress.Text.Trim() == "" || address.Text.Trim() == "" || postcode.Text.Trim() == "" || departmentCombo.SelectedIndex == -1 || dob.Text == "")
            {
                MessageBox.Show("Please fill all the empty fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            } 
            
            if(!gb.IsUsernameValid(username.Text.Trim()))
            {
                MessageBox.Show("Username is not valid. It may already exist or have invalid characters.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!gb.IsEmailValid(emailaddress.Text.Trim()) || !gb.IsValidEmailAddress(emailaddress.Text.Trim()))
            {
                MessageBox.Show("Email address is not valid. It may already exist or have invalid characters.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!gb.IsMobileValid(mobilenumber.Text.Trim()) || !gb.IsValidMobileNumber(mobilenumber.Text.Trim()))
            {
                MessageBox.Show("Mobilenumber is not valid. It may already exist or have invalid characters.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (gb.CalculateAge(dob.Value) < 18){
                MessageBox.Show("Age is not valid. User must be at least 18 years old.");
                return;
            }

            if (conn.State != ConnectionState.Open){
                try{
                    conn.Open();
                    KeyValuePair<int, string> selectedCompany = (KeyValuePair<int, string>)departmentCombo.SelectedItem;
                    int did = selectedCompany.Key;
                    if (did > 0)
                    {
                        DateTime insertedToday = DateTime.Today;
                        string insertQuery = "INSERT INTO users (username,fname,lname,mobile_number,email_id,address1,dep_id,postcode,password,insert_date,user_role_id,dob) values (@username,@fname,@lname,@mobile_number,@email_id,@address1,@dep_id,@postcode,@password,@insert_date,@user_role_id,@dob)";
                        using (SqlCommand insetCmd = new SqlCommand(insertQuery, conn))
                        {
                            string password = fname.Text.Trim() + lname.Text.Trim() + dob.Text.Trim();
                            insetCmd.Parameters.AddWithValue("@username", username.Text.Trim());
                            insetCmd.Parameters.AddWithValue("@fname", fname.Text.Trim());
                            insetCmd.Parameters.AddWithValue("@lname", lname.Text.Trim());
                            insetCmd.Parameters.AddWithValue("@mobile_number", mobilenumber.Text.Trim());
                            insetCmd.Parameters.AddWithValue("@email_id", emailaddress.Text.Trim());
                            insetCmd.Parameters.AddWithValue("@address1", address.Text.Trim());
                            insetCmd.Parameters.AddWithValue("@dep_id", did);
                            insetCmd.Parameters.AddWithValue("@postcode", postcode.Text.Trim());
                            insetCmd.Parameters.AddWithValue("@password", password);
                            insetCmd.Parameters.AddWithValue("@insert_date", insertedToday);
                            insetCmd.Parameters.AddWithValue("@user_role_id", 2);
                            insetCmd.Parameters.AddWithValue("@dob", dob.Value);

                            insetCmd.ExecuteNonQuery();
                            MessageBox.Show("User Added Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            displayEmpData();
                            reset();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please select the valid department", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        reset();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Contact to technical person, " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void reset(){
            username.Text = "";
            fname.Text = "";
            lname.Text = "";
            mobilenumber.Text = "";
            emailaddress.Text = "";
            address.Text = "";
            postcode.Text = "";
            dob.Text = "";
            departmentCombo.SelectedIndex = -1;
        }

        private void empGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            if (e.RowIndex != -1)
            {
                DataGridViewRow row = empGridView.Rows[e.RowIndex];
                if (row != null)
                {
                    userid.Text = row.Cells[0].Value.ToString();
                    username.Text = row.Cells[1].Value.ToString();
                    fname.Text = row.Cells[2].Value.ToString();
                    lname.Text = row.Cells[3].Value.ToString();
                    mobilenumber.Text = row.Cells[4].Value.ToString();
                    emailaddress.Text = row.Cells[5].Value.ToString();
                    if (DateTime.TryParse(row.Cells[6].Value.ToString(), out DateTime date))
                    {
                        dob.Value = date;
                    }
                    dob.Value = (DateTime)row.Cells[6].Value;
                    address.Text = row.Cells[7].Value.ToString();
                    postcode.Text = row.Cells[8].Value.ToString();
                    departmentCombo.SelectedItem = departmentCombo.Items.Cast<KeyValuePair<int, string>>()
                .FirstOrDefault(item => item.Key == GetDepId(row.Cells[10].Value.ToString()));
                }
            }
        }

         private int GetDepId(string v){
            int cid = 0;
            if (conn.State != ConnectionState.Open)
            {
                try
                {
                    conn.Open();

                    string query = "select id from department where dname=@name";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", v);

                        // Execute the query and get the CompanyId
                        object result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            cid = Convert.ToInt32(result);
                        }
                        else
                        {
                            MessageBox.Show("Department not found", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Contact to technical person, " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                }
            }
            return cid;
         }

        
        private void reset_btn_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void updateMyEmployee_Click(object sender, EventArgs e)
        {
            if (username.Text.Trim() == "" || fname.Text.Trim() == "" || lname.Text.Trim() == "" || mobilenumber.Text.Trim() == "" || emailaddress.Text.Trim() == "" || address.Text.Trim() == "" || postcode.Text.Trim() == "" || departmentCombo.SelectedIndex == -1 || dob.Text == "")
            {
                MessageBox.Show("Please fill all the empty fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!gb.IsUsernameAvailable(userid.Text.Trim(),username.Text.Trim()))
            {
                MessageBox.Show("Username is not valid. It may already exist or have invalid characters.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!gb.IsEmailAvailable(userid.Text.Trim(), emailaddress.Text.Trim()) || !gb.IsValidEmailAddress(emailaddress.Text.Trim()))
            {
                MessageBox.Show("Email address is not valid. It may already exist or have invalid characters.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!gb.IsMobileNumberAvailable(userid.Text.Trim(), mobilenumber.Text.Trim()) || !gb.IsValidMobileNumber(mobilenumber.Text.Trim()))
            {
                MessageBox.Show("Mobilenumber is not valid. It may already exist or have invalid characters.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (gb.CalculateAge(dob.Value) < 18)
            {
                MessageBox.Show("Age is not valid. User must be at least 18 years old.");
                return;
            }

            if (conn.State != ConnectionState.Open)
            {
                try
                {
                    conn.Open();
                    KeyValuePair<int, string> selectedCompany = (KeyValuePair<int, string>)departmentCombo.SelectedItem;
                    int did = selectedCompany.Key;
                    if (did > 0)
                    {
                        DateTime insertedToday = DateTime.Today;
                        string query = "update users set username=@name,fname=@fname,lname=@lname,mobile_number=@mobile_number,email_id=@email_id,address1=@address1,dob=@dob,dep_id=@dep_id,postcode=@postcode, updated_date=@updated_date where Id=@eid";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@eid", userid.Text.Trim());
                            cmd.Parameters.AddWithValue("@name", username.Text.Trim());
                            cmd.Parameters.AddWithValue("@fname", fname.Text.Trim());
                            cmd.Parameters.AddWithValue("@lname", lname.Text.Trim());
                            cmd.Parameters.AddWithValue("@mobile_number", mobilenumber.Text.Trim());
                            cmd.Parameters.AddWithValue("@email_id", emailaddress.Text.Trim());
                            cmd.Parameters.AddWithValue("@address1", address.Text.Trim());
                            cmd.Parameters.AddWithValue("@dob", dob.Value);
                            cmd.Parameters.AddWithValue("@dep_id", did);
                            cmd.Parameters.AddWithValue("@postcode", postcode.Text.Trim());
                            cmd.Parameters.AddWithValue("@updated_date", DateTime.Today);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("User Updated Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            displayEmpData();
                            reset();
                        }
                    }
                    else{
                        MessageBox.Show("Please select the valid department", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        reset();
                    }
                }catch (Exception ex){
                    MessageBox.Show("Contact to technical person, " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }finally{
                    conn.Close();
                }
            }
        }

        private void removeMyEmployee_Click(object sender, EventArgs e)
        {
            if (userid.Text.Trim() != "")
            {
                DialogResult result = MessageBox.Show("Are you sure do you want delete the user?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (conn.State != ConnectionState.Open)
                    {
                        try
                        {
                            conn.Open();
                            DateTime today = DateTime.Today;
                            string query = "update users set deleted_date=@deleted_date where Id=@uid";
                            using (SqlCommand cmd = new SqlCommand(query, conn))
                            {
                                cmd.Parameters.AddWithValue("@uid", userid.Text.Trim());
                                cmd.Parameters.AddWithValue("@deleted_date", today);

                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Deleted Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                displayEmpData();
                                reset();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Contact to technical person" + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            reset();
                        }
                        finally
                        {
                            conn.Close();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Cancelled", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Please select the record.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}