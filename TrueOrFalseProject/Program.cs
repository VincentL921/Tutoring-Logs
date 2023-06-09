using System;
using static System.Formats.Asn1.AsnWriter;

namespace TrueOrFalse
{
    class Program
    {
        static void Main(string[] args)
        {
            // Do not edit these lines
            Console.WriteLine("Welcome to 'True or False?'\nPress Enter to begin:");
            string entry = Console.ReadLine();
            //Tools.SetUpInputStream(entry);

            // Type your code below

            string[] questions = { "An apple is a vegetable", "Frosted flakes is a type of cereal",
                "Argentina won the 2023 world cup", "Mario and Luigi are brothers", "Brendan Fraser does not have an Oscar" };
            bool[] answers = { false, true, true, true, false };
            bool[] responses = new bool[5];

            if (questions.Length != answers.Length)
            {
                Console.WriteLine("WARNING: questions are not equal to answers!");
            }

            int askingIndex = 0;
            foreach (string question in questions)
            {
                Console.WriteLine(question);
                Console.WriteLine("True or False?");
                Console.Write("");
                string input = Console.ReadLine();
                bool isBool = true;
                bool inputBool;
                isBool = Boolean.TryParse(input, out inputBool);

                while (isBool != true)
                {
                    bool parsedValue = false;
                    Console.WriteLine($"Please respone with 'true' or 'false'.");
                    input = Console.ReadLine();
                    isBool = Boolean.TryParse(input, out parsedValue);
                    //Ask Dave why 'false' wont be recogniozed as a bool after multiple incorrect re-tries. SOLVED
                    //Only being recognized in initial response. SOLVED
                }


                //Step 13. review logic of this with Dave
                responses[askingIndex] = inputBool;
                askingIndex += 1;

                int scoringIndex = 0;
                int score = 0;
                foreach (bool answer in answers)
                {
                    bool newAns = responses[scoringIndex];
                    Console.WriteLine($"{askingIndex}. Input: {input} | Asnwer: {answer}");
                    //This forech statement displaying user answer and correct answer is printing right,
                    //But the entire array loop keeps printing after each answer. Been stuck on how to get it to print one element per answer.

                    if (isBool == answer)
                    {
                        score++;
                    }
                    scoringIndex++;
                }
                Console.WriteLine($"You got {score} out of {questions.Length} right!");
                //The results keep printing based off the incorrect foreach statement above, instead of giving the total score at the end.
            }
            //Console.WriteLine($"You got {score} out of {questions.Length} right!");

            //Go over step 13 & 14 with Dave - They wanted me to print this as a print check for step 13.
            for (askingIndex = 0; askingIndex < responses.Length; askingIndex++)
            {
            Console.WriteLine(responses[askingIndex]);
            }

        }

        }
    }



//Test Comment