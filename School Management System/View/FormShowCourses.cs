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
    public partial class FormShowCourses : Form
    {
        public FormShowCourses()
        {
            InitializeComponent();
            dataGridViewCourses.DataSource = AdminController.GetAllCoursesInfo();
        }

        private void FormShowCourses_Load(object sender, EventArgs e)
        {

        }

        private void textBoxCourseName_TextChanged(object sender, EventArgs e)
        {
            string text = textBoxCourseName.Text;
            dataGridViewCourses.DataSource = AdminController.SearchCourses(text);
        }
    }
}
