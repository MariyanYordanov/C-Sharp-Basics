﻿using System;

namespace Fruit_Shop
{
    class Program
    {
        static void Main(string[] args)
        {


            string fruit = Console.ReadLine();
            string day = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            double price = 0;



            switch (day)
            {
                case "Monday":
                case "Tuesday":
                case "Wednesday":
                case "Thursday":
                case "Friday":
                    if (fruit == "banana")
                    {
                        price = 2.50;
                    }
                    else if (fruit == "apple")
                    {
                        price = 1.20;
                    }
                    else if (fruit == "orange")
                    {
                        price = 0.85;
                    }
                    else if (fruit == "grapefruit")
                    {
                        price = 1.45;
                    }
                    else if (fruit == "kiwi")
                    {
                        price = 2.70;
                    }
                    else if (fruit == "pineapple")
                    {
                        price = 5.50;
                    }
                    else if (fruit == "grapes")
                    {
                        price = 3.85;
                    }
                    Console.WriteLine("error");
                    break;
                case "Saturday":
                case "Sunday":
                    if (fruit == "banana")
                    {
                        price = 2.70;
                    }
                    else if (fruit == "apple")
                    {
                        price = 1.25;
                    }
                    else if (fruit == "orange")
                    {
                        price = 0.90;
                    }
                    else if (fruit == "grapefruit")
                    {
                        price = 1.60;
                    }
                    else if (fruit == "kiwi")
                    {
                        price = 3.00;
                    }
                    else if (fruit == "pineapple")
                    {
                        price = 5.60;
                    }
                    else if (fruit == "grapes")
                    {
                        price = 4.20;
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                    break;

            }
            double totalPrice = price * quantity;

            Console.WriteLine($"{totalPrice:f2}");






        }
    }
}