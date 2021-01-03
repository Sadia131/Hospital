using HospitalManagement1.BussinessLogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagement1.PresentationLayer
{
    public partial class EmployeeManagement : Form
    {
        HomePage homePage;
        public EmployeeManagement(HomePage homePage)
        {
            this.homePage = homePage;
            InitializeComponent();
            AddEmployeebutton.Click += this.RefreshGridView;
            deletebutton.Click += this.RefreshGridView;
            updateEmployeebutton.Click += this.RefreshGridView;

        }



        private void EmployeeManagement_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        void RefreshGridView(object sender, EventArgs e)
        {
            EmployeeService employeeService = new EmployeeService();
            EmployeelistGridView.DataSource = employeeService.GetEmployeesList();
        }

        private void EmployeeManagement_Load(object sender, EventArgs e)
        {
            EmployeeService employeeService = new EmployeeService();
            EmployeelistGridView.DataSource = employeeService.GetEmployeesList();
            StaffService staffService = new StaffService();
            AddEmployeeStaflistcomboBox.DataSource = staffService.GetStaffNameList();
        }


        private void ClearInputFields()
        {
            AddEmployeeNametextBox.Text = updateEmployeetextBox.Text = deletetextBox.Text = string.Empty;

        }

        private void AddEmployeebutton_Click(object sender, EventArgs e)
        {
            EmployeeService employeeService = new EmployeeService();
            int result = employeeService.AddNewEmployee(AddEmployeeNametextBox.Text, AddOccupationtextBox.Text, AddSpecialisttextBox.Text,AddSalarytextBox.Text, AddEmployeeStaflistcomboBox.Text);
            if (result > 0)
            {
                MessageBox.Show("New Employee added");
                ClearInputFields();
            }
            else
            {
                MessageBox.Show("Error in adding new Employee");
            }

        }

        private void searchEmployeetextBox_TextChanged(object sender, EventArgs e)
        {
            EmployeeService employeeService = new EmployeeService();
            searchEmployeedataGridView.DataSource = employeeService.GetEmployeesListForSearch(searchEmployeetextBox.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            homePage.Show();
            this.Hide();
        }

        private void deletebutton_Click(object sender, EventArgs e)
        {
            EmployeeService employeeService = new EmployeeService();
            int result = employeeService.DeleteEmployee(Convert.ToInt32(deletetextBox.Text));
            if (result > 0)
            {
                MessageBox.Show("Employee deleted");
                ClearInputFields();
            }
            else
            {
                MessageBox.Show("Error!!");
            }

        }
        int id = 0;
        private void EmployeelistGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = (int) EmployeelistGridView.Rows[e.RowIndex].Cells[0].Value;
            updateEmployeetextBox.Text = EmployeelistGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void updateEmployeebutton_Click(object sender, EventArgs e)
        {
            EmployeeService employeeService = new EmployeeService();
            int result = employeeService.UpdateEmployee(id,updateEmployeetextBox.Text);
            if (result > 0)
            {
                MessageBox.Show("Updated!!");
                ClearInputFields();
            }
            else
            {
                MessageBox.Show("Error!!");
            }
        }
    }
}
