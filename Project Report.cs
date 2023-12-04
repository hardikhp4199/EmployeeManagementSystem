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
    public partial class Project_Report : Form
    {
        public Project_Report()
        {
            InitializeComponent();
            bindStatusComboBox();
            displayProjectData();
            
        }
        public void displayProjectData()
        {
            string selectedStuats = "";
            
            if (projectStatus.SelectedIndex != -1)
            {
                KeyValuePair<string, string> selectedStatus = (KeyValuePair<string, string>)projectStatus.SelectedItem;
                selectedStuats = selectedStatus.Key;
            }
            ProductData dd = new ProductData();
            List<ProductData> list = dd.ProductDataList(selectedStuats);
            projectGridView.DataSource = list;
            projectGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            projectGridView.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;
        }
        private void bindStatusComboBox(){
            try
            {
                projectStatus.Items.Add(new KeyValuePair<string, string>("Start", "Start"));
                projectStatus.Items.Add(new KeyValuePair<string, string>("Running", "Running"));
                projectStatus.Items.Add(new KeyValuePair<string, string>("Completed", "Completed"));
                projectStatus.DisplayMember = "Value";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something is wrong contact to techinal person." + ex.Message);
            }
        }
        

        private void projectStatus_SelectedIndexChanged(object sender, EventArgs e) { 
            displayProjectData();
        }

        
        private void reset_Click_1(object sender, EventArgs e)
        {
            projectStatus.SelectedIndex = -1;
            displayProjectData();
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
            Employee obj = new Employee();
            obj.Show();
        }

        private void projectGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
