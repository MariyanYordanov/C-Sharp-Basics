using System;

namespace _06TruckDriver
{
    class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            double km = double.Parse(Console.ReadLine());

            double price = 0;

            if (km <= 5000 && season == "Spring" || season == "Autumn")
            {
                price = 0.75 * km;
            }
            else if (km <= 5000 && season == "Summer")
            {
                price = 0.9 * km;
            }
            else if (km <= 5000 && season == "Winter")
            {
                price = 1.05 * km;
            }
            else if (km <= 10000 && season == "Spring" || season == "Autumn")
            {
                price = 0.95 * km;
            }
            else if (km <= 10000 && season == "Summer")
            {
                price = 1.1 * km;
            }
            else if (km <= 10000 && season == "Winter")
            {
                price = 1.25 * km;
            }
            else if (km <= 20000)
            {
                price = 1.45 * km;
            }
            double priceAfterTaxes = 4 * price * 0.9;
            Console.WriteLine($"{priceAfterTaxes:f2}");
        }
    }
}
