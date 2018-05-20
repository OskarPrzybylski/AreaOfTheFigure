﻿using System;
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
            float radius = numberOfSides / (2 * ((float)Math.Sin(Math.PI / numberOfSides)));
            Point center = new Point { x = -radius, y = 0 };
           

            List<Point> points = new List<Point>();
            float step = 360.0f / numberOfSides;

         
            for (float i = 0; i < 360.0; i += step) 
            {
                points.Add(DegreesToXY(i, radius, center)); 

            }

            return points.ToArray();
        }
       
    }
}
