using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataStringCalculator
{
    public inteface IValidator
    {
        IEnumerable<int> Validate(IEnumerable<int> input);
    }
}
