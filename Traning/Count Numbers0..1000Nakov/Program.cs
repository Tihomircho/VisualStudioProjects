using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_Numbers0._._1000Nakov
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            var count = new int[9];
            foreach (var num in nums)
            {
                count[num]++;
            }
            for (int i = 0; i < count.Length; i++)
            {
                if(count[i] > 0)
                Console.WriteLine(""+i+"->"+count[i]);
            }
        }
    }
}
