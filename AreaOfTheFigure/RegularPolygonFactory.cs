using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaOfTheFigure
{
    public class RegularPolygonFactory
    {
        public RegularPolygon GetRegularPolygon(int polygonType, int sideLength)
        {

            if (polygonType < 3)
            {
                throw new ArgumentException("Polygon must have more then 2 sides");
            }
            if (sideLength <= 0)
            {
                throw new ArgumentException("Length must be positive number!");
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
            return null;

        }
    }
}
