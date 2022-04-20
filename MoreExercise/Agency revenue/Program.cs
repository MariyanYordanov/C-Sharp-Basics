using System;

namespace _1Agency_revenue
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double adultTicket = int.Parse(Console.ReadLine());
            double kidTicket = int.Parse(Console.ReadLine());
            double netAdultTicket = double.Parse(Console.ReadLine());
            double taxService = double.Parse(Console.ReadLine());

            double netKidTicket = netAdultTicket - (netAdultTicket * 0.7);

            double priceKid = kidTicket * (netKidTicket + taxService);

            double priceAdult = adultTicket * (netAdultTicket + taxService);

            double profit = (priceKid + priceAdult) * 0.2;

            Console.WriteLine($"The profit of your agency from {name} tickets is {profit:f2} lv.");
        }
    }
}
