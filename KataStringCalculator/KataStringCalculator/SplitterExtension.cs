using System;
using System.Collections.Generic;
using System.Linq;
using KataStringCalculator.Exceptions;

namespace KataStringCalculator
{
    public static class SplitterExtension
    {

        public static IEnumerable<int> Splitter(this string input)
        {
            var tuple = ChoiseSeparator(input);

            foreach (var element in tuple.Item2)
            {
                if (tuple.Item1.EndsWith(element))
                    throw new SeparatorAtTheEndOfStringException("String ends with separator");
            }
            return
            tuple.Item1
             .Split(tuple.Item2, StringSplitOptions.RemoveEmptyEntries)
             .Select(x => int.Parse(x));
        }

        private static (string, string[]) ChoiseSeparator(string input)
        {
            var DefaultSeparators = new string[] { ",", "\n" };
            if (!input.StartsWith("//"))
                return (input, DefaultSeparators);

                var temp = input.Split("\n",2);
                var separator = new string []{ temp[0].Substring(2)};
            if (separator[0].Equals(string.Empty))
                throw new FormatException("Not Separator found");
                    return (temp[1], separator);
            
        }

    }
}
