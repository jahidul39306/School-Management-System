
namespace School_Management_System.View
{
    partial class FormShowSections
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
            this.dataGridViewSections = new System.Windows.Forms.DataGridView();
            this.textBoxSecName = new System.Windows.Forms.TextBox();
            this.labelSecName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSections)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewSections
            // 
            this.dataGridViewSections.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSections.Location = new System.Drawing.Point(215, 170);
            this.dataGridViewSections.Name = "dataGridViewSections";
            this.dataGridViewSections.RowHeadersWidth = 51;
            this.dataGridViewSections.RowTemplate.Height = 24;
            this.dataGridViewSections.Size = new System.Drawing.Size(530, 190);
            this.dataGridViewSections.TabIndex = 0;
            this.dataGridViewSections.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSections_CellContentClick);
            // 
            // textBoxSecName
            // 
            this.textBoxSecName.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSecName.Location = new System.Drawing.Point(448, 77);
            this.textBoxSecName.Name = "textBoxSecName";
            this.textBoxSecName.Size = new System.Drawing.Size(187, 31);
            this.textBoxSecName.TabIndex = 3;
            this.textBoxSecName.TextChanged += new System.EventHandler(this.textBoxSecName_TextChanged);
            // 
            // labelSecName
            // 
            this.labelSecName.AutoSize = true;
            this.labelSecName.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSecName.Location = new System.Drawing.Point(308, 77);
            this.labelSecName.Name = "labelSecName";
            this.labelSecName.Size = new System.Drawing.Size(134, 23);
            this.labelSecName.TabIndex = 9;
            this.labelSecName.Text = "Section Name:";
            // 
            // FormShowSections
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 461);
            this.Controls.Add(this.labelSecName);
            this.Controls.Add(this.textBoxSecName);
            this.Controls.Add(this.dataGridViewSections);
            this.Name = "FormShowSections";
            this.Text = "FormShowSections";
            this.Load += new System.EventHandler(this.FormShowSections_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSections)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewSections;
        private System.Windows.Forms.TextBox textBoxSecName;
        private System.Windows.Forms.Label labelSecName;
    }
}