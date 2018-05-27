using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Tourist_Information
{
    class Program
    {
        static void Main(string[] args)
        {
            var imperialUnit = Console.ReadLine();
            var value = double.Parse(Console.ReadLine());
            var metricValue = 0.0;
            var metricUnits = "";
            switch (imperialUnit)
            {
                case "miles":
                    metricUnits = "kilometres";
                    metricValue = value * 1.6;
                    break;
                case "inches":
                    metricUnits = "centimetrs";
                    metricValue = value * 2.54;
                    break;
                case "feet":
                    metricUnits = "centimeters";
                    metricValue = value * 30;
                    break;
                case "yards":
                    metricUnits = "meters";
                    metricValue = value * 0.91;
                    break;
                case "gallons":
                    metricUnits = "liters";
                    metricValue = value * 3.8;
                    break;
            }
            Console.WriteLine("{0} {1} =  {2:f2} {3}",value,imperialUnit,metricValue,metricUnits);
        }
    }
}
