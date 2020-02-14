//project done by Philipe Gouveia @ July 8th, 2019
//assignment requested on Summer Session Lasalle College - Object Oriented Programming


namespace GeometricShapesApp
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
            this.buttonAdd = new System.Windows.Forms.Button();
            this.listBoxShapes = new System.Windows.Forms.ListBox();
            this.tBXcoor = new System.Windows.Forms.TextBox();
            this.tBYcoor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cBName = new System.Windows.Forms.ComboBox();
            this.cBColor = new System.Windows.Forms.ComboBox();
            this.tBBaseRadius = new System.Windows.Forms.TextBox();
            this.tBHeight = new System.Windows.Forms.TextBox();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonDisplay = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.tBSearch = new System.Windows.Forms.TextBox();
            this.buttonAdd2 = new System.Windows.Forms.Button();
            this.labelBaseRadius = new System.Windows.Forms.Label();
            this.labelHeight = new System.Windows.Forms.Label();
            this.ArrowUp = new System.Windows.Forms.Button();
            this.ArrowLeftUp = new System.Windows.Forms.Button();
            this.ArrowRightUp = new System.Windows.Forms.Button();
            this.ArrowRight = new System.Windows.Forms.Button();
            this.ArrowLeft = new System.Windows.Forms.Button();
            this.ArrowRightDown = new System.Windows.Forms.Button();
            this.ArrowLeftDown = new System.Windows.Forms.Button();
            this.ArrowDown = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttonMove = new System.Windows.Forms.Button();
            this.labelMove = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tBIncrement = new System.Windows.Forms.TextBox();
            this.labelIncr = new System.Windows.Forms.Label();
            this.panelDrawing = new System.Windows.Forms.Panel();
            this.btDraw = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.btLoad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(198, 11);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(65, 28);
            this.buttonAdd.TabIndex = 5;
            this.buttonAdd.Text = "Create";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // listBoxShapes
            // 
            this.listBoxShapes.BackColor = System.Drawing.SystemColors.ControlLight;
            this.listBoxShapes.FormattingEnabled = true;
            this.listBoxShapes.Location = new System.Drawing.Point(9, 386);
            this.listBoxShapes.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxShapes.MultiColumn = true;
            this.listBoxShapes.Name = "listBoxShapes";
            this.listBoxShapes.Size = new System.Drawing.Size(392, 108);
            this.listBoxShapes.TabIndex = 30;
            this.listBoxShapes.SelectedIndexChanged += new System.EventHandler(this.ListBoxShapes_SelectedIndexChanged);
            // 
            // tBXcoor
            // 
            this.tBXcoor.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tBXcoor.Location = new System.Drawing.Point(10, 56);
            this.tBXcoor.Margin = new System.Windows.Forms.Padding(2);
            this.tBXcoor.Name = "tBXcoor";
            this.tBXcoor.Size = new System.Drawing.Size(41, 20);
            this.tBXcoor.TabIndex = 3;
            this.tBXcoor.TextChanged += new System.EventHandler(this.TBXcoor_TextChanged);
            // 
            // tBYcoor
            // 
            this.tBYcoor.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tBYcoor.Location = new System.Drawing.Point(81, 56);
            this.tBYcoor.Margin = new System.Windows.Forms.Padding(2);
            this.tBYcoor.Name = "tBYcoor";
            this.tBYcoor.Size = new System.Drawing.Size(41, 20);
            this.tBYcoor.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(125, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Y";
            // 
            // cBName
            // 
            this.cBName.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cBName.FormattingEnabled = true;
            this.cBName.Location = new System.Drawing.Point(10, 10);
            this.cBName.Margin = new System.Windows.Forms.Padding(2);
            this.cBName.Name = "cBName";
            this.cBName.Size = new System.Drawing.Size(132, 21);
            this.cBName.TabIndex = 1;
            this.cBName.Text = "Shape Type";
            // 
            // cBColor
            // 
            this.cBColor.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cBColor.FormattingEnabled = true;
            this.cBColor.Location = new System.Drawing.Point(10, 32);
            this.cBColor.Margin = new System.Windows.Forms.Padding(2);
            this.cBColor.Name = "cBColor";
            this.cBColor.Size = new System.Drawing.Size(132, 21);
            this.cBColor.TabIndex = 2;
            this.cBColor.Text = "Shape Color";
            // 
            // tBBaseRadius
            // 
            this.tBBaseRadius.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tBBaseRadius.Location = new System.Drawing.Point(10, 79);
            this.tBBaseRadius.Margin = new System.Windows.Forms.Padding(2);
            this.tBBaseRadius.Name = "tBBaseRadius";
            this.tBBaseRadius.Size = new System.Drawing.Size(132, 20);
            this.tBBaseRadius.TabIndex = 9;
            this.tBBaseRadius.Visible = false;
            // 
            // tBHeight
            // 
            this.tBHeight.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tBHeight.Location = new System.Drawing.Point(10, 102);
            this.tBHeight.Margin = new System.Windows.Forms.Padding(2);
            this.tBHeight.Name = "tBHeight";
            this.tBHeight.Size = new System.Drawing.Size(133, 20);
            this.tBHeight.TabIndex = 10;
            this.tBHeight.Visible = false;
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(267, 11);
            this.buttonRemove.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(65, 28);
            this.buttonRemove.TabIndex = 33;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.ButtonRemove_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(336, 43);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(2);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(65, 28);
            this.buttonExit.TabIndex = 34;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // buttonDisplay
            // 
            this.buttonDisplay.Location = new System.Drawing.Point(336, 11);
            this.buttonDisplay.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDisplay.Name = "buttonDisplay";
            this.buttonDisplay.Size = new System.Drawing.Size(65, 28);
            this.buttonDisplay.TabIndex = 35;
            this.buttonDisplay.Text = "Display";
            this.buttonDisplay.UseVisualStyleBackColor = true;
            this.buttonDisplay.Click += new System.EventHandler(this.ButtonDisplay_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(9, 314);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(65, 28);
            this.buttonSearch.TabIndex = 36;
            this.buttonSearch.Text = "Filter";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // tBSearch
            // 
            this.tBSearch.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tBSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tBSearch.Location = new System.Drawing.Point(81, 319);
            this.tBSearch.Margin = new System.Windows.Forms.Padding(2);
            this.tBSearch.Name = "tBSearch";
            this.tBSearch.Size = new System.Drawing.Size(61, 20);
            this.tBSearch.TabIndex = 37;
            // 
            // buttonAdd2
            // 
            this.buttonAdd2.Location = new System.Drawing.Point(40, 124);
            this.buttonAdd2.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAdd2.Name = "buttonAdd2";
            this.buttonAdd2.Size = new System.Drawing.Size(65, 28);
            this.buttonAdd2.TabIndex = 11;
            this.buttonAdd2.Text = "Add";
            this.buttonAdd2.UseVisualStyleBackColor = true;
            this.buttonAdd2.Visible = false;
            this.buttonAdd2.Click += new System.EventHandler(this.ButtonAdd2_Click);
            // 
            // labelBaseRadius
            // 
            this.labelBaseRadius.AutoSize = true;
            this.labelBaseRadius.Location = new System.Drawing.Point(146, 82);
            this.labelBaseRadius.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBaseRadius.Name = "labelBaseRadius";
            this.labelBaseRadius.Size = new System.Drawing.Size(69, 13);
            this.labelBaseRadius.TabIndex = 39;
            this.labelBaseRadius.Text = "Poligon Base";
            this.labelBaseRadius.Visible = false;
            // 
            // labelHeight
            // 
            this.labelHeight.AutoSize = true;
            this.labelHeight.Location = new System.Drawing.Point(146, 104);
            this.labelHeight.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelHeight.Name = "labelHeight";
            this.labelHeight.Size = new System.Drawing.Size(76, 13);
            this.labelHeight.TabIndex = 40;
            this.labelHeight.Text = "Poligon Height";
            this.labelHeight.Visible = false;
            // 
            // ArrowUp
            // 
            this.ArrowUp.Location = new System.Drawing.Point(56, 169);
            this.ArrowUp.Margin = new System.Windows.Forms.Padding(2);
            this.ArrowUp.Name = "ArrowUp";
            this.ArrowUp.Size = new System.Drawing.Size(33, 36);
            this.ArrowUp.TabIndex = 41;
            this.ArrowUp.Text = "🔺";
            this.ArrowUp.UseVisualStyleBackColor = true;
            this.ArrowUp.Visible = false;
            this.ArrowUp.Click += new System.EventHandler(this.ArrowUp_Click);
            // 
            // ArrowLeftUp
            // 
            this.ArrowLeftUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ArrowLeftUp.Location = new System.Drawing.Point(19, 169);
            this.ArrowLeftUp.Margin = new System.Windows.Forms.Padding(2);
            this.ArrowLeftUp.Name = "ArrowLeftUp";
            this.ArrowLeftUp.Size = new System.Drawing.Size(33, 36);
            this.ArrowLeftUp.TabIndex = 42;
            this.ArrowLeftUp.Text = "↖";
            this.ArrowLeftUp.UseVisualStyleBackColor = true;
            this.ArrowLeftUp.Visible = false;
            this.ArrowLeftUp.Click += new System.EventHandler(this.ArrowLeftUp_Click);
            // 
            // ArrowRightUp
            // 
            this.ArrowRightUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ArrowRightUp.Location = new System.Drawing.Point(94, 169);
            this.ArrowRightUp.Margin = new System.Windows.Forms.Padding(2);
            this.ArrowRightUp.Name = "ArrowRightUp";
            this.ArrowRightUp.Size = new System.Drawing.Size(33, 36);
            this.ArrowRightUp.TabIndex = 43;
            this.ArrowRightUp.Text = "↗";
            this.ArrowRightUp.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.ArrowRightUp.UseVisualStyleBackColor = true;
            this.ArrowRightUp.Visible = false;
            this.ArrowRightUp.Click += new System.EventHandler(this.ArrowRightUp_Click);
            // 
            // ArrowRight
            // 
            this.ArrowRight.Location = new System.Drawing.Point(94, 205);
            this.ArrowRight.Margin = new System.Windows.Forms.Padding(2);
            this.ArrowRight.Name = "ArrowRight";
            this.ArrowRight.Size = new System.Drawing.Size(33, 31);
            this.ArrowRight.TabIndex = 46;
            this.ArrowRight.Text = "▶";
            this.ArrowRight.UseVisualStyleBackColor = true;
            this.ArrowRight.Visible = false;
            this.ArrowRight.Click += new System.EventHandler(this.ArrowRight_Click);
            // 
            // ArrowLeft
            // 
            this.ArrowLeft.Location = new System.Drawing.Point(19, 205);
            this.ArrowLeft.Margin = new System.Windows.Forms.Padding(2);
            this.ArrowLeft.Name = "ArrowLeft";
            this.ArrowLeft.Size = new System.Drawing.Size(33, 31);
            this.ArrowLeft.TabIndex = 45;
            this.ArrowLeft.Text = "◀";
            this.ArrowLeft.UseVisualStyleBackColor = true;
            this.ArrowLeft.Visible = false;
            this.ArrowLeft.Click += new System.EventHandler(this.ArrowLeft_Click);
            // 
            // ArrowRightDown
            // 
            this.ArrowRightDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ArrowRightDown.Location = new System.Drawing.Point(94, 236);
            this.ArrowRightDown.Margin = new System.Windows.Forms.Padding(2);
            this.ArrowRightDown.Name = "ArrowRightDown";
            this.ArrowRightDown.Size = new System.Drawing.Size(33, 36);
            this.ArrowRightDown.TabIndex = 49;
            this.ArrowRightDown.Text = "↘";
            this.ArrowRightDown.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ArrowRightDown.UseVisualStyleBackColor = true;
            this.ArrowRightDown.Visible = false;
            this.ArrowRightDown.Click += new System.EventHandler(this.ArrowRightDown_Click);
            // 
            // ArrowLeftDown
            // 
            this.ArrowLeftDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ArrowLeftDown.Location = new System.Drawing.Point(19, 236);
            this.ArrowLeftDown.Margin = new System.Windows.Forms.Padding(2);
            this.ArrowLeftDown.Name = "ArrowLeftDown";
            this.ArrowLeftDown.Size = new System.Drawing.Size(33, 36);
            this.ArrowLeftDown.TabIndex = 48;
            this.ArrowLeftDown.Text = "↙";
            this.ArrowLeftDown.UseVisualStyleBackColor = true;
            this.ArrowLeftDown.Visible = false;
            this.ArrowLeftDown.Click += new System.EventHandler(this.ArrowLeftDown_Click);
            // 
            // ArrowDown
            // 
            this.ArrowDown.Location = new System.Drawing.Point(56, 236);
            this.ArrowDown.Margin = new System.Windows.Forms.Padding(2);
            this.ArrowDown.Name = "ArrowDown";
            this.ArrowDown.Size = new System.Drawing.Size(33, 36);
            this.ArrowDown.TabIndex = 47;
            this.ArrowDown.Text = "🔻";
            this.ArrowDown.UseVisualStyleBackColor = true;
            this.ArrowDown.Visible = false;
            this.ArrowDown.Click += new System.EventHandler(this.ArrowDown_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(198, 43);
            this.buttonRefresh.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(65, 28);
            this.buttonRefresh.TabIndex = 50;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.ButtonRefresh_Click);
            // 
            // buttonMove
            // 
            this.buttonMove.Location = new System.Drawing.Point(267, 43);
            this.buttonMove.Margin = new System.Windows.Forms.Padding(2);
            this.buttonMove.Name = "buttonMove";
            this.buttonMove.Size = new System.Drawing.Size(65, 28);
            this.buttonMove.TabIndex = 51;
            this.buttonMove.Text = "Move";
            this.buttonMove.UseVisualStyleBackColor = true;
            this.buttonMove.Click += new System.EventHandler(this.ButtonMove_Click);
            // 
            // labelMove
            // 
            this.labelMove.AutoSize = true;
            this.labelMove.Location = new System.Drawing.Point(53, 206);
            this.labelMove.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMove.Name = "labelMove";
            this.labelMove.Size = new System.Drawing.Size(42, 26);
            this.labelMove.TabIndex = 52;
            this.labelMove.Text = " Move \r\nPoligon";
            this.labelMove.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelMove.Visible = false;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.Info;
            this.label8.Location = new System.Drawing.Point(8, 349);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(393, 15);
            this.label8.TabIndex = 58;
            this.label8.Text = "List of Shapes";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label3.Location = new System.Drawing.Point(8, 364);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 20);
            this.label3.TabIndex = 59;
            this.label3.Text = "Serial";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label4.Location = new System.Drawing.Point(46, 364);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 20);
            this.label4.TabIndex = 60;
            this.label4.Text = "Type";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label5.Location = new System.Drawing.Point(157, 364);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 20);
            this.label5.TabIndex = 61;
            this.label5.Text = "X / Y";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label6.Location = new System.Drawing.Point(216, 364);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 20);
            this.label6.TabIndex = 62;
            this.label6.Text = "Area";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label7.Location = new System.Drawing.Point(286, 364);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 20);
            this.label7.TabIndex = 63;
            this.label7.Text = "Perimeter";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label9.Location = new System.Drawing.Point(104, 364);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 20);
            this.label9.TabIndex = 64;
            this.label9.Text = "Color";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tBIncrement
            // 
            this.tBIncrement.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tBIncrement.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tBIncrement.Location = new System.Drawing.Point(79, 275);
            this.tBIncrement.Margin = new System.Windows.Forms.Padding(2);
            this.tBIncrement.Name = "tBIncrement";
            this.tBIncrement.Size = new System.Drawing.Size(48, 20);
            this.tBIncrement.TabIndex = 65;
            this.tBIncrement.Text = "1";
            this.tBIncrement.Visible = false;
            // 
            // labelIncr
            // 
            this.labelIncr.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.labelIncr.Location = new System.Drawing.Point(16, 274);
            this.labelIncr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelIncr.Name = "labelIncr";
            this.labelIncr.Size = new System.Drawing.Size(58, 20);
            this.labelIncr.TabIndex = 66;
            this.labelIncr.Text = "Increment:";
            this.labelIncr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelIncr.Visible = false;
            // 
            // panelDrawing
            // 
            this.panelDrawing.Location = new System.Drawing.Point(149, 120);
            this.panelDrawing.Name = "panelDrawing";
            this.panelDrawing.Size = new System.Drawing.Size(252, 215);
            this.panelDrawing.TabIndex = 67;
            this.panelDrawing.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelDrawing_Paint);
            // 
            // btDraw
            // 
            this.btDraw.Location = new System.Drawing.Point(336, 89);
            this.btDraw.Margin = new System.Windows.Forms.Padding(2);
            this.btDraw.Name = "btDraw";
            this.btDraw.Size = new System.Drawing.Size(65, 28);
            this.btDraw.TabIndex = 68;
            this.btDraw.Text = "Draw";
            this.btDraw.UseVisualStyleBackColor = true;
            this.btDraw.Click += new System.EventHandler(this.BtDraw_Click);
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(9, 498);
            this.btSave.Margin = new System.Windows.Forms.Padding(2);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(65, 28);
            this.btSave.TabIndex = 69;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.BtSave_Click);
            // 
            // btLoad
            // 
            this.btLoad.Location = new System.Drawing.Point(77, 498);
            this.btLoad.Margin = new System.Windows.Forms.Padding(2);
            this.btLoad.Name = "btLoad";
            this.btLoad.Size = new System.Drawing.Size(65, 28);
            this.btLoad.TabIndex = 70;
            this.btLoad.Text = "Load";
            this.btLoad.UseVisualStyleBackColor = true;
            this.btLoad.Click += new System.EventHandler(this.BtLoad_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(405, 528);
            this.Controls.Add(this.btLoad);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.btDraw);
            this.Controls.Add(this.panelDrawing);
            this.Controls.Add(this.labelIncr);
            this.Controls.Add(this.tBIncrement);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.labelMove);
            this.Controls.Add(this.buttonMove);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.ArrowRightDown);
            this.Controls.Add(this.ArrowLeftDown);
            this.Controls.Add(this.ArrowDown);
            this.Controls.Add(this.ArrowRight);
            this.Controls.Add(this.ArrowLeft);
            this.Controls.Add(this.ArrowRightUp);
            this.Controls.Add(this.ArrowLeftUp);
            this.Controls.Add(this.ArrowUp);
            this.Controls.Add(this.labelHeight);
            this.Controls.Add(this.labelBaseRadius);
            this.Controls.Add(this.buttonAdd2);
            this.Controls.Add(this.tBSearch);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonDisplay);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.cBColor);
            this.Controls.Add(this.cBName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tBYcoor);
            this.Controls.Add(this.tBXcoor);
            this.Controls.Add(this.listBoxShapes);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.tBHeight);
            this.Controls.Add(this.tBBaseRadius);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "by Philipe Gouveia 1910072";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ListBox listBoxShapes;
        private System.Windows.Forms.TextBox tBXcoor;
        private System.Windows.Forms.TextBox tBYcoor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cBName;
        private System.Windows.Forms.ComboBox cBColor;
        private System.Windows.Forms.TextBox tBBaseRadius;
        private System.Windows.Forms.TextBox tBHeight;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonDisplay;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox tBSearch;
        private System.Windows.Forms.Button buttonAdd2;
        private System.Windows.Forms.Label labelBaseRadius;
        private System.Windows.Forms.Label labelHeight;
        private System.Windows.Forms.Button ArrowUp;
        private System.Windows.Forms.Button ArrowLeftUp;
        private System.Windows.Forms.Button ArrowRightUp;
        private System.Windows.Forms.Button ArrowRight;
        private System.Windows.Forms.Button ArrowLeft;
        private System.Windows.Forms.Button ArrowRightDown;
        private System.Windows.Forms.Button ArrowLeftDown;
        private System.Windows.Forms.Button ArrowDown;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button buttonMove;
        private System.Windows.Forms.Label labelMove;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tBIncrement;
        private System.Windows.Forms.Label labelIncr;
        private System.Windows.Forms.Panel panelDrawing;
        private System.Windows.Forms.Button btDraw;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btLoad;
    }
}

