using System;

namespace _05._PC_Game_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = int.Parse(Console.ReadLine());
            int counterHearthstone = 0;
            int counterFornite = 0;
            int counterOverwatch = 0;
            int counterOthers = 0;

            for (int i = 0; i < n; i++)
            {
                string game = Console.ReadLine();

                if (game == "Hearthstone")
                {
                    counterHearthstone++;
                }
                else if (game == "Fornite")
                {
                    counterFornite++;
                }
                else if (game == "Overwatch")
                {
                    counterOverwatch++;
                }
                else
                {
                    counterOthers++;
                }
            }

            double total = counterOthers + counterHearthstone + counterFornite + counterOverwatch;
            double porcentHearthstone = counterHearthstone / total * 100;
            double porcentFornite = counterFornite / total * 100;
            double porcentOverwatch = counterOverwatch / total * 100;
            double porcentOthers = counterOthers / total * 100;

            Console.WriteLine($"Hearthstone - {porcentHearthstone:f2}%");
            Console.WriteLine($"Fornite - {porcentFornite:f2}%");
            Console.WriteLine($"Overwatch - {porcentOverwatch:f2}%");
            Console.WriteLine($"Others - {porcentOthers:f2}%");

        }
    }
}
