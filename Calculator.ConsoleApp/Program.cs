using System;

namespace Calculator.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. wyświetlenie nagłówka - opis aplikacji
            Console.WriteLine("Welcome in Calculator app!");
            // 2. Prośba o podanie pierwszej liczby
            Console.Write("Input the first number: ");
            // 3. Pobranie liczby od użytkownika
            var number1 = int.Parse(Console.ReadLine());
            // 4. Prośba o podanie drugiej liczby
            Console.Write("Input the second number: ");
            // 5. Pobranie drugiej liczby od użytkownika
            var number2 = int.Parse(Console.ReadLine());
            // 6. Prośba o podanie działania
            Console.WriteLine("What operation do you want to do: '+', '-', '*', '/'");
            // 7. Pobranie wybranego działania od użytkownika
            var operation = Console.ReadLine();
            // 8. Wykonanie obliczeń
            var result = 0;
            switch (operation)
            {
                case "+":
                    result = number1 + number2;
                    break;
                case "-":
                    result = number1 - number2;
                    break;
                case "*":
                    result = number1 * number2;
                    break;
                case "/":
                    result = number1 / number2;
                    break;
                default:
                    Console.WriteLine("There is no operation like that.");
                    break;
            }
            // 9. Wyświetlenie wyniku użytkownikowi
            Console.WriteLine($"{number1} {operation} {number2} = {result}");

            Console.ReadLine();
        }
    }
}
