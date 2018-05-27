using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.Print_Part_of_the_ASCII_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            var begin = int.Parse(Console.ReadLine()); 
            var end = int.Parse(Console.ReadLine());
            for (char @char =(char)begin; @char <= end; @char++)
            {
                Console.Write(@char+" ");
            }
        }
    }
}
