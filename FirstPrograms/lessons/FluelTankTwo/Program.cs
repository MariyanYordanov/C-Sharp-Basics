using System;

namespace FluelTankTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            string fluelType = Console.ReadLine();
            double quantity = int.Parse(Console.ReadLine());
            string card = Console.ReadLine();

            if (card == "No")
            {
                if ((quantity > 20) && (quantity <= 25))
                {
                    if (fluelType == "Gasoline")
                    {
                        double coust = (quantity * 2.22) - (quantity * 2.22 * 0.08);
                        Console.WriteLine($"{coust:f2} lv.");
                    }
                    else if (fluelType == "Diesel")
                    {
                        double coust = (quantity * 2.33) - (quantity * 2.33 * 0.08);
                        Console.WriteLine($"{coust:f2} lv.");
                    }
                    else if (fluelType == "Gas")
                    {
                        double coust = (quantity * 0.93) - (quantity * 0.93 * 0.08);
                        Console.WriteLine($"{coust:f2} lv.");
                    }
                }
                else if (quantity > 25)
                {
                    if (fluelType == "Gasoline")
                    {
                        double coust = (quantity * 2.22) - (quantity * 2.22 * 0.1);
                        Console.WriteLine($"{coust:f2} lv.");
                    }
                    else if (fluelType == "Diesel")
                    {
                        double coust = (quantity * 2.33) - (quantity * 2.33 * 0.1);
                        Console.WriteLine($"{coust:f2} lv.");
                    }
                    else if (fluelType == "Gas")
                    {
                        double coust = (quantity * 0.93) - (quantity * 0.93 * 0.1);
                        Console.WriteLine($"{coust:f2} lv.");
                    }
                }
                else
                {
                    if (fluelType == "Gasoline")
                    {
                        double coust = quantity * 2.22 ;
                        Console.WriteLine($"{coust:f2} lv.");
                    }
                    else if (fluelType == "Diesel")
                    {
                        double coust = quantity * 2.33;
                        Console.WriteLine($"{coust:f2} lv.");
                    }
                    else if (fluelType == "Gas")
                    {
                        double coust = quantity * 0.93;
                        Console.WriteLine($"{coust:f2} lv.");
                    }
                }
            }
            else if (card == "Yes")
            {
                if ((quantity > 20) && (quantity <= 25))
                {
                    if (fluelType == "Gasoline")
                    {
                        double coust = (quantity * 2.04) - (quantity * 2.04 * 0.08);
                        Console.WriteLine($"{coust:f2} lv.");
                    }
                    else if (fluelType == "Diesel")
                    {
                        double coust = (quantity * 2.21) - (quantity * 2.21 * 0.08);
                        Console.WriteLine($"{coust:f2} lv.");
                    }
                    else if (fluelType == "Gas")
                    {
                        double coust = (quantity * 0.85) - (quantity * 0.85 * 0.08);
                        Console.WriteLine($"{coust:f2} lv.");
                    }
                }
                else if (quantity > 25)
                {
                    if (fluelType == "Gasoline")
                    {
                        double coust = (quantity * 2.04) - (quantity * 2.04 * 0.1);
                        Console.WriteLine($"{coust:f2} lv.");
                    }
                    else if (fluelType == "Diesel")
                    {
                        double coust = (quantity * 2.21) - (quantity * 2.21 * 0.1);
                        Console.WriteLine($"{coust:f2} lv.");
                    }
                    else if (fluelType == "Gas")
                    {
                        double coust = (quantity * 0.85) - (quantity * 0.85 * 0.1);
                        Console.WriteLine($"{coust:f2} lv.");
                    }
                }
                else
                {
                    if (fluelType == "Gasoline")
                    {
                        double coust = (quantity * 2.04);
                        Console.WriteLine($"{coust:f2} lv.");
                    }
                    else if (fluelType == "Diesel")
                    {
                        double coust = (quantity * 2.21);
                        Console.WriteLine($"{coust:f2} lv.");
                    }
                    else if (fluelType == "Gas")
                    {
                        double coust = (quantity * 0.85);
                        Console.WriteLine($"{coust:f2} lv.");
                    }
                }
            }
        }
    }
}
