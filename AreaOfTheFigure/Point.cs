using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaOfTheFigure
{
    public class Point
    {

        public float x { get; set; }
        public float y { get; set; }

       public override String ToString()
        {
            return "x= " + x + " ,y= " + y;
        }
    }
}
