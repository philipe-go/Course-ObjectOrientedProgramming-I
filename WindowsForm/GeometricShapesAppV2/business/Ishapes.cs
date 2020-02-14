using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapesApp.business
{
    interface IShapes
    {
        shapeName name { get; set; }
        shapeColor color { get; set; }
        int xCoordinate { get; set; }
        int yCoordinate { get; set; }
    }
}
