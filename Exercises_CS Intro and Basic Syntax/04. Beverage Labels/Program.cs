using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Beverage_Labels
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();
            var volume = double.Parse(Console.ReadLine());
            var ec = int.Parse(Console.ReadLine());
            var sc = int.Parse(Console.ReadLine());

            var vol = volume / 100;
            var kcal = ec * vol;
            var sug = sc *  vol;
            Console.WriteLine("{0}ml {1}: \n{2}kcal, {3}g sugars",volume,name,kcal,sug);


        }
    }
}
