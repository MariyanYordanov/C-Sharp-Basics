using System;

namespace _04._Even_Powers_of_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            double num = 0;

            for (int i = 0; i <= n; i+=2)
            {
                Console.WriteLine(Math.Pow(2, num));
                num += 2;
            }

        }
    }
}
