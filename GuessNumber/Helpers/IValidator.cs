using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessNumber.Helpers
{
    internal interface IValidator
    {
        bool IsValid(string input);
    }
}
