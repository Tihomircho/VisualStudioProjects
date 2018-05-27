using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace FilesAndExecptions
{
    class FilesAndExecptions
    {
        static void Main(string[] args)
        {
            string[] names = { "tiho", "ana", "gosho", "ivan" };
            File.WriteAllLines("file.txt", names);
            string[] lines= File.ReadAllLines("file.txt");
            var oddnames = lines.Where((line ,index) => index % 2 == 1);
            File.WriteAllLines("odd.txt", oddnames);
            string[] lines2 = File.ReadAllLines("odd.txt");
            var number = lines2.Select((line, index) => $"{index}.{line}");
            File.WriteAllLines("odd.txt",number);
            
        }
    }
}
