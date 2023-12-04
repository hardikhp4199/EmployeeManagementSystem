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
    public partial class Project : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=G:\Ravensbourne\Advance Software Developer\Project\EmployeeManagementSystem\ems1.mdf;Integrated Security=True");

        public Project(){
            InitializeComponent();
            bindComboBox();
            displayProductData();
        }
        private void bindComboBox()
        {
            try{
                pro_status.Items.Add(new KeyValuePair<string, string>("Start", "Start"));
                pro_status.Items.Add(new KeyValuePair<string, string>("Running", "Running"));
                pro_status.Items.Add(new KeyValuePair<string, string>("Completed", "Completed"));
                pro_status.DisplayMember = "Value";
            }catch (Exception ex){
                MessageBox.Show("Something is wrong contact to techinal person." + ex.Message);
            }
        }
        public void displayProductData(){
            ProductData dd = new ProductData();
            List<ProductData> list = dd.ProductDataList("");
            projectGrid.DataSource = list;
            projectGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            projectGrid.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;
        }

        private void pro_add_btn_Click(object sender, EventArgs e){
            if (pro_name.Text.Trim() == "" || pro_desc.Text.Trim() == "" || pro_status.SelectedItem == null){
                MessageBox.Show("Please fill all the empty fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else{
                if (conn.State != ConnectionState.Open){
                    try{
                        conn.Open();
                        KeyValuePair<string, string> selectedProject= (KeyValuePair<string, string>)pro_status.SelectedItem;
                        string stutus = selectedProject.Key;
                        if (stutus != "")
                        {
                            string insertQuery = " INSERT INTO project (name,description,status,start_date,insert_date) values (@pro_name,@pro_desc,@status,@start_date,@insert_date)";
                            using (SqlCommand insetCmd = new SqlCommand(insertQuery, conn))
                            {
                                insetCmd.Parameters.AddWithValue("@pro_name",pro_name.Text.Trim());
                                insetCmd.Parameters.AddWithValue("@pro_desc", pro_desc.Text.Trim());
                                insetCmd.Parameters.AddWithValue("@status", stutus);
                                insetCmd.Parameters.AddWithValue("@start_date", DateTime.Today);
                                insetCmd.Parameters.AddWithValue("@insert_date", DateTime.Today);

                                insetCmd.ExecuteNonQuery();
                                MessageBox.Show("Added Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                displayProductData();
                                reset();
                            }
                        }else{
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

        private void pro_up_btn_Click(object sender, EventArgs e){
            if (pro_name.Text.Trim() == "" || pro_desc.Text.Trim() == "" || pro_status.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill all the empty fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (pro_id.Text.Trim() != "")
                {
                    DialogResult result = MessageBox.Show("Are you sure do you want update the product?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes){
                        if (conn.State != ConnectionState.Open){
                            try{
                                conn.Open();
                                KeyValuePair<string, string> selectedCompany = (KeyValuePair<string, string>)pro_status.SelectedItem;
                                string status = selectedCompany.Key;
                                if (status != ""){
                                    if (status == "Completed") {
                                        string query = "update project set name=@name,description=@desc,status=@status,end_date=@end_date,updated_date=@updated_date where Id=@did";
                                        using (SqlCommand cmd = new SqlCommand(query, conn))
                                        {
                                            cmd.Parameters.AddWithValue("@did", pro_id.Text.Trim());
                                            cmd.Parameters.AddWithValue("@name", pro_name.Text.Trim());
                                            cmd.Parameters.AddWithValue("@desc", pro_desc.Text.Trim());
                                            cmd.Parameters.AddWithValue("@status", status);
                                            cmd.Parameters.AddWithValue("@end_date", DateTime.Today);
                                            cmd.Parameters.AddWithValue("@updated_date", DateTime.Today);

                                            cmd.ExecuteNonQuery();
                                            MessageBox.Show("Updated Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                            displayProductData();
                                            reset();
                                        }
                                    } else {
                                        string query = "update project set name=@name,description=@desc,status=@status,updated_date=@updated_date where Id=@did";
                                        using (SqlCommand cmd = new SqlCommand(query, conn))
                                        {
                                            cmd.Parameters.AddWithValue("@did", pro_id.Text.Trim());
                                            cmd.Parameters.AddWithValue("@name", pro_name.Text.Trim());
                                            cmd.Parameters.AddWithValue("@desc", pro_desc.Text.Trim());
                                            cmd.Parameters.AddWithValue("@status", status);
                                            cmd.Parameters.AddWithValue("@updated_date", DateTime.Today);

                                            cmd.ExecuteNonQuery();
                                            MessageBox.Show("Updated Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                            displayProductData();
                                            reset();
                                        }
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

        private void pro_remove_btn_Click(object sender, EventArgs e){
            
            if (pro_id.Text.Trim() != ""){
                DialogResult result = MessageBox.Show("Are you sure do you want delete the project?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes){
                    if (conn.State != ConnectionState.Open){
                        try{
                            conn.Open();
                            
                            string query = "update project set deleted_date=@delete_date where Id=@did";
                            using (SqlCommand cmd = new SqlCommand(query, conn)){
                                cmd.Parameters.AddWithValue("@did", pro_id.Text.Trim());
                                cmd.Parameters.AddWithValue("@delete_date", DateTime.Today);

                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Deleted Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                displayProductData();
                                reset();
                            }
                        }
                        catch (Exception ex){
                            MessageBox.Show("Contact to technical person, " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            reset();
                        }
                        finally{
                            conn.Close();
                        }
                    }
                }
                else{
                    MessageBox.Show("Cancelled", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    reset();
                }
            }else{
                MessageBox.Show("Please select the record", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pro_reset_btn_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void reset(){
            pro_id.Text = "";
            pro_name.Text = "";
            pro_desc.Text = "";
            pro_status.SelectedIndex= -1;
        }

        private void projectGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = projectGrid.Rows[e.RowIndex];
                if (row != null)
                {
                    pro_id.Text = row.Cells[0].Value.ToString();
                    pro_name.Text = row.Cells[1].Value.ToString();
                    pro_desc.Text = row.Cells[2].Value.ToString();
                    pro_status.SelectedItem = pro_status.Items.Cast<KeyValuePair<string, string>>()
                .FirstOrDefault(item => item.Key == row.Cells[3].Value.ToString());
                }
            }
        }
    }
}
