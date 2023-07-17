using System;
using System.Collections;
using System.Collections.Generic;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LastNameSiblingExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstNames = { "Vincent", "Dave", "Giovanni", "Justin", "Sarah", "George", "Vito", "Thomas", "Charles", "Ana" };
            List<string> firstNamesAsList = firstNames.ToList();
            string[] lastNames = { "Lentini", "Wimbley", "Rocco", "Lentini", "McGurn", "Prezioso", "Lentini", "Li", "Schmidt", "Lentini" };
            List<string> lastNamesAsList = lastNames.ToList();
            bool[] names = new bool[firstNames.Length];

            IEnumerable<string> whoAreSiblings = lastNamesAsList.GroupBy(x => x).Where(g => g.Count() > 1).Select(x => x.Key);

            int indexOfNames = 0;

            //lastNames[indexOfNames]

            for (int i = 0; i < indexOfNames; i++ )
            {
                if (whoAreSiblings != whoAreSiblings)
                {

                }

                Console.WriteLine($"The siblings in this list all have the last name {whoAreSiblings}");
            }

        }
    }
}