using System;

namespace _02._Football_Kit
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceTshurt = double.Parse(Console.ReadLine());
            double neededMoney = double.Parse(Console.ReadLine());

            double priceShorts = priceTshurt * 0.75;
            double priceSocks = priceShorts * 0.2;
            double priceButtons = (priceTshurt + priceShorts) * 2;
            double totalPrice = priceTshurt + priceShorts + priceButtons + priceSocks;
            double totalWhitDiscount = totalPrice * 0.85;

            if (totalWhitDiscount >= neededMoney)
            {
                Console.WriteLine($"Yes, he will earn the world-cup replica ball!");
                Console.WriteLine($"His sum is {totalWhitDiscount:f2} lv.");
            }
            else
            {
                Console.WriteLine($"No, he will not earn the world-cup replica ball.");
                Console.WriteLine($"He needs {(neededMoney - totalWhitDiscount):f2} lv. more.");
            }
        }
    }
}
