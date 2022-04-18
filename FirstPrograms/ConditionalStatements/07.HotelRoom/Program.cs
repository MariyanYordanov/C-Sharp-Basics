using System;

namespace _07.HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int overnight = int.Parse(Console.ReadLine());

            double priceApart = 0;
            double priceStudio = 0;

            if ((month == "May" || month == "October") && (overnight > 7 && overnight <= 14))
            {
                priceApart = overnight * 65;
                priceStudio = overnight * (50 * 0.95);
            }
            else if ((month == "May" || month == "October") && (overnight <= 7))
            {
                priceApart = overnight * 65;
                priceStudio = overnight * 50;
            }
            else if ((month == "May" || month == "October") && (overnight > 14))
            {
                priceApart = overnight * (65 * 0.90);
                priceStudio = overnight * (50 * 0.70);
            }
            else if ((month == "June" || month == "September") && (overnight <= 14))
            {
                priceApart = overnight * 68.70;
                priceStudio = overnight * 75.20;
            }
            else if ((month == "June" || month == "September") && (overnight > 14))
            {
                priceApart = overnight * (68.70 * 0.90);
                priceStudio = overnight * (75.20 * 0.80);
            }
            else if ((month == "July" || month == "August") && (overnight <= 14))
            {
                priceApart = overnight * 77;
                priceStudio = overnight * 76;
            }
            else if ((month == "July" || month == "August") && (overnight > 14))
            {
                priceApart = overnight * (77 * 0.90);
                priceStudio = overnight * 76;
            }

            Console.WriteLine($"Apartment: {priceApart:f2} lv.");
            Console.WriteLine($"Studio: {priceStudio:f2} lv.");

        }
    }
}
