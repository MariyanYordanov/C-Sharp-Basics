using System;

namespace _03._Oscars_week_in_cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string movieName = Console.ReadLine();
            string hallType = Console.ReadLine();
            double ticket = double.Parse(Console.ReadLine());

            double price = 0;
            if (movieName == "A Star Is Born")
            {
                if (hallType == "normal")
                {
                    price = 7.50;
                }
                else if (hallType == "luxury")
                {
                    price = 10.50;
                }
                else if (hallType == "ultra luxury")
                {
                    price = 13.50;
                }
                
            }
            else if (movieName == "Bohemian Rhapsody")
            {
                if (hallType == "normal")
                {
                    price = 7.35;
                }
                else if (hallType == "luxury")
                {
                    price = 9.45;
                }
                else if (hallType == "ultra luxury")
                {
                    price = 12.75;
                }
            }
            else if (movieName == "Green Book")
            {
                if (hallType == "normal")
                {
                    price = 8.15;
                }
                else if (hallType == "luxury")
                {
                    price = 10.25;
                }
                else if (hallType == "ultra luxury")
                {
                    price = 13.25;
                }
            }
            else if (movieName == "The Favourite")
            {
                if (hallType == "normal")
                {
                    price =8.75;
                }
                else if (hallType == "luxury")
                {
                    price = 11.55;
                }
                else if (hallType == "ultra luxury")
                {
                    price = 13.95;
                }
            }

            double income = ticket * price;

            Console.WriteLine($"{movieName} -> {income:f2} lv.");
        }
    }
}
