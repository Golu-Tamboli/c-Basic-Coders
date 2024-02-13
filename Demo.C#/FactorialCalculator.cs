using System;

namespace FactorialCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("Enter a number to calculate factorial:");
            number = Convert.ToInt32(Console.ReadLine());

            long factorial = CalculateFactorial(number);
            Console.WriteLine("Factorial of is: {factorial}");

            Console.ReadLine();
        }

        static long CalculateFactorial(int num)
        {
            if (num < 0)
            {
                throw new ArgumentException("Factorial is not defined for negative numbers.");
            }

            long result = 1;
            for (int i = 1; i <= num; i++)
            {
                result *= i;
            }

            return result;
        }
    }
}