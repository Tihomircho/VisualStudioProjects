﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Append_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            var stringList = Console.ReadLine()
                  .Split('|')
                  .ToList();
            var finalList = new List<List<int>>();
            for (int i = 0; i < stringList.Count; i++)
            {
                finalList.Add(new List<int>());
                finalList[i] = stringList[i]
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToList();
            }

            for (int i = finalList.Count - 1; i >= 0; i--)
            {
                Console.Write(string.Join(" ", finalList[i]) + " ");
            }
            Console.WriteLine();
        }
    }
}
