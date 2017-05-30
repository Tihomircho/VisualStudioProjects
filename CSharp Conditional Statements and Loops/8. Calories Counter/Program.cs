using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Calories_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int cheese = 500;
            int tomatoSause = 150;
            int salami = 600;
            int peper = 50;
            int calories = 0;

            for (int i = 0; i < number; i++)
            {
                string ingredient = Console.ReadLine().ToLower();
                switch (ingredient)
                {
                    case "cheese":
                        calories += cheese; break;
                    case "tomato sauce":
                        calories += tomatoSause; break;
                    case "salami":
                        calories += salami; break;
                    case "pepper":
                        calories += peper; break;
                    default: continue;
                }
            }
            Console.WriteLine($"Total calories: {calories}");
        }
    }

}
        
   

