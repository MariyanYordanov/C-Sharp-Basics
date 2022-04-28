using System;

namespace CharityCampaign
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfDays = int.Parse(Console.ReadLine());
            int numberOfBakers = int.Parse(Console.ReadLine());
            int numberOfCakes = int.Parse(Console.ReadLine());
            int numberOfWaffles = int.Parse(Console.ReadLine());
            int numberOfPancakes = int.Parse(Console.ReadLine());

            double priceCakaesPerDay = 45 * numberOfCakes;
            double priceWafflesPerDay = 5.80 * numberOfWaffles;
            double pricePancakesPerDay = 3.20 * numberOfPancakes;

            double sumPerDay = (priceCakaesPerDay + priceWafflesPerDay + pricePancakesPerDay) * numberOfBakers;
            double sumForCampain = numberOfDays * sumPerDay;
            double sumTotal = sumForCampain - (sumForCampain / 8);

            Console.WriteLine(sumTotal);

        }
    }
}
