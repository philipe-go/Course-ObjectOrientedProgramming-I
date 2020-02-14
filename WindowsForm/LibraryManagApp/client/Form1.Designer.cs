//created by Philipe Gouveia @ june 13th, 2019
//library management application

namespace LibraryManagApp
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
            this.lblbookID = new System.Windows.Forms.Label();
            this.lblbookTitle = new System.Windows.Forms.Label();
            this.lblbookAuthor = new System.Windows.Forms.Label();
            this.lblbookISBN = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.textBoxAuthor = new System.Windows.Forms.TextBox();
            this.textBoxISBN = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDisplay = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonUpdt = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.listBoxBooks = new System.Windows.Forms.ListBox();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.labelEdition = new System.Windows.Forms.Label();
            this.textBoxEditionDay = new System.Windows.Forms.TextBox();
            this.textBoxEditionYear = new System.Windows.Forms.TextBox();
            this.textBoxEditionMonth = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblbookID
            // 
            this.lblbookID.AutoSize = true;
            this.lblbookID.Location = new System.Drawing.Point(152, 9);
            this.lblbookID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblbookID.Name = "lblbookID";
            this.lblbookID.Size = new System.Drawing.Size(49, 13);
            this.lblbookID.TabIndex = 0;
            this.lblbookID.Text = "Book ID:";
            // 
            // lblbookTitle
            // 
            this.lblbookTitle.AutoSize = true;
            this.lblbookTitle.Location = new System.Drawing.Point(152, 40);
            this.lblbookTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblbookTitle.Name = "lblbookTitle";
            this.lblbookTitle.Size = new System.Drawing.Size(58, 13);
            this.lblbookTitle.TabIndex = 1;
            this.lblbookTitle.Text = "Book Title:";
            // 
            // lblbookAuthor
            // 
            this.lblbookAuthor.AutoSize = true;
            this.lblbookAuthor.Location = new System.Drawing.Point(152, 69);
            this.lblbookAuthor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblbookAuthor.Name = "lblbookAuthor";
            this.lblbookAuthor.Size = new System.Drawing.Size(69, 13);
            this.lblbookAuthor.TabIndex = 2;
            this.lblbookAuthor.Text = "Book Author:";
            // 
            // lblbookISBN
            // 
            this.lblbookISBN.AutoSize = true;
            this.lblbookISBN.Location = new System.Drawing.Point(152, 100);
            this.lblbookISBN.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblbookISBN.Name = "lblbookISBN";
            this.lblbookISBN.Size = new System.Drawing.Size(63, 13);
            this.lblbookISBN.TabIndex = 3;
            this.lblbookISBN.Text = "Book ISBN:";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(241, 5);
            this.textBoxID.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(218, 20);
            this.textBoxID.TabIndex = 4;
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(241, 37);
            this.textBoxTitle.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(218, 20);
            this.textBoxTitle.TabIndex = 5;
            // 
            // textBoxAuthor
            // 
            this.textBoxAuthor.Location = new System.Drawing.Point(242, 67);
            this.textBoxAuthor.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxAuthor.Name = "textBoxAuthor";
            this.textBoxAuthor.Size = new System.Drawing.Size(218, 20);
            this.textBoxAuthor.TabIndex = 6;
            // 
            // textBoxISBN
            // 
            this.textBoxISBN.Location = new System.Drawing.Point(241, 97);
            this.textBoxISBN.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxISBN.Name = "textBoxISBN";
            this.textBoxISBN.Size = new System.Drawing.Size(218, 20);
            this.textBoxISBN.TabIndex = 7;
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(48, 159);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(45, 37);
            this.buttonAdd.TabIndex = 11;
            this.buttonAdd.Text = "ADD";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // buttonDisplay
            // 
            this.buttonDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDisplay.Location = new System.Drawing.Point(112, 159);
            this.buttonDisplay.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDisplay.Name = "buttonDisplay";
            this.buttonDisplay.Size = new System.Drawing.Size(45, 37);
            this.buttonDisplay.TabIndex = 20;
            this.buttonDisplay.Text = "SHOW";
            this.buttonDisplay.UseVisualStyleBackColor = false;
            this.buttonDisplay.Click += new System.EventHandler(this.ButtonDisplay_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRefresh.Location = new System.Drawing.Point(181, 159);
            this.buttonRefresh.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(45, 37);
            this.buttonRefresh.TabIndex = 21;
            this.buttonRefresh.Text = "CLEAR";
            this.buttonRefresh.UseVisualStyleBackColor = false;
            this.buttonRefresh.Click += new System.EventHandler(this.ButtonRefresh_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDel.Location = new System.Drawing.Point(251, 159);
            this.buttonDel.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(45, 37);
            this.buttonDel.TabIndex = 22;
            this.buttonDel.Text = "DELETE";
            this.buttonDel.UseVisualStyleBackColor = false;
            this.buttonDel.Click += new System.EventHandler(this.ButtonDel_Click);
            // 
            // buttonUpdt
            // 
            this.buttonUpdt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonUpdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdt.Location = new System.Drawing.Point(326, 159);
            this.buttonUpdt.Margin = new System.Windows.Forms.Padding(2);
            this.buttonUpdt.Name = "buttonUpdt";
            this.buttonUpdt.Size = new System.Drawing.Size(45, 37);
            this.buttonUpdt.TabIndex = 23;
            this.buttonUpdt.Text = "UPDATE";
            this.buttonUpdt.UseVisualStyleBackColor = false;
            this.buttonUpdt.Click += new System.EventHandler(this.ButtonUpdt_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.Location = new System.Drawing.Point(394, 159);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(48, 37);
            this.buttonSearch.TabIndex = 24;
            this.buttonSearch.Text = "SEARCH ID";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.Location = new System.Drawing.Point(544, 5);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(2);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(45, 37);
            this.buttonExit.TabIndex = 14;
            this.buttonExit.Text = "EXIT";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // listBoxBooks
            // 
            this.listBoxBooks.BackColor = System.Drawing.Color.White;
            this.listBoxBooks.FormattingEnabled = true;
            this.listBoxBooks.Location = new System.Drawing.Point(48, 201);
            this.listBoxBooks.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxBooks.Name = "listBoxBooks";
            this.listBoxBooks.Size = new System.Drawing.Size(501, 147);
            this.listBoxBooks.TabIndex = 15;
            this.listBoxBooks.SelectedIndexChanged += new System.EventHandler(this.ListBoxBooks_SelectedIndexChanged);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(454, 168);
            this.textBoxSearch.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(95, 20);
            this.textBoxSearch.TabIndex = 16;
            // 
            // labelEdition
            // 
            this.labelEdition.AutoSize = true;
            this.labelEdition.Location = new System.Drawing.Point(152, 131);
            this.labelEdition.Name = "labelEdition";
            this.labelEdition.Size = new System.Drawing.Size(42, 13);
            this.labelEdition.TabIndex = 17;
            this.labelEdition.Text = "Edition:";
            // 
            // textBoxEditionDay
            // 
            this.textBoxEditionDay.Location = new System.Drawing.Point(241, 124);
            this.textBoxEditionDay.Name = "textBoxEditionDay";
            this.textBoxEditionDay.Size = new System.Drawing.Size(70, 20);
            this.textBoxEditionDay.TabIndex = 8;
            // 
            // textBoxEditionYear
            // 
            this.textBoxEditionYear.Location = new System.Drawing.Point(390, 124);
            this.textBoxEditionYear.Name = "textBoxEditionYear";
            this.textBoxEditionYear.Size = new System.Drawing.Size(70, 20);
            this.textBoxEditionYear.TabIndex = 10;
            // 
            // textBoxEditionMonth
            // 
            this.textBoxEditionMonth.Location = new System.Drawing.Point(313, 124);
            this.textBoxEditionMonth.Name = "textBoxEditionMonth";
            this.textBoxEditionMonth.Size = new System.Drawing.Size(74, 20);
            this.textBoxEditionMonth.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.textBoxEditionMonth);
            this.Controls.Add(this.textBoxEditionYear);
            this.Controls.Add(this.textBoxEditionDay);
            this.Controls.Add(this.labelEdition);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.listBoxBooks);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonUpdt);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.buttonDisplay);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxISBN);
            this.Controls.Add(this.textBoxAuthor);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.lblbookISBN);
            this.Controls.Add(this.lblbookAuthor);
            this.Controls.Add(this.lblbookTitle);
            this.Controls.Add(this.lblbookID);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Library Management Application";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblbookID;
        private System.Windows.Forms.Label lblbookTitle;
        private System.Windows.Forms.Label lblbookAuthor;
        private System.Windows.Forms.Label lblbookISBN;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.TextBox textBoxAuthor;
        private System.Windows.Forms.TextBox textBoxISBN;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDisplay;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonUpdt;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.ListBox listBoxBooks;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label labelEdition;
        private System.Windows.Forms.TextBox textBoxEditionDay;
        private System.Windows.Forms.TextBox textBoxEditionYear;
        private System.Windows.Forms.TextBox textBoxEditionMonth;
    }
}

