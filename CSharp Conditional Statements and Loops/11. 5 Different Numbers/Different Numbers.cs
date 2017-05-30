using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._5_Different_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                var num1 = int.Parse(Console.ReadLine());
                var num2 = int.Parse(Console.ReadLine());
                var check = false;
                for (int i = num1; i <= num2; i++)
                {
                    for (int j = num1; j <= num2; j++)
                    {
                        for (int k = num1; k <= num2; k++)
                        {
                            for (int o = num1; o <= num2; o++)
                            {
                                for (int p = num1; p <= num2; p++)
                                {
                                    if (num1 <= i && i < j && j < k && k < o && o < p && p <= num2)
                                    {
                                        Console.WriteLine($"{i} {j} {k} {o} {p}");
                                        check = true;
                                    }
                                }
                            }
                        }
                    }
                }
                if (check == false)
                    Console.WriteLine("No");
            }
        }
    }
}
