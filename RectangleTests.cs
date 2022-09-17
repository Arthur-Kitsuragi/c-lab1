using ConsoleApp1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class RectangleTests
    {
        [TestMethod]
        public void AreaCheck()
        {
            Rectangle rectangle = new Rectangle(56, 54);
            Assert.AreEqual(rectangle.AreaCalculator(), 3024);
        }
        [TestMethod]
        public void PerimeterCheck()
        {
            Rectangle rectangle1 = new Rectangle(56, 54);
            Assert.AreEqual(rectangle1.PerimeterCalculator(), 220);
        }
    }
    [TestClass]
    public class FigureCheck
    {
        [TestMethod]
        public void fgcheck()
        {
            Point x = new Point(0, 0);
            Point x1 = new Point(3, 0);
            Point x2 = new Point(3, 4);
            Figure fg = new Figure(x, x1, x2);
            Assert.AreEqual(fg.fig_name, "Triangle");
            Assert.AreEqual(fg.PerimeterCalculator(), 12);
        }
    }
}
 