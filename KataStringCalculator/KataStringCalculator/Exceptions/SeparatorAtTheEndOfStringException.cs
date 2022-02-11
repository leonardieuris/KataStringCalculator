using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataStringCalculator.Exceptions
{
    public class SeparatorAtTheEndOfStringException : Exception
    {
        public SeparatorAtTheEndOfStringException(string message): base(message)
        {

        }
    }
}
