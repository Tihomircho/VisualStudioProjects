﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Triangle_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            for (int i = 1; i <=n; i++)
            {
                for (int j = 0; j < i-1; j++)
                {
                    Console.Write(i+" ");
                }
                Console.WriteLine(i);
            }
        }
    }
}
