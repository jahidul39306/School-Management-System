using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using School_Management_System.Controller;

namespace School_Management_System.View
{
    public partial class FormShowSection : Form
    {
        public FormShowSection()
        {
            InitializeComponent();
            dataGridViewSection.DataSource = SectionController.GetAllSections();
        }

        private void FormShowSection_Load(object sender, EventArgs e)
        {

        }

        private void textBoxSearchSection_TextChanged(object sender, EventArgs e)
        {
            string search =textBoxSearchSection.Text;
            var ds = SectionController.SearchSectios(search);
            dataGridViewSection.DataSource = ds;
        }
    }
}
