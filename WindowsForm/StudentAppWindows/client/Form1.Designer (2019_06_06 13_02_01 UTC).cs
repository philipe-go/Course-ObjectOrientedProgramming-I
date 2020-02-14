namespace StudentAppWindows
{
    partial class Form1
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
            this.labelID = new System.Windows.Forms.Label();
            this.labelLN = new System.Windows.Forms.Label();
            this.labelFN = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxFN = new System.Windows.Forms.TextBox();
            this.textBoxLN = new System.Windows.Forms.TextBox();
            this.buttonADD = new System.Windows.Forms.Button();
            this.listBoxStudent = new System.Windows.Forms.ListBox();
            this.textBoxSt = new System.Windows.Forms.TextBox();
            this.address = new System.Windows.Forms.Label();
            this.textBoxMterm = new System.Windows.Forms.TextBox();
            this.midtermScore = new System.Windows.Forms.Label();
            this.textBoxProject = new System.Windows.Forms.TextBox();
            this.projectScore = new System.Windows.Forms.Label();
            this.textBoxFinterm = new System.Windows.Forms.TextBox();
            this.finaltermScore = new System.Windows.Forms.Label();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.textBoxProvince = new System.Windows.Forms.TextBox();
            this.textBoxZip = new System.Windows.Forms.TextBox();
            this.buttonCLEAR = new System.Windows.Forms.Button();
            this.buttonSHOW = new System.Windows.Forms.Button();
            this.buttonDELETE = new System.Windows.Forms.Button();
            this.buttonEXIT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelID.Location = new System.Drawing.Point(165, 33);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(61, 13);
            this.labelID.TabIndex = 0;
            this.labelID.Text = "Student ID:";
            this.labelID.UseMnemonic = false;
            // 
            // labelLN
            // 
            this.labelLN.AutoSize = true;
            this.labelLN.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelLN.Location = new System.Drawing.Point(165, 83);
            this.labelLN.Name = "labelLN";
            this.labelLN.Size = new System.Drawing.Size(101, 13);
            this.labelLN.TabIndex = 2;
            this.labelLN.Text = "Student Last Name:";
            this.labelLN.UseMnemonic = false;
            // 
            // labelFN
            // 
            this.labelFN.AutoSize = true;
            this.labelFN.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelFN.Location = new System.Drawing.Point(165, 58);
            this.labelFN.Name = "labelFN";
            this.labelFN.Size = new System.Drawing.Size(100, 13);
            this.labelFN.TabIndex = 1;
            this.labelFN.Text = "Student First Name:";
            this.labelFN.UseMnemonic = false;
            // 
            // textBoxID
            // 
            this.textBoxID.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBoxID.Location = new System.Drawing.Point(320, 29);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(346, 20);
            this.textBoxID.TabIndex = 3;
            this.textBoxID.Text = "0000";
            // 
            // textBoxFN
            // 
            this.textBoxFN.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBoxFN.Location = new System.Drawing.Point(320, 52);
            this.textBoxFN.Name = "textBoxFN";
            this.textBoxFN.Size = new System.Drawing.Size(346, 20);
            this.textBoxFN.TabIndex = 4;
            this.textBoxFN.Text = "default";
            // 
            // textBoxLN
            // 
            this.textBoxLN.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBoxLN.Location = new System.Drawing.Point(320, 76);
            this.textBoxLN.Name = "textBoxLN";
            this.textBoxLN.Size = new System.Drawing.Size(346, 20);
            this.textBoxLN.TabIndex = 5;
            this.textBoxLN.Text = "default";
            // 
            // buttonADD
            // 
            this.buttonADD.Location = new System.Drawing.Point(114, 235);
            this.buttonADD.Name = "buttonADD";
            this.buttonADD.Size = new System.Drawing.Size(125, 29);
            this.buttonADD.TabIndex = 13;
            this.buttonADD.Text = "ADD";
            this.buttonADD.UseVisualStyleBackColor = true;
            this.buttonADD.Click += new System.EventHandler(this.ButtonADD_Click);
            // 
            // listBoxStudent
            // 
            this.listBoxStudent.FormattingEnabled = true;
            this.listBoxStudent.Location = new System.Drawing.Point(16, 287);
            this.listBoxStudent.Name = "listBoxStudent";
            this.listBoxStudent.Size = new System.Drawing.Size(776, 134);
            this.listBoxStudent.TabIndex = 18;
            this.listBoxStudent.SelectedIndexChanged += new System.EventHandler(this.listBoxStudent_SelectedIndexChanged_1);
            // 
            // textBoxSt
            // 
            this.textBoxSt.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBoxSt.Location = new System.Drawing.Point(320, 101);
            this.textBoxSt.Name = "textBoxSt";
            this.textBoxSt.Size = new System.Drawing.Size(148, 20);
            this.textBoxSt.TabIndex = 6;
            this.textBoxSt.Text = "street";
            // 
            // address
            // 
            this.address.AutoSize = true;
            this.address.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.address.Location = new System.Drawing.Point(165, 107);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(88, 13);
            this.address.TabIndex = 19;
            this.address.Text = "Student Address:";
            this.address.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.address.UseMnemonic = false;
            // 
            // textBoxMterm
            // 
            this.textBoxMterm.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBoxMterm.Location = new System.Drawing.Point(320, 125);
            this.textBoxMterm.Name = "textBoxMterm";
            this.textBoxMterm.Size = new System.Drawing.Size(148, 20);
            this.textBoxMterm.TabIndex = 10;
            this.textBoxMterm.Text = "0.00";
            // 
            // midtermScore
            // 
            this.midtermScore.AutoSize = true;
            this.midtermScore.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.midtermScore.Location = new System.Drawing.Point(165, 132);
            this.midtermScore.Name = "midtermScore";
            this.midtermScore.Size = new System.Drawing.Size(85, 13);
            this.midtermScore.TabIndex = 20;
            this.midtermScore.Text = "Mid Term Score:";
            this.midtermScore.UseMnemonic = false;
            // 
            // textBoxProject
            // 
            this.textBoxProject.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBoxProject.Location = new System.Drawing.Point(320, 150);
            this.textBoxProject.Name = "textBoxProject";
            this.textBoxProject.Size = new System.Drawing.Size(148, 20);
            this.textBoxProject.TabIndex = 11;
            this.textBoxProject.Text = "0.00";
            // 
            // projectScore
            // 
            this.projectScore.AutoSize = true;
            this.projectScore.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.projectScore.Location = new System.Drawing.Point(165, 156);
            this.projectScore.Name = "projectScore";
            this.projectScore.Size = new System.Drawing.Size(74, 13);
            this.projectScore.TabIndex = 21;
            this.projectScore.Text = "Project Score:";
            this.projectScore.UseMnemonic = false;
            // 
            // textBoxFinterm
            // 
            this.textBoxFinterm.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBoxFinterm.Location = new System.Drawing.Point(320, 174);
            this.textBoxFinterm.Name = "textBoxFinterm";
            this.textBoxFinterm.Size = new System.Drawing.Size(148, 20);
            this.textBoxFinterm.TabIndex = 12;
            this.textBoxFinterm.Text = "0.00";
            // 
            // finaltermScore
            // 
            this.finaltermScore.AutoSize = true;
            this.finaltermScore.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.finaltermScore.Location = new System.Drawing.Point(165, 180);
            this.finaltermScore.Name = "finaltermScore";
            this.finaltermScore.Size = new System.Drawing.Size(90, 13);
            this.finaltermScore.TabIndex = 22;
            this.finaltermScore.Text = "Final Term Score:";
            this.finaltermScore.UseMnemonic = false;
            // 
            // textBoxCity
            // 
            this.textBoxCity.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBoxCity.Location = new System.Drawing.Point(473, 101);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(61, 20);
            this.textBoxCity.TabIndex = 7;
            this.textBoxCity.Text = "city";
            // 
            // textBoxProvince
            // 
            this.textBoxProvince.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBoxProvince.Location = new System.Drawing.Point(539, 101);
            this.textBoxProvince.Name = "textBoxProvince";
            this.textBoxProvince.Size = new System.Drawing.Size(61, 20);
            this.textBoxProvince.TabIndex = 8;
            this.textBoxProvince.Text = "province";
            // 
            // textBoxZip
            // 
            this.textBoxZip.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBoxZip.Location = new System.Drawing.Point(605, 101);
            this.textBoxZip.Name = "textBoxZip";
            this.textBoxZip.Size = new System.Drawing.Size(61, 20);
            this.textBoxZip.TabIndex = 9;
            this.textBoxZip.Text = "zip";
            // 
            // buttonCLEAR
            // 
            this.buttonCLEAR.Location = new System.Drawing.Point(249, 235);
            this.buttonCLEAR.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCLEAR.Name = "buttonCLEAR";
            this.buttonCLEAR.Size = new System.Drawing.Size(125, 29);
            this.buttonCLEAR.TabIndex = 14;
            this.buttonCLEAR.Text = "CLEAR";
            this.buttonCLEAR.UseVisualStyleBackColor = true;
            this.buttonCLEAR.Click += new System.EventHandler(this.buttonCLEAR_Click_1);
            // 
            // buttonSHOW
            // 
            this.buttonSHOW.Location = new System.Drawing.Point(380, 235);
            this.buttonSHOW.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSHOW.Name = "buttonSHOW";
            this.buttonSHOW.Size = new System.Drawing.Size(125, 29);
            this.buttonSHOW.TabIndex = 15;
            this.buttonSHOW.Text = "SHOWLIST";
            this.buttonSHOW.UseVisualStyleBackColor = true;
            this.buttonSHOW.Click += new System.EventHandler(this.buttonSHOW_Click_1);
            // 
            // buttonDELETE
            // 
            this.buttonDELETE.Location = new System.Drawing.Point(538, 235);
            this.buttonDELETE.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDELETE.Name = "buttonDELETE";
            this.buttonDELETE.Size = new System.Drawing.Size(125, 29);
            this.buttonDELETE.TabIndex = 23;
            this.buttonDELETE.Text = "DELETE";
            this.buttonDELETE.UseVisualStyleBackColor = true;
            this.buttonDELETE.Click += new System.EventHandler(this.buttonDELETE_Click_1);
            // 
            // buttonEXIT
            // 
            this.buttonEXIT.Location = new System.Drawing.Point(661, 235);
            this.buttonEXIT.Margin = new System.Windows.Forms.Padding(2);
            this.buttonEXIT.Name = "buttonEXIT";
            this.buttonEXIT.Size = new System.Drawing.Size(125, 29);
            this.buttonEXIT.TabIndex = 24;
            this.buttonEXIT.Text = "EXIT";
            this.buttonEXIT.UseVisualStyleBackColor = true;
            this.buttonEXIT.Click += new System.EventHandler(this.buttonEXIT_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(812, 450);
            this.Controls.Add(this.buttonEXIT);
            this.Controls.Add(this.buttonDELETE);
            this.Controls.Add(this.buttonSHOW);
            this.Controls.Add(this.buttonCLEAR);
            this.Controls.Add(this.textBoxZip);
            this.Controls.Add(this.textBoxProvince);
            this.Controls.Add(this.textBoxCity);
            this.Controls.Add(this.textBoxFinterm);
            this.Controls.Add(this.finaltermScore);
            this.Controls.Add(this.textBoxProject);
            this.Controls.Add(this.projectScore);
            this.Controls.Add(this.textBoxMterm);
            this.Controls.Add(this.midtermScore);
            this.Controls.Add(this.textBoxSt);
            this.Controls.Add(this.address);
            this.Controls.Add(this.listBoxStudent);
            this.Controls.Add(this.buttonADD);
            this.Controls.Add(this.textBoxLN);
            this.Controls.Add(this.textBoxFN);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.labelFN);
            this.Controls.Add(this.labelLN);
            this.Controls.Add(this.labelID);
            this.Name = "Form1";
            this.Text = "StudentApp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelLN;
        private System.Windows.Forms.Label labelFN;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxFN;
        private System.Windows.Forms.TextBox textBoxLN;
        private System.Windows.Forms.Button buttonADD;
        private System.Windows.Forms.ListBox listBoxStudent;
        private System.Windows.Forms.TextBox textBoxSt;
        private System.Windows.Forms.Label address;
        private System.Windows.Forms.TextBox textBoxMterm;
        private System.Windows.Forms.Label midtermScore;
        private System.Windows.Forms.TextBox textBoxProject;
        private System.Windows.Forms.Label projectScore;
        private System.Windows.Forms.TextBox textBoxFinterm;
        private System.Windows.Forms.Label finaltermScore;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.TextBox textBoxProvince;
        private System.Windows.Forms.TextBox textBoxZip;
        private System.Windows.Forms.Button buttonCLEAR;
        private System.Windows.Forms.Button buttonSHOW;
        private System.Windows.Forms.Button buttonDELETE;
        private System.Windows.Forms.Button buttonEXIT;
    }
}

