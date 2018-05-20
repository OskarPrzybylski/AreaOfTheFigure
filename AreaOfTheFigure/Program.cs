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
                int numberofsides = 0;
                double sidelength = 0;
                RegularPolygonFactory factory = new RegularPolygonFactory();
                RegularPolygon a = null;
                double area = 0;
                Point[] coordinates = null;
                string[] text = null;
                int choose = 0;

                try
                {
                    numberofsides = int.Parse(args[0]);

                    sidelength = double.Parse(args[1]);
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.ReadKey();
                    return 1;
                }




                try
                {
                    a = factory.GetRegularPolygon(numberofsides, sidelength);
                }
                catch(ArgumentException e)
                {
                    Console.WriteLine(e.Message);
                    Console.ReadKey();
                    return 1;
                }
                

                area = a.GetArea();
                coordinates = a.GetCoordinates();
                text = new string[coordinates.Length+1];



                for (int i = 0; i < coordinates.Length; i++)
                {
                    text[i] = coordinates[i].ToString();
                }
                text[coordinates.Length] = "area = " + area.ToString();


                if (args.Length == 3)
                {
                    try
                    {
                        choose = int.Parse(args[2]);
                    }
                    catch(Exception e)
                    {
                        Console.WriteLine(e.Message);
                        Console.ReadKey();
                        return 1;
                    }
                    if (choose == 1)
                    {

                        using (System.IO.StreamWriter file =
                            new System.IO.StreamWriter(@"C:\Users\Oskar Przybylski\Documents\visual studio 2017\Projects\AreaOfTheFigure\AreaOfTheFigure/test.txt"))
                        {
                            foreach (string line in text)
                            {


                                file.WriteLine(line);

                            }
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < coordinates.Length + 1; i++)
                    {
                        Console.WriteLine(text[i]);
                    }
                    Console.ReadKey();
                }
            }
            else
            {
                Console.WriteLine("Error! Must be 2 or 3 arguments!(numberofsides,sidelength,typeofwriting)");
                Console.ReadKey();
                return 1;
            }

            return 0;
        }


       

        
    }
}
