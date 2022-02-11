using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataStringCalculator.Exceptions
{
    public class NegativeNumbersException : Exception
    {
        public NegativeNumbersException() : base("Found Negative Numbers")
        {

        }
    }
}
