using System;
using System.Collections;
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
            FillClassComboBox();
            FillSectionComboBox();
        }
        public void FillClassComboBox()
        {
            ArrayList classes = AdminController.GetAllClasses();
            foreach (var e in classes)
            {
                comboBoxClassId.Items.Add(e.ToString());
            }
        }

        public void FillSectionComboBox()
        {
            ArrayList sections = AdminController.GetAllSections();
            foreach (var e in sections)
            {
                comboBoxSecId.Items.Add(e.ToString());
            }
        }

        private void FormAddStudent_Load(object sender, EventArgs e)
        {

        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
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
                s.secId = Int32.Parse(comboBoxSecId.Text);
                s.cId = Int32.Parse(comboBoxClassId.Text);
                bool b = StudentController.AddStudent(s);
                if (b)
                {
                    MessageBox.Show("Student Added");
                    this.Close();
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Invalid Input");
            }
            
        }

        private void comboBoxClassId_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
