﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace _05.Weather_Forecast
{
    class Program
    {
        static void Main(string[] args)
        {
            string numberString = Console.ReadLine();
            try
            {
                sbyte.Parse(numberString);
                Console.WriteLine("Sunny");
            }
            catch (Exception)
            {
                try
                {
                    int.Parse(numberString);
                    Console.WriteLine("Cloudy");
                }
                catch (Exception)
                {
                    try
                    {
                        long.Parse(numberString);
                        Console.WriteLine("Windy");
                    }
                    catch (Exception)
                    {
                        try
                        {
                            double.Parse(numberString);
                            Console.WriteLine("Rainy");
                        }
                        catch (Exception)
                        {
                        }
                    }
                }
            }
        }
    }
}

