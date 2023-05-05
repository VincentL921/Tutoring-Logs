using System;

namespace MoneyMaker
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Money Maker!");
            
            Console.Write("Please enter an amount to convert to coins: ");
            string amount = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine($"{amount} cents is equal to...");
            double amountAsDouble = Convert.ToDouble(amount);

            int goldValue = 10;
            int silverValue = 5;

            double goldCoins = Math.Floor(amountAsDouble / goldValue);
            double leftOverGold = amountAsDouble % goldValue;

            double silverCoins = Math.Floor(leftOverGold / silverValue);
            double leftOverSilver = amountAsDouble % silverValue;

            Console.WriteLine($"Gold Coins: {goldCoins}");
            Console.WriteLine($"Silver Coins: {silverCoins}");
            Console.WriteLine($"Bronze Coins: {leftOverSilver}");


            ;
        }
    }
}
