using System.Collections.Generic;

namespace KataStringCalculator.Validators
{
    public abstract class AbstractValidator : IValidator
    {
        protected IValidator Next;

        public IValidator SetNext(IValidator validator)
        {
            Next = validator;
            return Next;
        }

        public abstract List<int> Validate(List<int> input);
        
    }
}
