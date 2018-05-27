using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Array_Statistics
{
    class ArrayStatistics
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var max = int.MinValue;
            var min = int.MaxValue;
            var sum = 0;
            double average = 1.0;
            for (int i = 0; i < arr.Length; i++)
            {
                var currentNum = arr[i];
                if (currentNum > max)
                {
                    max = currentNum;
                }
                if (currentNum < min)
                {
                    min = currentNum;
                }
                sum += currentNum;
                average = (double)sum / arr.Length;
            }
            Console.WriteLine($"Min = {min}");
            Console.WriteLine($"Max = {max}");
            Console.WriteLine($"Sum = {sum}");
            Console.WriteLine($"Average = {average}");
        }
    }
}
