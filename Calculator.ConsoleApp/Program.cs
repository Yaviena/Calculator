using System;

namespace Calculator.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // MENU
            Console.WriteLine("Welcome in Calculator app!");
            Console.WriteLine("1. Addition (+)");
            Console.WriteLine("2. Subtraction(-)");
            Console.WriteLine("3. Multiplication (*)");
            Console.WriteLine("4. Division (/)");
            Console.WriteLine("5. EXIT");

            for (; ; )
            {
                Console.WriteLine();
                Console.Write("Choose option: ");
                var operation = Console.ReadLine();
                if (operation == "5")
                    System.Environment.Exit(0);

                Console.Write("Input the first number: ");
                var number1 = GetInput();

                Console.Write("Input the second number: ");
                var number2 = GetInput();

                double result = 0;
                    
                Calculate(number1, number2, operation, ref result);

                Console.WriteLine($"{number1} {OperationSign(operation)} {number2} = {Math.Round(result, 2)}");
            }
        }
        private static double GetInput()
        {
            if (!double.TryParse(Console.ReadLine(), out double input))
                throw new Exception("The value is not a number!");
            
            return input;
        }
        private static void Calculate(double number1, double number2, string operation, ref double result)
        {
            switch (operation)
            {
                case "1":
                    result =  number1 + number2;
                    break;
                case "2":
                    result = number1 - number2;
                    break;
                case "3":
                    result = number1 * number2;
                    break;
                case "4":
                    result = number1 / number2;
                    break;
                default:
                    throw new Exception("There is no operation like that.");
            }
        }
        private static char OperationSign(string operation)
        {
            switch (operation)
            {
                case "1":
                    return '+';
                case "2":
                    return '-';
                case "3":
                    return '*';
                case "4":
                    return '/';
                default:
                    throw new Exception("Wrong operation.");
            }
        }
    }
}
