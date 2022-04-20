using System;

namespace _04._Trekking_Mania
{
    class Program
    {
        static void Main(string[] args)
        {
            double numberOfGrups = int.Parse(Console.ReadLine());
            
            double counterMusala = 0;
            double counterMontBlanc = 0;
            double counterKilimanjaro = 0;
            double counterK2 = 0;
            double counterEverest = 0;

            for (int i = 1; i <= numberOfGrups; i++)
            {
                double peopleInGrup = int.Parse(Console.ReadLine());

                if (peopleInGrup <= 5)
                {
                    counterMusala += peopleInGrup;
                }
                else if (peopleInGrup <= 12)
                {
                    counterMontBlanc += peopleInGrup;
                }
                else if (peopleInGrup <= 25)
                {
                    counterKilimanjaro += peopleInGrup;
                }
                else if (peopleInGrup <= 40)
                {
                    counterK2 += peopleInGrup;
                }
                else if (peopleInGrup > 40)
                {
                    counterEverest += peopleInGrup;
                }
            }

            double total = counterMusala + counterMontBlanc + counterKilimanjaro + counterK2 + counterEverest;
            double porcentMusala = counterMusala / total * 100;
            double porcentMontBlanc = counterMontBlanc / total * 100;
            double porcentKilimanjaro = counterKilimanjaro / total * 100;
            double porcentK2 = counterK2 / total * 100;
            double porcentEverest = counterEverest / total * 100;

            Console.WriteLine($"{porcentMusala:f2}%");
            Console.WriteLine($"{porcentMontBlanc:f2}%");
            Console.WriteLine($"{porcentKilimanjaro:f2}%");
            Console.WriteLine($"{porcentK2:f2}%");
            Console.WriteLine($"{porcentEverest:f2}%");
        }
    }
}
