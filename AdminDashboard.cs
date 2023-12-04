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
    public partial class AdminDashboard : Form
    {
        GlobalFunction obj;
        public AdminDashboard()
        {
            InitializeComponent();
            obj = new GlobalFunction();
            adminDashboardCount();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {

        }

        public void adminDashboardCount(){
            int count = 0;
            count=obj.GetCount("select count(*) from department d, company c where d.company_id = c.Id and d.deleted_date is null and c.deleted_date is null");
            dep_count.Text= count.ToString();

            count= obj.GetCount("select count(*) from users u, user_role ur where u.user_role_id= ur.Id and u.deleted_date is null and ur.deleted_date is null and ur.role='employee'");
            employee_count.Text = count.ToString();

            count = obj.GetCount("select count(*) from project where deleted_date is null");
            project_count.Text = count.ToString();

            count = obj.GetCount("select count(t.id) from task t,users u,project p where t.project_id=p.Id and t.user_id=u.Id and t.deleted_date is null and p.deleted_date is null and u.deleted_date is null");
            task_count.Text = count.ToString();
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void taskreport_Click(object sender, EventArgs e)
        {
            TaskReport pobj = new TaskReport();
            pobj.Show();
            this.Hide();
            Employee obj = new Employee();
            obj.Hide();
            
        }
        private void projectreport_Click(object sender, EventArgs e){

            Project_Report pobj = new Project_Report();
            pobj.Show();
            this.Hide();
            Employee obj = new Employee();
            obj.Hide();
        }
    }
}
