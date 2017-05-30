using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Choose_a_Drink_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            var profession = Console.ReadLine().ToLower();
            var quantity = int.Parse(Console.ReadLine());

            if (profession == "athlete")
            {
                double waterPrice = 0.70;
                double LastPrice = waterPrice * quantity;
                Console.WriteLine("The Athlete has to pay {0:F2}.", LastPrice);
            }
            else if (profession == "softuni student")
            {
                double beerPrice = 1.70;
                double LastPrice = beerPrice * quantity;
                Console.WriteLine("The SoftUni Student has to pay {0:F2}.", LastPrice);
            }
            else if (profession == "businessman")
            {
                double coffeePrice = 1.00;
                double LastPrice = coffeePrice * quantity;
                Console.WriteLine("The Businessman has to pay {0:F2}.", LastPrice);
            }
            else if (profession == "businesswoman")
            {
                double coffeePrice = 1.00;
                double LastPrice = coffeePrice * quantity;
                Console.WriteLine("The Businesswoman has to pay {0:F2}.", LastPrice);
            }
            else
            {
                double teaPrice = 1.20;
                double LastPrice = teaPrice * quantity;
                Console.WriteLine("The Chef has to pay {0:F2}.", LastPrice);
            }
        }
    }
}
