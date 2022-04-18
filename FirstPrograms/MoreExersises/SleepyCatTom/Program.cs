using System;

namespace SleepyCatTom
{
    class Program
    {
        static void Main(string[] args)
        {
            int holidays = int.Parse(Console.ReadLine());
            int workdays = 365 - holidays;
            int playminutes = (63 * workdays) + (127 * holidays);

            if (playminutes > 30000)
            {
                int difference = playminutes - 30000 ;
                int hours = difference / 60;
                int minutes = difference % 60;

                Console.WriteLine("Tom will run away");
                Console.WriteLine($"{hours} hours and {minutes} minutes more for play");
            }
            else if (playminutes < 30000)
            {
                int difference = 30000 - playminutes;
                int hours = difference / 60;
                int minutes = difference % 60;

                Console.WriteLine("Tom sleeps well");
                Console.WriteLine($"{hours} hours and {minutes} minutes less for play");
            }
        }
    }
}
