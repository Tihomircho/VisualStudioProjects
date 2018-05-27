using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_Numbers0._._1000
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToList();

            if (number.Count > 0)
            {
                number.Sort();
                var previous = number[0];
                var count = 1;
                for (int i = 1; i < number.Count; i++)
                {
                    var currentNumber = number[i];
                    if (currentNumber == previous)
                    {
                        count++;
                    }
                    else
                    {
                        Console.WriteLine("{0}-{1}",previous,count);
                        count++;
                    }
                    previous = currentNumber;
                    
                }
                Console.WriteLine("{0}-{1}", previous, count);
            }
        }
    }
}
