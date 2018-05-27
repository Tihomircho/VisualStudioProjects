using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Convert_Speed_Units
{
    class Program
    {
        static void Main(string[] args)
        {
            var distanceInMeters = int.Parse(Console.ReadLine());
            var hours = float.Parse(Console.ReadLine());
            var minutes = float.Parse(Console.ReadLine());
            var seconds = float.Parse(Console.ReadLine());

            var totalSecond = seconds + minutes * 60 + (hours * 60 * 60);
            var meterPerSecond = distanceInMeters / totalSecond;
            var kilometersPerHour = (distanceInMeters / 1000) / (totalSecond / 60 / 60);
            var milesPerHour = (distanceInMeters / 1609f) / (totalSecond / 60 / 60);

            Console.WriteLine(meterPerSecond);
            Console.WriteLine(kilometersPerHour);
            Console.WriteLine(milesPerHour);
        }
    }
}
