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
    class ComapnyData
    {
        public int ID { set; get; }
        public string Name { set; get; }
        public string MobileNumber { set; get; }
        public string EmailId { set; get; }
        public string Address { set; get; }
        public string PostCode { set; get; }

        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=G:\Ravensbourne\Advance Software Developer\Project\EmployeeManagementSystem\ems1.mdf;Integrated Security=True");

        public List<ComapnyData> DepartmentListData()
        {
            List<ComapnyData> listdata = new List<ComapnyData>();

            if (conn.State != ConnectionState.Open)
            {
                try
                {
                    conn.Open();
                    string query = "select * from company where deleted_date is null";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            ComapnyData data = new ComapnyData();
                            data.ID = (int)reader["Id"];
                            data.Name = reader["name"].ToString();
                            data.MobileNumber = reader["mobile_number"].ToString();
                            data.EmailId = reader["email_id"].ToString();
                            data.Address = reader["address1"].ToString();
                            data.PostCode = reader["postcode"].ToString();
                            listdata.Add(data);
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Contact to technical person: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
