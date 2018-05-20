using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaOfTheFigure
{
    class Program
    {
        static void Main(string[] args)
        {
            RegularPolygonFactory factory = new RegularPolygonFactory();
            RegularPolygon a = factory.GetRegularPolygon(3, 10);
            Point[] b = a.GetCoordinates();
            for(int i = 0; i < b.Count(); i++)
            {
                Console.WriteLine(b[i]);
            }
            Console.ReadLine();
        }


       

        
    }
}
