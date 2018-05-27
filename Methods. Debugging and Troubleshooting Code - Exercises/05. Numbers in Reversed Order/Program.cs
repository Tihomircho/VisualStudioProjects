using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Numbers_in_Reversed_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal num = decimal.Parse(Console.ReadLine());
            var reversNum = ReversedNumbers(num);
            Console.WriteLine(reversNum);
        }

        private static decimal ReversedNumbers(decimal num)
        {
            var toString = new string(num.ToString().Reverse().ToArray());
          
            return decimal.Parse(toString);
        }
    
    }
}
