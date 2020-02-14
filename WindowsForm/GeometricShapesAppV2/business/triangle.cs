using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapesApp.business
{
    public class Triangle : ShapesIn2D
    {
        #region //triangle class attributes
        shapeName name;
        shapeColor color;
        int xCoordinate;
        int yCoordinate;
        int triangBase;
        int triangHeight;
        #endregion

        #region //attributes properties 
        public shapeName Name1 { get => name; set => name = value; }
        public shapeColor Color1 { get => color; set => color = value; }
        public int XCoordinate1 { get => xCoordinate; set => xCoordinate = value; }
        public int YCoordinate1 { get => yCoordinate; set => yCoordinate = value; }
        public int TriangBase { get => triangBase; set => triangBase = value; }
        public int TriangHeight { get => triangHeight; set => triangHeight = value; }
        #endregion

        //parameteless constructor
        public Triangle()
        {
            this.name = shapeName.undefined;
            this.color = shapeColor.undefined;
            this.xCoordinate = 00;
            this.yCoordinate = 00;
            this.triangBase = 00;
            this.triangHeight = 00;
        }

        //parameter constructor
        public Triangle(shapeName aName, shapeColor aColor, int aX, int aY, int aBase, int aHeight)
        {
            this.name = aName;
            this.color = aColor;
            this.xCoordinate = aX;
            this.yCoordinate = aY;
            this.triangBase = aBase;
            this.triangHeight = aHeight;
        }

        //ToString method override
        public override string ToString()
        {
            return (base.ToString() + " - base: " + this.triangBase+ " - height: " + this.triangHeight + " - area: " + getArea());
        }

        //getArea method override
        public override double getArea()
        {
            return this.TriangHeight * this.triangBase * 1/2;
        }
    }
}
