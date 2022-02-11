using System.Collections.Generic;

namespace KataStringCalculator
{
    public interface IValidate
    {
        bool Validate(IEnumerable<int> input);
    }
}
