using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using School_Management_System.Controller;
using School_Management_System.Model;

namespace School_Management_System.View
{
    public partial class FormAddStudent : Form
    {
        public FormAddStudent()
        {
            InitializeComponent();

        }

        private void FormAddStudent_Load(object sender, EventArgs e)
        {

        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Student s = new Student();
            s.name = textBoxName.Text;
            s.roll = textBoxRoll.Text;
            s.fatherName = textBoxFathersName.Text;
            s.motherName = textBoxMothersName.Text;
            s.dateOfBirth = Convert.ToDateTime(textBoxDateOfBirth.Text);
            s.dateOfAdmission = Convert.ToDateTime(textBoxDateOfAdmission.Text);
            s.contact = textBoxContact.Text;
            s.address = richTextBoxAddress.Text;
            s.gender = comboBoxGender.Text;
            s.userName = textBoxUserName.Text;
            s.password = textBoxPassword.Text;
            s.secId = Int32.Parse(textBoxSectionId.Text);
            s.cId = Int32.Parse(textBoxClassId.Text);
            bool b = StudentController.AddStudent(s);
            if(b)
            {
                MessageBox.Show("Student Added");
                this.Close();
            }
            
        }
    }
}
