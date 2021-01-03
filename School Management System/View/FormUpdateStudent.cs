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
    public partial class FormUpdateStudent : Form
    {
        public FormUpdateStudent()
        {
            InitializeComponent();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            int stuId = Int32.Parse(textBoxSearch.Text);
            Student s = null;
            s = StudentController.GetStudent(stuId);
            if(s != null)
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

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxClass_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            int sId = Int32.Parse(textBoxSearch.Text);
            Student s = new Student();
            s.name = textBoxName.Text;
            s.roll = textBoxRoll.Text;
            s.fatherName = textBoxFathersName.Text;
            s.motherName = textBoxMothersName.Text;
            s.dateOfBirth = Convert.ToDateTime(textBoxDateOfBirth.Text);
            s.dateOfAdmission = Convert.ToDateTime(textBoxDateOfAdmission.Text);
            s.contact = textBoxContact.Text;
            s.address = richTextBoxAddress.Text;
            s.gender = textBoxGender.Text;
            s.userName = textBoxUserName.Text;
            s.password = textBoxPassword.Text;
            s.secId = Int32.Parse(textBoxSection.Text);
            s.cId = Int32.Parse(textBoxClass.Text);
            bool b = StudentController.UpdateStudent(s, sId);
            if(b)
            {
                MessageBox.Show("Student Updated");
                this.Close();
            }
            else
            {
                MessageBox.Show("Student update Failed");
            }
        }

        private void textBoxUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int sId = Int32.Parse(textBoxSearch.Text);
            bool b = StudentController.DeleteStudent(sId);
            if(b)
            {
                MessageBox.Show("Deleted");
                this.Close();
            }
            else
                MessageBox.Show("Fail to delete");
        }
    }
}
