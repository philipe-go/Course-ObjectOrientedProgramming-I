namespace GeometricShapesFinal.business
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
            this.tbXCoord = new System.Windows.Forms.TextBox();
            this.tbYCoord = new System.Windows.Forms.TextBox();
            this.tbHeight = new System.Windows.Forms.TextBox();
            this.tbLength = new System.Windows.Forms.TextBox();
            this.tbSide = new System.Windows.Forms.TextBox();
            this.tbXRadius = new System.Windows.Forms.TextBox();
            this.tbYRadius = new System.Windows.Forms.TextBox();
            this.tbRadius = new System.Windows.Forms.TextBox();
            this.cbBColor = new System.Windows.Forms.ComboBox();
            this.cbSColor = new System.Windows.Forms.ComboBox();
            this.btDraw = new System.Windows.Forms.Button();
            this.xCoor = new System.Windows.Forms.Label();
            this.yCoord = new System.Windows.Forms.Label();
            this.bColor = new System.Windows.Forms.Label();
            this.sColor = new System.Windows.Forms.Label();
            this.txShapes = new System.Windows.Forms.Label();
            this.Height = new System.Windows.Forms.Label();
            this.Length = new System.Windows.Forms.Label();
            this.Side = new System.Windows.Forms.Label();
            this.xRadius = new System.Windows.Forms.Label();
            this.yRadius = new System.Windows.Forms.Label();
            this.Radius = new System.Windows.Forms.Label();
            this.btExit = new System.Windows.Forms.Button();
            this.rbRectangle = new System.Windows.Forms.RadioButton();
            this.rbSquare = new System.Windows.Forms.RadioButton();
            this.rbEllipses = new System.Windows.Forms.RadioButton();
            this.rbCircle = new System.Windows.Forms.RadioButton();
            this.panelDraw = new System.Windows.Forms.Panel();
            this.btUp = new System.Windows.Forms.Button();
            this.btUpLeft = new System.Windows.Forms.Button();
            this.btUpRight = new System.Windows.Forms.Button();
            this.btRight = new System.Windows.Forms.Button();
            this.btLeft = new System.Windows.Forms.Button();
            this.btDownRight = new System.Windows.Forms.Button();
            this.btDownLeft = new System.Windows.Forms.Button();
            this.btDown = new System.Windows.Forms.Button();
            this.btLoad = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.listBoxShapes = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // tbXCoord
            // 
            this.tbXCoord.Location = new System.Drawing.Point(83, 47);
            this.tbXCoord.Name = "tbXCoord";
            this.tbXCoord.Size = new System.Drawing.Size(100, 20);
            this.tbXCoord.TabIndex = 0;
            // 
            // tbYCoord
            // 
            this.tbYCoord.Location = new System.Drawing.Point(83, 74);
            this.tbYCoord.Name = "tbYCoord";
            this.tbYCoord.Size = new System.Drawing.Size(100, 20);
            this.tbYCoord.TabIndex = 1;
            // 
            // tbHeight
            // 
            this.tbHeight.Location = new System.Drawing.Point(241, 44);
            this.tbHeight.Name = "tbHeight";
            this.tbHeight.Size = new System.Drawing.Size(100, 20);
            this.tbHeight.TabIndex = 2;
            // 
            // tbLength
            // 
            this.tbLength.Location = new System.Drawing.Point(241, 70);
            this.tbLength.Name = "tbLength";
            this.tbLength.Size = new System.Drawing.Size(100, 20);
            this.tbLength.TabIndex = 3;
            // 
            // tbSide
            // 
            this.tbSide.Location = new System.Drawing.Point(388, 43);
            this.tbSide.Name = "tbSide";
            this.tbSide.Size = new System.Drawing.Size(100, 20);
            this.tbSide.TabIndex = 4;
            // 
            // tbXRadius
            // 
            this.tbXRadius.Location = new System.Drawing.Point(548, 39);
            this.tbXRadius.Name = "tbXRadius";
            this.tbXRadius.Size = new System.Drawing.Size(100, 20);
            this.tbXRadius.TabIndex = 5;
            // 
            // tbYRadius
            // 
            this.tbYRadius.Location = new System.Drawing.Point(548, 66);
            this.tbYRadius.Name = "tbYRadius";
            this.tbYRadius.Size = new System.Drawing.Size(100, 20);
            this.tbYRadius.TabIndex = 6;
            // 
            // tbRadius
            // 
            this.tbRadius.Location = new System.Drawing.Point(718, 39);
            this.tbRadius.Name = "tbRadius";
            this.tbRadius.Size = new System.Drawing.Size(100, 20);
            this.tbRadius.TabIndex = 7;
            // 
            // cbBColor
            // 
            this.cbBColor.FormattingEnabled = true;
            this.cbBColor.Location = new System.Drawing.Point(83, 132);
            this.cbBColor.Name = "cbBColor";
            this.cbBColor.Size = new System.Drawing.Size(121, 21);
            this.cbBColor.TabIndex = 8;
            // 
            // cbSColor
            // 
            this.cbSColor.FormattingEnabled = true;
            this.cbSColor.Location = new System.Drawing.Point(83, 159);
            this.cbSColor.Name = "cbSColor";
            this.cbSColor.Size = new System.Drawing.Size(121, 21);
            this.cbSColor.TabIndex = 9;
            // 
            // btDraw
            // 
            this.btDraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDraw.Location = new System.Drawing.Point(33, 204);
            this.btDraw.Name = "btDraw";
            this.btDraw.Size = new System.Drawing.Size(171, 37);
            this.btDraw.TabIndex = 10;
            this.btDraw.Text = "Draw it";
            this.btDraw.UseVisualStyleBackColor = true;
            this.btDraw.Click += new System.EventHandler(this.BtDraw_Click);
            // 
            // xCoor
            // 
            this.xCoor.AutoSize = true;
            this.xCoor.Location = new System.Drawing.Point(37, 51);
            this.xCoor.Name = "xCoor";
            this.xCoor.Size = new System.Drawing.Size(40, 13);
            this.xCoor.TabIndex = 11;
            this.xCoor.Text = "xCoord";
            // 
            // yCoord
            // 
            this.yCoord.AutoSize = true;
            this.yCoord.Location = new System.Drawing.Point(37, 77);
            this.yCoord.Name = "yCoord";
            this.yCoord.Size = new System.Drawing.Size(40, 13);
            this.yCoord.TabIndex = 12;
            this.yCoord.Text = "yCoord";
            // 
            // bColor
            // 
            this.bColor.AutoSize = true;
            this.bColor.Location = new System.Drawing.Point(12, 135);
            this.bColor.Name = "bColor";
            this.bColor.Size = new System.Drawing.Size(65, 13);
            this.bColor.TabIndex = 13;
            this.bColor.Text = "Border Color";
            // 
            // sColor
            // 
            this.sColor.AutoSize = true;
            this.sColor.Location = new System.Drawing.Point(13, 162);
            this.sColor.Name = "sColor";
            this.sColor.Size = new System.Drawing.Size(65, 13);
            this.sColor.TabIndex = 14;
            this.sColor.Text = "Shape Color";
            // 
            // txShapes
            // 
            this.txShapes.AutoSize = true;
            this.txShapes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txShapes.Location = new System.Drawing.Point(57, 13);
            this.txShapes.Name = "txShapes";
            this.txShapes.Size = new System.Drawing.Size(80, 24);
            this.txShapes.TabIndex = 15;
            this.txShapes.Text = "Shapes";
            // 
            // Height
            // 
            this.Height.AutoSize = true;
            this.Height.Location = new System.Drawing.Point(197, 51);
            this.Height.Name = "Height";
            this.Height.Size = new System.Drawing.Size(38, 13);
            this.Height.TabIndex = 16;
            this.Height.Text = "Height";
            // 
            // Length
            // 
            this.Length.AutoSize = true;
            this.Length.Location = new System.Drawing.Point(195, 77);
            this.Length.Name = "Length";
            this.Length.Size = new System.Drawing.Size(40, 13);
            this.Length.TabIndex = 17;
            this.Length.Text = "Length";
            // 
            // Side
            // 
            this.Side.AutoSize = true;
            this.Side.Location = new System.Drawing.Point(354, 50);
            this.Side.Name = "Side";
            this.Side.Size = new System.Drawing.Size(28, 13);
            this.Side.TabIndex = 18;
            this.Side.Text = "Side";
            // 
            // xRadius
            // 
            this.xRadius.AutoSize = true;
            this.xRadius.Location = new System.Drawing.Point(501, 46);
            this.xRadius.Name = "xRadius";
            this.xRadius.Size = new System.Drawing.Size(45, 13);
            this.xRadius.TabIndex = 19;
            this.xRadius.Text = "xRadius";
            // 
            // yRadius
            // 
            this.yRadius.AutoSize = true;
            this.yRadius.Location = new System.Drawing.Point(501, 73);
            this.yRadius.Name = "yRadius";
            this.yRadius.Size = new System.Drawing.Size(45, 13);
            this.yRadius.TabIndex = 20;
            this.yRadius.Text = "yRadius";
            // 
            // Radius
            // 
            this.Radius.AutoSize = true;
            this.Radius.Location = new System.Drawing.Point(672, 42);
            this.Radius.Name = "Radius";
            this.Radius.Size = new System.Drawing.Size(40, 13);
            this.Radius.TabIndex = 21;
            this.Radius.Text = "Radius";
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(841, 14);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(75, 23);
            this.btExit.TabIndex = 22;
            this.btExit.Text = "Exit";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.BtExit_Click);
            // 
            // rbRectangle
            // 
            this.rbRectangle.AutoSize = true;
            this.rbRectangle.Location = new System.Drawing.Point(241, 17);
            this.rbRectangle.Name = "rbRectangle";
            this.rbRectangle.Size = new System.Drawing.Size(74, 17);
            this.rbRectangle.TabIndex = 23;
            this.rbRectangle.TabStop = true;
            this.rbRectangle.Text = "Rectangle";
            this.rbRectangle.UseVisualStyleBackColor = true;
            // 
            // rbSquare
            // 
            this.rbSquare.AutoSize = true;
            this.rbSquare.Location = new System.Drawing.Point(388, 17);
            this.rbSquare.Name = "rbSquare";
            this.rbSquare.Size = new System.Drawing.Size(59, 17);
            this.rbSquare.TabIndex = 24;
            this.rbSquare.TabStop = true;
            this.rbSquare.Text = "Square";
            this.rbSquare.UseVisualStyleBackColor = true;
            // 
            // rbEllipses
            // 
            this.rbEllipses.AutoSize = true;
            this.rbEllipses.Location = new System.Drawing.Point(548, 17);
            this.rbEllipses.Name = "rbEllipses";
            this.rbEllipses.Size = new System.Drawing.Size(60, 17);
            this.rbEllipses.TabIndex = 25;
            this.rbEllipses.TabStop = true;
            this.rbEllipses.Text = "Ellipses";
            this.rbEllipses.UseVisualStyleBackColor = true;
            // 
            // rbCircle
            // 
            this.rbCircle.AutoSize = true;
            this.rbCircle.Location = new System.Drawing.Point(718, 17);
            this.rbCircle.Name = "rbCircle";
            this.rbCircle.Size = new System.Drawing.Size(51, 17);
            this.rbCircle.TabIndex = 26;
            this.rbCircle.TabStop = true;
            this.rbCircle.Text = "Circle";
            this.rbCircle.UseVisualStyleBackColor = true;
            // 
            // panelDraw
            // 
            this.panelDraw.Location = new System.Drawing.Point(241, 112);
            this.panelDraw.Name = "panelDraw";
            this.panelDraw.Size = new System.Drawing.Size(675, 352);
            this.panelDraw.TabIndex = 27;
            this.panelDraw.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelDraw_Paint);
            // 
            // btUp
            // 
            this.btUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btUp.Location = new System.Drawing.Point(90, 247);
            this.btUp.Name = "btUp";
            this.btUp.Size = new System.Drawing.Size(54, 46);
            this.btUp.TabIndex = 28;
            this.btUp.Text = "↑";
            this.btUp.UseVisualStyleBackColor = true;
            // 
            // btUpLeft
            // 
            this.btUpLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btUpLeft.Location = new System.Drawing.Point(33, 247);
            this.btUpLeft.Name = "btUpLeft";
            this.btUpLeft.Size = new System.Drawing.Size(54, 46);
            this.btUpLeft.TabIndex = 29;
            this.btUpLeft.Text = "↖";
            this.btUpLeft.UseVisualStyleBackColor = true;
            // 
            // btUpRight
            // 
            this.btUpRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btUpRight.Location = new System.Drawing.Point(150, 247);
            this.btUpRight.Name = "btUpRight";
            this.btUpRight.Size = new System.Drawing.Size(54, 46);
            this.btUpRight.TabIndex = 30;
            this.btUpRight.Text = "↗";
            this.btUpRight.UseVisualStyleBackColor = true;
            // 
            // btRight
            // 
            this.btRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRight.Location = new System.Drawing.Point(150, 299);
            this.btRight.Name = "btRight";
            this.btRight.Size = new System.Drawing.Size(54, 46);
            this.btRight.TabIndex = 33;
            this.btRight.Text = "→";
            this.btRight.UseVisualStyleBackColor = true;
            // 
            // btLeft
            // 
            this.btLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLeft.Location = new System.Drawing.Point(33, 299);
            this.btLeft.Name = "btLeft";
            this.btLeft.Size = new System.Drawing.Size(54, 46);
            this.btLeft.TabIndex = 32;
            this.btLeft.Text = "←";
            this.btLeft.UseVisualStyleBackColor = true;
            // 
            // btDownRight
            // 
            this.btDownRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDownRight.Location = new System.Drawing.Point(150, 351);
            this.btDownRight.Name = "btDownRight";
            this.btDownRight.Size = new System.Drawing.Size(54, 46);
            this.btDownRight.TabIndex = 36;
            this.btDownRight.Text = "↘";
            this.btDownRight.UseVisualStyleBackColor = true;
            // 
            // btDownLeft
            // 
            this.btDownLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDownLeft.Location = new System.Drawing.Point(33, 351);
            this.btDownLeft.Name = "btDownLeft";
            this.btDownLeft.Size = new System.Drawing.Size(54, 46);
            this.btDownLeft.TabIndex = 35;
            this.btDownLeft.Text = "↙";
            this.btDownLeft.UseVisualStyleBackColor = true;
            // 
            // btDown
            // 
            this.btDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDown.Location = new System.Drawing.Point(90, 351);
            this.btDown.Name = "btDown";
            this.btDown.Size = new System.Drawing.Size(54, 46);
            this.btDown.TabIndex = 34;
            this.btDown.Text = "↓";
            this.btDown.UseVisualStyleBackColor = true;
            // 
            // btLoad
            // 
            this.btLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLoad.Location = new System.Drawing.Point(127, 427);
            this.btLoad.Name = "btLoad";
            this.btLoad.Size = new System.Drawing.Size(77, 37);
            this.btLoad.TabIndex = 38;
            this.btLoad.Text = "Load";
            this.btLoad.UseVisualStyleBackColor = true;
            this.btLoad.Click += new System.EventHandler(this.BtLoad_Click);
            // 
            // btSave
            // 
            this.btSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSave.Location = new System.Drawing.Point(33, 427);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(77, 37);
            this.btSave.TabIndex = 39;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.BtSave_Click);
            // 
            // listBoxShapes
            // 
            this.listBoxShapes.FormattingEnabled = true;
            this.listBoxShapes.Location = new System.Drawing.Point(33, 489);
            this.listBoxShapes.Name = "listBoxShapes";
            this.listBoxShapes.Size = new System.Drawing.Size(883, 199);
            this.listBoxShapes.TabIndex = 40;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 707);
            this.Controls.Add(this.listBoxShapes);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.btLoad);
            this.Controls.Add(this.btDownRight);
            this.Controls.Add(this.btDownLeft);
            this.Controls.Add(this.btDown);
            this.Controls.Add(this.btRight);
            this.Controls.Add(this.btLeft);
            this.Controls.Add(this.btUpRight);
            this.Controls.Add(this.btUpLeft);
            this.Controls.Add(this.btUp);
            this.Controls.Add(this.panelDraw);
            this.Controls.Add(this.rbCircle);
            this.Controls.Add(this.rbEllipses);
            this.Controls.Add(this.rbSquare);
            this.Controls.Add(this.rbRectangle);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.Radius);
            this.Controls.Add(this.yRadius);
            this.Controls.Add(this.xRadius);
            this.Controls.Add(this.Side);
            this.Controls.Add(this.Length);
            this.Controls.Add(this.Height);
            this.Controls.Add(this.txShapes);
            this.Controls.Add(this.sColor);
            this.Controls.Add(this.bColor);
            this.Controls.Add(this.yCoord);
            this.Controls.Add(this.xCoor);
            this.Controls.Add(this.btDraw);
            this.Controls.Add(this.cbSColor);
            this.Controls.Add(this.cbBColor);
            this.Controls.Add(this.tbRadius);
            this.Controls.Add(this.tbYRadius);
            this.Controls.Add(this.tbXRadius);
            this.Controls.Add(this.tbSide);
            this.Controls.Add(this.tbLength);
            this.Controls.Add(this.tbHeight);
            this.Controls.Add(this.tbYCoord);
            this.Controls.Add(this.tbXCoord);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbXCoord;
        private System.Windows.Forms.TextBox tbYCoord;
        private System.Windows.Forms.TextBox tbHeight;
        private System.Windows.Forms.TextBox tbLength;
        private System.Windows.Forms.TextBox tbSide;
        private System.Windows.Forms.TextBox tbXRadius;
        private System.Windows.Forms.TextBox tbYRadius;
        private System.Windows.Forms.TextBox tbRadius;
        private System.Windows.Forms.ComboBox cbBColor;
        private System.Windows.Forms.ComboBox cbSColor;
        private System.Windows.Forms.Button btDraw;
        private System.Windows.Forms.Label xCoor;
        private System.Windows.Forms.Label yCoord;
        private System.Windows.Forms.Label bColor;
        private System.Windows.Forms.Label sColor;
        private System.Windows.Forms.Label txShapes;
        private System.Windows.Forms.Label Height;
        private System.Windows.Forms.Label Length;
        private System.Windows.Forms.Label Side;
        private System.Windows.Forms.Label xRadius;
        private System.Windows.Forms.Label yRadius;
        private System.Windows.Forms.Label Radius;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.RadioButton rbRectangle;
        private System.Windows.Forms.RadioButton rbSquare;
        private System.Windows.Forms.RadioButton rbEllipses;
        private System.Windows.Forms.RadioButton rbCircle;
        private System.Windows.Forms.Panel panelDraw;
        private System.Windows.Forms.Button btUp;
        private System.Windows.Forms.Button btUpLeft;
        private System.Windows.Forms.Button btUpRight;
        private System.Windows.Forms.Button btRight;
        private System.Windows.Forms.Button btLeft;
        private System.Windows.Forms.Button btDownRight;
        private System.Windows.Forms.Button btDownLeft;
        private System.Windows.Forms.Button btDown;
        private System.Windows.Forms.Button btLoad;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.ListBox listBoxShapes;
    }
}

