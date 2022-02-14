using System.Linq;
using KataStringCalculator.Validators;

namespace KataStringCalculator
{

    public class Sum : ICalculator
    {
        private IValidator _validator;
        

        public Sum(IValidator validator)
        {
            _validator = validator;
        }

        public int Calculate(string numbers)
        {
            var splitted = numbers.Splitter().ToList();
            var validatedData = _validator.Validate(splitted);
            return validatedData.Sum();
        }
           
    }
}
