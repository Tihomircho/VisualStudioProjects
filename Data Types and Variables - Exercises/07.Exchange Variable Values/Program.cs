﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Exchange_Variable_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            Console.WriteLine("Before:\na = {0}\nb = {1}", a, b);
            int temp = a;
            a = b;
            b = temp;
            Console.WriteLine("After:\na = {0}\nb = {1}", a, b);
        }
    }
}

