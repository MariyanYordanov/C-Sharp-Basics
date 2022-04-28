using System;

namespace Time
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            if (minutes >= 45)
            {
                hours += 1;
                minutes = (minutes + 15) - 60;
            }
            
            else if (minutes < 45)
            {
                minutes = minutes + 15;
            }

            if (hours == 24)
            {
                hours = 00;
            }

            Console.WriteLine($"{hours}:{minutes:D2}");
            
        }
    }
}
