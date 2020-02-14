using System;
using System.Windows.Forms;
using System.Drawing;

namespace ShapesDataLayer.business
{
    //2.2
    [Serializable]
    public class Squares : Shapes
    {
        //class related attributes
        private double side;

        //Properties and Prop. Override
        #region ##properties##
        public override double area { get => getArea(); }
        public override double circunference { get => getCircunference(); }
        public double Side { get => side; set => side = value; }
        #endregion

        //constructors
        #region ##constructors##
        public Squares() : base()
        {
            this.Side = 00;
            
        }
        public Squares(double side) : base()
        {
            this.Side = side;
        }
        #endregion

        //base class methods for lambda expression using child class attribute
        #region ##methods##
        public override double getArea()
        {
            return Math.Pow(this.Side, 2);
        }
        public override double getCircunference()
        {
            return Math.Pow(this.Side, 4);
        }
        #endregion

        //base class override methods using chidl class attributes
        #region ##methods##
        public override void Draw(PaintEventArgs e)
        {
            Color brColor = Color.FromName(Convert.ToString(BrushColor));
            Color boColor = Color.FromName(Convert.ToString(BorderColor));
            Pen myPen = new Pen(boColor,2);
            Brush myBrush = new SolidBrush(brColor);

            e.Graphics.DrawRectangle(myPen, XCoord, YCoord, Convert.ToInt32(this.Side), Convert.ToInt32(this.Side));
            e.Graphics.FillRectangle(myBrush, XCoord, YCoord, Convert.ToInt32(this.Side), Convert.ToInt32(this.Side));

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

            e.Graphics.DrawRectangle(myPen, XCoord, YCoord, Convert.ToInt32(this.Side), Convert.ToInt32(this.Side));
            e.Graphics.FillRectangle(myBrush, XCoord, YCoord, Convert.ToInt32(this.Side), Convert.ToInt32(this.Side));

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

            e.Graphics.DrawRectangle(myPen, XCoord, YCoord, Convert.ToInt32(this.Side), Convert.ToInt32(this.Side));
            e.Graphics.FillRectangle(myBrush, XCoord, YCoord, Convert.ToInt32(this.Side), Convert.ToInt32(this.Side));

            myPen.Dispose();
            myBrush.Dispose();
            e.Dispose();
        }
        #endregion

        //base class moving methods
        #region ##methods##
        public override void moveUp(int dy)
        {
            if (YCoord > 0 + this.Side)
            {
                YCoord = YCoord - dy;
            }
        }
        public override void moveDown(int dy)
        {
            if (YCoord <= 309 - this.Side)
            {
                YCoord = YCoord + dy;
            }
        }
        public override void moveLeft(int dx)
        {
            if (XCoord > 0 + this.Side)
            {
                XCoord = XCoord - dx;
            }
        }
        public override void moveRight(int dx)
        {
            if (XCoord <= 690 - this.Side)
            {
                XCoord = XCoord + dx;
            }
        }

        public override void moveUpLeft(int dy, int dx)
        {
            if ((XCoord > 0 + this.Side)&&(YCoord > 0 + this.Side))
            {
                YCoord = YCoord - dy;
                XCoord = XCoord - dx;
            }
        }
        public override void moveUpRight(int dy, int dx)
        {
            if ((YCoord > 0 + this.Side)&&(XCoord <= 690 - this.Side))
            {
                YCoord = YCoord - dy;
                XCoord = XCoord + dx;
            }
        }
        public override void moveDownLeft(int dy, int dx)
        {
            if ((XCoord > 0 + this.Side)&&(YCoord <= 309 - this.Side))
            {
                YCoord = YCoord + dy;
                XCoord = XCoord - dx;
            }
        }
        public override void moveDownRight(int dy, int dx)
        {
            if ((XCoord <= 690 - this.Side)&&(YCoord <= 309 - this.Side))
            {
                YCoord = YCoord + dy;
                XCoord = XCoord + dx;
            }
        }
        #endregion

        //override ToString
        public override string ToString()
        {
            return ($"{Convert.ToString(ShapeType)} - (x/y): ({XCoord}/{YCoord}) - Area: {this.area} - Circunference: {this.circunference} - Side: {this.Side}");
        }
    }
}
