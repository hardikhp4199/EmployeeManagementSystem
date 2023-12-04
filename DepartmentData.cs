using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagementSystem
{

    class DepartmentData
    {

        public int ID { set; get; }
        public string Name { set; get; }
        public string CompanyName { set; get; }

        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=G:\Ravensbourne\Advance Software Developer\Project\EmployeeManagementSystem\ems1.mdf;Integrated Security=True");

        public List<DepartmentData> DepartmentListData()
        {
            List<DepartmentData> listdata = new List<DepartmentData>();

            if (conn.State != ConnectionState.Open)
            {
                try
                {
                    conn.Open();
                    string query = "select d.Id as deparment_id, d.dname, c.name  from department d, company c where d.deleted_date IS NULL and d.company_id=c.id and c.deleted_date IS NULL";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            DepartmentData data = new DepartmentData();
                            data.ID = (int)reader["deparment_id"];
                            data.Name = reader["dname"].ToString();
                            data.CompanyName = reader["name"].ToString();
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