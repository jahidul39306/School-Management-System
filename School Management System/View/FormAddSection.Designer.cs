
namespace School_Management_System.View
{
    partial class FormAddSection
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
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxClassId = new System.Windows.Forms.TextBox();
            this.labelClassId = new System.Windows.Forms.Label();
            this.textBoxSectionName = new System.Windows.Forms.TextBox();
            this.labelSectionName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(328, 236);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(138, 56);
            this.buttonAdd.TabIndex = 9;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxClassId
            // 
            this.textBoxClassId.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxClassId.Location = new System.Drawing.Point(328, 159);
            this.textBoxClassId.Name = "textBoxClassId";
            this.textBoxClassId.Size = new System.Drawing.Size(198, 30);
            this.textBoxClassId.TabIndex = 8;
            // 
            // labelClassId
            // 
            this.labelClassId.AutoSize = true;
            this.labelClassId.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClassId.Location = new System.Drawing.Point(224, 159);
            this.labelClassId.Name = "labelClassId";
            this.labelClassId.Size = new System.Drawing.Size(77, 22);
            this.labelClassId.TabIndex = 7;
            this.labelClassId.Text = "Class Id";
            // 
            // textBoxSectionName
            // 
            this.textBoxSectionName.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSectionName.Location = new System.Drawing.Point(328, 106);
            this.textBoxSectionName.Name = "textBoxSectionName";
            this.textBoxSectionName.Size = new System.Drawing.Size(198, 30);
            this.textBoxSectionName.TabIndex = 6;
            // 
            // labelSectionName
            // 
            this.labelSectionName.AutoSize = true;
            this.labelSectionName.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSectionName.Location = new System.Drawing.Point(172, 109);
            this.labelSectionName.Name = "labelSectionName";
            this.labelSectionName.Size = new System.Drawing.Size(136, 22);
            this.labelSectionName.TabIndex = 5;
            this.labelSectionName.Text = "Section  Name ";
            // 
            // FormAddSection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxClassId);
            this.Controls.Add(this.labelClassId);
            this.Controls.Add(this.textBoxSectionName);
            this.Controls.Add(this.labelSectionName);
            this.Name = "FormAddSection";
            this.Text = "FormAddSection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxClassId;
        private System.Windows.Forms.Label labelClassId;
        private System.Windows.Forms.TextBox textBoxSectionName;
        private System.Windows.Forms.Label labelSectionName;
    }
}