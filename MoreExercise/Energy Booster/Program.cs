using System;

namespace _03._Energy_Booster
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string setType = Console.ReadLine();
            int set = int.Parse(Console.ReadLine());

            double price = 0;
            if (setType == "small")
            {
                if (fruit == "Watermelon")
                {
                    price = 56 * 2;
                }
                else if (fruit == "Mango")
                {
                    price = 36.66 * 2;
                }
                else if (fruit == "Pineapple")
                {
                    price = 42.10 * 2;
                }
                else if (fruit == "Raspberry")
                {
                    price = 20 * 2;
                }
            }
            else
            {
                if (fruit == "Watermelon")
                {
                    price = 28.70 * 5;
                }
                else if (fruit == "Mango")
                {
                    price = 19.60 * 5;
                }
                else if (fruit == "Pineapple")
                {
                    price = 24.80 * 5;
                }
                else if (fruit == "Raspberry")
                {
                    price = 15.20 * 5;
                }
            }
            double totalPrice = set * price;
            if (totalPrice >= 400 && totalPrice <= 1000)
            {
                totalPrice *= 0.85;
            }
            else if (totalPrice > 1000)
            {
                totalPrice *= 0.5;
            }
            
            Console.WriteLine($"{totalPrice:f2} lv.");
        }
    }
}
