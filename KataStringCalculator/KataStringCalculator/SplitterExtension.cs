using System;
using System.Collections.Generic;
using System.Linq;

namespace KataStringCalculator
{
    public static class SplitterExtension
    {
        public static IEnumerable<int> Splitter(this string input)
        {
            var separator = new string[] { ",", "\n" };

            foreach (var element in separator)
            {
                if (input.EndsWith(element))
                    throw new SeparatorAtTheEndOfStringException("String ends with separator");
            }
            return
            input
             .Split(separator, StringSplitOptions.RemoveEmptyEntries)
             .Select(x => int.Parse(x));
        }
    }
}
