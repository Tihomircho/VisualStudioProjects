using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Supermarket_Database
{
    class SupermarketDatabase
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var prodPriceQuantDict = new Dictionary<string, Dictionary<double, int>>();

            
            var productQuantity = new Dictionary<string, int>();

            while (input != "stocked")
            {
                var splittedInput = input.Split(' ');

                var product = splittedInput[0];
                var price = double.Parse(splittedInput[1]);
                var quantity = int.Parse(splittedInput[2]);

                if (!prodPriceQuantDict.ContainsKey(product))
                {
                    prodPriceQuantDict[product] = new Dictionary<double, int>();
                    prodPriceQuantDict[product].Add(price, quantity);

                    productQuantity[product] = quantity;
                }

                else
                {
                    
                    quantity += productQuantity[product];
                    productQuantity[product] = quantity;

                    
                    prodPriceQuantDict[product].Clear();
                    prodPriceQuantDict[product].Add(price, quantity);
                }

                input = Console.ReadLine();
            }

            var grandTotal = 0.0;

            foreach (var product in prodPriceQuantDict)
            {
                foreach (var priceQuant in product.Value)
                {
                    var currentTotal = priceQuant.Key * priceQuant.Value;
                    grandTotal += currentTotal;

                    Console.WriteLine($"{product.Key}: ${priceQuant.Key:f2} * {priceQuant.Value} = ${currentTotal:f2}");
                }
            }

            Console.WriteLine("------------------------------");
            Console.WriteLine($"Grand Total: ${grandTotal:f2}");
        }
    }
}
