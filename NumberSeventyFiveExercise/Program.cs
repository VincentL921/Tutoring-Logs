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

            int numberCap = 200;
            int x = 6;
            int y = 9;

            for (int i = 0; i < numberCap; i++)
            {

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
