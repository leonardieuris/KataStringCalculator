using System.Linq;
using KataStringCalculator.Validators;

namespace KataStringCalculator
{

    public class Calculator : ICalculator
    {
        private IValidator _validator;
        

        public Calculator(IValidator validator)
        {
            _validator = validator;
        }

        public int Add(string numbers)
        {
            var splitted = numbers.Splitter().ToList();
            var validatedData = _validator.Validate(splitted);
            return validatedData.Sum();
        }
           
    }
}
