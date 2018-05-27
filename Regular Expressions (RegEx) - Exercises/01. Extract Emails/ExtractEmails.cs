using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _01.Extract_Emails
{
    class ExtractEmails
    {
        static void Main(string[] args)
        {
            var pattern = @"\b(?<!\S)[a-z]+([\.\-_]\w+)?\@\w+([-\.]\w+)*\.\w+([-\.]\w+)*\b";

            var text = Console.ReadLine()
                .TrimEnd('.');

            var matches = Regex.Matches(text, pattern);

            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);
            }
        }

    }
}
