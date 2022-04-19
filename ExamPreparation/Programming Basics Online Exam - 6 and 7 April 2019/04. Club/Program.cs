using System;

namespace _04._Club
{
    class Program
    {
        static void Main(string[] args)
        {
            double clubProfit = double.Parse(Console.ReadLine());
            string cocktail = Console.ReadLine();
            double total = 0;
            bool check = false;

            while (cocktail != "Party!")
            {
                double numberOfCocktails = double.Parse(Console.ReadLine());

                double priceCocktail = cocktail.Length;
                double sum = priceCocktail * numberOfCocktails;
                double odd = sum % 10;

                if ( odd % 2 != 0)
                {
                    sum *= 0.75;
                }
                total += sum;

                if (total >= clubProfit)
                {
                    check = true;
                    break;
                }
                cocktail = Console.ReadLine();
            }
            if (cocktail == "Party!")
            {
                Console.WriteLine($"We need {(clubProfit - total):F2} leva more.");
            }
            else if (check)
            {
                Console.WriteLine($"Target acquired.");
            }
            Console.WriteLine($"Club income - {total:f2} leva.");
        }
    }
}
