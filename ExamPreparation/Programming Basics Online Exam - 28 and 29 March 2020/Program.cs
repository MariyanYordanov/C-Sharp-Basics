using System;

namespace Programming_Basics_Online_Exam___28_and_29_March_2020
{
    class Program
    {
        static void Main(string[] args)
        {
            double numPens = int.Parse(Console.ReadLine());
            double numMarkers = int.Parse(Console.ReadLine());
            double LITER = double.Parse(Console.ReadLine());
            double porcentDiscount = double.Parse(Console.ReadLine());

            double pricePens = 5.80 * numPens;
            double priceMarkers = 7.20 * numMarkers;
            double priceLiter = 1.20 * LITER;
            double sum = pricePens + priceMarkers + priceLiter;
            double total = sum * ( 1.00 - (porcentDiscount / 100));
            Console.WriteLine($"{total:f3}");
        }
    }
}
