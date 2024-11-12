using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessNumber.Services
{
    internal interface IGeneratorService
    {
        int Generate(int min, int max);
    }
}
