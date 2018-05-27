using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Sum_Reversed_Numbers
{
    class SumReversedNumbers
    {
        static void Main(string[] args)
        {
            string[] numbersStr = Console.ReadLine()
                  .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int sum = 0;
            for (int i = 0; i < numbersStr.Length; i++)
            {
                char[] number = numbersStr[i].ToCharArray();
                Array.Reverse(number);
                sum += int.Parse(string.Join("", number));
            }
            Console.WriteLine(sum);
        }
    }
}
