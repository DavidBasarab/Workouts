using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace LargestPlainDrome
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var watch = Stopwatch.StartNew();

            var largestPalinDrome = FindLargest3DigitPalinDrome();

            watch.Stop();

            Console.WriteLine("Largest 3 Digit Palin Drome: {0} | Time: {1}", largestPalinDrome, watch.Elapsed);
        }

        private static int FindLargest3DigitPalinDrome()
        {
            var palinDromes = new List<int>();

            for (var number1 = 999; number1 > 99; number1--)
            {
                for (var number2 = 999; number2 > 99; number2--)
                {
                    var product = number1 * number2;
                    var isPalinDrome = ProductPalinDromeDeterminer.IsProductAPalinDrome(number1, number2);

                    if (isPalinDrome) palinDromes.Add(product);
                }
            }

            return palinDromes.Max();
        }
    }
}