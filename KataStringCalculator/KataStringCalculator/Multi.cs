using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KataStringCalculator.Validators;

namespace KataStringCalculator
{

   
    public class Multi : ICalculator
    {
        private IValidator _validator;


        public Multi(IValidator validator)
        {
            _validator = validator;
        }
        public int Calculate(string numbers)
        {
            var splitted = numbers.Splitter().ToList();
            var validatedData = _validator.Validate(splitted);
            int result = 1;
            foreach (var item in validatedData)
            {
                result = result * item;
            }
            return result;
        }
    }
}
