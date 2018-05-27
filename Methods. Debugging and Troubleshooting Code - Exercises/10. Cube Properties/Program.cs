using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Cube_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            double side = double.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            PrintResultOfCalculat(side, input);
        }

        private static void PrintResultOfCalculat(double side, object input)
        {
            switch (input)
            {
                case "face":
                    Console.WriteLine("{0:f2}", GetFace(side));
                    return;

                case "space":
                    Console.WriteLine("{0:f2}",GetSpace(side));
                    return;

                case "volume":
                    Console.WriteLine("{0:f2}",GetVolume(side));
                    return;

                case "area":
                    Console.WriteLine("{0:f2}",GetArea(side));
                    return;
            }
        }
        private static double GetFace(double side)
        {
            double face = Math.Sqrt(Math.Pow(side, 2) * 2);
            return face;
        }
        private static double GetSpace(double side)
        {
            double space = Math.Sqrt(Math.Pow(side, 2) * 3);
            return space;
        }
        private static double GetVolume(double side)
        {
            double volume = Math.Pow(side, 3);
            return volume;
        }
        private static double GetArea(double side)
        {
            double area = Math.Pow(side, 2) * 6;
            return area;
        }
    }
}
