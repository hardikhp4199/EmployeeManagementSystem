using MySqlX.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace EmployeeManagementSystem
{
    public partial class Holiday : Form{
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=G:\Ravensbourne\Advance Software Developer\Project\EmployeeManagementSystem\ems1.mdf;Integrated Security=True");
        public Holiday(){
            InitializeComponent();
            
            // Bind the combobo
            BindComboBox();
            displayHolidayList();
        }

        //Bind the data into grid view
        public void displayHolidayList(){
            //holiday data file object
            HolidayData dd = new HolidayData();
            List<HolidayData> list = dd.HolidayListData();
            holidayGridView.DataSource = list;
            holidayGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
        
        //add task function
        private void task_add_btn_Click(object sender, EventArgs e){
            // check the filed is empty or not
            if (ho_name.Text.Trim() == "" || ho_date.Text.Trim() == "" || ho_company.SelectedIndex == -1){
                MessageBox.Show("Please fill all the empty fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else{
                // check connection state is open or not
                if (conn.State != ConnectionState.Open){
                    try{
                        conn.Open();
                        KeyValuePair<int, string> selectedCompany = (KeyValuePair<int, string>)ho_company.SelectedItem;
                        int cid = selectedCompany.Key;
                        if (cid > 0){
                            DateTime insertedToday = DateTime.Today;
                            string insertQuery = " INSERT INTO holiday (name,holiday_date,company_id,insert_date) values (@holiday_name,@ho_date,@cid,@insert_date)";
                            using (SqlCommand insetCmd = new SqlCommand(insertQuery, conn))
                            {
                                insetCmd.Parameters.AddWithValue("@holiday_name", ho_name.Text.Trim());
                                insetCmd.Parameters.AddWithValue("@ho_date", ho_date.Value);
                                insetCmd.Parameters.AddWithValue("@cid", cid);
                                insetCmd.Parameters.AddWithValue("@insert_date", insertedToday);

                                insetCmd.ExecuteNonQuery();
                                MessageBox.Show("Added Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                displayHolidayList();
                                reset();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please select the valid company name", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            reset();
                        }
                    }catch (Exception ex){
                        MessageBox.Show("Contact to technical person, " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }finally{
                        conn.Close();
                    }
                }
            }
        }
        private int GetCompanyId(string v)
        {
            int cid = 0;
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=G:\Ravensbourne\Advance Software Developer\Project\EmployeeManagementSystem\ems1.mdf;Integrated Security=True");
            if (conn.State != ConnectionState.Open)
            {
                try
                {
                    conn.Open();

                    string query = "select id from company where name=@name";
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

        public void reset()
        {
            holiday_id.Text = "";
            ho_date.Text = "";
            ho_name.Text = "";
            ho_company.SelectedIndex = -1;
            holiday_id.Text = "";
        }

        private void BindComboBox()
        {
            try
            {
                string query = "SELECT Id,name FROM company where deleted_date IS NULL";
                conn.Open();
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string value = reader["name"].ToString();
                            ho_company.Items.Add(new KeyValuePair<int, string>(reader.GetInt32(0), reader.GetString(1)));
                            ho_company.DisplayMember = "Value";
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

        private void holidayGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = holidayGridView.Rows[e.RowIndex];
                if (row != null)
                {
                    holiday_id.Text = row.Cells[0].Value.ToString();
                    ho_name.Text = row.Cells[1].Value.ToString();
                    ho_date.Value = (DateTime)row.Cells[2].Value;
                    ho_company.SelectedItem = ho_company.Items.Cast<KeyValuePair<int, string>>()
                .FirstOrDefault(item => item.Key == GetCompanyId(row.Cells[3].Value.ToString()));
                }
            }
        }

        private void task_reset_btn_Click_1(object sender, EventArgs e)
        {
            reset();
        }

        //update click event button: update task details 
        private void task_up_btn_Click(object sender, EventArgs e){
            // confirmation message prompt
            DialogResult result = MessageBox.Show("Are you sure do you want update the holiday?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes){
                // check the any field empty or not
                if (ho_name.Text.Trim() == "" || ho_date.Text.Trim() == "" || ho_company.SelectedIndex == -1){
                    MessageBox.Show("Please fill all the empty fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }else{
                    if (conn.State != ConnectionState.Open){
                        try{
                            conn.Open();
                            KeyValuePair<int, string> selectedCompany = (KeyValuePair<int, string>)ho_company.SelectedItem;
                            int cid = selectedCompany.Key;
                            if (cid > 0){
                                string query = "update holiday set name=@name,holiday_date=@holiday_date,company_id=@company_id,updated_date=@updated_date where Id=@hid";
                                using (SqlCommand cmd = new SqlCommand(query, conn)){
                                    cmd.Parameters.AddWithValue("@hid", holiday_id.Text.Trim());
                                    cmd.Parameters.AddWithValue("@name", ho_name.Text.Trim());
                                    cmd.Parameters.AddWithValue("@holiday_date", ho_date.Value);
                                    cmd.Parameters.AddWithValue("@company_id", cid);
                                    cmd.Parameters.AddWithValue("@updated_date", DateTime.Today);

                                    cmd.ExecuteNonQuery();
                                    MessageBox.Show("Updated Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    displayHolidayList();
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
                        }finally{
                            conn.Close();
                        }
                    }
                }
            }
        }

        private void task_remove_btn_Click(object sender, EventArgs e)        {
            DialogResult result = MessageBox.Show("Are you sure do you want delete the holiday?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes){
                if (holiday_id.Text.Trim() != ""){
                    if (conn.State != ConnectionState.Open){
                        try{
                            conn.Open();
                            DateTime today = DateTime.Today;
                            string query = "update holiday set deleted_date=@deleted_date where Id=@eid";
                            using (SqlCommand cmd = new SqlCommand(query, conn)){
                                cmd.Parameters.AddWithValue("@eid", holiday_id.Text.Trim());
                                cmd.Parameters.AddWithValue("@deleted_date", today);
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Deleted Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                displayHolidayList();
                                reset();
                            }
                        }catch (Exception ex){
                            MessageBox.Show("Contact to technical person" + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            reset();
                        }finally{
                            conn.Close();
                        }
                    }
                }else{
                    MessageBox.Show("Please select the record.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }else{
                MessageBox.Show("Cancelled", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
