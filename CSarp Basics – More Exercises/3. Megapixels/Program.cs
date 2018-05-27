using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Megapixels
{
    class Program
    {
        static void Main(string[] args)
        {
            int resolutionWidth = int.Parse(Console.ReadLine());
            int resolutionHeight = int.Parse(Console.ReadLine());

            double megapixels = Math.Round(resolutionWidth * resolutionHeight / 1000000.0, 1);
            Console.WriteLine($"{resolutionWidth}x{resolutionHeight} => {megapixels}MP");
        }
    }
}
