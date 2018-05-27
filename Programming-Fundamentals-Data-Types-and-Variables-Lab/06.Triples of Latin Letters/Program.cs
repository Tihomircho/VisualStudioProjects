using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Triples_of_Latin_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            var count = int.Parse(Console.ReadLine());

            var letters = Enumerable.Range('a', count).Select(a => (char)a).ToArray();

            var letterCount = letters.Length;
            for (int first = 0; first < letterCount; first++)
            {
                for (int second = 0; second < letterCount; second++)
                {
                    for (int third = 0; third < letterCount; third++)
                    {
                        Console.WriteLine("{0}{1}{2}", letters[first], letters[second], letters[third]);
                    }
                }
            }
        }
    }
}