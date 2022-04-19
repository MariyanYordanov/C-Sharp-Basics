using System;

namespace TransportPrice
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int km = int.Parse(Console.ReadLine());
            string orOr = Console.ReadLine();

            if (km < 20)
            {
                double dayTaxi = 0.7 + (km * 0.79);
                double nightTaxi = 0.7 + (km * 0.90);
                if (orOr == "day")
                {
                    Console.WriteLine($"{dayTaxi:f2}");
                }
                
                else if (orOr == "night")
                {
                    Console.WriteLine($"{nightTaxi:f2}");
                }
                
            }
            else if (km < 100)
            {
                double bus = km * 0.09;
                Console.WriteLine($"{bus:f2}");
            }
            else if (km >= 100)
            {
                double train = km * 0.06;
                Console.WriteLine($"{train:f2}");
            }

        }
    }
}
