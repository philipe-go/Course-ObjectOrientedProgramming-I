using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ShapesDataLayer
{
    //2.2
    class Rectangles : Squares
    {

        private double width;
        private double length;
  
        private int xCoord;
        private int yCoord;
        private EnumBrushingColor shapeFillColor;
        private EnumBorderColor shapeBorderColor;
        private EnumShapeType shapeType;
        private double area;
        private double circunference;

        public int XCoord { get => xCoord; set => xCoord = value; }
        public int YCoord { get => yCoord; set => yCoord = value; }
        internal EnumBrushingColor ShapeFillColor { get => shapeFillColor; set => shapeFillColor = value; }
        internal EnumBorderColor ShapeBorderColor { get => shapeBorderColor; set => shapeBorderColor = value; }
        internal EnumShapeType ShapeType { get => shapeType; set => shapeType = value; }
        public double Area { get => area; set => getArea(); }
        public double Circunference { get => circunference; set => getCircumference(); }
        public double Width { get => width; set => width = value; }
        public double Length { get => length; set => length = value; }

        public override double getArea()
        {
            return (this.width)*(this.length);
        }

        public override double getCircumference()
        {
            return 2*(this.length+this.width);
        }

        public void Draw(PaintEventArgs e) { }
        public void Draw(PaintEventArgs e, String brushingColor) { }
        public void Draw(PaintEventArgs e, String borderColor, String brushingColor) { }
        public void moveUp(int dy) { }
        public void moveDown(int dy) { }
        public void moveLeft(int dx) { }
        public void moveRight(int dx) { }
        public void moveUpRight(int dx, int dy) { }
        public void moveDownRight(int dx, int dy) { }
        public void moveUpLeft(int dx, int dy) { }
        public void moveDownLeft(int dx, int dy) { }
    }
}
