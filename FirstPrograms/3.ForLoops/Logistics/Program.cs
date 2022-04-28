using System;

namespace _0003._Logistics
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberCargo = int.Parse(Console.ReadLine());

            int counterBus = 0;
            int counterTruck = 0;
            int counterTrain = 0;

            for (int i = 1; i <= numberCargo; i++)
            {
                int tons = int.Parse(Console.ReadLine());

                if (tons <= 3)
                {
                    counterBus += tons;
                }
                if (tons > 3 && tons <= 11)
                {
                    counterTruck += tons;
                }
                if (tons > 11)
                {
                    counterTrain += tons;
                }
            }
            double totalTons = counterBus + counterTruck + counterTrain;

            double procentTonWithBuss = (counterBus / totalTons) * 100;
            double procentTonWithTruck = (counterTruck /totalTons) * 100;
            double procentTonWithTrain = (counterTrain / totalTons) * 100;

            double middlePricePerTon = ((counterBus * 200) + (counterTruck * 175) + (counterTrain * 120)) / totalTons;

            Console.WriteLine($"{middlePricePerTon:f2}");
            Console.WriteLine($"{procentTonWithBuss:f2}%");
            Console.WriteLine($"{procentTonWithTruck:f2}%");
            Console.WriteLine($"{procentTonWithTrain:f2}%");
        }
    }
}
