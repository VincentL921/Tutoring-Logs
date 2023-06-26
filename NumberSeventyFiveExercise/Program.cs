using System;
using Microsoft.VisualBasic;

namespace NumberSeventyFiveExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please provide a number between 1 - 75:");
            string userInputNumber = Console.ReadLine();
            int inputAsInt;
            bool parsedInput = int.TryParse(userInputNumber, out inputAsInt);


            while ((!int.TryParse(userInputNumber, out inputAsInt)) || (inputAsInt > 75))
            {
                Console.WriteLine("Invalid. Please provide a sufficient number between 1 - 75");
                userInputNumber = Console.ReadLine();
                parsedInput = int.TryParse(userInputNumber, out inputAsInt);
            }

            //int numberCap = 201;

            for (int i = inputAsInt; i <= 200; i++)
            {
                if (inputAsInt % 6 == 0)
                {
                    Console.WriteLine(i += 6);
                    //incrementing by one number higher than intended. Need 6 multiplication table.
                }
                else if (inputAsInt % 9 == 0)
                {
                    Console.WriteLine(i += 9);
                    //incrementing by one number higher than intended. Need 9 multiplication table.
                }
                else
                {
                    Console.WriteLine(i + 1);
                    //did not know how to get this one to increment the input by 1 any other way, but this way worked!
                }
            }
        }
    }
}

//while (inputAsInt > 75)
//{
//    Console.WriteLine("Inval id. Please provide a number that is less than 75");
//    userInputNumber = Console.ReadLine();
//    parsedInput = int.TryParse(userInputNumber, out inputAsInt);
//}