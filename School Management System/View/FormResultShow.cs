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
    public partial class FormResultShow : Form
    {
        public FormResultShow()
        {
            InitializeComponent();
            dataGridViewResult.DataSource = AdminController.GetAllresults();
        }

        private void FormResultShow_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {

                int text = Int32.Parse(textBoxSearch.Text);
                dataGridViewResult.DataSource = AdminController.SearchResult(text);
            }
            catch(Exception)
            {

            }
        }
    }
}
