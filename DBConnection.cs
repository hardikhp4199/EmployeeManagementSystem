using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace EmployeeManagementSystem
{
    class DBConnection
    {
        SqlConnection conn; 
        public bool Open(){
            var connectionString = ConfigurationManager.ConnectionStrings["EmployeeManagementSystem"].ConnectionString;
            connectionString = @connectionString.ToLower();
            conn = new SqlConnection(connectionString);

            if (conn.State != ConnectionState.Open){

                try{
                    conn.Open();
                    return true;
                }catch (Exception ex){
                    MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }finally{
                    Close();
                }
            }
            return false;
        }

        public void Close()
        {
            conn.Close();
            conn.Dispose();
        }        
    }
}
