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
    public partial class FormAddTeacher : Form
    {
        public FormAddTeacher()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Teacher t = new Teacher();
                t.name = textBoxName.Text;
                t.gender = comboBoxGender.Text;
                t.contact = textBoxContact.Text;
                t.address = richTextBoxAddress.Text;
                t.userName = textBoxUserName.Text;
                t.password = textBoxPassword.Text;
                bool b = AdminController.AddTeacher(t);
                if (b)
                {
                    MessageBox.Show("Teacher added");
                    this.Close();
                }
                /*else
                {
                    MessageBox.Show("Failed to add teacher");
                }*/
            }
            catch(Exception)
            {
                MessageBox.Show("Invalid Input");
            }
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
