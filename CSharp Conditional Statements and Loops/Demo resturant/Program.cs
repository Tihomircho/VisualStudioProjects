using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantDiscount
{
    class Program
    {
        static void Main(string[] args)
        {
            var numOfGuests = int.Parse(Console.ReadLine());
            string package = Console.ReadLine();
            var price = 0.0;
            string hall = string.Empty;

            if (numOfGuests < 51)
            {
                price = 2500;
                hall = "Small Hall";
            }
            else if (numOfGuests < 101)
            {
                price = 5000;
                hall = "Terrace";
            }
            else if (numOfGuests <= 120)
            {
                price = 7500;
                hall = "Great Hall";
            }

            if (package == "Normal") price = (price + 500) * 0.95;
            else if (package == "Gold") price = (price + 750) * 0.90;
            else if (package == "Platinum") price = (price + 1000) * 0.85;

            if (numOfGuests > 120) Console.WriteLine("We do not have an appropriate hall.");
            else
            {
                Console.WriteLine($"We can offer you the {hall}");
                Console.WriteLine($"The price per person is {(price / numOfGuests):F2}$");
            }


        }
    }
}