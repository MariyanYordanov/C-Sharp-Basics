using System;

namespace _03._Mobile_operator
{
    class Program
    {
        static void Main(string[] args)
        {
            string period = Console.ReadLine();
            string type = Console.ReadLine();
            string net = Console.ReadLine();
            int month = int.Parse(Console.ReadLine());

            double price = 0;

            if (period == "one")
            {
                if (type == "Small")
                {
                    price = 9.98;
                }
                else if (type == "Middle")
                {
                    price = 18.99;
                }
                else if (type == "Large")
                {
                    price = 25.98;
                }
                else if (type == "ExtraLarge")
                {
                    price = 35.99;
                }
            }
            else if (period == "two")
            {
                if (type == "Small")
                {
                    price = 8.58;
                }
                else if (type == "Middle")
                {
                    price = 17.09;
                }
                else if (type == "Large")
                {
                    price = 23.59;
                }
                else if (type == "ExtraLarge")
                {
                    price = 31.79;
                }
            }
            if (net == "yes")
            {
                if (price <= 10)
                {
                    price += 5.50;
                }
                else if (price <= 30)
                {
                    price += 4.35;
                }
                else if (price > 30)
                {
                    price += 3.85;
                }
            }
            double total = price * month;
            if (period == "two")
            {
                total = total * 0.9625;
            }
            Console.WriteLine($"{total:f2} lv.");
        }
    }
}
