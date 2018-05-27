using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Number_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = Console.ReadLine();
            {
                try
                {
                    long.Parse(number);
                    Console.WriteLine("integer");
                }
                catch (Exception)
                {
                    try
                    {
                        decimal.Parse(number);
                        Console.WriteLine("floating-point");
                    }
                    catch (Exception)
                    {

                    }
                }
            }
            
        }
    }
}