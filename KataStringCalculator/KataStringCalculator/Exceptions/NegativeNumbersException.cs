using System;

namespace KataStringCalculator.Exceptions
{
    public class NegativeNumbersException : Exception
    {
        public NegativeNumbersException() : base("Found Negative Numbers")
        {

        }
    }
}
