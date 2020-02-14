using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapesApp.business
{
    abstract public class ShapesIn2D : IShapes
    {
        #region //shape class attributes
        private shapeName name;
        private shapeColor color;
        private int xCoordinate;
        private int yCoordinate;
        #endregion

        #region //attibutes constructors
        public shapeColor Color { get => color; set => color = value; }
        public shapeName Name { get => name; set => name = value; }
        public int XCoordinate { get => xCoordinate; set => xCoordinate = value; }
        public int YCoordinate { get => yCoordinate; set => yCoordinate = value; }
        #endregion

        //parameteless constructors
        public ShapesIn2D()
        {
            this.name = shapeName.undefined;
            this.color = shapeColor.undefined;
            this.xCoordinate = 00;
            this.yCoordinate = 00;
        }

        //parameter constructor
        public ShapesIn2D(shapeName name, shapeColor color, int x, int y)
        {
            this.name = name;
            this.color = color;
            this.xCoordinate = x;
            this.yCoordinate = y;
        }

        #region //Shapes class methods signature
        abstract double getArea();
        #endregion

        //toString method override
        public override string ToString()
        {
            return ("Shape parameters :: name: "+ this.name+" - color: "+ this.color+" - xCoordinate: "+ this.xCoordinate+" - yCoordinate: "+this.yCoordinate);
        }            
    }
}
