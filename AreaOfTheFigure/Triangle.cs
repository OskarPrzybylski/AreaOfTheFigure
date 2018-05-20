using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AreaOfTheFigure
{
    public class Triangle : RegularPolygon
    {
        private const float STEP = 120;
       
        public Triangle(double _sideLength)
        {

            sideLength = _sideLength;
            numberOfSides = 3;
        }

        public override Point[] GetCoordinates()
        {
            float radius = numberOfSides / (2 * ((float)Math.Sin(Math.PI / numberOfSides)));
            Point center = new Point { x = -radius, y = 0 };
            List<Point> points = new List<Point>();
           

            
            for (float i = 0; i < 360.0; i += STEP) 
            {
                points.Add(DegreesToXY(i, radius, center)); 

            }

            return points.ToArray();
        }

        
    }
}
