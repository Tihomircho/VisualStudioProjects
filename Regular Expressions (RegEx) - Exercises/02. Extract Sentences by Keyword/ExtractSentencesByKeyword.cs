using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02.Extract_Sentences_by_Keyword
{
    class ExtractSentencesByKeyword
    {
        static void Main(string[] args)
        {
            var word = Console.ReadLine();

            var text = Console.ReadLine()
                .Split(".!?".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            var pattern = $@"(\b{word}\b)";

            foreach (var sentence in text)
            {
                var match = Regex.Match(sentence, pattern);

                if (match.Success)
                {
                    Console.WriteLine(sentence.Trim());
                }
            }
        }
    }
}
