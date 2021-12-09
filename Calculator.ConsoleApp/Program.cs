using System;

namespace Calculator.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Welcome in Calculator app!");

                Console.Write("Input the first number: ");
                var number1 = GetInput();

                Console.Write("Input the second number: ");
                var number2 = GetInput();

                Console.WriteLine("What operation do you want to do: '+', '-', '*', '/'");
                var operation = Console.ReadLine();

                var result = Calculate(number1, number2, operation);

                Console.WriteLine($"{number1} {operation} {number2} = {result}");
            }
            catch (Exception ex)
            {
                // log to a file with the error information
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }
        private static int GetInput()
        {
            return int.Parse(Console.ReadLine());
        }
        private static int Calculate(int number1, int number2, string operation)
        {
            switch (operation)
            {
                case "+":
                    return number1 + number2;
                case "-":
                    return number1 - number2;
                case "*":
                    return number1 * number2;
                case "/":
                    return number1 / number2;
                default:
                    throw new Exception("There is no operation like that.");
            }
        }
    }
}
