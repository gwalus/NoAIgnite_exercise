using CommandLineApp.Builders;
using CommandLineApp.Validators;
using System;

namespace CommandLineApp
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("No input arguments");
                return;
            }

            if (!DateValidator.IsValid(args[0], out DateTime firstDate))
            {
                Console.WriteLine("First date is invalid");
                return;
            }

            if (!DateValidator.IsValid(args[1], out DateTime secondDate))
            {
                Console.WriteLine("Second date is invalid");
                return;
            }

            if (DateValidator.IsSame(firstDate, secondDate))
            {
                Console.WriteLine("Dates are the same");
                return;
            }

            if (DateValidator.IsGreater(firstDate, secondDate))
            {
                Console.WriteLine("First date is later than second");
                return;
            }

            var calculatedDate = new DateBuilder(firstDate, secondDate).CalculateDates();
            
            Console.WriteLine(calculatedDate);

            Console.ReadKey();
        }
    }
}
