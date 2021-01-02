﻿
namespace School_Management_System.View
{
    partial class FormStudent
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
            this.labelPersonalInfo = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxFathersName = new System.Windows.Forms.TextBox();
            this.labelFathersName = new System.Windows.Forms.Label();
            this.textBoxMothersName = new System.Windows.Forms.TextBox();
            this.labelMothersName = new System.Windows.Forms.Label();
            this.textBoxGender = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.labelDateOfBirth = new System.Windows.Forms.Label();
            this.textBoxContact = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxDateOfBirth = new System.Windows.Forms.TextBox();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.richTextBoxAddress = new System.Windows.Forms.RichTextBox();
            this.labelRoll = new System.Windows.Forms.Label();
            this.labelClass = new System.Windows.Forms.Label();
            this.textBoxRoll = new System.Windows.Forms.TextBox();
            this.textBoxClass = new System.Windows.Forms.TextBox();
            this.labelResultInformation = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelSection = new System.Windows.Forms.Label();
            this.textBoxSection = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelPersonalInfo
            // 
            this.labelPersonalInfo.AutoSize = true;
            this.labelPersonalInfo.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPersonalInfo.Location = new System.Drawing.Point(12, 9);
            this.labelPersonalInfo.Name = "labelPersonalInfo";
            this.labelPersonalInfo.Size = new System.Drawing.Size(260, 28);
            this.labelPersonalInfo.TabIndex = 0;
            this.labelPersonalInfo.Text = "Personal Information :";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(102, 55);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(42, 15);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Name";
            this.labelName.Click += new System.EventHandler(this.labelName_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxName.Location = new System.Drawing.Point(168, 52);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.ReadOnly = true;
            this.textBoxName.Size = new System.Drawing.Size(230, 23);
            this.textBoxName.TabIndex = 2;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // textBoxFathersName
            // 
            this.textBoxFathersName.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFathersName.Location = new System.Drawing.Point(168, 168);
            this.textBoxFathersName.Name = "textBoxFathersName";
            this.textBoxFathersName.ReadOnly = true;
            this.textBoxFathersName.Size = new System.Drawing.Size(230, 23);
            this.textBoxFathersName.TabIndex = 4;
            this.textBoxFathersName.TextChanged += new System.EventHandler(this.textBoxFathersName_TextChanged);
            // 
            // labelFathersName
            // 
            this.labelFathersName.AutoSize = true;
            this.labelFathersName.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFathersName.Location = new System.Drawing.Point(51, 171);
            this.labelFathersName.Name = "labelFathersName";
            this.labelFathersName.Size = new System.Drawing.Size(93, 15);
            this.labelFathersName.TabIndex = 3;
            this.labelFathersName.Text = "Father\'s Name";
            this.labelFathersName.Click += new System.EventHandler(this.labelFathersName_Click);
            // 
            // textBoxMothersName
            // 
            this.textBoxMothersName.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMothersName.Location = new System.Drawing.Point(168, 197);
            this.textBoxMothersName.Name = "textBoxMothersName";
            this.textBoxMothersName.ReadOnly = true;
            this.textBoxMothersName.Size = new System.Drawing.Size(230, 23);
            this.textBoxMothersName.TabIndex = 6;
            this.textBoxMothersName.TextChanged += new System.EventHandler(this.textBoxMothersName_TextChanged);
            // 
            // labelMothersName
            // 
            this.labelMothersName.AutoSize = true;
            this.labelMothersName.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMothersName.Location = new System.Drawing.Point(46, 200);
            this.labelMothersName.Name = "labelMothersName";
            this.labelMothersName.Size = new System.Drawing.Size(98, 15);
            this.labelMothersName.TabIndex = 5;
            this.labelMothersName.Text = "Mother\'s Name";
            this.labelMothersName.Click += new System.EventHandler(this.labelMothersName_Click);
            // 
            // textBoxGender
            // 
            this.textBoxGender.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxGender.Location = new System.Drawing.Point(168, 226);
            this.textBoxGender.Name = "textBoxGender";
            this.textBoxGender.ReadOnly = true;
            this.textBoxGender.Size = new System.Drawing.Size(230, 23);
            this.textBoxGender.TabIndex = 8;
            this.textBoxGender.TextChanged += new System.EventHandler(this.textBoxGender_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(93, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Gender";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(168, 255);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(230, 23);
            this.textBox4.TabIndex = 10;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // labelDateOfBirth
            // 
            this.labelDateOfBirth.AutoSize = true;
            this.labelDateOfBirth.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateOfBirth.Location = new System.Drawing.Point(61, 258);
            this.labelDateOfBirth.Name = "labelDateOfBirth";
            this.labelDateOfBirth.Size = new System.Drawing.Size(83, 15);
            this.labelDateOfBirth.TabIndex = 9;
            this.labelDateOfBirth.Text = "Date of birth";
            this.labelDateOfBirth.Click += new System.EventHandler(this.labelDateOfBirth_Click);
            // 
            // textBoxContact
            // 
            this.textBoxContact.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxContact.Location = new System.Drawing.Point(168, 284);
            this.textBoxContact.Name = "textBoxContact";
            this.textBoxContact.ReadOnly = true;
            this.textBoxContact.Size = new System.Drawing.Size(230, 23);
            this.textBoxContact.TabIndex = 12;
            this.textBoxContact.TextChanged += new System.EventHandler(this.textBoxContact_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(88, 287);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Contact";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // textBoxDateOfBirth
            // 
            this.textBoxDateOfBirth.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDateOfBirth.Location = new System.Drawing.Point(168, 313);
            this.textBoxDateOfBirth.Name = "textBoxDateOfBirth";
            this.textBoxDateOfBirth.ReadOnly = true;
            this.textBoxDateOfBirth.Size = new System.Drawing.Size(230, 23);
            this.textBoxDateOfBirth.TabIndex = 14;
            this.textBoxDateOfBirth.TextChanged += new System.EventHandler(this.textBoxDateOfBirth_TextChanged);
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.Location = new System.Drawing.Point(30, 316);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(114, 15);
            this.labelDate.TabIndex = 13;
            this.labelDate.Text = "Date of admission";
            this.labelDate.Click += new System.EventHandler(this.labelDate_Click);
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddress.Location = new System.Drawing.Point(88, 345);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(56, 15);
            this.labelAddress.TabIndex = 15;
            this.labelAddress.Text = "Address";
            this.labelAddress.Click += new System.EventHandler(this.labelAddress_Click);
            // 
            // richTextBoxAddress
            // 
            this.richTextBoxAddress.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxAddress.Location = new System.Drawing.Point(168, 342);
            this.richTextBoxAddress.Name = "richTextBoxAddress";
            this.richTextBoxAddress.ReadOnly = true;
            this.richTextBoxAddress.Size = new System.Drawing.Size(230, 84);
            this.richTextBoxAddress.TabIndex = 16;
            this.richTextBoxAddress.Text = "";
            this.richTextBoxAddress.TextChanged += new System.EventHandler(this.richTextBoxAddress_TextChanged);
            // 
            // labelRoll
            // 
            this.labelRoll.AutoSize = true;
            this.labelRoll.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRoll.Location = new System.Drawing.Point(113, 142);
            this.labelRoll.Name = "labelRoll";
            this.labelRoll.Size = new System.Drawing.Size(31, 15);
            this.labelRoll.TabIndex = 17;
            this.labelRoll.Text = "Roll";
            this.labelRoll.Click += new System.EventHandler(this.labelRoll_Click);
            // 
            // labelClass
            // 
            this.labelClass.AutoSize = true;
            this.labelClass.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClass.Location = new System.Drawing.Point(107, 84);
            this.labelClass.Name = "labelClass";
            this.labelClass.Size = new System.Drawing.Size(37, 15);
            this.labelClass.TabIndex = 18;
            this.labelClass.Text = "Class";
            this.labelClass.Click += new System.EventHandler(this.labelClass_Click);
            // 
            // textBoxRoll
            // 
            this.textBoxRoll.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRoll.Location = new System.Drawing.Point(168, 139);
            this.textBoxRoll.Name = "textBoxRoll";
            this.textBoxRoll.ReadOnly = true;
            this.textBoxRoll.Size = new System.Drawing.Size(230, 23);
            this.textBoxRoll.TabIndex = 19;
            this.textBoxRoll.TextChanged += new System.EventHandler(this.textBoxRoll_TextChanged);
            // 
            // textBoxClass
            // 
            this.textBoxClass.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxClass.Location = new System.Drawing.Point(168, 81);
            this.textBoxClass.Name = "textBoxClass";
            this.textBoxClass.ReadOnly = true;
            this.textBoxClass.Size = new System.Drawing.Size(230, 23);
            this.textBoxClass.TabIndex = 20;
            // 
            // labelResultInformation
            // 
            this.labelResultInformation.AutoSize = true;
            this.labelResultInformation.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResultInformation.Location = new System.Drawing.Point(9, 446);
            this.labelResultInformation.Name = "labelResultInformation";
            this.labelResultInformation.Size = new System.Drawing.Size(233, 28);
            this.labelResultInformation.TabIndex = 21;
            this.labelResultInformation.Text = "Result Information :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(31, 488);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(414, 150);
            this.dataGridView1.TabIndex = 22;
            // 
            // labelSection
            // 
            this.labelSection.AutoSize = true;
            this.labelSection.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSection.Location = new System.Drawing.Point(93, 113);
            this.labelSection.Name = "labelSection";
            this.labelSection.Size = new System.Drawing.Size(51, 15);
            this.labelSection.TabIndex = 23;
            this.labelSection.Text = "Section";
            // 
            // textBoxSection
            // 
            this.textBoxSection.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSection.Location = new System.Drawing.Point(168, 110);
            this.textBoxSection.Name = "textBoxSection";
            this.textBoxSection.ReadOnly = true;
            this.textBoxSection.Size = new System.Drawing.Size(230, 23);
            this.textBoxSection.TabIndex = 24;
            // 
            // FormStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(740, 711);
            this.Controls.Add(this.textBoxSection);
            this.Controls.Add(this.labelSection);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelResultInformation);
            this.Controls.Add(this.textBoxClass);
            this.Controls.Add(this.textBoxRoll);
            this.Controls.Add(this.labelClass);
            this.Controls.Add(this.labelRoll);
            this.Controls.Add(this.richTextBoxAddress);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.textBoxDateOfBirth);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.textBoxContact);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.labelDateOfBirth);
            this.Controls.Add(this.textBoxGender);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxMothersName);
            this.Controls.Add(this.labelMothersName);
            this.Controls.Add(this.textBoxFathersName);
            this.Controls.Add(this.labelFathersName);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelPersonalInfo);
            this.Name = "FormStudent";
            this.Text = "FormStudent";
            this.Load += new System.EventHandler(this.FormStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPersonalInfo;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxFathersName;
        private System.Windows.Forms.Label labelFathersName;
        private System.Windows.Forms.TextBox textBoxMothersName;
        private System.Windows.Forms.Label labelMothersName;
        private System.Windows.Forms.TextBox textBoxGender;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label labelDateOfBirth;
        private System.Windows.Forms.TextBox textBoxContact;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxDateOfBirth;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.RichTextBox richTextBoxAddress;
        private System.Windows.Forms.Label labelRoll;
        private System.Windows.Forms.Label labelClass;
        private System.Windows.Forms.TextBox textBoxRoll;
        private System.Windows.Forms.TextBox textBoxClass;
        private System.Windows.Forms.Label labelResultInformation;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelSection;
        private System.Windows.Forms.TextBox textBoxSection;
    }
}