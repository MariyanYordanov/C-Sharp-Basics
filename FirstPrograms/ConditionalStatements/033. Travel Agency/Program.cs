using System;

namespace _033._Travel_Agency
{
    class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine();
            string pocket = Console.ReadLine();
            string vip = Console.ReadLine();
            double days = double.Parse(Console.ReadLine());

            double price = 0;
            if (days > 7)
            {
                days--;
            }
            if (town == "Bansko" || town == "Borovets")
            {
                if (pocket == "noEquipment")
                {
                    if (vip == "yes")
                    {
                        price = 80 * 0.95;
                    }
                    if (vip == "no")
                    {
                        price = 80;
                    }
                }
                else if (pocket == "withEquipment")
                {
                    if (vip == "yes")
                    {
                        price = 100 * 0.9;
                    }
                    if (vip == "no")
                    {
                        price = 100;
                    }
                }
                else
                {
                    Console.WriteLine($"Invalid input!");
                }
            }
            else if (town == "Varna" || town == "Burgas")
            {
                if (pocket == "noBreakfast")
                {
                    if (vip == "yes")
                    {
                        price = 100 * 0.93;
                    }
                    else if (vip == "no")
                    {
                        price = 100;
                    }
                }
                else if (pocket == "withBreakfast")
                {
                    if (vip == "yes")
                    {
                        price = 130 * 0.88;
                    }
                    else if (vip == "no")
                    {
                        price = 130;
                    }
                }
                else
                {
                    Console.WriteLine($"Invalid input!");
                }
            }
            else
            {
                Console.WriteLine($"Invalid input!");
            }

            double total = price * days;

            if (days < 1)
            {
                Console.WriteLine($"Days must be positive number!");
            }

            if (days > 0 && (pocket == "noEquipment" || pocket == "withEquipment" || pocket == "noBreakfast" || pocket == "withBreakfast") && (town == "Bansko" || town == "Borovets" || town == "Varna" || town == "Burgas"))
            {
                Console.WriteLine($"The price is {total:f2}lv! Have a nice time!");
            }
            
        }
    }
}
