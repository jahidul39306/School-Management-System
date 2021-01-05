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
    public partial class FormAddCourses: Form
    {
        public FormAddCourses()
        {
            InitializeComponent();
            FillClassComboBox();
        }
        public void FillClassComboBox()
        {
            ArrayList classes = AdminController.GetAllClasses();
            foreach (var e in classes)
            {
                comboBoxClaasId.Items.Add(e.ToString());
            }
        }

        private void FormAddCourses_Load(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Course c = new Course();
                c.courseName = textBoxCourseName.Text;
                c.cId = Int32.Parse(comboBoxClaasId.Text);
                bool b = AdminController.AddCourse(c);
                if (b)
                {
                    MessageBox.Show("Courses Added");
                    this.Close();
                }
                else
                    MessageBox.Show("Failed");
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid input");
            }
        }

        private void comboBoxClaasId_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
