using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace damo_proba
{
    class Program
    {
        static void Main(string[] args)
        {
            var day = Console.ReadLine().ToLower();
            var age = int.Parse(Console.ReadLine());
            int price = 0;
            if ((day == "weekday") && (age >= 0 && age <= 18) || (age > 64 && age <= 122))
            {
                price = 12;
            }
            else if (age > 18 && age <= 64)
            {
                price = 18;
            }
            if ((day == "weekend") && (age >= 0 && age <= 18) || (age > 64 && age <= 122))
            {
                price = 15;
            }
            else if (age >18 && age <= 64)
            {
                price = 20;
            }
            if ((day=="holiday") && (age <= 18))
            {
                price = 5;
            }
            else if (age > 18 && age <= 64)
            {
                price = 12;
            }
            else if (age > 64 && age <= 122)
            {
                price = 10;
            }
                Console.WriteLine($"{price}$");
            if ((day =="weekday" && day =="weekend" && day== "holiday") && (age > 1000 && age < -1000))
            {
                Console.WriteLine("Error!");
            }
        }
    }
}
