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
    public partial class Task : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=G:\Ravensbourne\Advance Software Developer\Project\EmployeeManagementSystem\ems1.mdf;Integrated Security=True");
        public Task()
        {
            InitializeComponent();
            displayTaskData();
            bindStatusComboBox();
            BindProjectComboBox();
            BindUserComboBox();
        }

        public void displayTaskData()
        {
            TaskData dd = new TaskData();
            List<TaskData> list = dd.TaskListData(0,0,"");
            taskGridView.DataSource = list;
            taskGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            taskGridView.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;
        }

        private void bindStatusComboBox()
        {
            try
            {
                task_status.Items.Add(new KeyValuePair<string, string>("Start", "Start"));
                task_status.Items.Add(new KeyValuePair<string, string>("Running", "Running"));
                task_status.Items.Add(new KeyValuePair<string, string>("Completed", "Completed"));
                task_status.DisplayMember = "Value";
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
                using (SqlCommand command = new SqlCommand(query, conn)){
                    using (SqlDataReader reader = command.ExecuteReader()){
                        while (reader.Read()){
                            string value = reader["name"].ToString();
                            task_project.Items.Add(new KeyValuePair<int, string>(reader.GetInt32(0), reader.GetString(1)));
                            task_project.DisplayMember = "Value";
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
                            task_user.Items.Add(new KeyValuePair<int, string>(reader.GetInt32(0), reader.GetString(1)));
                            task_user.DisplayMember = "Value";
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

        private void task_add_btn_Click(object sender, EventArgs e)
        {
            if (task_name.Text.Trim() == "" || task_desc.Text.Trim() == "" || task_project.SelectedItem == null || task_user.SelectedItem == null || task_status.SelectedItem == null){
                MessageBox.Show("Please fill all the empty fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else{
                if (conn.State != ConnectionState.Open){
                    try
                    {
                        conn.Open();
                        KeyValuePair<string, string> selectedStatus = (KeyValuePair<string, string>)task_status.SelectedItem;
                        string taskStatus= selectedStatus.Key;

                        KeyValuePair<int, string> selectedUser= (KeyValuePair<int, string>)task_user.SelectedItem;
                        int uid = selectedUser.Key;

                        KeyValuePair<int, string> selectedProject= (KeyValuePair<int, string>)task_project.SelectedItem;
                        int pid= selectedProject.Key;
                        if (taskStatus != "" && uid != -1 && pid != -1)
                        {
                            int re;
                            string insertQuery = " INSERT INTO task (name,description,status,start_date,insert_date,project_id,user_id) values (@pro_name,@pro_desc,@status,@start_date,@insert_date,@project_id,@user_id)";
                            using (SqlCommand insetCmd = new SqlCommand(insertQuery, conn))
                            {
                                insetCmd.Parameters.AddWithValue("@pro_name", task_name.Text.Trim());
                                insetCmd.Parameters.AddWithValue("@pro_desc", task_desc.Text.Trim());
                                insetCmd.Parameters.AddWithValue("@status", taskStatus);
                                insetCmd.Parameters.AddWithValue("@start_date", DateTime.Today);
                                insetCmd.Parameters.AddWithValue("@insert_date", DateTime.Today);
                                insetCmd.Parameters.AddWithValue("@project_id", pid);
                                insetCmd.Parameters.AddWithValue("@user_id", uid);
                                re = insetCmd.ExecuteNonQuery();
                            }
                            MessageBox.Show("Added Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            displayTaskData();
                            reset();
                        }
                        else{
                            MessageBox.Show("Please select the valid company name", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            reset();
                        }
                    }
                    catch (Exception ex){
                        MessageBox.Show("Contact to technical person, " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }
        }

        private void task_up_btn_Click(object sender, EventArgs e)
        {
            if (task_name.Text.Trim() == "" || task_desc.Text.Trim() == "" || task_project.SelectedItem == null || task_user.SelectedItem == null || task_status.SelectedItem == null)
            {
                MessageBox.Show("Please fill all the empty fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (task_id.Text.Trim() != "")
                {
                    DialogResult result = MessageBox.Show("Are you sure do you want update the task?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        if (conn.State != ConnectionState.Open)
                        {
                            try
                            {
                                conn.Open();
                                KeyValuePair<string, string> selectedStatus = (KeyValuePair<string, string>)task_status.SelectedItem;
                                string taskStatus = selectedStatus.Key;

                                KeyValuePair<int, string> selectedUser = (KeyValuePair<int, string>)task_user.SelectedItem;
                                int uid = selectedUser.Key;

                                KeyValuePair<int, string> selectedProject = (KeyValuePair<int, string>)task_project.SelectedItem;
                                int pid = selectedProject.Key;
                                if (taskStatus != "" && uid != -1 && pid != -1)
                                {
                                    if(taskStatus == "Completed")
                                    {
                                        string query = "update task set name=@task_name,description=@pro_desc,status=@status,end_date=@end_date,updated_date=@updated_date,project_id=@pid,user_id=@uid where Id=@id";
                                        using (SqlCommand cmd = new SqlCommand(query, conn))
                                        {
                                            cmd.Parameters.AddWithValue("@id", task_id.Text.Trim());
                                            cmd.Parameters.AddWithValue("@task_name", task_name.Text.Trim());
                                            cmd.Parameters.AddWithValue("@pro_desc", task_desc.Text.Trim());
                                            cmd.Parameters.AddWithValue("@status", taskStatus);
                                            cmd.Parameters.AddWithValue("@updated_date", DateTime.Today);
                                            cmd.Parameters.AddWithValue("@end_date", DateTime.Today);
                                            cmd.Parameters.AddWithValue("@pid", pid);
                                            cmd.Parameters.AddWithValue("@uid", uid);
                                            cmd.ExecuteNonQuery();
                                        }
                                    }
                                    else
                                    {
                                        string query = "update task set name=@task_name,description=@pro_desc,status=@status,updated_date=@updated_date,project_id=@pid,user_id=@uid where Id=@id";
                                        using (SqlCommand cmd = new SqlCommand(query, conn))
                                        {
                                            cmd.Parameters.AddWithValue("@id", task_id.Text.Trim());
                                            cmd.Parameters.AddWithValue("@task_name", task_name.Text.Trim());
                                            cmd.Parameters.AddWithValue("@pro_desc", task_desc.Text.Trim());
                                            cmd.Parameters.AddWithValue("@status", taskStatus);
                                            cmd.Parameters.AddWithValue("@updated_date", DateTime.Today);
                                            cmd.Parameters.AddWithValue("@pid", pid);
                                            cmd.Parameters.AddWithValue("@uid", uid);
                                            cmd.ExecuteNonQuery();
                                        }
                                    }
                                    
                                    
                                    MessageBox.Show("Updated Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    displayTaskData();
                                    reset();
                                }
                                else
                                {
                                    MessageBox.Show("Please select the valid company name", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    else
                    {
                        MessageBox.Show("Cancelled", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Please fill all the empty fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void task_remove_btn_Click(object sender, EventArgs e)
        {
            if (task_id.Text.Trim() != "")
            {
                DialogResult result = MessageBox.Show("Are you sure do you want delete the task?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (conn.State != ConnectionState.Open)
                    {
                        try
                        {
                            conn.Open();

                            string query = "update task set deleted_date=@deleted_date where Id=@id";
                            using (SqlCommand cmd = new SqlCommand(query, conn))
                            {
                                cmd.Parameters.AddWithValue("@id", task_id.Text.Trim());
                                cmd.Parameters.AddWithValue("@deleted_date", DateTime.Today);
                                cmd.ExecuteNonQuery();
                            }
                            MessageBox.Show("Deleted Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            displayTaskData();
                            reset();
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
                else
                {
                    MessageBox.Show("Cancelled", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Please select the record", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void task_reset_btn_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void taskGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = taskGridView.Rows[e.RowIndex];
                if (row != null)
                {
                    task_id.Text = row.Cells[0].Value.ToString();
                    task_name.Text = row.Cells[1].Value.ToString();
                    task_desc.Text = row.Cells[2].Value.ToString();
                    task_project.SelectedItem = task_project.Items.Cast<KeyValuePair<int, string>>()
                .FirstOrDefault(item => item.Key == GetId("project", "name", row.Cells[3].Value.ToString()));
                    task_user.SelectedItem = task_user.Items.Cast<KeyValuePair<int, string>>()
                .FirstOrDefault(item => item.Key == GetId("users", "username", row.Cells[4].Value.ToString()));
                    task_status.SelectedItem = task_status.Items.Cast<KeyValuePair<string, string>>()
                .FirstOrDefault(item => item.Key == row.Cells[6].Value.ToString());                   
                    
                }
            }
        }

        private int GetId(string tabelName,string cname,string v)
        {
            int cid = 0;
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=G:\Ravensbourne\Advance Software Developer\Project\EmployeeManagementSystem\ems1.mdf;Integrated Security=True");
            if (conn.State != ConnectionState.Open)
            {
                try
                {
                    conn.Open();

                    string query = "select id from " + tabelName +" where "+cname+"=@name";
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
                            MessageBox.Show("Company not found", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void task_desc_TextChanged(object sender, EventArgs e)
        {

        }

        private void reset(){
            task_id.Text = "";
            task_name.Text = "";
            task_desc.Text = "";
            task_status.SelectedIndex = -1;
            task_project.SelectedIndex = -1;
            task_user.SelectedIndex = -1;
        }
    }
}
