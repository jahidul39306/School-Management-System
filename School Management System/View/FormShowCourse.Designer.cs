
namespace School_Management_System.View
{
    partial class FormShowCourse
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
            this.dataGridViewCourse = new System.Windows.Forms.DataGridView();
            this.textBoxSearchCourse = new System.Windows.Forms.TextBox();
            this.labelSearchCourses = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCourse)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewCourse
            // 
            this.dataGridViewCourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCourse.Location = new System.Drawing.Point(69, 135);
            this.dataGridViewCourse.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewCourse.Name = "dataGridViewCourse";
            this.dataGridViewCourse.RowHeadersWidth = 51;
            this.dataGridViewCourse.RowTemplate.Height = 24;
            this.dataGridViewCourse.Size = new System.Drawing.Size(614, 249);
            this.dataGridViewCourse.TabIndex = 49;
            // 
            // textBoxSearchCourse
            // 
            this.textBoxSearchCourse.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearchCourse.Location = new System.Drawing.Point(358, 66);
            this.textBoxSearchCourse.Name = "textBoxSearchCourse";
            this.textBoxSearchCourse.Size = new System.Drawing.Size(130, 26);
            this.textBoxSearchCourse.TabIndex = 48;
            this.textBoxSearchCourse.TextChanged += new System.EventHandler(this.textBoxSearchCourse_TextChanged);
            // 
            // labelSearchCourses
            // 
            this.labelSearchCourses.AutoSize = true;
            this.labelSearchCourses.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearchCourses.Location = new System.Drawing.Point(197, 69);
            this.labelSearchCourses.Name = "labelSearchCourses";
            this.labelSearchCourses.Size = new System.Drawing.Size(117, 19);
            this.labelSearchCourses.TabIndex = 47;
            this.labelSearchCourses.Text = "Search Course ";
            // 
            // FormShowCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewCourse);
            this.Controls.Add(this.textBoxSearchCourse);
            this.Controls.Add(this.labelSearchCourses);
            this.Name = "FormShowCourse";
            this.Text = "FormShowCourse";
            this.Load += new System.EventHandler(this.FormShowCourse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCourse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCourse;
        private System.Windows.Forms.TextBox textBoxSearchCourse;
        private System.Windows.Forms.Label labelSearchCourses;
    }
}