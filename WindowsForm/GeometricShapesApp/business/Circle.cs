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
    public class Circle : Shapes
    {
        #region //circle class attributes
        ShapeName name;
        ShapeColor color;
        int xCoordinate;
        int yCoordinate;
        int radius;
        #endregion

        #region //attributes properties 
        public ShapeName Name1 { get => name; set => name = value; }
        public ShapeColor Color1 { get => color; set => color = value; }
        public int XCoordinate1 { get => xCoordinate; set => xCoordinate = value; }
        public int YCoordinate1 { get => yCoordinate; set => yCoordinate = value; }
        public int Radius { get => radius; set => radius = value; }
        #endregion

        //parameteless constructor
        public Circle()
        {
            this.name = ShapeName.Type;
            this.color = ShapeColor.Color;
            this.xCoordinate = 00;
            this.yCoordinate = 00;
            this.radius = 00;
        }

        //parameter constructor
        public Circle(ShapeName aName, ShapeColor aColor, int aX, int aY, int aRadius)
        {
            this.name = aName;
            this.color = aColor;
            this.xCoordinate = aX;
            this.yCoordinate = aY;
            this.radius = aRadius;
        }

        //ToString method override
        public override string ToString()
        {
            return (base.ToString());
        }

        //getArea Method Override
        public override double getArea()
        {
            return Math.Round(Math.PI * Math.Pow(radius, 2), 3);
        }

        //getPerimeter method override
        public override double getPerimeter()
        {
            return Math.Round(this.radius*2*Math.PI, 3);
        }
    }
}
