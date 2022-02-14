using System.Collections.Generic;
using System.Linq;

namespace KataStringCalculator.Validators
{
    public class NumberLimitValidator : AbstractValidator
    {
        public override List<int> Validate(List<int> input)
        {
            var list = input.Where(x => x < 1001).ToList();
            if (Next == null)
                return list;
            return Next.Validate(list);


        }
   
    }
}
