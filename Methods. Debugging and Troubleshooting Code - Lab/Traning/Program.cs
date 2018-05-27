using System;

namespace Traning
{
    class Program
    {

        public static void Main()
        {
           var fullName = GetFullName("Pesho", "\nPetrov");
            Console.WriteLine(fullName);
        }
        public static string GetFullName(string firstName, string lastName)
        {
            return $"{firstName} {lastName}";
        }
        
    }
}
