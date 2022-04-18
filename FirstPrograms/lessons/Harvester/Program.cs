using System;

namespace Harvester
{
    class Program
    {
        static void Main(string[] args)
        {
            int sqM = int.Parse(Console.ReadLine());
            double grapeY = double.Parse(Console.ReadLine());
            int vineZ = int.Parse(Console.ReadLine());
            int numWorkers = int.Parse(Console.ReadLine());

            double totalharvestInLitters = ((sqM * grapeY) * 0.4) / 2.5;

            if (totalharvestInLitters < vineZ)
            {
                Console.WriteLine($"It will be a tough winter! More {Math.Floor(vineZ -totalharvestInLitters)} liters wine needed.");
            }
            else if (totalharvestInLitters >= vineZ)
            {
                double enoughWine = totalharvestInLitters - vineZ;
                double vineForOneWorker = enoughWine / numWorkers;

                Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(totalharvestInLitters)} liters.");

                Console.WriteLine($"{Math.Ceiling(enoughWine)} liters left -> {Math.Ceiling(vineForOneWorker)} liters per person.");

            }
        }
    }
}
