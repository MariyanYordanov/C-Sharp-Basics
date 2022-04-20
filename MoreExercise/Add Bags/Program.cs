using System;

namespace _02._Add_Bags
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceBaggageOverTewnty = double.Parse(Console.ReadLine());
            double weigthBaggage = double.Parse(Console.ReadLine());
            int daysToTrip = int.Parse(Console.ReadLine());
            int counterBaggage = int.Parse(Console.ReadLine());

            double priceBaggage = 0;
            if (weigthBaggage < 10)
            {
                priceBaggage = priceBaggageOverTewnty * 0.2;
            }
            else if (weigthBaggage <= 20)
            {
                priceBaggage = priceBaggageOverTewnty * 0.5;
            }
            else
            {
                priceBaggage = priceBaggageOverTewnty;
            }

            if (daysToTrip < 7)
            {
                priceBaggage *= 1.4;
            }
            else if (daysToTrip <= 30)
            {
                priceBaggage *= 1.15;
            }
            else
            {
                priceBaggage *= 1.1;
            }
            double totalPrice = counterBaggage * priceBaggage;
            Console.WriteLine($"The total price of bags is: {totalPrice:f2} lv.");
        }
    }
}
