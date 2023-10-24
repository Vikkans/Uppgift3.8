using System;
namespace Consoleapp37
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();

            

            bool sign1Exists = false;
            bool sign2Exists = false;

            Console.WriteLine("Skriv in en sträng:");
            string userString = Console.ReadLine().ToLower();

            Console.WriteLine("Skriv två tecken:");
            string signs = Console.ReadLine().ToLower();

            char sign1 = signs[0];
            char sign2 = signs[1];

            for (int i = 0; i < userString.Length; i++)
            {
                if (userString[i] == sign1)
                {
                    sign1Exists = true;
                }
                else if (userString[i] == sign2)
                {
                    sign2Exists = true;
                }
            }

            if (sign1Exists && sign2Exists)
            {
                Console.WriteLine($" {sign1} och {sign2} finns med i {userString}.");
            }
            else if (sign1Exists)
            {
                Console.WriteLine($"Det finns  {sign1} med i {userString}.");
            }
            else if (sign2Exists)
            {
                Console.WriteLine($"Det finns  {sign2} med i {userString}.");
            }
            else
            {
                Console.WriteLine($"{sign1} eller ett {sign2} finns med i {userString}.");
            }
        }
    }
}