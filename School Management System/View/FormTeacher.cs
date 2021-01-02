using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using School_Management_System.Model;

namespace School_Management_System.View
{
    public partial class FormTeacher : Form
    {
        public FormTeacher(Teacher t)
        {
            InitializeComponent();
            panelAddResult.Visible = false;
            panelChangePass.Visible = false;
            panelStudentInfo.Visible = false;
            panelSResult.Visible = false;
            panelResultUpdate.Visible = false;
            panelResultAdd.Visible = false;
            GetPersonalInfo(t);
            /*string s = labelWelcome.Text;
            s += t.name;
            labelWelcome.Text = s;*/
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
            panelTeacherInfo.Visible = false;
            panelChangePass.Visible = false;
            panelResultAdd.Visible = false;
            panelResultUpdate.Visible = true;
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
            
        }

        private void buttonSResult_Click(object sender, EventArgs e)
        {
            panelTeacherInfo.Visible = false;
            panelChangePass.Visible = false;
            panelResultAdd.Visible = false;
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
            panelResultAdd.Visible = false;
            panelResultUpdate.Visible = false;
            panelStudentInfo.Visible = false;
            panelSResult.Visible = false;

        }

        private void buttonViewCSInfo_Click(object sender, EventArgs e)
        {
            panelTeacherInfo.Visible = false;
            panelChangePass.Visible = false;
            // panelAddResult.Visible = false;
            panelResultAdd.Visible = false;
            panelResultUpdate.Visible = false;
            panelSResult.Visible = false;
            panelStudentInfo.Visible = true;
        }

        private void buttonAddResult_Click(object sender, EventArgs e)
        {
            panelTeacherInfo.Visible = false;
            panelChangePass.Visible = false;
            panelResultAdd.Visible = true;
            panelResultUpdate.Visible = false;
            panelStudentInfo.Visible = false;
            panelSResult.Visible = false;

        }
    }
}
