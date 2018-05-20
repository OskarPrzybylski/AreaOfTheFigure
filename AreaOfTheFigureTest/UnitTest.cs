using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AreaOfTheFigure;
namespace AreaOfTheFigureTest
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void AreaCalculationsTest()
        {

            IArea a = new Triangle(10);
            IArea b = new Triangle(20);
            IArea c = new Triangle(30);


            RegularPolygon d = new Square(10);
            RegularPolygon e = new Square(20);
            RegularPolygon f = new Square(30);
            
            
        

            double w1 = a.GetArea();
            double w2 = b.GetArea();
            double w3 = c.GetArea();
            double w4 = d.GetArea();
            double w5 = e.GetArea();
            double w6 = f.GetArea();

            Assert.AreEqual(43.30, Math.Round(w1, 2), "Is not equal: " + Math.Round(w1, 2));
            Assert.AreEqual(173.21, Math.Round(w2, 2), "Is not equal: " + Math.Round(w2, 2));
            Assert.AreEqual(389.71, Math.Round(w3, 2), "Is not equal: " + Math.Round(w3, 2));
            Assert.AreEqual(100, Math.Round(w4, 2), "Is not equal: " + Math.Round(w4, 2));
            Assert.AreEqual(400, Math.Round(w5, 2), "Is not equal: " + Math.Round(w5, 2));
            Assert.AreEqual(900, Math.Round(w6, 2), "Is not equal: " + Math.Round(w6, 2));

        }

        [TestMethod]
        public void CoordinatesCalculationsTest()
        {

            RegularPolygonFactory factory = new RegularPolygonFactory();

            RegularPolygon a = factory.GetRegularPolygon(3, 2);
            
            
            Point[] d = a.GetCoordinates();
            

            Point[] g = { new Point { x = 0, y = 0 }, new Point { x =(float)-1.732051, y =(float)-0.9999999 }, new Point { x=(float)-1.732051, y=(float)0.9999999 } };

            for(int i = 0; i < d.Length; i++)
            {
                Assert.AreEqual(Math.Round(d[i].x,2), Math.Round(g[i].x,2));
                Assert.AreEqual(Math.Round(d[i].y, 2), Math.Round(g[i].y, 2));
            }
           

           
        }
        [TestMethod]
        public void RegularPolygonFactoryTest()
        {
            RegularPolygonFactory factory = new RegularPolygonFactory();



            RegularPolygon a = factory.GetRegularPolygon(3, 10);
            RegularPolygon b = factory.GetRegularPolygon(4, 10);
            RegularPolygon c = factory.GetRegularPolygon(6, 10);


            Assert.IsInstanceOfType(a, typeof(Triangle));
            Assert.IsInstanceOfType(b, typeof(Square));
            Assert.IsInstanceOfType(c, typeof(NSidedRegularPolygon));
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SideLengthLessThen0()
        {
            RegularPolygonFactory factory = new RegularPolygonFactory();


            RegularPolygon a = factory.GetRegularPolygon(3, -10);

            
        }
    }
}
