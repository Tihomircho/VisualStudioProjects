using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace traning1
{
    class ObjectAndClasses
    {
        static void Main()
        {
            var firstCat = new Cat
            {
                Name ="Gosho",
                Age = 5,
                Color = "Red",
                IsAsleep= true
            };

            Console.WriteLine(firstCat.Name);
            Console.WriteLine(firstCat.Age+ " - yars old");
            Console.WriteLine(firstCat.Color);
            Console.WriteLine(firstCat.IsAsleep);

        }
    }
}