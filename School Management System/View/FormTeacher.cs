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
    public partial class FormTeacher : Form
    {
        Teacher t;
        public FormTeacher(Teacher t)
        {
            InitializeComponent();
            this.t = t;
            panelTeacherInfo.Visible = true;
            panelResultAdd.Visible = false;
            panelResultUpdate.Visible = false;
            panelStudentInfo.Visible = false;
            panelSResult.Visible = false;
            panelChangePass.Visible = false;
            GetPersonalInfo(t);
            FillClassComboBox(t.tId);
            FillSectionComboBox(t.tId);
            FillCourseComboBox(t.tId);
            var ds = TeacherController.GetAllStudent();
            dataGridViewCSInfo.DataSource = ds;
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
        public void GetPersonalInfo(Teacher t)
        {
            string s = labelWelcome.Text;
            s += t.name;
            labelWelcome.Text = s;
            textBoxName.Text = t.name;
            textBoxGender.Text = t.gender;
            textBoxContact.Text = t.contact;
            richTextBoxAddress.Text = t.address;
        }

        private void buttonChangePass_Click(object sender, EventArgs e)
        {
            panelTeacherInfo.Visible = false;
            panelResultAdd.Visible = false;
            panelResultUpdate.Visible = false;
            panelStudentInfo.Visible = false;
            panelSResult.Visible = false;
            panelChangePass.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new FormUpdateResult(t).Show();
            panelTeacherInfo.Visible = false;
            panelChangePass.Visible = false;
            panelResultAdd.Visible = false;
            
            panelStudentInfo.Visible = false;
            panelSResult.Visible = false;
        }

        private void FormTeacher_Load(object sender, EventArgs e)
        {

        }

        private void panelAddResult_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            string userName = textBoxUserName.Text;
            string newPass = textBoxNewPassword.Text;
            bool b = TeacherController.UpdateTeacherPassword(userName, newPass);
            if (b)
            {
                MessageBox.Show("Password Changed");
            }
            else
            {
                MessageBox.Show("Password changed failed");
            }
        }

        private void buttonSResult_Click(object sender, EventArgs e)
        {
            panelTeacherInfo.Visible = false;
            panelChangePass.Visible = false;
           
            panelResultUpdate.Visible = false;
            panelStudentInfo.Visible = false;
            panelSResult.Visible = true;
        }

        private void labelSection_Click(object sender, EventArgs e)
        {

        }

        private void buttonProfile_Click(object sender, EventArgs e)
        {
            panelTeacherInfo.Visible = true;
            panelChangePass.Visible = false;
          
            panelResultUpdate.Visible = false;
            panelStudentInfo.Visible = false;
            panelSResult.Visible = false;

        }

        private void buttonViewCSInfo_Click(object sender, EventArgs e)
        {
            panelTeacherInfo.Visible = false;
            panelChangePass.Visible = false;
            // panelAddResult.Visible = false;
            
            panelResultUpdate.Visible = false;
            panelSResult.Visible = false;
            panelStudentInfo.Visible = true;
        }

        private void buttonAddResult_Click(object sender, EventArgs e)
        {
            new FormAddResult1(t).Show();
            panelTeacherInfo.Visible = false;
            panelChangePass.Visible = false;
            
            panelResultUpdate.Visible = false;
            panelStudentInfo.Visible = false;
            panelSResult.Visible = false;

        }

        private void panelChangePass_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBoxUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxNewPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }

        private void panelSResult_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panelTeacherInfo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelStudentInfo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBoxSId_TextChanged(object sender, EventArgs e)
        {
            string search = textBoxSId.Text; 
            var ds = TeacherController.SearchStudent(search);
            dataGridViewCSInfo.DataSource = ds;
        }

        private void labelCourse_Click(object sender, EventArgs e)
        {

        }

        private void buttonResultAdd_Click(object sender, EventArgs e)
        {
            int cId = Int32.Parse(this.comboBoxClass.Text);
            int secId = Int32.Parse(this.comboBoxSection.Text);
            int sId = Int32.Parse(this.textBoxSearchStudent.Text);
            int coId = Int32.Parse(this.comboBoxCourse.Text);
            int tMark = Int32.Parse(this.textBoxTotalMark.Text);
            int obMark = Int32.Parse(this.textBoxObtainedMark.Text);
            Console.WriteLine(cId + secId + sId + coId + tMark + obMark + " 985563 Form Teacher");
            //int b = TeacherController.AssignResult(cId, secId, sId, coId, tMark, obMark);
            
        }
    }
}
