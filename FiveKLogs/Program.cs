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
            int[] minutes = new int[5];

            if (names.Length != minutes.Length)
            {
                Console.WriteLine("Warning: Times are not equal to answers");
            }

            int indexOfRunners = 0;
            foreach (string title in names)
            {
                Console.Write($"How many minutes did {title} run: ");
                string runnerInput = Console.ReadLine();
                int inputAsInt;
                bool parsedInput = int.TryParse(runnerInput, out inputAsInt);

                while (!int.TryParse(runnerInput, out inputAsInt))
                {
                    Console.WriteLine("Invalid. Please provide a sufficient time");
                    runnerInput = Console.ReadLine();
                    parsedInput = int.TryParse(runnerInput, out inputAsInt);
                }

                minutes[indexOfRunners] = inputAsInt;
                indexOfRunners += 1;

                for (int i = 0; i < names.Length; i++)
                {
                    string runnerNames = names[i];
                    int runnerTimes = minutes[i];
                    Console.WriteLine($"{runnerNames} - {runnerTimes} minutes");
                }
            }
        }
    }
}