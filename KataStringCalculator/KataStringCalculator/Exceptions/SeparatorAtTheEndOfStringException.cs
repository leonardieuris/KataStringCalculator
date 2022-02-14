using System;

namespace KataStringCalculator.Exceptions
{
    public class SeparatorAtTheEndOfStringException : Exception
    {
        public SeparatorAtTheEndOfStringException(string message): base(message)
        {

        }
    }
}
