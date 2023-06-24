using System;

namespace LINQDotWherePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] digits = { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            var shortDigits = digits.Where((digit, Index) => digit.Length < Index);

            Console.WriteLine($"Short Digits:");
            foreach (var d in shortDigits)
            {
                Console.WriteLine($"The word {d} shorter than its value");
            }
        }
    }
}