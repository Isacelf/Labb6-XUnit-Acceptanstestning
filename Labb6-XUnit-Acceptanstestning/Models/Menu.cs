using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb6_XUnit_Acceptanstestning.Models
{
    public class Menu
    {
        public static void MainMenu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Welcome to the Calculator-App!");
                Console.WriteLine("Choose an operation:");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Division");
                Console.WriteLine("5. Show previous calculations");
                Console.WriteLine("6. Exit");

                var input = UserInput.GetStringInput();

                switch (input)
                {
                    case "1":
                        Calculator.PerformOperation(Calculator.Add, "sum");
                        break;
                    case "2":
                        Calculator.PerformOperation(Calculator.Subtract, "difference");
                        break;
                    case "3":
                        Calculator.PerformOperation(Calculator.Multiply, "product");
                        break;
                    case "4":
                        Calculator.PerformOperation(Calculator.Divide, "quotient");
                        break;
                    case "5":
                        ShowCalculations();
                        break;
                    case "6":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please choose a number between 1 and 6.");
                        Console.ReadKey();
                        break;
                }
            }
        }

        private static void ShowCalculations()
        {
            Console.WriteLine("Previous calculations:");
            foreach (var calc in Calculator.Calculations)
            {
                Console.WriteLine(calc);
            }
            Console.ReadKey();
        }
    }
}