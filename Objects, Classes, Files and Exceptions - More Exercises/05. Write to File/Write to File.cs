using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Write_to_File
{
    class    WriteToFile
    {
        static void Main(string[] args)
        {
           
            
                var text = File.ReadAllText(@"D:\Softuni\0.2 Tech Module - May 2017\Projects\10.ObjectsClassesFilesAndExceptiosMoreExers
                                        \05. Write to File\sample_text.txt");
                var chars = text.Where(c => ".,?!:".IndexOf(c) == -1).ToArray();

                File.WriteAllText(@"D:\Softuni\0.2 Tech Module - May 2017\Projects\10.ObjectsClassesFilesAndExceptiosMoreExers
            \05. Write to File\output.txt", string.Join("", chars));
            
        }
    }
}
    
