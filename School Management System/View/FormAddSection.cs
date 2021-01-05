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
    public partial class FormAddSection : Form
    {
        public FormAddSection()
        {
            InitializeComponent();
            //ArrayList classes = AdminController.GetAllClasses();
            FillClassComboBox();
        }
        public void FillClassComboBox()
        {
            ArrayList classes = AdminController.GetAllClasses();
            foreach(var e in classes)
            {
                comboBoxClaasId.Items.Add(e.ToString());
            }
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Section s = new Section();
                s.secName = textBoxSecName.Text;
                s.cId = Int32.Parse(comboBoxClaasId.Text);

                //s.cId = Int32.Parse(textBoxClass.Text);
                bool b = AdminController.AddSection(s);
                if (b)
                {
                    MessageBox.Show("Section added to class");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Fill all the boxes");

                }
            }
            catch(Exception)
            {
                MessageBox.Show("Invalid input");
            }
        }

        private void comboBoxClaasId_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FormAddSection_Load(object sender, EventArgs e)
        {

        }
    }
}
