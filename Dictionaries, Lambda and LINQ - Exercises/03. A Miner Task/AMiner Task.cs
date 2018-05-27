using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.A_Miner_Task
{
    class AMinerTask
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> input = new Dictionary<string, int>();

            while (true)
            {
                string keyName = Console.ReadLine();
                if (keyName == "stop")
                {
                    break;
                }
                else if (input.ContainsKey(keyName))
                {
                    input[keyName] += int.Parse(Console.ReadLine());
                }
                else
                {
                    input[keyName] = int.Parse(Console.ReadLine());
                }
            }

            foreach (KeyValuePair<string, int> kvp in input)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
