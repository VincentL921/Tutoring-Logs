using System;

namespace DocumentationHunt
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] summerStrut;

            summerStrut = new string[] { "Juice", "Missing U", "Raspberry Beret", "New York Groove", "Make Me Feel", "Rebel Rebel", "Despacito", "Los Angeles" };

            int[] ratings = { 5, 4, 4, 3, 3, 5, 5, 4 };


            //SHOW DAVE - won't print correctly
            string[] summerStrutCopy = new string[8];
            Array.Copy(summerStrutCopy, summerStrut, 8);
            Console.WriteLine($"{summerStrutCopy[0]}");

            //SHOW DAVE - won't print correctly
            Array.Reverse(summerStrut);
            Console.WriteLine($"{summerStrut[0]}");
            Console.WriteLine($"{summerStrut[7]}");

            //SHOW DAVE - need review on these
            Array.Clear(ratings, 0, ratings.Length);
            Console.WriteLine($"{ratings[0]}");

        }
    }
}
