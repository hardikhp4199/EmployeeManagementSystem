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
    public partial class EmployeeHoliday : Form
    {
        public EmployeeHoliday()
        {
            InitializeComponent();
            displayHolidayList();
        }

        private void EmployeeHoliday_Load(object sender, EventArgs e)
        {

        }
        public void displayHolidayList()
        {
            HolidayData dd = new HolidayData();

            List<HolidayData> list = dd.HolidayListData();

            holidayGridView.DataSource = list;
            holidayGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void holidayGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
