using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Strings_and_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            var hello = Console.ReadLine();
            var world = Console.ReadLine();
            object conkat1 = hello + " " + world;
            Console.WriteLine(conkat1);
        }
    }
}
