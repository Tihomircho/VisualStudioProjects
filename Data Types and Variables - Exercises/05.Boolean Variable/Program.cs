using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Boolean_Variable
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = bool.Parse(Console.ReadLine());
             if (name == true)
            {
                Console.WriteLine("Yes");
            }
            else if (name==false)
            {
                Console.WriteLine("No");
            }
        }
    }
}
