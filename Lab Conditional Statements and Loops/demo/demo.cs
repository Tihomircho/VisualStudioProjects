using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    class demo
    {
        static void Main(string[] args)



        {
            var hours = int.Parse(Console.ReadLine());
            var minutes = int.Parse(Console.ReadLine());
            minutes = minutes + 30;
            if (minutes >= 60)
            {
                hours++;
                minutes = minutes - 60;
            }
            if (hours >= 24)
            {
                hours = hours - 24;
            }
            if (minutes > 9)
            {
                Console.WriteLine("{0}:{1}", hours, minutes);
            }
            else
            {
                Console.WriteLine("{0}:0{1}",hours,minutes);
            }
            
        }
    }
}
