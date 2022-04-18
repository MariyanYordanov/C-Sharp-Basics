using System;

namespace TradeCommissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine();
            double sales = double.Parse(Console.ReadLine());
            double comision = 0;

            if (!(town == "Sofia" || town == "Varna" || town == "Plovdiv") || sales <= 0)
            {
                Console.WriteLine("error");
            }
            else if (sales <= 500)
            {
                if (town == "Sofia")
                {
                    comision = sales * 0.05;
                    Console.WriteLine($"{comision:f2}");
                }
                else if (town == "Varna")
                {
                    comision = sales * 0.045;
                    Console.WriteLine($"{comision:f2}");
                }
                else if (town == "Plovdiv")
                {
                    comision = sales * 0.055;
                    Console.WriteLine($"{comision:f2}");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (sales <= 1000)
            {
                if (town == "Sofia")
                {
                    comision = sales * 0.07;
                    Console.WriteLine($"{comision:f2}");
                }
                else if (town == "Varna")
                {
                    comision = sales * 0.075;
                    Console.WriteLine($"{comision:f2}");
                }
                else if (town == "Plovdiv")
                {
                    comision = sales * 0.08;
                    Console.WriteLine($"{comision:f2}");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (sales <= 10000)
            {
                if (town == "Sofia")
                {
                    comision = sales * 0.08;
                    Console.WriteLine($"{comision:f2}");
                }
                else if (town == "Varna")
                {
                    comision = sales * 0.10;
                    Console.WriteLine($"{comision:f2}");
                }
                else if (town == "Plovdiv")
                {
                    comision = sales * 0.12;
                    Console.WriteLine($"{comision:f2}");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (sales > 10000)
            {
                if (town == "Sofia")
                {
                    comision = sales * 0.12;
                    Console.WriteLine($"{comision:f2}");
                }
                else if (town == "Varna")
                {
                    comision = sales * 0.13;
                    Console.WriteLine($"{comision:f2}");
                }
                else if (town == "Plovdiv")
                {
                    comision = sales * 0.145;
                    Console.WriteLine($"{comision:f2}");
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
