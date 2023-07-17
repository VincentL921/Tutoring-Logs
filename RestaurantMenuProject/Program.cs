using System;
using Microsoft.VisualBasic;

namespace RestaurantMenuProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Vin's Pizza!");

            string[] menuItems = { "Pizza", "Pasta", "Chicken Parm", "Meatballs", "Soda" };
            int[] itemNumbers = new int[5];
            //int[] index = new int[5];

            if (menuItems.Length != itemNumbers.Length)
            {
                Console.WriteLine("Warning: Menu Items are not equal to Item Numbers");
            }

            int indexOfItems = 0;
            Console.WriteLine($"Please Begin Order:");
            Console.WriteLine($"#1 - Pizza");
            Console.WriteLine($"#2 - Pasta");
            Console.WriteLine($"#3 - Chicken Parm");
            Console.WriteLine($"#4 - Meatballs");
            Console.WriteLine($"#5 - Soda");

            foreach (string title in menuItems)
            {
                Console.WriteLine("What would you like?");
                string menuInput = Console.ReadLine();
                //int answerInput = 1;
                int inputAsInt;
                bool parsedInput = int.TryParse(menuInput, out inputAsInt);

                while ((inputAsInt == 0) || (inputAsInt > 5) || (!int.TryParse(menuInput, out inputAsInt)))
                {
                    Console.WriteLine("Invalid Order. Please order a food item within range:");
                    menuInput = Console.ReadLine();
                    parsedInput = int.TryParse(menuInput, out inputAsInt);
                }

                itemNumbers[indexOfItems] = inputAsInt;
                indexOfItems += 1;
                //int translationNumber = 0;

                for (int i = 0; i < indexOfItems; i++)
                {
                    int translationNumber = itemNumbers[i];
                    string translationOfUserInput = menuItems[translationNumber - 1];
                    Console.WriteLine($"Your order: {translationOfUserInput}!");
                }
                Console.WriteLine("Thank you for your order. Please press Enter to checkout/continue!");

            }

        }
    }
}

//In console:
//"Welcome to ABC"
//"Then, Please enter your selections with food item #"
//User needs to make their orders by inputting the cood item #
//*If they order out of the range, print out a re-try to please order the items within range
//**DONT HAVE THE MENU DISPLAY CODE TWICE**
//**DO NOT DUPLICATE CODE**