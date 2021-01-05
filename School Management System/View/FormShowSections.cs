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
    public partial class FormShowSections : Form
    {
        public FormShowSections()
        {
            InitializeComponent();
            dataGridViewSections.DataSource = AdminController.GetAllSecInfo();

        }

        private void FormShowSections_Load(object sender, EventArgs e)
        {

        }

        private void dataGridViewSections_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBoxSecName_TextChanged(object sender, EventArgs e)
        {
            string text = textBoxSecName.Text;
            dataGridViewSections.DataSource = AdminController.SearchSectios(text);
        }
    }
}
