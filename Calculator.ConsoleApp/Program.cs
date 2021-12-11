using System;

namespace Calculator.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Colouring the notes:
            // MENU
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\t--------------------------");
            Console.WriteLine("\tWelcome in Calculator app!\n");
            Console.WriteLine("\t1. Addition (+)");
            Console.WriteLine("\t2. Subtraction(-)");
            Console.WriteLine("\t3. Multiplication (*)");
            Console.WriteLine("\t4. Division (/)");
            Console.WriteLine("\t5. EXIT");
            Console.WriteLine("\t--------------------------");
            Console.ResetColor();

            for (; ; )
            {
                bool correctChoose = true;
                Console.WriteLine();
                Console.Write("Choose option: ");
                var operation = Console.ReadLine();

                // Add switch checking if the choosen number is correct (1-4)

                switch (operation)
                {
                    case "1":
                    case "2":
                    case "3":
                    case "4":
                        break;
                    case "5":
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("\tGOODBYE!");
                        Console.ResetColor();
                        System.Environment.Exit(0);
                        break;
                    default:
                        {
                            correctChoose = false;
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("There is no operation like that.");
                            Console.ResetColor();
                            break;
                        }
                }

                if (correctChoose)
                {
                    Console.Write("Input the first number: ");
                    var number1 = GetInput();

                    Console.Write("Input the second number: ");
                    var number2 = GetInput();

                    double result = 0;

                    Calculate(number1, number2, operation, ref result);

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"{number1} {OperationSign(operation)} {number2} = {Math.Round(result, 2)}");
                    Console.ResetColor();
                }
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
                    result = number1 + number2;
                    break;
                case "2":
                    result = number1 - number2;
                    break;
                case "3":
                    result = number1 * number2;
                    break;
                case "4":
                    // add try-catch dividing by zero
                    result = number1 / number2;
                    break;
                default:
                    throw new Exception("Wrong operation to calculate.");
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
