using System;
using Microsoft.VisualBasic;

namespace FiveKLogs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("5K Time Log. Press Enter to begin:");
            string enter = Console.ReadLine();

            string[] names = { "Vincent", "Vito", "Gio", "Dave", "Justin" };
            int[] minutes = { 18, 19, 20, 21, 22 };
            int[] values = new int[5];

            if (names.Length != minutes.Length)
            {
                Console.WriteLine("Warning: Times are not equal to answers");
            }

            int scoringIndex = 0;
            foreach (string title in names)
            {
                Console.Write($"How many minutes did {title} run: ");
                int inputAsInt = int.Parse(Console.ReadLine());

                //values[scoringIndex] = inputAsInt;
                //scoringIndex += 1;

                for (int i = 0; i < inputAsInt; i++)
                {
                    Console.WriteLine($"{title} - {inputAsInt} minutes");
                    break;
                }
            }
        }
    }
}