using System;

namespace _03._Fitness_Card
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            string sex = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string sport = Console.ReadLine();
            double priceCard = 0;
            if (sex == "m")
            {
                if (sport == "Gym")
                {
                    priceCard = 42;
                }
                else if (sport == "Boxing")
                {
                    priceCard = 41;
                }
                else if (sport == "Yoga")
                {
                    priceCard = 45;
                }
                else if (sport == "Zumba")
                {
                    priceCard = 34;
                }
                else if (sport == "Dances")
                {
                    priceCard = 51;
                }
                else if (sport == "Pilates")
                {
                    priceCard = 39;
                }
            }
            else if (sex == "f")
            {
                if (sport == "Gym")
                {
                    priceCard = 35;
                }
                else if (sport == "Boxing")
                {
                    priceCard = 37;
                }
                else if (sport == "Yoga")
                {
                    priceCard = 42;
                }
                else if (sport == "Zumba")
                {
                    priceCard = 31;
                }
                else if (sport == "Dances")
                {
                    priceCard = 53;
                }
                else if (sport == "Pilates")
                {
                    priceCard = 37;
                }
            }
            if (age <= 19)
            {
                priceCard *= 0.8;
            }

            if (priceCard <= money)
            {
                Console.WriteLine($"You purchased a 1 month pass for {sport}.");
            }
            else
            {
                Console.WriteLine($"You don't have enough money! You need ${(priceCard -money):f2} more.");
            }
        }
    }
}
