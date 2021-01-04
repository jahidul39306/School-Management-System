using School_Management_System.Controller;
using School_Management_System.Model;
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
    public partial class FormUpdateTeacher : Form
    {
        public FormUpdateTeacher()
        {
            InitializeComponent();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            int tId = Int32.Parse(textBoxTeacherId.Text);
            Teacher t = new Teacher();
            t = AdminController.GetTeacher(tId);
            textBoxName.Text = t.name;
            textBoxGender.Text = t.gender;
            textBoxContact.Text = t.contact;
            richTextBoxAddress.Text = t.address;
            textBoxUserName.Text = t.userName;
            textBoxPassword.Text = t.password;
        }

        private void textBoxTeacherId_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            int teacherId = Int32.Parse(textBoxTeacherId.Text);
            Teacher t = new Teacher();
            t.name = textBoxName.Text;
            t.gender = textBoxGender.Text;
            t.contact = textBoxContact.Text;
            t.address = richTextBoxAddress.Text;
            t.userName = textBoxUserName.Text;
            t.password = textBoxPassword.Text;
            bool b = AdminController.UpdateTeacher(t, teacherId);
            if(b)
            {
                MessageBox.Show("Teacher Updated");
                this.Close();
            }
            else
            {
                MessageBox.Show("Failed to Update Teacher");
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int tId = Int32.Parse(textBoxTeacherId.Text);
            bool b = AdminController.DeleteTeacher(tId);
            if (b)
            {
                MessageBox.Show("Teacher Deleted");
                this.Close();
            }
            else
            {
                MessageBox.Show("Failed to Delete Teacher");
            }
        }
    }
}
