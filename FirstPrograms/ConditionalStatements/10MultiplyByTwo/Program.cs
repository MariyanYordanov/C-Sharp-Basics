using System;

namespace _10MultiplyByTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            for (double i = double.Parse(Console.ReadLine()); i >= 0; i = double.Parse(Console.ReadLine()))
            {
                Console.WriteLine($"Result: {(i * 2):f2}");
            }
            Console.WriteLine("Negative number!");
        }
    }
}