using System;

namespace _011._Repainting
{
    class Program
    {
        static void Main(string[] args)
        {
            double nylon = double.Parse(Console.ReadLine());
            double paint = double.Parse(Console.ReadLine());
            double diluent = double.Parse(Console.ReadLine());
            double hours = double.Parse(Console.ReadLine());

            double totalNylon = (nylon + 2) * 1.5;
            double totalPaint = (paint * 1.1) * 14.50;
            double costs = totalNylon + totalPaint + diluent * 5 + 0.4;
            double rerHour = costs * 0.3;

            double total = costs + (rerHour * hours);
            Console.WriteLine($"Total expenses: {total:f2} lv.");
        }
    }
}
