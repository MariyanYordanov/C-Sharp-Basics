using System;

namespace FruitShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string day = Console.ReadLine();
            double number = double.Parse(Console.ReadLine());

            if (day == "Saturday" || day == "Sunday")
            {
                if (fruit == "banana")
                {
                    Console.WriteLine($"{(2.70 * number):f2}");
                }
                else if (fruit == "apple")
                {
                    Console.WriteLine($"{(1.25 * number):f2}");
                }
                else if (fruit == "orange")
                {
                    Console.WriteLine($"{(0.90 * number):f2}");
                }
                else if (fruit == "grapefruit")
                {
                    Console.WriteLine($"{(1.60 * number):f2}");
                }
                else if (fruit == "kiwi")
                {
                    Console.WriteLine($"{(3.00 * number):f2}");
                }
                else if (fruit == "pineapple")
                {
                    Console.WriteLine($"{(5.60 * number):f2}");
                }
                else if (fruit == "grapes")
                {
                    Console.WriteLine($"{(4.20 * number):f2}");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (day == "Monday" 
                || day == "Tuesday" 
                || day == "Wednesday" 
                || day == "Thursday" 
                || day == "Friday")
            {
                if (fruit == "banana")
                {
                    Console.WriteLine($"{(2.50 * number):f2}");
                }
                else if (fruit == "apple")
                {
                    Console.WriteLine($"{(1.20 * number):f2}");
                }
                else if (fruit == "orange")
                {
                    Console.WriteLine($"{(0.85 * number):f2}");
                }
                else if (fruit == "grapefruit")
                {
                    Console.WriteLine($"{(1.45 * number):f2}");
                }
                else if (fruit == "kiwi")
                {
                    Console.WriteLine($"{(2.70 * number):f2}");
                }
                else if (fruit == "pineapple")
                {
                    Console.WriteLine($"{(5.50 * number):f2}");
                }
                else if (fruit == "grapes")
                {
                    Console.WriteLine($"{(3.85 * number):f2}");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
