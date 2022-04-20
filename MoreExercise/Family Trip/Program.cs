using System;

namespace _02._Family_Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double overnights = double.Parse(Console.ReadLine());
            double overnightsPrice = double.Parse(Console.ReadLine());
            double porcentOverCosts = double.Parse(Console.ReadLine());

            if (overnights > 7)
            {
                overnightsPrice *= 0.95;
            }
            double n = overnights * overnightsPrice;
            double m = budget * porcentOverCosts / 100;
            double neededMoney = n + m;

            if (budget >= neededMoney)
            {
                Console.WriteLine($"Ivanovi will be left with {(budget - neededMoney):f2} leva after vacation.");
            }
            else
            {
                Console.WriteLine($"{(neededMoney - budget):f2} leva needed.");
            }
            
        }
    }
}
