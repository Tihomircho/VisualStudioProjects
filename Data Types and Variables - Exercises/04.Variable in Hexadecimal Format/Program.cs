using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Variable_in_Hexadecimal_Format
{
    class Program
    {
        static void Main(string[] args)
        {
            var hexqDecimalFormat = Console.ReadLine();
            var format = Convert.ToInt32(hexqDecimalFormat, 16);
            Console.WriteLine(format);
        }
    }
}
