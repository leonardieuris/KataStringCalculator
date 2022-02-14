using System.Collections.Generic;

namespace KataStringCalculator.Validators
{
    public interface IValidator
    {
        List<int> Validate(List<int> input);
    }
}
