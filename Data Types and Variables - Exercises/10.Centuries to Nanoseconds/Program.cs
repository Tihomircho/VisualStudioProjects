using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _10.Centuries_to_Nanoseconds
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int centuries = int.Parse(Console.ReadLine());
            int years = centuries * 100;
            int days = (int)(years * 365.2422);
            int hours = 24 * days;
            BigInteger minutes = 60 * hours;
            BigInteger second = 60 * minutes;
            BigInteger miliSeconds = 1000 * second;
            BigInteger microSeconds = 1000 * miliSeconds;
            BigInteger nanoSeconds = 1000 * microSeconds;
            Console.WriteLine("{0} centuries = {1} years = {2} days = {3} hours = {4} " +
                "minutes = {5} seconds = {6} milliseconds = {7} microseconds = {8} nanoseconds", centuries, years, days, hours, minutes, second, miliSeconds, microSeconds, nanoSeconds);
        }
    }
}
