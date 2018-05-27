using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lettersCount
{
    class lettersCount
    {
        static void Main(string[] args)
        {
            var text = "pesho gosho i ivan";
            var count = new int[26];

            foreach (var symbol in text)
            {
                if (char.IsLetter(symbol))
                {
                    count[symbol - 'a']++;
                }
            }
            for (int i = 0; i < count.Length; i++)
            {
                if (count[i] > 0)
                {
                    Console.WriteLine("{0}-{1}",(char)(i+'a'),count[i]);
                }
            }
        }
    }
}
