using System;
using System.Drawing;
using System.Windows.Forms;

namespace ShapesDataLayer.business
{
    [Serializable]
    public class Ellipses : Circles
    {
        //class related attributes
        private double xRadius;
        private double yRadius;

        //base class related attributes
        private int xCoord;
        private int yCoord;
        private EnumShapeType shapeType;
        private EnumBrushingColor brushColor;
        private EnumBorderColor borderColor;

        //attributes properties
        public double XRadius { get => xRadius; set => xRadius = value; }
        public double YRadius { get => yRadius; set => yRadius = value; }
        public int XCoord { get => xCoord; set => xCoord = value; }
        public int YCoord { get => yCoord; set => yCoord = value; }
        public EnumShapeType ShapeType { get => shapeType; set => shapeType = value; }
        public EnumBrushingColor BrushColor { get => brushColor; set => brushColor = value; }
        public EnumBorderColor BorderColor { get => borderColor; set => borderColor = value; }
        public override double area { get => getArea(); }
        public override double circunference { get => getCircunference(); }

        //constructors
        public Ellipses() : base()
        {
            this.xRadius = 00;
            this.yRadius = 00;
        }
        public Ellipses(int x, int y, double yradius, double xradius, EnumShapeType type, EnumBrushingColor brushcolor, EnumBorderColor bordercolor)
        {
            this.xRadius = xradius;
            this.yRadius = yradius;
            this.xCoord = x;
            this.yCoord = y;
            this.shapeType = type;
            this.brushColor = brushcolor;
            this.borderColor = bordercolor;
        }
        public Ellipses(double xradius, double yradius) : base()
        {
            this.xRadius = xradius;
            this.yRadius = yradius;
        }

        //base class methods for lambda expression
        public override double getArea()
        {
            return Math.PI*this.xRadius*this.yRadius;
        }
        public override double getCircunference()
        {
            return Math.PI * (3 * (this.xRadius + this.yRadius) - Math.Sqrt(((3 * this.xRadius) + this.yRadius) * (this.xRadius + ((3 * this.yRadius)))));
        }

        //base class drawing methods
        public override void Draw(PaintEventArgs e)
        {
            Color brColor = Color.FromName(Convert.ToString(this.brushColor));
            Color boColor = Color.FromName(Convert.ToString(this.borderColor));
            Pen myPen = new Pen(boColor, 2);
            Brush myBrush = new SolidBrush(brColor);

            e.Graphics.DrawEllipse(myPen, this.xCoord, this.yCoord, Convert.ToInt32(this.xRadius), Convert.ToInt32(this.yRadius));
            e.Graphics.FillEllipse(myBrush, this.xCoord, this.yCoord, Convert.ToInt32(this.xRadius), Convert.ToInt32(this.yRadius));

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

            e.Graphics.DrawEllipse(myPen, this.xCoord, this.yCoord, Convert.ToInt32(this.xRadius), Convert.ToInt32(this.yRadius));
            e.Graphics.FillEllipse(myBrush, this.xCoord, this.yCoord, Convert.ToInt32(this.xRadius), Convert.ToInt32(this.yRadius));

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

            e.Graphics.DrawEllipse(myPen, this.xCoord, this.yCoord, Convert.ToInt32(this.xRadius), Convert.ToInt32(this.yRadius));
            e.Graphics.FillEllipse(myBrush, this.xCoord, this.yCoord, Convert.ToInt32(this.xRadius), Convert.ToInt32(this.yRadius));

            myPen.Dispose();
            myBrush.Dispose();
            e.Dispose();
        }

        //base class moving methods
        #region
        public override void moveUp(int dy)
        {
            if (this.yCoord > 0 + this.yRadius)
            {
                this.yCoord = this.yCoord - dy;
            }
        }
        public override void moveDown(int dy)
        {
            if (this.yCoord <= 309 - this.yRadius)
            {
                this.yCoord = this.yCoord + dy;
            }
        }
        public override void moveLeft(int dx)
        {
            if (this.xCoord > 0 + this.xRadius)
            {
                this.xCoord = this.xCoord - dx;
            }
        }
        public override void moveRight(int dx)
        {
            if (this.xCoord <= 690 - this.xRadius)
            {
                this.xCoord = this.xCoord + dx;
            }
        }

        public override void moveUpLeft(int dy, int dx)
        {
            if ((this.xCoord > 0 + this.xRadius) && (this.yCoord > 0 + this.yRadius))
            {
                this.yCoord = this.yCoord - dy;
                this.xCoord = this.xCoord - dx;
            }
        }
        public override void moveUpRight(int dy, int dx)
        {
            if ((this.yCoord > 0 + this.yRadius) && (this.xCoord <= 690 - this.xRadius))
            {
                this.yCoord = this.yCoord - dy;
                this.xCoord = this.xCoord + dx;
            }
        }
        public override void moveDownLeft(int dy, int dx)
        {
            if ((this.xCoord > 0 + this.xRadius) && (this.yCoord <= 309 - this.yRadius))
            {
                this.yCoord = this.yCoord + dy;
                this.xCoord = this.xCoord - dx;
            }
        }
        public override void moveDownRight(int dy, int dx)
        {
            if ((this.xCoord <= 690 - this.xRadius) && (this.yCoord <= 309 - this.yRadius))
            {
                this.yCoord = this.yCoord + dy;
                this.xCoord = this.xCoord + dx;
            }
        }
        #endregion

        //override ToString
        public override string ToString()
        {
            return ($"{Convert.ToString(this.shapeType)} - (x/y): ({this.xCoord}/{this.yCoord}) - Area: {this.area} - Circunference: {this.circunference} - xRadius: {this.xRadius} - yRadius: {this.yRadius}");
        }
    }
}
