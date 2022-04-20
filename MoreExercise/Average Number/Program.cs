using System;

namespace _0005._Average_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            double sum = 0;
            for (int i = 0; i < n; i++)
            {
                double number = double.Parse(Console.ReadLine());

                sum += number;
            }
            Console.WriteLine($"{sum / n:f2}");
        }
    }
}
