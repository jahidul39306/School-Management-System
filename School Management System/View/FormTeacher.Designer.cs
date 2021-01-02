
namespace School_Management_System.View
{
    partial class FormTeacher
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
            this.panelT1 = new System.Windows.Forms.Panel();
            this.buttonSResult = new System.Windows.Forms.Button();
            this.buttonViewCSInfo = new System.Windows.Forms.Button();
            this.buttonChangePass = new System.Windows.Forms.Button();
            this.panelChangePass = new System.Windows.Forms.Panel();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.labelUserName = new System.Windows.Forms.Label();
            this.panelCSInfo = new System.Windows.Forms.Panel();
            this.dataGridViewCSInfo = new System.Windows.Forms.DataGridView();
            this.panelSResult = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonAddResult = new System.Windows.Forms.Button();
            this.panelAddResult = new System.Windows.Forms.Panel();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxTMark = new System.Windows.Forms.TextBox();
            this.textBoxOMark = new System.Windows.Forms.TextBox();
            this.labeloMark = new System.Windows.Forms.Label();
            this.labelTMark = new System.Windows.Forms.Label();
            this.comboBoxSSubject = new System.Windows.Forms.ComboBox();
            this.labelSSubject = new System.Windows.Forms.Label();
            this.comboBoxSClass = new System.Windows.Forms.ComboBox();
            this.labelSClass = new System.Windows.Forms.Label();
            this.panelT1.SuspendLayout();
            this.panelChangePass.SuspendLayout();
            this.panelCSInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCSInfo)).BeginInit();
            this.panelSResult.SuspendLayout();
            this.panelAddResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelT1
            // 
            this.panelT1.BackColor = System.Drawing.Color.Blue;
            this.panelT1.Controls.Add(this.buttonSResult);
            this.panelT1.Controls.Add(this.buttonViewCSInfo);
            this.panelT1.Controls.Add(this.buttonChangePass);
            this.panelT1.Location = new System.Drawing.Point(1, -1);
            this.panelT1.Name = "panelT1";
            this.panelT1.Size = new System.Drawing.Size(171, 418);
            this.panelT1.TabIndex = 0;
            // 
            // buttonSResult
            // 
            this.buttonSResult.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonSResult.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSResult.Location = new System.Drawing.Point(0, 181);
            this.buttonSResult.Name = "buttonSResult";
            this.buttonSResult.Size = new System.Drawing.Size(171, 53);
            this.buttonSResult.TabIndex = 3;
            this.buttonSResult.Text = "Student\'s Result";
            this.buttonSResult.UseVisualStyleBackColor = false;
            // 
            // buttonViewCSInfo
            // 
            this.buttonViewCSInfo.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonViewCSInfo.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonViewCSInfo.Location = new System.Drawing.Point(0, 99);
            this.buttonViewCSInfo.Name = "buttonViewCSInfo";
            this.buttonViewCSInfo.Size = new System.Drawing.Size(171, 53);
            this.buttonViewCSInfo.TabIndex = 2;
            this.buttonViewCSInfo.Text = "Course Student\'s Info";
            this.buttonViewCSInfo.UseVisualStyleBackColor = false;
            // 
            // buttonChangePass
            // 
            this.buttonChangePass.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonChangePass.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChangePass.Location = new System.Drawing.Point(0, 264);
            this.buttonChangePass.Name = "buttonChangePass";
            this.buttonChangePass.Size = new System.Drawing.Size(171, 53);
            this.buttonChangePass.TabIndex = 1;
            this.buttonChangePass.Text = "Change Password";
            this.buttonChangePass.UseVisualStyleBackColor = false;
            this.buttonChangePass.Click += new System.EventHandler(this.buttonChangePass_Click);
            // 
            // panelChangePass
            // 
            this.panelChangePass.Controls.Add(this.buttonUpdate);
            this.panelChangePass.Controls.Add(this.textBoxPassword);
            this.panelChangePass.Controls.Add(this.labelPassword);
            this.panelChangePass.Controls.Add(this.textBoxUserName);
            this.panelChangePass.Controls.Add(this.labelUserName);
            this.panelChangePass.Location = new System.Drawing.Point(244, 74);
            this.panelChangePass.Name = "panelChangePass";
            this.panelChangePass.Size = new System.Drawing.Size(428, 278);
            this.panelChangePass.TabIndex = 4;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.IndianRed;
            this.buttonUpdate.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.Location = new System.Drawing.Point(159, 168);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(117, 51);
            this.buttonUpdate.TabIndex = 9;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.Location = new System.Drawing.Point(159, 106);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(201, 32);
            this.textBoxPassword.TabIndex = 8;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.Location = new System.Drawing.Point(22, 109);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(100, 25);
            this.labelPassword.TabIndex = 7;
            this.labelPassword.Text = "Password";
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUserName.Location = new System.Drawing.Point(159, 64);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(201, 32);
            this.textBoxUserName.TabIndex = 6;
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserName.Location = new System.Drawing.Point(22, 67);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(110, 25);
            this.labelUserName.TabIndex = 5;
            this.labelUserName.Text = "User Name";
            // 
            // panelCSInfo
            // 
            this.panelCSInfo.Controls.Add(this.dataGridViewCSInfo);
            this.panelCSInfo.Location = new System.Drawing.Point(178, 65);
            this.panelCSInfo.Name = "panelCSInfo";
            this.panelCSInfo.Size = new System.Drawing.Size(625, 339);
            this.panelCSInfo.TabIndex = 10;
            // 
            // dataGridViewCSInfo
            // 
            this.dataGridViewCSInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCSInfo.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewCSInfo.Name = "dataGridViewCSInfo";
            this.dataGridViewCSInfo.Size = new System.Drawing.Size(622, 283);
            this.dataGridViewCSInfo.TabIndex = 0;
            // 
            // panelSResult
            // 
            this.panelSResult.Controls.Add(this.button1);
            this.panelSResult.Controls.Add(this.buttonAddResult);
            this.panelSResult.Location = new System.Drawing.Point(178, 9);
            this.panelSResult.Name = "panelSResult";
            this.panelSResult.Size = new System.Drawing.Size(581, 405);
            this.panelSResult.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(282, 135);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 105);
            this.button1.TabIndex = 1;
            this.button1.Text = " View/Update Result";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonAddResult
            // 
            this.buttonAddResult.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddResult.Location = new System.Drawing.Point(75, 135);
            this.buttonAddResult.Name = "buttonAddResult";
            this.buttonAddResult.Size = new System.Drawing.Size(166, 105);
            this.buttonAddResult.TabIndex = 0;
            this.buttonAddResult.Text = "Add Result";
            this.buttonAddResult.UseVisualStyleBackColor = true;
            // 
            // panelAddResult
            // 
            this.panelAddResult.Controls.Add(this.buttonAdd);
            this.panelAddResult.Controls.Add(this.textBoxTMark);
            this.panelAddResult.Controls.Add(this.textBoxOMark);
            this.panelAddResult.Controls.Add(this.labeloMark);
            this.panelAddResult.Controls.Add(this.labelTMark);
            this.panelAddResult.Controls.Add(this.comboBoxSSubject);
            this.panelAddResult.Controls.Add(this.labelSSubject);
            this.panelAddResult.Controls.Add(this.comboBoxSClass);
            this.panelAddResult.Controls.Add(this.labelSClass);
            this.panelAddResult.Location = new System.Drawing.Point(178, -1);
            this.panelAddResult.Name = "panelAddResult";
            this.panelAddResult.Size = new System.Drawing.Size(610, 418);
            this.panelAddResult.TabIndex = 1;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(324, 218);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(151, 53);
            this.buttonAdd.TabIndex = 8;
            this.buttonAdd.Text = "ADD";
            this.buttonAdd.UseVisualStyleBackColor = true;
            // 
            // textBoxTMark
            // 
            this.textBoxTMark.Location = new System.Drawing.Point(394, 157);
            this.textBoxTMark.Name = "textBoxTMark";
            this.textBoxTMark.Size = new System.Drawing.Size(100, 20);
            this.textBoxTMark.TabIndex = 7;
            // 
            // textBoxOMark
            // 
            this.textBoxOMark.Location = new System.Drawing.Point(394, 108);
            this.textBoxOMark.Name = "textBoxOMark";
            this.textBoxOMark.Size = new System.Drawing.Size(100, 20);
            this.textBoxOMark.TabIndex = 6;
            // 
            // labeloMark
            // 
            this.labeloMark.AutoSize = true;
            this.labeloMark.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeloMark.Location = new System.Drawing.Point(294, 110);
            this.labeloMark.Name = "labeloMark";
            this.labeloMark.Size = new System.Drawing.Size(83, 15);
            this.labeloMark.TabIndex = 5;
            this.labeloMark.Text = "Obtain Mark";
            // 
            // labelTMark
            // 
            this.labelTMark.AutoSize = true;
            this.labelTMark.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTMark.Location = new System.Drawing.Point(294, 157);
            this.labelTMark.Name = "labelTMark";
            this.labelTMark.Size = new System.Drawing.Size(72, 15);
            this.labelTMark.TabIndex = 4;
            this.labelTMark.Text = "Total Mark";
            // 
            // comboBoxSSubject
            // 
            this.comboBoxSSubject.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSSubject.FormattingEnabled = true;
            this.comboBoxSSubject.Items.AddRange(new object[] {
            "Bangla",
            "English",
            "Math",
            "Islam"});
            this.comboBoxSSubject.Location = new System.Drawing.Point(373, 32);
            this.comboBoxSSubject.Name = "comboBoxSSubject";
            this.comboBoxSSubject.Size = new System.Drawing.Size(121, 23);
            this.comboBoxSSubject.TabIndex = 3;
            // 
            // labelSSubject
            // 
            this.labelSSubject.AutoSize = true;
            this.labelSSubject.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSSubject.Location = new System.Drawing.Point(279, 34);
            this.labelSSubject.Name = "labelSSubject";
            this.labelSSubject.Size = new System.Drawing.Size(91, 15);
            this.labelSSubject.TabIndex = 2;
            this.labelSSubject.Text = "Select Subject";
            // 
            // comboBoxSClass
            // 
            this.comboBoxSClass.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSClass.FormattingEnabled = true;
            this.comboBoxSClass.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBoxSClass.Location = new System.Drawing.Point(124, 29);
            this.comboBoxSClass.Name = "comboBoxSClass";
            this.comboBoxSClass.Size = new System.Drawing.Size(121, 23);
            this.comboBoxSClass.TabIndex = 1;
            // 
            // labelSClass
            // 
            this.labelSClass.AutoSize = true;
            this.labelSClass.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSClass.Location = new System.Drawing.Point(30, 31);
            this.labelSClass.Name = "labelSClass";
            this.labelSClass.Size = new System.Drawing.Size(76, 15);
            this.labelSClass.TabIndex = 0;
            this.labelSClass.Text = "Select Class";
            // 
            // FormTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 416);
            this.Controls.Add(this.panelAddResult);
            this.Controls.Add(this.panelSResult);
            this.Controls.Add(this.panelCSInfo);
            this.Controls.Add(this.panelChangePass);
            this.Controls.Add(this.panelT1);
            this.Name = "FormTeacher";
            this.Text = "FormTeacher";
            this.Load += new System.EventHandler(this.FormTeacher_Load);
            this.panelT1.ResumeLayout(false);
            this.panelChangePass.ResumeLayout(false);
            this.panelChangePass.PerformLayout();
            this.panelCSInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCSInfo)).EndInit();
            this.panelSResult.ResumeLayout(false);
            this.panelAddResult.ResumeLayout(false);
            this.panelAddResult.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelT1;
        private System.Windows.Forms.Button buttonChangePass;
        private System.Windows.Forms.Button buttonSResult;
        private System.Windows.Forms.Button buttonViewCSInfo;
        private System.Windows.Forms.Panel panelChangePass;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Panel panelCSInfo;
        private System.Windows.Forms.DataGridView dataGridViewCSInfo;
        private System.Windows.Forms.Panel panelSResult;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonAddResult;
        private System.Windows.Forms.Panel panelAddResult;
        private System.Windows.Forms.TextBox textBoxOMark;
        private System.Windows.Forms.Label labeloMark;
        private System.Windows.Forms.Label labelTMark;
        private System.Windows.Forms.ComboBox comboBoxSSubject;
        private System.Windows.Forms.Label labelSSubject;
        private System.Windows.Forms.ComboBox comboBoxSClass;
        private System.Windows.Forms.Label labelSClass;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxTMark;
    }
}