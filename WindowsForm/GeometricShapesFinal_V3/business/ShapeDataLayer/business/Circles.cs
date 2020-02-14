using System;
using System.Drawing;
using System.Windows.Forms;

namespace ShapesDataLayer.business
{
    //2.2
    [Serializable]
    public class Circles : Shapes
    {
        //class related attributes
        private double radius;

        //attributes properties
        #region ##properties##
        public double Radius { get => radius; set => radius = value; }
        

        public override double area { get => getArea(); }
        public override double circunference { get => getCircunference(); }
        #endregion

        //constructors
        #region ##constructors##
        public Circles() : base()
        {
            this.Radius = 00;
        }

        public Circles(double radius) : base()
        {
            this.Radius = radius;
        }
        #endregion

        //base class methods for lambda expression using child class attribute
        #region ##methods##
        public override double getArea()
        {
            return Math.Pow(this.Radius, 2)*Math.PI;
        }
        public override double getCircunference()
        {
            return 2*Math.PI*this.Radius;
        }
        #endregion

        //class override drawing methods using child class attribute
        #region ##methods##
        public override void Draw(PaintEventArgs e)
        {
            Color brColor = Color.FromName(Convert.ToString(BrushColor));
            Color boColor = Color.FromName(Convert.ToString(BorderColor));
            Pen myPen = new Pen(boColor, 2);
            Brush myBrush = new SolidBrush(brColor);

            e.Graphics.DrawEllipse(myPen, XCoord, YCoord, Convert.ToInt32(this.Radius), Convert.ToInt32(this.Radius));
            e.Graphics.FillEllipse(myBrush, XCoord, YCoord, Convert.ToInt32(this.Radius), Convert.ToInt32(this.Radius));

            myPen.Dispose();
            myBrush.Dispose();
            e.Dispose();
        }
        public override void Draw(PaintEventArgs e, string brushColor)
        {
            Color brColor = Color.FromName(brushColor);
            Color boColor = Color.FromName(Convert.ToString(BorderColor));
            Pen myPen = new Pen(boColor);
            Brush myBrush = new SolidBrush(boColor);

            e.Graphics.DrawEllipse(myPen, XCoord, YCoord, Convert.ToInt32(this.Radius), Convert.ToInt32(this.Radius));
            e.Graphics.FillEllipse(myBrush, XCoord, YCoord, Convert.ToInt32(this.Radius), Convert.ToInt32(this.Radius));

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

            e.Graphics.DrawEllipse(myPen, XCoord, YCoord, Convert.ToInt32(this.Radius), Convert.ToInt32(this.Radius));
            e.Graphics.FillEllipse(myBrush, XCoord, YCoord, Convert.ToInt32(this.Radius), Convert.ToInt32(this.Radius));

            myPen.Dispose();
            myBrush.Dispose();
            e.Dispose();
        }
        #endregion

        //base class moving methods
        #region ##methods##
        public override void moveUp(int dy)
        {
            if (YCoord > 0 + this.Radius)
            {
                YCoord = YCoord - dy;
            }
        }
        public override void moveDown(int dy)
        {
            if (YCoord <= 309 - this.Radius)
            {
                YCoord = YCoord + dy;
            }
        }
        public override void moveLeft(int dx)
        {
            if (XCoord > 0 + this.Radius)
            {
                XCoord = XCoord - dx;
            }
        }
        public override void moveRight(int dx)
        {
            if (XCoord <= 690 - this.Radius)
            {
                XCoord = XCoord + dx;
            }
        }

        public override void moveUpLeft(int dy, int dx)
        {
            if ((XCoord > 0 + this.Radius) && (YCoord > 0 + this.Radius))
            {
                YCoord = YCoord - dy;
                XCoord = XCoord - dx;
            }
        }
        public override void moveUpRight(int dy, int dx)
        {
            if ((YCoord > 0 + this.Radius) && (XCoord <= 690 - this.Radius))
            {
                YCoord = YCoord - dy;
                XCoord = XCoord + dx;
            }
        }
        public override void moveDownLeft(int dy, int dx)
        {
            if ((XCoord > 0 + this.Radius) && (YCoord <= 309 - this.Radius))
            {
                YCoord = YCoord + dy;
                XCoord = XCoord - dx;
            }
        }
        public override void moveDownRight(int dy, int dx)
        {
            if ((XCoord <= 690 - this.Radius) && (YCoord <= 309 - this.Radius))
            {
                YCoord = YCoord + dy;
                XCoord = XCoord + dx;
            }
        }
#endregion

        //override ToString
        public override string ToString()
        {
            return ($"{Convert.ToString(ShapeType)} - (x/y): ({XCoord}/{YCoord}) - Area: {this.area} - Circunference: {this.circunference} - Radius: {this.Radius}");
        }
    }
}
