using System;

namespace firm
{
    class Program
    {
        static void Main(string[] args)
        {
            int necessaryHours = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            int employees = int.Parse(Console.ReadLine());

            double hoursOnWork = (days - (days * 0.1)) * 8;
            double hoursExtraOnWork = employees * (days * 2);
            double totalHour = Math.Floor(hoursOnWork + hoursExtraOnWork);

            if (necessaryHours <= totalHour)
            {
                Console.WriteLine($"Yes!{totalHour - necessaryHours} hours left.");
            }
            else if (necessaryHours > totalHour)
            {
                Console.WriteLine($"Not enough time!{necessaryHours - totalHour } hours needed.");
            }
        }
    }
}
