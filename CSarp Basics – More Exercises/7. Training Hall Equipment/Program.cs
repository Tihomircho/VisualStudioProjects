using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Training_Hall_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double n = double.Parse(Console.ReadLine());
            double money = 0;
            for (int i = 0; i < n; i++)
            {
                String s = Console.ReadLine();

                double price = double.Parse(Console.ReadLine());

                double quantity = double.Parse(Console.ReadLine());
               

                money += price * quantity;
                if (quantity <= 2)
                    Console.WriteLine($"Adding {quantity} {s}s to cart.");
                else Console.WriteLine($"Adding {quantity} {s}s to cart.");
            }

            if (money <= budget)
            {
                Console.WriteLine($"Subtotal: ${money:F2}");
                Console.WriteLine($"Money left: ${Math.Abs(budget - money):F2}");
            }
            else
            {
                Console.WriteLine($"Subtotal: ${Math.Abs(money):F2}");
                Console.WriteLine($"Not enough. We need ${money - budget:F2} more.");
            }
        }
        
    }
}
