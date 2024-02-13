using System;

namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2, result;
            char operation;

            Console.WriteLine("Simple Calculator App");
            Console.WriteLine("Enter the first number:");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the second number:");
            num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the operation (+, -, *, /):");
            operation = Convert.ToChar(Console.ReadLine());

            switch (operation)
            {
                case '+':
                    result = num1 + num2;
                    Console.WriteLine("Result: " + num1 + " + " + num2 + " = " + result);
                    break;
                case '-':
                    result = num1 - num2;
                    Console.WriteLine("Result: " + num1 + " - " + num2 + " = " + result);
                    break;
                case '*':
                    result = num1 * num2;
                    Console.WriteLine("Result: " + num1 + " * " + num2 + " = " + result);
                    break;
                case '/':
                    if (num2 == 0)
                    {
                        Console.WriteLine("Cannot divide by zero!");
                    }
                    else
                    {
                        result = num1 / num2;
                        Console.WriteLine("Result: " + num1 + " / " + num2 + " = " + result);
                    }
                    break;
                default:
                    Console.WriteLine("Invalid operation");
                    break;
            }

            Console.ReadLine();
        }
    }
}