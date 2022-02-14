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

            if(tuple.Item1.Length> 0 && tuple.Item2.Contains(tuple.Item1.Substring(tuple.Item1.Length-1)))
                throw new SeparatorAtTheEndOfStringException("String ends with separator");

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

            if(temp.Count()!=2)
                throw new FormatException("Format error");

            var separator = new string []{ temp[0].Substring(2)};
            if (separator[0].Equals(string.Empty))
                throw new FormatException("Not Separator found");
                    return (temp[1], separator);
            
        }

    }
}
