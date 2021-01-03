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
    public partial class StaffManagement : Form
    {
        HomePage homePage;
        public StaffManagement(HomePage homePage)
        {
            this.homePage = homePage;
            InitializeComponent();
            addStaffButton.Click += this.RefreshGridView;
            updateStaffButton.Click += this.RefreshGridView;
            DeleteStaffButton.Click += this.RefreshGridView;


        }

        private void StaffManagement_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void StaffManagement_Load(object sender, EventArgs e)
        {
            StaffService staffService = new StaffService();
            loadStaffDataGridView.DataSource = staffService.GetStaffList();
            staffService = new StaffService();
            SearchStaffcomboBox.DataSource = staffService.GetStaffNameList();
        }

        private void RefreshGridView(object sender, EventArgs e)
        {
            StaffService staffService = new StaffService();
            loadStaffDataGridView.DataSource = staffService.GetStaffList();
            staffService = new StaffService();
            SearchStaffcomboBox.DataSource = staffService.GetStaffNameList();
        }

        private void ClearInputFields()
        {
            addStaffNameTextBox.Text = updateStaffNameTextBox.Text =DeleteStaffIdtextBox.Text= string.Empty;

        }

        private void addStaffButton_Click(object sender, EventArgs e)
        {
            StaffService staffService = new StaffService();
            int result = staffService.AddNewStaff(addStaffNameTextBox.Text);
            if (result>0)
            {
                MessageBox.Show("New staff added");
                ClearInputFields();
            }
            else
            {
                MessageBox.Show("Error in adding new Staff");
            }
        }
        int id = 0;

        private void loadStaffDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id =(int) loadStaffDataGridView.Rows[e.RowIndex].Cells[0].Value;
            updateStaffNameTextBox.Text=loadStaffDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void updateStaffButton_Click(object sender, EventArgs e)
        {
            StaffService staffService = new StaffService();
            int result = staffService.UpdateStaff(id, updateStaffNameTextBox.Text);
            if (result > 0)
            {
                MessageBox.Show(" staff updated");
                ClearInputFields();
            }
            else
            {
                MessageBox.Show("Error in updating Staff");
            }
        }

        private void DeleteStaffbutton_Click(object sender, EventArgs e)
        {
            StaffService staffService = new StaffService();
            int result = staffService.DeleteStaff(Convert.ToInt32(DeleteStaffIdtextBox.Text));
            if (result > 0)
            {
                MessageBox.Show(" Deleted Successfully...");
                ClearInputFields();
            }
            else
            {
                MessageBox.Show("Error!!!");
            }
        }

        private void SearchStaffcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            StaffService staffService = new StaffService();
            StaffwiseEmployeelistdataGridView.DataSource = staffService.GetEmployeeListByStaff(SearchStaffcomboBox.Text);
        }

        private void StaffwiseEmployeelistdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            homePage.Show();
            this.Hide();
        }
    }
}
