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
            password = password.Replace(" ", string.Empty);

            int score = 0;

            if (password.Length >= minLength)
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
