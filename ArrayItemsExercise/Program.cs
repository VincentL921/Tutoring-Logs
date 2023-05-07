using System;

namespace AccessingArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] summerStrut;

            summerStrut = new string[] { "Juice", "Missing U", "Raspberry Beret", "New York Groove", "Make Me Feel", "Rebel Rebel", "Despacito", "Los Angeles" };

            int[] ratings = { 5, 4, 4, 3, 3, 5, 5, 4 };


            //Print out a statement that includes the name of the second song in the playlist and the rating that you gave it.
            //The message should read something like “You rated the song Missing U 4 stars.”

            Console.WriteLine($"You rated the song {summerStrut[1]} {ratings[1]} stars");

        }
    }
}
