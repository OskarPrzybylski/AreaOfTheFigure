using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaOfTheFigure
{
    public class Square : RegularPolygon
    {
        public Square(double _sideLength)
        {

            sideLength = _sideLength;
            numberOfSides = 4;
        }


        
        public override Point[] GetCoordinates()
        {
            float radius = 4 / (2 * ((float)Math.Sin(Math.PI / 4)));
            Point center = new Point { x = -radius, y = 0 };
            if (4 < 3)
                throw new ArgumentException("Polygon must have 3 sides or more.");

            List<Point> points = new List<Point>();
            float step = 360.0f / 4;

            //starting angle
            for (float i = 0; i < 360.0; i += step) //go in a full circle
            {
                points.Add(DegreesToXY(i, radius, center)); //code snippet from above

            }

            return points.ToArray();
        }

       
    }
}
