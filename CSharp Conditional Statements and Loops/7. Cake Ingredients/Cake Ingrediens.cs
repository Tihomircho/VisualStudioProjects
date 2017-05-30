using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Cake_Ingredients
{
    class Program
    {
        static void Main(string[] args)
        {
            var ingredient = Console.ReadLine();
            var ingredientCount = 0;
            while (ingredient != "Bake!")
            {
                Console.WriteLine("Adding ingredient {0}.", ingredient);
                ingredientCount++;
                ingredient = Console.ReadLine();
            }
            Console.WriteLine("Preparing cake with {0} ingredients.", ingredientCount);
        }
    }
}
