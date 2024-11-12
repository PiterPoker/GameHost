using GameDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessNumber.Models
{
    internal record AppSettings : Setting
    {
        public AppSettings() : base("Guess number")
        {
        }

        private int maxAttempts = 3;
        private int maxNumber = 100;
        private int minNumber = 1;

        public int MinNumber { get => minNumber; init => minNumber = value; }
        public int MaxNumber { get => maxNumber; init => maxNumber = value; }
        public int MaxAttempts { get => maxAttempts; init => maxAttempts = value; }
    }
}
