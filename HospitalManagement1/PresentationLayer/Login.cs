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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (userNameTextBox.Text==""||passwordTextBox.Text=="")
            {
                MessageBox.Show("Username and Password cannot be empty");
            }
            else
            {
                UserService userService = new UserService();
                bool result = userService.LoginValidation(userNameTextBox.Text, passwordTextBox.Text);
                if (result)
                {
                    HomePage homePage = new HomePage();
                    homePage.Show();
                    
                }
                else
                {
                    MessageBox.Show("Invalid name or password");
                }
            }

            
        }
    }
}
