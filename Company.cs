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
using System.Xml.Linq;

namespace EmployeeManagementSystem
{
    public partial class Company : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=G:\Ravensbourne\Advance Software Developer\Project\EmployeeManagementSystem\ems1.mdf;Integrated Security=True");
        GlobalFunction pobj;
        public Company()
        {
            InitializeComponent();
            displayCompanyData();
            pobj = new GlobalFunction();
        }

        public void displayCompanyData()
        {
            ComapnyData dd = new ComapnyData();

            List<ComapnyData> list = dd.DepartmentListData();

            companyGridView.DataSource = list;
            companyGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            companyGridView.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;
        }
        private void com_add_btn_Click(object sender, EventArgs e)
        {
            if (com_name.Text.Trim() == "" || com_mobile_number.Text.Trim() == "" || com_email.Text.Trim() == "" || com_address.Text.Trim() == "" || com_postcode.Text.Trim() == "")
            {
                MessageBox.Show("Please fill all the empty fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else if (!pobj.IsValidMobileNumber(com_mobile_number.Text.Trim())){
                MessageBox.Show("Please enter the valid mobile number", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!pobj.IsValidEmailAddress(com_email.Text.Trim()))
            {
                MessageBox.Show("Please enter the valid email address", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (conn.State != ConnectionState.Open)
                {
                    try
                    {
                        conn.Open();
                        DateTime today = DateTime.Today;
                        string query = " INSERT INTO company (name,mobile_number,email_id,address1,postcode,insert_date) values (@name,@mobile_number,@email_id,@address1,@postcode,@insert_date)";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@name", com_name.Text.Trim());
                            cmd.Parameters.AddWithValue("@mobile_number", com_mobile_number.Text.Trim());
                            cmd.Parameters.AddWithValue("@email_id", com_email.Text.Trim());
                            cmd.Parameters.AddWithValue("@address1", com_address.Text.Trim());
                            cmd.Parameters.AddWithValue("@postcode", com_postcode.Text.Trim());
                            cmd.Parameters.AddWithValue("@insert_date", today);

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Added Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            displayCompanyData();
                            reset();
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Contact to technical person" + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        conn.Close();
                    }
                }

            }
        }

        private void companyGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if ( e.RowIndex != -1) { 
                DataGridViewRow row = companyGridView.Rows[e.RowIndex];
                if ( row != null )
                {
                    empid.Text = row.Cells[0].Value.ToString();
                    com_name.Text = row.Cells[1].Value.ToString();
                    com_mobile_number.Text = row.Cells[2].Value.ToString();
                    com_email.Text = row.Cells[3].Value.ToString();
                    com_address.Text = row.Cells[4].Value.ToString();
                    com_postcode.Text = row.Cells[5].Value.ToString();
                }
            }
        }

        private void com_reset_btn_Click(object sender, EventArgs e)
        {
            reset();
        }

        public void reset()
        {
            com_name.Text = "";
            com_mobile_number.Text = "";
            com_email.Text = "";
            com_address.Text = "";
            com_postcode.Text = "";
        }

        private void com_up_btn_Click(object sender, EventArgs e)
        {
            if (com_name.Text.Trim() == "" || com_mobile_number.Text.Trim() == "" || com_email.Text.Trim() == "" || com_address.Text.Trim() == "" || com_postcode.Text.Trim() == "")
            {
                MessageBox.Show("Please fill all the empty fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!pobj.IsValidMobileNumber(com_mobile_number.Text.Trim()))
            {
                MessageBox.Show("Please enter the valid mobile number", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!pobj.IsValidEmailAddress(com_email.Text.Trim()))
            {
                MessageBox.Show("Please enter the valid email address", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult result = MessageBox.Show("Are you sure do you want update the company?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (conn.State != ConnectionState.Open)
                    {
                        try
                        {
                            conn.Open();
                            DateTime today = DateTime.Today;
                            string query = "update company set name=@name,mobile_number=@mobile_number,email_id=@email_id,address1=@address1,postcode=@postcode,updated_date=@updated_date where Id=@eid";
                            using (SqlCommand cmd = new SqlCommand(query, conn))
                            {
                                cmd.Parameters.AddWithValue("@eid", empid.Text.Trim());
                                cmd.Parameters.AddWithValue("@name", com_name.Text.Trim());
                                cmd.Parameters.AddWithValue("@mobile_number", com_mobile_number.Text.Trim());
                                cmd.Parameters.AddWithValue("@email_id", com_email.Text.Trim());
                                cmd.Parameters.AddWithValue("@address1", com_address.Text.Trim());
                                cmd.Parameters.AddWithValue("@postcode", com_postcode.Text.Trim());
                                cmd.Parameters.AddWithValue("@updated_date", today);

                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Updated Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                displayCompanyData();
                                reset();
                            }

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Contact to technical person" + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        }

        private void com_remove_btn_Click(object sender, EventArgs e)
        {
            if (empid.Text.Trim() != "")
            {
                DialogResult result = MessageBox.Show("Are you sure do you want delete the company?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (conn.State != ConnectionState.Open)
                    {
                        try
                        {
                            conn.Open();
                            DateTime today = DateTime.Today;
                            string query = "update company set deleted_date=@deleted_date where Id=@eid";
                            using (SqlCommand cmd = new SqlCommand(query, conn))
                            {
                                cmd.Parameters.AddWithValue("@eid", empid.Text.Trim());
                                cmd.Parameters.AddWithValue("@deleted_date", today);

                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Deleted Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                displayCompanyData();
                                reset();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Contact to technical person" + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Please select the record.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
