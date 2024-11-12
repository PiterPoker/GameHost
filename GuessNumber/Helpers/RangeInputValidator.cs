using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessNumber.Helpers
{
    internal class RangeInputValidator : IValidator
    {
        private readonly int _min;
        private readonly int _max;

        public RangeInputValidator(int min, int max)
        {
            _min = min;
            _max = max;
        }

        public bool IsValid(string input)
        { 
            bool isValid = int.TryParse(input, out int value);

            if (isValid)
            {
                isValid = value >= _min && value <= _max;
                if (!isValid)
                {
                    TypeTextHelper.TypeText($"Error! Number = {value} beyond communication limit from {_min} to {_max}.", ConsoleColor.Red);
                }
            }
            else
            {
                TypeTextHelper.TypeText($"Error! The line = {input} does not match the type int.", ConsoleColor.Red);
            }            
            Console.ResetColor();
            return isValid;
        }
    }
}
