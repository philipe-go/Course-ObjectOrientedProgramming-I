using System;
using System.Windows.Forms;

namespace ShapesDataLayer.business
{
    //2.1
    [Serializable]
    public abstract class Shapes : IShape2D
    {
        //Class Attributes
        #region ##attributes##
        private int xCoord;
        private int yCoord;
        private EnumShapeType shapeType;
        private EnumBrushingColor brushColor;
        private EnumBorderColor borderColor;
        #endregion

        //properties
        #region ##properties##
        public abstract double area { get; }
        public abstract double circunference { get; }
        //main properties
        public int XCoord { get ; set; }
        public int YCoord { get; set; }
        public EnumShapeType ShapeType { get; set; }
        public EnumBrushingColor BrushColor { get; set; }
        public EnumBorderColor BorderColor { get; set; }
        #endregion

        //constructors
        #region ##constructors##
        public Shapes()
        {
            this.xCoord = 00;
            this.yCoord = 00;
            this.shapeType = EnumShapeType.undefined;
            this.brushColor = EnumBrushingColor.undefined;
            this.borderColor = EnumBorderColor.undefined;
        }
        public Shapes(int x, int y, EnumShapeType type, EnumBrushingColor brushcolor, EnumBorderColor bordercolor)
        {
            this.xCoord = x;
            this.yCoord = y;
            this.shapeType = type;
            this.brushColor = brushcolor;
            this.borderColor = bordercolor;
        }
        #endregion

        //class methods (getArea, getCirc, Draw, Move)
        #region ##methods##
        public abstract double getArea();
        public abstract double getCircunference();

        public abstract void Draw(PaintEventArgs e);
        public abstract void Draw(PaintEventArgs e, string brushColor);
        public abstract void Draw(PaintEventArgs e, string brushColor, string borderColor);

        public abstract void moveUp(int dy);
        public abstract void moveDown(int dy);
        public abstract void moveLeft(int dx);
        public abstract void moveRight(int dx);

        public abstract void moveUpLeft(int dy, int dx);
        public abstract void moveUpRight(int dy, int dx);
        public abstract void moveDownLeft(int dy, int dx);
        public abstract void moveDownRight(int dy, int dx);
        #endregion

        //override ToString
        public override string ToString()
        {
            return ($"{Convert.ToString(this.shapeType)} - (x/y): ({this.xCoord}/{this.yCoord})");
        }
    }
}
