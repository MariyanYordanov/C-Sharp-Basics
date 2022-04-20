using System;

namespace _03._Courier_Express
{
    class Program
    {
        static void Main(string[] args)
        {
            double weight = double.Parse(Console.ReadLine());
            string services = Console.ReadLine();
            double distance = double.Parse(Console.ReadLine());

            double pricePerKilometer = 0;

            if (services == "standard")
            {
                if (weight < 1)
                {
                    pricePerKilometer = 0.03;
                }
                else if (weight <= 10)
                {
                    pricePerKilometer = 0.05;
                }
                else if (weight <= 40)
                {
                    pricePerKilometer = 0.10;
                }
                else if (weight <= 90)
                {
                    pricePerKilometer = 0.15;
                }
                else if (weight <= 150)
                {
                    pricePerKilometer = 0.20;
                }
            }
            else if (services == "express")
            {
                if (weight < 1)
                {
                    pricePerKilometer = 0.03 + (weight * (0.03 * 80 / 100));
                }
                else if (weight <= 10)
                {
                    pricePerKilometer = 0.05 + (weight * (0.05 * 40 / 100));
                }
                else if (weight <= 40)
                {
                    pricePerKilometer = 0.10 + (weight * (0.10 * 5 / 100));
                }
                else if (weight <= 90)
                {
                    pricePerKilometer = 0.15 + (weight * (0.15 * 2 / 100));
                }
                else if (weight <= 150)
                {
                    pricePerKilometer = 0.20 + (weight * (0.20 * 1 / 100));
                }
            }

            double totalPrice = distance * pricePerKilometer;

            Console.WriteLine($"The delivery of your shipment with weight of {weight:f3} kg. would cost {totalPrice:f2} lv.");
        }
    }
}
