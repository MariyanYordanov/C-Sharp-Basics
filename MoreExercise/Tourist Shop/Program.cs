using System;

namespace _04._Tourist_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string productName = Console.ReadLine();
            
            int counter = 0;
            bool check = false;
            double sum = 0;
            double needed = 0;
            
            while (productName != "Stop")
            {
                double productPrice = double.Parse(Console.ReadLine());
                
                counter++;
                if (counter % 3 == 0)
                {
                    productPrice *= 0.5;
                }
                if (productPrice > budget)
                {
                    counter--;
                    needed = productPrice - budget;
                    check = true;
                    break;
                }
                sum += productPrice;
                budget -= productPrice;
                
                productName = Console.ReadLine();
            }
            if (productName == "Stop")
            {
                Console.WriteLine($"You bought {counter} products for {sum:f2} leva.");
            }
            if (check)
            {
                Console.WriteLine($"You don't have enough money!");
                Console.WriteLine($"You need {needed:f2} leva!");
            }
        }
    }
}
