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
    public partial class FormShowTeacherInfo : Form
    {
        public FormShowTeacherInfo()
        {
            InitializeComponent();
            var ds = AdminController.GetAllTeachers();
            dataGridViewTeachers.DataSource = ds;
        }

        private void FormShowTeacherInfo_Load(object sender, EventArgs e)
        {

        }

        private void dataGridViewTeachers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //string search = textBoxTeacherId.Text;

        }

        private void textBoxTeacherId_TextChanged(object sender, EventArgs e)
        {
            string search = textBoxTeacherId.Text;
            var ds = AdminController.SearchTeachers(search);
            dataGridViewTeachers.DataSource = ds;
        }
    }
}
