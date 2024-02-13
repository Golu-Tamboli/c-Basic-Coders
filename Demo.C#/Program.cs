using System;

namespace h1project.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;

            Console.WriteLine("Welcome to Voting System");
            Console.WriteLine("Enter your age:");
            age = Convert.ToInt32(Console.ReadLine());

            if (age >= 18)
            {
                Console.WriteLine("You are eligible to vote.");
            }
            else
            {
                Console.WriteLine("You are not eligible to vote yet.");
            }

            Console.ReadLine();
        }
    }
}