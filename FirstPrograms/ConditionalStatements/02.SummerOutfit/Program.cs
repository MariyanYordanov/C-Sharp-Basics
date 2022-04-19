using System;

namespace _02.SummerOutfit
{
    class Program
    {
        static void Main(string[] args)
        {
            int degrees = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();

            string outfit = "";
            string shoes = "";

            if (type == "Morning" && (degrees >= 10 && degrees <= 18))
            {
                outfit = "Sweatshirt";
                shoes = "Sneakers";
            }
            else if (type == "Afternoon" && (degrees >= 10 && degrees <= 18))
            {
                outfit = "Shirt";
                shoes = "Moccasins";
            }
            else if (type == "Morning" && (degrees > 18 && degrees <= 24))
            {
                outfit = "Shirt";
                shoes = "Moccasins";
            }
            else if (type == "Afternoon" && (degrees > 18 && degrees <= 24))
            {
                outfit = "T-Shirt";
                shoes = "Sandals";
            }
            else if (type == "Morning" && degrees >= 25)
            {
                outfit = "T-Shirt";
                shoes = "Sandals";
            }
            else if (type == "Afternoon" && degrees >= 25)
            {
                outfit = "Swim Suit";
                shoes = "Barefoot";
            }
            else if (type == "Evening")
            {
                outfit = "Shirt";
                shoes = "Moccasins";
            }
            Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.");
        }
    }
}
