using System;

namespace _022._Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double n = double.Parse(Console.ReadLine());
            double m = double.Parse(Console.ReadLine());
            double p = double.Parse(Console.ReadLine());

            double nPrice = 250 * n;
            double mPrice = nPrice * 0.35 * m;
            double pPrice = nPrice * 0.1 * p;
            
            double total = nPrice + mPrice + pPrice;

            if (n > m)
            {
               total *= 0.85;
            }

            if (budget >= total)
            {
                Console.WriteLine($"You have {(budget - total):f2} leva left!");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {(total - budget):f2} leva more!");     
            }
        }
    }
}
