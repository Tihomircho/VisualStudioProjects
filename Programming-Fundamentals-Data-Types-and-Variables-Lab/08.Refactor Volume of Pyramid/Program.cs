﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Refactor_Volume_of_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.Write("Length: ");
           var areaOfBase = double.Parse(Console.ReadLine());
            Console.Write("Width: ");
           var height = double.Parse(Console.ReadLine());
            Console.Write("Height: ");
           var volume = double.Parse(Console.ReadLine());
           volume = (areaOfBase * height * volume ) / 3;
            Console.WriteLine("Pyramid Volume: {0:F2}", volume);

        }
    }
}
