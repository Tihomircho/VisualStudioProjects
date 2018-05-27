using System.Collections.Generic;
using System.Linq;
using System;

namespace _06.Fibonacci_Numbers
{
    class Program
    {

        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            if (n == 0)
            {
                Console.WriteLine(1);
            }
            else
            {
                Console.WriteLine(TakeFibonachiNumbers(n));
            }
                
        }

        private static int TakeFibonachiNumbers(int n)
        {
            var f1 = 0; 
            var f2 = 1; 
            var f3 = 0;
            for (int i = 1; i <=n; i++)
            {
                f3 = f1 + f2;
                f1 = f2;
                f2 = f3;
            }
            return f3;
        }
    }
}
