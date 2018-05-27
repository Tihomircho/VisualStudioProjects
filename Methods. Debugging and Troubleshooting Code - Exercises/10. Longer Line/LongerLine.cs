﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Longer_Line
{
    class LongerLine
    {
        static void Main(string[] args)
        {
            var x1 = double.Parse(Console.ReadLine());
            var y1 = double.Parse(Console.ReadLine());

            var x2 = double.Parse(Console.ReadLine());
            var y2 = double.Parse(Console.ReadLine());

            var x3 = double.Parse(Console.ReadLine());
            var y3 = double.Parse(Console.ReadLine());

            var x4 = double.Parse(Console.ReadLine());
            var y4 = double.Parse(Console.ReadLine());

            var distanece1 = CauculateDistanceBetweenPoints(x1, y1, x2, y2);
            var distanece2 = CauculateDistanceBetweenPoints(x3, y3, x4, y4);
            if (distanece1 > distanece2)
            {
                if (Point1IsCloserToCenter(x1, y1, x2, y2))
                {
                    Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
                }
                else
                {
                    Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
                }
            }
            else
            {
                if (Point1IsCloserToCenter(x3, y3, x4, y4))
                {
                    Console.WriteLine($"({x3}, {y3})({x4}, {y4})");
                }
                else
                {
                    Console.WriteLine($"({x4}, {y4})({x3}, {y3})");
                }
            }
        }
            private static bool Point1IsCloserToCenter(double x1, double y1, double x2, double y2)
            {
                var distance1 = CauculateDistanceBetweenPoints(x1, y1, 0, 0);
                var distance2 = CauculateDistanceBetweenPoints(x2, y2, 0, 0);
                if (distance1 <= distance2)
                {
                    return true;
                }
                return false;
            }
            private static double CauculateDistanceBetweenPoints(double x1, double y1, double x2, double y2)
            {
                var distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
                return distance;
            }
      
    }
}
