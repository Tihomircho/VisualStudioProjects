using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Restaurant_Discount
{
    class Program
    {
        static void Main(string[] args)
        {
            var groupsize = int.Parse(Console.ReadLine());
            var package = Console.ReadLine().ToLower();
            var priceOfHall = 0.0;
            string hall = string.Empty;
            
            if(groupsize < 51)
            {
                priceOfHall = 2500;
                hall = "Small Hall";
            }
            else if (groupsize < 101)
            {
                priceOfHall = 5000;
                hall = "Terrace";
            }
            else if(groupsize <= 120)
            {
                priceOfHall = 7500;
                hall = "Great Hall";
            }
            if (package == "normal") priceOfHall = (priceOfHall + 500) * 0.95;
            else if (package == "gold") priceOfHall = (priceOfHall + 750) *0.90;
            else if (package == "platinum") priceOfHall = (priceOfHall + 1000) * 0.85;
            if (groupsize > 120)
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }
            else
            {
                Console.WriteLine("We can offer you the {0}",hall);
                Console.WriteLine($"The price per person is {(priceOfHall/groupsize):F2}$");
            }
        }
    }
}
