using System.Linq;
using System;
using System.Collections.Generic;

namespace KataStringCalculator
{
    public class Calculator : ICalculator
    {
        public int Add(string numbers) => numbers.Splitter().Sum();
    }
}
