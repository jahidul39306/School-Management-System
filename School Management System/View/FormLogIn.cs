using School_Management_System.Controller;
using School_Management_System.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace School_Management_System.View
{
    public partial class FormLogIn : Form
    {
        public FormLogIn()
        {
            InitializeComponent();
        }

        private void labelUserName_Click(object sender, EventArgs e)
        {

        }

        private void FormLogIn_Load(object sender, EventArgs e)
        {

        }

        private void textBoxUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            string userName = textBoxUserName.Text;
            string password = textBoxPassword.Text;
            string userType = comboBoxUserType.Text;
            if(userType == "Admin")
            {
                //AdminController.AuthenticateAdmin(userName, password);
                if(AdminController.AuthenticateAdmin(userName, password) != null)
                {
                    new FormAdmin().Show();
                }
                else
                {
                    MessageBox.Show("Invalid user name or password");
                }
            }
            else if(userType == "Teacher")
            {
                if (TeacherController.AuthenticateTeacher(userName, password) != null)
                {
                    Teacher t = TeacherController.AuthenticateTeacher(userName, password);
                    new FormTeacher(t).Show();
                }
                else
                {
                    MessageBox.Show("Invalid user name or password");
                }
                
            }
            else if(userType == "Student")
            {
                if (StudentController.AuthenticateStudent(userName, password) != null)
                {
                    Student s = StudentController.AuthenticateStudent(userName, password);
                    new FormStudent(s).Show();
                }
                else
                {
                    MessageBox.Show("Invalid user name or password");
                }
         
            }
        }

        private void comboBoxUserType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
