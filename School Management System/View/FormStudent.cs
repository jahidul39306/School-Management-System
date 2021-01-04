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
    public partial class FormStudent : Form
    {
        public FormStudent(Student s)
        {
            InitializeComponent();
            int sId = s.sId;
            GetStudentInfo(s);
            var ds = StudentController.GetStudentResult(sId);
            dataGridViewResult.DataSource = ds;
        }
        
        public void GetStudentInfo(Student s)
        {
            int sId = s.sId;
            int secId = s.secId;
            int cId = s.cId;
            
            textBoxName.Text = s.name;
            textBoxClass.Text = ClassController.GetClass(cId).clas.ToString();
            textBoxSection.Text = SectionController.GetSection(secId).secName.ToString();
            textBoxFathersName.Text = s.fatherName;
            textBoxMothersName.Text = s.motherName;
            textBoxRoll.Text = s.roll;
            textBoxDateOfBirth.Text = s.dateOfBirth.ToString();
            textBoxDateOfAdmission.Text = s.dateOfAdmission.ToString();
            textBoxContact.Text = s.contact;
            richTextBoxAddress.Text = s.address;
            textBoxGender.Text = s.gender;
            textBoxRoll.Text = s.roll;
            
        }

        private void labelFathersName_Click(object sender, EventArgs e)
        {

        }

        private void textBoxFathersName_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelName_Click(object sender, EventArgs e)
        {

        }

        private void FormStudent_Load(object sender, EventArgs e)
        {

        }

        private void textBoxRoll_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelClass_Click(object sender, EventArgs e)
        {

        }

        private void labelRoll_Click(object sender, EventArgs e)
        {

        }

        private void richTextBoxAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelAddress_Click(object sender, EventArgs e)
        {

        }

        private void textBoxDateOfBirth_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelDate_Click(object sender, EventArgs e)
        {

        }

        private void textBoxContact_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelDateOfBirth_Click(object sender, EventArgs e)
        {

        }

        private void textBoxGender_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBoxMothersName_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelMothersName_Click(object sender, EventArgs e)
        {

        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBoxSection_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
