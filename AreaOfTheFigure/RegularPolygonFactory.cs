using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaOfTheFigure
{
    public class RegularPolygonFactory
    {
        public RegularPolygon GetRegularPolygon(int polygonType, double sideLength)
        {

            if (sideLength < 1)
            {
                throw new ArgumentException("Arguments are not correct! Length of side must be > 0!");
            }

            if (polygonType == 3)
            {
                return new Triangle(sideLength);
            }
            else if (polygonType == 4)
            {
                return new Square(sideLength);
            }
            else if (polygonType > 4)
            {
                return new NSidedRegularPolygon(sideLength, polygonType);
            }
            else
            {
                throw new ArgumentException("Arguments are not correct! Polygon must have more then 2 sides!");
            }
            

        }
    }
}
