using System;

namespace GodzillaVsKong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int numberStatist = int.Parse(Console.ReadLine());
            double clothesPriceForOneStatist = double.Parse(Console.ReadLine());

            double decor = budget * 0.1;
            double clothesPrice = numberStatist * clothesPriceForOneStatist;

            if (numberStatist > 150)
            {
                clothesPrice = clothesPrice - (clothesPrice * 0.1);
                
            }

            double costs = decor + clothesPrice;

            if (costs <= budget)
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {budget-costs:f2} leva left.");
            }
            else if (costs > budget)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {costs-budget:f2} leva more.");
            }
            
        }
    }
}
