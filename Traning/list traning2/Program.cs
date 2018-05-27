using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list_traning2
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = Console.ReadLine()
                 .Split(' ')
                 .Select(int.Parse)
                 .Reverse()
                 .ToList();
                 
            var result = 0;
            for (int i = num.Count; i > 0; i--)
            {
               
                if (num.Count > 0)
                {
                    Console.WriteLine(string.Join(",",num.Count));
                }
            }

        }
    }
}
