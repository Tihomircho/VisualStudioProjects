using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extended_Arrays_And_Lists
{
    class ExtendedArraysAndLists
    {
        static void Main(string[] args)
        {

            string[] names = Console.ReadLine().Split();
            string temp = names[names.Length - 1];
            for (int i = names.Length - 1; i >= 1; i--)
            {
                names[i] = names[i - 1];
            }
            names[0] = temp;
            Console.WriteLine(string.Join(" ", names));
        }

    }
}
