using System;
using System.Diagnostics.Metrics;
using System.Reflection;

namespace JumpStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            bool buttonClick = false;

            do
            {
                int counter = 0;
                counter++;
                Console.WriteLine("BLARRRRR");

                if (counter == 3)
                {
                        break;
                }

            } while (!buttonClick);

        }
    }
}
 //SHOW DAVE - having trouble on how to break the infinite loop and get it to print out 3 instead of an infinite loop.   

