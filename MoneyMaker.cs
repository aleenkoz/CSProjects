using System;

namespace MoneyMaker
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            /* This program will ask the user for the amount of money in cents so that the program can convert it into the minimum amount of coins that is equivalent to the amount given by the user, where: 
            Gold Coins = 10 cents
            Silver Coins = 5 cents
            Bronze Coins = 1 cent. */
            Console.WriteLine("Welcome to Money Maker!");
            Console.WriteLine("How much money (in cents) would you like to convert? ");
            string amount = Console.ReadLine();
            double amounts = Convert.ToDouble(amount);
            Console.WriteLine($"{amount} cents is equal to --->");
            //Set the values for the coins.
            double GoldCoin = 10;
            double SilverCoin = 5;
            //Start calculating the amounts of coins.
            double GoldCoins = Math.Floor(amounts / GoldCoin);
            double remainingAfterGold = amounts - GoldCoins * GoldCoin;
            double SilverCoins = Math.Floor(remainingAfterGold / SilverCoin);
            double second_remaining = remainingAfterGold - SilverCoins * SilverCoin;
            //Print the results to the user.
            Console.WriteLine("Gold Coins: ");
            Console.WriteLine(GoldCoins);
            Console.WriteLine("Silver Coins: ");
            Console.WriteLine(SilverCoins);
            Console.WriteLine("Bronze Coins: ");
            Console.WriteLine(second_remaining);
            Console.WriteLine("Spend it wisely.");
        }
    }
}
