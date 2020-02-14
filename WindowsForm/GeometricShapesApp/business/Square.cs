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
    public class Square : Shapes
    {
        #region //rectangle class attributes
        ShapeName name;
        ShapeColor color;
        int xCoordinate;
        int yCoordinate;
        int poligonBase;
        #endregion

        #region //attributes properties 
        public ShapeName Name1 { get => name; set => name = value; }
        public ShapeColor Color1 { get => color; set => color = value; }
        public int XCoordinate1 { get => xCoordinate; set => xCoordinate = value; }
        public int YCoordinate1 { get => yCoordinate; set => yCoordinate = value; }
        public int PoligonBase { get => poligonBase; set => poligonBase = value; }
        #endregion

        //parameteless constructor
        public Square()
        {
            this.name = ShapeName.Type;
            this.color = ShapeColor.Color;
            this.xCoordinate = 00;
            this.yCoordinate = 00;
            this.poligonBase = 00;
        }

        //parameter constructor
        public Square(ShapeName aName, ShapeColor aColor, int aX, int aY, int aBase)
        {
            this.name = aName;
            this.color = aColor;
            this.xCoordinate = aX;
            this.yCoordinate = aY;
            this.poligonBase = aBase;
        }

        //ToString method override
        public override string ToString()
        {
            return (base.ToString());
        }

        //getArea method override
        public override double getArea()
        {
            return Math.Pow(this.poligonBase,2);
        }

        //getPerimeter method override
        public override double getPerimeter()
        {
            return this.poligonBase * 4;
        }
    }
}
