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
    public partial class FormUpdateSections : Form
    {
        public FormUpdateSections()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int secId = Int32.Parse(textBoxSecId.Text);
            Section s = new Section();
            s = AdminController.GetSection(secId);
            if(s != null)
            {
                textBoxSecName.Text = s.secName;
                textBoxCId.Text = s.cId.ToString();
            }
            else
            {
                MessageBox.Show("Invalid Section ID");
            }

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            Section s = new Section();
            int secId = Int32.Parse(textBoxSecId.Text);
            s.secName = textBoxSecName.Text;
            s.cId = Int32.Parse(textBoxCId.Text);
            bool b = AdminController.UpdateSection(s, secId);
            if(b)
            {
                MessageBox.Show("Section Updated");
            }
            else
            {
                MessageBox.Show("Invalid Section ID");
            }
                   
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int secId = Int32.Parse(textBoxSecId.Text);
            bool b = AdminController.DeleteSection(secId);
            if(b)
            {
                MessageBox.Show("Section Deleted");
                this.Close();
            }
            else
            {
                MessageBox.Show("Failed to delete section");
            }    
        }
    }
}
