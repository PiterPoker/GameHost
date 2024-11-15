﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessNumber.Services
{
    internal class NumberGeneratorService : IGeneratorService
    {
        private readonly Random _random;
        public NumberGeneratorService(Random random) 
        {
            _random = random;
        }

        public int Generate(int min, int max)
        {
            return _random.Next(min, max);
        }
    }
}
