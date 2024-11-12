using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessNumber.Helpers
{
    internal static class TypeTextHelper
    {
        public static void TypeText(string message, ConsoleColor color)
        {
            Console.ForegroundColor = color;   
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
