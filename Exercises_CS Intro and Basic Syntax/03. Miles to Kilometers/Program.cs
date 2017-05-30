using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Miles_to_Kilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            var mile  = double.Parse(Console.ReadLine());
            var km = mile * 1.60934;
            Console.WriteLine("{0:F2}",km);
        }
    }
}
