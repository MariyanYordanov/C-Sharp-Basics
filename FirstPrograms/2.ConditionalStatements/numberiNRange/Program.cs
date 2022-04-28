using System;

namespace numberiNRange
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte number = sbyte.Parse(Console.ReadLine());

            if (number >= -100 && number <= 100 && number != 0)
            {
                Console.WriteLine("Yes");
            }
            else 
            {
                Console.WriteLine("No");
            }
        }
    }
}
