using System;

namespace LastNameSiblingExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstNames = { "Vincent", "Dave", "Giovanni", "Justin", "Sarah", "George", "Vito", "Thomas", "Charles", "Ana" };
            string[] lastNames = { "Lentini", "Wimbley", "Rocco", "Lentini", "McGurn", "Prezioso", "Lentini", "Li", "Schmidt", "Lentini" };
            bool[] names = new bool[firstNames.Length];


            string whoAreSiblings = lastNames.Where(b => lastNames.Contains("Lentini").Select(b => lastNames));

            foreach (var title in whoAreSiblings)
            {
                Console.WriteLine(title);

            }


        }
    }
}