using System;
using System.Drawing;
using System.Windows.Forms;

namespace ShapesDataLayer.business
{
    //2.2
    [Serializable]
    public class Rectangles : Squares
    {
        //class related attributes
        private double height;
        private double length;

        //attributes properties
        #region ##properties##
        public double Height { get => height; set => height = value; }
        public double Length { get => length; set => length = value; }

        public override double area { get => getArea(); }
        public override double circunference { get => getCircunference(); }
        #endregion

        //constructors
        #region ##constructors##
        public Rectangles() : base()
        {
            this.height = 00;
            this.length = 00;
        }
        public Rectangles(double height, double length) : base()
        {
            this.height = height;
            this.length = length;
        }
        #endregion

        //base class methods for lambda expression using child class attribute
        #region ##methods##
        public override double getArea()
        {
            return (this.height * this.length);
        }
        public override double getCircunference()
        {
            return (this.height * this.length) * 2;
        }
        #endregion

        //base class drawing methods using child class attribute
        #region ##methods##
        public override void Draw(PaintEventArgs e)
        {
            Color brColor = Color.FromName(Convert.ToString(BrushColor));
            Color boColor = Color.FromName(Convert.ToString(BorderColor));
            Pen myPen = new Pen(boColor, 2);
            Brush myBrush = new SolidBrush(brColor);

            e.Graphics.DrawRectangle(myPen, XCoord, YCoord, Convert.ToInt32(this.length), Convert.ToInt32(this.height));
            e.Graphics.FillRectangle(myBrush, XCoord, YCoord, Convert.ToInt32(this.length), Convert.ToInt32(this.height));

            myPen.Dispose();
            myBrush.Dispose();
            e.Dispose();
        }
        public override void Draw(PaintEventArgs e, string brushColor)
        {
            Color brColor = Color.FromName(brushColor);
            Color boColor = Color.FromName(Convert.ToString(BorderColor));
            Pen myPen = new Pen(boColor, 2);
            Brush myBrush = new SolidBrush(brColor);

            e.Graphics.DrawRectangle(myPen, XCoord, YCoord, Convert.ToInt32(this.length), Convert.ToInt32(this.height));
            e.Graphics.FillRectangle(myBrush, XCoord, YCoord, Convert.ToInt32(this.length), Convert.ToInt32(this.height));

            myPen.Dispose();
            myBrush.Dispose();
            e.Dispose();

        }
        public override void Draw(PaintEventArgs e, string brushColor, string borderColor)
        {
            Color brColor = Color.FromName(brushColor);
            Color boColor = Color.FromName(borderColor);
            Pen myPen = new Pen(boColor, 2);
            Brush myBrush = new SolidBrush(brColor);

            e.Graphics.DrawRectangle(myPen, XCoord, YCoord, Convert.ToInt32(this.length), Convert.ToInt32(this.height));
            e.Graphics.FillRectangle(myBrush, XCoord, YCoord, Convert.ToInt32(this.length), Convert.ToInt32(this.height));

            myPen.Dispose();
            myBrush.Dispose();
            e.Dispose();
        }
        #endregion

        //base class moving methods
        #region ##methods##
        public override void moveUp(int dy)
        {
            if (YCoord > 0 + this.Height)
            {
                YCoord = YCoord - dy;
            }
        }
        public override void moveDown(int dy)
        {
            if (YCoord <= 309 - this.Height)
            {
                YCoord = YCoord + dy;
            }
        }
        public override void moveLeft(int dx)
        {
            if (XCoord > 0 + this.length)
            {
                XCoord = XCoord - dx;
            }
        }
        public override void moveRight(int dx)
        {
            if (XCoord <= 690 - this.length)
            {
                XCoord = XCoord + dx;
            }
        }

        public override void moveUpLeft(int dy, int dx)
        {
            if ((XCoord > 0 + this.length) && (XCoord > 0 + this.height))
            {
                YCoord = YCoord - dy;
                XCoord = XCoord - dx;
            }
        }
        public override void moveUpRight(int dy, int dx)
        {
            if ((YCoord > 0 + this.height) && (XCoord <= 690 - this.length))
            {
                YCoord = YCoord - dy;
                XCoord = XCoord + dx;
            }
        }
        public override void moveDownLeft(int dy, int dx)
        {
            if ((XCoord > 0 + this.length) && (YCoord <= 309 - this.height))
            {
                YCoord = YCoord + dy;
                XCoord = XCoord - dx;
            }
        }
        public override void moveDownRight(int dy, int dx)
        {
            if ((XCoord <= 690 - this.length) && (YCoord <= 309 - this.height))
            {
                YCoord = YCoord + dy;
                XCoord = XCoord + dx;
            }
        }
        #endregion

        //override ToString
        public override string ToString()
        {
            return ($"{Convert.ToString(ShapeType)} - (x/y): ({XCoord}/{YCoord}) - Area: {this.area} - Circunference: {this.circunference} - Height: {this.Height} - Length: {this.length}");
        }
    }
}
