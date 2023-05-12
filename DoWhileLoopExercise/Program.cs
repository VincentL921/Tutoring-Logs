using System;

namespace DoWhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {

            //You’ve decided to try making another productivity tool. This time you build a pomodoro timer.
            //When the timer finishes, an alarm will ring once.
            //If you don’t click the button to turn it off, the alarm will repeat until it is turned off.
            bool buttonClick = true;

            //Write a program that plays the alarm once, and then if the button isn’t clicked (!buttonClick), it will repeat the alarm.
            //To simulate an alarm, you can print something like “BLARRRRRRRRR” to the console.
            do
            {
                Console.WriteLine("BOOMSHAKALAKA");
            } while (!buttonClick);

            //After the loop finishes, the program should print a message telling you to take a break, like:
            //“Time for a five minute break.”
            Console.WriteLine("Time for a five minute break");
        }
    }
}