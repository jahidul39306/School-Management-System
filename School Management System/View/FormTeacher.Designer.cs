
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
            this.buttonChangePass = new System.Windows.Forms.Button();
            this.buttonViewCSInfo = new System.Windows.Forms.Button();
            this.buttonSResult = new System.Windows.Forms.Button();
            this.panelChangePass = new System.Windows.Forms.Panel();
            this.labelUserName = new System.Windows.Forms.Label();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.panelCSInfo = new System.Windows.Forms.Panel();
            this.dataGridViewCSInfo = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonAddResult = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panelT1.SuspendLayout();
            this.panelChangePass.SuspendLayout();
            this.panelCSInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCSInfo)).BeginInit();
            this.panel1.SuspendLayout();
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
            // textBoxUserName
            // 
            this.textBoxUserName.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUserName.Location = new System.Drawing.Point(159, 64);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(201, 32);
            this.textBoxUserName.TabIndex = 6;
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
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.Location = new System.Drawing.Point(159, 106);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(201, 32);
            this.textBoxPassword.TabIndex = 8;
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
            // panelCSInfo
            // 
            this.panelCSInfo.Controls.Add(this.dataGridViewCSInfo);
            this.panelCSInfo.Location = new System.Drawing.Point(207, 37);
            this.panelCSInfo.Name = "panelCSInfo";
            this.panelCSInfo.Size = new System.Drawing.Size(540, 339);
            this.panelCSInfo.TabIndex = 10;
            // 
            // dataGridViewCSInfo
            // 
            this.dataGridViewCSInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCSInfo.Location = new System.Drawing.Point(0, 67);
            this.dataGridViewCSInfo.Name = "dataGridViewCSInfo";
            this.dataGridViewCSInfo.Size = new System.Drawing.Size(538, 288);
            this.dataGridViewCSInfo.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.buttonAddResult);
            this.panel1.Location = new System.Drawing.Point(196, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(581, 405);
            this.panel1.TabIndex = 1;
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
            // FormTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 416);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelCSInfo);
            this.Controls.Add(this.panelChangePass);
            this.Controls.Add(this.panelT1);
            this.Name = "FormTeacher";
            this.Text = "FormTeacher";
            this.panelT1.ResumeLayout(false);
            this.panelChangePass.ResumeLayout(false);
            this.panelChangePass.PerformLayout();
            this.panelCSInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCSInfo)).EndInit();
            this.panel1.ResumeLayout(false);
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonAddResult;
    }
}