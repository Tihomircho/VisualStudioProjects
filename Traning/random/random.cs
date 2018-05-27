
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
namespace random
{
    class random
    {
        // static void Main(string[] args)
        //
        // {
        //     int n = int.Parse(Console.ReadLine());
        //
        //     BigInteger result = 1;
        //     for (int i = 1; i <= n; i++)
        //     {
        //         result = result * i;
        //     }
        //     Console.WriteLine(result);
        // }
        static void Main()
        {
            var firstPointParts = Console.ReadLine().Split(' ');
            var first = new Point()
            {
                X = double.Parse(firstPointParts[0]),
                Y = double.Parse(firstPointParts[1]),
            };
            var secoundPintParts = Console.ReadLine().Split(' ');
            var secound = new Point()
            {
                X = double.Parse(firstPointParts[0]),
                Y = double.Parse(firstPointParts[1]),
            };
          }
        public static double CalculationDistance(Point first ,Point secound)
        {
            var diffX=
        }
    }
}
