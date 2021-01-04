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
    public partial class FormShowCourse : Form
    {
        public FormShowCourse()
        {
            InitializeComponent();
            dataGridViewCourse.DataSource = CourseController.GetAllCourses();
        }

        private void FormShowCourse_Load(object sender, EventArgs e)
        {

        }

        private void textBoxSearchCourse_TextChanged(object sender, EventArgs e)
        {
            string search = textBoxSearchCourse.Text;
            dataGridViewCourse.DataSource = CourseController.SearchCourses(search);
        }
    }
}
