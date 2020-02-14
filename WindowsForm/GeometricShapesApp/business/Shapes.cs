//project done by Philipe Gouveia @ July 8th, 2019
//assignment requested on Summer Session Lasalle College - Object Oriented Programming

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapesApp.business
{
    [Serializable]
    abstract public class Shapes : IShapesIn2D
    {
        #region //shape class attributes
        private int serialNumber;
        private ShapeName name;
        private ShapeColor color;
        private int xCoordinate;
        private int yCoordinate;
        #endregion

        #region //attibutes constructors
        public ShapeColor Color { get => color; set => color = value; }
        public ShapeName Name { get => name; set => name = value; }
        public int XCoordinate { get => xCoordinate; set => xCoordinate = value; }
        public int YCoordinate { get => yCoordinate; set => yCoordinate = value; }
        public int SerialNumber { get => serialNumber; set => serialNumber = value; }
        #endregion

        //parameteless constructors
        public Shapes()
        {
            this.name = ShapeName.Type;
            this.color = ShapeColor.Color;
            this.xCoordinate = 00;
            this.yCoordinate = 00;
            this.serialNumber = 0001;
        }

        //parameter constructor
        public Shapes(ShapeName name, ShapeColor color, int x, int y, int z, int serial)
        {
            this.name = name;
            this.color = color;
            this.xCoordinate = x;
            this.yCoordinate = y;
            this.serialNumber = serial;
        }

        //interface method
        public abstract double getArea();
        public abstract double getPerimeter();

        //class methods
        public void moveUp(int incr) { this.yCoordinate = this.yCoordinate + incr; }
        public void moveDown(int incr) { this.yCoordinate = this.yCoordinate - incr; ; }
        public void moveLeft(int incr) { this.xCoordinate = this.xCoordinate - incr; ; }
        public void moveRight(int incr) { this.xCoordinate = this.xCoordinate + incr; ; }
        public void moveUpRight(int incr) { this.xCoordinate = this.xCoordinate + incr; ; this.yCoordinate = this.yCoordinate + incr; ; }
        public void moveUpLeft(int incr) { this.xCoordinate = this.xCoordinate - incr; ; this.yCoordinate = this.yCoordinate + incr; ; }
        public void moveDownRight(int incr) { this.xCoordinate = this.xCoordinate + incr; ; this.yCoordinate = this.yCoordinate - incr; ; }
        public void moveDownLeft(int incr) { this.xCoordinate = this.xCoordinate - incr; ; this.yCoordinate = this.yCoordinate - incr; ; }

        //toString method
        public override string ToString()
        {
            return ($" {this.serialNumber}    -    {this.name}    -    {this.color}    -    {this.xCoordinate} / {this.yCoordinate}       -       { getArea()}      -        { getPerimeter()}");
        }
    }
}
