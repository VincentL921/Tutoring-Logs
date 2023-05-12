using System;

namespace WhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int emails = 20;


            //Write a while loop that checks to see if there are any emails in your inbox.
            //If there are still emails, decrease the amount of emails by one until there are no emails left.

            //It’s a little hard to tell what’s happening in our program,
            //so within the loop have it print a message that it’s deleting an email and how many emails are left.
            while (emails > 0)
            {
                emails--;
                Console.WriteLine($"Email is deleted. There are {emails} emails left in your inbox.");
            }

            //When your inbox reaches zero, have your program print out “INBOX ZERO ACHIEVED!” or some other congratulatory message.
            Console.WriteLine("INBOX ZERO ACHIEVED!");

        }
    }
}
