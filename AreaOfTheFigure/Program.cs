using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaOfTheFigure
{
    class Program
    {
        static int Main(string[] args)
        {
            if (args.Length>1 && args.Length<4)
            {
                int numberOfSides = 0;
                double sideLength = 0;
                RegularPolygonFactory factory = new RegularPolygonFactory();
                RegularPolygon a = null;
                double area = 0;
                Point[] coordinates = null;
                
                List<string> tekst = new List<string>();
                int choice = 0;

                try
                {
                    numberOfSides = int.Parse(args[0]);

                    sideLength = double.Parse(args[1]);
                    
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.ReadKey();
                    return 1;
                }




                try
                {
                    a = factory.GetRegularPolygon(numberOfSides, sideLength);
                }
                catch(ArgumentException e)
                {
                    Console.WriteLine(e.Message);
                    Console.ReadKey();
                    return 1;
                }
                

                area = a.GetArea();
                coordinates = a.GetCoordinates();
              

                foreach(Point point in coordinates)
                {
                    tekst.Add(point.ToString());
                }

               
                tekst.Add("area = " + area.ToString());


                if (args.Length == 3)
                {
                    try
                    {
                        choice = int.Parse(args[2]);
                    }
                    catch(Exception e)
                    {
                        Console.WriteLine(e.Message);
                        Console.ReadKey();
                        return 1;
                    }
                    if (choice == 1)
                    {

                        using (System.IO.StreamWriter file =
                            new System.IO.StreamWriter("test.txt"))
                        {
                            foreach (string line in tekst)
                            {


                                file.WriteLine(line);

                            }
                        }
                    }
                }
                else
                {
                    foreach (string line in tekst)
                    {
                        Console.WriteLine(line);
                    }
                    Console.ReadKey();
                }
            }
            else
            {
                Console.WriteLine("Error! Must be 2 or 3 arguments!(numberofsides,sidelength,typeofwriting(type 1 if you want to write to file))");
                Console.ReadKey();
                return 1;
            }

            return 0;
        }


       

        
    }
}
