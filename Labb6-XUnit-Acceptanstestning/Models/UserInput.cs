using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb6_XUnit_Acceptanstestning.Models
{
    public static class UserInput
    {
        public static string GetStringInput()
        {
            return Console.ReadLine();
        }

        public static decimal GetDecimalInput(string prompt)
        {
            Console.Write(prompt);
            return Convert.ToDecimal(Console.ReadLine());
        }
    }
}