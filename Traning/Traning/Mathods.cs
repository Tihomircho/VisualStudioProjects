using System;

namespace Traning
{
    class Mathods
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                for (int j = 0; j < i-1; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine(i);
            }

        }
    }
}
