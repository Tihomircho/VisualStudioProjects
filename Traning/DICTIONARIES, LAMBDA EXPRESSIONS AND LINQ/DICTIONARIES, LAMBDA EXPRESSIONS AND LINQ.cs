using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DICTIONARIES__LAMBDA_EXPRESSIONS_AND_LINQ
{
    public class DICTIONARIES
    {
        public static void Main(string[] args)
        {

            var text = Console.ReadLine();

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
                    Console.WriteLine("{0} - {1}", ((char)(i + 'a')), count[i]);
                }
            }


        }
    }
}
