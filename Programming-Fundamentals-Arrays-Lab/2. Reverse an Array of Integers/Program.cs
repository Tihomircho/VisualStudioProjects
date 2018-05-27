using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Reverse_an_Array_of_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var num = new int[n];
            for (int i = 0; i < n; i++)
            {
                num[i] = int.Parse(Console.ReadLine());
                
            }
            for (int i = n-1; i >= 0; i--)
            {
                Console.Write(num[i]+" ");
                
            }
            Console.WriteLine();
        }
    }
}
