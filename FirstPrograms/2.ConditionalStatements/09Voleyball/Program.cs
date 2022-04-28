using System;

namespace _09Voleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string yearType = Console.ReadLine();
            int p = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());

            double pSofia = (48 - h) * (3/4.0);
            double holyday = p * (2 / 3.0);
            double total = pSofia + h + holyday;
            if (yearType == "leap")
            {
               total *= 1.15;
            }
            Console.WriteLine(Math.Floor(total));
        }
    }
}
