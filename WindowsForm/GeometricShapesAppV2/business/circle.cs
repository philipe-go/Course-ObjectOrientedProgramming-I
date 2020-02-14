using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapesApp.business
{
    public class Circle : ShapesIn2D
    {
        #region //circle class attributes
        shapeName name;
        shapeColor color;
        int xCoordinate;
        int yCoordinate;
        int radius;
        #endregion

        #region //attributes properties 
        public shapeName Name1 { get => name; set => name = value; }
        public shapeColor Color1 { get => color; set => color = value; }
        public int XCoordinate1 { get => xCoordinate; set => xCoordinate = value; }
        public int YCoordinate1 { get => yCoordinate; set => yCoordinate = value; }
        public int Radius { get => radius; set => radius = value; }
        #endregion

        //parameteless constructor
        public Circle()
        {
            this.name = shapeName.undefined;
            this.color = shapeColor.undefined;
            this.xCoordinate = 00;
            this.yCoordinate = 00;
            this.radius = 00;
        }

        //parameter constructor
        public Circle(shapeName aName, shapeColor aColor, int aX, int aY, int aRadius)
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
            return (base.ToString() +" - radius: "+this.radius+" - area: "+getArea());
        }

        //Area Method Override
        public override double getArea()
        {
            return Math.PI * Math.Pow(radius, 2);
        }
    }
}
