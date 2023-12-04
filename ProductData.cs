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
    class ProductData
    {
        public int Id { set; get; }
        public string Name { set; get; }

        public string Description { set; get; }
        public string Status{ set; get; }

        public DateTime StartDate { set; get; }
        public String EndDate { set; get; }

        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=G:\Ravensbourne\Advance Software Developer\Project\EmployeeManagementSystem\ems1.mdf;Integrated Security=True");

        public List<ProductData> ProductDataList(string projectStatus)
        {
            List<ProductData> listdata = new List<ProductData>();
            if (conn.State != ConnectionState.Open){
                try{
                    conn.Open();

                    if (projectStatus == "") {
                        string query = "select Id,name,status,description,start_date,end_date from project where deleted_date IS NULL";

                        using (SqlCommand cmd = new SqlCommand(query, conn)){
                            SqlDataReader reader = cmd.ExecuteReader();
                            listdata=DispalyProductData(reader);
                        }
                    }
                    else

                    {
                        string query = "select Id,name,status,description,start_date,end_date from project where deleted_date IS NULL and status=@proStatus";

                        using (SqlCommand cmd = new SqlCommand(query, conn)){
                            cmd.Parameters.AddWithValue("@proStatus", projectStatus);
                            SqlDataReader reader = cmd.ExecuteReader();
                            listdata = DispalyProductData(reader);

                        }
                    }
                    
                }catch (Exception ex){
                    MessageBox.Show("Contact to technical person: testing => " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }finally{
                    conn.Close();
                }
            }
            return listdata;
        }
        public List<ProductData> DispalyProductData(SqlDataReader reader)
        {
            List<ProductData> listdata = new List<ProductData>();
            while (reader.Read())
            {
                ProductData data = new ProductData();
                data.Id = (int)reader["Id"];
                data.Name = reader["name"].ToString();
                data.Description = reader["description"].ToString();
                data.Status = reader["status"].ToString();
                data.StartDate = (DateTime)reader["start_date"];
                if (reader["end_date"].ToString() != "")
                {
                    GlobalFunction gf = new GlobalFunction();
                    data.EndDate = gf.DateFormation(reader["end_date"].ToString());
                }
                else
                {
                    data.EndDate = "-";
                }

                listdata.Add(data);
            }
            return listdata;
        }
    }
}
