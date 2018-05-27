using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Multiply_Evens_by_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = Math.Abs (int.Parse(Console.ReadLine()));
            Console.WriteLine($"{GetMultipleOfEvensAndOdds(n)}");
        }
        static int GetMultipleOfEvensAndOdds(int n)
        {
            int sumOfodd = GetoddSum(n);
            int sumOfevens =  GetEvenSum(n);
            int result = sumOfodd * sumOfevens;
            return result;

        }
        static int GetoddSum(int n)
        {
            int sum = 0;
            while (n > 0)
            {
                int lastDigit = n % 10; 
                if (lastDigit % 2 != 0)
                {
                    sum += lastDigit;
                }
                n /= 10;
            }
            return sum;
        }
        static int GetEvenSum(int n)
        {
            int sum = 0;
            while(n > 0)
            {
                int lastDigit = n % 10;
                if (lastDigit % 2 == 0)
                {
                    sum += lastDigit;
                }
                n /= 10;
            }
            return sum;
        }
    }
}
