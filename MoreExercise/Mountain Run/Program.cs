using System;

namespace _02._Mountain_Run
{
    class Program
    {
        static void Main(string[] args)
        {
            double record = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double timePerMeterInSec = double.Parse(Console.ReadLine());

            double delay = (Math.Floor(distance / 50) * 30);

            double timeGeorgi = (distance * timePerMeterInSec) + delay;
            if (record > timeGeorgi)
            {
                Console.WriteLine($" Yes! The new record is {timeGeorgi:f2} seconds.");
            }
        
            else
            {
                Console.WriteLine($"No! He was {(timeGeorgi - record):f2} seconds slower.");
            }
        }
    }
}
