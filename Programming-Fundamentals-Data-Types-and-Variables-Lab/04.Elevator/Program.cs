using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            var personsCount = int.Parse(Console.ReadLine());
            var personsCapacity = int.Parse(Console.ReadLine());

         int curses = (int)Math.Ceiling(((double)personsCount / personsCapacity));
            Console.WriteLine(curses);

        }
    }
}
