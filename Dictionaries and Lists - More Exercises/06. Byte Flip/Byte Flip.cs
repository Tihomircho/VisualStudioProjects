using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Byte_Flip
{
    class ByteFlip
    {
        static void Main(string[] args)
        {
            var randomString = Console.ReadLine().Split(' ').ToList();


            randomString.RemoveAll(x => x.Length != 2);


            for (int i = randomString.Count - 1; i >= 0; i--)
            {
                var currentReversedText = string.Concat(randomString[i].Reverse());

                randomString[i] = currentReversedText;
            }

            randomString.Reverse();

            foreach (var item in randomString)
            {
                Console.Write(ConvertFromHexadecimalToChars(item));

            }

            Console.WriteLine();
        }

        public static char ConvertFromHexadecimalToChars(string input)
        {
            return (char)Int16.Parse(input, NumberStyles.AllowHexSpecifier);
        }
    }
}

