using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{   public class Rectangle
    {
        private double side1, side2;
        public Rectangle(double sideA, double sideB)
        {
            side1 = sideA;
            side2 = sideB;
        }
        public double AreaCalculator()
        {
            return side1 * side2;
        }
        public double PerimeterCalculator()
        {
            return 2 * (side1 + side2);
        }
        public double Area
        {
            get { return AreaCalculator(); }
        }
        public double Perimeter
        {
            get { return PerimeterCalculator(); }
        }
    }
    public class Point
    {
        private int X, Y;
        public int x
        {
            get { return X; }
        }
        public int y
        {
            get { return Y; }
        }
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
    public class Figure
    {
        private Point[] points;
        public string fig_name { get; set; }
        public Figure (Point x, Point y, Point z)
        {
            fig_name = "Triangle";
            points = new Point[3] { x, y, z };
        }
        public Figure(Point x, Point y, Point z, Point d)
        {
            fig_name = "Quadrangle";
            points = new Point[4] { x, y, z, d };
        }
        public Figure(Point x, Point y, Point z, Point d, Point f)
        {
            fig_name = "Pentagon";
            points = new Point[5] { x, y, z, d, f };
        }
        private double LengthSide(Point A, Point B)
        {
            return (Math.Pow(Math.Pow(A.x - B.x, 2) + Math.Pow(A.y - B.y, 2), 0.5));
        }
        public double PerimeterCalculator()
        {
            double per = 0;
            for (int i = 0; i < points.Length; i++)
            {
                per += LengthSide(points[i % points.Length], points[(i + 1) % points.Length]);
            }
            return per;

        }
    }
    class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine(Int32.MaxValue + " " + Int32.MinValue + "\n");
            Console.WriteLine(UInt32.MaxValue + " " + UInt32.MinValue + "\n");
            Console.WriteLine(true + " " + false + "\n");
            Console.WriteLine(Char.MaxValue + " " + Char.MinValue + "\n");
            Console.WriteLine(SByte.MaxValue + " " + SByte.MinValue + "\n");
            Console.WriteLine(Byte.MaxValue + " " + Byte.MinValue + "\n");
            Console.WriteLine(Int16.MaxValue + " " + Int16.MinValue + "\n");
            Console.WriteLine(UInt16.MaxValue + " " + UInt16.MinValue + "\n");
            Console.WriteLine(Int64.MaxValue + " " + Int64.MinValue + "\n");
            Console.WriteLine(UInt64.MaxValue + " " + UInt64.MinValue + "\n");
            Console.WriteLine(Decimal.MaxValue + " " + Decimal.MinValue + "\n");
            Console.WriteLine(Single.MaxValue + " " + Single.MinValue + "\n");
            Console.WriteLine(Double.MaxValue + " " + Double.MinValue + "\n");
            //Console.WriteLine(Environment.NewLine);
            Console.WriteLine("type sides of rectangle" + "\n");
            double a, b;
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            Rectangle rectangle = new Rectangle(a, b);
            Console.WriteLine(rectangle.Perimeter + " " + rectangle.Area);
            Point x = new Point(1, 1);
            Point x1 = new Point(1, 4);
            Point x2 = new Point(5, 4);
            Point x3 = new Point(5, 1);
            Figure f1 = new Figure(x, x1, x2, x3);
            Console.WriteLine(f1.fig_name + " " + f1.PerimeterCalculator() + "\n");
            Console.ReadLine();
        }
    }
}
