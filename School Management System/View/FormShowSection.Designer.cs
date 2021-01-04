
namespace School_Management_System.View
{
    partial class FormShowSection
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
            this.dataGridViewSection = new System.Windows.Forms.DataGridView();
            this.textBoxSearchSection = new System.Windows.Forms.TextBox();
            this.labelSearchSection = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSection)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewSection
            // 
            this.dataGridViewSection.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSection.Location = new System.Drawing.Point(93, 135);
            this.dataGridViewSection.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewSection.Name = "dataGridViewSection";
            this.dataGridViewSection.RowHeadersWidth = 51;
            this.dataGridViewSection.RowTemplate.Height = 24;
            this.dataGridViewSection.Size = new System.Drawing.Size(614, 249);
            this.dataGridViewSection.TabIndex = 52;
            // 
            // textBoxSearchSection
            // 
            this.textBoxSearchSection.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearchSection.Location = new System.Drawing.Point(382, 66);
            this.textBoxSearchSection.Name = "textBoxSearchSection";
            this.textBoxSearchSection.Size = new System.Drawing.Size(130, 26);
            this.textBoxSearchSection.TabIndex = 51;
            this.textBoxSearchSection.TextChanged += new System.EventHandler(this.textBoxSearchSection_TextChanged);
            // 
            // labelSearchSection
            // 
            this.labelSearchSection.AutoSize = true;
            this.labelSearchSection.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearchSection.Location = new System.Drawing.Point(221, 69);
            this.labelSearchSection.Name = "labelSearchSection";
            this.labelSearchSection.Size = new System.Drawing.Size(117, 19);
            this.labelSearchSection.TabIndex = 50;
            this.labelSearchSection.Text = "Search Section";
            // 
            // FormShowSection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewSection);
            this.Controls.Add(this.textBoxSearchSection);
            this.Controls.Add(this.labelSearchSection);
            this.Name = "FormShowSection";
            this.Text = "FormShowSection";
            this.Load += new System.EventHandler(this.FormShowSection_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSection)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewSection;
        private System.Windows.Forms.TextBox textBoxSearchSection;
        private System.Windows.Forms.Label labelSearchSection;
    }
}