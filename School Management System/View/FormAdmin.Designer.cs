
namespace School_Management_System.View
{
    partial class FormAdmin
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
            this.panelAdmin = new System.Windows.Forms.Panel();
            this.buttonTeacherAssign = new System.Windows.Forms.Button();
            this.buttonHome = new System.Windows.Forms.Button();
            this.buttonResultreport = new System.Windows.Forms.Button();
            this.buttonSection = new System.Windows.Forms.Button();
            this.buttonCourses = new System.Windows.Forms.Button();
            this.buttonTeachers = new System.Windows.Forms.Button();
            this.buttonStudents = new System.Windows.Forms.Button();
            this.panelStudent = new System.Windows.Forms.Panel();
            this.buttonShowStudent = new System.Windows.Forms.Button();
            this.buttonUpdateStudent = new System.Windows.Forms.Button();
            this.buttonAddStudent = new System.Windows.Forms.Button();
            this.panelTeacher = new System.Windows.Forms.Panel();
            this.buttonShowTeacher = new System.Windows.Forms.Button();
            this.buttonUpdateTeacher = new System.Windows.Forms.Button();
            this.buttonAddTeacher = new System.Windows.Forms.Button();
            this.panelCourse = new System.Windows.Forms.Panel();
            this.button = new System.Windows.Forms.Button();
            this.buttonUpdateCourse = new System.Windows.Forms.Button();
            this.buttonAddCourse = new System.Windows.Forms.Button();
            this.panelSection = new System.Windows.Forms.Panel();
            this.buttonShowSection = new System.Windows.Forms.Button();
            this.buttonUpdateSection = new System.Windows.Forms.Button();
            this.buttonAddSection = new System.Windows.Forms.Button();
            this.panelAdminHome = new System.Windows.Forms.Panel();
            this.labelYearlyEnrollment = new System.Windows.Forms.Label();
            this.labelEarning = new System.Windows.Forms.Label();
            this.labelTotalSection = new System.Windows.Forms.Label();
            this.labelTotalCourse = new System.Windows.Forms.Label();
            this.labelTotalStudent = new System.Windows.Forms.Label();
            this.labelTotalTeacher = new System.Windows.Forms.Label();
            this.panelResultReport = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.labelStudentId = new System.Windows.Forms.Label();
            this.buttonEnter = new System.Windows.Forms.Button();
            this.textBoxStudentId = new System.Windows.Forms.TextBox();
            this.dataGridViewResult = new System.Windows.Forms.DataGridView();
            this.panelAdmin.SuspendLayout();
            this.panelStudent.SuspendLayout();
            this.panelTeacher.SuspendLayout();
            this.panelCourse.SuspendLayout();
            this.panelSection.SuspendLayout();
            this.panelAdminHome.SuspendLayout();
            this.panelResultReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult)).BeginInit();
            this.SuspendLayout();
            // 
            // panelAdmin
            // 
            this.panelAdmin.BackColor = System.Drawing.Color.Gray;
            this.panelAdmin.Controls.Add(this.buttonTeacherAssign);
            this.panelAdmin.Controls.Add(this.buttonHome);
            this.panelAdmin.Controls.Add(this.buttonResultreport);
            this.panelAdmin.Controls.Add(this.buttonSection);
            this.panelAdmin.Controls.Add(this.buttonCourses);
            this.panelAdmin.Controls.Add(this.buttonTeachers);
            this.panelAdmin.Controls.Add(this.buttonStudents);
            this.panelAdmin.Location = new System.Drawing.Point(2, 12);
            this.panelAdmin.Name = "panelAdmin";
            this.panelAdmin.Size = new System.Drawing.Size(193, 409);
            this.panelAdmin.TabIndex = 0;
            // 
            // buttonTeacherAssign
            // 
            this.buttonTeacherAssign.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.buttonTeacherAssign.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTeacherAssign.Location = new System.Drawing.Point(10, 348);
            this.buttonTeacherAssign.Name = "buttonTeacherAssign";
            this.buttonTeacherAssign.Size = new System.Drawing.Size(164, 49);
            this.buttonTeacherAssign.TabIndex = 6;
            this.buttonTeacherAssign.Text = "Teacher Assign";
            this.buttonTeacherAssign.UseVisualStyleBackColor = false;
            // 
            // buttonHome
            // 
            this.buttonHome.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.buttonHome.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHome.Location = new System.Drawing.Point(10, 15);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(164, 49);
            this.buttonHome.TabIndex = 5;
            this.buttonHome.Text = "Home";
            this.buttonHome.UseVisualStyleBackColor = false;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // buttonResultreport
            // 
            this.buttonResultreport.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.buttonResultreport.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonResultreport.Location = new System.Drawing.Point(10, 290);
            this.buttonResultreport.Name = "buttonResultreport";
            this.buttonResultreport.Size = new System.Drawing.Size(164, 49);
            this.buttonResultreport.TabIndex = 4;
            this.buttonResultreport.Text = "Result report";
            this.buttonResultreport.UseVisualStyleBackColor = false;
            this.buttonResultreport.Click += new System.EventHandler(this.buttonResultreport_Click);
            // 
            // buttonSection
            // 
            this.buttonSection.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.buttonSection.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSection.Location = new System.Drawing.Point(10, 235);
            this.buttonSection.Name = "buttonSection";
            this.buttonSection.Size = new System.Drawing.Size(164, 49);
            this.buttonSection.TabIndex = 3;
            this.buttonSection.Text = "Sections";
            this.buttonSection.UseVisualStyleBackColor = false;
            this.buttonSection.Click += new System.EventHandler(this.buttonSection_Click);
            // 
            // buttonCourses
            // 
            this.buttonCourses.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.buttonCourses.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCourses.Location = new System.Drawing.Point(10, 180);
            this.buttonCourses.Name = "buttonCourses";
            this.buttonCourses.Size = new System.Drawing.Size(164, 49);
            this.buttonCourses.TabIndex = 2;
            this.buttonCourses.Text = "Courses";
            this.buttonCourses.UseVisualStyleBackColor = false;
            this.buttonCourses.Click += new System.EventHandler(this.buttonCourses_Click);
            // 
            // buttonTeachers
            // 
            this.buttonTeachers.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.buttonTeachers.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTeachers.Location = new System.Drawing.Point(10, 125);
            this.buttonTeachers.Name = "buttonTeachers";
            this.buttonTeachers.Size = new System.Drawing.Size(164, 49);
            this.buttonTeachers.TabIndex = 1;
            this.buttonTeachers.Text = "Teachers";
            this.buttonTeachers.UseVisualStyleBackColor = false;
            this.buttonTeachers.Click += new System.EventHandler(this.buttonTeachers_Click);
            // 
            // buttonStudents
            // 
            this.buttonStudents.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.buttonStudents.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStudents.Location = new System.Drawing.Point(10, 70);
            this.buttonStudents.Name = "buttonStudents";
            this.buttonStudents.Size = new System.Drawing.Size(164, 49);
            this.buttonStudents.TabIndex = 0;
            this.buttonStudents.Text = "Students";
            this.buttonStudents.UseVisualStyleBackColor = false;
            this.buttonStudents.Click += new System.EventHandler(this.buttonStudents_Click);
            // 
            // panelStudent
            // 
            this.panelStudent.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelStudent.Controls.Add(this.buttonShowStudent);
            this.panelStudent.Controls.Add(this.buttonUpdateStudent);
            this.panelStudent.Controls.Add(this.buttonAddStudent);
            this.panelStudent.Location = new System.Drawing.Point(201, 12);
            this.panelStudent.Name = "panelStudent";
            this.panelStudent.Size = new System.Drawing.Size(650, 409);
            this.panelStudent.TabIndex = 7;
            // 
            // buttonShowStudent
            // 
            this.buttonShowStudent.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.buttonShowStudent.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShowStudent.Location = new System.Drawing.Point(234, 218);
            this.buttonShowStudent.Name = "buttonShowStudent";
            this.buttonShowStudent.Size = new System.Drawing.Size(164, 49);
            this.buttonShowStudent.TabIndex = 9;
            this.buttonShowStudent.Text = "Show student";
            this.buttonShowStudent.UseVisualStyleBackColor = false;
            this.buttonShowStudent.Click += new System.EventHandler(this.buttonShowStudent_Click);
            // 
            // buttonUpdateStudent
            // 
            this.buttonUpdateStudent.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.buttonUpdateStudent.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdateStudent.Location = new System.Drawing.Point(330, 112);
            this.buttonUpdateStudent.Name = "buttonUpdateStudent";
            this.buttonUpdateStudent.Size = new System.Drawing.Size(164, 49);
            this.buttonUpdateStudent.TabIndex = 8;
            this.buttonUpdateStudent.Text = "Update/ Delete";
            this.buttonUpdateStudent.UseVisualStyleBackColor = false;
            this.buttonUpdateStudent.Click += new System.EventHandler(this.buttonUpdateStudent_Click);
            // 
            // buttonAddStudent
            // 
            this.buttonAddStudent.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.buttonAddStudent.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddStudent.Location = new System.Drawing.Point(123, 112);
            this.buttonAddStudent.Name = "buttonAddStudent";
            this.buttonAddStudent.Size = new System.Drawing.Size(164, 49);
            this.buttonAddStudent.TabIndex = 7;
            this.buttonAddStudent.Text = "Add student";
            this.buttonAddStudent.UseVisualStyleBackColor = false;
            this.buttonAddStudent.Click += new System.EventHandler(this.buttonAddStudent_Click);
            // 
            // panelTeacher
            // 
            this.panelTeacher.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelTeacher.Controls.Add(this.buttonShowTeacher);
            this.panelTeacher.Controls.Add(this.buttonUpdateTeacher);
            this.panelTeacher.Controls.Add(this.buttonAddTeacher);
            this.panelTeacher.Location = new System.Drawing.Point(201, 13);
            this.panelTeacher.Name = "panelTeacher";
            this.panelTeacher.Size = new System.Drawing.Size(650, 409);
            this.panelTeacher.TabIndex = 10;
            // 
            // buttonShowTeacher
            // 
            this.buttonShowTeacher.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.buttonShowTeacher.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShowTeacher.Location = new System.Drawing.Point(222, 219);
            this.buttonShowTeacher.Name = "buttonShowTeacher";
            this.buttonShowTeacher.Size = new System.Drawing.Size(164, 49);
            this.buttonShowTeacher.TabIndex = 9;
            this.buttonShowTeacher.Text = "Show Teacher";
            this.buttonShowTeacher.UseVisualStyleBackColor = false;
            this.buttonShowTeacher.Click += new System.EventHandler(this.buttonShowTeacher_Click);
            // 
            // buttonUpdateTeacher
            // 
            this.buttonUpdateTeacher.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.buttonUpdateTeacher.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdateTeacher.Location = new System.Drawing.Point(325, 105);
            this.buttonUpdateTeacher.Name = "buttonUpdateTeacher";
            this.buttonUpdateTeacher.Size = new System.Drawing.Size(164, 49);
            this.buttonUpdateTeacher.TabIndex = 8;
            this.buttonUpdateTeacher.Text = "Update/ Delete";
            this.buttonUpdateTeacher.UseVisualStyleBackColor = false;
            this.buttonUpdateTeacher.Click += new System.EventHandler(this.buttonUpdateTeacher_Click);
            // 
            // buttonAddTeacher
            // 
            this.buttonAddTeacher.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.buttonAddTeacher.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddTeacher.Location = new System.Drawing.Point(113, 105);
            this.buttonAddTeacher.Name = "buttonAddTeacher";
            this.buttonAddTeacher.Size = new System.Drawing.Size(164, 49);
            this.buttonAddTeacher.TabIndex = 7;
            this.buttonAddTeacher.Text = "Add Teacher";
            this.buttonAddTeacher.UseVisualStyleBackColor = false;
            this.buttonAddTeacher.Click += new System.EventHandler(this.buttonAddTeacher_Click);
            // 
            // panelCourse
            // 
            this.panelCourse.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelCourse.Controls.Add(this.button);
            this.panelCourse.Controls.Add(this.buttonUpdateCourse);
            this.panelCourse.Controls.Add(this.buttonAddCourse);
            this.panelCourse.Location = new System.Drawing.Point(198, 12);
            this.panelCourse.Name = "panelCourse";
            this.panelCourse.Size = new System.Drawing.Size(653, 406);
            this.panelCourse.TabIndex = 11;
            // 
            // button
            // 
            this.button.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button.Location = new System.Drawing.Point(217, 214);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(164, 49);
            this.button.TabIndex = 9;
            this.button.Text = "Show Course";
            this.button.UseVisualStyleBackColor = false;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonUpdateCourse
            // 
            this.buttonUpdateCourse.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.buttonUpdateCourse.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdateCourse.Location = new System.Drawing.Point(324, 112);
            this.buttonUpdateCourse.Name = "buttonUpdateCourse";
            this.buttonUpdateCourse.Size = new System.Drawing.Size(164, 49);
            this.buttonUpdateCourse.TabIndex = 8;
            this.buttonUpdateCourse.Text = "Update Course";
            this.buttonUpdateCourse.UseVisualStyleBackColor = false;
            this.buttonUpdateCourse.Click += new System.EventHandler(this.buttonUpdateCourse_Click);
            // 
            // buttonAddCourse
            // 
            this.buttonAddCourse.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.buttonAddCourse.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddCourse.Location = new System.Drawing.Point(94, 112);
            this.buttonAddCourse.Name = "buttonAddCourse";
            this.buttonAddCourse.Size = new System.Drawing.Size(164, 49);
            this.buttonAddCourse.TabIndex = 7;
            this.buttonAddCourse.Text = "Add Course";
            this.buttonAddCourse.UseVisualStyleBackColor = false;
            this.buttonAddCourse.Click += new System.EventHandler(this.buttonAddCourse_Click);
            // 
            // panelSection
            // 
            this.panelSection.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelSection.Controls.Add(this.buttonShowSection);
            this.panelSection.Controls.Add(this.buttonUpdateSection);
            this.panelSection.Controls.Add(this.buttonAddSection);
            this.panelSection.Location = new System.Drawing.Point(195, 12);
            this.panelSection.Name = "panelSection";
            this.panelSection.Size = new System.Drawing.Size(656, 409);
            this.panelSection.TabIndex = 11;
            // 
            // buttonShowSection
            // 
            this.buttonShowSection.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.buttonShowSection.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShowSection.Location = new System.Drawing.Point(225, 201);
            this.buttonShowSection.Name = "buttonShowSection";
            this.buttonShowSection.Size = new System.Drawing.Size(164, 49);
            this.buttonShowSection.TabIndex = 9;
            this.buttonShowSection.Text = "Show Section";
            this.buttonShowSection.UseVisualStyleBackColor = false;
            this.buttonShowSection.Click += new System.EventHandler(this.buttonShowSection_Click);
            // 
            // buttonUpdateSection
            // 
            this.buttonUpdateSection.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.buttonUpdateSection.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdateSection.Location = new System.Drawing.Point(342, 105);
            this.buttonUpdateSection.Name = "buttonUpdateSection";
            this.buttonUpdateSection.Size = new System.Drawing.Size(164, 49);
            this.buttonUpdateSection.TabIndex = 8;
            this.buttonUpdateSection.Text = "Update/Delete";
            this.buttonUpdateSection.UseVisualStyleBackColor = false;
            this.buttonUpdateSection.Click += new System.EventHandler(this.buttonUpdateSection_Click);
            // 
            // buttonAddSection
            // 
            this.buttonAddSection.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.buttonAddSection.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddSection.Location = new System.Drawing.Point(107, 105);
            this.buttonAddSection.Name = "buttonAddSection";
            this.buttonAddSection.Size = new System.Drawing.Size(164, 49);
            this.buttonAddSection.TabIndex = 7;
            this.buttonAddSection.Text = "Add Section";
            this.buttonAddSection.UseVisualStyleBackColor = false;
            this.buttonAddSection.Click += new System.EventHandler(this.buttonAddSection_Click);
            // 
            // panelAdminHome
            // 
            this.panelAdminHome.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelAdminHome.Controls.Add(this.labelYearlyEnrollment);
            this.panelAdminHome.Controls.Add(this.labelEarning);
            this.panelAdminHome.Controls.Add(this.labelTotalSection);
            this.panelAdminHome.Controls.Add(this.labelTotalCourse);
            this.panelAdminHome.Controls.Add(this.labelTotalStudent);
            this.panelAdminHome.Controls.Add(this.labelTotalTeacher);
            this.panelAdminHome.Location = new System.Drawing.Point(201, 12);
            this.panelAdminHome.Name = "panelAdminHome";
            this.panelAdminHome.Size = new System.Drawing.Size(636, 409);
            this.panelAdminHome.TabIndex = 1;
            this.panelAdminHome.Paint += new System.Windows.Forms.PaintEventHandler(this.panelAdminHome_Paint);
            // 
            // labelYearlyEnrollment
            // 
            this.labelYearlyEnrollment.AutoSize = true;
            this.labelYearlyEnrollment.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelYearlyEnrollment.Location = new System.Drawing.Point(60, 265);
            this.labelYearlyEnrollment.Name = "labelYearlyEnrollment";
            this.labelYearlyEnrollment.Size = new System.Drawing.Size(162, 19);
            this.labelYearlyEnrollment.TabIndex = 5;
            this.labelYearlyEnrollment.Text = "Yearly Enrollment :   ";
            // 
            // labelEarning
            // 
            this.labelEarning.AutoSize = true;
            this.labelEarning.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEarning.Location = new System.Drawing.Point(375, 265);
            this.labelEarning.Name = "labelEarning";
            this.labelEarning.Size = new System.Drawing.Size(129, 19);
            this.labelEarning.TabIndex = 4;
            this.labelEarning.Text = "Total Earning :   ";
            // 
            // labelTotalSection
            // 
            this.labelTotalSection.AutoSize = true;
            this.labelTotalSection.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalSection.Location = new System.Drawing.Point(379, 168);
            this.labelTotalSection.Name = "labelTotalSection";
            this.labelTotalSection.Size = new System.Drawing.Size(125, 19);
            this.labelTotalSection.TabIndex = 3;
            this.labelTotalSection.Text = "Total Section :   ";
            // 
            // labelTotalCourse
            // 
            this.labelTotalCourse.AutoSize = true;
            this.labelTotalCourse.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalCourse.Location = new System.Drawing.Point(59, 168);
            this.labelTotalCourse.Name = "labelTotalCourse";
            this.labelTotalCourse.Size = new System.Drawing.Size(121, 19);
            this.labelTotalCourse.TabIndex = 2;
            this.labelTotalCourse.Text = "Total Course :   ";
            // 
            // labelTotalStudent
            // 
            this.labelTotalStudent.AutoSize = true;
            this.labelTotalStudent.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalStudent.Location = new System.Drawing.Point(60, 70);
            this.labelTotalStudent.Name = "labelTotalStudent";
            this.labelTotalStudent.Size = new System.Drawing.Size(129, 19);
            this.labelTotalStudent.TabIndex = 1;
            this.labelTotalStudent.Text = "Total Student :   ";
            // 
            // labelTotalTeacher
            // 
            this.labelTotalTeacher.AutoSize = true;
            this.labelTotalTeacher.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalTeacher.Location = new System.Drawing.Point(379, 70);
            this.labelTotalTeacher.Name = "labelTotalTeacher";
            this.labelTotalTeacher.Size = new System.Drawing.Size(130, 19);
            this.labelTotalTeacher.TabIndex = 0;
            this.labelTotalTeacher.Text = "Total Teacher :   ";
            // 
            // panelResultReport
            // 
            this.panelResultReport.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelResultReport.Controls.Add(this.label1);
            this.panelResultReport.Controls.Add(this.labelStudentId);
            this.panelResultReport.Controls.Add(this.buttonEnter);
            this.panelResultReport.Controls.Add(this.textBoxStudentId);
            this.panelResultReport.Controls.Add(this.dataGridViewResult);
            this.panelResultReport.Location = new System.Drawing.Point(201, 12);
            this.panelResultReport.Name = "panelResultReport";
            this.panelResultReport.Size = new System.Drawing.Size(650, 409);
            this.panelResultReport.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Result Information :";
            // 
            // labelStudentId
            // 
            this.labelStudentId.AutoSize = true;
            this.labelStudentId.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStudentId.Location = new System.Drawing.Point(73, 20);
            this.labelStudentId.Name = "labelStudentId";
            this.labelStudentId.Size = new System.Drawing.Size(87, 19);
            this.labelStudentId.TabIndex = 3;
            this.labelStudentId.Text = "Student Id";
            this.labelStudentId.Click += new System.EventHandler(this.labelStudentId_Click);
            // 
            // buttonEnter
            // 
            this.buttonEnter.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEnter.Location = new System.Drawing.Point(166, 59);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(75, 28);
            this.buttonEnter.TabIndex = 2;
            this.buttonEnter.Text = "Enter";
            this.buttonEnter.UseVisualStyleBackColor = true;
            this.buttonEnter.Click += new System.EventHandler(this.buttonEnter_Click);
            // 
            // textBoxStudentId
            // 
            this.textBoxStudentId.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxStudentId.Location = new System.Drawing.Point(166, 17);
            this.textBoxStudentId.Name = "textBoxStudentId";
            this.textBoxStudentId.Size = new System.Drawing.Size(139, 26);
            this.textBoxStudentId.TabIndex = 1;
            // 
            // dataGridViewResult
            // 
            this.dataGridViewResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult.Location = new System.Drawing.Point(69, 184);
            this.dataGridViewResult.Name = "dataGridViewResult";
            this.dataGridViewResult.Size = new System.Drawing.Size(343, 203);
            this.dataGridViewResult.TabIndex = 0;
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(863, 464);
            this.Controls.Add(this.panelStudent);
            this.Controls.Add(this.panelSection);
            this.Controls.Add(this.panelCourse);
            this.Controls.Add(this.panelTeacher);
            this.Controls.Add(this.panelResultReport);
            this.Controls.Add(this.panelAdminHome);
            this.Controls.Add(this.panelAdmin);
            this.Name = "FormAdmin";
            this.Text = "FormAdmin";
            this.Load += new System.EventHandler(this.FormAdmin_Load);
            this.panelAdmin.ResumeLayout(false);
            this.panelStudent.ResumeLayout(false);
            this.panelTeacher.ResumeLayout(false);
            this.panelCourse.ResumeLayout(false);
            this.panelSection.ResumeLayout(false);
            this.panelAdminHome.ResumeLayout(false);
            this.panelAdminHome.PerformLayout();
            this.panelResultReport.ResumeLayout(false);
            this.panelResultReport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelAdmin;
        private System.Windows.Forms.Button buttonTeacherAssign;
        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.Button buttonResultreport;
        private System.Windows.Forms.Button buttonSection;
        private System.Windows.Forms.Button buttonCourses;
        private System.Windows.Forms.Button buttonTeachers;
        private System.Windows.Forms.Button buttonStudents;
        private System.Windows.Forms.Panel panelStudent;
        private System.Windows.Forms.Panel panelTeacher;
        private System.Windows.Forms.Panel panelCourse;
        private System.Windows.Forms.Panel panelSection;
        private System.Windows.Forms.Button buttonUpdateSection;
        private System.Windows.Forms.Button buttonAddSection;
        private System.Windows.Forms.Button buttonUpdateCourse;
        private System.Windows.Forms.Button buttonAddCourse;
        private System.Windows.Forms.Button buttonUpdateTeacher;
        private System.Windows.Forms.Button buttonAddTeacher;
        private System.Windows.Forms.Button buttonUpdateStudent;
        private System.Windows.Forms.Button buttonAddStudent;
        private System.Windows.Forms.Button buttonShowStudent;
        private System.Windows.Forms.Button buttonShowTeacher;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.Button buttonShowSection;
        private System.Windows.Forms.Panel panelAdminHome;
        private System.Windows.Forms.Label labelYearlyEnrollment;
        private System.Windows.Forms.Label labelEarning;
        private System.Windows.Forms.Label labelTotalSection;
        private System.Windows.Forms.Label labelTotalCourse;
        private System.Windows.Forms.Label labelTotalStudent;
        private System.Windows.Forms.Label labelTotalTeacher;
        private System.Windows.Forms.Panel panelResultReport;
        private System.Windows.Forms.DataGridView dataGridViewResult;
        private System.Windows.Forms.Label labelStudentId;
        private System.Windows.Forms.Button buttonEnter;
        private System.Windows.Forms.TextBox textBoxStudentId;
        private System.Windows.Forms.Label label1;
    }
}