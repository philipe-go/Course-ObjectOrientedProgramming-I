using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace ShapesDataLayer
{
    //2.1
    abstract class Shapes : IShape2D
    {
        private int xCoord;
        private int yCoord;
        private EnumBrushingColor shapeFillColor;
        private EnumBorderColor shapeBorderColor;
        private EnumShapeType shapeType;
        private double area;
        private double circunference;

        public abstract double getArea();
        public abstract double getCircumference();

        public abstract void Draw(PaintEventArgs e);
        public abstract void Draw(PaintEventArgs e, String brushingColor);
        public abstract void Draw(PaintEventArgs e, String borderColor, String brushingColor);
        public abstract void moveUp(int dy);
        public abstract void moveDown(int dy);
        public abstract void moveLeft(int dx);
        public abstract void moveRight(int dx);
        public abstract void moveUpRight(int dx, int dy);
        public abstract void moveDownRight(int dx, int dy);
        public abstract void moveUpLeft(int dx, int dy);
        public abstract void moveDownLeft(int dx, int dy);
    }
}
