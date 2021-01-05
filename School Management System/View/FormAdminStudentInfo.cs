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
    public partial class FormAdminStudentInfo : Form
    {
        public FormAdminStudentInfo()
        {
            InitializeComponent();
            dataGridViewStudentInfo.DataSource = AdminController.GetAllStudent();
        }

        private void FormAdminStudentInfo_Load(object sender, EventArgs e)
        {

        }

        private void textBoxStudentInfo_TextChanged(object sender, EventArgs e)
        {
            string search = textBoxStudentInfo.Text;
            dataGridViewStudentInfo.DataSource = AdminController.SearchStudent(search);

        }
    }
}
