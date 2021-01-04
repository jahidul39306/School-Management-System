using School_Management_System.Controller;
using School_Management_System.Model;
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
    public partial class FormAddResult1 : Form
    {
        Teacher t;
         
        public FormAddResult1(Teacher t)
        {
            
            InitializeComponent();
            this.t = t;
            FillClassComboBox(t.tId);
            FillSectionComboBox(t.tId);
            FillCourseComboBox(t.tId);
        }
        public void FillClassComboBox(int tId)
        {
            ArrayList classes = TeacherController.GetTeacherAllClasses(tId);

            foreach (var i in classes)
            {
                comboBoxClass.Items.Add(i.ToString());

            }
        }
        public void FillSectionComboBox(int tId)
        {
            ArrayList sections = TeacherController.GetTeacherAllSections(tId);

            foreach (var i in sections)
            {
                comboBoxSection.Items.Add(i.ToString());

            }
        }

        public void FillCourseComboBox(int tId)
        {
            ArrayList courses = TeacherController.GetTeacherAllCourses(tId);

            foreach (var i in courses)
            {
                comboBoxCourse.Items.Add(i.ToString());

            }
        }
        private void panelResultAdd_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormAddResult1_Load(object sender, EventArgs e)
        {

        }

        private void buttonResultAdd_Click(object sender, EventArgs e)
        {
            //Result r = new Result();
            int cId = Int32.Parse(comboBoxClass.Text);
            int secId = Int32.Parse(comboBoxSection.Text);
            int sId = Int32.Parse(textBoxSearchStudent.Text);
            int coId = Int32.Parse(comboBoxCourse.Text);
            int tMark = Int32.Parse(textBoxTotalMark.Text);
            int obMark = Int32.Parse(textBoxObtainedMark.Text);
            
            int b = TeacherController.AssignResult(cId, secId, sId, coId, tMark, obMark);
            if (b == 0)
            {
                MessageBox.Show("Result Added");
                this.Close();
            }
            else if(b == 2)
            {
                MessageBox.Show("Result for this course already added");
            }
            else
                MessageBox.Show("You don't have access to this student result");
            /*int r = Int32.Parse(comboBoxClass.Text);
            Console.WriteLine(r + "999");*/
        }
    }
}
