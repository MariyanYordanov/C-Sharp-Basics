using System;

namespace _05._Division_Without_Remainder
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double counter2 = 0;
            double counter3 = 0;
            double counter4 = 0;
            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (number % 2 == 0)
                {
                    counter2++;
                }
                if (number % 3 == 0)
                {
                    counter3++;
                }
                if (number % 4 == 0)
                {
                    counter4++;
                }
            }
            double p1 = counter2 / n * 100;
            double p2 = counter3 / n * 100;
            double p3 = counter4 / n * 100;

            Console.WriteLine($"{p1:f2}%");
            Console.WriteLine($"{p2:f2}%");
            Console.WriteLine($"{p3:f2}%");
        }
    }
}
