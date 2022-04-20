using System;

namespace _02._Godzilla_vs._Kong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double extras = double.Parse(Console.ReadLine());
            double clothing = double.Parse(Console.ReadLine());

            double deckor = budget * 0.1;
            if (extras > 150)
            {
                clothing *= 0.9;
            }
            double costs = deckor + (clothing * extras);
            if (costs > budget)
            {
                Console.WriteLine($"Not enough money!");
                Console.WriteLine($"Wingard needs {(costs - budget):f2} leva more.");
            }
            else
            {
                Console.WriteLine($"Action!");
                Console.WriteLine($"Wingard starts filming with {(budget - costs):f2} leva left.");
            }
        }
    }
}
