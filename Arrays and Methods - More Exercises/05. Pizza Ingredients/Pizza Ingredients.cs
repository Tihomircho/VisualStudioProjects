using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Pizza_Ingredients
{
    class PizzaIngredients
    {
        static void Main(string[] args)
        {
            var allIngredients = Console.ReadLine().Split(' ');
            var stringLenght = long.Parse(Console.ReadLine());

            var ingredientsCount = 0;

            var pizzaIngredients = new string[allIngredients.Length];

            foreach (var ingredient in allIngredients)
            {
                if (ingredient.Length == stringLenght)
                {
                    pizzaIngredients[ingredientsCount] = ingredient;
                    ingredientsCount++;
                    Console.WriteLine($"Adding {ingredient}.");

                    if (ingredientsCount == 10)
                    {
                        break;
                    }
                }
            }

            Console.WriteLine($"Made pizza with total of {ingredientsCount} ingredients.");
            Console.Write("The ingredients are: ");

            for (int i = 0; i < pizzaIngredients.Length; i++)
            {
                if (ingredientsCount > 1)
                {
                    Console.Write(pizzaIngredients[i] + ", ");
                    ingredientsCount--;
                }
                else if (ingredientsCount == 1)
                {
                    Console.Write(pizzaIngredients[i] + ".");
                    break;
                }
            }
            Console.WriteLine();
        }
    }
}
