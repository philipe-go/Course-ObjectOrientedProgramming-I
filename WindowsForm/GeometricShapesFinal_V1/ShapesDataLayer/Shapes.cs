using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
