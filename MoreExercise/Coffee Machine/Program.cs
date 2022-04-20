using System;

namespace _03._Coffee_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            string drinks = Console.ReadLine();
            string suger = Console.ReadLine();
            int numbersOfDrinks = int.Parse(Console.ReadLine());
            double price = 0;

            if (drinks == "Espresso")
            {
                if (suger == "Without")
                {
                    price = 0.90 * 0.65;
                }
                else if (suger == "Normal")
                {
                    price = 1.0;
                }
                else if (suger == "Extra")
                {
                    price = 1.20;
                }
            }
            else if (drinks == "Cappuccino")
            {
                if (suger == "Without")
                {
                    price = 1.0 * 0.65;
                }
                else if (suger == "Normal")
                {
                    price = 1.20;
                }
                else if (suger == "Extra")
                {
                    price = 1.60;
                }
            }
            else if (drinks == "Tea")
            {
                if (suger == "Without")
                {
                    price = 0.50 * 0.65;
                }
                else if (suger == "Normal")
                {
                    price = 0.60;
                }
                else if (suger == "Extra")
                {
                    price = 0.70;
                }
            }

            if (drinks == "Espresso" && numbersOfDrinks >= 5)
            {
                price *= 0.75;
            }

            double sum = price * numbersOfDrinks;

            if (sum > 15)
            {
                sum *= 0.8;
            }
            
            Console.WriteLine($"You bought {numbersOfDrinks} cups of {drinks} for {sum:f2} lv.");
        }
    }
}
