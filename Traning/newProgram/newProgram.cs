using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace newProgram
{
    class newProgram
    {
        static void Main(string[] args)
        {
            var words = File.ReadAllText("File2.txt").Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var text = File.ReadAllText("File1.txt").Split(new[] { '.', ',', '?', '!', '\'', '\n', '-', '\r' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(t => t.ToLower())
                .ToArray();

            var result = new Dictionary<string, int>();

            for (int i = 0; i < words.Length; i++)
            {
                var currenstWord = words[i];
                var currentWordCoint = 0;
                for (int j = 0; j < text.Length; j++)
                {
                    if (currenstWord == text[j])
                    {
                        currentWordCoint++;
                    }
                }
                result[currenstWord] = currentWordCoint;
            }
            var sortedResult = result
                .OrderBy(kvp => kvp.Value)
                .Select(kvp => $"{kvp.Key} - {kvp.Value}")
                .ToArray();
            File.WriteAllLines("File2.txt", sortedResult);
        }
    }
}
