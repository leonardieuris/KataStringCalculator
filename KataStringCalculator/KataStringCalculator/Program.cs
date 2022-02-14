using System;
using KataStringCalculator.Validators;

namespace KataStringCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci la stringa da calcolare");
            var read = Console.ReadLine();
            Console.WriteLine($"Il risultato è => {Calculate(read)}");
            Console.ReadLine();
        }

        private static int Calculate(string inputString)
        {
            var validator = new NotNegativeValidator().SetNext(new NumberLimitValidator());
            var calculator = new Calculator(validator);

            return calculator.Add(inputString);
        }
    }
}
