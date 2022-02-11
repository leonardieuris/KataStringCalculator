using System.Collections.Generic;
using System.Linq;
using KataStringCalculator.Exceptions;

namespace KataStringCalculator
{
    public class Validator : IValidate
    {
        public bool Validate(IEnumerable<int> input)
            =>
           input.Any(x => x < 0) ? 
            throw new NegativeNumbersException():
          true;
        
    }
}
