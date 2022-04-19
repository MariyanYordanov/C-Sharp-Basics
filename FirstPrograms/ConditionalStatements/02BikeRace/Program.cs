using System;

namespace _02BikeRace
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberJuniorBikers = int.Parse(Console.ReadLine());
            int numberSeniorBikers = int.Parse(Console.ReadLine());
            string trace = Console.ReadLine();

            int numTotal = numberJuniorBikers + numberSeniorBikers;
            double taxJunior = 0;
            double taxSenior = 0;

            if (numTotal >= 50 && trace == "cross-country")
            {
                taxJunior = 8 * 0.75;
                taxSenior = 9.5 * 0.75;
            }
            else if (trace == "cross-country")
            {
                taxJunior = 8;
                taxSenior = 9.5;
            }
            else if (trace == "trail")
            {
                taxJunior = 5.5;
                taxSenior = 7;
            }
            else if (trace == "downhill")
            {
                taxJunior = 12.25;
                taxSenior = 13.75;
            }
            else if (trace == "road")
            {
                taxJunior = 20;
                taxSenior = 21.5;
            }
            double active = (taxSenior * numberSeniorBikers) + (taxJunior * numberJuniorBikers);
            double tax = active * 0.05;
            double total = active - tax;
            Console.WriteLine($"{total:f2}");
        }
    }
}
