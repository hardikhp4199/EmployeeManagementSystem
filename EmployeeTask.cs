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
    public partial class EmployeeTask : Form
    {
        public EmployeeTask()
        {
            InitializeComponent();
            displayTaskData();
        }

        private void EmployeeTask_Load(object sender, EventArgs e)
        {

        }
        public void displayTaskData()
        {
            EmployeeTaskData dd = new EmployeeTaskData();
            List<EmployeeTaskData> list = dd.TaskListData();
            taskGridView.DataSource = list;
            taskGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            taskGridView.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;
        }
    }
}
