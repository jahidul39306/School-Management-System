using School_Management_System.Controller;
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
            GetLabelValue();

        }
        public void GetLabelValue()
        {
            string a = labelTotalStudent.Text;
            a += AdminController.GetTotalStudent().ToString();
            labelTotalStudent.Text = a;

            string b = labelTotalTeacher.Text;
            b += AdminController.GetTotalTeachers().ToString();
            labelTotalTeacher.Text = b;

            string c = labelTotalSection.Text;
            c += AdminController.GetTotalSection().ToString();
            labelTotalSection.Text = c;

            string d = labelTotalCourse.Text;
            d += AdminController.GetTotalCourse().ToString();
            labelTotalCourse.Text = d;

            string e = labelEarning.Text;
            e += AdminController.TotalEarning().ToString();
            labelEarning.Text = e;
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
            
            new FormAdminStudentInfo().Show();
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

        private void buttonAddSection_Click(object sender, EventArgs e)
        {
            new FormAddSection().Show();
        }

        private void buttonUpdateSection_Click(object sender, EventArgs e)
        {
            new FormUpdateSections().Show();
        }

        private void buttonShowSection_Click(object sender, EventArgs e)
        {
            new FormShowSections().Show();
        }

        private void buttonAddCourse_Click(object sender, EventArgs e)
        {
            new FormAddCourses().Show();
        }

        private void button_Click(object sender, EventArgs e)
        {
            new FormShowCourses().Show();
        }

        private void buttonUpdateCourse_Click(object sender, EventArgs e)
        {
            new FormUpdateCourse().Show();
        }

        private void buttonTeacherAssign_Click(object sender, EventArgs e)
        {
            new FormTeacherAssign().Show();
        }

        private void panelAdminHome_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonResultreport_Click(object sender, EventArgs e)
        {
            new FormResultShow().Show();
        }

        private void panelStudent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelEarning_Click(object sender, EventArgs e)
        {

        }
    }
}
