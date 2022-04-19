using System;

namespace _01.Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());

            double seats = rows * cols;
            double total = 0;

            if (type == "Premiere")
            {
                total = seats * 12;
            }
            else if (type == "Normal")
            {
                total = seats * 7.50;
            }
            else if (type == "Discount")
            {
                total = seats * 5;
            }
            Console.WriteLine($"{total:f2}");
        }
    }
}
