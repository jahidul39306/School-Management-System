using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using School_Management_System.Model;
using School_Management_System.Controller;
namespace School_Management_System.View
{
    public partial class FormAddSection : Form
    {
        public FormAddSection()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Section s = new Section();
                s.secName = textBoxSectionName.Text;
                s.cId = Int32.Parse(textBoxClassId.Text);
                bool b = SectionController.AddSection(s);
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
