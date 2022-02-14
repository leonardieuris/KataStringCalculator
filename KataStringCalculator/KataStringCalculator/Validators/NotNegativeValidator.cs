using System.Collections.Generic;
using System.Linq;
using KataStringCalculator.Exceptions;

namespace KataStringCalculator.Validators
{
    public class NotNegativeValidator : AbstractValidator
    {
        public override List<int> Validate(List<int> input)
            =>
           input.Any(x => x < 0) ?
            throw new NegativeNumbersException() :
          (Next == null ? input : Next.Validate(input));
        
    }
}
