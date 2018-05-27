using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.English_Name_of_Last_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = Math.Abs(long.Parse(Console.ReadLine()));
            var ret = NameOfLastDigit(n);
            Console.WriteLine(ret);
        }
        static string NameOfLastDigit(long imputNumber)
        {
            long lastDigit = imputNumber % 10;
            string nameDigit = "";
            switch (lastDigit)
            { 
                case 0:
                Console.WriteLine("zero");
                break;
       
            }
            return nameDigit;
        }
    }
}
