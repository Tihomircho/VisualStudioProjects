using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Net;

namespace ObjectAndClasses
{
      class ObjectAndClasses
    { 
        static void Main(string[] args)
        {
            // pesho gosho ana tisho
            var words = Console.ReadLine().Split(' ');
            var random = new Random();
            var result = new List<string>();

            for (int i = 0; i < words.Length; i++)
            {
                var curretnWord = words[i];
                var randomIndex = random.Next(0, words.Length);

                var tempWord = words[randomIndex];
                words[i] = tempWord;
                words[randomIndex] = curretnWord;
            }
            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
