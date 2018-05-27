using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Square_Numbers
{
    class SquareNumbers

    {
        static void Main(string[] args)
        {
            var numList = Console.ReadLine()
                   .Split(' ')
                   .Select(int.Parse)
                   .Where(n => Math.Sqrt(n) == (int)Math.Sqrt(n))
                   .OrderByDescending(n => n)
                   .ToList();
            Console.WriteLine(string.Join(" ", numList));
        }
    }
}
