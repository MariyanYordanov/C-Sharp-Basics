using System;

namespace _02._Safari
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double fuel = double.Parse(Console.ReadLine());
            string text = Console.ReadLine();

            double fuelPrice = fuel * 2.1;
            double total = 100 + fuelPrice;
            if (text == "Saturday")
            {
                total *= 0.9;
            }
            else if (text == "Sunday")
            {
                total *= 0.8;
            }
            if (budget  >= total)
            {
                Console.WriteLine($"Safari time! Money left: {(budget - total):f2} lv. ");
            }
            else
            {
                Console.WriteLine($"Not enough money! Money needed: {(total - budget):f2} lv.");
            }
        }
    }
}
