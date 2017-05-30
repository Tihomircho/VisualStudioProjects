using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _3.Employee_Data
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();
            var age = int.Parse(Console.ReadLine());
            var id = int.Parse(Console.ReadLine());
            var salary = double.Parse(Console.ReadLine());
            Console.WriteLine("Name: {0} \nAge: {1} \nEmployee ID: {2:D8}\n Salary {3:F2}", name, age, id, calary);

        }
    }
}
