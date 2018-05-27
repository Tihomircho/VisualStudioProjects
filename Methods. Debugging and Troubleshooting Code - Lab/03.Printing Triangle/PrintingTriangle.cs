using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Printing_Triangle
{
    class PrintingTriangle
    {

        public static void Main()
        {
            EnterTringleMethod();
        }
        static void PrintTringle(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
        static void EnterTringleMethod()
        {
            var n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                PrintTringle(1, i);
            }
            for (int i = n - 1; i >= 1; i--)
            {
                PrintTringle(1, i);
            }
        }
    }
}



