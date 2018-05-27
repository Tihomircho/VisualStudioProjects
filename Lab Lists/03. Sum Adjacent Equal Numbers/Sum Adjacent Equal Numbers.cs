using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Sum_Adjacent_Equal_Numbers
{
    class SumAdjacentEqualNumbers

    {
        static void Main(string[] args)
        {
            var numList = Console.ReadLine()
                  .Split(' ')
                  .Select(double.Parse)
                  .ToList();
            int i = 0;
            while (i < numList.Count - 1)
            {
                if (numList[i] == numList[i + 1])
                {
                    double num = numList[i] + numList[i + 1];
                    numList.Insert(i, num);
                    numList.RemoveAt(i + 1);
                    numList.RemoveAt(i + 1);
                    i = 0;
                    continue;
                }
                i++;
            }
            Console.WriteLine(string.Join(" ", numList));
        }
    }
}
