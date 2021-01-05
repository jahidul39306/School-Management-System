using School_Management_System.Controller;
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

namespace School_Management_System.View
{
    public partial class FormTeacherAssign : Form
    {
        public FormTeacherAssign()
        {
            InitializeComponent();
            FillClassComboBox();
            FillSectionComboBox();
            FillCourseComboBox();
            FillTeacherComboBox();
        }
        public void FillClassComboBox()
        {
            ArrayList classes = AdminController.GetAllClasses();
            foreach (var e in classes)
            {
                comboBoxClass.Items.Add(e.ToString());
            }
        }

        public void FillSectionComboBox()
        {
            ArrayList sections = AdminController.GetAllSections();
            foreach (var e in sections)
            {
                comboBoxSection.Items.Add(e.ToString());
            }
        }
        public void FillCourseComboBox()
        {
            ArrayList courses = AdminController.GetAllCourses();
            foreach (var e in courses)
            {
                comboBoxCourse.Items.Add(e.ToString());
            }
        }
        public void FillTeacherComboBox()
        {
            ArrayList teachers = AdminController.GetAllTeachersId();
            foreach (var e in teachers)
            {
                comboBoxTeacher.Items.Add(e.ToString());
            }
        }

        private void comboBoxCourse_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FormTeacherAssign_Load(object sender, EventArgs e)
        {

        }

        private void buttonAssignTeacher_Click(object sender, EventArgs e)
        {
            try
            {
                int tId = Int32.Parse(comboBoxTeacher.Text);
                int coId = Int32.Parse(comboBoxCourse.Text);
                int secId = Int32.Parse(comboBoxSection.Text);
                int cId = Int32.Parse(comboBoxClass.Text);
                bool b = AdminController.AssignTeacher(tId, coId, cId, secId);
                if (b)
                {
                    MessageBox.Show("Teacher Assigned");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to assign Invalid Input");
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Invalid input");
            }
        }

        private void comboBoxTeacher_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
