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
    public partial class FormShowStudentInfo : Form
    {
        public FormShowStudentInfo()
        {
            InitializeComponent();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            int stuId = Int32.Parse(textBoxStudentId.Text);
            Student s = null;
            s = StudentController.GetStudent(stuId);
            if (s != null)
            {

                textBoxName.Text = s.name;
                textBoxClass.Text = s.cId.ToString();
                textBoxSection.Text = s.secId.ToString();
                textBoxFathersName.Text = s.fatherName;
                textBoxMothersName.Text = s.motherName;
                textBoxRoll.Text = s.roll;
                textBoxDateOfBirth.Text = s.dateOfBirth.ToString();
                textBoxDateOfAdmission.Text = s.dateOfAdmission.ToString();
                textBoxContact.Text = s.contact;
                richTextBoxAddress.Text = s.address;
                textBoxGender.Text = s.gender;
                textBoxRoll.Text = s.roll;
                textBoxUserName.Text = s.userName;
                textBoxPassword.Text = s.password;

            }
            else
            {
                MessageBox.Show("Student Not Found");
            }
        }
    }
}
