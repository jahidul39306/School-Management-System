
namespace School_Management_System.View
{
    partial class FormAdminStudentInfo
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
            this.labelStudentInfo = new System.Windows.Forms.Label();
            this.textBoxStudentInfo = new System.Windows.Forms.TextBox();
            this.dataGridViewStudentInfo = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudentInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // labelStudentInfo
            // 
            this.labelStudentInfo.AutoSize = true;
            this.labelStudentInfo.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStudentInfo.Location = new System.Drawing.Point(285, 82);
            this.labelStudentInfo.Name = "labelStudentInfo";
            this.labelStudentInfo.Size = new System.Drawing.Size(144, 23);
            this.labelStudentInfo.TabIndex = 0;
            this.labelStudentInfo.Text = "Search Student:";
            // 
            // textBoxStudentInfo
            // 
            this.textBoxStudentInfo.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxStudentInfo.Location = new System.Drawing.Point(460, 79);
            this.textBoxStudentInfo.Name = "textBoxStudentInfo";
            this.textBoxStudentInfo.Size = new System.Drawing.Size(310, 31);
            this.textBoxStudentInfo.TabIndex = 1;
            this.textBoxStudentInfo.TextChanged += new System.EventHandler(this.textBoxStudentInfo_TextChanged);
            // 
            // dataGridViewStudentInfo
            // 
            this.dataGridViewStudentInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudentInfo.Location = new System.Drawing.Point(30, 163);
            this.dataGridViewStudentInfo.Name = "dataGridViewStudentInfo";
            this.dataGridViewStudentInfo.RowHeadersWidth = 51;
            this.dataGridViewStudentInfo.RowTemplate.Height = 24;
            this.dataGridViewStudentInfo.Size = new System.Drawing.Size(1135, 265);
            this.dataGridViewStudentInfo.TabIndex = 2;
            // 
            // FormAdminStudentInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 458);
            this.Controls.Add(this.dataGridViewStudentInfo);
            this.Controls.Add(this.textBoxStudentInfo);
            this.Controls.Add(this.labelStudentInfo);
            this.Name = "FormAdminStudentInfo";
            this.Text = "FormAdminStudentInfo";
            this.Load += new System.EventHandler(this.FormAdminStudentInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudentInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelStudentInfo;
        private System.Windows.Forms.TextBox textBoxStudentInfo;
        private System.Windows.Forms.DataGridView dataGridViewStudentInfo;
    }
}