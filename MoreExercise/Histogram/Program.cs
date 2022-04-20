using System;

namespace _04._Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int counter1 = 0;
            int counter2 = 0;
            int counter3 = 0;
            int counter4 = 0;
            int counter5 = 0;

            for (int i = 0; i < num; i++)
            {
                int numbers = int.Parse(Console.ReadLine());
                if (numbers < 200)
                {
                    counter1++;
                }
                else if (numbers < 400)
                {
                    counter2++;
                }
                else if (numbers < 600)
                {
                    counter3++;
                }
                else if (numbers < 800)
                {
                    counter4++;
                }
                else if (numbers >= 800)
                {
                    counter5++;
                }
            }
            double counter = counter1 + counter2 + counter3 + counter4 + counter5;
            double p1 = counter1 / counter * 100;
            double p2 = counter2 / counter * 100;
            double p3 = counter3 / counter * 100;
            double p4 = counter4 / counter * 100;
            double p5 = counter5 / counter * 100;

            Console.WriteLine($"{p1:f2}%");
            Console.WriteLine($"{p2:f2}%");
            Console.WriteLine($"{p3:f2}%");
            Console.WriteLine($"{p4:f2}%");
            Console.WriteLine($"{p5:f2}%");
        }
    }
}
