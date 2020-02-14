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
    public class Triangle : Shapes
    {
        #region //triangle class attributes
        ShapeName name;
        ShapeColor color;
        int xCoordinate;
        int yCoordinate;
        int triangBase;
        int triangHeight;
        #endregion

        #region //attributes properties 
        public ShapeName Name1 { get => name; set => name = value; }
        public ShapeColor Color1 { get => color; set => color = value; }
        public int XCoordinate1 { get => xCoordinate; set => xCoordinate = value; }
        public int YCoordinate1 { get => yCoordinate; set => yCoordinate = value; }
        public int TriangBase { get => triangBase; set => triangBase = value; }
        public int TriangHeight { get => triangHeight; set => triangHeight = value; }
        #endregion

        //parameteless constructor
        public Triangle()
        {
            this.name = ShapeName.Type;
            this.color = ShapeColor.Color;
            this.xCoordinate = 00;
            this.yCoordinate = 00;
            this.triangBase = 00;
            this.triangHeight = 00;
        }

        //parameter constructor
        public Triangle(ShapeName aName, ShapeColor aColor, int aX, int aY, int aBase, int aHeight)
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
            return (base.ToString());
        }

        //getArea method override
        public override double getArea()
        {
            return this.TriangHeight * this.triangBase * 1/2;
        }

        //getPerimeter method override
        public override double getPerimeter()
        {
            double triangSide = Math.Pow( Math.Pow(triangBase, 2) + Math.Pow(triangHeight, 2) , 1/2);

            return (this.triangBase + 2 * triangSide);
        }
    }
}
