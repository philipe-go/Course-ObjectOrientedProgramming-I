namespace BikesFactoryClient
{
    partial class MainForm
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
            this.tbSerialNumber = new System.Windows.Forms.TextBox();
            this.tbManufacturer = new System.Windows.Forms.TextBox();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.cbColor = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateManufacturer = new System.Windows.Forms.DateTimePicker();
            this.btDisplaySB = new System.Windows.Forms.Button();
            this.btDisplayAll = new System.Windows.Forms.Button();
            this.btDisplayMountB = new System.Windows.Forms.Button();
            this.btDisplayRB = new System.Windows.Forms.Button();
            this.btDisplayMotorB = new System.Windows.Forms.Button();
            this.btBMX = new System.Windows.Forms.Button();
            this.btUpdate = new System.Windows.Forms.Button();
            this.btRefresh = new System.Windows.Forms.Button();
            this.btFilter = new System.Windows.Forms.Button();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.btExit = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbMadeIn = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btLoad = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.btRemove = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.listViewBikes = new System.Windows.Forms.ListView();
            this.SerialNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Color = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Manufacturer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MadeIn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ManufactDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SpeedX = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btMove = new System.Windows.Forms.Button();
            this.btStop = new System.Windows.Forms.Button();
            this.btEngine = new System.Windows.Forms.Button();
            this.btJump = new System.Windows.Forms.Button();
            this.btSuspension = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbSerialNumber
            // 
            this.tbSerialNumber.Location = new System.Drawing.Point(123, 13);
            this.tbSerialNumber.Name = "tbSerialNumber";
            this.tbSerialNumber.Size = new System.Drawing.Size(100, 20);
            this.tbSerialNumber.TabIndex = 0;
            this.tbSerialNumber.TextChanged += new System.EventHandler(this.TbSerialNumber_TextChanged);
            // 
            // tbManufacturer
            // 
            this.tbManufacturer.Location = new System.Drawing.Point(123, 94);
            this.tbManufacturer.Name = "tbManufacturer";
            this.tbManufacturer.Size = new System.Drawing.Size(100, 20);
            this.tbManufacturer.TabIndex = 4;
            this.tbManufacturer.TextChanged += new System.EventHandler(this.TbManufacturer_TextChanged);
            // 
            // cbType
            // 
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(123, 40);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(100, 21);
            this.cbType.TabIndex = 2;
            // 
            // cbColor
            // 
            this.cbColor.FormattingEnabled = true;
            this.cbColor.Location = new System.Drawing.Point(123, 67);
            this.cbColor.Name = "cbColor";
            this.cbColor.Size = new System.Drawing.Size(100, 21);
            this.cbColor.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Serial Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Bike Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Bike Color";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Manufacturer";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Made In";
            // 
            // dateManufacturer
            // 
            this.dateManufacturer.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateManufacturer.Location = new System.Drawing.Point(110, 140);
            this.dateManufacturer.Name = "dateManufacturer";
            this.dateManufacturer.Size = new System.Drawing.Size(100, 20);
            this.dateManufacturer.TabIndex = 6;
            // 
            // btDisplaySB
            // 
            this.btDisplaySB.Location = new System.Drawing.Point(23, 282);
            this.btDisplaySB.Name = "btDisplaySB";
            this.btDisplaySB.Size = new System.Drawing.Size(94, 23);
            this.btDisplaySB.TabIndex = 23;
            this.btDisplaySB.Text = "Display Speed";
            this.btDisplaySB.UseVisualStyleBackColor = true;
            this.btDisplaySB.Click += new System.EventHandler(this.BtDisplaySB_Click);
            // 
            // btDisplayAll
            // 
            this.btDisplayAll.Location = new System.Drawing.Point(23, 195);
            this.btDisplayAll.Name = "btDisplayAll";
            this.btDisplayAll.Size = new System.Drawing.Size(94, 23);
            this.btDisplayAll.TabIndex = 20;
            this.btDisplayAll.Text = "Display All";
            this.btDisplayAll.UseVisualStyleBackColor = true;
            this.btDisplayAll.Click += new System.EventHandler(this.BtDisplayAll_Click);
            // 
            // btDisplayMountB
            // 
            this.btDisplayMountB.Location = new System.Drawing.Point(23, 224);
            this.btDisplayMountB.Name = "btDisplayMountB";
            this.btDisplayMountB.Size = new System.Drawing.Size(94, 23);
            this.btDisplayMountB.TabIndex = 21;
            this.btDisplayMountB.Text = "Display Mtain";
            this.btDisplayMountB.UseVisualStyleBackColor = true;
            this.btDisplayMountB.Click += new System.EventHandler(this.BtDisplayMountB_Click);
            // 
            // btDisplayRB
            // 
            this.btDisplayRB.Location = new System.Drawing.Point(23, 253);
            this.btDisplayRB.Name = "btDisplayRB";
            this.btDisplayRB.Size = new System.Drawing.Size(94, 23);
            this.btDisplayRB.TabIndex = 22;
            this.btDisplayRB.Text = "Display Road";
            this.btDisplayRB.UseVisualStyleBackColor = true;
            this.btDisplayRB.Click += new System.EventHandler(this.BtDisplayRB_Click);
            // 
            // btDisplayMotorB
            // 
            this.btDisplayMotorB.Location = new System.Drawing.Point(10, 120);
            this.btDisplayMotorB.Name = "btDisplayMotorB";
            this.btDisplayMotorB.Size = new System.Drawing.Size(94, 23);
            this.btDisplayMotorB.TabIndex = 24;
            this.btDisplayMotorB.Text = "Display Motor B";
            this.btDisplayMotorB.UseVisualStyleBackColor = true;
            this.btDisplayMotorB.Click += new System.EventHandler(this.BtDisplayMotorB_Click);
            // 
            // btBMX
            // 
            this.btBMX.Location = new System.Drawing.Point(10, 149);
            this.btBMX.Name = "btBMX";
            this.btBMX.Size = new System.Drawing.Size(94, 23);
            this.btBMX.TabIndex = 25;
            this.btBMX.Text = "Display BMX";
            this.btBMX.UseVisualStyleBackColor = true;
            this.btBMX.Click += new System.EventHandler(this.BtBMX_Click);
            // 
            // btUpdate
            // 
            this.btUpdate.Location = new System.Drawing.Point(129, 253);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(94, 23);
            this.btUpdate.TabIndex = 9;
            this.btUpdate.Text = "Update";
            this.btUpdate.UseVisualStyleBackColor = true;
            this.btUpdate.Click += new System.EventHandler(this.BtUpdate_Click);
            // 
            // btRefresh
            // 
            this.btRefresh.Location = new System.Drawing.Point(129, 282);
            this.btRefresh.Name = "btRefresh";
            this.btRefresh.Size = new System.Drawing.Size(94, 23);
            this.btRefresh.TabIndex = 10;
            this.btRefresh.Text = "Refresh";
            this.btRefresh.UseVisualStyleBackColor = true;
            this.btRefresh.Click += new System.EventHandler(this.BtRefresh_Click);
            // 
            // btFilter
            // 
            this.btFilter.Location = new System.Drawing.Point(10, 178);
            this.btFilter.Name = "btFilter";
            this.btFilter.Size = new System.Drawing.Size(94, 23);
            this.btFilter.TabIndex = 26;
            this.btFilter.Tag = "";
            this.btFilter.Text = "Filter";
            this.btFilter.UseVisualStyleBackColor = true;
            this.btFilter.Click += new System.EventHandler(this.BtFilter_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(116, 180);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(94, 20);
            this.tbSearch.TabIndex = 13;
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(10, 207);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(200, 23);
            this.btExit.TabIndex = 14;
            this.btExit.Text = "Exit";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.BtExit_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.tbMadeIn);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.dateManufacturer);
            this.panel2.Location = new System.Drawing.Point(12, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(219, 179);
            this.panel2.TabIndex = 31;
            // 
            // tbMadeIn
            // 
            this.tbMadeIn.Location = new System.Drawing.Point(110, 114);
            this.tbMadeIn.Name = "tbMadeIn";
            this.tbMadeIn.Size = new System.Drawing.Size(100, 20);
            this.tbMadeIn.TabIndex = 5;
            this.tbMadeIn.TextChanged += new System.EventHandler(this.TbMadeIn_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Manufacture Date";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btLoad);
            this.panel3.Controls.Add(this.btSave);
            this.panel3.Controls.Add(this.btRemove);
            this.panel3.Controls.Add(this.btAdd);
            this.panel3.Controls.Add(this.btExit);
            this.panel3.Controls.Add(this.tbSearch);
            this.panel3.Controls.Add(this.btFilter);
            this.panel3.Controls.Add(this.btBMX);
            this.panel3.Controls.Add(this.btDisplayMotorB);
            this.panel3.Location = new System.Drawing.Point(12, 190);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(219, 239);
            this.panel3.TabIndex = 32;
            // 
            // btLoad
            // 
            this.btLoad.Location = new System.Drawing.Point(116, 149);
            this.btLoad.Name = "btLoad";
            this.btLoad.Size = new System.Drawing.Size(94, 23);
            this.btLoad.TabIndex = 12;
            this.btLoad.Text = "Load";
            this.btLoad.UseVisualStyleBackColor = true;
            this.btLoad.Click += new System.EventHandler(this.BtLoad_Click);
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(116, 120);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(94, 23);
            this.btSave.TabIndex = 11;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.BtSave_Click);
            // 
            // btRemove
            // 
            this.btRemove.Location = new System.Drawing.Point(116, 32);
            this.btRemove.Name = "btRemove";
            this.btRemove.Size = new System.Drawing.Size(94, 23);
            this.btRemove.TabIndex = 8;
            this.btRemove.Text = "Remove";
            this.btRemove.UseVisualStyleBackColor = true;
            this.btRemove.Click += new System.EventHandler(this.BtRemove_Click);
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(116, 3);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(94, 23);
            this.btAdd.TabIndex = 7;
            this.btAdd.Text = "Add";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.BtAdd_Click);
            // 
            // listViewBikes
            // 
            this.listViewBikes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.SerialNumber,
            this.Type,
            this.Color,
            this.Manufacturer,
            this.MadeIn,
            this.ManufactDate,
            this.SpeedX});
            this.listViewBikes.FullRowSelect = true;
            this.listViewBikes.GridLines = true;
            this.listViewBikes.HideSelection = false;
            this.listViewBikes.Location = new System.Drawing.Point(238, 5);
            this.listViewBikes.Name = "listViewBikes";
            this.listViewBikes.Size = new System.Drawing.Size(570, 395);
            this.listViewBikes.TabIndex = 33;
            this.listViewBikes.UseCompatibleStateImageBehavior = false;
            this.listViewBikes.View = System.Windows.Forms.View.Details;
            this.listViewBikes.SelectedIndexChanged += new System.EventHandler(this.ListViewBikes_SelectedIndexChanged);
            // 
            // SerialNumber
            // 
            this.SerialNumber.Text = "Serial";
            this.SerialNumber.Width = 104;
            // 
            // Type
            // 
            this.Type.Text = "Type";
            this.Type.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Type.Width = 76;
            // 
            // Color
            // 
            this.Color.Text = "Color";
            this.Color.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Color.Width = 58;
            // 
            // Manufacturer
            // 
            this.Manufacturer.Text = "Manufacturer";
            this.Manufacturer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Manufacturer.Width = 97;
            // 
            // MadeIn
            // 
            this.MadeIn.Text = "Made In";
            this.MadeIn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MadeIn.Width = 73;
            // 
            // ManufactDate
            // 
            this.ManufactDate.Text = "Manufacture Date";
            this.ManufactDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ManufactDate.Width = 100;
            // 
            // SpeedX
            // 
            this.SpeedX.Text = "SpeedX";
            this.SpeedX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SpeedX.Width = 59;
            // 
            // btMove
            // 
            this.btMove.Location = new System.Drawing.Point(263, 406);
            this.btMove.Name = "btMove";
            this.btMove.Size = new System.Drawing.Size(100, 23);
            this.btMove.TabIndex = 15;
            this.btMove.Text = "Move Bike";
            this.btMove.UseVisualStyleBackColor = true;
            this.btMove.Click += new System.EventHandler(this.BtMove_Click);
            // 
            // btStop
            // 
            this.btStop.Location = new System.Drawing.Point(369, 406);
            this.btStop.Name = "btStop";
            this.btStop.Size = new System.Drawing.Size(100, 23);
            this.btStop.TabIndex = 16;
            this.btStop.Text = "Stop Bike";
            this.btStop.UseVisualStyleBackColor = true;
            this.btStop.Click += new System.EventHandler(this.BtStop_Click);
            // 
            // btEngine
            // 
            this.btEngine.Location = new System.Drawing.Point(475, 406);
            this.btEngine.Name = "btEngine";
            this.btEngine.Size = new System.Drawing.Size(100, 23);
            this.btEngine.TabIndex = 17;
            this.btEngine.Text = "Start Engine";
            this.btEngine.UseVisualStyleBackColor = true;
            this.btEngine.Click += new System.EventHandler(this.BtEngine_Click);
            // 
            // btJump
            // 
            this.btJump.Location = new System.Drawing.Point(581, 406);
            this.btJump.Name = "btJump";
            this.btJump.Size = new System.Drawing.Size(100, 23);
            this.btJump.TabIndex = 18;
            this.btJump.Text = "Jump Bike";
            this.btJump.UseVisualStyleBackColor = true;
            this.btJump.Click += new System.EventHandler(this.BtJump_Click);
            // 
            // btSuspension
            // 
            this.btSuspension.Location = new System.Drawing.Point(687, 406);
            this.btSuspension.Name = "btSuspension";
            this.btSuspension.Size = new System.Drawing.Size(100, 23);
            this.btSuspension.TabIndex = 19;
            this.btSuspension.Text = "New Suspension";
            this.btSuspension.UseVisualStyleBackColor = true;
            this.btSuspension.Click += new System.EventHandler(this.BtSuspension_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(820, 436);
            this.Controls.Add(this.btSuspension);
            this.Controls.Add(this.btJump);
            this.Controls.Add(this.btEngine);
            this.Controls.Add(this.btStop);
            this.Controls.Add(this.btMove);
            this.Controls.Add(this.listViewBikes);
            this.Controls.Add(this.btRefresh);
            this.Controls.Add(this.btUpdate);
            this.Controls.Add(this.btDisplayRB);
            this.Controls.Add(this.btDisplayMountB);
            this.Controls.Add(this.btDisplayAll);
            this.Controls.Add(this.btDisplaySB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbColor);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.tbManufacturer);
            this.Controls.Add(this.tbSerialNumber);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Name = "MainForm";
            this.Text = "<<My Bike Factory >> Philipe Gouveia";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbSerialNumber;
        private System.Windows.Forms.TextBox tbManufacturer;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.ComboBox cbColor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateManufacturer;
        private System.Windows.Forms.Button btDisplaySB;
        private System.Windows.Forms.Button btDisplayAll;
        private System.Windows.Forms.Button btDisplayMountB;
        private System.Windows.Forms.Button btDisplayRB;
        private System.Windows.Forms.Button btDisplayMotorB;
        private System.Windows.Forms.Button btBMX;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Button btRefresh;
        private System.Windows.Forms.Button btFilter;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListView listViewBikes;
        private System.Windows.Forms.Button btRemove;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btLoad;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btMove;
        private System.Windows.Forms.Button btStop;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btEngine;
        private System.Windows.Forms.Button btJump;
        private System.Windows.Forms.ColumnHeader SerialNumber;
        private System.Windows.Forms.ColumnHeader Type;
        private System.Windows.Forms.ColumnHeader Color;
        private System.Windows.Forms.ColumnHeader Manufacturer;
        private System.Windows.Forms.ColumnHeader MadeIn;
        private System.Windows.Forms.ColumnHeader ManufactDate;
        private System.Windows.Forms.ColumnHeader SpeedX;
        private System.Windows.Forms.TextBox tbMadeIn;
        private System.Windows.Forms.Button btSuspension;
    }
}

