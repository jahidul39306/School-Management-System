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
    public partial class FormUpdateCourse : Form
    {
        public FormUpdateCourse()
        {
            InitializeComponent();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            int coId = Int32.Parse(textBoxCourseId.Text);
            Course c = new Course();
            c = AdminController.GetCourse(coId);
            if(c != null)
            {
                textBoxCourseName.Text = c.courseName;
                textBoxCId.Text = c.cId.ToString();
            }
            else
            {
                MessageBox.Show("Update Failed. Invalid Input");
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            Course c = new Course();
            c.courseName = textBoxCourseName.Text;
            c.cId = Int32.Parse(textBoxCId.Text);
            int coId = Int32.Parse(textBoxCourseId.Text);
            bool b = AdminController.UpdateCourse(c, coId);
            if(b)
            {
                MessageBox.Show("Course Updated");
            }
            else
            {
                MessageBox.Show("Failed to Update. Invalid Input");
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int coId = Int32.Parse(textBoxCourseId.Text);
            bool b = AdminController.DeleteCourse(coId);
            if(b)
            {
                MessageBox.Show("Course Deleted");
            }
            else
            {
                MessageBox.Show("Failed to delete. Invalid Input");
            }
        }
    }
}
