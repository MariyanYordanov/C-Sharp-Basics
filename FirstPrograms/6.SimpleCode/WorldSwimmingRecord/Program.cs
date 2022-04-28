using System;

namespace WorldSwimmingRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            double worldRecord = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double timeForMeter = double.Parse(Console.ReadLine());

            double timeIvan = (distance * timeForMeter) + (Math.Floor(distance / 15.0) * 12.5);
            double inafSeconds = timeIvan - worldRecord;


            if (timeIvan < worldRecord)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {timeIvan:f2} seconds.");
            }

            else if (true)
            {
                Console.WriteLine($"No, he failed! He was {inafSeconds:f2} seconds slower.");
            }

        }
    }
}
