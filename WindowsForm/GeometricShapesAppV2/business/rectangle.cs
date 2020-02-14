using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapesApp.business
{
    public class Rectangle : ShapesIn2D
    {
        #region //rectangle class attributes
        shapeName name;
        shapeColor color;
        int xCoordinate;
        int yCoordinate;
        int poligonBase;
        int poligonHeight;
        #endregion

        #region //attributes properties 
        public shapeName Name1 { get => name; set => name = value; }
        public shapeColor Color1 { get => color; set => color = value; }
        public int XCoordinate1 { get => xCoordinate; set => xCoordinate = value; }
        public int YCoordinate1 { get => yCoordinate; set => yCoordinate = value; }
        public int PoligonBase { get => poligonBase; set => poligonBase = value; }
        public int PoligonHeight { get => poligonHeight; set => poligonHeight = value; }
        #endregion

        //parameteless constructor
        public Rectangle()
        {
            this.name = shapeName.undefined;
            this.color = shapeColor.undefined;
            this.xCoordinate = 00;
            this.yCoordinate = 00;
            this.poligonBase = 00;
            this.poligonHeight = 00;
        }

        //parameter constructor
        public Rectangle(shapeName aName, shapeColor aColor, int aX, int aY, int aBase, int aHeight)
        {
            this.name = aName;
            this.color = aColor;
            this.xCoordinate = aX;
            this.yCoordinate = aY;
            this.poligonBase = aBase;
            this.poligonHeight = aHeight;
        }

        //ToString method override
        public override string ToString()
        {
            return (base.ToString() + " - base: " + this.poligonBase + " - height: " + this.poligonHeight + " - area: " + getArea());
        }

        //getArea method override
        public override double getArea()
        {
            return this.poligonHeight * this.poligonBase;
        }



    }
}
