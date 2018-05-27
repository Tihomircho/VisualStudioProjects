﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _05.Only_Letters
{
    class OnlyLetters
    {
        static void Main(string[] args)
        {
            var message = Console.ReadLine();

            var pattern = @"(?<digit>\d+)(?<letter>\w)";
            var matches = Regex.Matches(message, pattern);

            var correctedMessage = new StringBuilder(message);

            foreach (Match match in matches)
            {
                var digit = match.Groups["digit"].Value;
                var letter = match.Groups["letter"].Value;

                correctedMessage.Replace(digit, letter);
            }

            Console.WriteLine(correctedMessage.ToString());
        }
    }
}
