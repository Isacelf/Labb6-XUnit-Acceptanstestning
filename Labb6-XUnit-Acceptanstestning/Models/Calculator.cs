using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb6_XUnit_Acceptanstestning.Models
{
    public class Calculator
    {
        public static List<string> Calculations { get; private set; } = new List<string>();

        public static (decimal Result, string Operation) Add(decimal x, decimal y)
        {
            var result = x + y;
            var operation = $"{x} + {y} = {result}";
            return (result, operation);
        }

        public static (decimal Result, string Operation) Subtract(decimal x, decimal y)
        {
            var result = x - y;
            var operation = $"{x} - {y} = {result}";
            return (result, operation);
        }

        public static (decimal Result, string Operation) Multiply(decimal x, decimal y)
        {
            var result = x * y;
            var operation = $"{x} * {y} = {result}";
            return (result, operation);
        }

        public static (decimal Result, string Operation) Divide(decimal x, decimal y)
        {
            string operation;
            decimal result;

            if (y == 0)
            {
                operation = $"{x} / {y} = Cannot divide by zero.";
                return (0, operation);
            }

            result = x / y;
            operation = $"{x} / {y} = {result}";
            return (result, operation);
        }

        public static void PerformOperation(Func<decimal, decimal, (decimal Result, string Operation)> operation, string operationName)
        {
            try
            {
                decimal x = UserInput.GetDecimalInput("Enter the first decimal number: ");
                decimal y = UserInput.GetDecimalInput("Enter the second decimal number: ");
                var (result, operationDetails) = operation(x, y);
                Console.WriteLine($"The {operationName} is: {result}");
                Calculations.Add(operationDetails);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Invalid input. Please enter valid decimal numbers.");
            }
            Console.ReadKey();
        }
    }
}
