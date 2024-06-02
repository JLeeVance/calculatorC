using System;

namespace CalculatorConsoleCS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Calculator!");

            Services.CalculatorOptions printCalcOptions = new CalculatorConsoleCS.Services.CalculatorOptions();
            Services.GetInput inputService = new CalculatorConsoleCS.Services.GetInput();

            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            printCalcOptions.ReturnOptions(name);

            int selection = inputService.ReturningOptions();

            switch (selection)
            {
                case 1:
                    Console.WriteLine("Performing Addition...");
                    break;
                case 2:
                    Console.WriteLine("Performing Subtraction...");
                    break;
                case 3:
                    Console.WriteLine("Performing Multiplication...");
                    break;
                case 4:
                    Console.WriteLine("Performing Division...");
                    break;
                default:
                    break;
            }
        }
    }
}


