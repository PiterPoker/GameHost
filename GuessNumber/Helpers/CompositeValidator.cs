using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessNumber.Helpers
{
    internal class CompositeValidator : ICompositeValidator, IValidator
    {
        private readonly List<IValidator> _validators;

        public CompositeValidator()
        {
            _validators = new List<IValidator>();
        }

        public void Add(IValidator validator)
        {
            _validators.Add(validator);
        }

        public bool Remote(IValidator validator)
        {
            return _validators.Remove(validator);
        }

        public bool IsValid(string input)
        {
            return _validators.All(v => v.IsValid(input));
        }

    }
}
