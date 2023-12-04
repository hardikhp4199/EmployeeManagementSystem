using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Org.BouncyCastle.Bcpg;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Runtime.Remoting.Messaging;

namespace EmployeeManagementSystem
{
    class TaskData
    {
        public int ID { set; get; } // 0
        public string Name { set; get; } //1 
        public string Description { set; get; } //2
        public string ProjectName { set; get; } //3

        public string UserName { set; get; } // 4
        public DateTime StartDate { set; get; } // 5

        public string Status { set; get; } //7
        public string EndDate { set; get; } //6
        

        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=G:\Ravensbourne\Advance Software Developer\Project\EmployeeManagementSystem\ems1.mdf;Integrated Security=True");

        public List<TaskData> TaskListData(int projectId, int userId, string sta)
        {
            List<TaskData> listdata = new List<TaskData>();
            if (conn.State != ConnectionState.Open)
            {
                try
                {
                    string query = "";
                    conn.Open();

                    if (projectId != 0 && userId == 0 && sta == "")
                    {
                        query = "select t.id, t.name , t.description, p.name as projectname, t.start_date, t.end_date, t.status as taskStatus, u.fname as username from  users u, project p, task t where t.project_id = p.Id and t.user_id = u.Id and u.deleted_date IS NULL and t.deleted_date IS NULL and p.deleted_date IS NULL and t.project_id=@project_id";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@project_id", projectId);
                            SqlDataReader reader = cmd.ExecuteReader();
                            
                            listdata = dispalyData(reader);
                        }

                    }
                    else if (projectId != 0 && userId != 0 && sta == "")
                    {
                        query = "select t.id, t.name , t.description, p.name as projectname, t.start_date, t.end_date, t.status as taskStatus, u.fname as username from  users u, project p, task t where t.project_id = p.Id and t.user_id = u.Id and u.deleted_date IS NULL and t.deleted_date IS NULL and p.deleted_date IS NULL and t.project_id=@project_id and t.user_id=@user_id";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@project_id", projectId);
                            cmd.Parameters.AddWithValue("@user_id", userId);
                            SqlDataReader reader = cmd.ExecuteReader();
                            
                            listdata = dispalyData(reader);
                        }

                    }
                    else if (projectId != 0 && userId == 0 && sta == "")
                    {
                        query = "select t.id, t.name , t.description, p.name as projectname, t.start_date, t.end_date, t.status as taskStatus, u.fname as username from  users u, project p, task t where t.project_id = p.Id and t.user_id = u.Id and u.deleted_date IS NULL and t.deleted_date IS NULL and p.deleted_date IS NULL and t.project_id=@project_id and t.status=@status";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@project_id", projectId);
                            cmd.Parameters.AddWithValue("@status", sta);
                            SqlDataReader reader = cmd.ExecuteReader();
                            

                            listdata = dispalyData(reader);
                        }

                    }
                    else if (projectId == 0 && userId != 0 && sta == ""){
                        query = "select t.id, t.name , t.description, p.name as projectname, t.start_date, t.end_date, t.status as taskStatus, u.fname as username from  users u, project p, task t where t.project_id = p.Id and t.user_id = u.Id and u.deleted_date IS NULL and t.deleted_date IS NULL and p.deleted_date IS NULL  and t.user_id=@user_id" + userId;
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@user_id", userId);
                            SqlDataReader reader = cmd.ExecuteReader();
                            listdata = dispalyData(reader);

                        }
                    }
                    else if (projectId == 0 && userId != 0 && sta != ""){
                        query = "select t.id, t.name , t.description, p.name as projectname, t.start_date, t.end_date, t.status as taskStatus, u.fname as username from  users u, project p, task t where t.project_id = p.Id and t.user_id = u.Id and u.deleted_date IS NULL and t.deleted_date IS NULL and p.deleted_date IS NULL and t.user_id=@user_id and t.status=@status";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@user_id", userId);
                            cmd.Parameters.AddWithValue("@status", sta);
                            SqlDataReader reader = cmd.ExecuteReader();
                            

                            listdata = dispalyData(reader);
                        }

                    }
                    else if (projectId == 0 && userId == 0 && sta != "")
                    {
                        query = "select t.id, t.name , t.description, p.name as projectname, t.start_date, t.end_date, t.status as taskStatus, u.fname as username from  users u, project p, task t where t.project_id = p.Id and t.user_id = u.Id and u.deleted_date IS NULL and t.deleted_date IS NULL and p.deleted_date IS NULL and t.status=@status";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@status", sta);
                            SqlDataReader reader = cmd.ExecuteReader();
                            

                            listdata = dispalyData(reader);
                        }
                    }
                    else if (projectId != 0 && userId != 0 && sta != "")
                    {
                        query = "select t.id, t.name , t.description, p.name as projectname, t.start_date, t.end_date, t.status as taskStatus, u.fname as username from  users u, project p, task t where t.project_id = p.Id and t.user_id = u.Id and u.deleted_date IS NULL and t.deleted_date IS NULL and p.deleted_date IS NULL and t.project_id=@project_id and t.user_id=@user_id and t.status=@status";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@project_id", projectId);
                            cmd.Parameters.AddWithValue("@user_id", userId);
                            cmd.Parameters.AddWithValue("@status", sta);
                            SqlDataReader reader = cmd.ExecuteReader();
                            

                            listdata = dispalyData(reader);
                        }
                    }
                    else
                    {
                        query = "select t.id, t.name , t.description, p.name as projectname, t.start_date, t.end_date, t.status as taskStatus, u.fname as username from  users u, project p, task t where t.project_id = p.Id and t.user_id = u.Id and u.deleted_date IS NULL and t.deleted_date IS NULL and p.deleted_date IS NULL";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            SqlDataReader reader = cmd.ExecuteReader();

                            listdata = dispalyData(reader);
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

        public List<TaskData> dispalyData(SqlDataReader reader)
        {
            List<TaskData> listdata = new List<TaskData>();
            while (reader.Read())
            {
                TaskData data = new TaskData();
                data.ID = (int)reader["id"];
                data.Name = reader["name"].ToString();
                data.Description = reader["description"].ToString();
                data.ProjectName = reader["projectname"].ToString();
                data.UserName = reader["username"].ToString();
                data.StartDate = (DateTime)reader["start_date"];
                if (reader["end_date"].ToString() != "")
                {
                    GlobalFunction gf = new GlobalFunction();
                    data.EndDate = gf.DateFormation(reader["end_date"].ToString());
                }
                else
                {
                    data.EndDate = reader["end_date"].ToString();
                }
                data.Status = reader["taskStatus"].ToString();
                listdata.Add(data);
            }
            return listdata;
        }
        public List<TaskData> EmployeeTaskListData()
        {
            List<TaskData> listdata = new List<TaskData>();

            if (conn.State != ConnectionState.Open)
            {
                try
                {
                    conn.Open();
                    int userId=  GlobalFunction.LoggedInUserId;
                    string query = "select t.id, t.name , t.description, p.name as projectname, t.start_date, t.end_date, t.status, u.fname as username from  users u, project p, task t where t.project_id = p.Id and t.user_id = u.Id and u.deleted_date IS NULL and t.deleted_date IS NULL and p.deleted_date IS NULL and u.Id="+ userId;

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            TaskData data = new TaskData();
                            data.ID = (int)reader["id"];
                            data.Name = reader["name"].ToString();
                            data.Description = reader["description"].ToString();
                            data.ProjectName = reader["projectname"].ToString();
                            data.UserName = reader["username"].ToString();
                            data.StartDate = (DateTime)reader["start_date"];
                            if (reader["end_date"].ToString() != "")
                            {
                                GlobalFunction gf = new GlobalFunction();
                                data.EndDate = gf.DateFormation(reader["end_date"].ToString());
                            }
                            else
                            {
                                data.EndDate = reader["end_date"].ToString();
                            }

                            data.Status = reader["status"].ToString();
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
