using System;

namespace _04CarToGo
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            double price = 0;
            if (budget <= 100)
            {
                Console.WriteLine("Economy class");
                if (season == "Summer")
                {
                    price = budget * 0.35;
                    Console.WriteLine($"Cabrio - {price:f2}");
                }
                else if (season == "Winter")
                {
                    price = budget * 0.65;
                    Console.WriteLine($"Jeep - {price:f2}");
                }
            }
            else if (budget <= 500)
            {
                Console.WriteLine("Compact class");
                if (season == "Summer")
                {
                    price = budget * 0.45;
                    Console.WriteLine($"Cabrio - {price:f2}");
                }
                else if (season == "Winter")
                {
                    price = budget * 0.80;
                    Console.WriteLine($"Jeep - {price:f2}");
                }
            }
            else if (budget > 500)
            {
                Console.WriteLine("Luxury class");
                price = budget * 0.90;
                Console.WriteLine($"Jeep - {price:f2}");
            }
        }
    }
}
