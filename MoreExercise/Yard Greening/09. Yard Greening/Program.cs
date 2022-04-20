using System;

namespace _09._Yard_Greening
{
    class Program
    {
        static void Main(string[] args)
        {
            double sqMeters = double.Parse(Console.ReadLine());

            double priceForOneSqMeter = 7.61;
            double discount = 0.18;

            double priceServe = sqMeters * priceForOneSqMeter ;
            double priceDiscount = priceServe * discount ;

            double finalPrice = priceServe - priceDiscount;

            Console.WriteLine($"The final price is: {finalPrice} lv.");
            Console.WriteLine($"The discount is: {priceDiscount} lv.");

        }
    }
}
