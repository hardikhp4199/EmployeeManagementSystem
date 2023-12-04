using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace EmployeeManagementSystem
{
    public partial class TaskReport : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=G:\Ravensbourne\Advance Software Developer\Project\EmployeeManagementSystem\ems1.mdf;Integrated Security=True");
        public TaskReport()
        {
            InitializeComponent();
            displayTaskData();
            bindStatusComboBox();
            BindProjectComboBox();
            BindUserComboBox();
        }

        private void TaskReport_Load(object sender, EventArgs e)
        {

        }
        public void displayTaskData()
        {
            int projectId = 0;
            int userId = 0;
            string selectedStuats = "";
            if (projectCombo.SelectedIndex != -1)
            {
                KeyValuePair<int, string> selectedProject = (KeyValuePair<int, string>)projectCombo.SelectedItem;
                projectId = selectedProject.Key;
            }
            if (userCombo.SelectedIndex != -1){
                
                KeyValuePair<int, string> selectedUser = (KeyValuePair<int, string>)userCombo.SelectedItem;
                userId= selectedUser.Key;

            }

            if (statusCombo.SelectedIndex != -1)
            {
                KeyValuePair<string, string> selectedStatus = (KeyValuePair<string, string>)statusCombo.SelectedItem;
                selectedStuats = selectedStatus.Key;
            }

            
            TaskData dd = new TaskData();
            List<TaskData> list = dd.TaskListData(projectId,userId,selectedStuats);
             dataGridView2.DataSource = list;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView2.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;
        }

        private void bindStatusComboBox()
        {
            try
            {
                statusCombo.Items.Add(new KeyValuePair<string, string>("Start", "Start"));
                statusCombo.Items.Add(new KeyValuePair<string, string>("Running", "Running"));
                statusCombo.Items.Add(new KeyValuePair<string, string>("Completed", "Completed"));
                statusCombo.DisplayMember = "Value";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something is wrong contact to techinal person." + ex.Message);
            }
        }

        private void BindProjectComboBox()
        {
            try
            {
                string query = "SELECT Id,name FROM project where deleted_date IS null";
                conn.Open();
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string value = reader["name"].ToString();
                            projectCombo.Items.Add(new KeyValuePair<int, string>(reader.GetInt32(0), reader.GetString(1)));
                            projectCombo.DisplayMember = "Value";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something is wrong contact to techinal person." + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void BindUserComboBox()
        {
            try
            {
                string query = "SELECT Id,username FROM users where deleted_date IS NULL";
                conn.Open();
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            userCombo.Items.Add(new KeyValuePair<int, string>(reader.GetInt32(0), reader.GetString(1)));
                            userCombo.DisplayMember = "Value";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something is wrong contact to techinal person." + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void task_project_SelectedIndexChanged(object sender, EventArgs e)
        {
            displayTaskData();
        }

        private void user_SelectedIndexChanged(object sender, EventArgs e)
        {
            displayTaskData();
        }

        private void status_SelectedIndexChanged(object sender, EventArgs e)
        {
            displayTaskData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            user.SelectedIndex = -1;
            project.SelectedIndex = -1;
            status.SelectedIndex = -1;
            displayTaskData();
        }


        private void back_Click(object sender, EventArgs e)
        {

            //this.Hide();
            this.Close();
            Employee obj = new Employee();
            obj.Show();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
