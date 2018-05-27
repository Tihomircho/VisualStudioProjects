using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Geometry_Calculator
{
    class Program
    {
        

        static void Main(string[] args)
        {
            var nameOfFigure = Console.ReadLine().ToLower();

            switch (nameOfFigure)
            {
                case "triangle":
                    var sideOfTringle1 = double.Parse(Console.ReadLine());
                    var sideOfTringle2 = double.Parse(Console.ReadLine());
                    Console.WriteLine("{0:f2}", GetTriangleArea(sideOfTringle1, sideOfTringle2));
                    break;
                case "rectangle":
                    var sideOfRectangle1 = double.Parse(Console.ReadLine());
                    var sideOfRectangle2 = double.Parse(Console.ReadLine());
                    Console.WriteLine("{0:f2}", GetRectangleArea(sideOfRectangle1, sideOfRectangle2));
                    break;
                case "square":
                    var sideOfSqare = double.Parse(Console.ReadLine());
                    Console.WriteLine("{0:f2}", GetSqareArea(sideOfSqare));
                    break;
                case "circle":
                    var radius = double.Parse(Console.ReadLine());
                    Console.WriteLine("{0:f2}", GetCircleArea(radius));
                    break;

            }

        }

        private static double GetCircleArea(double r)
        {
            double sircleArea = Math.PI * r * r;
            return sircleArea;
        }

        private static double GetSqareArea(double a)
        {
            double squaeArea = a * a;
            return squaeArea;
        }
        private static double GetRectangleArea(double a, double b)
        {
            double rectangleArea = a * b;
            return rectangleArea;
        }

        public static double GetTriangleArea(double a , double b)
        {
            double triangleArea = a * b / 2;
            return triangleArea;
        }
    }
}
