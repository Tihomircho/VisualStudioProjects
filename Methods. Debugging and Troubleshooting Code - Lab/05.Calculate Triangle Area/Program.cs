using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Calculate_Triangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
          var width = double.Parse(Console.ReadLine());
          var hight= double.Parse(Console.ReadLine());
          var area = TringleArea(width, hight);
            Console.WriteLine(area);
        }
        static double TringleArea(double width, double hight)
        {
            return width * hight / 2;
        }
    }
}
