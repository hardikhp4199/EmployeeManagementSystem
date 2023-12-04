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
    public partial class EmployeeMaster : Form
    {
        private EmployeePanel employeePanelObj;
        private EmployeeTask employeeTaskObj;
        private EmployeeHoliday employeeHolidayObj;
        private MyProfile myProfileObj;
        private Reset resetObj;

        public EmployeeMaster()
        {
            InitializeComponent();
            employeePanelObj = new EmployeePanel();
            employeeTaskObj = new EmployeeTask();
            employeeHolidayObj = new EmployeeHoliday();
            myProfileObj = new MyProfile();
            resetObj = new Reset();

            employeePanelObj.TopLevel = false;
            employeeTaskObj.TopLevel = false;
            employeeHolidayObj.TopLevel = false;
            myProfileObj.TopLevel = false;
            resetObj.TopLevel = false;

            main_panel.Controls.Clear();
            main_panel.Controls.Add(employeePanelObj);
            main_panel.Controls.Add(employeeTaskObj);
            main_panel.Controls.Add(employeeHolidayObj);
            main_panel.Controls.Add(myProfileObj);
            main_panel.Controls.Add(resetObj);

            employeePanelObj.Show();
            employeeTaskObj.Hide();
            employeeHolidayObj.Hide();
            myProfileObj.Hide();
            resetObj.Hide();
        }

        private void main_panel_Paint(object sender, PaintEventArgs e){

        }

        private void dashboard_btn_Click(object sender, EventArgs e){
            employeePanelObj.Show();
            employeeTaskObj.Hide();
            employeeHolidayObj.Hide();
            myProfileObj.Hide();
            resetObj.Hide();
        }

        private void task_btn_Click(object sender, EventArgs e){
            employeeTaskObj.Show();
            employeePanelObj.Hide();
            employeeHolidayObj.Hide();
            myProfileObj.Hide();
            resetObj.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes){
                // Open the login form
                MainForm obj = new MainForm();
                obj.Show();
                this.Hide();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            employeePanelObj.Show();
            employeeTaskObj.Hide();
            employeeHolidayObj.Hide();
            myProfileObj.Hide();
            resetObj.Hide();
        }

        private void welcome_username_Click(object sender, EventArgs e)
        {
            employeePanelObj.Show();
            employeeTaskObj.Hide();
            employeeHolidayObj.Hide();
            myProfileObj.Hide();
            resetObj.Hide();
        }

        private void holidaylist_btn_Click(object sender, EventArgs e)
        {
            employeeTaskObj.Hide();
            employeePanelObj.Hide();
            employeeHolidayObj.Show();
            myProfileObj.Hide();
            resetObj.Hide();
        }

        private void employee_btn_Click(object sender, EventArgs e)
        {
            employeeTaskObj.Hide();
            employeePanelObj.Hide();
            employeeHolidayObj.Hide();
            myProfileObj.Show();
            resetObj.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            employeeTaskObj.Hide();
            employeePanelObj.Hide();
            employeeHolidayObj.Hide();
            myProfileObj.Hide();
            resetObj.Show();
        }
    }
}
