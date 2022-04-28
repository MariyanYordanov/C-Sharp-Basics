using System;

namespace ticetsForMach
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            int people = int.Parse(Console.ReadLine());
            double leftAfterTansport = 0;


            if (people <= 0)
            {
                Console.WriteLine("error");
            }
            else if (people <= 4)
            {
                leftAfterTansport = budget * 0.25;
            }
            else if (people <= 9)
            {
                leftAfterTansport = budget * 0.40;
            }
            else if (people <= 24)
            {
                leftAfterTansport = budget * 0.50;
            }
            else if (people <= 49)
            {
                leftAfterTansport = budget * 0.60;
            }
            else if (people > 50)
            {
                leftAfterTansport = budget * 0.75;
            }
            
            if (type == "VIP")
            {
                double price = 499.99 * people;
                if (price > leftAfterTansport)
                {
                    Console.WriteLine($"Not enough money! You need {(price - leftAfterTansport):f2} leva.");
                }
                else if (price <= leftAfterTansport)
                {
                    Console.WriteLine($"Yes! You have {(leftAfterTansport - price):f2} leva left.");
                }
                
            }
            else if (type == "Normal")
            {
                double price = 249.99 * people;
                if (price > leftAfterTansport)
                {
                    Console.WriteLine($"Not enough money! You need {(price - leftAfterTansport):f2} leva.");
                }
                else if (price <= leftAfterTansport)
                {
                    Console.WriteLine($"Yes! You have {(leftAfterTansport - price):f2} leva left.");
                }
            }
        }
    }
}
