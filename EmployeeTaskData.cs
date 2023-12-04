using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagementSystem{
    class EmployeeTaskData{
        public int ID { set; get; } // 0
        public string Name { set; get; } //1 
        public string Description { set; get; } //2
        public string ProjectName { set; get; } //3
        public DateTime StartDate { set; get; } // 5
        public string EndDate { set; get; } //6
        public string Status { set; get; } //7

        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=G:\Ravensbourne\Advance Software Developer\Project\EmployeeManagementSystem\ems1.mdf;Integrated Security=True");

        public List<EmployeeTaskData> TaskListData(){
            List<EmployeeTaskData> listdata = new List<EmployeeTaskData>();

            if (conn.State != ConnectionState.Open){
                try{
                    conn.Open();

                    int userId = GlobalFunction.LoggedInUserId;
                    string query = "select t.id, t.name, t.description, p.name as projectname, t.start_date, t.end_date, t.status from  users u, project p, task t where t.project_id = p.Id and t.user_id = u.Id and u.deleted_date IS NULL and t.deleted_date IS NULL and p.deleted_date IS NULL and u.Id=" + userId;

                    using (SqlCommand cmd = new SqlCommand(query, conn)){
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read()){
                            EmployeeTaskData data = new EmployeeTaskData();
                            data.ID = (int)reader["id"];
                            data.Name = reader["name"].ToString();
                            data.Description = reader["description"].ToString();
                            data.ProjectName = reader["projectname"].ToString();
                            data.StartDate = (DateTime)reader["start_date"];
                            if (reader["end_date"].ToString() != ""){
                                GlobalFunction gf = new GlobalFunction();
                                data.EndDate = gf.DateFormation(reader["end_date"].ToString());
                            }else{
                                data.EndDate = reader["end_date"].ToString();
                            }
                            data.Status = reader["status"].ToString();
                            listdata.Add(data);
                        }
                    }
                }
                catch (Exception ex){
                    MessageBox.Show("Contact to technical person." + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }finally{
                    conn.Close();
                }
            }
            return listdata;
        }
    }
}