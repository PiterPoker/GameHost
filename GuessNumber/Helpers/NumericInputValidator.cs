using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessNumber.Helpers
{
    internal class NumericInputValidator : IValidator
    {
        public bool IsValid(string input)
        {
            bool isValid = int.TryParse(input, out _);
            if (!isValid)
            {
                TypeTextHelper.TypeText($"Error! The line = {input} does not match the type int.", ConsoleColor.Red);
            }
            return isValid;
        }
    }
}
