using System;

namespace _005._Divide_Without_Remainder
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double counter1 = 0;
            double counter2 = 0;
            double counter3 = 0;

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num % 2 == 0)
                {
                    counter1++;
                }
                if (num % 3 == 0)
                {
                    counter2++;
                }
                if (num % 4 == 0)
                {
                    counter3++;
                }
            }

            double p1 = counter1 / n * 100;
            double p2 = counter2 / n * 100;
            double p3 = counter3 / n * 100;

            Console.WriteLine($"{p1:f2}%");
            Console.WriteLine($"{p2:f2}%");
            Console.WriteLine($"{p3:f2}%");
            
        }
    }
}
