using System;

namespace _0006._Bills
{
    class Program
    {
        static void Main(string[] args)
        {
            double month = double.Parse(Console.ReadLine());
            double bildsEl = 0;
            double water = 0;
            double net = 0;
            double others = 0;

            for (int i = 0; i < month; i++)
            {
                double el = double.Parse(Console.ReadLine());
                bildsEl += el;
                water += 20;
                net += 15;
                others = (bildsEl + water + net) * 1.2;
            }

            double averageBillds = (bildsEl + water + net + others) / month;
            
            Console.WriteLine($"Electricity: {bildsEl:f2} lv");
            Console.WriteLine($"Water: {water:f2} lv");
            Console.WriteLine($"Internet: {net:f2} lv");
            Console.WriteLine($"Other: {others:f2} lv");
            Console.WriteLine($"Average: {averageBillds:f2} lv");
        }
    }
}
