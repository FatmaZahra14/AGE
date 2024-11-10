using System;

namespace SimpleProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // Greet the user and ask for their name
            Console.WriteLine("Hello! What's your name?");
            string name = Console.ReadLine();

            // Ask for their age
            Console.WriteLine($"Nice to meet you, {name}! How old are you?");
            int age = int.Parse(Console.ReadLine());

            // Calculate birth year
            int currentYear = DateTime.Now.Year;
            int birthYear = currentYear - age;

            // Display the result
            Console.WriteLine($"{name}, you were probably born in {birthYear}.");
        }
    }
}
