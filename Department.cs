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
    public partial class Department : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=G:\Ravensbourne\Advance Software Developer\Project\EmployeeManagementSystem\ems1.mdf;Integrated Security=True");
        public Department()
        {
            InitializeComponent();
            bindComboBox();
            displayDeparmentData();
        }
        public void displayDeparmentData() {
            DepartmentData dd= new DepartmentData();
            List<DepartmentData> list = dd.DepartmentListData();
            departmentGridView.DataSource = list;
            departmentGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            departmentGridView.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;
        }
        private void task_add_btn_Click(object sender, EventArgs e)
        {
            if (dep_name.Text.Trim() == "" || dep_company_name.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill all the empty fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else
            {
                if (conn.State != ConnectionState.Open)
                {
                    try
                    {
                        conn.Open();
                        KeyValuePair<int, string> selectedCompany = (KeyValuePair<int, string>)dep_company_name.SelectedItem;
                        int cid = selectedCompany.Key;
                        if (cid > 0)
                        {
                            DateTime insertedToday = DateTime.Today;
                            string insertQuery = " INSERT INTO department (dname,company_id,insert_date) values (@dep_name,@cid,@insert_date)";
                            using (SqlCommand insetCmd = new SqlCommand(insertQuery, conn))
                            {
                                insetCmd.Parameters.AddWithValue("@dep_name", dep_name.Text.Trim());
                                insetCmd.Parameters.AddWithValue("@cid", cid);
                                insetCmd.Parameters.AddWithValue("@insert_date", insertedToday);

                                insetCmd.ExecuteNonQuery();
                                MessageBox.Show("Added Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                displayDeparmentData();
                                reset();
                            }
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
        }

        private void task_up_btn_Click(object sender, EventArgs e){
            if (dep_name.Text.Trim() == "" ||  dep_company_name.SelectedIndex == -1){
                MessageBox.Show("Please fill all the empty fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else{
                 if(dep_id.Text.Trim() != "") { 
                    DialogResult result = MessageBox.Show("Are you sure do you want update the department?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes){
                        if (conn.State != ConnectionState.Open){
                            try{
                                conn.Open();
                                KeyValuePair<int, string> selectedCompany = (KeyValuePair<int, string>)dep_company_name.SelectedItem;
                                int cid = selectedCompany.Key;
                                if (cid > 0){
                                    string query = "update department set dname=@name,company_id=@company_id,updated_date=@updated_date where Id=@did";
                                    using (SqlCommand cmd = new SqlCommand(query, conn))
                                    {
                                        cmd.Parameters.AddWithValue("@did", dep_id.Text.Trim());
                                        cmd.Parameters.AddWithValue("@name", dep_name.Text.Trim());
                                        cmd.Parameters.AddWithValue("@company_id", cid);
                                        cmd.Parameters.AddWithValue("@updated_date", DateTime.Today);

                                        cmd.ExecuteNonQuery();
                                        MessageBox.Show("Updated Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    
                                        displayDeparmentData();
                                        reset();
                                    }
                                }
                                else{
                                    MessageBox.Show("Please select the valid company name", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    reset();
                                }
                            }
                            catch (Exception ex){
                                MessageBox.Show("Contact to technical person, " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            finally{
                                conn.Close();
                            }
                        }
                    }else
                    {
                        MessageBox.Show("Cancelled", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                 }else{
                    MessageBox.Show("Please fill all the empty fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                  }
            }
        }

        private void task_remove_btn_Click(object sender, EventArgs e){
            if (dep_id.Text.Trim() != ""){
                DialogResult result = MessageBox.Show("Are you sure do you want delete the department?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes){
                    if (conn.State != ConnectionState.Open){
                        try{
                            conn.Open();
                            DateTime today = DateTime.Today;
                            string query = "update department set deleted_date=@deleted_date where Id=@id";
                            using (SqlCommand cmd = new SqlCommand(query, conn))
                            {
                                cmd.Parameters.AddWithValue("@id", dep_id.Text.Trim());
                                cmd.Parameters.AddWithValue("@deleted_date", today);
                                cmd.ExecuteNonQuery();

                                MessageBox.Show("Deleted Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                displayDeparmentData();
                                reset();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Contact to technical person" + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            reset();
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
            }else{
                MessageBox.Show("Please select the record.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void task_reset_btn_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void bindComboBox()
        {
            try
            {
                string query = "SELECT Id,name FROM company where deleted_date is null";
                conn.Open();
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string value = reader["name"].ToString();
                            dep_company_name.Items.Add(new KeyValuePair<int, string>(reader.GetInt32(0), reader.GetString(1)));
                            dep_company_name.DisplayMember = "Value";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void reset()
        {
            dep_name.Text = "";
            dep_company_name.SelectedIndex = -1;
            dep_name.Focus();
            dep_id.Text = "";
        }

        private void departmentGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = departmentGridView.Rows[e.RowIndex];
                if (row != null)
                {
                    dep_id.Text = row.Cells[0].Value.ToString();
                    dep_name.Text = row.Cells[1].Value.ToString();
                    dep_company_name.SelectedItem = dep_company_name.Items.Cast<KeyValuePair<int, string>>()
                .FirstOrDefault(item => item.Key == GetCompanyId(row.Cells[2].Value.ToString()));
                }
            }
        }
        private int GetCompanyId(string v){
            int cid = 0;
            if (conn.State != ConnectionState.Open)
            {
                try{
                    conn.Open();
                    string query = "select id from company where name=@name";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", v);
                        object result = cmd.ExecuteScalar();
                        if (result != null){
                            cid = Convert.ToInt32(result);
                        }else{
                            MessageBox.Show("Company not found", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex){
                    MessageBox.Show("Contact to technical person, " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally{
                    conn.Close();
                }
            }
            return cid;
        }
    }
}
