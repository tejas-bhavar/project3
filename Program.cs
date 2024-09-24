using System;

class Calculator
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter first number:");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter second number:");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Choose an operation (+, -, *, /):");
        char operation = Console.ReadKey().KeyChar;
        Console.WriteLine();

        double result;

        switch (operation)
        {
            case '+':
                result = num1 + num2;
                break;
            case '-':
                result = num1 - num2;
                break;
            case '*':
                result = num1 * num2;
                break;
            case '/':
                result = num1 / num2;
                break;
            default:
                Console.WriteLine("Invalid operation.");
                return;
        }

        Console.WriteLine($"Result: {result}");
        Console.ReadLine();
    }
}
