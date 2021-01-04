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
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
            panelAdminHome.Visible = true;
            panelStudent.Visible = false;
            panelTeacher.Visible = false;
            panelCourse.Visible = false;
            panelSection.Visible = false;
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {

        }

        private void buttonStudents_Click(object sender, EventArgs e)
        {
            panelStudent.Visible = true;
            panelTeacher.Visible = false;
            panelCourse.Visible = false;
            panelSection.Visible = false;
            panelAdminHome.Visible = false;
        }

        private void buttonTeachers_Click(object sender, EventArgs e)
        {
            panelStudent.Visible = false;
            panelTeacher.Visible = true;
            panelCourse.Visible = false;
            panelSection.Visible = false;
            panelAdminHome.Visible = false;
        }

        private void buttonCourses_Click(object sender, EventArgs e)
        {
            panelStudent.Visible = false;
            panelTeacher.Visible = false;
            panelCourse.Visible = true;
            panelSection.Visible = false;
            panelAdminHome.Visible = false;
        }

        private void buttonSection_Click(object sender, EventArgs e)
        {
            panelAdminHome.Visible = false;
            panelStudent.Visible = false;
            panelTeacher.Visible = false;
            panelCourse.Visible = false;
            panelSection.Visible = true;
        }

        private void buttonAddStudent_Click(object sender, EventArgs e)
        {
            new FormAddStudent().Show();
        }

        private void buttonUpdateStudent_Click(object sender, EventArgs e)
        {
            new FormUpdateStudent().Show();
        }

        private void buttonShowStudent_Click(object sender, EventArgs e)
        {
            new FormShowStudentInfo().Show();
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            panelStudent.Visible = false;
            panelTeacher.Visible = false;
            panelCourse.Visible = false;
            panelSection.Visible = false;
            panelAdminHome.Visible = true;
        }

        private void buttonAddTeacher_Click(object sender, EventArgs e)
        {
            new FormAddTeacher().Show();
        }

        private void buttonUpdateTeacher_Click(object sender, EventArgs e)
        {
            new FormUpdateTeacher().Show();
        }

        private void buttonShowTeacher_Click(object sender, EventArgs e)
        {
            new FormShowTeacherInfo().Show();
        }
    }
}
