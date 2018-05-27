using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(double.Parse);
            var result = new SortedDictionary<double, int>();
            foreach (var num in numbers)
            {
                if (!result.ContainsKey(num))
                {
                    result[num] = 1;
                }
                result[num]++;
            }
            foreach (var item in result)
            {
                Console.WriteLine(item.Key+"->"+item.Value);
            }
        }
    }
}
