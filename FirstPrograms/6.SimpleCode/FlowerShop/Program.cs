using System;

namespace FlowerShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int Magnolias = int.Parse(Console.ReadLine()); 
            int Hyacinths = int.Parse(Console.ReadLine()); 
            int Roses = int.Parse(Console.ReadLine());
            int Cacti = int.Parse(Console.ReadLine());
            double giftCoust = double.Parse(Console.ReadLine());

            double order = Magnolias * 3.25 + Hyacinths * 4 + Roses * 3.5 + Cacti * 8;
            double total = order - (order * 0.05);

            if (total >= giftCoust)
            {
                Console.WriteLine($"She is left with {Math.Floor(total - giftCoust)} leva.");
            }
            else if (total < giftCoust)
            {
                Console.WriteLine($"She will have to borrow {Math.Ceiling(giftCoust - total)} leva.");
            }
        }
    }
}
