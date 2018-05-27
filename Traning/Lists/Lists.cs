using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    class Lists
    {
        static void Main(string[] args)
        {
            //8 2 2 8 2 2 3 7

            var number = Console.ReadLine()
                 .Split(' ')
                 .Select(int.Parse)
                 .ToList();

            if (number.Count > 0)
            {
                number.Sort();
                var previos = number[0];
                var count = 1;

                for (int i =1; i < number.Count; i++)
                {
                    var currentNumber = number[i];
                    if (currentNumber == previos)
                    {
                        count++;
                    }
                    else
                    {
                        Console.WriteLine("{0}->{1}", previos,count);
                        count = 1;
                    }
                    previos = currentNumber;
                }
                Console.WriteLine("{0}->{1}", previos, count);
            }
            
        }
    }
}
