using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagementSystem
{
    public partial class Employee : Form
    {
        private AdminDashboard objForm;
        private Task taskObjForm;
        private Project projectObjForm;
        private Department departmentObjForm;

        private Company companyObjForm;
        private Holiday holidayObjForm;
        private MyProfile myProfileObj;
        private Reset resetObj;


        private employeeForm employeeFormObj;
        public Employee()
        {
            InitializeComponent();

            objForm = new AdminDashboard();
            taskObjForm = new Task();
            projectObjForm = new Project();
            departmentObjForm = new Department();
            companyObjForm = new Company();
            holidayObjForm = new Holiday();
            myProfileObj = new MyProfile();
            resetObj = new Reset();

            employeeFormObj = new employeeForm();

            // Set TopLevel property to false to indicate it's a non-toplevel control
            employeeFormObj.TopLevel = false;
            objForm.TopLevel = false;
            taskObjForm.TopLevel = false;
            projectObjForm.TopLevel = false;
            departmentObjForm.TopLevel = false;
            companyObjForm.TopLevel = false;
            holidayObjForm.TopLevel = false;
            myProfileObj.TopLevel = false;
            resetObj.TopLevel = false;
            // Clear any existing controls in main_panel
            main_panel.Controls.Clear();

            // Add the admin_dashboard form to main_panel

            main_panel.Controls.Add(employeeFormObj);
            main_panel.Controls.Add(objForm);
            main_panel.Controls.Add(taskObjForm);
            main_panel.Controls.Add(projectObjForm);
            main_panel.Controls.Add(departmentObjForm);
            main_panel.Controls.Add(resetObj);

            main_panel.Controls.Add(companyObjForm);
            main_panel.Controls.Add(holidayObjForm);
            main_panel.Controls.Add(myProfileObj);

            // Show the admin_dashboard form
            objForm.Show();
            taskObjForm.Hide();
            projectObjForm.Hide();
            departmentObjForm.Hide();
            companyObjForm.Hide();
            holidayObjForm.Hide();
            employeeFormObj.Hide();
            myProfileObj.Hide();
            resetObj.Hide();
        }

        private void holidaylist_btn_Click(object sender, EventArgs e)
        {
            objForm.Hide();
            taskObjForm.Hide();
            projectObjForm.Hide();
            departmentObjForm.Hide();
            companyObjForm.Hide();
            holidayObjForm.Show();
            employeeFormObj.Hide();
            myProfileObj.Hide();
            holidayObjForm.displayHolidayList();
            resetObj.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                /*Application.Exit();*/
                MainForm obj = new MainForm();
                obj.Show();
                this.Hide();
            }
        }

        private void company_btn_Click(object sender, EventArgs e)
        {
            objForm.Hide();
            taskObjForm.Hide();
            projectObjForm.Hide();
            departmentObjForm.Hide();
            companyObjForm.Show();
            employeeFormObj.Hide();
            holidayObjForm.Hide();
            myProfileObj.Hide();
            companyObjForm.displayCompanyData();
            resetObj.Hide();
        }


        private void employee_btn_Click(object sender, EventArgs e)
        {
            resetObj.Hide();
            employeeFormObj.Show();
            objForm.Hide();
            taskObjForm.Hide();
            projectObjForm.Hide();
            departmentObjForm.Hide();
            companyObjForm.Hide();
            holidayObjForm.Hide();
            myProfileObj.Hide();
            employeeFormObj.displayEmpData();
        }

        private void department_btn_Click(object sender, EventArgs e)
        {
            resetObj.Hide();
            employeeFormObj.Hide();
            objForm.Hide();
            taskObjForm.Hide();
            projectObjForm.Hide();
            departmentObjForm.Show();
            companyObjForm.Hide();
            holidayObjForm.Hide();
            departmentObjForm.displayDeparmentData();
        }

        private void project_btn_Click(object sender, EventArgs e)
        {
            resetObj.Hide();
            employeeFormObj.Hide();
            objForm.Hide();
            taskObjForm.Hide();
            projectObjForm.Show();
            departmentObjForm.Hide();
            companyObjForm.Hide();
            holidayObjForm.Hide();

            projectObjForm.displayProductData();
        }

        private void task_btn_Click(object sender, EventArgs e)
        {
            resetObj.Hide();
            employeeFormObj.Hide();
            objForm.Hide();
            taskObjForm.Show();
            projectObjForm.Hide();
            departmentObjForm.Hide();
            companyObjForm.Hide();
            holidayObjForm.Hide();
            taskObjForm.displayTaskData();
        }

        private void main_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dashboard_btn_Click(object sender, EventArgs e)
        {
            resetObj.Hide();
            objForm.adminDashboardCount();
            employeeFormObj.Hide();
            objForm.Show();
            taskObjForm.Hide();
            projectObjForm.Hide();
            departmentObjForm.Hide();
            companyObjForm.Hide();
            holidayObjForm.Hide();
            myProfileObj.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            resetObj.Hide();
            objForm.adminDashboardCount();
            employeeFormObj.Hide();
            objForm.Show();
            taskObjForm.Hide();
            projectObjForm.Hide();
            departmentObjForm.Hide();
            companyObjForm.Hide();
            holidayObjForm.Hide();
        }

        private void welcome_username_Click(object sender, EventArgs e)
        {
            resetObj.Hide();
            objForm.adminDashboardCount();
            employeeFormObj.Hide();
            objForm.Show();
            taskObjForm.Hide();
            projectObjForm.Hide();
            departmentObjForm.Hide();
            companyObjForm.Hide();
            holidayObjForm.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            resetObj.Hide();
            objForm.Hide();
            taskObjForm.Hide();
            projectObjForm.Hide();
            departmentObjForm.Hide();
            companyObjForm.Hide();
            holidayObjForm.Hide();
            employeeFormObj.Hide();
            myProfileObj.Show();
        }

        private void resetpassword_Click(object sender, EventArgs e)
        {
            resetObj.Show();
            objForm.Hide();
            taskObjForm.Hide();
            projectObjForm.Hide();
            departmentObjForm.Hide();
            companyObjForm.Hide();
            holidayObjForm.Hide();
            employeeFormObj.Hide();
            myProfileObj.Hide();
        }
    }
}
