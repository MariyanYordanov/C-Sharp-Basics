using System;

namespace SkiTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string rooms = Console.ReadLine();
            string raiting = Console.ReadLine();

            int nights = days - 1;
            double total = 0;

            if (rooms == "room for one person" && raiting == "positive")
            {
                double tripPrice = 18 * nights;
                total = tripPrice + (tripPrice * 0.25);
            }
            else if (rooms == "room for one person" && raiting == "negative")
            {
                double tripPrice = 18 * nights;
                total = tripPrice - (tripPrice * 0.10);
            }
            else if (rooms == "apartment" && nights < 10 && raiting == "positive")
            {
                double tripPrice = 25 * nights;
                double discount = tripPrice - (tripPrice * 0.30);
                total = discount + (discount * 0.25);
            }
            else if (rooms == "apartment" && nights < 10 && raiting == "negative")
            {
                double tripPrice = 25 * nights;
                double discount = tripPrice - (tripPrice * 0.30);
                total = discount - (discount * 0.10);
            }
            else if (rooms == "apartment" && (nights >= 10 && nights <= 15 )&& raiting == "positive")
            {
                double tripPrice = 25 * nights;
                double discount = tripPrice - (tripPrice * 0.35);
                total = discount + (discount * 0.25);
            }
            else if (rooms == "apartment" && (nights >= 10 && nights <= 15) && raiting == "negative")
            {
                double tripPrice = 25 * nights;
                double discount = tripPrice - (tripPrice * 0.35);
                total = discount - (discount * 0.10);
            }
            else if (rooms == "apartment" && (nights > 15) && raiting == "positive")
            {
                double tripPrice = 25 * nights;
                double discount = tripPrice - (tripPrice * 0.50);
                total = discount + (discount * 0.25);
            }
            else if (rooms == "apartment" && (nights > 15) && raiting == "negative")
            {
                double tripPrice = 25 * nights;
                double discount = tripPrice - (tripPrice * 0.50);
                total = discount - (discount * 0.10);
            }
            else if (rooms == "president apartment" && nights < 10 && raiting == "positive")
            {
                double tripPrice = 35 * nights;
                double discount = tripPrice - (tripPrice * 0.10);
                total = discount + (discount * 0.25);
            }
            else if (rooms == "president apartment" && nights < 10 && raiting == "negative")
            {
                double tripPrice = 35 * nights;
                double discount = tripPrice - (tripPrice * 0.10);
                total = discount - (discount * 0.10);
            }
            else if (rooms == "president apartment" && (nights >= 10 && nights <= 15) && raiting == "positive")
            {
                double tripPrice = 35 * nights;
                double discount = tripPrice - (tripPrice * 0.15);
                total = discount + (discount * 0.25);
            }
            else if (rooms == "president apartment" && (nights >= 10 && nights <= 15) && raiting == "negative")
            {
                double tripPrice = 35 * nights;
                double discount = tripPrice - (tripPrice * 0.15);
                total = discount - (discount * 0.10);
            }
            else if (rooms == "president apartment" && (nights > 15) && raiting == "positive")
            {
                double tripPrice = 35 * nights;
                double discount = tripPrice - (tripPrice * 0.20);
                total = discount + (discount * 0.25);
            }
            else if (rooms == "president apartment" && (nights > 15) && raiting == "negative")
            {
                double tripPrice = 35 * nights;
                double discount = tripPrice - (tripPrice * 0.20);
                total = discount - (discount * 0.10);
            }
            Console.WriteLine($"{total:f2}");
        }
    }
}
