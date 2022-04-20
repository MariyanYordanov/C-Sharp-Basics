using System;

namespace _01._Food_Delivery
{
    class Program
    {
        static void Main(string[] args)
        {
            double chickenMenus = int.Parse(Console.ReadLine());
            double fishMenus = int.Parse(Console.ReadLine());
            double vegetarianmenus = int.Parse(Console.ReadLine());

            double priceChickenMenus = chickenMenus * 10.35;
            double priceFishMenus = fishMenus * 12.40;
            double priceVegetarianmenus = vegetarianmenus * 8.15;

            double check = priceChickenMenus + priceFishMenus + priceVegetarianmenus;
            double desert = check * 0.2;
            double total = check + desert + 2.5;

            Console.WriteLine($"Total: {total:f2}");
        }
    }
}
