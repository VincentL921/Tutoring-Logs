//Create variable for your name and print it backwards.
//Make sure to get your name to print horizontally, not vertically.
//**DO NOT USE Array.Reverse**

using System;

namespace ReverseNameTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] name = { "V", "i", "n", "c", "e", "n", "t", " ", "L", "e", "n", "t", "i", "n", "i" };

            foreach (string letter in name.Reverse())
            {
                Console.Write($"{letter}");
            }

        }
    }
}
        

