using System;

namespace _0007._Football_League
{
    class Program
    {
        static void Main(string[] args)
        {
            double capacity = int.Parse(Console.ReadLine());
            double fens = int.Parse(Console.ReadLine());
            int counterA = 0;
            int counterB = 0;
            int counterV = 0;
            int counterG = 0;
            for (int i = 0; i < fens; i++)
            {
                string sector = Console.ReadLine();

                if (sector == "A")
                {
                    counterA++;
                }

                if (sector == "B")
                {
                    counterB++;
                }

                if (sector == "V")
                {
                    counterV++;
                }

                if (sector == "G")
                {
                    counterG++;
                }
            }

            double porcentA = counterA / fens * 100;
            double porcentB = counterB / fens * 100;
            double porcentV = counterV / fens * 100;
            double porcentG = counterG / fens * 100;
            double porcent = fens / capacity * 100;

            Console.WriteLine($"{porcentA:f2}%");
            Console.WriteLine($"{porcentB:f2}%");
            Console.WriteLine($"{porcentV:f2}%");
            Console.WriteLine($"{porcentG:f2}%");
            Console.WriteLine($"{porcent:f2}%");
        }
    }
}
