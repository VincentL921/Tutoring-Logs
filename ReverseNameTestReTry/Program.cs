using System;

namespace ReverseNameTestReTry
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Vincent Lentini";
            string reverseName = string.Empty;

            for (int length = name.Length - 1; length >= 0; length--)
            {
                reverseName += name[length];
            }
            Console.WriteLine(reverseName);

        }     

    }
}