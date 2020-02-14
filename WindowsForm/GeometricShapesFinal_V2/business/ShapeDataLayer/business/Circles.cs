using System;
using System.Drawing;
using System.Windows.Forms;

namespace ShapesDataLayer.business
{
    [Serializable]
    public class Circles : Shapes
    {
        //class related attributes
        private double radius;

        //base class related attributes
        private int xCoord;
        private int yCoord;
        private EnumShapeType shapeType;
        private EnumBrushingColor brushColor;
        private EnumBorderColor borderColor;

        //attributes properties
        public double Radius { get => radius; set => radius = value; }
        public int XCoord { get => xCoord; set => xCoord = value; }
        public int YCoord { get => yCoord; set => yCoord = value; }
        public EnumShapeType ShapeType { get => shapeType; set => shapeType = value; }
        public EnumBrushingColor BrushColor { get => brushColor; set => brushColor = value; }
        public EnumBorderColor BorderColor { get => borderColor; set => borderColor = value; }
        public override double area { get => getArea(); }
        public override double circunference { get => getCircunference(); }

        //constructors
        public Circles() : base()
        {
            this.Radius = 00;
        }
        public Circles(int x, int y, double radius, EnumShapeType type, EnumBrushingColor brushcolor, EnumBorderColor bordercolor)
        {
            this.Radius = radius;
            this.xCoord = x;
            this.yCoord = y;
            this.shapeType = type;
            this.brushColor = brushcolor;
            this.borderColor = bordercolor;
        }
        public Circles(double radius) : base()
        {
            this.Radius = radius;
        }

        //base class methods for lambda expression
        public override double getArea()
        {
            return Math.Pow(this.Radius, 2)*Math.PI;
        }
        public override double getCircunference()
        {
            return 2*Math.PI*this.Radius;
        }

        //base class drawing methods
        public override void Draw(PaintEventArgs e)
        {
            Color brColor = Color.FromName(Convert.ToString(this.brushColor));
            Color boColor = Color.FromName(Convert.ToString(this.borderColor));
            Pen myPen = new Pen(boColor, 2);
            Brush myBrush = new SolidBrush(brColor);

            e.Graphics.DrawEllipse(myPen, this.xCoord, this.yCoord, Convert.ToInt32(this.Radius), Convert.ToInt32(this.Radius));
            e.Graphics.FillEllipse(myBrush, this.xCoord, this.yCoord, Convert.ToInt32(this.Radius), Convert.ToInt32(this.Radius));

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

            e.Graphics.DrawEllipse(myPen, this.xCoord, this.yCoord, Convert.ToInt32(this.Radius), Convert.ToInt32(this.Radius));
            e.Graphics.FillEllipse(myBrush, this.xCoord, this.yCoord, Convert.ToInt32(this.Radius), Convert.ToInt32(this.Radius));

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

            e.Graphics.DrawEllipse(myPen, this.xCoord, this.yCoord, Convert.ToInt32(this.Radius), Convert.ToInt32(this.Radius));
            e.Graphics.FillEllipse(myBrush, this.xCoord, this.yCoord, Convert.ToInt32(this.Radius), Convert.ToInt32(this.Radius));

            myPen.Dispose();
            myBrush.Dispose();
            e.Dispose();
        }

        //base class moving methods
        #region
        public override void moveUp(int dy)
        {
            if (this.yCoord > 0 + this.Radius)
            {
                this.yCoord = this.yCoord - dy;
            }
        }
        public override void moveDown(int dy)
        {
            if (this.yCoord <= 309 - this.Radius)
            {
                this.yCoord = this.yCoord + dy;
            }
        }
        public override void moveLeft(int dx)
        {
            if (this.xCoord > 0 + this.Radius)
            {
                this.xCoord = this.xCoord - dx;
            }
        }
        public override void moveRight(int dx)
        {
            if (this.xCoord <= 690 - this.Radius)
            {
                this.xCoord = this.xCoord + dx;
            }
        }

        public override void moveUpLeft(int dy, int dx)
        {
            if ((this.xCoord > 0 + this.Radius) && (this.yCoord > 0 + this.Radius))
            {
                this.yCoord = this.yCoord - dy;
                this.xCoord = this.xCoord - dx;
            }
        }
        public override void moveUpRight(int dy, int dx)
        {
            if ((this.yCoord > 0 + this.Radius) && (this.xCoord <= 690 - this.Radius))
            {
                this.yCoord = this.yCoord - dy;
                this.xCoord = this.xCoord + dx;
            }
        }
        public override void moveDownLeft(int dy, int dx)
        {
            if ((this.xCoord > 0 + this.Radius) && (this.yCoord <= 309 - this.Radius))
            {
                this.yCoord = this.yCoord + dy;
                this.xCoord = this.xCoord - dx;
            }
        }
        public override void moveDownRight(int dy, int dx)
        {
            if ((this.xCoord <= 690 - this.Radius) && (this.yCoord <= 309 - this.Radius))
            {
                this.yCoord = this.yCoord + dy;
                this.xCoord = this.xCoord + dx;
            }
        }
        #endregion

        //override ToString
        public override string ToString()
        {
            return ($"{Convert.ToString(this.shapeType)} - (x/y): ({this.xCoord}/{this.yCoord}) - Area: {this.area} - Circunference: {this.circunference} - Radius: {this.Radius}");
        }
    }
}
