using System;

namespace BhirthdayParty
{
    class Program
    {
        static void Main(string[] args)
        {
            double rentForHall = double.Parse(Console.ReadLine());

            double cakePrice = rentForHall * 0.2;
            double drinksPrice = cakePrice -(cakePrice * 0.45);
            double clownPrice = rentForHall / 3;

            double sumBudget = cakePrice + drinksPrice + clownPrice + rentForHall;

            Console.WriteLine(sumBudget);
        }
    }
}
