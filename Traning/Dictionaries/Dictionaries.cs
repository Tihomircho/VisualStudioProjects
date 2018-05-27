using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionaries
{
    class Dictionaries
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, int>();
            dict["pesho"] = 65;
            dict["gosho"] = 45;

           //  dict.Remove("gosho");
            
            if (dict.ContainsKey("gosho"))
            {
                
                foreach (var item in  dict)
                {
                   
                    Console.WriteLine(dict);
                    Console.WriteLine(item.Value);
                }
            }
        }
    }
}
