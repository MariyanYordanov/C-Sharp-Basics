using System;

namespace _03._Aluminum_Joinery
{
    class Program
    {
        static void Main(string[] args)
        {
            double numberWindows = int.Parse(Console.ReadLine());
            string tipWindows = Console.ReadLine();
            string delivery = Console.ReadLine();

            double price = 0;

            if (numberWindows <= 10)
            {
                Console.WriteLine($"Invalid order");
                return;
            }
            if (tipWindows == "90X130")
            {
                if (numberWindows <= 30)
                {
                    price = 110;
                }
                else if (numberWindows <= 60)
                {
                    price = 110 * 0.95;
                }
                else if (numberWindows > 60)
                {
                    price = 110 * 0.92;
                }
            }
            else if (tipWindows == "100X150")
            {
                if (numberWindows <= 40)
                {
                    price = 140;
                }
                else if (numberWindows <= 80)
                {
                    price = 140 * 0.94;
                }
                else if (numberWindows > 80)
                {
                    price = 140 * 0.9;
                }
            }
            else if (tipWindows == "130X180")
            {
                if (numberWindows <= 20)
                {
                    price = 190;
                }
                else if (numberWindows <= 50)
                {
                    price = 190 * 0.93;
                }
                else if (numberWindows > 50)
                {
                    price = 190 * 0.88;
                }
            }
            else if (tipWindows == "200X300")
            {
                if (numberWindows <= 25)
                {
                    price = 250;
                }
                else if (numberWindows <= 50)
                {
                    price = 250 * 0.91;
                }
                else if (numberWindows > 50)
                {
                    price = 250 * 0.86;
                }
            }

            double total = price * numberWindows;

            if (delivery == "With delivery")
            {
                total += 60;
            }
            if (numberWindows > 99)
            {
                total *= 0.96;
            }

            Console.WriteLine($"{total:f2} BGN");
        }
    }
}
