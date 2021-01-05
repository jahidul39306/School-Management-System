
namespace School_Management_System.View
{
    partial class FormTeacherAssign
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelCourse = new System.Windows.Forms.Label();
            this.comboBoxCourse = new System.Windows.Forms.ComboBox();
            this.comboBoxClass = new System.Windows.Forms.ComboBox();
            this.labelClass = new System.Windows.Forms.Label();
            this.comboBoxTeacher = new System.Windows.Forms.ComboBox();
            this.labelTeacher = new System.Windows.Forms.Label();
            this.comboBoxSection = new System.Windows.Forms.ComboBox();
            this.labelSec = new System.Windows.Forms.Label();
            this.buttonAssignTeacher = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelCourse
            // 
            this.labelCourse.AutoSize = true;
            this.labelCourse.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCourse.Location = new System.Drawing.Point(152, 79);
            this.labelCourse.Name = "labelCourse";
            this.labelCourse.Size = new System.Drawing.Size(104, 23);
            this.labelCourse.TabIndex = 1;
            this.labelCourse.Text = "Course ID:";
            // 
            // comboBoxCourse
            // 
            this.comboBoxCourse.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCourse.FormattingEnabled = true;
            this.comboBoxCourse.Location = new System.Drawing.Point(276, 76);
            this.comboBoxCourse.Name = "comboBoxCourse";
            this.comboBoxCourse.Size = new System.Drawing.Size(121, 31);
            this.comboBoxCourse.TabIndex = 2;
            this.comboBoxCourse.SelectedIndexChanged += new System.EventHandler(this.comboBoxCourse_SelectedIndexChanged);
            // 
            // comboBoxClass
            // 
            this.comboBoxClass.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxClass.FormattingEnabled = true;
            this.comboBoxClass.Location = new System.Drawing.Point(276, 301);
            this.comboBoxClass.Name = "comboBoxClass";
            this.comboBoxClass.Size = new System.Drawing.Size(121, 31);
            this.comboBoxClass.TabIndex = 4;
            // 
            // labelClass
            // 
            this.labelClass.AutoSize = true;
            this.labelClass.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClass.Location = new System.Drawing.Point(172, 301);
            this.labelClass.Name = "labelClass";
            this.labelClass.Size = new System.Drawing.Size(87, 23);
            this.labelClass.TabIndex = 3;
            this.labelClass.Text = "Class ID:";
            // 
            // comboBoxTeacher
            // 
            this.comboBoxTeacher.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTeacher.FormattingEnabled = true;
            this.comboBoxTeacher.Location = new System.Drawing.Point(276, 220);
            this.comboBoxTeacher.Name = "comboBoxTeacher";
            this.comboBoxTeacher.Size = new System.Drawing.Size(121, 31);
            this.comboBoxTeacher.TabIndex = 6;
            this.comboBoxTeacher.SelectedIndexChanged += new System.EventHandler(this.comboBoxTeacher_SelectedIndexChanged);
            // 
            // labelTeacher
            // 
            this.labelTeacher.AutoSize = true;
            this.labelTeacher.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTeacher.Location = new System.Drawing.Point(144, 223);
            this.labelTeacher.Name = "labelTeacher";
            this.labelTeacher.Size = new System.Drawing.Size(115, 23);
            this.labelTeacher.TabIndex = 5;
            this.labelTeacher.Text = "Teacher ID:";
            // 
            // comboBoxSection
            // 
            this.comboBoxSection.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSection.FormattingEnabled = true;
            this.comboBoxSection.Location = new System.Drawing.Point(276, 145);
            this.comboBoxSection.Name = "comboBoxSection";
            this.comboBoxSection.Size = new System.Drawing.Size(121, 31);
            this.comboBoxSection.TabIndex = 8;
            // 
            // labelSec
            // 
            this.labelSec.AutoSize = true;
            this.labelSec.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSec.Location = new System.Drawing.Point(152, 148);
            this.labelSec.Name = "labelSec";
            this.labelSec.Size = new System.Drawing.Size(107, 23);
            this.labelSec.TabIndex = 7;
            this.labelSec.Text = "Section ID:";
            // 
            // buttonAssignTeacher
            // 
            this.buttonAssignTeacher.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAssignTeacher.Location = new System.Drawing.Point(635, 220);
            this.buttonAssignTeacher.Name = "buttonAssignTeacher";
            this.buttonAssignTeacher.Size = new System.Drawing.Size(193, 86);
            this.buttonAssignTeacher.TabIndex = 9;
            this.buttonAssignTeacher.Text = "Assign Teacher";
            this.buttonAssignTeacher.UseVisualStyleBackColor = true;
            this.buttonAssignTeacher.Click += new System.EventHandler(this.buttonAssignTeacher_Click);
            // 
            // FormTeacherAssign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 546);
            this.Controls.Add(this.buttonAssignTeacher);
            this.Controls.Add(this.comboBoxSection);
            this.Controls.Add(this.labelSec);
            this.Controls.Add(this.comboBoxTeacher);
            this.Controls.Add(this.labelTeacher);
            this.Controls.Add(this.comboBoxClass);
            this.Controls.Add(this.labelClass);
            this.Controls.Add(this.comboBoxCourse);
            this.Controls.Add(this.labelCourse);
            this.Name = "FormTeacherAssign";
            this.Text = "FormTeacherAssign";
            this.Load += new System.EventHandler(this.FormTeacherAssign_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCourse;
        private System.Windows.Forms.ComboBox comboBoxCourse;
        private System.Windows.Forms.ComboBox comboBoxClass;
        private System.Windows.Forms.Label labelClass;
        private System.Windows.Forms.ComboBox comboBoxTeacher;
        private System.Windows.Forms.Label labelTeacher;
        private System.Windows.Forms.ComboBox comboBoxSection;
        private System.Windows.Forms.Label labelSec;
        private System.Windows.Forms.Button buttonAssignTeacher;
    }
}