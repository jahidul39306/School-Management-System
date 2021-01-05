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
            this.textBoxSecName = new System.Windows.Forms.TextBox();
            this.labelSection = new System.Windows.Forms.Label();
            this.labelCId = new System.Windows.Forms.Label();
            this.comboBoxClaasId = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(519, 288);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(149, 55);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxSecName
            // 
            this.textBoxSecName.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSecName.Location = new System.Drawing.Point(312, 87);
            this.textBoxSecName.Name = "textBoxSecName";
            this.textBoxSecName.Size = new System.Drawing.Size(187, 31);
            this.textBoxSecName.TabIndex = 1;
            // 
            // labelSection
            // 
            this.labelSection.AutoSize = true;
            this.labelSection.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSection.Location = new System.Drawing.Point(172, 90);
            this.labelSection.Name = "labelSection";
            this.labelSection.Size = new System.Drawing.Size(134, 23);
            this.labelSection.TabIndex = 3;
            this.labelSection.Text = "Section Name:";
            // 
            // labelCId
            // 
            this.labelCId.AutoSize = true;
            this.labelCId.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCId.Location = new System.Drawing.Point(224, 166);
            this.labelCId.Name = "labelCId";
            this.labelCId.Size = new System.Drawing.Size(82, 23);
            this.labelCId.TabIndex = 4;
            this.labelCId.Text = "Class ID:";
            // 
            // comboBoxClaasId
            // 
            this.comboBoxClaasId.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxClaasId.FormattingEnabled = true;
            this.comboBoxClaasId.Location = new System.Drawing.Point(312, 166);
            this.comboBoxClaasId.Name = "comboBoxClaasId";
            this.comboBoxClaasId.Size = new System.Drawing.Size(187, 31);
            this.comboBoxClaasId.TabIndex = 5;
            this.comboBoxClaasId.SelectedIndexChanged += new System.EventHandler(this.comboBoxClaasId_SelectedIndexChanged);
            // 
            // FormAddSection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBoxClaasId);
            this.Controls.Add(this.labelCId);
            this.Controls.Add(this.labelSection);
            this.Controls.Add(this.textBoxSecName);
            this.Controls.Add(this.buttonAdd);
            this.Name = "FormAddSection";
            this.Text = "FormAddSection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxSecName;
        private System.Windows.Forms.Label labelSection;
        private System.Windows.Forms.Label labelCId;
        private System.Windows.Forms.ComboBox comboBoxClaasId;
    }
}