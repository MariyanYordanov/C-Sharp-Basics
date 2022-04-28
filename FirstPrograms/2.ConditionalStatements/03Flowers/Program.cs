using System;

namespace _03Flowers
{
    class Program
    {
        static void Main(string[] args)
        {
            int hriz = int.Parse(Console.ReadLine());
            int roses = int.Parse(Console.ReadLine());
            int tulips = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string holydayOrNot = Console.ReadLine();
            int sum = hriz + roses + tulips;
            double hrizPrice = 0;
            double rosesPrice = 0;
            double tulipsPrice = 0;

            if ((holydayOrNot == "N"))
            {
                if (season == "Spring" || season == "Summer")
                {
                    hrizPrice = 2 * hriz;
                    rosesPrice = 4.1 * roses;
                    tulipsPrice = 2.5 * tulips;
                }
                else if (season == "Autumn" || season == "Winter")
                {
                    hrizPrice = 3.75 * hriz;
                    rosesPrice = 4.5 * roses;
                    tulipsPrice = 4.15 * tulips;
                }
            }
            else if (holydayOrNot == "Y")
            {
                if (season == "Spring" || season == "Summer")
                {
                    hrizPrice = 2 * hriz * 1.15;
                    rosesPrice = 4.1 * roses * 1.15;
                    tulipsPrice = 2.5 * tulips * 1.15;
                }
                else if (season == "Autumn" || season == "Winter")
                {
                    hrizPrice = 3.75 * hriz * 1.15;
                    rosesPrice = 4.5 * roses * 1.15;
                    tulipsPrice = 4.15 * tulips * 1.15;
                }
            }

            double bucetPrice = hrizPrice + rosesPrice + tulipsPrice;

            if (tulips > 7 && season == "Spring")
            {
                bucetPrice *= 0.95;
            }
            if (roses > 10 && season == "Winter")
            {
                bucetPrice *= 0.9;
            }
            if (sum > 20)
            {
                bucetPrice *= 0.8;
            }
            double bucetTotal = bucetPrice + 2;
            Console.WriteLine($"{bucetTotal:f2}");
        }
    }
}

