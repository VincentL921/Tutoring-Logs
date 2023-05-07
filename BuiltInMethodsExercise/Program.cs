using System;
using System.Collections.Generic;

namespace BuiltInMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] summerStrut;

            summerStrut = new string[] { "Juice", "Missing U", "Raspberry Beret", "New York Groove", "Make Me Feel", "Rebel Rebel", "Despacito", "Los Angeles" };

            int[] ratings = { 5, 4, 4, 3, 3, 5, 5, 4 };


            //Using an Array method, find the position for the first 3-star rated song and save it to a variable.
            //Print a message to the console, like “Song number X is rated three stars”.
            int thirdSong = Array.IndexOf(summerStrut, "Make Me Feel");
            int thirdRating = Array.IndexOf(ratings, 3);
            Console.WriteLine($"Song number {thirdSong} is rated {thirdRating} stars.");

            //Find the first song that has more than 10 characters in its title. Save it to a variable and print a message to the console,
            //such as “The first song that has more than 10 characters in the title is X.”
            string moreTenLetters = Array.Find(summerStrut, letters => letters.Length > 10);
            Console.WriteLine($"The first song that has more than 10 characters in the title is {moreTenLetters}");

            //Organize the playlist alphabetically. To check that it worked, print the first and last song titles to the console.
            Array.Sort(summerStrut);
            Console.WriteLine($"{summerStrut[0]}");
            Console.WriteLine($"{summerStrut[7]}");

        }
    }
}
