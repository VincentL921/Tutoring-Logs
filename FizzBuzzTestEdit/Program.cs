//Create a loop that loops 50 times.
//For every number divisible by 3, print "fizz".
//For every number divisible by 5, print "buzz".
//For every number divisible by both 3 & 5, print "fizz buzz", respectively.
//If a number is not divisible by either 3 or 5, just print out the number itself.

using System;

namespace FizzBuzzTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int digits = 1;
            int x = 3;
            int y = 5;

            for (digits = 1; digits < 51; digits++)
            {
                if ((digits % x == 0) && (digits % y == 0))
                {
                    Console.WriteLine("fizz-buzz");
                }
                else if (digits % x == 0)
                {
                    Console.WriteLine("fizz");
                }
                else if (digits % y == 0)
                {
                    Console.WriteLine("buzz");
                }
                else
                {
                    Console.WriteLine($"{digits}");
                }
            }
        }
    }
}
