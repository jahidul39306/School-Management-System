namespace School_Management_System.View
{
    partial class FormUpdateCourse
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
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.labelSecName = new System.Windows.Forms.Label();
            this.labelCId = new System.Windows.Forms.Label();
            this.textBoxCId = new System.Windows.Forms.TextBox();
            this.textBoxCourseName = new System.Windows.Forms.TextBox();
            this.labelCourseId = new System.Windows.Forms.Label();
            this.textBoxCourseId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.Location = new System.Drawing.Point(486, 316);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(111, 43);
            this.buttonUpdate.TabIndex = 20;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.Red;
            this.buttonDelete.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.ForeColor = System.Drawing.Color.Snow;
            this.buttonDelete.Location = new System.Drawing.Point(640, 316);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(111, 43);
            this.buttonDelete.TabIndex = 19;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.Location = new System.Drawing.Point(547, 89);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(111, 43);
            this.buttonSearch.TabIndex = 18;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // labelSecName
            // 
            this.labelSecName.AutoSize = true;
            this.labelSecName.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSecName.Location = new System.Drawing.Point(166, 184);
            this.labelSecName.Name = "labelSecName";
            this.labelSecName.Size = new System.Drawing.Size(130, 23);
            this.labelSecName.TabIndex = 17;
            this.labelSecName.Text = "Course Name:";
            // 
            // labelCId
            // 
            this.labelCId.AutoSize = true;
            this.labelCId.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCId.Location = new System.Drawing.Point(220, 248);
            this.labelCId.Name = "labelCId";
            this.labelCId.Size = new System.Drawing.Size(80, 23);
            this.labelCId.TabIndex = 16;
            this.labelCId.Text = "Class Id:";
            // 
            // textBoxCId
            // 
            this.textBoxCId.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCId.Location = new System.Drawing.Point(306, 240);
            this.textBoxCId.Name = "textBoxCId";
            this.textBoxCId.Size = new System.Drawing.Size(187, 31);
            this.textBoxCId.TabIndex = 15;
            // 
            // textBoxCourseName
            // 
            this.textBoxCourseName.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCourseName.Location = new System.Drawing.Point(306, 181);
            this.textBoxCourseName.Name = "textBoxCourseName";
            this.textBoxCourseName.Size = new System.Drawing.Size(187, 31);
            this.textBoxCourseName.TabIndex = 14;
            // 
            // labelCourseId
            // 
            this.labelCourseId.AutoSize = true;
            this.labelCourseId.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCourseId.Location = new System.Drawing.Point(200, 99);
            this.labelCourseId.Name = "labelCourseId";
            this.labelCourseId.Size = new System.Drawing.Size(96, 23);
            this.labelCourseId.TabIndex = 13;
            this.labelCourseId.Text = "Course Id:";
            // 
            // textBoxCourseId
            // 
            this.textBoxCourseId.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCourseId.Location = new System.Drawing.Point(306, 96);
            this.textBoxCourseId.Name = "textBoxCourseId";
            this.textBoxCourseId.Size = new System.Drawing.Size(187, 31);
            this.textBoxCourseId.TabIndex = 12;
            // 
            // FormUpdateCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 448);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.labelSecName);
            this.Controls.Add(this.labelCId);
            this.Controls.Add(this.textBoxCId);
            this.Controls.Add(this.textBoxCourseName);
            this.Controls.Add(this.labelCourseId);
            this.Controls.Add(this.textBoxCourseId);
            this.Name = "FormUpdateCourse";
            this.Text = "FormUpdateCourse";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label labelSecName;
        private System.Windows.Forms.Label labelCId;
        private System.Windows.Forms.TextBox textBoxCId;
        private System.Windows.Forms.TextBox textBoxCourseName;
        private System.Windows.Forms.Label labelCourseId;
        private System.Windows.Forms.TextBox textBoxCourseId;
    }
}