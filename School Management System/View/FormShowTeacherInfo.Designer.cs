
namespace School_Management_System.View
{
    partial class FormShowTeacherInfo
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
            this.textBoxTeacherId = new System.Windows.Forms.TextBox();
            this.labelSearchTeacher = new System.Windows.Forms.Label();
            this.dataGridViewTeachers = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTeachers)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxTeacherId
            // 
            this.textBoxTeacherId.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTeacherId.Location = new System.Drawing.Point(421, 85);
            this.textBoxTeacherId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxTeacherId.Name = "textBoxTeacherId";
            this.textBoxTeacherId.Size = new System.Drawing.Size(419, 31);
            this.textBoxTeacherId.TabIndex = 45;
            this.textBoxTeacherId.TextChanged += new System.EventHandler(this.textBoxTeacherId_TextChanged);
            // 
            // labelSearchTeacher
            // 
            this.labelSearchTeacher.AutoSize = true;
            this.labelSearchTeacher.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearchTeacher.Location = new System.Drawing.Point(259, 88);
            this.labelSearchTeacher.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSearchTeacher.Name = "labelSearchTeacher";
            this.labelSearchTeacher.Size = new System.Drawing.Size(154, 23);
            this.labelSearchTeacher.TabIndex = 44;
            this.labelSearchTeacher.Text = "Search Teacher ";
            // 
            // dataGridViewTeachers
            // 
            this.dataGridViewTeachers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTeachers.Location = new System.Drawing.Point(36, 170);
            this.dataGridViewTeachers.Name = "dataGridViewTeachers";
            this.dataGridViewTeachers.RowHeadersWidth = 51;
            this.dataGridViewTeachers.RowTemplate.Height = 24;
            this.dataGridViewTeachers.Size = new System.Drawing.Size(1065, 306);
            this.dataGridViewTeachers.TabIndex = 46;
            this.dataGridViewTeachers.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTeachers_CellDoubleClick);
            // 
            // FormShowTeacherInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 554);
            this.Controls.Add(this.dataGridViewTeachers);
            this.Controls.Add(this.textBoxTeacherId);
            this.Controls.Add(this.labelSearchTeacher);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormShowTeacherInfo";
            this.Text = "FormShowTeacherInfo";
            this.Load += new System.EventHandler(this.FormShowTeacherInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTeachers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxTeacherId;
        private System.Windows.Forms.Label labelSearchTeacher;
        private System.Windows.Forms.DataGridView dataGridViewTeachers;
    }
}