using System;

namespace VacationBooksList
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPges = int.Parse(Console.ReadLine());
            double readPagesPerHour = double.Parse(Console.ReadLine());
            int numberOfPagesPerDay = int.Parse(Console.ReadLine());

            double timePerReadBook = numberOfPges / readPagesPerHour;
            double numberOfHoursPerDay = timePerReadBook / numberOfPagesPerDay;

            Console.WriteLine(numberOfHoursPerDay);
        }
    }
}
