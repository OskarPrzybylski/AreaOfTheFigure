using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaOfTheFigure
{
    public class NSidedRegularPolygon : RegularPolygon
    {
        
        public NSidedRegularPolygon(double _sideLength, int _numberOfSides)
        {
           

            sideLength = _sideLength;
            numberOfSides = _numberOfSides;
        }

        public override Point[] GetCoordinates()
        {
            float radius = (float)sideLength / (2 * ((float)Math.Sin(Math.PI / numberOfSides)));
            Point center = new Point { x = -radius, y = 0 };
           

            List<Point> points = new List<Point>();
            float step = FULL_ANGLE / numberOfSides;
            
         
            for (float i = 0; i < numberOfSides; i ++) 
            {

                points.Add(DegreesToXY(i, radius, center));
                step += step;

            }

            return points.ToArray();
        }
       
    }
}
