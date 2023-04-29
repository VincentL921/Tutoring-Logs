using System;

namespace MadLibs
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            This program ...
            Author: ...
            */


            // Let the user know that the program is starting:


            // Give the Mad Lib a title:
            string title = "The Crazy Day - a MadLib";

            Console.WriteLine(title);
            Console.WriteLine("   ");
            // Define user input and variables:
            /* 
            Author:
            Vincent Lentini
            */

            // The template for the story:
            Console.WriteLine(@"Beginning:");
            Console.WriteLine("");

            Console.Write(@"Please write your name: ");
            string name = Console.ReadLine();

            Console.WriteLine("");

            Console.Write(@"Write a first adjective: ");
            string adj1 = Console.ReadLine();


            Console.Write(@"Write a second adjective: ");
            string adj2 = Console.ReadLine();

            
            Console.Write(@"Write a third adjective: ");
            string adj3 = Console.ReadLine();

            Console.WriteLine("");

            Console.Write(@"Write a verb: ");
            string verb = Console.ReadLine();

            Console.WriteLine("");

            Console.Write(@"Write a first noun: ");
            string noun1 = Console.ReadLine();

         
            Console.Write(@"Write a second noun: ");
            string noun2 = Console.ReadLine();

            Console.WriteLine("");

            Console.Write(@"Please name an animal: ");
            string animal = Console.ReadLine();

            Console.WriteLine("");

            Console.Write(@"Please provide a food you like: ");
            string food = Console.ReadLine();

            Console.WriteLine("");

            Console.Write(@"Write your favorite fruit: ");
            string fruit = Console.ReadLine();

            Console.WriteLine("");

            Console.Write(@"Write the name of your favorite superhero: ");
            string superHero = Console.ReadLine();

            Console.WriteLine("");

            Console.Write(@"Write the name of a country: ");
            string country = Console.ReadLine();

            Console.WriteLine("");

            Console.Write(@"Write your favorite dessert: ");
            string dessert = Console.ReadLine();

            Console.WriteLine("");

            Console.Write(@"Write a year in the past or future: ");
            string year = Console.ReadLine();

            Console.WriteLine("   ");

            string story = $"This morning {name} woke up feeling {adj1}. 'It is going to be a {adj2} day!' Outside, a bunch of {animal}s were protesting to keep {food} in stores. They began to {verb} to the rhythm of the {noun1}, which made all the {fruit}s very {adj3}. Concerned, {name} texted {superHero}, who flew {name} to {country} and dropped {name} in a puddle of frozen {dessert}. {name} woke up in the year {year}, in a world where {noun2}s ruled the world.";

            // Print the story:
            Console.WriteLine(story);

        }
    }
}

