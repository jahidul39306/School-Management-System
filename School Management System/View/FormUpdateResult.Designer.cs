
namespace School_Management_System.View
{
    partial class FormUpdateResult
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
            this.comboBoxSection = new System.Windows.Forms.ComboBox();
            this.textBoxPObtainedMark = new System.Windows.Forms.TextBox();
            this.labelSection = new System.Windows.Forms.Label();
            this.buttonResultUpdate = new System.Windows.Forms.Button();
            this.comboBoxClass = new System.Windows.Forms.ComboBox();
            this.textBoxTotalMark = new System.Windows.Forms.TextBox();
            this.labelClass = new System.Windows.Forms.Label();
            this.labelPreviousObtainedMark = new System.Windows.Forms.Label();
            this.textBoxSearchStudent = new System.Windows.Forms.TextBox();
            this.labelTotalMark = new System.Windows.Forms.Label();
            this.labelCourse = new System.Windows.Forms.Label();
            this.comboBoxCourse = new System.Windows.Forms.ComboBox();
            this.labelStudentId = new System.Windows.Forms.Label();
            this.buttonGetResult = new System.Windows.Forms.Button();
            this.textBoxNoMark = new System.Windows.Forms.TextBox();
            this.labelNewObtainedMark = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxSection
            // 
            this.comboBoxSection.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSection.FormattingEnabled = true;
            this.comboBoxSection.Location = new System.Drawing.Point(232, 163);
            this.comboBoxSection.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxSection.Name = "comboBoxSection";
            this.comboBoxSection.Size = new System.Drawing.Size(160, 31);
            this.comboBoxSection.TabIndex = 17;
            // 
            // textBoxPObtainedMark
            // 
            this.textBoxPObtainedMark.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPObtainedMark.Location = new System.Drawing.Point(793, 179);
            this.textBoxPObtainedMark.Name = "textBoxPObtainedMark";
            this.textBoxPObtainedMark.Size = new System.Drawing.Size(135, 31);
            this.textBoxPObtainedMark.TabIndex = 25;
            // 
            // labelSection
            // 
            this.labelSection.AutoSize = true;
            this.labelSection.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSection.Location = new System.Drawing.Point(126, 167);
            this.labelSection.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSection.Name = "labelSection";
            this.labelSection.Size = new System.Drawing.Size(101, 23);
            this.labelSection.TabIndex = 16;
            this.labelSection.Text = "Section ID";
            // 
            // buttonResultUpdate
            // 
            this.buttonResultUpdate.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonResultUpdate.Location = new System.Drawing.Point(768, 341);
            this.buttonResultUpdate.Name = "buttonResultUpdate";
            this.buttonResultUpdate.Size = new System.Drawing.Size(160, 56);
            this.buttonResultUpdate.TabIndex = 26;
            this.buttonResultUpdate.Text = "Update Result";
            this.buttonResultUpdate.UseVisualStyleBackColor = true;
            this.buttonResultUpdate.Click += new System.EventHandler(this.buttonResultUpdate_Click);
            // 
            // comboBoxClass
            // 
            this.comboBoxClass.AllowDrop = true;
            this.comboBoxClass.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxClass.FormattingEnabled = true;
            this.comboBoxClass.Location = new System.Drawing.Point(232, 115);
            this.comboBoxClass.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxClass.Name = "comboBoxClass";
            this.comboBoxClass.Size = new System.Drawing.Size(160, 31);
            this.comboBoxClass.TabIndex = 15;
            // 
            // textBoxTotalMark
            // 
            this.textBoxTotalMark.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTotalMark.Location = new System.Drawing.Point(793, 116);
            this.textBoxTotalMark.Name = "textBoxTotalMark";
            this.textBoxTotalMark.Size = new System.Drawing.Size(135, 31);
            this.textBoxTotalMark.TabIndex = 24;
            this.textBoxTotalMark.TextChanged += new System.EventHandler(this.textBoxTotalMark_TextChanged);
            // 
            // labelClass
            // 
            this.labelClass.AutoSize = true;
            this.labelClass.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClass.Location = new System.Drawing.Point(149, 123);
            this.labelClass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelClass.Name = "labelClass";
            this.labelClass.Size = new System.Drawing.Size(81, 23);
            this.labelClass.TabIndex = 14;
            this.labelClass.Text = "Class ID";
            // 
            // labelPreviousObtainedMark
            // 
            this.labelPreviousObtainedMark.AutoSize = true;
            this.labelPreviousObtainedMark.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPreviousObtainedMark.Location = new System.Drawing.Point(548, 187);
            this.labelPreviousObtainedMark.Name = "labelPreviousObtainedMark";
            this.labelPreviousObtainedMark.Size = new System.Drawing.Size(239, 23);
            this.labelPreviousObtainedMark.TabIndex = 23;
            this.labelPreviousObtainedMark.Text = "Previous Obtained Mark:";
            // 
            // textBoxSearchStudent
            // 
            this.textBoxSearchStudent.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearchStudent.Location = new System.Drawing.Point(232, 284);
            this.textBoxSearchStudent.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSearchStudent.Name = "textBoxSearchStudent";
            this.textBoxSearchStudent.Size = new System.Drawing.Size(213, 31);
            this.textBoxSearchStudent.TabIndex = 21;
            // 
            // labelTotalMark
            // 
            this.labelTotalMark.AutoSize = true;
            this.labelTotalMark.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalMark.Location = new System.Drawing.Point(672, 119);
            this.labelTotalMark.Name = "labelTotalMark";
            this.labelTotalMark.Size = new System.Drawing.Size(115, 23);
            this.labelTotalMark.TabIndex = 22;
            this.labelTotalMark.Text = "Total Mark:";
            // 
            // labelCourse
            // 
            this.labelCourse.AutoSize = true;
            this.labelCourse.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCourse.Location = new System.Drawing.Point(126, 233);
            this.labelCourse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCourse.Name = "labelCourse";
            this.labelCourse.Size = new System.Drawing.Size(98, 23);
            this.labelCourse.TabIndex = 18;
            this.labelCourse.Text = "Course ID";
            // 
            // comboBoxCourse
            // 
            this.comboBoxCourse.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCourse.FormattingEnabled = true;
            this.comboBoxCourse.Location = new System.Drawing.Point(232, 230);
            this.comboBoxCourse.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxCourse.Name = "comboBoxCourse";
            this.comboBoxCourse.Size = new System.Drawing.Size(160, 31);
            this.comboBoxCourse.TabIndex = 19;
            // 
            // labelStudentId
            // 
            this.labelStudentId.AutoSize = true;
            this.labelStudentId.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStudentId.Location = new System.Drawing.Point(118, 286);
            this.labelStudentId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStudentId.Name = "labelStudentId";
            this.labelStudentId.Size = new System.Drawing.Size(106, 23);
            this.labelStudentId.TabIndex = 20;
            this.labelStudentId.Text = "Student ID";
            // 
            // buttonGetResult
            // 
            this.buttonGetResult.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGetResult.Location = new System.Drawing.Point(285, 354);
            this.buttonGetResult.Name = "buttonGetResult";
            this.buttonGetResult.Size = new System.Drawing.Size(160, 43);
            this.buttonGetResult.TabIndex = 27;
            this.buttonGetResult.Text = "Get Result";
            this.buttonGetResult.UseVisualStyleBackColor = true;
            this.buttonGetResult.Click += new System.EventHandler(this.buttonGetResult_Click);
            // 
            // textBoxNoMark
            // 
            this.textBoxNoMark.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNoMark.Location = new System.Drawing.Point(793, 250);
            this.textBoxNoMark.Name = "textBoxNoMark";
            this.textBoxNoMark.Size = new System.Drawing.Size(135, 31);
            this.textBoxNoMark.TabIndex = 29;
            // 
            // labelNewObtainedMark
            // 
            this.labelNewObtainedMark.AutoSize = true;
            this.labelNewObtainedMark.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNewObtainedMark.Location = new System.Drawing.Point(588, 253);
            this.labelNewObtainedMark.Name = "labelNewObtainedMark";
            this.labelNewObtainedMark.Size = new System.Drawing.Size(199, 23);
            this.labelNewObtainedMark.TabIndex = 28;
            this.labelNewObtainedMark.Text = "New Obtained Mark:";
            // 
            // FormUpdateResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 512);
            this.Controls.Add(this.textBoxNoMark);
            this.Controls.Add(this.labelNewObtainedMark);
            this.Controls.Add(this.buttonGetResult);
            this.Controls.Add(this.comboBoxSection);
            this.Controls.Add(this.textBoxPObtainedMark);
            this.Controls.Add(this.labelSection);
            this.Controls.Add(this.buttonResultUpdate);
            this.Controls.Add(this.comboBoxClass);
            this.Controls.Add(this.textBoxTotalMark);
            this.Controls.Add(this.labelClass);
            this.Controls.Add(this.labelPreviousObtainedMark);
            this.Controls.Add(this.textBoxSearchStudent);
            this.Controls.Add(this.labelTotalMark);
            this.Controls.Add(this.labelCourse);
            this.Controls.Add(this.comboBoxCourse);
            this.Controls.Add(this.labelStudentId);
            this.Name = "FormUpdateResult";
            this.Text = "FormUpdateResult";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxSection;
        private System.Windows.Forms.TextBox textBoxPObtainedMark;
        private System.Windows.Forms.Label labelSection;
        private System.Windows.Forms.Button buttonResultUpdate;
        private System.Windows.Forms.ComboBox comboBoxClass;
        private System.Windows.Forms.TextBox textBoxTotalMark;
        private System.Windows.Forms.Label labelClass;
        private System.Windows.Forms.Label labelPreviousObtainedMark;
        private System.Windows.Forms.TextBox textBoxSearchStudent;
        private System.Windows.Forms.Label labelTotalMark;
        private System.Windows.Forms.Label labelCourse;
        private System.Windows.Forms.ComboBox comboBoxCourse;
        private System.Windows.Forms.Label labelStudentId;
        private System.Windows.Forms.Button buttonGetResult;
        private System.Windows.Forms.TextBox textBoxNoMark;
        private System.Windows.Forms.Label labelNewObtainedMark;
    }
}