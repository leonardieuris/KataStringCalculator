using System;
using KataStringCalculator.IOC;

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
            var calculator = Container.GetService<ICalculator>();

            return calculator.Calculate(inputString);
        }
    }
}
