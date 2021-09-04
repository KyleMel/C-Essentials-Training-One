
namespace SchoolFormsApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelName = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelCity = new System.Windows.Forms.Label();
            this.labelState = new System.Windows.Forms.Label();
            this.labelZip = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.textAddress = new System.Windows.Forms.TextBox();
            this.textCity = new System.Windows.Forms.TextBox();
            this.textZip = new System.Windows.Forms.TextBox();
            this.textState = new System.Windows.Forms.TextBox();
            this.textPhone = new System.Windows.Forms.TextBox();
            this.textTwitter = new System.Windows.Forms.TextBox();
            this.labelTwitter = new System.Windows.Forms.Label();
            this.btnPushToTest = new System.Windows.Forms.Button();
            this.BtnTestTeacher = new System.Windows.Forms.Button();
            this.BtnTestStudent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(129, 82);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(175, 37);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "School Name";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(193, 194);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(111, 37);
            this.labelAddress.TabIndex = 1;
            this.labelAddress.Text = "Address";
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Location = new System.Drawing.Point(241, 301);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(63, 37);
            this.labelCity.TabIndex = 2;
            this.labelCity.Text = "City";
            // 
            // labelState
            // 
            this.labelState.AutoSize = true;
            this.labelState.Location = new System.Drawing.Point(234, 409);
            this.labelState.Name = "labelState";
            this.labelState.Size = new System.Drawing.Size(76, 37);
            this.labelState.TabIndex = 3;
            this.labelState.Text = "State";
            // 
            // labelZip
            // 
            this.labelZip.AutoSize = true;
            this.labelZip.Location = new System.Drawing.Point(249, 527);
            this.labelZip.Name = "labelZip";
            this.labelZip.Size = new System.Drawing.Size(55, 37);
            this.labelZip.TabIndex = 4;
            this.labelZip.Text = "Zip";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(218, 627);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(92, 37);
            this.labelPhone.TabIndex = 5;
            this.labelPhone.Text = "Phone";
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(325, 82);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(225, 43);
            this.textName.TabIndex = 6;
            // 
            // textAddress
            // 
            this.textAddress.Location = new System.Drawing.Point(325, 194);
            this.textAddress.Name = "textAddress";
            this.textAddress.Size = new System.Drawing.Size(225, 43);
            this.textAddress.TabIndex = 7;
            // 
            // textCity
            // 
            this.textCity.Location = new System.Drawing.Point(325, 301);
            this.textCity.Name = "textCity";
            this.textCity.Size = new System.Drawing.Size(225, 43);
            this.textCity.TabIndex = 8;
            // 
            // textZip
            // 
            this.textZip.Location = new System.Drawing.Point(325, 527);
            this.textZip.Name = "textZip";
            this.textZip.Size = new System.Drawing.Size(225, 43);
            this.textZip.TabIndex = 9;
            // 
            // textState
            // 
            this.textState.Location = new System.Drawing.Point(325, 409);
            this.textState.Name = "textState";
            this.textState.Size = new System.Drawing.Size(225, 43);
            this.textState.TabIndex = 10;
            // 
            // textPhone
            // 
            this.textPhone.Location = new System.Drawing.Point(325, 627);
            this.textPhone.Name = "textPhone";
            this.textPhone.Size = new System.Drawing.Size(225, 43);
            this.textPhone.TabIndex = 11;
            // 
            // textTwitter
            // 
            this.textTwitter.Location = new System.Drawing.Point(325, 734);
            this.textTwitter.Name = "textTwitter";
            this.textTwitter.Size = new System.Drawing.Size(225, 43);
            this.textTwitter.TabIndex = 12;
            this.textTwitter.TextChanged += new System.EventHandler(this.TextBox7_TextChanged);
            // 
            // labelTwitter
            // 
            this.labelTwitter.AutoSize = true;
            this.labelTwitter.Location = new System.Drawing.Point(212, 734);
            this.labelTwitter.Name = "labelTwitter";
            this.labelTwitter.Size = new System.Drawing.Size(98, 37);
            this.labelTwitter.TabIndex = 13;
            this.labelTwitter.Text = "Twitter";
            // 
            // btnPushToTest
            // 
            this.btnPushToTest.Location = new System.Drawing.Point(282, 810);
            this.btnPushToTest.Name = "btnPushToTest";
            this.btnPushToTest.Size = new System.Drawing.Size(299, 52);
            this.btnPushToTest.TabIndex = 14;
            this.btnPushToTest.Text = "Test";
            this.btnPushToTest.UseVisualStyleBackColor = true;
            this.btnPushToTest.Click += new System.EventHandler(this.BtnPushToTest_Click);
            // 
            // BtnTestTeacher
            // 
            this.BtnTestTeacher.Location = new System.Drawing.Point(348, 877);
            this.BtnTestTeacher.Name = "BtnTestTeacher";
            this.BtnTestTeacher.Size = new System.Drawing.Size(169, 52);
            this.BtnTestTeacher.TabIndex = 15;
            this.BtnTestTeacher.Text = "Test Teacher";
            this.BtnTestTeacher.UseVisualStyleBackColor = true;
            this.BtnTestTeacher.Click += new System.EventHandler(this.BtnTestTeacher_Click);
            // 
            // BtnTestStudent
            // 
            this.BtnTestStudent.Location = new System.Drawing.Point(348, 947);
            this.BtnTestStudent.Name = "BtnTestStudent";
            this.BtnTestStudent.Size = new System.Drawing.Size(169, 52);
            this.BtnTestStudent.TabIndex = 16;
            this.BtnTestStudent.Text = "Test Student";
            this.BtnTestStudent.UseVisualStyleBackColor = true;
            this.BtnTestStudent.Click += new System.EventHandler(this.BtnTestStudent_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 1030);
            this.Controls.Add(this.BtnTestStudent);
            this.Controls.Add(this.BtnTestTeacher);
            this.Controls.Add(this.btnPushToTest);
            this.Controls.Add(this.labelTwitter);
            this.Controls.Add(this.textTwitter);
            this.Controls.Add(this.textPhone);
            this.Controls.Add(this.textState);
            this.Controls.Add(this.textZip);
            this.Controls.Add(this.textCity);
            this.Controls.Add(this.textAddress);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.labelZip);
            this.Controls.Add(this.labelState);
            this.Controls.Add(this.labelCity);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.labelName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.Label labelState;
        private System.Windows.Forms.Label labelZip;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textAddress;
        private System.Windows.Forms.TextBox textCity;
        private System.Windows.Forms.TextBox textZip;
        private System.Windows.Forms.TextBox textState;
        private System.Windows.Forms.TextBox textPhone;
        private System.Windows.Forms.TextBox textTwitter;
        private System.Windows.Forms.Label labelTwitter;
        private System.Windows.Forms.Button btnPushToTest;
        private System.Windows.Forms.Button BtnTestTeacher;
        private System.Windows.Forms.Button BtnTestStudent;
    }
}

