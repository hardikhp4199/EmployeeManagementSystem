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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EmployeeManagementSystem
{
    public partial class MainForm : Form
    {
        GlobalFunction gb;
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=G:\Ravensbourne\Advance Software Developer\Project\EmployeeManagementSystem\ems1.mdf;Integrated Security=True");
        public MainForm()
        {
            InitializeComponent();
            gb= new GlobalFunction();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            DBConnection db = new DBConnection();
            db.Open();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            password.PasswordChar = show_pass_check.Checked ? '\0' : '*';
        }

        private void exit_label_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void signup_btn_Click(object sender, EventArgs e){
            Registraion r1 = new Registraion();
            r1.Show();
            this.Hide();
        }

        private void show_pass_check_CheckedChanged(object sender, EventArgs e)
        {
            password.PasswordChar = show_pass_check.Checked ? '\0' : '*';
        }
        
        private void login_btn_Click(object sender, EventArgs e)
        {
            if(username.Text.Trim() == "" || password.Text.Trim() == "")
            {
                MessageBox.Show("Please fill all the empty fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (conn.State != ConnectionState.Open)
                {
                    try
                    {
                        conn.Open();
                        string getUsername = "select Id,user_role_id from users where username=@uname COLLATE Latin1_General_CS_AS  and password=@pass COLLATE Latin1_General_CS_AS ";
                        using (SqlCommand checkUser = new SqlCommand(getUsername, conn))
                        {
                            checkUser.Parameters.AddWithValue("@uname", username.Text.Trim());
                            checkUser.Parameters.AddWithValue("@pass", password.Text.Trim());
                            using (SqlDataReader reader = checkUser.ExecuteReader()){
                                if (reader.Read()){
                                    // Retrieve count and id values
                                    int userId = reader.GetInt32(reader.GetOrdinal("Id"));
                                    int userRoleId = reader.GetInt32(reader.GetOrdinal("User_role_id"));
                                    GlobalFunction.LoggedInUserId = userId;
                                    
                                    if (userId > 0){
                                        if (userRoleId == 1){
                                            Employee empObj = new Employee();
                                            empObj.Show();
                                        }
                                        else{
                                            EmployeeMaster  employeeMaster = new EmployeeMaster();
                                            employeeMaster.Show();
                                        }
                                        this.Hide();
                                    }
                                    else{
                                        MessageBox.Show("Please enter the correct username or password.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        resetLoginForm();
                                    }
                                }else{
                                    MessageBox.Show("Please enter the correct username or password.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    resetLoginForm();
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
            }
        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }

        private void reset_btn_Click(object sender, EventArgs e)
        {
            resetLoginForm();
        }

        private void resetLoginForm()
        {
            username.Text = "";
            password.Text = "";
            username.Focus();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
