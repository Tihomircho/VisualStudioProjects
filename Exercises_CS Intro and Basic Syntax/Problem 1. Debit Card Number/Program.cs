﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1.Debit_Card_Number
{
    class Program
    {
        static void Main(string[] args)
        {
           var num1 = int.Parse(Console.ReadLine());
           var num2 = int.Parse(Console.ReadLine());
           var num3 = int.Parse(Console.ReadLine());
           var num4 = int.Parse(Console.ReadLine());
            Console.WriteLine("{0:D4} {1:D4} {2:D4} {3:D4}",num1,num2,num3,num4);
        }
    }
}
