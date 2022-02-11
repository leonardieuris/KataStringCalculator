using System;
using System.Collections.Generic;
using System.Linq;

namespace KataStringCalculator
{
    public static class SplitterExtension
    {
        public static IEnumerable<int> Splitter(this string input) => input
           .Split(new string[] { ",", "\n" }, StringSplitOptions.RemoveEmptyEntries)
           .Select(x => int.Parse(x));
    }
}
