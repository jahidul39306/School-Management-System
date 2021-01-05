namespace School_Management_System.View
{
    partial class FormAddCourses
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
            this.comboBoxClaasId = new System.Windows.Forms.ComboBox();
            this.labelCId = new System.Windows.Forms.Label();
            this.labelCourseName = new System.Windows.Forms.Label();
            this.textBoxCourseName = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxClaasId
            // 
            this.comboBoxClaasId.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxClaasId.FormattingEnabled = true;
            this.comboBoxClaasId.Location = new System.Drawing.Point(292, 176);
            this.comboBoxClaasId.Name = "comboBoxClaasId";
            this.comboBoxClaasId.Size = new System.Drawing.Size(187, 31);
            this.comboBoxClaasId.TabIndex = 10;
            this.comboBoxClaasId.SelectedIndexChanged += new System.EventHandler(this.comboBoxClaasId_SelectedIndexChanged);
            // 
            // labelCId
            // 
            this.labelCId.AutoSize = true;
            this.labelCId.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCId.Location = new System.Drawing.Point(204, 176);
            this.labelCId.Name = "labelCId";
            this.labelCId.Size = new System.Drawing.Size(82, 23);
            this.labelCId.TabIndex = 9;
            this.labelCId.Text = "Class ID:";
            // 
            // labelCourseName
            // 
            this.labelCourseName.AutoSize = true;
            this.labelCourseName.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCourseName.Location = new System.Drawing.Point(152, 100);
            this.labelCourseName.Name = "labelCourseName";
            this.labelCourseName.Size = new System.Drawing.Size(130, 23);
            this.labelCourseName.TabIndex = 8;
            this.labelCourseName.Text = "Course Name:";
            // 
            // textBoxCourseName
            // 
            this.textBoxCourseName.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCourseName.Location = new System.Drawing.Point(292, 97);
            this.textBoxCourseName.Name = "textBoxCourseName";
            this.textBoxCourseName.Size = new System.Drawing.Size(187, 31);
            this.textBoxCourseName.TabIndex = 7;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(499, 298);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(149, 55);
            this.buttonAdd.TabIndex = 6;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // FormAddCourses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBoxClaasId);
            this.Controls.Add(this.labelCId);
            this.Controls.Add(this.labelCourseName);
            this.Controls.Add(this.textBoxCourseName);
            this.Controls.Add(this.buttonAdd);
            this.Name = "FormAddCourses";
            this.Text = "FormAddCourses";
            this.Load += new System.EventHandler(this.FormAddCourses_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxClaasId;
        private System.Windows.Forms.Label labelCId;
        private System.Windows.Forms.Label labelCourseName;
        private System.Windows.Forms.TextBox textBoxCourseName;
        private System.Windows.Forms.Button buttonAdd;
    }
}