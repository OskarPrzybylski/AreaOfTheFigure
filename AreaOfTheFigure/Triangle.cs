using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AreaOfTheFigure
{
    public class Triangle : RegularPolygon
    {
        //private double sideLength { get; set; }
       // private int numberOfTheSides=3;
       
        public Triangle(double _sideLength)
        {

            sideLength = _sideLength;
            numberOfSides = 3;
        }

        public override Point[] GetCoordinates()
        {
            float radius = 3 / (2 * ((float)Math.Sin(Math.PI / 3)));
            Point center = new Point { x = -radius, y = 0 };
            

            List<Point> points = new List<Point>();
            float step = 360.0f / 3;

            //starting angle
            for (float i = 0; i < 360.0; i += step) //go in a full circle
            {
                points.Add(DegreesToXY(i, radius, center)); //code snippet from above

            }

            return points.ToArray();
        }

        
    }
}
