using System;

namespace Mod3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            var name = Console.ReadLine();

            Console.Write("Enter your age: ");
            byte age = ((byte)int.Parse(Console.ReadLine()));

            Console.WriteLine($"\nYour name is {name} and age {age}");

            Console.Write("\nEnter your birthdate date: ");
            var day = Console.ReadLine();

            Console.WriteLine($"Your britdate is {day}");

            Console.ReadKey();
        }
    }
}

