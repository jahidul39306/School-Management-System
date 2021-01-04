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
            panelResultReport.Visible = false;
            GetLabelValue();
        }
        public void GetLabelValue()
        {
            string a = labelTotalStudent.Text;
            a+=StudentController.GetTotalStudet().ToString();
            labelTotalStudent.Text = a;

            string b = labelTotalTeacher.Text;
            b += TeacherController.GetTotalTeacher().ToString();
            labelTotalTeacher.Text = b;

            string c = labelTotalSection.Text;
            c += SectionController.GetTotalSection().ToString();
            labelTotalSection.Text = c;

            string d = labelTotalCourse.Text;
            d += CourseController.GetTotalCourse().ToString();
            labelTotalCourse.Text = d;

            

            
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
            panelResultReport.Visible = false;
        }

        private void buttonTeachers_Click(object sender, EventArgs e)
        {
            panelStudent.Visible = false;
            panelResultReport.Visible = false;
            panelTeacher.Visible = true;
            panelCourse.Visible = false;
            panelSection.Visible = false;
            panelAdminHome.Visible = false;
        }

        private void buttonCourses_Click(object sender, EventArgs e)
        {
            panelStudent.Visible = false;
            panelResultReport.Visible = false;
            panelTeacher.Visible = false;
            panelCourse.Visible = true;
            panelSection.Visible = false;
            panelAdminHome.Visible = false;
        }

        private void buttonSection_Click(object sender, EventArgs e)
        {
            panelAdminHome.Visible = false;
            panelResultReport.Visible = false;
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
            panelResultReport.Visible = false;
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

        private void labelStudentId_Click(object sender, EventArgs e)
        {

        }

        private void buttonResultreport_Click(object sender, EventArgs e)
        {
            panelStudent.Visible = false;
            panelTeacher.Visible = false;
            panelCourse.Visible = false;
            panelSection.Visible = false;
            panelAdminHome.Visible = false;
            panelResultReport.Visible = true;
        }

        private void buttonAddCourse_Click(object sender, EventArgs e)
        {
            new FormAddCourse().Show();
        }

        private void panelAdminHome_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            int sId=Int32.Parse(textBoxStudentId.Text);
            dataGridViewResult.DataSource = StudentController.GetStudentResult(sId);
        }

        private void buttonUpdateCourse_Click(object sender, EventArgs e)
        {
            new FormUpdateCourse().Show();
        }

        private void button_Click(object sender, EventArgs e)
        {
            new FormShowCourse().Show();
        }

        private void buttonAddSection_Click(object sender, EventArgs e)
        {
            new FormAddSection().Show();
        }

        private void buttonShowSection_Click(object sender, EventArgs e)
        {
            new FormShowSection().Show();
        }

        private void buttonUpdateSection_Click(object sender, EventArgs e)
        {
            new FormUpdateSection().Show();
        }
    }
}
