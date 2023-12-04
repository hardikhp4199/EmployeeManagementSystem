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
    public partial class EmployeePanel : Form
    {
        GlobalFunction obj;
        public EmployeePanel()
        {
            InitializeComponent();
            obj = new GlobalFunction();
            adminDashboardCount();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void adminDashboardCount(){
            int userId = GlobalFunction.LoggedInUserId;
            int count = 0;
            

            count = obj.GetCount("select count(t.id) from task t,users u,project p where t.project_id=p.Id and t.user_id=u.Id and t.deleted_date is null and p.deleted_date is null and u.deleted_date is null and t.status !='Completed' and t.user_id=" + userId);
            task_pending_count.Text = count.ToString();

            count = obj.GetCount("select count(t.id) from task t,users u,project p where t.project_id=p.Id and t.user_id=u.Id and t.deleted_date is null and p.deleted_date is null and u.deleted_date is null and t.status='Completed' and t.user_id=" + userId);
            task_completed.Text = count.ToString();

            count = obj.GetCount("select h.Id as holi_id, h.name,h.holiday_date, c.name as company_name  from holiday h, company c where h.deleted_date IS NULL and h.company_id=c.id and c.deleted_date IS NULL");
            holiday_count.Text = count.ToString();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void holiday_count_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
