using System;

namespace _03.NewHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            string flowersType = Console.ReadLine();
            int flowers = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            double total = 0.0;

            if (flowersType == "Roses" && flowers <= 80)
            {
                total = 5 * flowers;
            }
            else if (flowersType == "Roses" && flowers > 80)
            {
                total = (5 * flowers) * 0.9;
            }
            else if (flowersType == "Dahlias" && flowers <= 90)
            {
                total = 3.80 * flowers;
            }
            else if (flowersType == "Dahlias" && flowers > 90)
            {
                total = (3.80 * flowers) * 0.85;
            }
            else if (flowersType == "Tulips" && flowers <= 80)
            {
                total = 2.80 * flowers;
            }
            else if (flowersType == "Tulips" && flowers > 80)
            {
                total = (2.80 * flowers) * 0.85;
            }
            else if (flowersType == "Narcissus" && flowers < 120)
            {
                total = (3.00 * flowers) * 1.15;
            }
            else if (flowersType == "Narcissus" && flowers >= 120)
            {
                total = 3.00 * flowers ;
            }
            else if (flowersType == "Gladiolus" && flowers < 80)
            {
                total = (2.50 * flowers) * 1.2;
            }
            else if (flowersType == "Gladiolus" && flowers >= 80)
            {
                total = 2.50 * flowers ;
            }

            if (total > budget)
            {
                Console.WriteLine($"Not enough money, you need {(total - budget):f2} leva more.");
            }
            else if (total <= budget)
            {
                Console.WriteLine($"Hey, you have a great garden with {flowers} {flowersType} and {(budget - total):f2} leva left.");
            }
        }
    }
}
