using System;
using System.Windows.Forms;
using System.Drawing;

namespace ShapesDataLayer.business
{
    [Serializable]
    public class Squares : Shapes
    {
        //class related attributes
        private double side;

        //base class related attributes
        private int xCoord;
        private int yCoord;
        private EnumShapeType shapeType;
        private EnumBrushingColor brushColor;
        private EnumBorderColor borderColor;

        //attributes properties
        public double Side { get => side; set => side = value; }
        public int XCoord { get => xCoord; set => xCoord = value; }
        public int YCoord { get => yCoord; set => yCoord = value; }
        public EnumShapeType ShapeType { get => shapeType; set => shapeType = value; }
        public EnumBrushingColor BrushColor { get => brushColor; set => brushColor = value; }
        public EnumBorderColor BorderColor { get => borderColor; set => borderColor = value; }
        public override double area { get => getArea(); }
        public override double circunference { get => getCircunference(); }

        //constructors
        public Squares() : base()
        {
            this.side = 00;
        }
        public Squares(int x, int y, double side, EnumShapeType type, EnumBrushingColor brushcolor, EnumBorderColor bordercolor)
        {
            this.side = side;
            this.xCoord = x;
            this.yCoord = y;
            this.shapeType = type;
            this.brushColor = brushcolor;
            this.borderColor = bordercolor;
        }
        public Squares(double side) : base()
        {
            this.side = side;
        }

        //base class methods for lambda expression
        public override double getArea()
        {
            return Math.Pow(this.side, 2);
        }
        public override double getCircunference()
        {
            return Math.Pow(this.side, 4);
        }

        //base class drawing methods
        public override void Draw(PaintEventArgs e)
        {
            Color brColor = Color.FromName(Convert.ToString(this.brushColor));
            Color boColor = Color.FromName(Convert.ToString(this.borderColor));
            Pen myPen = new Pen(boColor,2);
            Brush myBrush = new SolidBrush(brColor);

            e.Graphics.DrawRectangle(myPen, this.xCoord, this.yCoord, Convert.ToInt32(this.side), Convert.ToInt32(this.side));
            e.Graphics.FillRectangle(myBrush, this.xCoord, this.yCoord, Convert.ToInt32(this.side), Convert.ToInt32(this.side));

            myPen.Dispose();
            myBrush.Dispose();
            e.Dispose();
        }
        public override void Draw(PaintEventArgs e, string brushColor)
        {
            Color brColor = Color.FromName(brushColor);
            Color boColor = Color.FromName(Convert.ToString(this.borderColor));
            Pen myPen = new Pen(boColor);
            Brush myBrush = new SolidBrush(boColor);

            e.Graphics.DrawRectangle(myPen, this.xCoord, this.yCoord, Convert.ToInt32(this.side), Convert.ToInt32(this.side));
            e.Graphics.FillRectangle(myBrush, this.xCoord, this.yCoord, Convert.ToInt32(this.side), Convert.ToInt32(this.side));

            myPen.Dispose();
            myBrush.Dispose();
            e.Dispose();

        }
        public override void Draw(PaintEventArgs e, string brushColor, string borderColor)
        {
            Color brColor = Color.FromName(brushColor);
            Color boColor = Color.FromName(borderColor);
            Pen myPen = new Pen(boColor);
            Brush myBrush = new SolidBrush(boColor);

            e.Graphics.DrawRectangle(myPen, this.xCoord, this.yCoord, Convert.ToInt32(this.side), Convert.ToInt32(this.side));
            e.Graphics.FillRectangle(myBrush, this.xCoord, this.yCoord, Convert.ToInt32(this.side), Convert.ToInt32(this.side));

            myPen.Dispose();
            myBrush.Dispose();
            e.Dispose();
        }

        //base class moving methods
        #region
        public override void moveUp(int dy)
        {
            if (this.yCoord > 0 + this.side)
            {
                this.yCoord = this.yCoord - dy;
            }
        }
        public override void moveDown(int dy)
        {
            if (this.yCoord <= 309 - this.side)
            {
                this.yCoord = this.yCoord + dy;
            }
        }
        public override void moveLeft(int dx)
        {
            if (this.xCoord > 0 + this.side)
            {
                this.xCoord = this.xCoord - dx;
            }
        }
        public override void moveRight(int dx)
        {
            if (this.xCoord <= 690 - this.side)
            {
                this.xCoord = this.xCoord + dx;
            }
        }

        public override void moveUpLeft(int dy, int dx)
        {
            if ((this.xCoord > 0 + this.side)&&(this.yCoord > 0 + this.side))
            {
                this.yCoord = this.yCoord - dy;
                this.xCoord = this.xCoord - dx;
            }
        }
        public override void moveUpRight(int dy, int dx)
        {
            if ((this.yCoord > 0 + this.side)&&(this.xCoord <= 690 - this.side))
            {
                this.yCoord = this.yCoord - dy;
                this.xCoord = this.xCoord + dx;
            }
        }
        public override void moveDownLeft(int dy, int dx)
        {
            if ((this.xCoord > 0 + this.side)&&(this.yCoord <= 309 - this.side))
            {
                this.yCoord = this.yCoord + dy;
                this.xCoord = this.xCoord - dx;
            }
        }
        public override void moveDownRight(int dy, int dx)
        {
            if ((this.xCoord <= 690 - this.side)&&(this.yCoord <= 309 - this.side))
            {
                this.yCoord = this.yCoord + dy;
                this.xCoord = this.xCoord + dx;
            }
        }
        #endregion

        //override ToString
        public override string ToString()
        {
            return ($"{Convert.ToString(this.shapeType)} - (x/y): ({this.xCoord}/{this.yCoord}) - Area: {this.area} - Circunference: {this.circunference} - Side: {this.side}");
        }
    }
}
