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
using System.Xml.Linq;


namespace EmployeeManagementSystem{
    class HolidayData{
        public int ID { set; get; } // 0
        public string Name { set; get; }
        public DateTime HolidayDate { set; get; }
        public string CompanyName { set; get; }
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=G:\Ravensbourne\Advance Software Developer\Project\EmployeeManagementSystem\ems1.mdf;Integrated Security=True");
        public List<HolidayData> HolidayListData(){
            List<HolidayData> listdata = new List<HolidayData>();

            if (conn.State != ConnectionState.Open){
                try{
                    conn.Open();
                    string query = "select h.Id as holi_id, h.name,h.holiday_date, c.name as company_name  from holiday h, company c where h.deleted_date IS NULL and h.company_id=c.id and c.deleted_date IS NULL";
                    using (SqlCommand cmd = new SqlCommand(query, conn)){
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read()){
                            HolidayData data = new HolidayData();
                            data.ID = (int)reader["holi_id"];
                            data.Name = reader["name"].ToString();
                            data.HolidayDate = (DateTime)reader["holiday_date"];
                            data.CompanyName = reader["company_name"].ToString();
                            listdata.Add(data);
                        }
                    }
                }
                catch (Exception ex){
                    MessageBox.Show("Contact to technical person." + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally{
                    conn.Close();
                }
            }
            return listdata;
        }
    }
}
