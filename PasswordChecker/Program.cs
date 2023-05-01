using System;

namespace PasswordChecker
{
    class Program
    {
        public static void Main(string[] args)
        {

            int minLength = 8;
            string uppercase = "QWERTYUIOPASDFGHJKLZXCVBNM";
            string lowercase = "qwertyuiopasdfghjklzxcvbnm";
            string digits = "1234567890";
            string specialChars = "!@#$%^&*()";

            Console.Write("Please Enter A Password: ");
            string password = Console.ReadLine();

            int score = 0;

            if (minLength >= 8)
            {
                score++;
            }
            if (Tools.Contains(password, uppercase))
            {
                score++;
            }
            if (Tools.Contains(password, lowercase))
            {
                score++;
            }
            if (Tools.Contains(password, digits))
            {
                score++;
            }
            if (Tools.Contains(password, specialChars))
            {
                score++;
            }
            Console.WriteLine("");
            Console.WriteLine($"Password Score: {score}");
            //Score does not align with what I am looking for. I want all spaces typed into the terminal
            //to be a score of 0 but instead it is giving me a score of 1. Not sure how to eliminate spaces as a character.


            switch (score)
            {
                case 5:
                    Console.WriteLine("Extremely Strong");
                    break;

                case 4:
                    Console.WriteLine("Extremely Strong");
                    break;

                case 3:
                    Console.WriteLine("Strong");
                    break;

                case 2:
                    Console.WriteLine("Medium");
                    break;

                case 1:
                    Console.WriteLine("Weak");
                    break;

                default:
                    Console.WriteLine("Password does not meet any standards");
                    break;
            }


        }
    }
}
