using System;

namespace _04.FishingBoat
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int number = int.Parse(Console.ReadLine());

            double rent = 0;
            if (season == "Spring" && number <= 6)
            {
                rent = 3000 * 0.9;
            }
            else if (season == "Spring" && (number <= 11 && number >= 7))
            {
                rent = 3000 * 0.85;
            }
            else if (season == "Spring" && number >= 12)
            {
                rent = 3000 * 0.75;
            }
            else if (season == "Summer" && number <= 6)
            {
                rent = 4200 * 0.9;
            }
            else if (season == "Summer" && (number <= 11 && number >= 7))
            {
                rent = 4200 * 0.85;
            }
            else if (season == "Summer" && number >= 12)
            {
                rent = 4200 * 0.75;
            }
            else if (season == "Winter" && number <= 6)
            {
                rent = 2600 * 0.9;
            }
            else if (season == "Winter" && (number <= 11 && number >= 7))
            {
                rent = 2600 * 0.85;
            }
            else if (season == "Winter" && number > 12)
            {
                rent = 2600 * 0.75;
            }
            else if (season == "Autumn" && number <= 6)
            {
                rent = 4200 * 0.9;
            }
            else if (season == "Autumn" && (number <= 11 && number >= 7))
            {
                rent = 4200 * 0.85;
            }
            else if (season == "Autumn" && number >= 12)
            {
                rent = 4200 * 0.75;
            }

            if (number % 2 == 0 && (season == "Spring" || season == "Summer" || season == "Winter"))
            {
                rent *= 0.95;
            }

            if (rent > budget)
            {
                Console.WriteLine($"Not enough money! You need {(rent - budget):f2} leva.");
            }
            else if (rent <= budget)
            {
                Console.WriteLine($"Yes! You have {(budget - rent):f2} leva left.");
            }
        }
    }
}
