using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.House_Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            //    long price1 = long.Parse(Console.ReadLine());
            //    long price2 = long.Parse(Console.ReadLine());
            //
            //    if (price1 > price2)
            //    {
            //        var totalPriceInt = price1 * 10;
            //        var toitalPriceSbyte = price2 * 4;
            //        long allPrices = totalPriceInt + toitalPriceSbyte;
            //        Console.WriteLine(allPrices);
            //    }
            //    else if (price1 < price2)
            //    {
            //        var totalPriceSbyte =(byte) price1 * 4;
            //        var totalPriceInt = price2 * 10;
            //        long allPrices = totalPriceInt + totalPriceSbyte;
            //        Console.WriteLine(allPrices);
            long price1 = long.Parse(Console.ReadLine());
            long price2 = long.Parse(Console.ReadLine());
            Console.WriteLine(Math.Max(price1, price2) * 10 + Math.Min(price1, price2) * 4);
        }
    }
}
