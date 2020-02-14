using System;
using System.Drawing;
using System.Windows.Forms;

namespace ShapesDataLayer.business
{
    //2.2
    [Serializable]
    public class Ellipses : Circles
    {
        //class related attributes
        private double xRadius;
        private double yRadius;

        //attributes properties
        #region ##properties##
        public double YRadius { get => yRadius; set => yRadius = value; }
        public double XRadius { get => xRadius; set => xRadius = value; }
        public override double area { get => getArea(); }
        public override double circunference { get => getCircunference(); }
        #endregion

        //constructors
        #region ##constructors##
        public Ellipses() : base()
        {
            this.XRadius = 00;
            this.YRadius = 00;
        }

        public Ellipses(double xradius, double yradius) : base()
        {
            this.XRadius = xradius;
            this.YRadius = yradius;
        }
        #endregion

        //base class methods for lambda expression using child class attribute
        #region ##methods##
        public override double getArea()
        {
            return Math.PI*this.XRadius*this.YRadius;
        }
        public override double getCircunference()
        {
            return Math.PI * (3 * (this.XRadius + this.YRadius) - Math.Sqrt(((3 * this.XRadius) + this.YRadius) * (this.XRadius + ((3 * this.YRadius)))));
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

            e.Graphics.DrawEllipse(myPen, XCoord, YCoord, Convert.ToInt32(this.XRadius), Convert.ToInt32(this.YRadius));
            e.Graphics.FillEllipse(myBrush, XCoord, YCoord, Convert.ToInt32(this.XRadius), Convert.ToInt32(this.YRadius));

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

            e.Graphics.DrawEllipse(myPen, XCoord, YCoord, Convert.ToInt32(this.XRadius), Convert.ToInt32(this.YRadius));
            e.Graphics.FillEllipse(myBrush, XCoord, YCoord, Convert.ToInt32(this.XRadius), Convert.ToInt32(this.YRadius));

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

            e.Graphics.DrawEllipse(myPen, XCoord, YCoord, Convert.ToInt32(this.XRadius), Convert.ToInt32(this.YRadius));
            e.Graphics.FillEllipse(myBrush, XCoord, YCoord, Convert.ToInt32(this.XRadius), Convert.ToInt32(this.YRadius));

            myPen.Dispose();
            myBrush.Dispose();
            e.Dispose();
        }
        #endregion

        //base class moving methods
        #region ##methods##
        public override void moveUp(int dy)
        {
            if (YCoord > 0 + this.YRadius)
            {
                YCoord = YCoord - dy;
            }
        }
        public override void moveDown(int dy)
        {
            if (YCoord <= 309 - this.YRadius)
            {
                YCoord = YCoord + dy;
            }
        }
        public override void moveLeft(int dx)
        {
            if (XCoord > 0 + this.XRadius)
            {
                XCoord = XCoord - dx;
            }
        }
        public override void moveRight(int dx)
        {
            if (XCoord <= 690 - this.XRadius)
            {
                XCoord = XCoord + dx;
            }
        }

        public override void moveUpLeft(int dy, int dx)
        {
            if ((XCoord > 0 + this.XRadius) && (XCoord > 0 + this.YRadius))
            {
                YCoord = YCoord - dy;
                XCoord = XCoord - dx;
            }
        }
        public override void moveUpRight(int dy, int dx)
        {
            if ((YCoord > 0 + this.YRadius) && (XCoord <= 690 - this.XRadius))
            {
                YCoord = YCoord - dy;
                XCoord = XCoord + dx;
            }
        }
        public override void moveDownLeft(int dy, int dx)
        {
            if ((XCoord > 0 + this.XRadius) && (YCoord <= 309 - this.YRadius))
            {
                YCoord = YCoord + dy;
                XCoord = XCoord - dx;
            }
        }
        public override void moveDownRight(int dy, int dx)
        {
            if ((XCoord <= 690 - this.XRadius) && (YCoord <= 309 - this.YRadius))
            {
                YCoord = YCoord + dy;
                XCoord = XCoord + dx;
            }
        }
        #endregion

        //override ToString
        public override string ToString()
        {
            return ($"{Convert.ToString(ShapeType)} - (x/y): ({XCoord}/{YCoord}) - Area: {this.area} - Circunference: {this.circunference} - Height: {this.YRadius} - Length: {this.XRadius}");
        }
    }
}
