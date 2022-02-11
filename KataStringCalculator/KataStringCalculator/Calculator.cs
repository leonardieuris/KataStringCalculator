using System.Linq;
using System;

namespace KataStringCalculator
{

    public class Calculator : ICalculator
    {
        private IValidate _validator;

        public Calculator(IValidate validator)
        {
            _validator = validator;
        }

        public int Add(string numbers)
        {
            var myinput = numbers.Splitter();
            if(_validator.Validate(myinput))
               return myinput.Sum();
            throw new Exception();
        }
           
    }
}
