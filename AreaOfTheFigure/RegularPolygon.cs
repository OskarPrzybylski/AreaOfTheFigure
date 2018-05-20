using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaOfTheFigure
{
    public abstract class RegularPolygon : IArea
    {
        protected double sideLength;
        protected int numberOfSides;
        protected const float FULL_ANGLE = 360;
        public double GetArea()
        {
            double a = (numberOfSides / 4.0) * (1.0 / (Math.Tan(Math.PI / numberOfSides))) * sideLength * sideLength;
          
            return a;
        }
        public abstract Point[] GetCoordinates();
        protected Point DegreesToXY(float degrees, float radius, Point origin)
        {
            Point xy = new Point();
            double radians = degrees * Math.PI / 180.0;

            xy.x = (float)Math.Cos(radians) * radius + origin.x;
            xy.y = (float)Math.Sin(-radians) * radius + origin.y;

            return xy;
        }
    }
}
