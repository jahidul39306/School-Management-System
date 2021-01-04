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
    public partial class FormAddCourse : Form
    {
        public FormAddCourse()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Course c = new Course();
                c.courseName = textBoxCourseName.Text;
                c.cId = Int32.Parse(textBoxClassId.Text);
                bool b = CourseController.AddCourse(c);
                if (b)
                {
                    MessageBox.Show("Section Added");
                }
                else
                    MessageBox.Show("Failed");
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid input");
            }
        }
    }
}
