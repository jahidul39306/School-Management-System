
namespace School_Management_System.View
{
    partial class FormUpdateSections
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
            this.textBoxSecId = new System.Windows.Forms.TextBox();
            this.labelSectionId = new System.Windows.Forms.Label();
            this.textBoxSecName = new System.Windows.Forms.TextBox();
            this.textBoxCId = new System.Windows.Forms.TextBox();
            this.labelCId = new System.Windows.Forms.Label();
            this.labelSecName = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxSecId
            // 
            this.textBoxSecId.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSecId.Location = new System.Drawing.Point(286, 90);
            this.textBoxSecId.Name = "textBoxSecId";
            this.textBoxSecId.Size = new System.Drawing.Size(187, 31);
            this.textBoxSecId.TabIndex = 2;
            // 
            // labelSectionId
            // 
            this.labelSectionId.AutoSize = true;
            this.labelSectionId.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSectionId.Location = new System.Drawing.Point(180, 93);
            this.labelSectionId.Name = "labelSectionId";
            this.labelSectionId.Size = new System.Drawing.Size(100, 23);
            this.labelSectionId.TabIndex = 4;
            this.labelSectionId.Text = "Section Id:";
            // 
            // textBoxSecName
            // 
            this.textBoxSecName.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSecName.Location = new System.Drawing.Point(286, 175);
            this.textBoxSecName.Name = "textBoxSecName";
            this.textBoxSecName.Size = new System.Drawing.Size(187, 31);
            this.textBoxSecName.TabIndex = 5;
            // 
            // textBoxCId
            // 
            this.textBoxCId.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCId.Location = new System.Drawing.Point(286, 234);
            this.textBoxCId.Name = "textBoxCId";
            this.textBoxCId.Size = new System.Drawing.Size(187, 31);
            this.textBoxCId.TabIndex = 6;
            // 
            // labelCId
            // 
            this.labelCId.AutoSize = true;
            this.labelCId.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCId.Location = new System.Drawing.Point(200, 242);
            this.labelCId.Name = "labelCId";
            this.labelCId.Size = new System.Drawing.Size(80, 23);
            this.labelCId.TabIndex = 7;
            this.labelCId.Text = "Class Id:";
            // 
            // labelSecName
            // 
            this.labelSecName.AutoSize = true;
            this.labelSecName.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSecName.Location = new System.Drawing.Point(146, 178);
            this.labelSecName.Name = "labelSecName";
            this.labelSecName.Size = new System.Drawing.Size(134, 23);
            this.labelSecName.TabIndex = 8;
            this.labelSecName.Text = "Section Name:";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.Location = new System.Drawing.Point(527, 83);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(111, 43);
            this.buttonSearch.TabIndex = 9;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.Red;
            this.buttonDelete.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.ForeColor = System.Drawing.Color.Snow;
            this.buttonDelete.Location = new System.Drawing.Point(620, 310);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(111, 43);
            this.buttonDelete.TabIndex = 10;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.Location = new System.Drawing.Point(466, 310);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(111, 43);
            this.buttonUpdate.TabIndex = 11;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // FormUpdateSections
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.labelSecName);
            this.Controls.Add(this.labelCId);
            this.Controls.Add(this.textBoxCId);
            this.Controls.Add(this.textBoxSecName);
            this.Controls.Add(this.labelSectionId);
            this.Controls.Add(this.textBoxSecId);
            this.Name = "FormUpdateSections";
            this.Text = "FormUpdateSections";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSecId;
        private System.Windows.Forms.Label labelSectionId;
        private System.Windows.Forms.TextBox textBoxSecName;
        private System.Windows.Forms.TextBox textBoxCId;
        private System.Windows.Forms.Label labelCId;
        private System.Windows.Forms.Label labelSecName;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonUpdate;
    }
}