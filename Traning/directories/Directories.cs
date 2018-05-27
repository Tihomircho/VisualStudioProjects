using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace directories
{
    class Directories
    {
        static void Main(string[] args)
        {
            var currentFiles = Directory.GetFiles("FindMySize");
            foreach (var item in currentFiles)
            {
                var fileinfo = new FileInfo(item);
            }
            
         
        }
    }
}
