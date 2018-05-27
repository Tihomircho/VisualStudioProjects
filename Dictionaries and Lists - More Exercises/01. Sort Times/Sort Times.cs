using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Sort_Times
{
    class SortTimes
    {
        static void Main(string[] args)
        {
            var times = Console.ReadLine().Split(' ');

            var orderedTimes = times.OrderBy(x => x);

            Console.WriteLine(string.Join(", ", orderedTimes));
        }
    }
}
