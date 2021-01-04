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
    public partial class FormUpdateResult : Form
    {
        Teacher t;
        public FormUpdateResult(Teacher t)
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
        private void buttonGetResult_Click(object sender, EventArgs e)
        {
            int cId = Int32.Parse(this.comboBoxClass.Text);
            int secId = Int32.Parse(this.comboBoxSection.Text);
            int sId = Int32.Parse(this.textBoxSearchStudent.Text);
            int coId = Int32.Parse(this.comboBoxCourse.Text);
            Result r = new Result();
            r = TeacherController.GetCourseResult(cId, secId, sId, coId);
            if(r != null)
            {
                textBoxTotalMark.Text = r.totalMark.ToString();
                textBoxPObtainedMark.Text = r.obtainedMark.ToString();
            }
            else
            {
                MessageBox.Show("You don't have access to this student result");
            }
            
        }

        private void textBoxTotalMark_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonResultUpdate_Click(object sender, EventArgs e)
        {
            int cId = Int32.Parse(comboBoxClass.Text);
            int secId = Int32.Parse(comboBoxSection.Text);
            int sId = Int32.Parse(textBoxSearchStudent.Text);
            int coId = Int32.Parse(comboBoxCourse.Text);
            int tMark = Int32.Parse(textBoxTotalMark.Text);
            int obMark = Int32.Parse(textBoxNoMark.Text);

            bool b = TeacherController.UpdateResult(cId, secId, sId, coId, tMark, obMark);
            if (b)
            {
                MessageBox.Show("Result Added");
                this.Close();
            }
            else
                MessageBox.Show("You don't have access to this student result");
            
        }
    

    private void labelNewObtainedMark_Click(object sender, EventArgs e)
        {

        }

        private void FormUpdateResult_Load(object sender, EventArgs e)
        {

        }
    }
}
