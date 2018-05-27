using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Catch_the_Thief
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            long maxValue = 0l;
            switch (type)
            {
                case "sbyte":
                    maxValue = sbyte.MaxValue;
                    break;
                case "int":
                    maxValue = int.MaxValue;
                    break;
                case "long":
                    maxValue = long.MaxValue;
                    break;
            }
            int n = int.Parse(Console.ReadLine());
            long thiefsId = long.MinValue;
            for (int i = 0; i < n; i++)
            {
                long temId = long.Parse(Console.ReadLine());
                if (temId > thiefsId && temId <= maxValue)
                {
                    thiefsId = temId;
                }
            }
            Console.WriteLine(thiefsId);
        }
    }
}
