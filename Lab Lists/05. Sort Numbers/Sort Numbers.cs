using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Sort_Numbers
{
    class SortNumbers
    {
        static void Main(string[] args)
        {
            var numList = Console.ReadLine()
                  .Split(' ')
                  .Select(double.Parse)
                  .OrderBy(n => n)
                  .ToList();
            Console.WriteLine(string.Join(" <= ", numList));
        }
    }
}
