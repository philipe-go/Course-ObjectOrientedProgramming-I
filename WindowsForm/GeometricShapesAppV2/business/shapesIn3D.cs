using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapesApp.business
{
    abstract public class ShapesIn3D : IShapes
    {
        #region //shape class attributes
        private shapeName name;
        private shapeColor color;
        private int xCoordinate;
        private int yCoordinate;
        private int zCoordinate;
        #endregion

        #region //attibutes constructors
        public shapeColor Color { get => color; set => color = value; }
        public shapeName Name { get => name; set => name = value; }
        public int XCoordinate { get => xCoordinate; set => xCoordinate = value; }
        public int YCoordinate { get => yCoordinate; set => yCoordinate = value; }
        public int ZCoordinate { get => zCoordinate; set => zCoordinate = value; }
        #endregion

        //parameteless constructors
        public Shapes()
        {
            this.name = shapeName.undefined;
            this.color = shapeColor.undefined;
            this.xCoordinate = 00;
            this.yCoordinate = 00;
            this.zCoordinate = 00;        
        }

        //parameter constructor
        public Shapes(shapeName name, shapeColor color, int x, int y, int z)
        {
            this.name = name;
            this.color = color;
            this.xCoordinate = x;
            this.yCoordinate = y;
            this.zCoordinate = z; 
        }

        #region //Shapes class methods signature
        abstract double getVolume();
        #endregion

        //toString method override
        public override string ToString()
        {
            return ("Shape parameters :: name: "+ this.name+" - color: "+ this.color+" - xCoordinate: "+ this.xCoordinate+" - yCoordinate: "+this.yCoordinate+" - zCoordinate: "+this.zCoordinate);
        }  
        private int zCoordinate;
    }
}
